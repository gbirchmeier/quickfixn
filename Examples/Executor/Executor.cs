using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32.SafeHandles;
using QuickFix;
using QuickFix.Fields;

namespace Executor
{
    public class Executor : QuickFix.MessageCracker, QuickFix.IApplication
    {
        public void FromApp(Message message, SessionID sessionID)
        {
            Console.WriteLine("IN:  " + message);
            Crack(message, sessionID);
        }

        public void ToApp(Message message, SessionID sessionID)
        {
            Console.WriteLine("OUT: " + message);
        }

        public void FromAdmin(Message message, SessionID sessionID) { }
        public void OnCreate(SessionID sessionID) { }
        public void OnLogout(SessionID sessionID) { }
        public void OnLogon(SessionID sessionID) { }
        public void ToAdmin(Message message, SessionID sessionID) { }


        public void OnMessage(QuickFix.FIX44.SecurityDefinitionRequest msg, SessionID s)
        {
            var reqType = msg.SecurityRequestType.getValue();
            switch(reqType){
                case 3:
                    SendSecDef(s, msg.SecurityReqID.getValue());
                    break;
                case 101:
                    SendUDS(s, msg.SecurityReqID.getValue());
                    break;
                default:
                    throw new IncorrectTagValue(SecurityRequestType.TAG);
            }
        }

        public void OnMessage(QuickFix.FIX44.News n, SessionID s) { }

        private int _respId = 0;

        private void SendSecDef(SessionID s, String reqId) {
            var msg = new QuickFix.FIX44.SecurityDefinition(
                new SecurityResponseID($"response-{_respId++}"),
                new SecurityResponseType(SecurityResponseType.LIST_OF_SECURITIES_RETURNED_PER_REQUEST),
                new SecurityReqID(reqId));
            Session.SendToTarget(msg, s);
        }

        private void SendUDS(SessionID s, String reqId) {
            var msg = new QuickFix.FIX44.DefinedStrategy(
                new SecurityResponseID($"response-{_respId++}"),
                new SecurityResponseType(SecurityResponseType.LIST_OF_SECURITIES_RETURNED_PER_REQUEST),
                new SecurityReqID(reqId));
            Session.SendToTarget(msg, s);
        }
    }
}