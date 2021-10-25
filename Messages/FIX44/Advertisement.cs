// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX44 
    {
        public class Advertisement : Message
        {
            public const string MsgType = "7";

            public Advertisement() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("7"));
            }



        }
    }
}
