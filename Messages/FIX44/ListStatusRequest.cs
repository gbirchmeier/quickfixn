// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX44 
    {
        public class ListStatusRequest : Message
        {
            public const string MsgType = "M";

            public ListStatusRequest() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("M"));
            }

            public ListStatusRequest(
                    QuickFix.Fields.ListID aListID
                ) : this()
            {
                this.ListID = aListID;
            }

            public QuickFix.Fields.ListID ListID
            { 
                get 
                {
                    QuickFix.Fields.ListID val = new QuickFix.Fields.ListID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ListID val) 
            { 
                this.ListID = val;
            }
            
            public QuickFix.Fields.ListID Get(QuickFix.Fields.ListID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ListID val) 
            { 
                return IsSetListID();
            }
            
            public bool IsSetListID() 
            { 
                return IsSetField(Tags.ListID);
            }
        }
    }
}
