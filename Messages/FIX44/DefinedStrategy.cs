// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX44 
    {
        public class DefinedStrategy : Message
        {
            public const string MsgType = "UDS";

            public DefinedStrategy() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("UDS"));
            }

            public DefinedStrategy(
                    QuickFix.Fields.SecurityResponseID aSecurityResponseID,
                    QuickFix.Fields.SecurityResponseType aSecurityResponseType,
                    QuickFix.Fields.SecurityReqID aSecurityReqID
                ) : this()
            {
                this.SecurityResponseID = aSecurityResponseID;
                this.SecurityResponseType = aSecurityResponseType;
                this.SecurityReqID = aSecurityReqID;
            }

            public QuickFix.Fields.SecurityResponseID SecurityResponseID
            { 
                get 
                {
                    QuickFix.Fields.SecurityResponseID val = new QuickFix.Fields.SecurityResponseID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityResponseID val) 
            { 
                this.SecurityResponseID = val;
            }
            
            public QuickFix.Fields.SecurityResponseID Get(QuickFix.Fields.SecurityResponseID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityResponseID val) 
            { 
                return IsSetSecurityResponseID();
            }
            
            public bool IsSetSecurityResponseID() 
            { 
                return IsSetField(Tags.SecurityResponseID);
            }
            public QuickFix.Fields.SecurityResponseType SecurityResponseType
            { 
                get 
                {
                    QuickFix.Fields.SecurityResponseType val = new QuickFix.Fields.SecurityResponseType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityResponseType val) 
            { 
                this.SecurityResponseType = val;
            }
            
            public QuickFix.Fields.SecurityResponseType Get(QuickFix.Fields.SecurityResponseType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityResponseType val) 
            { 
                return IsSetSecurityResponseType();
            }
            
            public bool IsSetSecurityResponseType() 
            { 
                return IsSetField(Tags.SecurityResponseType);
            }
            public QuickFix.Fields.SecurityReqID SecurityReqID
            { 
                get 
                {
                    QuickFix.Fields.SecurityReqID val = new QuickFix.Fields.SecurityReqID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityReqID val) 
            { 
                this.SecurityReqID = val;
            }
            
            public QuickFix.Fields.SecurityReqID Get(QuickFix.Fields.SecurityReqID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityReqID val) 
            { 
                return IsSetSecurityReqID();
            }
            
            public bool IsSetSecurityReqID() 
            { 
                return IsSetField(Tags.SecurityReqID);
            }
            public QuickFix.Fields.MarketTypeID MarketTypeID
            { 
                get 
                {
                    QuickFix.Fields.MarketTypeID val = new QuickFix.Fields.MarketTypeID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MarketTypeID val) 
            { 
                this.MarketTypeID = val;
            }
            
            public QuickFix.Fields.MarketTypeID Get(QuickFix.Fields.MarketTypeID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MarketTypeID val) 
            { 
                return IsSetMarketTypeID();
            }
            
            public bool IsSetMarketTypeID() 
            { 
                return IsSetField(Tags.MarketTypeID);
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
            public QuickFix.Fields.StrategySecurityID StrategySecurityID
            { 
                get 
                {
                    QuickFix.Fields.StrategySecurityID val = new QuickFix.Fields.StrategySecurityID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StrategySecurityID val) 
            { 
                this.StrategySecurityID = val;
            }
            
            public QuickFix.Fields.StrategySecurityID Get(QuickFix.Fields.StrategySecurityID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StrategySecurityID val) 
            { 
                return IsSetStrategySecurityID();
            }
            
            public bool IsSetStrategySecurityID() 
            { 
                return IsSetField(Tags.StrategySecurityID);
            }
            public QuickFix.Fields.UnderlyingStrategySymbol UnderlyingStrategySymbol
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingStrategySymbol val = new QuickFix.Fields.UnderlyingStrategySymbol();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingStrategySymbol val) 
            { 
                this.UnderlyingStrategySymbol = val;
            }
            
            public QuickFix.Fields.UnderlyingStrategySymbol Get(QuickFix.Fields.UnderlyingStrategySymbol val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingStrategySymbol val) 
            { 
                return IsSetUnderlyingStrategySymbol();
            }
            
            public bool IsSetUnderlyingStrategySymbol() 
            { 
                return IsSetField(Tags.UnderlyingStrategySymbol);
            }
            public QuickFix.Fields.SecurityType SecurityType
            { 
                get 
                {
                    QuickFix.Fields.SecurityType val = new QuickFix.Fields.SecurityType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityType val) 
            { 
                this.SecurityType = val;
            }
            
            public QuickFix.Fields.SecurityType Get(QuickFix.Fields.SecurityType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityType val) 
            { 
                return IsSetSecurityType();
            }
            
            public bool IsSetSecurityType() 
            { 
                return IsSetField(Tags.SecurityType);
            }
            public QuickFix.Fields.MaturityDate MaturityDate
            { 
                get 
                {
                    QuickFix.Fields.MaturityDate val = new QuickFix.Fields.MaturityDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MaturityDate val) 
            { 
                this.MaturityDate = val;
            }
            
            public QuickFix.Fields.MaturityDate Get(QuickFix.Fields.MaturityDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MaturityDate val) 
            { 
                return IsSetMaturityDate();
            }
            
            public bool IsSetMaturityDate() 
            { 
                return IsSetField(Tags.MaturityDate);
            }
            public QuickFix.Fields.SecurityDesc SecurityDesc
            { 
                get 
                {
                    QuickFix.Fields.SecurityDesc val = new QuickFix.Fields.SecurityDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityDesc val) 
            { 
                this.SecurityDesc = val;
            }
            
            public QuickFix.Fields.SecurityDesc Get(QuickFix.Fields.SecurityDesc val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityDesc val) 
            { 
                return IsSetSecurityDesc();
            }
            
            public bool IsSetSecurityDesc() 
            { 
                return IsSetField(Tags.SecurityDesc);
            }
            public QuickFix.Fields.SecurityTradingStatus SecurityTradingStatus
            { 
                get 
                {
                    QuickFix.Fields.SecurityTradingStatus val = new QuickFix.Fields.SecurityTradingStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityTradingStatus val) 
            { 
                this.SecurityTradingStatus = val;
            }
            
            public QuickFix.Fields.SecurityTradingStatus Get(QuickFix.Fields.SecurityTradingStatus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityTradingStatus val) 
            { 
                return IsSetSecurityTradingStatus();
            }
            
            public bool IsSetSecurityTradingStatus() 
            { 
                return IsSetField(Tags.SecurityTradingStatus);
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
            public QuickFix.Fields.UnitOfMeasure UnitOfMeasure
            { 
                get 
                {
                    QuickFix.Fields.UnitOfMeasure val = new QuickFix.Fields.UnitOfMeasure();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnitOfMeasure val) 
            { 
                this.UnitOfMeasure = val;
            }
            
            public QuickFix.Fields.UnitOfMeasure Get(QuickFix.Fields.UnitOfMeasure val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnitOfMeasure val) 
            { 
                return IsSetUnitOfMeasure();
            }
            
            public bool IsSetUnitOfMeasure() 
            { 
                return IsSetField(Tags.UnitOfMeasure);
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
            public QuickFix.Fields.IncrementPrice IncrementPrice
            { 
                get 
                {
                    QuickFix.Fields.IncrementPrice val = new QuickFix.Fields.IncrementPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.IncrementPrice val) 
            { 
                this.IncrementPrice = val;
            }
            
            public QuickFix.Fields.IncrementPrice Get(QuickFix.Fields.IncrementPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.IncrementPrice val) 
            { 
                return IsSetIncrementPrice();
            }
            
            public bool IsSetIncrementPrice() 
            { 
                return IsSetField(Tags.IncrementPrice);
            }
            public QuickFix.Fields.IncrementQty IncrementQty
            { 
                get 
                {
                    QuickFix.Fields.IncrementQty val = new QuickFix.Fields.IncrementQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.IncrementQty val) 
            { 
                this.IncrementQty = val;
            }
            
            public QuickFix.Fields.IncrementQty Get(QuickFix.Fields.IncrementQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.IncrementQty val) 
            { 
                return IsSetIncrementQty();
            }
            
            public bool IsSetIncrementQty() 
            { 
                return IsSetField(Tags.IncrementQty);
            }
            public QuickFix.Fields.MinPrice MinPrice
            { 
                get 
                {
                    QuickFix.Fields.MinPrice val = new QuickFix.Fields.MinPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MinPrice val) 
            { 
                this.MinPrice = val;
            }
            
            public QuickFix.Fields.MinPrice Get(QuickFix.Fields.MinPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MinPrice val) 
            { 
                return IsSetMinPrice();
            }
            
            public bool IsSetMinPrice() 
            { 
                return IsSetField(Tags.MinPrice);
            }
            public QuickFix.Fields.MaxPrice MaxPrice
            { 
                get 
                {
                    QuickFix.Fields.MaxPrice val = new QuickFix.Fields.MaxPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MaxPrice val) 
            { 
                this.MaxPrice = val;
            }
            
            public QuickFix.Fields.MaxPrice Get(QuickFix.Fields.MaxPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MaxPrice val) 
            { 
                return IsSetMaxPrice();
            }
            
            public bool IsSetMaxPrice() 
            { 
                return IsSetField(Tags.MaxPrice);
            }
            public QuickFix.Fields.NumOfDecimalPrice NumOfDecimalPrice
            { 
                get 
                {
                    QuickFix.Fields.NumOfDecimalPrice val = new QuickFix.Fields.NumOfDecimalPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NumOfDecimalPrice val) 
            { 
                this.NumOfDecimalPrice = val;
            }
            
            public QuickFix.Fields.NumOfDecimalPrice Get(QuickFix.Fields.NumOfDecimalPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NumOfDecimalPrice val) 
            { 
                return IsSetNumOfDecimalPrice();
            }
            
            public bool IsSetNumOfDecimalPrice() 
            { 
                return IsSetField(Tags.NumOfDecimalPrice);
            }
            public QuickFix.Fields.NumOfDecimalQty NumOfDecimalQty
            { 
                get 
                {
                    QuickFix.Fields.NumOfDecimalQty val = new QuickFix.Fields.NumOfDecimalQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NumOfDecimalQty val) 
            { 
                this.NumOfDecimalQty = val;
            }
            
            public QuickFix.Fields.NumOfDecimalQty Get(QuickFix.Fields.NumOfDecimalQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NumOfDecimalQty val) 
            { 
                return IsSetNumOfDecimalQty();
            }
            
            public bool IsSetNumOfDecimalQty() 
            { 
                return IsSetField(Tags.NumOfDecimalQty);
            }
            public QuickFix.Fields.ProductId ProductId
            { 
                get 
                {
                    QuickFix.Fields.ProductId val = new QuickFix.Fields.ProductId();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ProductId val) 
            { 
                this.ProductId = val;
            }
            
            public QuickFix.Fields.ProductId Get(QuickFix.Fields.ProductId val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ProductId val) 
            { 
                return IsSetProductId();
            }
            
            public bool IsSetProductId() 
            { 
                return IsSetField(Tags.ProductId);
            }
            public QuickFix.Fields.BaseNumLots BaseNumLots
            { 
                get 
                {
                    QuickFix.Fields.BaseNumLots val = new QuickFix.Fields.BaseNumLots();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.BaseNumLots val) 
            { 
                this.BaseNumLots = val;
            }
            
            public QuickFix.Fields.BaseNumLots Get(QuickFix.Fields.BaseNumLots val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.BaseNumLots val) 
            { 
                return IsSetBaseNumLots();
            }
            
            public bool IsSetBaseNumLots() 
            { 
                return IsSetField(Tags.BaseNumLots);
            }
            public QuickFix.Fields.ClearedAlias ClearedAlias
            { 
                get 
                {
                    QuickFix.Fields.ClearedAlias val = new QuickFix.Fields.ClearedAlias();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ClearedAlias val) 
            { 
                this.ClearedAlias = val;
            }
            
            public QuickFix.Fields.ClearedAlias Get(QuickFix.Fields.ClearedAlias val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ClearedAlias val) 
            { 
                return IsSetClearedAlias();
            }
            
            public bool IsSetClearedAlias() 
            { 
                return IsSetField(Tags.ClearedAlias);
            }
            public QuickFix.Fields.Denominator Denominator
            { 
                get 
                {
                    QuickFix.Fields.Denominator val = new QuickFix.Fields.Denominator();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Denominator val) 
            { 
                this.Denominator = val;
            }
            
            public QuickFix.Fields.Denominator Get(QuickFix.Fields.Denominator val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Denominator val) 
            { 
                return IsSetDenominator();
            }
            
            public bool IsSetDenominator() 
            { 
                return IsSetField(Tags.Denominator);
            }
            public QuickFix.Fields.ImpliedType ImpliedType
            { 
                get 
                {
                    QuickFix.Fields.ImpliedType val = new QuickFix.Fields.ImpliedType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ImpliedType val) 
            { 
                this.ImpliedType = val;
            }
            
            public QuickFix.Fields.ImpliedType Get(QuickFix.Fields.ImpliedType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ImpliedType val) 
            { 
                return IsSetImpliedType();
            }
            
            public bool IsSetImpliedType() 
            { 
                return IsSetField(Tags.ImpliedType);
            }
            public QuickFix.Fields.OffExchangeIncrementPrice OffExchangeIncrementPrice
            { 
                get 
                {
                    QuickFix.Fields.OffExchangeIncrementPrice val = new QuickFix.Fields.OffExchangeIncrementPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OffExchangeIncrementPrice val) 
            { 
                this.OffExchangeIncrementPrice = val;
            }
            
            public QuickFix.Fields.OffExchangeIncrementPrice Get(QuickFix.Fields.OffExchangeIncrementPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OffExchangeIncrementPrice val) 
            { 
                return IsSetOffExchangeIncrementPrice();
            }
            
            public bool IsSetOffExchangeIncrementPrice() 
            { 
                return IsSetField(Tags.OffExchangeIncrementPrice);
            }
            public QuickFix.Fields.OffExchangeIncrementQty OffExchangeIncrementQty
            { 
                get 
                {
                    QuickFix.Fields.OffExchangeIncrementQty val = new QuickFix.Fields.OffExchangeIncrementQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OffExchangeIncrementQty val) 
            { 
                this.OffExchangeIncrementQty = val;
            }
            
            public QuickFix.Fields.OffExchangeIncrementQty Get(QuickFix.Fields.OffExchangeIncrementQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OffExchangeIncrementQty val) 
            { 
                return IsSetOffExchangeIncrementQty();
            }
            
            public bool IsSetOffExchangeIncrementQty() 
            { 
                return IsSetField(Tags.OffExchangeIncrementQty);
            }
            public QuickFix.Fields.PriceDenomination PriceDenomination
            { 
                get 
                {
                    QuickFix.Fields.PriceDenomination val = new QuickFix.Fields.PriceDenomination();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PriceDenomination val) 
            { 
                this.PriceDenomination = val;
            }
            
            public QuickFix.Fields.PriceDenomination Get(QuickFix.Fields.PriceDenomination val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PriceDenomination val) 
            { 
                return IsSetPriceDenomination();
            }
            
            public bool IsSetPriceDenomination() 
            { 
                return IsSetField(Tags.PriceDenomination);
            }
            public QuickFix.Fields.PriceUnit PriceUnit
            { 
                get 
                {
                    QuickFix.Fields.PriceUnit val = new QuickFix.Fields.PriceUnit();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PriceUnit val) 
            { 
                this.PriceUnit = val;
            }
            
            public QuickFix.Fields.PriceUnit Get(QuickFix.Fields.PriceUnit val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PriceUnit val) 
            { 
                return IsSetPriceUnit();
            }
            
            public bool IsSetPriceUnit() 
            { 
                return IsSetField(Tags.PriceUnit);
            }
            public QuickFix.Fields.NumOfDecimalStrikePrice NumOfDecimalStrikePrice
            { 
                get 
                {
                    QuickFix.Fields.NumOfDecimalStrikePrice val = new QuickFix.Fields.NumOfDecimalStrikePrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NumOfDecimalStrikePrice val) 
            { 
                this.NumOfDecimalStrikePrice = val;
            }
            
            public QuickFix.Fields.NumOfDecimalStrikePrice Get(QuickFix.Fields.NumOfDecimalStrikePrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NumOfDecimalStrikePrice val) 
            { 
                return IsSetNumOfDecimalStrikePrice();
            }
            
            public bool IsSetNumOfDecimalStrikePrice() 
            { 
                return IsSetField(Tags.NumOfDecimalStrikePrice);
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
            public QuickFix.Fields.LotSizeMultiplier LotSizeMultiplier
            { 
                get 
                {
                    QuickFix.Fields.LotSizeMultiplier val = new QuickFix.Fields.LotSizeMultiplier();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LotSizeMultiplier val) 
            { 
                this.LotSizeMultiplier = val;
            }
            
            public QuickFix.Fields.LotSizeMultiplier Get(QuickFix.Fields.LotSizeMultiplier val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LotSizeMultiplier val) 
            { 
                return IsSetLotSizeMultiplier();
            }
            
            public bool IsSetLotSizeMultiplier() 
            { 
                return IsSetField(Tags.LotSizeMultiplier);
            }
            public QuickFix.Fields.BlockOnly BlockOnly
            { 
                get 
                {
                    QuickFix.Fields.BlockOnly val = new QuickFix.Fields.BlockOnly();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.BlockOnly val) 
            { 
                this.BlockOnly = val;
            }
            
            public QuickFix.Fields.BlockOnly Get(QuickFix.Fields.BlockOnly val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.BlockOnly val) 
            { 
                return IsSetBlockOnly();
            }
            
            public bool IsSetBlockOnly() 
            { 
                return IsSetField(Tags.BlockOnly);
            }
            public QuickFix.Fields.FlexAllowed FlexAllowed
            { 
                get 
                {
                    QuickFix.Fields.FlexAllowed val = new QuickFix.Fields.FlexAllowed();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.FlexAllowed val) 
            { 
                this.FlexAllowed = val;
            }
            
            public QuickFix.Fields.FlexAllowed Get(QuickFix.Fields.FlexAllowed val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.FlexAllowed val) 
            { 
                return IsSetFlexAllowed();
            }
            
            public bool IsSetFlexAllowed() 
            { 
                return IsSetField(Tags.FlexAllowed);
            }
            public QuickFix.Fields.GTAllowed GTAllowed
            { 
                get 
                {
                    QuickFix.Fields.GTAllowed val = new QuickFix.Fields.GTAllowed();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.GTAllowed val) 
            { 
                this.GTAllowed = val;
            }
            
            public QuickFix.Fields.GTAllowed Get(QuickFix.Fields.GTAllowed val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.GTAllowed val) 
            { 
                return IsSetGTAllowed();
            }
            
            public bool IsSetGTAllowed() 
            { 
                return IsSetField(Tags.GTAllowed);
            }
            public QuickFix.Fields.MiFIDRegulatedMarket MiFIDRegulatedMarket
            { 
                get 
                {
                    QuickFix.Fields.MiFIDRegulatedMarket val = new QuickFix.Fields.MiFIDRegulatedMarket();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MiFIDRegulatedMarket val) 
            { 
                this.MiFIDRegulatedMarket = val;
            }
            
            public QuickFix.Fields.MiFIDRegulatedMarket Get(QuickFix.Fields.MiFIDRegulatedMarket val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MiFIDRegulatedMarket val) 
            { 
                return IsSetMiFIDRegulatedMarket();
            }
            
            public bool IsSetMiFIDRegulatedMarket() 
            { 
                return IsSetField(Tags.MiFIDRegulatedMarket);
            }
            public QuickFix.Fields.LegDealsSuppressed LegDealsSuppressed
            { 
                get 
                {
                    QuickFix.Fields.LegDealsSuppressed val = new QuickFix.Fields.LegDealsSuppressed();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LegDealsSuppressed val) 
            { 
                this.LegDealsSuppressed = val;
            }
            
            public QuickFix.Fields.LegDealsSuppressed Get(QuickFix.Fields.LegDealsSuppressed val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LegDealsSuppressed val) 
            { 
                return IsSetLegDealsSuppressed();
            }
            
            public bool IsSetLegDealsSuppressed() 
            { 
                return IsSetField(Tags.LegDealsSuppressed);
            }
            public QuickFix.Fields.ProductName ProductName
            { 
                get 
                {
                    QuickFix.Fields.ProductName val = new QuickFix.Fields.ProductName();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ProductName val) 
            { 
                this.ProductName = val;
            }
            
            public QuickFix.Fields.ProductName Get(QuickFix.Fields.ProductName val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ProductName val) 
            { 
                return IsSetProductName();
            }
            
            public bool IsSetProductName() 
            { 
                return IsSetField(Tags.ProductName);
            }
            public QuickFix.Fields.StripType StripType
            { 
                get 
                {
                    QuickFix.Fields.StripType val = new QuickFix.Fields.StripType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StripType val) 
            { 
                this.StripType = val;
            }
            
            public QuickFix.Fields.StripType Get(QuickFix.Fields.StripType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StripType val) 
            { 
                return IsSetStripType();
            }
            
            public bool IsSetStripType() 
            { 
                return IsSetField(Tags.StripType);
            }
            public QuickFix.Fields.StripName StripName
            { 
                get 
                {
                    QuickFix.Fields.StripName val = new QuickFix.Fields.StripName();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StripName val) 
            { 
                this.StripName = val;
            }
            
            public QuickFix.Fields.StripName Get(QuickFix.Fields.StripName val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StripName val) 
            { 
                return IsSetStripName();
            }
            
            public bool IsSetStripName() 
            { 
                return IsSetField(Tags.StripName);
            }
            public QuickFix.Fields.HubId HubId
            { 
                get 
                {
                    QuickFix.Fields.HubId val = new QuickFix.Fields.HubId();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.HubId val) 
            { 
                this.HubId = val;
            }
            
            public QuickFix.Fields.HubId Get(QuickFix.Fields.HubId val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.HubId val) 
            { 
                return IsSetHubId();
            }
            
            public bool IsSetHubId() 
            { 
                return IsSetField(Tags.HubId);
            }
            public QuickFix.Fields.HubName HubName
            { 
                get 
                {
                    QuickFix.Fields.HubName val = new QuickFix.Fields.HubName();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.HubName val) 
            { 
                this.HubName = val;
            }
            
            public QuickFix.Fields.HubName Get(QuickFix.Fields.HubName val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.HubName val) 
            { 
                return IsSetHubName();
            }
            
            public bool IsSetHubName() 
            { 
                return IsSetField(Tags.HubName);
            }
            public QuickFix.Fields.HubAlias HubAlias
            { 
                get 
                {
                    QuickFix.Fields.HubAlias val = new QuickFix.Fields.HubAlias();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.HubAlias val) 
            { 
                this.HubAlias = val;
            }
            
            public QuickFix.Fields.HubAlias Get(QuickFix.Fields.HubAlias val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.HubAlias val) 
            { 
                return IsSetHubAlias();
            }
            
            public bool IsSetHubAlias() 
            { 
                return IsSetField(Tags.HubAlias);
            }
            public QuickFix.Fields.PhysicalCode PhysicalCode
            { 
                get 
                {
                    QuickFix.Fields.PhysicalCode val = new QuickFix.Fields.PhysicalCode();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PhysicalCode val) 
            { 
                this.PhysicalCode = val;
            }
            
            public QuickFix.Fields.PhysicalCode Get(QuickFix.Fields.PhysicalCode val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PhysicalCode val) 
            { 
                return IsSetPhysicalCode();
            }
            
            public bool IsSetPhysicalCode() 
            { 
                return IsSetField(Tags.PhysicalCode);
            }
            public QuickFix.Fields.OverrideBlockMin OverrideBlockMin
            { 
                get 
                {
                    QuickFix.Fields.OverrideBlockMin val = new QuickFix.Fields.OverrideBlockMin();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OverrideBlockMin val) 
            { 
                this.OverrideBlockMin = val;
            }
            
            public QuickFix.Fields.OverrideBlockMin Get(QuickFix.Fields.OverrideBlockMin val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OverrideBlockMin val) 
            { 
                return IsSetOverrideBlockMin();
            }
            
            public bool IsSetOverrideBlockMin() 
            { 
                return IsSetField(Tags.OverrideBlockMin);
            }
            public QuickFix.Fields.NoBlockDetails NoBlockDetails
            { 
                get 
                {
                    QuickFix.Fields.NoBlockDetails val = new QuickFix.Fields.NoBlockDetails();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoBlockDetails val) 
            { 
                this.NoBlockDetails = val;
            }
            
            public QuickFix.Fields.NoBlockDetails Get(QuickFix.Fields.NoBlockDetails val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoBlockDetails val) 
            { 
                return IsSetNoBlockDetails();
            }
            
            public bool IsSetNoBlockDetails() 
            { 
                return IsSetField(Tags.NoBlockDetails);
            }
            public QuickFix.Fields.TestMarketIndicator TestMarketIndicator
            { 
                get 
                {
                    QuickFix.Fields.TestMarketIndicator val = new QuickFix.Fields.TestMarketIndicator();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TestMarketIndicator val) 
            { 
                this.TestMarketIndicator = val;
            }
            
            public QuickFix.Fields.TestMarketIndicator Get(QuickFix.Fields.TestMarketIndicator val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TestMarketIndicator val) 
            { 
                return IsSetTestMarketIndicator();
            }
            
            public bool IsSetTestMarketIndicator() 
            { 
                return IsSetField(Tags.TestMarketIndicator);
            }
            public QuickFix.Fields.ScreenTickValue ScreenTickValue
            { 
                get 
                {
                    QuickFix.Fields.ScreenTickValue val = new QuickFix.Fields.ScreenTickValue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ScreenTickValue val) 
            { 
                this.ScreenTickValue = val;
            }
            
            public QuickFix.Fields.ScreenTickValue Get(QuickFix.Fields.ScreenTickValue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ScreenTickValue val) 
            { 
                return IsSetScreenTickValue();
            }
            
            public bool IsSetScreenTickValue() 
            { 
                return IsSetField(Tags.ScreenTickValue);
            }
            public QuickFix.Fields.BlockTickValue BlockTickValue
            { 
                get 
                {
                    QuickFix.Fields.BlockTickValue val = new QuickFix.Fields.BlockTickValue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.BlockTickValue val) 
            { 
                this.BlockTickValue = val;
            }
            
            public QuickFix.Fields.BlockTickValue Get(QuickFix.Fields.BlockTickValue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.BlockTickValue val) 
            { 
                return IsSetBlockTickValue();
            }
            
            public bool IsSetBlockTickValue() 
            { 
                return IsSetField(Tags.BlockTickValue);
            }
            public QuickFix.Fields.NoUnderlyingSecurityAltID NoUnderlyingSecurityAltID
            { 
                get 
                {
                    QuickFix.Fields.NoUnderlyingSecurityAltID val = new QuickFix.Fields.NoUnderlyingSecurityAltID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoUnderlyingSecurityAltID val) 
            { 
                this.NoUnderlyingSecurityAltID = val;
            }
            
            public QuickFix.Fields.NoUnderlyingSecurityAltID Get(QuickFix.Fields.NoUnderlyingSecurityAltID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoUnderlyingSecurityAltID val) 
            { 
                return IsSetNoUnderlyingSecurityAltID();
            }
            
            public bool IsSetNoUnderlyingSecurityAltID() 
            { 
                return IsSetField(Tags.NoUnderlyingSecurityAltID);
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
            public class NoBlockDetailsGroup : Group
            {
                public static int[] fieldOrder = {Tags.BlockDetailsBlockType, Tags.BlockDetailsTradeType, Tags.BlockDetailsMinQty, 0};
            
                public NoBlockDetailsGroup() 
                  :base( Tags.NoBlockDetails, Tags.BlockDetailsBlockType, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoBlockDetailsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                public QuickFix.Fields.BlockDetailsBlockType BlockDetailsBlockType
                { 
                    get 
                    {
                        QuickFix.Fields.BlockDetailsBlockType val = new QuickFix.Fields.BlockDetailsBlockType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.BlockDetailsBlockType val) 
                { 
                    this.BlockDetailsBlockType = val;
                }
                
                public QuickFix.Fields.BlockDetailsBlockType Get(QuickFix.Fields.BlockDetailsBlockType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.BlockDetailsBlockType val) 
                { 
                    return IsSetBlockDetailsBlockType();
                }
                
                public bool IsSetBlockDetailsBlockType() 
                { 
                    return IsSetField(Tags.BlockDetailsBlockType);
                }
                public QuickFix.Fields.BlockDetailsTradeType BlockDetailsTradeType
                { 
                    get 
                    {
                        QuickFix.Fields.BlockDetailsTradeType val = new QuickFix.Fields.BlockDetailsTradeType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.BlockDetailsTradeType val) 
                { 
                    this.BlockDetailsTradeType = val;
                }
                
                public QuickFix.Fields.BlockDetailsTradeType Get(QuickFix.Fields.BlockDetailsTradeType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.BlockDetailsTradeType val) 
                { 
                    return IsSetBlockDetailsTradeType();
                }
                
                public bool IsSetBlockDetailsTradeType() 
                { 
                    return IsSetField(Tags.BlockDetailsTradeType);
                }
                public QuickFix.Fields.BlockDetailsMinQty BlockDetailsMinQty
                { 
                    get 
                    {
                        QuickFix.Fields.BlockDetailsMinQty val = new QuickFix.Fields.BlockDetailsMinQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.BlockDetailsMinQty val) 
                { 
                    this.BlockDetailsMinQty = val;
                }
                
                public QuickFix.Fields.BlockDetailsMinQty Get(QuickFix.Fields.BlockDetailsMinQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.BlockDetailsMinQty val) 
                { 
                    return IsSetBlockDetailsMinQty();
                }
                
                public bool IsSetBlockDetailsMinQty() 
                { 
                    return IsSetField(Tags.BlockDetailsMinQty);
                }
            
            }
            public class NoUnderlyingSecurityAltIDGroup : Group
            {
                public static int[] fieldOrder = {Tags.UnderlyingSecurityAltID, Tags.UnderlyingSecurityAltIDSource, 0};
            
                public NoUnderlyingSecurityAltIDGroup() 
                  :base( Tags.NoUnderlyingSecurityAltID, Tags.UnderlyingSecurityAltID, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoUnderlyingSecurityAltIDGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                public QuickFix.Fields.UnderlyingSecurityAltID UnderlyingSecurityAltID
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingSecurityAltID val = new QuickFix.Fields.UnderlyingSecurityAltID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingSecurityAltID val) 
                { 
                    this.UnderlyingSecurityAltID = val;
                }
                
                public QuickFix.Fields.UnderlyingSecurityAltID Get(QuickFix.Fields.UnderlyingSecurityAltID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingSecurityAltID val) 
                { 
                    return IsSetUnderlyingSecurityAltID();
                }
                
                public bool IsSetUnderlyingSecurityAltID() 
                { 
                    return IsSetField(Tags.UnderlyingSecurityAltID);
                }
                public QuickFix.Fields.UnderlyingSecurityAltIDSource UnderlyingSecurityAltIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingSecurityAltIDSource val = new QuickFix.Fields.UnderlyingSecurityAltIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingSecurityAltIDSource val) 
                { 
                    this.UnderlyingSecurityAltIDSource = val;
                }
                
                public QuickFix.Fields.UnderlyingSecurityAltIDSource Get(QuickFix.Fields.UnderlyingSecurityAltIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingSecurityAltIDSource val) 
                { 
                    return IsSetUnderlyingSecurityAltIDSource();
                }
                
                public bool IsSetUnderlyingSecurityAltIDSource() 
                { 
                    return IsSetField(Tags.UnderlyingSecurityAltIDSource);
                }
            
            }
            public class NoLegsGroup : Group
            {
                public static int[] fieldOrder = {Tags.LegSymbol, Tags.LegSecurityType, Tags.LegSide, Tags.LegQuantity, Tags.LegPrice, Tags.LegSecuritySubType, Tags.LegOptionDelta, Tags.LegRatioQtyDenominator, Tags.LegRatioQtyNumerator, Tags.LegRatioPriceDenominator, Tags.LegRatioPriceNumerator, 0};
            
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
                public QuickFix.Fields.LegSecurityType LegSecurityType
                { 
                    get 
                    {
                        QuickFix.Fields.LegSecurityType val = new QuickFix.Fields.LegSecurityType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSecurityType val) 
                { 
                    this.LegSecurityType = val;
                }
                
                public QuickFix.Fields.LegSecurityType Get(QuickFix.Fields.LegSecurityType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSecurityType val) 
                { 
                    return IsSetLegSecurityType();
                }
                
                public bool IsSetLegSecurityType() 
                { 
                    return IsSetField(Tags.LegSecurityType);
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
                public QuickFix.Fields.LegQuantity LegQuantity
                { 
                    get 
                    {
                        QuickFix.Fields.LegQuantity val = new QuickFix.Fields.LegQuantity();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegQuantity val) 
                { 
                    this.LegQuantity = val;
                }
                
                public QuickFix.Fields.LegQuantity Get(QuickFix.Fields.LegQuantity val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegQuantity val) 
                { 
                    return IsSetLegQuantity();
                }
                
                public bool IsSetLegQuantity() 
                { 
                    return IsSetField(Tags.LegQuantity);
                }
                public QuickFix.Fields.LegPrice LegPrice
                { 
                    get 
                    {
                        QuickFix.Fields.LegPrice val = new QuickFix.Fields.LegPrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegPrice val) 
                { 
                    this.LegPrice = val;
                }
                
                public QuickFix.Fields.LegPrice Get(QuickFix.Fields.LegPrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegPrice val) 
                { 
                    return IsSetLegPrice();
                }
                
                public bool IsSetLegPrice() 
                { 
                    return IsSetField(Tags.LegPrice);
                }
                public QuickFix.Fields.LegSecuritySubType LegSecuritySubType
                { 
                    get 
                    {
                        QuickFix.Fields.LegSecuritySubType val = new QuickFix.Fields.LegSecuritySubType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSecuritySubType val) 
                { 
                    this.LegSecuritySubType = val;
                }
                
                public QuickFix.Fields.LegSecuritySubType Get(QuickFix.Fields.LegSecuritySubType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSecuritySubType val) 
                { 
                    return IsSetLegSecuritySubType();
                }
                
                public bool IsSetLegSecuritySubType() 
                { 
                    return IsSetField(Tags.LegSecuritySubType);
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
                public QuickFix.Fields.LegRatioQtyDenominator LegRatioQtyDenominator
                { 
                    get 
                    {
                        QuickFix.Fields.LegRatioQtyDenominator val = new QuickFix.Fields.LegRatioQtyDenominator();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegRatioQtyDenominator val) 
                { 
                    this.LegRatioQtyDenominator = val;
                }
                
                public QuickFix.Fields.LegRatioQtyDenominator Get(QuickFix.Fields.LegRatioQtyDenominator val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegRatioQtyDenominator val) 
                { 
                    return IsSetLegRatioQtyDenominator();
                }
                
                public bool IsSetLegRatioQtyDenominator() 
                { 
                    return IsSetField(Tags.LegRatioQtyDenominator);
                }
                public QuickFix.Fields.LegRatioQtyNumerator LegRatioQtyNumerator
                { 
                    get 
                    {
                        QuickFix.Fields.LegRatioQtyNumerator val = new QuickFix.Fields.LegRatioQtyNumerator();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegRatioQtyNumerator val) 
                { 
                    this.LegRatioQtyNumerator = val;
                }
                
                public QuickFix.Fields.LegRatioQtyNumerator Get(QuickFix.Fields.LegRatioQtyNumerator val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegRatioQtyNumerator val) 
                { 
                    return IsSetLegRatioQtyNumerator();
                }
                
                public bool IsSetLegRatioQtyNumerator() 
                { 
                    return IsSetField(Tags.LegRatioQtyNumerator);
                }
                public QuickFix.Fields.LegRatioPriceDenominator LegRatioPriceDenominator
                { 
                    get 
                    {
                        QuickFix.Fields.LegRatioPriceDenominator val = new QuickFix.Fields.LegRatioPriceDenominator();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegRatioPriceDenominator val) 
                { 
                    this.LegRatioPriceDenominator = val;
                }
                
                public QuickFix.Fields.LegRatioPriceDenominator Get(QuickFix.Fields.LegRatioPriceDenominator val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegRatioPriceDenominator val) 
                { 
                    return IsSetLegRatioPriceDenominator();
                }
                
                public bool IsSetLegRatioPriceDenominator() 
                { 
                    return IsSetField(Tags.LegRatioPriceDenominator);
                }
                public QuickFix.Fields.LegRatioPriceNumerator LegRatioPriceNumerator
                { 
                    get 
                    {
                        QuickFix.Fields.LegRatioPriceNumerator val = new QuickFix.Fields.LegRatioPriceNumerator();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegRatioPriceNumerator val) 
                { 
                    this.LegRatioPriceNumerator = val;
                }
                
                public QuickFix.Fields.LegRatioPriceNumerator Get(QuickFix.Fields.LegRatioPriceNumerator val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegRatioPriceNumerator val) 
                { 
                    return IsSetLegRatioPriceNumerator();
                }
                
                public bool IsSetLegRatioPriceNumerator() 
                { 
                    return IsSetField(Tags.LegRatioPriceNumerator);
                }
            
            }
        }
    }
}
