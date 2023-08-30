// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX44 
    {
        public class TradeCaptureReport : Message
        {
            public const string MsgType = "AE";

            public TradeCaptureReport() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("AE"));
            }

            public TradeCaptureReport(
                    QuickFix.Fields.TradeReportID aTradeReportID,
                    QuickFix.Fields.PreviouslyReported aPreviouslyReported,
                    QuickFix.Fields.LastQty aLastQty,
                    QuickFix.Fields.LastPx aLastPx,
                    QuickFix.Fields.TradeDate aTradeDate,
                    QuickFix.Fields.TransactTime aTransactTime
                ) : this()
            {
                this.TradeReportID = aTradeReportID;
                this.PreviouslyReported = aPreviouslyReported;
                this.LastQty = aLastQty;
                this.LastPx = aLastPx;
                this.TradeDate = aTradeDate;
                this.TransactTime = aTransactTime;
            }

            public QuickFix.Fields.TradeReportID TradeReportID
            { 
                get 
                {
                    QuickFix.Fields.TradeReportID val = new QuickFix.Fields.TradeReportID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradeReportID val) 
            { 
                this.TradeReportID = val;
            }
            
            public QuickFix.Fields.TradeReportID Get(QuickFix.Fields.TradeReportID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradeReportID val) 
            { 
                return IsSetTradeReportID();
            }
            
            public bool IsSetTradeReportID() 
            { 
                return IsSetField(Tags.TradeReportID);
            }
            public QuickFix.Fields.TradeReportTransType TradeReportTransType
            { 
                get 
                {
                    QuickFix.Fields.TradeReportTransType val = new QuickFix.Fields.TradeReportTransType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradeReportTransType val) 
            { 
                this.TradeReportTransType = val;
            }
            
            public QuickFix.Fields.TradeReportTransType Get(QuickFix.Fields.TradeReportTransType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradeReportTransType val) 
            { 
                return IsSetTradeReportTransType();
            }
            
            public bool IsSetTradeReportTransType() 
            { 
                return IsSetField(Tags.TradeReportTransType);
            }
            public QuickFix.Fields.TradeReportType TradeReportType
            { 
                get 
                {
                    QuickFix.Fields.TradeReportType val = new QuickFix.Fields.TradeReportType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradeReportType val) 
            { 
                this.TradeReportType = val;
            }
            
            public QuickFix.Fields.TradeReportType Get(QuickFix.Fields.TradeReportType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradeReportType val) 
            { 
                return IsSetTradeReportType();
            }
            
            public bool IsSetTradeReportType() 
            { 
                return IsSetField(Tags.TradeReportType);
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
            public QuickFix.Fields.TrdType TrdType
            { 
                get 
                {
                    QuickFix.Fields.TrdType val = new QuickFix.Fields.TrdType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TrdType val) 
            { 
                this.TrdType = val;
            }
            
            public QuickFix.Fields.TrdType Get(QuickFix.Fields.TrdType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TrdType val) 
            { 
                return IsSetTrdType();
            }
            
            public bool IsSetTrdType() 
            { 
                return IsSetField(Tags.TrdType);
            }
            public QuickFix.Fields.OrigTradeID OrigTradeID
            { 
                get 
                {
                    QuickFix.Fields.OrigTradeID val = new QuickFix.Fields.OrigTradeID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OrigTradeID val) 
            { 
                this.OrigTradeID = val;
            }
            
            public QuickFix.Fields.OrigTradeID Get(QuickFix.Fields.OrigTradeID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OrigTradeID val) 
            { 
                return IsSetOrigTradeID();
            }
            
            public bool IsSetOrigTradeID() 
            { 
                return IsSetField(Tags.OrigTradeID);
            }
            public QuickFix.Fields.ExecType ExecType
            { 
                get 
                {
                    QuickFix.Fields.ExecType val = new QuickFix.Fields.ExecType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ExecType val) 
            { 
                this.ExecType = val;
            }
            
            public QuickFix.Fields.ExecType Get(QuickFix.Fields.ExecType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ExecType val) 
            { 
                return IsSetExecType();
            }
            
            public bool IsSetExecType() 
            { 
                return IsSetField(Tags.ExecType);
            }
            public QuickFix.Fields.TradeLinkID TradeLinkID
            { 
                get 
                {
                    QuickFix.Fields.TradeLinkID val = new QuickFix.Fields.TradeLinkID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradeLinkID val) 
            { 
                this.TradeLinkID = val;
            }
            
            public QuickFix.Fields.TradeLinkID Get(QuickFix.Fields.TradeLinkID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradeLinkID val) 
            { 
                return IsSetTradeLinkID();
            }
            
            public bool IsSetTradeLinkID() 
            { 
                return IsSetField(Tags.TradeLinkID);
            }
            public QuickFix.Fields.GroupIndicator GroupIndicator
            { 
                get 
                {
                    QuickFix.Fields.GroupIndicator val = new QuickFix.Fields.GroupIndicator();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.GroupIndicator val) 
            { 
                this.GroupIndicator = val;
            }
            
            public QuickFix.Fields.GroupIndicator Get(QuickFix.Fields.GroupIndicator val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.GroupIndicator val) 
            { 
                return IsSetGroupIndicator();
            }
            
            public bool IsSetGroupIndicator() 
            { 
                return IsSetField(Tags.GroupIndicator);
            }
            public QuickFix.Fields.TradeLinkMktID TradeLinkMktID
            { 
                get 
                {
                    QuickFix.Fields.TradeLinkMktID val = new QuickFix.Fields.TradeLinkMktID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradeLinkMktID val) 
            { 
                this.TradeLinkMktID = val;
            }
            
            public QuickFix.Fields.TradeLinkMktID Get(QuickFix.Fields.TradeLinkMktID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradeLinkMktID val) 
            { 
                return IsSetTradeLinkMktID();
            }
            
            public bool IsSetTradeLinkMktID() 
            { 
                return IsSetField(Tags.TradeLinkMktID);
            }
            public QuickFix.Fields.ExecID ExecID
            { 
                get 
                {
                    QuickFix.Fields.ExecID val = new QuickFix.Fields.ExecID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ExecID val) 
            { 
                this.ExecID = val;
            }
            
            public QuickFix.Fields.ExecID Get(QuickFix.Fields.ExecID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ExecID val) 
            { 
                return IsSetExecID();
            }
            
            public bool IsSetExecID() 
            { 
                return IsSetField(Tags.ExecID);
            }
            public QuickFix.Fields.OrdStatus OrdStatus
            { 
                get 
                {
                    QuickFix.Fields.OrdStatus val = new QuickFix.Fields.OrdStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OrdStatus val) 
            { 
                this.OrdStatus = val;
            }
            
            public QuickFix.Fields.OrdStatus Get(QuickFix.Fields.OrdStatus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OrdStatus val) 
            { 
                return IsSetOrdStatus();
            }
            
            public bool IsSetOrdStatus() 
            { 
                return IsSetField(Tags.OrdStatus);
            }
            public QuickFix.Fields.PreviouslyReported PreviouslyReported
            { 
                get 
                {
                    QuickFix.Fields.PreviouslyReported val = new QuickFix.Fields.PreviouslyReported();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PreviouslyReported val) 
            { 
                this.PreviouslyReported = val;
            }
            
            public QuickFix.Fields.PreviouslyReported Get(QuickFix.Fields.PreviouslyReported val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PreviouslyReported val) 
            { 
                return IsSetPreviouslyReported();
            }
            
            public bool IsSetPreviouslyReported() 
            { 
                return IsSetField(Tags.PreviouslyReported);
            }
            public QuickFix.Fields.Symbol Symbol
            { 
                get 
                {
                    QuickFix.Fields.Symbol val = new QuickFix.Fields.Symbol();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Symbol val) 
            { 
                this.Symbol = val;
            }
            
            public QuickFix.Fields.Symbol Get(QuickFix.Fields.Symbol val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Symbol val) 
            { 
                return IsSetSymbol();
            }
            
            public bool IsSetSymbol() 
            { 
                return IsSetField(Tags.Symbol);
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
            public QuickFix.Fields.SecurityIDSource SecurityIDSource
            { 
                get 
                {
                    QuickFix.Fields.SecurityIDSource val = new QuickFix.Fields.SecurityIDSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityIDSource val) 
            { 
                this.SecurityIDSource = val;
            }
            
            public QuickFix.Fields.SecurityIDSource Get(QuickFix.Fields.SecurityIDSource val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityIDSource val) 
            { 
                return IsSetSecurityIDSource();
            }
            
            public bool IsSetSecurityIDSource() 
            { 
                return IsSetField(Tags.SecurityIDSource);
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
            public QuickFix.Fields.StrikePrice StrikePrice
            { 
                get 
                {
                    QuickFix.Fields.StrikePrice val = new QuickFix.Fields.StrikePrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StrikePrice val) 
            { 
                this.StrikePrice = val;
            }
            
            public QuickFix.Fields.StrikePrice Get(QuickFix.Fields.StrikePrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StrikePrice val) 
            { 
                return IsSetStrikePrice();
            }
            
            public bool IsSetStrikePrice() 
            { 
                return IsSetField(Tags.StrikePrice);
            }
            public QuickFix.Fields.OptionsSymbol OptionsSymbol
            { 
                get 
                {
                    QuickFix.Fields.OptionsSymbol val = new QuickFix.Fields.OptionsSymbol();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OptionsSymbol val) 
            { 
                this.OptionsSymbol = val;
            }
            
            public QuickFix.Fields.OptionsSymbol Get(QuickFix.Fields.OptionsSymbol val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OptionsSymbol val) 
            { 
                return IsSetOptionsSymbol();
            }
            
            public bool IsSetOptionsSymbol() 
            { 
                return IsSetField(Tags.OptionsSymbol);
            }
            public QuickFix.Fields.SecurityExchange SecurityExchange
            { 
                get 
                {
                    QuickFix.Fields.SecurityExchange val = new QuickFix.Fields.SecurityExchange();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityExchange val) 
            { 
                this.SecurityExchange = val;
            }
            
            public QuickFix.Fields.SecurityExchange Get(QuickFix.Fields.SecurityExchange val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityExchange val) 
            { 
                return IsSetSecurityExchange();
            }
            
            public bool IsSetSecurityExchange() 
            { 
                return IsSetField(Tags.SecurityExchange);
            }
            public QuickFix.Fields.ExchangeSilo ExchangeSilo
            { 
                get 
                {
                    QuickFix.Fields.ExchangeSilo val = new QuickFix.Fields.ExchangeSilo();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ExchangeSilo val) 
            { 
                this.ExchangeSilo = val;
            }
            
            public QuickFix.Fields.ExchangeSilo Get(QuickFix.Fields.ExchangeSilo val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ExchangeSilo val) 
            { 
                return IsSetExchangeSilo();
            }
            
            public bool IsSetExchangeSilo() 
            { 
                return IsSetField(Tags.ExchangeSilo);
            }
            public QuickFix.Fields.StartDate StartDate
            { 
                get 
                {
                    QuickFix.Fields.StartDate val = new QuickFix.Fields.StartDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StartDate val) 
            { 
                this.StartDate = val;
            }
            
            public QuickFix.Fields.StartDate Get(QuickFix.Fields.StartDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StartDate val) 
            { 
                return IsSetStartDate();
            }
            
            public bool IsSetStartDate() 
            { 
                return IsSetField(Tags.StartDate);
            }
            public QuickFix.Fields.EndDate EndDate
            { 
                get 
                {
                    QuickFix.Fields.EndDate val = new QuickFix.Fields.EndDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EndDate val) 
            { 
                this.EndDate = val;
            }
            
            public QuickFix.Fields.EndDate Get(QuickFix.Fields.EndDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EndDate val) 
            { 
                return IsSetEndDate();
            }
            
            public bool IsSetEndDate() 
            { 
                return IsSetField(Tags.EndDate);
            }
            public QuickFix.Fields.DeliveryStartDate DeliveryStartDate
            { 
                get 
                {
                    QuickFix.Fields.DeliveryStartDate val = new QuickFix.Fields.DeliveryStartDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DeliveryStartDate val) 
            { 
                this.DeliveryStartDate = val;
            }
            
            public QuickFix.Fields.DeliveryStartDate Get(QuickFix.Fields.DeliveryStartDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DeliveryStartDate val) 
            { 
                return IsSetDeliveryStartDate();
            }
            
            public bool IsSetDeliveryStartDate() 
            { 
                return IsSetField(Tags.DeliveryStartDate);
            }
            public QuickFix.Fields.DeliveryEndDate DeliveryEndDate
            { 
                get 
                {
                    QuickFix.Fields.DeliveryEndDate val = new QuickFix.Fields.DeliveryEndDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DeliveryEndDate val) 
            { 
                this.DeliveryEndDate = val;
            }
            
            public QuickFix.Fields.DeliveryEndDate Get(QuickFix.Fields.DeliveryEndDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DeliveryEndDate val) 
            { 
                return IsSetDeliveryEndDate();
            }
            
            public bool IsSetDeliveryEndDate() 
            { 
                return IsSetField(Tags.DeliveryEndDate);
            }
            public QuickFix.Fields.LocationCode LocationCode
            { 
                get 
                {
                    QuickFix.Fields.LocationCode val = new QuickFix.Fields.LocationCode();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LocationCode val) 
            { 
                this.LocationCode = val;
            }
            
            public QuickFix.Fields.LocationCode Get(QuickFix.Fields.LocationCode val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LocationCode val) 
            { 
                return IsSetLocationCode();
            }
            
            public bool IsSetLocationCode() 
            { 
                return IsSetField(Tags.LocationCode);
            }
            public QuickFix.Fields.MeterNumber MeterNumber
            { 
                get 
                {
                    QuickFix.Fields.MeterNumber val = new QuickFix.Fields.MeterNumber();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MeterNumber val) 
            { 
                this.MeterNumber = val;
            }
            
            public QuickFix.Fields.MeterNumber Get(QuickFix.Fields.MeterNumber val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MeterNumber val) 
            { 
                return IsSetMeterNumber();
            }
            
            public bool IsSetMeterNumber() 
            { 
                return IsSetField(Tags.MeterNumber);
            }
            public QuickFix.Fields.LeadTime LeadTime
            { 
                get 
                {
                    QuickFix.Fields.LeadTime val = new QuickFix.Fields.LeadTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LeadTime val) 
            { 
                this.LeadTime = val;
            }
            
            public QuickFix.Fields.LeadTime Get(QuickFix.Fields.LeadTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LeadTime val) 
            { 
                return IsSetLeadTime();
            }
            
            public bool IsSetLeadTime() 
            { 
                return IsSetField(Tags.LeadTime);
            }
            public QuickFix.Fields.ReasonCode ReasonCode
            { 
                get 
                {
                    QuickFix.Fields.ReasonCode val = new QuickFix.Fields.ReasonCode();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ReasonCode val) 
            { 
                this.ReasonCode = val;
            }
            
            public QuickFix.Fields.ReasonCode Get(QuickFix.Fields.ReasonCode val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ReasonCode val) 
            { 
                return IsSetReasonCode();
            }
            
            public bool IsSetReasonCode() 
            { 
                return IsSetField(Tags.ReasonCode);
            }
            public QuickFix.Fields.LastQty LastQty
            { 
                get 
                {
                    QuickFix.Fields.LastQty val = new QuickFix.Fields.LastQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LastQty val) 
            { 
                this.LastQty = val;
            }
            
            public QuickFix.Fields.LastQty Get(QuickFix.Fields.LastQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LastQty val) 
            { 
                return IsSetLastQty();
            }
            
            public bool IsSetLastQty() 
            { 
                return IsSetField(Tags.LastQty);
            }
            public QuickFix.Fields.LastPx LastPx
            { 
                get 
                {
                    QuickFix.Fields.LastPx val = new QuickFix.Fields.LastPx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LastPx val) 
            { 
                this.LastPx = val;
            }
            
            public QuickFix.Fields.LastPx Get(QuickFix.Fields.LastPx val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LastPx val) 
            { 
                return IsSetLastPx();
            }
            
            public bool IsSetLastPx() 
            { 
                return IsSetField(Tags.LastPx);
            }
            public QuickFix.Fields.LastParPx LastParPx
            { 
                get 
                {
                    QuickFix.Fields.LastParPx val = new QuickFix.Fields.LastParPx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LastParPx val) 
            { 
                this.LastParPx = val;
            }
            
            public QuickFix.Fields.LastParPx Get(QuickFix.Fields.LastParPx val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LastParPx val) 
            { 
                return IsSetLastParPx();
            }
            
            public bool IsSetLastParPx() 
            { 
                return IsSetField(Tags.LastParPx);
            }
            public QuickFix.Fields.PriceType PriceType
            { 
                get 
                {
                    QuickFix.Fields.PriceType val = new QuickFix.Fields.PriceType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PriceType val) 
            { 
                this.PriceType = val;
            }
            
            public QuickFix.Fields.PriceType Get(QuickFix.Fields.PriceType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PriceType val) 
            { 
                return IsSetPriceType();
            }
            
            public bool IsSetPriceType() 
            { 
                return IsSetField(Tags.PriceType);
            }
            public QuickFix.Fields.BenchmarkPrice BenchmarkPrice
            { 
                get 
                {
                    QuickFix.Fields.BenchmarkPrice val = new QuickFix.Fields.BenchmarkPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.BenchmarkPrice val) 
            { 
                this.BenchmarkPrice = val;
            }
            
            public QuickFix.Fields.BenchmarkPrice Get(QuickFix.Fields.BenchmarkPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.BenchmarkPrice val) 
            { 
                return IsSetBenchmarkPrice();
            }
            
            public bool IsSetBenchmarkPrice() 
            { 
                return IsSetField(Tags.BenchmarkPrice);
            }
            public QuickFix.Fields.BenchmarkPriceType BenchmarkPriceType
            { 
                get 
                {
                    QuickFix.Fields.BenchmarkPriceType val = new QuickFix.Fields.BenchmarkPriceType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.BenchmarkPriceType val) 
            { 
                this.BenchmarkPriceType = val;
            }
            
            public QuickFix.Fields.BenchmarkPriceType Get(QuickFix.Fields.BenchmarkPriceType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.BenchmarkPriceType val) 
            { 
                return IsSetBenchmarkPriceType();
            }
            
            public bool IsSetBenchmarkPriceType() 
            { 
                return IsSetField(Tags.BenchmarkPriceType);
            }
            public QuickFix.Fields.NumOfLots NumOfLots
            { 
                get 
                {
                    QuickFix.Fields.NumOfLots val = new QuickFix.Fields.NumOfLots();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NumOfLots val) 
            { 
                this.NumOfLots = val;
            }
            
            public QuickFix.Fields.NumOfLots Get(QuickFix.Fields.NumOfLots val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NumOfLots val) 
            { 
                return IsSetNumOfLots();
            }
            
            public bool IsSetNumOfLots() 
            { 
                return IsSetField(Tags.NumOfLots);
            }
            public QuickFix.Fields.NumOfCycles NumOfCycles
            { 
                get 
                {
                    QuickFix.Fields.NumOfCycles val = new QuickFix.Fields.NumOfCycles();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NumOfCycles val) 
            { 
                this.NumOfCycles = val;
            }
            
            public QuickFix.Fields.NumOfCycles Get(QuickFix.Fields.NumOfCycles val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NumOfCycles val) 
            { 
                return IsSetNumOfCycles();
            }
            
            public bool IsSetNumOfCycles() 
            { 
                return IsSetField(Tags.NumOfCycles);
            }
            public QuickFix.Fields.TradeDate TradeDate
            { 
                get 
                {
                    QuickFix.Fields.TradeDate val = new QuickFix.Fields.TradeDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradeDate val) 
            { 
                this.TradeDate = val;
            }
            
            public QuickFix.Fields.TradeDate Get(QuickFix.Fields.TradeDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradeDate val) 
            { 
                return IsSetTradeDate();
            }
            
            public bool IsSetTradeDate() 
            { 
                return IsSetField(Tags.TradeDate);
            }
            public QuickFix.Fields.TransactTime TransactTime
            { 
                get 
                {
                    QuickFix.Fields.TransactTime val = new QuickFix.Fields.TransactTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TransactTime val) 
            { 
                this.TransactTime = val;
            }
            
            public QuickFix.Fields.TransactTime Get(QuickFix.Fields.TransactTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TransactTime val) 
            { 
                return IsSetTransactTime();
            }
            
            public bool IsSetTransactTime() 
            { 
                return IsSetField(Tags.TransactTime);
            }
            public QuickFix.Fields.ClientAppType ClientAppType
            { 
                get 
                {
                    QuickFix.Fields.ClientAppType val = new QuickFix.Fields.ClientAppType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ClientAppType val) 
            { 
                this.ClientAppType = val;
            }
            
            public QuickFix.Fields.ClientAppType Get(QuickFix.Fields.ClientAppType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ClientAppType val) 
            { 
                return IsSetClientAppType();
            }
            
            public bool IsSetClientAppType() 
            { 
                return IsSetField(Tags.ClientAppType);
            }
            public QuickFix.Fields.SecuritySubType SecuritySubType
            { 
                get 
                {
                    QuickFix.Fields.SecuritySubType val = new QuickFix.Fields.SecuritySubType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecuritySubType val) 
            { 
                this.SecuritySubType = val;
            }
            
            public QuickFix.Fields.SecuritySubType Get(QuickFix.Fields.SecuritySubType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecuritySubType val) 
            { 
                return IsSetSecuritySubType();
            }
            
            public bool IsSetSecuritySubType() 
            { 
                return IsSetField(Tags.SecuritySubType);
            }
            public QuickFix.Fields.SequenceWithinMillis SequenceWithinMillis
            { 
                get 
                {
                    QuickFix.Fields.SequenceWithinMillis val = new QuickFix.Fields.SequenceWithinMillis();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SequenceWithinMillis val) 
            { 
                this.SequenceWithinMillis = val;
            }
            
            public QuickFix.Fields.SequenceWithinMillis Get(QuickFix.Fields.SequenceWithinMillis val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SequenceWithinMillis val) 
            { 
                return IsSetSequenceWithinMillis();
            }
            
            public bool IsSetSequenceWithinMillis() 
            { 
                return IsSetField(Tags.SequenceWithinMillis);
            }
            public QuickFix.Fields.Currency Currency
            { 
                get 
                {
                    QuickFix.Fields.Currency val = new QuickFix.Fields.Currency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Currency val) 
            { 
                this.Currency = val;
            }
            
            public QuickFix.Fields.Currency Get(QuickFix.Fields.Currency val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Currency val) 
            { 
                return IsSetCurrency();
            }
            
            public bool IsSetCurrency() 
            { 
                return IsSetField(Tags.Currency);
            }
            public QuickFix.Fields.Revenue Revenue
            { 
                get 
                {
                    QuickFix.Fields.Revenue val = new QuickFix.Fields.Revenue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Revenue val) 
            { 
                this.Revenue = val;
            }
            
            public QuickFix.Fields.Revenue Get(QuickFix.Fields.Revenue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Revenue val) 
            { 
                return IsSetRevenue();
            }
            
            public bool IsSetRevenue() 
            { 
                return IsSetField(Tags.Revenue);
            }
            public QuickFix.Fields.Contract Contract
            { 
                get 
                {
                    QuickFix.Fields.Contract val = new QuickFix.Fields.Contract();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Contract val) 
            { 
                this.Contract = val;
            }
            
            public QuickFix.Fields.Contract Get(QuickFix.Fields.Contract val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Contract val) 
            { 
                return IsSetContract();
            }
            
            public bool IsSetContract() 
            { 
                return IsSetField(Tags.Contract);
            }
            public QuickFix.Fields.GeneralTerms GeneralTerms
            { 
                get 
                {
                    QuickFix.Fields.GeneralTerms val = new QuickFix.Fields.GeneralTerms();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.GeneralTerms val) 
            { 
                this.GeneralTerms = val;
            }
            
            public QuickFix.Fields.GeneralTerms Get(QuickFix.Fields.GeneralTerms val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.GeneralTerms val) 
            { 
                return IsSetGeneralTerms();
            }
            
            public bool IsSetGeneralTerms() 
            { 
                return IsSetField(Tags.GeneralTerms);
            }
            public QuickFix.Fields.NoCombiDefinitions NoCombiDefinitions
            { 
                get 
                {
                    QuickFix.Fields.NoCombiDefinitions val = new QuickFix.Fields.NoCombiDefinitions();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoCombiDefinitions val) 
            { 
                this.NoCombiDefinitions = val;
            }
            
            public QuickFix.Fields.NoCombiDefinitions Get(QuickFix.Fields.NoCombiDefinitions val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoCombiDefinitions val) 
            { 
                return IsSetNoCombiDefinitions();
            }
            
            public bool IsSetNoCombiDefinitions() 
            { 
                return IsSetField(Tags.NoCombiDefinitions);
            }
            public QuickFix.Fields.TermsQualityComments TermsQualityComments
            { 
                get 
                {
                    QuickFix.Fields.TermsQualityComments val = new QuickFix.Fields.TermsQualityComments();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TermsQualityComments val) 
            { 
                this.TermsQualityComments = val;
            }
            
            public QuickFix.Fields.TermsQualityComments Get(QuickFix.Fields.TermsQualityComments val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TermsQualityComments val) 
            { 
                return IsSetTermsQualityComments();
            }
            
            public bool IsSetTermsQualityComments() 
            { 
                return IsSetField(Tags.TermsQualityComments);
            }
            public QuickFix.Fields.WaiverIndicator WaiverIndicator
            { 
                get 
                {
                    QuickFix.Fields.WaiverIndicator val = new QuickFix.Fields.WaiverIndicator();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.WaiverIndicator val) 
            { 
                this.WaiverIndicator = val;
            }
            
            public QuickFix.Fields.WaiverIndicator Get(QuickFix.Fields.WaiverIndicator val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.WaiverIndicator val) 
            { 
                return IsSetWaiverIndicator();
            }
            
            public bool IsSetWaiverIndicator() 
            { 
                return IsSetField(Tags.WaiverIndicator);
            }
            public QuickFix.Fields.DirectElectronicAccess DirectElectronicAccess
            { 
                get 
                {
                    QuickFix.Fields.DirectElectronicAccess val = new QuickFix.Fields.DirectElectronicAccess();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DirectElectronicAccess val) 
            { 
                this.DirectElectronicAccess = val;
            }
            
            public QuickFix.Fields.DirectElectronicAccess Get(QuickFix.Fields.DirectElectronicAccess val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DirectElectronicAccess val) 
            { 
                return IsSetDirectElectronicAccess();
            }
            
            public bool IsSetDirectElectronicAccess() 
            { 
                return IsSetField(Tags.DirectElectronicAccess);
            }
            public QuickFix.Fields.TradingCapacity TradingCapacity
            { 
                get 
                {
                    QuickFix.Fields.TradingCapacity val = new QuickFix.Fields.TradingCapacity();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradingCapacity val) 
            { 
                this.TradingCapacity = val;
            }
            
            public QuickFix.Fields.TradingCapacity Get(QuickFix.Fields.TradingCapacity val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradingCapacity val) 
            { 
                return IsSetTradingCapacity();
            }
            
            public bool IsSetTradingCapacity() 
            { 
                return IsSetField(Tags.TradingCapacity);
            }
            public QuickFix.Fields.LiquidityProvision LiquidityProvision
            { 
                get 
                {
                    QuickFix.Fields.LiquidityProvision val = new QuickFix.Fields.LiquidityProvision();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LiquidityProvision val) 
            { 
                this.LiquidityProvision = val;
            }
            
            public QuickFix.Fields.LiquidityProvision Get(QuickFix.Fields.LiquidityProvision val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LiquidityProvision val) 
            { 
                return IsSetLiquidityProvision();
            }
            
            public bool IsSetLiquidityProvision() 
            { 
                return IsSetField(Tags.LiquidityProvision);
            }
            public QuickFix.Fields.CommodityDerivIndicator CommodityDerivIndicator
            { 
                get 
                {
                    QuickFix.Fields.CommodityDerivIndicator val = new QuickFix.Fields.CommodityDerivIndicator();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CommodityDerivIndicator val) 
            { 
                this.CommodityDerivIndicator = val;
            }
            
            public QuickFix.Fields.CommodityDerivIndicator Get(QuickFix.Fields.CommodityDerivIndicator val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CommodityDerivIndicator val) 
            { 
                return IsSetCommodityDerivIndicator();
            }
            
            public bool IsSetCommodityDerivIndicator() 
            { 
                return IsSetField(Tags.CommodityDerivIndicator);
            }
            public QuickFix.Fields.InvestmentDecision InvestmentDecision
            { 
                get 
                {
                    QuickFix.Fields.InvestmentDecision val = new QuickFix.Fields.InvestmentDecision();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.InvestmentDecision val) 
            { 
                this.InvestmentDecision = val;
            }
            
            public QuickFix.Fields.InvestmentDecision Get(QuickFix.Fields.InvestmentDecision val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.InvestmentDecision val) 
            { 
                return IsSetInvestmentDecision();
            }
            
            public bool IsSetInvestmentDecision() 
            { 
                return IsSetField(Tags.InvestmentDecision);
            }
            public QuickFix.Fields.ExecutionDecision ExecutionDecision
            { 
                get 
                {
                    QuickFix.Fields.ExecutionDecision val = new QuickFix.Fields.ExecutionDecision();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ExecutionDecision val) 
            { 
                this.ExecutionDecision = val;
            }
            
            public QuickFix.Fields.ExecutionDecision Get(QuickFix.Fields.ExecutionDecision val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ExecutionDecision val) 
            { 
                return IsSetExecutionDecision();
            }
            
            public bool IsSetExecutionDecision() 
            { 
                return IsSetField(Tags.ExecutionDecision);
            }
            public QuickFix.Fields.ClientIDCode ClientIDCode
            { 
                get 
                {
                    QuickFix.Fields.ClientIDCode val = new QuickFix.Fields.ClientIDCode();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ClientIDCode val) 
            { 
                this.ClientIDCode = val;
            }
            
            public QuickFix.Fields.ClientIDCode Get(QuickFix.Fields.ClientIDCode val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ClientIDCode val) 
            { 
                return IsSetClientIDCode();
            }
            
            public bool IsSetClientIDCode() 
            { 
                return IsSetField(Tags.ClientIDCode);
            }
            public QuickFix.Fields.MiFIDID MiFIDID
            { 
                get 
                {
                    QuickFix.Fields.MiFIDID val = new QuickFix.Fields.MiFIDID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MiFIDID val) 
            { 
                this.MiFIDID = val;
            }
            
            public QuickFix.Fields.MiFIDID Get(QuickFix.Fields.MiFIDID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MiFIDID val) 
            { 
                return IsSetMiFIDID();
            }
            
            public bool IsSetMiFIDID() 
            { 
                return IsSetField(Tags.MiFIDID);
            }
            public QuickFix.Fields.CDIOverride CDIOverride
            { 
                get 
                {
                    QuickFix.Fields.CDIOverride val = new QuickFix.Fields.CDIOverride();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CDIOverride val) 
            { 
                this.CDIOverride = val;
            }
            
            public QuickFix.Fields.CDIOverride Get(QuickFix.Fields.CDIOverride val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CDIOverride val) 
            { 
                return IsSetCDIOverride();
            }
            
            public bool IsSetCDIOverride() 
            { 
                return IsSetField(Tags.CDIOverride);
            }
            public QuickFix.Fields.DealAdjustIndicator DealAdjustIndicator
            { 
                get 
                {
                    QuickFix.Fields.DealAdjustIndicator val = new QuickFix.Fields.DealAdjustIndicator();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DealAdjustIndicator val) 
            { 
                this.DealAdjustIndicator = val;
            }
            
            public QuickFix.Fields.DealAdjustIndicator Get(QuickFix.Fields.DealAdjustIndicator val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DealAdjustIndicator val) 
            { 
                return IsSetDealAdjustIndicator();
            }
            
            public bool IsSetDealAdjustIndicator() 
            { 
                return IsSetField(Tags.DealAdjustIndicator);
            }
            public QuickFix.Fields.SelfMatchPreventionID SelfMatchPreventionID
            { 
                get 
                {
                    QuickFix.Fields.SelfMatchPreventionID val = new QuickFix.Fields.SelfMatchPreventionID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SelfMatchPreventionID val) 
            { 
                this.SelfMatchPreventionID = val;
            }
            
            public QuickFix.Fields.SelfMatchPreventionID Get(QuickFix.Fields.SelfMatchPreventionID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SelfMatchPreventionID val) 
            { 
                return IsSetSelfMatchPreventionID();
            }
            
            public bool IsSetSelfMatchPreventionID() 
            { 
                return IsSetField(Tags.SelfMatchPreventionID);
            }
            public QuickFix.Fields.SelfMatchPreventionInstruction SelfMatchPreventionInstruction
            { 
                get 
                {
                    QuickFix.Fields.SelfMatchPreventionInstruction val = new QuickFix.Fields.SelfMatchPreventionInstruction();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SelfMatchPreventionInstruction val) 
            { 
                this.SelfMatchPreventionInstruction = val;
            }
            
            public QuickFix.Fields.SelfMatchPreventionInstruction Get(QuickFix.Fields.SelfMatchPreventionInstruction val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SelfMatchPreventionInstruction val) 
            { 
                return IsSetSelfMatchPreventionInstruction();
            }
            
            public bool IsSetSelfMatchPreventionInstruction() 
            { 
                return IsSetField(Tags.SelfMatchPreventionInstruction);
            }
            public QuickFix.Fields.QuantityMax QuantityMax
            { 
                get 
                {
                    QuickFix.Fields.QuantityMax val = new QuickFix.Fields.QuantityMax();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.QuantityMax val) 
            { 
                this.QuantityMax = val;
            }
            
            public QuickFix.Fields.QuantityMax Get(QuickFix.Fields.QuantityMax val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.QuantityMax val) 
            { 
                return IsSetQuantityMax();
            }
            
            public bool IsSetQuantityMax() 
            { 
                return IsSetField(Tags.QuantityMax);
            }
            public QuickFix.Fields.PlattsMinQuantity PlattsMinQuantity
            { 
                get 
                {
                    QuickFix.Fields.PlattsMinQuantity val = new QuickFix.Fields.PlattsMinQuantity();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PlattsMinQuantity val) 
            { 
                this.PlattsMinQuantity = val;
            }
            
            public QuickFix.Fields.PlattsMinQuantity Get(QuickFix.Fields.PlattsMinQuantity val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PlattsMinQuantity val) 
            { 
                return IsSetPlattsMinQuantity();
            }
            
            public bool IsSetPlattsMinQuantity() 
            { 
                return IsSetField(Tags.PlattsMinQuantity);
            }
            public QuickFix.Fields.PlattsMaxQuantity PlattsMaxQuantity
            { 
                get 
                {
                    QuickFix.Fields.PlattsMaxQuantity val = new QuickFix.Fields.PlattsMaxQuantity();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PlattsMaxQuantity val) 
            { 
                this.PlattsMaxQuantity = val;
            }
            
            public QuickFix.Fields.PlattsMaxQuantity Get(QuickFix.Fields.PlattsMaxQuantity val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PlattsMaxQuantity val) 
            { 
                return IsSetPlattsMaxQuantity();
            }
            
            public bool IsSetPlattsMaxQuantity() 
            { 
                return IsSetField(Tags.PlattsMaxQuantity);
            }
            public QuickFix.Fields.OptolPriceBasis OptolPriceBasis
            { 
                get 
                {
                    QuickFix.Fields.OptolPriceBasis val = new QuickFix.Fields.OptolPriceBasis();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OptolPriceBasis val) 
            { 
                this.OptolPriceBasis = val;
            }
            
            public QuickFix.Fields.OptolPriceBasis Get(QuickFix.Fields.OptolPriceBasis val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OptolPriceBasis val) 
            { 
                return IsSetOptolPriceBasis();
            }
            
            public bool IsSetOptolPriceBasis() 
            { 
                return IsSetField(Tags.OptolPriceBasis);
            }
            public QuickFix.Fields.PlattsTerms PlattsTerms
            { 
                get 
                {
                    QuickFix.Fields.PlattsTerms val = new QuickFix.Fields.PlattsTerms();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PlattsTerms val) 
            { 
                this.PlattsTerms = val;
            }
            
            public QuickFix.Fields.PlattsTerms Get(QuickFix.Fields.PlattsTerms val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PlattsTerms val) 
            { 
                return IsSetPlattsTerms();
            }
            
            public bool IsSetPlattsTerms() 
            { 
                return IsSetField(Tags.PlattsTerms);
            }
            public QuickFix.Fields.OptolPriceBasisSubLevel OptolPriceBasisSubLevel
            { 
                get 
                {
                    QuickFix.Fields.OptolPriceBasisSubLevel val = new QuickFix.Fields.OptolPriceBasisSubLevel();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OptolPriceBasisSubLevel val) 
            { 
                this.OptolPriceBasisSubLevel = val;
            }
            
            public QuickFix.Fields.OptolPriceBasisSubLevel Get(QuickFix.Fields.OptolPriceBasisSubLevel val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OptolPriceBasisSubLevel val) 
            { 
                return IsSetOptolPriceBasisSubLevel();
            }
            
            public bool IsSetOptolPriceBasisSubLevel() 
            { 
                return IsSetField(Tags.OptolPriceBasisSubLevel);
            }
            public QuickFix.Fields.OptolPrice OptolPrice
            { 
                get 
                {
                    QuickFix.Fields.OptolPrice val = new QuickFix.Fields.OptolPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OptolPrice val) 
            { 
                this.OptolPrice = val;
            }
            
            public QuickFix.Fields.OptolPrice Get(QuickFix.Fields.OptolPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OptolPrice val) 
            { 
                return IsSetOptolPrice();
            }
            
            public bool IsSetOptolPrice() 
            { 
                return IsSetField(Tags.OptolPrice);
            }
            public QuickFix.Fields.NoSides NoSides
            { 
                get 
                {
                    QuickFix.Fields.NoSides val = new QuickFix.Fields.NoSides();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoSides val) 
            { 
                this.NoSides = val;
            }
            
            public QuickFix.Fields.NoSides Get(QuickFix.Fields.NoSides val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoSides val) 
            { 
                return IsSetNoSides();
            }
            
            public bool IsSetNoSides() 
            { 
                return IsSetField(Tags.NoSides);
            }
            public QuickFix.Fields.NoLegs NoLegs
            { 
                get 
                {
                    QuickFix.Fields.NoLegs val = new QuickFix.Fields.NoLegs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoLegs val) 
            { 
                this.NoLegs = val;
            }
            
            public QuickFix.Fields.NoLegs Get(QuickFix.Fields.NoLegs val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoLegs val) 
            { 
                return IsSetNoLegs();
            }
            
            public bool IsSetNoLegs() 
            { 
                return IsSetField(Tags.NoLegs);
            }
            public class NoCombiDefinitionsGroup : Group
            {
                public static int[] fieldOrder = {Tags.CombiPercentage, Tags.CombiPriceBasis, Tags.CombiPriceBasisPeriod, Tags.CombiPriceBasisSubLevel, Tags.CombiLegPrice, 0};
            
                public NoCombiDefinitionsGroup() 
                  :base( Tags.NoCombiDefinitions, Tags.CombiPercentage, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoCombiDefinitionsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                public QuickFix.Fields.CombiPercentage CombiPercentage
                { 
                    get 
                    {
                        QuickFix.Fields.CombiPercentage val = new QuickFix.Fields.CombiPercentage();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.CombiPercentage val) 
                { 
                    this.CombiPercentage = val;
                }
                
                public QuickFix.Fields.CombiPercentage Get(QuickFix.Fields.CombiPercentage val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.CombiPercentage val) 
                { 
                    return IsSetCombiPercentage();
                }
                
                public bool IsSetCombiPercentage() 
                { 
                    return IsSetField(Tags.CombiPercentage);
                }
                public QuickFix.Fields.CombiPriceBasis CombiPriceBasis
                { 
                    get 
                    {
                        QuickFix.Fields.CombiPriceBasis val = new QuickFix.Fields.CombiPriceBasis();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.CombiPriceBasis val) 
                { 
                    this.CombiPriceBasis = val;
                }
                
                public QuickFix.Fields.CombiPriceBasis Get(QuickFix.Fields.CombiPriceBasis val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.CombiPriceBasis val) 
                { 
                    return IsSetCombiPriceBasis();
                }
                
                public bool IsSetCombiPriceBasis() 
                { 
                    return IsSetField(Tags.CombiPriceBasis);
                }
                public QuickFix.Fields.CombiPriceBasisPeriod CombiPriceBasisPeriod
                { 
                    get 
                    {
                        QuickFix.Fields.CombiPriceBasisPeriod val = new QuickFix.Fields.CombiPriceBasisPeriod();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.CombiPriceBasisPeriod val) 
                { 
                    this.CombiPriceBasisPeriod = val;
                }
                
                public QuickFix.Fields.CombiPriceBasisPeriod Get(QuickFix.Fields.CombiPriceBasisPeriod val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.CombiPriceBasisPeriod val) 
                { 
                    return IsSetCombiPriceBasisPeriod();
                }
                
                public bool IsSetCombiPriceBasisPeriod() 
                { 
                    return IsSetField(Tags.CombiPriceBasisPeriod);
                }
                public QuickFix.Fields.CombiPriceBasisSubLevel CombiPriceBasisSubLevel
                { 
                    get 
                    {
                        QuickFix.Fields.CombiPriceBasisSubLevel val = new QuickFix.Fields.CombiPriceBasisSubLevel();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.CombiPriceBasisSubLevel val) 
                { 
                    this.CombiPriceBasisSubLevel = val;
                }
                
                public QuickFix.Fields.CombiPriceBasisSubLevel Get(QuickFix.Fields.CombiPriceBasisSubLevel val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.CombiPriceBasisSubLevel val) 
                { 
                    return IsSetCombiPriceBasisSubLevel();
                }
                
                public bool IsSetCombiPriceBasisSubLevel() 
                { 
                    return IsSetField(Tags.CombiPriceBasisSubLevel);
                }
                public QuickFix.Fields.CombiLegPrice CombiLegPrice
                { 
                    get 
                    {
                        QuickFix.Fields.CombiLegPrice val = new QuickFix.Fields.CombiLegPrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.CombiLegPrice val) 
                { 
                    this.CombiLegPrice = val;
                }
                
                public QuickFix.Fields.CombiLegPrice Get(QuickFix.Fields.CombiLegPrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.CombiLegPrice val) 
                { 
                    return IsSetCombiLegPrice();
                }
                
                public bool IsSetCombiLegPrice() 
                { 
                    return IsSetField(Tags.CombiLegPrice);
                }
            
            }
            public class NoSidesGroup : Group
            {
                public static int[] fieldOrder = {Tags.Side, Tags.OrderID, Tags.ClOrdID, Tags.NoPartyIDs, Tags.ComplianceID, Tags.CustOrderHandlingInst, Tags.PositionEffect, Tags.MemoField, Tags.TransactDetails, Tags.CrossExecutionType, Tags.Text, Tags.NoAllocs, 0};
            
                public NoSidesGroup() 
                  :base( Tags.NoSides, Tags.Side, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoSidesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                public QuickFix.Fields.Side Side
                { 
                    get 
                    {
                        QuickFix.Fields.Side val = new QuickFix.Fields.Side();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.Side val) 
                { 
                    this.Side = val;
                }
                
                public QuickFix.Fields.Side Get(QuickFix.Fields.Side val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.Side val) 
                { 
                    return IsSetSide();
                }
                
                public bool IsSetSide() 
                { 
                    return IsSetField(Tags.Side);
                }
                public QuickFix.Fields.OrderID OrderID
                { 
                    get 
                    {
                        QuickFix.Fields.OrderID val = new QuickFix.Fields.OrderID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.OrderID val) 
                { 
                    this.OrderID = val;
                }
                
                public QuickFix.Fields.OrderID Get(QuickFix.Fields.OrderID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.OrderID val) 
                { 
                    return IsSetOrderID();
                }
                
                public bool IsSetOrderID() 
                { 
                    return IsSetField(Tags.OrderID);
                }
                public QuickFix.Fields.ClOrdID ClOrdID
                { 
                    get 
                    {
                        QuickFix.Fields.ClOrdID val = new QuickFix.Fields.ClOrdID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ClOrdID val) 
                { 
                    this.ClOrdID = val;
                }
                
                public QuickFix.Fields.ClOrdID Get(QuickFix.Fields.ClOrdID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ClOrdID val) 
                { 
                    return IsSetClOrdID();
                }
                
                public bool IsSetClOrdID() 
                { 
                    return IsSetField(Tags.ClOrdID);
                }
                public QuickFix.Fields.NoPartyIDs NoPartyIDs
                { 
                    get 
                    {
                        QuickFix.Fields.NoPartyIDs val = new QuickFix.Fields.NoPartyIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoPartyIDs val) 
                { 
                    this.NoPartyIDs = val;
                }
                
                public QuickFix.Fields.NoPartyIDs Get(QuickFix.Fields.NoPartyIDs val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoPartyIDs val) 
                { 
                    return IsSetNoPartyIDs();
                }
                
                public bool IsSetNoPartyIDs() 
                { 
                    return IsSetField(Tags.NoPartyIDs);
                }
                public QuickFix.Fields.ComplianceID ComplianceID
                { 
                    get 
                    {
                        QuickFix.Fields.ComplianceID val = new QuickFix.Fields.ComplianceID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ComplianceID val) 
                { 
                    this.ComplianceID = val;
                }
                
                public QuickFix.Fields.ComplianceID Get(QuickFix.Fields.ComplianceID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ComplianceID val) 
                { 
                    return IsSetComplianceID();
                }
                
                public bool IsSetComplianceID() 
                { 
                    return IsSetField(Tags.ComplianceID);
                }
                public QuickFix.Fields.CustOrderHandlingInst CustOrderHandlingInst
                { 
                    get 
                    {
                        QuickFix.Fields.CustOrderHandlingInst val = new QuickFix.Fields.CustOrderHandlingInst();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.CustOrderHandlingInst val) 
                { 
                    this.CustOrderHandlingInst = val;
                }
                
                public QuickFix.Fields.CustOrderHandlingInst Get(QuickFix.Fields.CustOrderHandlingInst val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.CustOrderHandlingInst val) 
                { 
                    return IsSetCustOrderHandlingInst();
                }
                
                public bool IsSetCustOrderHandlingInst() 
                { 
                    return IsSetField(Tags.CustOrderHandlingInst);
                }
                public QuickFix.Fields.PositionEffect PositionEffect
                { 
                    get 
                    {
                        QuickFix.Fields.PositionEffect val = new QuickFix.Fields.PositionEffect();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PositionEffect val) 
                { 
                    this.PositionEffect = val;
                }
                
                public QuickFix.Fields.PositionEffect Get(QuickFix.Fields.PositionEffect val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PositionEffect val) 
                { 
                    return IsSetPositionEffect();
                }
                
                public bool IsSetPositionEffect() 
                { 
                    return IsSetField(Tags.PositionEffect);
                }
                public QuickFix.Fields.MemoField MemoField
                { 
                    get 
                    {
                        QuickFix.Fields.MemoField val = new QuickFix.Fields.MemoField();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MemoField val) 
                { 
                    this.MemoField = val;
                }
                
                public QuickFix.Fields.MemoField Get(QuickFix.Fields.MemoField val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MemoField val) 
                { 
                    return IsSetMemoField();
                }
                
                public bool IsSetMemoField() 
                { 
                    return IsSetField(Tags.MemoField);
                }
                public QuickFix.Fields.TransactDetails TransactDetails
                { 
                    get 
                    {
                        QuickFix.Fields.TransactDetails val = new QuickFix.Fields.TransactDetails();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TransactDetails val) 
                { 
                    this.TransactDetails = val;
                }
                
                public QuickFix.Fields.TransactDetails Get(QuickFix.Fields.TransactDetails val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TransactDetails val) 
                { 
                    return IsSetTransactDetails();
                }
                
                public bool IsSetTransactDetails() 
                { 
                    return IsSetField(Tags.TransactDetails);
                }
                public QuickFix.Fields.CrossExecutionType CrossExecutionType
                { 
                    get 
                    {
                        QuickFix.Fields.CrossExecutionType val = new QuickFix.Fields.CrossExecutionType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.CrossExecutionType val) 
                { 
                    this.CrossExecutionType = val;
                }
                
                public QuickFix.Fields.CrossExecutionType Get(QuickFix.Fields.CrossExecutionType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.CrossExecutionType val) 
                { 
                    return IsSetCrossExecutionType();
                }
                
                public bool IsSetCrossExecutionType() 
                { 
                    return IsSetField(Tags.CrossExecutionType);
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
                public QuickFix.Fields.NoAllocs NoAllocs
                { 
                    get 
                    {
                        QuickFix.Fields.NoAllocs val = new QuickFix.Fields.NoAllocs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoAllocs val) 
                { 
                    this.NoAllocs = val;
                }
                
                public QuickFix.Fields.NoAllocs Get(QuickFix.Fields.NoAllocs val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoAllocs val) 
                { 
                    return IsSetNoAllocs();
                }
                
                public bool IsSetNoAllocs() 
                { 
                    return IsSetField(Tags.NoAllocs);
                }
                            public class NoPartyIDsGroup : Group
                {
                    public static int[] fieldOrder = {Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, 0};
                
                    public NoPartyIDsGroup() 
                      :base( Tags.NoPartyIDs, Tags.PartyID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoPartyIDsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                    public QuickFix.Fields.PartyID PartyID
                    { 
                        get 
                        {
                            QuickFix.Fields.PartyID val = new QuickFix.Fields.PartyID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.PartyID val) 
                    { 
                        this.PartyID = val;
                    }
                    
                    public QuickFix.Fields.PartyID Get(QuickFix.Fields.PartyID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.PartyID val) 
                    { 
                        return IsSetPartyID();
                    }
                    
                    public bool IsSetPartyID() 
                    { 
                        return IsSetField(Tags.PartyID);
                    }
                    public QuickFix.Fields.PartyIDSource PartyIDSource
                    { 
                        get 
                        {
                            QuickFix.Fields.PartyIDSource val = new QuickFix.Fields.PartyIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.PartyIDSource val) 
                    { 
                        this.PartyIDSource = val;
                    }
                    
                    public QuickFix.Fields.PartyIDSource Get(QuickFix.Fields.PartyIDSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.PartyIDSource val) 
                    { 
                        return IsSetPartyIDSource();
                    }
                    
                    public bool IsSetPartyIDSource() 
                    { 
                        return IsSetField(Tags.PartyIDSource);
                    }
                    public QuickFix.Fields.PartyRole PartyRole
                    { 
                        get 
                        {
                            QuickFix.Fields.PartyRole val = new QuickFix.Fields.PartyRole();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.PartyRole val) 
                    { 
                        this.PartyRole = val;
                    }
                    
                    public QuickFix.Fields.PartyRole Get(QuickFix.Fields.PartyRole val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.PartyRole val) 
                    { 
                        return IsSetPartyRole();
                    }
                    
                    public bool IsSetPartyRole() 
                    { 
                        return IsSetField(Tags.PartyRole);
                    }
                
                }
                public class NoAllocsGroup : Group
                {
                    public static int[] fieldOrder = {Tags.AllocAccount, Tags.NoNested2PartyIDs, 0};
                
                    public NoAllocsGroup() 
                      :base( Tags.NoAllocs, Tags.AllocAccount, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoAllocsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                    public QuickFix.Fields.AllocAccount AllocAccount
                    { 
                        get 
                        {
                            QuickFix.Fields.AllocAccount val = new QuickFix.Fields.AllocAccount();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.AllocAccount val) 
                    { 
                        this.AllocAccount = val;
                    }
                    
                    public QuickFix.Fields.AllocAccount Get(QuickFix.Fields.AllocAccount val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.AllocAccount val) 
                    { 
                        return IsSetAllocAccount();
                    }
                    
                    public bool IsSetAllocAccount() 
                    { 
                        return IsSetField(Tags.AllocAccount);
                    }
                    public QuickFix.Fields.NoNested2PartyIDs NoNested2PartyIDs
                    { 
                        get 
                        {
                            QuickFix.Fields.NoNested2PartyIDs val = new QuickFix.Fields.NoNested2PartyIDs();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoNested2PartyIDs val) 
                    { 
                        this.NoNested2PartyIDs = val;
                    }
                    
                    public QuickFix.Fields.NoNested2PartyIDs Get(QuickFix.Fields.NoNested2PartyIDs val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoNested2PartyIDs val) 
                    { 
                        return IsSetNoNested2PartyIDs();
                    }
                    
                    public bool IsSetNoNested2PartyIDs() 
                    { 
                        return IsSetField(Tags.NoNested2PartyIDs);
                    }
                                    public class NoNested2PartyIDsGroup : Group
                    {
                        public static int[] fieldOrder = {Tags.Nested2PartyID, Tags.Nested2PartyIDSource, Tags.Nested2PartyRole, 0};
                    
                        public NoNested2PartyIDsGroup() 
                          :base( Tags.NoNested2PartyIDs, Tags.Nested2PartyID, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoNested2PartyIDsGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                        public QuickFix.Fields.Nested2PartyID Nested2PartyID
                        { 
                            get 
                            {
                                QuickFix.Fields.Nested2PartyID val = new QuickFix.Fields.Nested2PartyID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.Nested2PartyID val) 
                        { 
                            this.Nested2PartyID = val;
                        }
                        
                        public QuickFix.Fields.Nested2PartyID Get(QuickFix.Fields.Nested2PartyID val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.Nested2PartyID val) 
                        { 
                            return IsSetNested2PartyID();
                        }
                        
                        public bool IsSetNested2PartyID() 
                        { 
                            return IsSetField(Tags.Nested2PartyID);
                        }
                        public QuickFix.Fields.Nested2PartyIDSource Nested2PartyIDSource
                        { 
                            get 
                            {
                                QuickFix.Fields.Nested2PartyIDSource val = new QuickFix.Fields.Nested2PartyIDSource();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.Nested2PartyIDSource val) 
                        { 
                            this.Nested2PartyIDSource = val;
                        }
                        
                        public QuickFix.Fields.Nested2PartyIDSource Get(QuickFix.Fields.Nested2PartyIDSource val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.Nested2PartyIDSource val) 
                        { 
                            return IsSetNested2PartyIDSource();
                        }
                        
                        public bool IsSetNested2PartyIDSource() 
                        { 
                            return IsSetField(Tags.Nested2PartyIDSource);
                        }
                        public QuickFix.Fields.Nested2PartyRole Nested2PartyRole
                        { 
                            get 
                            {
                                QuickFix.Fields.Nested2PartyRole val = new QuickFix.Fields.Nested2PartyRole();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.Nested2PartyRole val) 
                        { 
                            this.Nested2PartyRole = val;
                        }
                        
                        public QuickFix.Fields.Nested2PartyRole Get(QuickFix.Fields.Nested2PartyRole val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.Nested2PartyRole val) 
                        { 
                            return IsSetNested2PartyRole();
                        }
                        
                        public bool IsSetNested2PartyRole() 
                        { 
                            return IsSetField(Tags.Nested2PartyRole);
                        }
                    
                    }
                }
            }
            public class NoLegsGroup : Group
            {
                public static int[] fieldOrder = {Tags.LegSymbol, Tags.LegSecurityID, Tags.LegSecurityIDSource, Tags.LegCFICode, Tags.LegStrikePrice, Tags.LegOptionSymbol, Tags.LegSecurityExchange, Tags.LegSide, Tags.LegLastPx, Tags.LegParPx, Tags.LegQty, Tags.LegOptionDelta, Tags.LegRefID, Tags.LinkExecID, Tags.LegNumOfLots, Tags.LegNumOfCycles, Tags.LegStartDate, Tags.LegEndDate, Tags.LegMemoField, Tags.NoNestedPartyIDs, Tags.LegComplianceID, Tags.LegCustOrderHandlingInst, 0};
            
                public NoLegsGroup() 
                  :base( Tags.NoLegs, Tags.LegSymbol, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoLegsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                public QuickFix.Fields.LegSymbol LegSymbol
                { 
                    get 
                    {
                        QuickFix.Fields.LegSymbol val = new QuickFix.Fields.LegSymbol();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSymbol val) 
                { 
                    this.LegSymbol = val;
                }
                
                public QuickFix.Fields.LegSymbol Get(QuickFix.Fields.LegSymbol val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSymbol val) 
                { 
                    return IsSetLegSymbol();
                }
                
                public bool IsSetLegSymbol() 
                { 
                    return IsSetField(Tags.LegSymbol);
                }
                public QuickFix.Fields.LegSecurityID LegSecurityID
                { 
                    get 
                    {
                        QuickFix.Fields.LegSecurityID val = new QuickFix.Fields.LegSecurityID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSecurityID val) 
                { 
                    this.LegSecurityID = val;
                }
                
                public QuickFix.Fields.LegSecurityID Get(QuickFix.Fields.LegSecurityID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSecurityID val) 
                { 
                    return IsSetLegSecurityID();
                }
                
                public bool IsSetLegSecurityID() 
                { 
                    return IsSetField(Tags.LegSecurityID);
                }
                public QuickFix.Fields.LegSecurityIDSource LegSecurityIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.LegSecurityIDSource val = new QuickFix.Fields.LegSecurityIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSecurityIDSource val) 
                { 
                    this.LegSecurityIDSource = val;
                }
                
                public QuickFix.Fields.LegSecurityIDSource Get(QuickFix.Fields.LegSecurityIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSecurityIDSource val) 
                { 
                    return IsSetLegSecurityIDSource();
                }
                
                public bool IsSetLegSecurityIDSource() 
                { 
                    return IsSetField(Tags.LegSecurityIDSource);
                }
                public QuickFix.Fields.LegCFICode LegCFICode
                { 
                    get 
                    {
                        QuickFix.Fields.LegCFICode val = new QuickFix.Fields.LegCFICode();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegCFICode val) 
                { 
                    this.LegCFICode = val;
                }
                
                public QuickFix.Fields.LegCFICode Get(QuickFix.Fields.LegCFICode val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegCFICode val) 
                { 
                    return IsSetLegCFICode();
                }
                
                public bool IsSetLegCFICode() 
                { 
                    return IsSetField(Tags.LegCFICode);
                }
                public QuickFix.Fields.LegStrikePrice LegStrikePrice
                { 
                    get 
                    {
                        QuickFix.Fields.LegStrikePrice val = new QuickFix.Fields.LegStrikePrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegStrikePrice val) 
                { 
                    this.LegStrikePrice = val;
                }
                
                public QuickFix.Fields.LegStrikePrice Get(QuickFix.Fields.LegStrikePrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegStrikePrice val) 
                { 
                    return IsSetLegStrikePrice();
                }
                
                public bool IsSetLegStrikePrice() 
                { 
                    return IsSetField(Tags.LegStrikePrice);
                }
                public QuickFix.Fields.LegOptionSymbol LegOptionSymbol
                { 
                    get 
                    {
                        QuickFix.Fields.LegOptionSymbol val = new QuickFix.Fields.LegOptionSymbol();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegOptionSymbol val) 
                { 
                    this.LegOptionSymbol = val;
                }
                
                public QuickFix.Fields.LegOptionSymbol Get(QuickFix.Fields.LegOptionSymbol val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegOptionSymbol val) 
                { 
                    return IsSetLegOptionSymbol();
                }
                
                public bool IsSetLegOptionSymbol() 
                { 
                    return IsSetField(Tags.LegOptionSymbol);
                }
                public QuickFix.Fields.LegSecurityExchange LegSecurityExchange
                { 
                    get 
                    {
                        QuickFix.Fields.LegSecurityExchange val = new QuickFix.Fields.LegSecurityExchange();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSecurityExchange val) 
                { 
                    this.LegSecurityExchange = val;
                }
                
                public QuickFix.Fields.LegSecurityExchange Get(QuickFix.Fields.LegSecurityExchange val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSecurityExchange val) 
                { 
                    return IsSetLegSecurityExchange();
                }
                
                public bool IsSetLegSecurityExchange() 
                { 
                    return IsSetField(Tags.LegSecurityExchange);
                }
                public QuickFix.Fields.LegSide LegSide
                { 
                    get 
                    {
                        QuickFix.Fields.LegSide val = new QuickFix.Fields.LegSide();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSide val) 
                { 
                    this.LegSide = val;
                }
                
                public QuickFix.Fields.LegSide Get(QuickFix.Fields.LegSide val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSide val) 
                { 
                    return IsSetLegSide();
                }
                
                public bool IsSetLegSide() 
                { 
                    return IsSetField(Tags.LegSide);
                }
                public QuickFix.Fields.LegLastPx LegLastPx
                { 
                    get 
                    {
                        QuickFix.Fields.LegLastPx val = new QuickFix.Fields.LegLastPx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegLastPx val) 
                { 
                    this.LegLastPx = val;
                }
                
                public QuickFix.Fields.LegLastPx Get(QuickFix.Fields.LegLastPx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegLastPx val) 
                { 
                    return IsSetLegLastPx();
                }
                
                public bool IsSetLegLastPx() 
                { 
                    return IsSetField(Tags.LegLastPx);
                }
                public QuickFix.Fields.LegParPx LegParPx
                { 
                    get 
                    {
                        QuickFix.Fields.LegParPx val = new QuickFix.Fields.LegParPx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegParPx val) 
                { 
                    this.LegParPx = val;
                }
                
                public QuickFix.Fields.LegParPx Get(QuickFix.Fields.LegParPx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegParPx val) 
                { 
                    return IsSetLegParPx();
                }
                
                public bool IsSetLegParPx() 
                { 
                    return IsSetField(Tags.LegParPx);
                }
                public QuickFix.Fields.LegQty LegQty
                { 
                    get 
                    {
                        QuickFix.Fields.LegQty val = new QuickFix.Fields.LegQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegQty val) 
                { 
                    this.LegQty = val;
                }
                
                public QuickFix.Fields.LegQty Get(QuickFix.Fields.LegQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegQty val) 
                { 
                    return IsSetLegQty();
                }
                
                public bool IsSetLegQty() 
                { 
                    return IsSetField(Tags.LegQty);
                }
                public QuickFix.Fields.LegOptionDelta LegOptionDelta
                { 
                    get 
                    {
                        QuickFix.Fields.LegOptionDelta val = new QuickFix.Fields.LegOptionDelta();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegOptionDelta val) 
                { 
                    this.LegOptionDelta = val;
                }
                
                public QuickFix.Fields.LegOptionDelta Get(QuickFix.Fields.LegOptionDelta val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegOptionDelta val) 
                { 
                    return IsSetLegOptionDelta();
                }
                
                public bool IsSetLegOptionDelta() 
                { 
                    return IsSetField(Tags.LegOptionDelta);
                }
                public QuickFix.Fields.LegRefID LegRefID
                { 
                    get 
                    {
                        QuickFix.Fields.LegRefID val = new QuickFix.Fields.LegRefID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegRefID val) 
                { 
                    this.LegRefID = val;
                }
                
                public QuickFix.Fields.LegRefID Get(QuickFix.Fields.LegRefID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegRefID val) 
                { 
                    return IsSetLegRefID();
                }
                
                public bool IsSetLegRefID() 
                { 
                    return IsSetField(Tags.LegRefID);
                }
                public QuickFix.Fields.LinkExecID LinkExecID
                { 
                    get 
                    {
                        QuickFix.Fields.LinkExecID val = new QuickFix.Fields.LinkExecID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LinkExecID val) 
                { 
                    this.LinkExecID = val;
                }
                
                public QuickFix.Fields.LinkExecID Get(QuickFix.Fields.LinkExecID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LinkExecID val) 
                { 
                    return IsSetLinkExecID();
                }
                
                public bool IsSetLinkExecID() 
                { 
                    return IsSetField(Tags.LinkExecID);
                }
                public QuickFix.Fields.LegNumOfLots LegNumOfLots
                { 
                    get 
                    {
                        QuickFix.Fields.LegNumOfLots val = new QuickFix.Fields.LegNumOfLots();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegNumOfLots val) 
                { 
                    this.LegNumOfLots = val;
                }
                
                public QuickFix.Fields.LegNumOfLots Get(QuickFix.Fields.LegNumOfLots val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegNumOfLots val) 
                { 
                    return IsSetLegNumOfLots();
                }
                
                public bool IsSetLegNumOfLots() 
                { 
                    return IsSetField(Tags.LegNumOfLots);
                }
                public QuickFix.Fields.LegNumOfCycles LegNumOfCycles
                { 
                    get 
                    {
                        QuickFix.Fields.LegNumOfCycles val = new QuickFix.Fields.LegNumOfCycles();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegNumOfCycles val) 
                { 
                    this.LegNumOfCycles = val;
                }
                
                public QuickFix.Fields.LegNumOfCycles Get(QuickFix.Fields.LegNumOfCycles val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegNumOfCycles val) 
                { 
                    return IsSetLegNumOfCycles();
                }
                
                public bool IsSetLegNumOfCycles() 
                { 
                    return IsSetField(Tags.LegNumOfCycles);
                }
                public QuickFix.Fields.LegStartDate LegStartDate
                { 
                    get 
                    {
                        QuickFix.Fields.LegStartDate val = new QuickFix.Fields.LegStartDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegStartDate val) 
                { 
                    this.LegStartDate = val;
                }
                
                public QuickFix.Fields.LegStartDate Get(QuickFix.Fields.LegStartDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegStartDate val) 
                { 
                    return IsSetLegStartDate();
                }
                
                public bool IsSetLegStartDate() 
                { 
                    return IsSetField(Tags.LegStartDate);
                }
                public QuickFix.Fields.LegEndDate LegEndDate
                { 
                    get 
                    {
                        QuickFix.Fields.LegEndDate val = new QuickFix.Fields.LegEndDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegEndDate val) 
                { 
                    this.LegEndDate = val;
                }
                
                public QuickFix.Fields.LegEndDate Get(QuickFix.Fields.LegEndDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegEndDate val) 
                { 
                    return IsSetLegEndDate();
                }
                
                public bool IsSetLegEndDate() 
                { 
                    return IsSetField(Tags.LegEndDate);
                }
                public QuickFix.Fields.LegMemoField LegMemoField
                { 
                    get 
                    {
                        QuickFix.Fields.LegMemoField val = new QuickFix.Fields.LegMemoField();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegMemoField val) 
                { 
                    this.LegMemoField = val;
                }
                
                public QuickFix.Fields.LegMemoField Get(QuickFix.Fields.LegMemoField val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegMemoField val) 
                { 
                    return IsSetLegMemoField();
                }
                
                public bool IsSetLegMemoField() 
                { 
                    return IsSetField(Tags.LegMemoField);
                }
                public QuickFix.Fields.NoNestedPartyIDs NoNestedPartyIDs
                { 
                    get 
                    {
                        QuickFix.Fields.NoNestedPartyIDs val = new QuickFix.Fields.NoNestedPartyIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoNestedPartyIDs val) 
                { 
                    this.NoNestedPartyIDs = val;
                }
                
                public QuickFix.Fields.NoNestedPartyIDs Get(QuickFix.Fields.NoNestedPartyIDs val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoNestedPartyIDs val) 
                { 
                    return IsSetNoNestedPartyIDs();
                }
                
                public bool IsSetNoNestedPartyIDs() 
                { 
                    return IsSetField(Tags.NoNestedPartyIDs);
                }
                public QuickFix.Fields.LegComplianceID LegComplianceID
                { 
                    get 
                    {
                        QuickFix.Fields.LegComplianceID val = new QuickFix.Fields.LegComplianceID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegComplianceID val) 
                { 
                    this.LegComplianceID = val;
                }
                
                public QuickFix.Fields.LegComplianceID Get(QuickFix.Fields.LegComplianceID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegComplianceID val) 
                { 
                    return IsSetLegComplianceID();
                }
                
                public bool IsSetLegComplianceID() 
                { 
                    return IsSetField(Tags.LegComplianceID);
                }
                public QuickFix.Fields.LegCustOrderHandlingInst LegCustOrderHandlingInst
                { 
                    get 
                    {
                        QuickFix.Fields.LegCustOrderHandlingInst val = new QuickFix.Fields.LegCustOrderHandlingInst();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegCustOrderHandlingInst val) 
                { 
                    this.LegCustOrderHandlingInst = val;
                }
                
                public QuickFix.Fields.LegCustOrderHandlingInst Get(QuickFix.Fields.LegCustOrderHandlingInst val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegCustOrderHandlingInst val) 
                { 
                    return IsSetLegCustOrderHandlingInst();
                }
                
                public bool IsSetLegCustOrderHandlingInst() 
                { 
                    return IsSetField(Tags.LegCustOrderHandlingInst);
                }
                            public class NoNestedPartyIDsGroup : Group
                {
                    public static int[] fieldOrder = {Tags.NestedPartyID, Tags.NestedPartyIDSource, Tags.NestedPartyRole, 0};
                
                    public NoNestedPartyIDsGroup() 
                      :base( Tags.NoNestedPartyIDs, Tags.NestedPartyID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoNestedPartyIDsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                    public QuickFix.Fields.NestedPartyID NestedPartyID
                    { 
                        get 
                        {
                            QuickFix.Fields.NestedPartyID val = new QuickFix.Fields.NestedPartyID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NestedPartyID val) 
                    { 
                        this.NestedPartyID = val;
                    }
                    
                    public QuickFix.Fields.NestedPartyID Get(QuickFix.Fields.NestedPartyID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NestedPartyID val) 
                    { 
                        return IsSetNestedPartyID();
                    }
                    
                    public bool IsSetNestedPartyID() 
                    { 
                        return IsSetField(Tags.NestedPartyID);
                    }
                    public QuickFix.Fields.NestedPartyIDSource NestedPartyIDSource
                    { 
                        get 
                        {
                            QuickFix.Fields.NestedPartyIDSource val = new QuickFix.Fields.NestedPartyIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NestedPartyIDSource val) 
                    { 
                        this.NestedPartyIDSource = val;
                    }
                    
                    public QuickFix.Fields.NestedPartyIDSource Get(QuickFix.Fields.NestedPartyIDSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NestedPartyIDSource val) 
                    { 
                        return IsSetNestedPartyIDSource();
                    }
                    
                    public bool IsSetNestedPartyIDSource() 
                    { 
                        return IsSetField(Tags.NestedPartyIDSource);
                    }
                    public QuickFix.Fields.NestedPartyRole NestedPartyRole
                    { 
                        get 
                        {
                            QuickFix.Fields.NestedPartyRole val = new QuickFix.Fields.NestedPartyRole();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NestedPartyRole val) 
                    { 
                        this.NestedPartyRole = val;
                    }
                    
                    public QuickFix.Fields.NestedPartyRole Get(QuickFix.Fields.NestedPartyRole val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NestedPartyRole val) 
                    { 
                        return IsSetNestedPartyRole();
                    }
                    
                    public bool IsSetNestedPartyRole() 
                    { 
                        return IsSetField(Tags.NestedPartyRole);
                    }
                
                }
            }
        }
    }
}
