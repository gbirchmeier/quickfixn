using System;
using QuickFix;
using QuickFix.Fields;
using System.Collections.Generic;

namespace TradeClient
{
    public class TradeClientApp : QuickFix.MessageCracker, QuickFix.IApplication
    {
        Session _session = null;

        // This variable is a kludge for developer test purposes.  Don't do this on a production application.
        public IInitiator MyInitiator = null;


        public void OnCreate(SessionID sessionID)
        {
            _session = Session.LookupSession(sessionID);
        }

        public void OnLogon(SessionID sessionID) { Console.WriteLine("Logon - " + sessionID.ToString()); }
        public void OnLogout(SessionID sessionID) { Console.WriteLine("Logout - " + sessionID.ToString()); }

        public void FromAdmin(Message message, SessionID sessionID) { }
        public void ToAdmin(Message message, SessionID sessionID) { }

        public void FromApp(Message message, SessionID sessionID)
        {
            Console.WriteLine("IN:  " + message.ToString());
            try
            {
                Crack(message, sessionID);
            }
            catch (Exception ex)
            {
                Console.WriteLine("==Cracker exception==");
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.StackTrace);
            }
        }

        public void ToApp(Message message, SessionID sessionID)
        {
            try
            {
                bool possDupFlag = false;
                if (message.Header.IsSetField(QuickFix.Fields.Tags.PossDupFlag))
                {
                    possDupFlag = QuickFix.Fields.Converters.BoolConverter.Convert(
                        message.Header.GetString(QuickFix.Fields.Tags.PossDupFlag)); /// FIXME
                }
                if (possDupFlag)
                    throw new DoNotSend();
            }
            catch (FieldNotFoundException)
            { }

            Console.WriteLine();
            Console.WriteLine("OUT: " + message.ToString());
        }


        public void OnMessage(QuickFix.FIX44.ExecutionReport m, SessionID s)
        {
            Console.WriteLine("Received execution report");
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    char action = QueryAction();
                    if (action == '1')
                        SendSecDef(false);
                    else if (action == '2')
                        SendSecDef(true);
                    else if (action == 'g')
                    {
                        if (this.MyInitiator.IsStopped)
                        {
                            Console.WriteLine("Restarting initiator...");
                            this.MyInitiator.Start();
                        }
                        else
                            Console.WriteLine("Already started.");
                    }
                    else if (action == 'x')
                    {
                        if (this.MyInitiator.IsStopped)
                            Console.WriteLine("Already stopped.");
                        else
                        {
                            Console.WriteLine("Stopping initiator...");
                            this.MyInitiator.Stop();
                        }
                    }
                    else if (action == 'q' || action == 'Q')
                        break;
                }
                catch (System.Exception e)
                {
                    Console.WriteLine("Message Not Sent: " + e.Message);
                    Console.WriteLine("StackTrace: " + e.StackTrace);
                }
            }
            Console.WriteLine("Program shutdown.");
        }

        private void SendMessage(Message m)
        {
            if (_session != null)
                _session.Send(m);
            else
            {
                // This probably won't ever happen.
                Console.WriteLine("Can't send message: session not created.");
            }
        }

        private char QueryAction()
        {
            // Commands 'g' and 'x' are intentionally hidden.
            Console.Write("\n"
                + "1) Send SecDef request with 321=3 (Securities) \n"
                + "2) Send SecDef request with 321=101 (Defined Strategies) \n"
                + "Q) Quit\n"
                + "Action: "
            );

            HashSet<string> validActions = new HashSet<string>("1,2,q,Q,g,x".Split(','));

            string cmd = Console.ReadLine().Trim();
            if (cmd.Length != 1 || validActions.Contains(cmd) == false)
                throw new System.Exception("Invalid action");

            return cmd.ToCharArray()[0];
        }

        private bool QueryConfirm(string query)
        {
            Console.WriteLine();
            Console.WriteLine(query + "?: ");
            string line = Console.ReadLine().Trim();
            return (line[0].Equals('y') || line[0].Equals('Y'));
        }

        public void SendSecDef(bool isUDS)
        {
            var reqType = SecurityRequestType.REQUEST_LIST_SECURITIES;
            if(isUDS)
                reqType = SecurityRequestType.REQUEST_LIST_OF_DEFINED_STRATEGIES;

            var msg = new QuickFix.FIX44.SecurityDefinitionRequest(
                new SecurityReqID("pants"),
                new SecurityRequestType(reqType)
            );
            SendMessage(msg);
        }

        public void OnMessage(QuickFix.FIX44.SecurityDefinition msg, SessionID s)
        {
            Console.WriteLine("Received a SecDef!");
        }

        public void OnMessage(QuickFix.FIX44.DefinedStrategy msg, SessionID s)
        {
            Console.WriteLine("Received a DefinedStrategy!");
        }
    }
}