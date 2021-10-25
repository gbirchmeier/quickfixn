// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX44 
    {
        public class TradeCaptureReportRequestAck : Message
        {
            public const string MsgType = "AQ";

            public TradeCaptureReportRequestAck() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("AQ"));
            }

            public TradeCaptureReportRequestAck(
                    QuickFix.Fields.TradeRequestID aTradeRequestID,
                    QuickFix.Fields.TradeRequestType aTradeRequestType,
                    QuickFix.Fields.TradeRequestResult aTradeRequestResult,
                    QuickFix.Fields.TradeRequestStatus aTradeRequestStatus
                ) : this()
            {
                this.TradeRequestID = aTradeRequestID;
                this.TradeRequestType = aTradeRequestType;
                this.TradeRequestResult = aTradeRequestResult;
                this.TradeRequestStatus = aTradeRequestStatus;
            }

            public QuickFix.Fields.TradeRequestID TradeRequestID
            { 
                get 
                {
                    QuickFix.Fields.TradeRequestID val = new QuickFix.Fields.TradeRequestID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradeRequestID val) 
            { 
                this.TradeRequestID = val;
            }
            
            public QuickFix.Fields.TradeRequestID Get(QuickFix.Fields.TradeRequestID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradeRequestID val) 
            { 
                return IsSetTradeRequestID();
            }
            
            public bool IsSetTradeRequestID() 
            { 
                return IsSetField(Tags.TradeRequestID);
            }
            public QuickFix.Fields.TradeRequestType TradeRequestType
            { 
                get 
                {
                    QuickFix.Fields.TradeRequestType val = new QuickFix.Fields.TradeRequestType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradeRequestType val) 
            { 
                this.TradeRequestType = val;
            }
            
            public QuickFix.Fields.TradeRequestType Get(QuickFix.Fields.TradeRequestType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradeRequestType val) 
            { 
                return IsSetTradeRequestType();
            }
            
            public bool IsSetTradeRequestType() 
            { 
                return IsSetField(Tags.TradeRequestType);
            }
            public QuickFix.Fields.TradeRequestResult TradeRequestResult
            { 
                get 
                {
                    QuickFix.Fields.TradeRequestResult val = new QuickFix.Fields.TradeRequestResult();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradeRequestResult val) 
            { 
                this.TradeRequestResult = val;
            }
            
            public QuickFix.Fields.TradeRequestResult Get(QuickFix.Fields.TradeRequestResult val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradeRequestResult val) 
            { 
                return IsSetTradeRequestResult();
            }
            
            public bool IsSetTradeRequestResult() 
            { 
                return IsSetField(Tags.TradeRequestResult);
            }
            public QuickFix.Fields.TradeRequestStatus TradeRequestStatus
            { 
                get 
                {
                    QuickFix.Fields.TradeRequestStatus val = new QuickFix.Fields.TradeRequestStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradeRequestStatus val) 
            { 
                this.TradeRequestStatus = val;
            }
            
            public QuickFix.Fields.TradeRequestStatus Get(QuickFix.Fields.TradeRequestStatus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradeRequestStatus val) 
            { 
                return IsSetTradeRequestStatus();
            }
            
            public bool IsSetTradeRequestStatus() 
            { 
                return IsSetField(Tags.TradeRequestStatus);
            }
            public QuickFix.Fields.CFICode CFICode
            { 
                get 
                {
                    QuickFix.Fields.CFICode val = new QuickFix.Fields.CFICode();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CFICode val) 
            { 
                this.CFICode = val;
            }
            
            public QuickFix.Fields.CFICode Get(QuickFix.Fields.CFICode val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CFICode val) 
            { 
                return IsSetCFICode();
            }
            
            public bool IsSetCFICode() 
            { 
                return IsSetField(Tags.CFICode);
            }
            public QuickFix.Fields.SecurityID SecurityID
            { 
                get 
                {
                    QuickFix.Fields.SecurityID val = new QuickFix.Fields.SecurityID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityID val) 
            { 
                this.SecurityID = val;
            }
            
            public QuickFix.Fields.SecurityID Get(QuickFix.Fields.SecurityID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityID val) 
            { 
                return IsSetSecurityID();
            }
            
            public bool IsSetSecurityID() 
            { 
                return IsSetField(Tags.SecurityID);
            }
            public QuickFix.Fields.NoUnderlyings NoUnderlyings
            { 
                get 
                {
                    QuickFix.Fields.NoUnderlyings val = new QuickFix.Fields.NoUnderlyings();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoUnderlyings val) 
            { 
                this.NoUnderlyings = val;
            }
            
            public QuickFix.Fields.NoUnderlyings Get(QuickFix.Fields.NoUnderlyings val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoUnderlyings val) 
            { 
                return IsSetNoUnderlyings();
            }
            
            public bool IsSetNoUnderlyings() 
            { 
                return IsSetField(Tags.NoUnderlyings);
            }
            public QuickFix.Fields.Text Text
            { 
                get 
                {
                    QuickFix.Fields.Text val = new QuickFix.Fields.Text();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Text val) 
            { 
                this.Text = val;
            }
            
            public QuickFix.Fields.Text Get(QuickFix.Fields.Text val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Text val) 
            { 
                return IsSetText();
            }
            
            public bool IsSetText() 
            { 
                return IsSetField(Tags.Text);
            }
            public class NoUnderlyingsGroup : Group
            {
                public static int[] fieldOrder = {Tags.UnderlyingSymbol, 0};
            
                public NoUnderlyingsGroup() 
                  :base( Tags.NoUnderlyings, Tags.UnderlyingSymbol, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoUnderlyingsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                public QuickFix.Fields.UnderlyingSymbol UnderlyingSymbol
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingSymbol val = new QuickFix.Fields.UnderlyingSymbol();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingSymbol val) 
                { 
                    this.UnderlyingSymbol = val;
                }
                
                public QuickFix.Fields.UnderlyingSymbol Get(QuickFix.Fields.UnderlyingSymbol val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingSymbol val) 
                { 
                    return IsSetUnderlyingSymbol();
                }
                
                public bool IsSetUnderlyingSymbol() 
                { 
                    return IsSetField(Tags.UnderlyingSymbol);
                }
            
            }
        }
    }
}
