// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX44 
    {
        public class Email : Message
        {
            public const string MsgType = "C";

            public Email() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("C"));
            }



        }
    }
}
