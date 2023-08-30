// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX44 
    {
        public class SecurityDefinition : Message
        {
            public const string MsgType = "d";

            public SecurityDefinition() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("d"));
            }

            public SecurityDefinition(
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
            public QuickFix.Fields.TotNoRelatedSym TotNoRelatedSym
            { 
                get 
                {
                    QuickFix.Fields.TotNoRelatedSym val = new QuickFix.Fields.TotNoRelatedSym();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TotNoRelatedSym val) 
            { 
                this.TotNoRelatedSym = val;
            }
            
            public QuickFix.Fields.TotNoRelatedSym Get(QuickFix.Fields.TotNoRelatedSym val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TotNoRelatedSym val) 
            { 
                return IsSetTotNoRelatedSym();
            }
            
            public bool IsSetTotNoRelatedSym() 
            { 
                return IsSetField(Tags.TotNoRelatedSym);
            }
            public QuickFix.Fields.NoRpts NoRpts
            { 
                get 
                {
                    QuickFix.Fields.NoRpts val = new QuickFix.Fields.NoRpts();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoRpts val) 
            { 
                this.NoRpts = val;
            }
            
            public QuickFix.Fields.NoRpts Get(QuickFix.Fields.NoRpts val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoRpts val) 
            { 
                return IsSetNoRpts();
            }
            
            public bool IsSetNoRpts() 
            { 
                return IsSetField(Tags.NoRpts);
            }
            public QuickFix.Fields.ListSeqNo ListSeqNo
            { 
                get 
                {
                    QuickFix.Fields.ListSeqNo val = new QuickFix.Fields.ListSeqNo();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ListSeqNo val) 
            { 
                this.ListSeqNo = val;
            }
            
            public QuickFix.Fields.ListSeqNo Get(QuickFix.Fields.ListSeqNo val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ListSeqNo val) 
            { 
                return IsSetListSeqNo();
            }
            
            public bool IsSetListSeqNo() 
            { 
                return IsSetField(Tags.ListSeqNo);
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
            public class NoUnderlyingsGroup : Group
            {
                public static int[] fieldOrder = {Tags.UnderlyingSymbol, Tags.UnderlyingSecurityID, Tags.UnderlyingSecurityExchange, Tags.UnderlyingSecurityIDSource, Tags.IncrementPrice, Tags.MinPrice, Tags.MaxPrice, Tags.ScreenTickValue, Tags.BlockTickValue, Tags.OffExchangeIncrementPrice, Tags.OffExchangeIncrementQty, Tags.UnderlyingSecurityDesc, Tags.UnderlyingSecuritySubType, Tags.UnderlyingSettlMethod, Tags.NoUnderlyingSecurityAltID, Tags.IncrementQty, Tags.LotSize, Tags.ContractSize, Tags.SecurityTradingStatus, Tags.UnderlyingUnitofMeasure, Tags.UnderlyingCurrency, Tags.NumOfDecimalPrice, Tags.NumOfDecimalQty, Tags.Granularity, Tags.ProductId, Tags.ProductName, Tags.ProductDescription, Tags.HedgeProductID, Tags.HedgeMarketID, Tags.TickValue, Tags.BaseNumLots, Tags.LegacyTickValue, Tags.ClearedAlias, Tags.Denominator, Tags.InitialMargin, Tags.ProductType, Tags.MiFIDRegulatedMarket, Tags.TestMarketIndicator, Tags.GTAllowed, Tags.UnderlyingContractMultiplier, Tags.MarketTransparencyType, Tags.ProductGroup, Tags.AONAllowed, Tags.UnderlyingCFICode, Tags.UnderlyingMaturityDate, Tags.ScreenLastTradeDate, Tags.PriceDenomination, Tags.PriceUnit, Tags.NumOfCycles, Tags.LotSizeMultiplier, Tags.UDSAllowed, Tags.BlockOnly, Tags.ImpliedType, Tags.PrimaryLegSymbol, Tags.SecondaryLegSymbol, Tags.Clearable, Tags.StartDate, Tags.EndDate, Tags.StripId, Tags.StripType, Tags.StripName, Tags.HubId, Tags.HubName, Tags.HubAlias, Tags.PhysicalCode, Tags.OverrideBlockMin, Tags.NoBlockDetails, Tags.UnderlyingCouponRate, Tags.UnderlyingDatedDate, Tags.UnderlyingInterestAccrualDate, Tags.UnderlyingIssueDate, Tags.UnderlyingRepurchaseRate, Tags.UnderlyingFactor, Tags.UnderlyingCreditRating, Tags.UnderlyingInstrRegistry, Tags.UnderlyingPutOrCall, Tags.UnderlyingStrikePrice, Tags.StrikeExerciseStyle, Tags.HedgeOnly, Tags.HomeExchange, Tags.IsDividendAdjusted, Tags.NumOfDecimalStrikePrice, Tags.FlexAllowed, Tags.IncrementStrike, Tags.MinStrike, Tags.MaxStrike, Tags.UnderlyingAccruedPremiumAmt, Tags.UnderlyingEventPaymentAmt, Tags.UnderlyingAlignmentInterestRate, Tags.UnderlyingRepurchaseDate, Tags.UnderlyingInterpolationFactor, Tags.NonCommoditizedMarket, 0};
            
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
                public QuickFix.Fields.UnderlyingSecurityID UnderlyingSecurityID
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingSecurityID val = new QuickFix.Fields.UnderlyingSecurityID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingSecurityID val) 
                { 
                    this.UnderlyingSecurityID = val;
                }
                
                public QuickFix.Fields.UnderlyingSecurityID Get(QuickFix.Fields.UnderlyingSecurityID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingSecurityID val) 
                { 
                    return IsSetUnderlyingSecurityID();
                }
                
                public bool IsSetUnderlyingSecurityID() 
                { 
                    return IsSetField(Tags.UnderlyingSecurityID);
                }
                public QuickFix.Fields.UnderlyingSecurityExchange UnderlyingSecurityExchange
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingSecurityExchange val = new QuickFix.Fields.UnderlyingSecurityExchange();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingSecurityExchange val) 
                { 
                    this.UnderlyingSecurityExchange = val;
                }
                
                public QuickFix.Fields.UnderlyingSecurityExchange Get(QuickFix.Fields.UnderlyingSecurityExchange val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingSecurityExchange val) 
                { 
                    return IsSetUnderlyingSecurityExchange();
                }
                
                public bool IsSetUnderlyingSecurityExchange() 
                { 
                    return IsSetField(Tags.UnderlyingSecurityExchange);
                }
                public QuickFix.Fields.UnderlyingSecurityIDSource UnderlyingSecurityIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingSecurityIDSource val = new QuickFix.Fields.UnderlyingSecurityIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingSecurityIDSource val) 
                { 
                    this.UnderlyingSecurityIDSource = val;
                }
                
                public QuickFix.Fields.UnderlyingSecurityIDSource Get(QuickFix.Fields.UnderlyingSecurityIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingSecurityIDSource val) 
                { 
                    return IsSetUnderlyingSecurityIDSource();
                }
                
                public bool IsSetUnderlyingSecurityIDSource() 
                { 
                    return IsSetField(Tags.UnderlyingSecurityIDSource);
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
                public QuickFix.Fields.UnderlyingSecurityDesc UnderlyingSecurityDesc
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingSecurityDesc val = new QuickFix.Fields.UnderlyingSecurityDesc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingSecurityDesc val) 
                { 
                    this.UnderlyingSecurityDesc = val;
                }
                
                public QuickFix.Fields.UnderlyingSecurityDesc Get(QuickFix.Fields.UnderlyingSecurityDesc val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingSecurityDesc val) 
                { 
                    return IsSetUnderlyingSecurityDesc();
                }
                
                public bool IsSetUnderlyingSecurityDesc() 
                { 
                    return IsSetField(Tags.UnderlyingSecurityDesc);
                }
                public QuickFix.Fields.UnderlyingSecuritySubType UnderlyingSecuritySubType
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingSecuritySubType val = new QuickFix.Fields.UnderlyingSecuritySubType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingSecuritySubType val) 
                { 
                    this.UnderlyingSecuritySubType = val;
                }
                
                public QuickFix.Fields.UnderlyingSecuritySubType Get(QuickFix.Fields.UnderlyingSecuritySubType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingSecuritySubType val) 
                { 
                    return IsSetUnderlyingSecuritySubType();
                }
                
                public bool IsSetUnderlyingSecuritySubType() 
                { 
                    return IsSetField(Tags.UnderlyingSecuritySubType);
                }
                public QuickFix.Fields.UnderlyingSettlMethod UnderlyingSettlMethod
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingSettlMethod val = new QuickFix.Fields.UnderlyingSettlMethod();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingSettlMethod val) 
                { 
                    this.UnderlyingSettlMethod = val;
                }
                
                public QuickFix.Fields.UnderlyingSettlMethod Get(QuickFix.Fields.UnderlyingSettlMethod val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingSettlMethod val) 
                { 
                    return IsSetUnderlyingSettlMethod();
                }
                
                public bool IsSetUnderlyingSettlMethod() 
                { 
                    return IsSetField(Tags.UnderlyingSettlMethod);
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
                public QuickFix.Fields.LotSize LotSize
                { 
                    get 
                    {
                        QuickFix.Fields.LotSize val = new QuickFix.Fields.LotSize();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LotSize val) 
                { 
                    this.LotSize = val;
                }
                
                public QuickFix.Fields.LotSize Get(QuickFix.Fields.LotSize val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LotSize val) 
                { 
                    return IsSetLotSize();
                }
                
                public bool IsSetLotSize() 
                { 
                    return IsSetField(Tags.LotSize);
                }
                public QuickFix.Fields.ContractSize ContractSize
                { 
                    get 
                    {
                        QuickFix.Fields.ContractSize val = new QuickFix.Fields.ContractSize();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ContractSize val) 
                { 
                    this.ContractSize = val;
                }
                
                public QuickFix.Fields.ContractSize Get(QuickFix.Fields.ContractSize val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ContractSize val) 
                { 
                    return IsSetContractSize();
                }
                
                public bool IsSetContractSize() 
                { 
                    return IsSetField(Tags.ContractSize);
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
                public QuickFix.Fields.UnderlyingUnitofMeasure UnderlyingUnitofMeasure
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingUnitofMeasure val = new QuickFix.Fields.UnderlyingUnitofMeasure();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingUnitofMeasure val) 
                { 
                    this.UnderlyingUnitofMeasure = val;
                }
                
                public QuickFix.Fields.UnderlyingUnitofMeasure Get(QuickFix.Fields.UnderlyingUnitofMeasure val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingUnitofMeasure val) 
                { 
                    return IsSetUnderlyingUnitofMeasure();
                }
                
                public bool IsSetUnderlyingUnitofMeasure() 
                { 
                    return IsSetField(Tags.UnderlyingUnitofMeasure);
                }
                public QuickFix.Fields.UnderlyingCurrency UnderlyingCurrency
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingCurrency val = new QuickFix.Fields.UnderlyingCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingCurrency val) 
                { 
                    this.UnderlyingCurrency = val;
                }
                
                public QuickFix.Fields.UnderlyingCurrency Get(QuickFix.Fields.UnderlyingCurrency val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingCurrency val) 
                { 
                    return IsSetUnderlyingCurrency();
                }
                
                public bool IsSetUnderlyingCurrency() 
                { 
                    return IsSetField(Tags.UnderlyingCurrency);
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
                public QuickFix.Fields.Granularity Granularity
                { 
                    get 
                    {
                        QuickFix.Fields.Granularity val = new QuickFix.Fields.Granularity();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.Granularity val) 
                { 
                    this.Granularity = val;
                }
                
                public QuickFix.Fields.Granularity Get(QuickFix.Fields.Granularity val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.Granularity val) 
                { 
                    return IsSetGranularity();
                }
                
                public bool IsSetGranularity() 
                { 
                    return IsSetField(Tags.Granularity);
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
                public QuickFix.Fields.ProductDescription ProductDescription
                { 
                    get 
                    {
                        QuickFix.Fields.ProductDescription val = new QuickFix.Fields.ProductDescription();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ProductDescription val) 
                { 
                    this.ProductDescription = val;
                }
                
                public QuickFix.Fields.ProductDescription Get(QuickFix.Fields.ProductDescription val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ProductDescription val) 
                { 
                    return IsSetProductDescription();
                }
                
                public bool IsSetProductDescription() 
                { 
                    return IsSetField(Tags.ProductDescription);
                }
                public QuickFix.Fields.HedgeProductID HedgeProductID
                { 
                    get 
                    {
                        QuickFix.Fields.HedgeProductID val = new QuickFix.Fields.HedgeProductID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.HedgeProductID val) 
                { 
                    this.HedgeProductID = val;
                }
                
                public QuickFix.Fields.HedgeProductID Get(QuickFix.Fields.HedgeProductID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.HedgeProductID val) 
                { 
                    return IsSetHedgeProductID();
                }
                
                public bool IsSetHedgeProductID() 
                { 
                    return IsSetField(Tags.HedgeProductID);
                }
                public QuickFix.Fields.HedgeMarketID HedgeMarketID
                { 
                    get 
                    {
                        QuickFix.Fields.HedgeMarketID val = new QuickFix.Fields.HedgeMarketID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.HedgeMarketID val) 
                { 
                    this.HedgeMarketID = val;
                }
                
                public QuickFix.Fields.HedgeMarketID Get(QuickFix.Fields.HedgeMarketID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.HedgeMarketID val) 
                { 
                    return IsSetHedgeMarketID();
                }
                
                public bool IsSetHedgeMarketID() 
                { 
                    return IsSetField(Tags.HedgeMarketID);
                }
                public QuickFix.Fields.TickValue TickValue
                { 
                    get 
                    {
                        QuickFix.Fields.TickValue val = new QuickFix.Fields.TickValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TickValue val) 
                { 
                    this.TickValue = val;
                }
                
                public QuickFix.Fields.TickValue Get(QuickFix.Fields.TickValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TickValue val) 
                { 
                    return IsSetTickValue();
                }
                
                public bool IsSetTickValue() 
                { 
                    return IsSetField(Tags.TickValue);
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
                public QuickFix.Fields.LegacyTickValue LegacyTickValue
                { 
                    get 
                    {
                        QuickFix.Fields.LegacyTickValue val = new QuickFix.Fields.LegacyTickValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegacyTickValue val) 
                { 
                    this.LegacyTickValue = val;
                }
                
                public QuickFix.Fields.LegacyTickValue Get(QuickFix.Fields.LegacyTickValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegacyTickValue val) 
                { 
                    return IsSetLegacyTickValue();
                }
                
                public bool IsSetLegacyTickValue() 
                { 
                    return IsSetField(Tags.LegacyTickValue);
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
                public QuickFix.Fields.InitialMargin InitialMargin
                { 
                    get 
                    {
                        QuickFix.Fields.InitialMargin val = new QuickFix.Fields.InitialMargin();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.InitialMargin val) 
                { 
                    this.InitialMargin = val;
                }
                
                public QuickFix.Fields.InitialMargin Get(QuickFix.Fields.InitialMargin val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.InitialMargin val) 
                { 
                    return IsSetInitialMargin();
                }
                
                public bool IsSetInitialMargin() 
                { 
                    return IsSetField(Tags.InitialMargin);
                }
                public QuickFix.Fields.ProductType ProductType
                { 
                    get 
                    {
                        QuickFix.Fields.ProductType val = new QuickFix.Fields.ProductType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ProductType val) 
                { 
                    this.ProductType = val;
                }
                
                public QuickFix.Fields.ProductType Get(QuickFix.Fields.ProductType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ProductType val) 
                { 
                    return IsSetProductType();
                }
                
                public bool IsSetProductType() 
                { 
                    return IsSetField(Tags.ProductType);
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
                public QuickFix.Fields.UnderlyingContractMultiplier UnderlyingContractMultiplier
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingContractMultiplier val = new QuickFix.Fields.UnderlyingContractMultiplier();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingContractMultiplier val) 
                { 
                    this.UnderlyingContractMultiplier = val;
                }
                
                public QuickFix.Fields.UnderlyingContractMultiplier Get(QuickFix.Fields.UnderlyingContractMultiplier val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingContractMultiplier val) 
                { 
                    return IsSetUnderlyingContractMultiplier();
                }
                
                public bool IsSetUnderlyingContractMultiplier() 
                { 
                    return IsSetField(Tags.UnderlyingContractMultiplier);
                }
                public QuickFix.Fields.MarketTransparencyType MarketTransparencyType
                { 
                    get 
                    {
                        QuickFix.Fields.MarketTransparencyType val = new QuickFix.Fields.MarketTransparencyType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MarketTransparencyType val) 
                { 
                    this.MarketTransparencyType = val;
                }
                
                public QuickFix.Fields.MarketTransparencyType Get(QuickFix.Fields.MarketTransparencyType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MarketTransparencyType val) 
                { 
                    return IsSetMarketTransparencyType();
                }
                
                public bool IsSetMarketTransparencyType() 
                { 
                    return IsSetField(Tags.MarketTransparencyType);
                }
                public QuickFix.Fields.ProductGroup ProductGroup
                { 
                    get 
                    {
                        QuickFix.Fields.ProductGroup val = new QuickFix.Fields.ProductGroup();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ProductGroup val) 
                { 
                    this.ProductGroup = val;
                }
                
                public QuickFix.Fields.ProductGroup Get(QuickFix.Fields.ProductGroup val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ProductGroup val) 
                { 
                    return IsSetProductGroup();
                }
                
                public bool IsSetProductGroup() 
                { 
                    return IsSetField(Tags.ProductGroup);
                }
                public QuickFix.Fields.AONAllowed AONAllowed
                { 
                    get 
                    {
                        QuickFix.Fields.AONAllowed val = new QuickFix.Fields.AONAllowed();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.AONAllowed val) 
                { 
                    this.AONAllowed = val;
                }
                
                public QuickFix.Fields.AONAllowed Get(QuickFix.Fields.AONAllowed val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.AONAllowed val) 
                { 
                    return IsSetAONAllowed();
                }
                
                public bool IsSetAONAllowed() 
                { 
                    return IsSetField(Tags.AONAllowed);
                }
                public QuickFix.Fields.UnderlyingCFICode UnderlyingCFICode
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingCFICode val = new QuickFix.Fields.UnderlyingCFICode();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingCFICode val) 
                { 
                    this.UnderlyingCFICode = val;
                }
                
                public QuickFix.Fields.UnderlyingCFICode Get(QuickFix.Fields.UnderlyingCFICode val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingCFICode val) 
                { 
                    return IsSetUnderlyingCFICode();
                }
                
                public bool IsSetUnderlyingCFICode() 
                { 
                    return IsSetField(Tags.UnderlyingCFICode);
                }
                public QuickFix.Fields.UnderlyingMaturityDate UnderlyingMaturityDate
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingMaturityDate val = new QuickFix.Fields.UnderlyingMaturityDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingMaturityDate val) 
                { 
                    this.UnderlyingMaturityDate = val;
                }
                
                public QuickFix.Fields.UnderlyingMaturityDate Get(QuickFix.Fields.UnderlyingMaturityDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingMaturityDate val) 
                { 
                    return IsSetUnderlyingMaturityDate();
                }
                
                public bool IsSetUnderlyingMaturityDate() 
                { 
                    return IsSetField(Tags.UnderlyingMaturityDate);
                }
                public QuickFix.Fields.ScreenLastTradeDate ScreenLastTradeDate
                { 
                    get 
                    {
                        QuickFix.Fields.ScreenLastTradeDate val = new QuickFix.Fields.ScreenLastTradeDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ScreenLastTradeDate val) 
                { 
                    this.ScreenLastTradeDate = val;
                }
                
                public QuickFix.Fields.ScreenLastTradeDate Get(QuickFix.Fields.ScreenLastTradeDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ScreenLastTradeDate val) 
                { 
                    return IsSetScreenLastTradeDate();
                }
                
                public bool IsSetScreenLastTradeDate() 
                { 
                    return IsSetField(Tags.ScreenLastTradeDate);
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
                public QuickFix.Fields.UDSAllowed UDSAllowed
                { 
                    get 
                    {
                        QuickFix.Fields.UDSAllowed val = new QuickFix.Fields.UDSAllowed();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UDSAllowed val) 
                { 
                    this.UDSAllowed = val;
                }
                
                public QuickFix.Fields.UDSAllowed Get(QuickFix.Fields.UDSAllowed val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UDSAllowed val) 
                { 
                    return IsSetUDSAllowed();
                }
                
                public bool IsSetUDSAllowed() 
                { 
                    return IsSetField(Tags.UDSAllowed);
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
                public QuickFix.Fields.PrimaryLegSymbol PrimaryLegSymbol
                { 
                    get 
                    {
                        QuickFix.Fields.PrimaryLegSymbol val = new QuickFix.Fields.PrimaryLegSymbol();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PrimaryLegSymbol val) 
                { 
                    this.PrimaryLegSymbol = val;
                }
                
                public QuickFix.Fields.PrimaryLegSymbol Get(QuickFix.Fields.PrimaryLegSymbol val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PrimaryLegSymbol val) 
                { 
                    return IsSetPrimaryLegSymbol();
                }
                
                public bool IsSetPrimaryLegSymbol() 
                { 
                    return IsSetField(Tags.PrimaryLegSymbol);
                }
                public QuickFix.Fields.SecondaryLegSymbol SecondaryLegSymbol
                { 
                    get 
                    {
                        QuickFix.Fields.SecondaryLegSymbol val = new QuickFix.Fields.SecondaryLegSymbol();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SecondaryLegSymbol val) 
                { 
                    this.SecondaryLegSymbol = val;
                }
                
                public QuickFix.Fields.SecondaryLegSymbol Get(QuickFix.Fields.SecondaryLegSymbol val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SecondaryLegSymbol val) 
                { 
                    return IsSetSecondaryLegSymbol();
                }
                
                public bool IsSetSecondaryLegSymbol() 
                { 
                    return IsSetField(Tags.SecondaryLegSymbol);
                }
                public QuickFix.Fields.Clearable Clearable
                { 
                    get 
                    {
                        QuickFix.Fields.Clearable val = new QuickFix.Fields.Clearable();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.Clearable val) 
                { 
                    this.Clearable = val;
                }
                
                public QuickFix.Fields.Clearable Get(QuickFix.Fields.Clearable val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.Clearable val) 
                { 
                    return IsSetClearable();
                }
                
                public bool IsSetClearable() 
                { 
                    return IsSetField(Tags.Clearable);
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
                public QuickFix.Fields.StripId StripId
                { 
                    get 
                    {
                        QuickFix.Fields.StripId val = new QuickFix.Fields.StripId();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.StripId val) 
                { 
                    this.StripId = val;
                }
                
                public QuickFix.Fields.StripId Get(QuickFix.Fields.StripId val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.StripId val) 
                { 
                    return IsSetStripId();
                }
                
                public bool IsSetStripId() 
                { 
                    return IsSetField(Tags.StripId);
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
                public QuickFix.Fields.UnderlyingCouponRate UnderlyingCouponRate
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingCouponRate val = new QuickFix.Fields.UnderlyingCouponRate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingCouponRate val) 
                { 
                    this.UnderlyingCouponRate = val;
                }
                
                public QuickFix.Fields.UnderlyingCouponRate Get(QuickFix.Fields.UnderlyingCouponRate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingCouponRate val) 
                { 
                    return IsSetUnderlyingCouponRate();
                }
                
                public bool IsSetUnderlyingCouponRate() 
                { 
                    return IsSetField(Tags.UnderlyingCouponRate);
                }
                public QuickFix.Fields.UnderlyingDatedDate UnderlyingDatedDate
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingDatedDate val = new QuickFix.Fields.UnderlyingDatedDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingDatedDate val) 
                { 
                    this.UnderlyingDatedDate = val;
                }
                
                public QuickFix.Fields.UnderlyingDatedDate Get(QuickFix.Fields.UnderlyingDatedDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingDatedDate val) 
                { 
                    return IsSetUnderlyingDatedDate();
                }
                
                public bool IsSetUnderlyingDatedDate() 
                { 
                    return IsSetField(Tags.UnderlyingDatedDate);
                }
                public QuickFix.Fields.UnderlyingInterestAccrualDate UnderlyingInterestAccrualDate
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingInterestAccrualDate val = new QuickFix.Fields.UnderlyingInterestAccrualDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingInterestAccrualDate val) 
                { 
                    this.UnderlyingInterestAccrualDate = val;
                }
                
                public QuickFix.Fields.UnderlyingInterestAccrualDate Get(QuickFix.Fields.UnderlyingInterestAccrualDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingInterestAccrualDate val) 
                { 
                    return IsSetUnderlyingInterestAccrualDate();
                }
                
                public bool IsSetUnderlyingInterestAccrualDate() 
                { 
                    return IsSetField(Tags.UnderlyingInterestAccrualDate);
                }
                public QuickFix.Fields.UnderlyingIssueDate UnderlyingIssueDate
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingIssueDate val = new QuickFix.Fields.UnderlyingIssueDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingIssueDate val) 
                { 
                    this.UnderlyingIssueDate = val;
                }
                
                public QuickFix.Fields.UnderlyingIssueDate Get(QuickFix.Fields.UnderlyingIssueDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingIssueDate val) 
                { 
                    return IsSetUnderlyingIssueDate();
                }
                
                public bool IsSetUnderlyingIssueDate() 
                { 
                    return IsSetField(Tags.UnderlyingIssueDate);
                }
                public QuickFix.Fields.UnderlyingRepurchaseRate UnderlyingRepurchaseRate
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingRepurchaseRate val = new QuickFix.Fields.UnderlyingRepurchaseRate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingRepurchaseRate val) 
                { 
                    this.UnderlyingRepurchaseRate = val;
                }
                
                public QuickFix.Fields.UnderlyingRepurchaseRate Get(QuickFix.Fields.UnderlyingRepurchaseRate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingRepurchaseRate val) 
                { 
                    return IsSetUnderlyingRepurchaseRate();
                }
                
                public bool IsSetUnderlyingRepurchaseRate() 
                { 
                    return IsSetField(Tags.UnderlyingRepurchaseRate);
                }
                public QuickFix.Fields.UnderlyingFactor UnderlyingFactor
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingFactor val = new QuickFix.Fields.UnderlyingFactor();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingFactor val) 
                { 
                    this.UnderlyingFactor = val;
                }
                
                public QuickFix.Fields.UnderlyingFactor Get(QuickFix.Fields.UnderlyingFactor val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingFactor val) 
                { 
                    return IsSetUnderlyingFactor();
                }
                
                public bool IsSetUnderlyingFactor() 
                { 
                    return IsSetField(Tags.UnderlyingFactor);
                }
                public QuickFix.Fields.UnderlyingCreditRating UnderlyingCreditRating
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingCreditRating val = new QuickFix.Fields.UnderlyingCreditRating();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingCreditRating val) 
                { 
                    this.UnderlyingCreditRating = val;
                }
                
                public QuickFix.Fields.UnderlyingCreditRating Get(QuickFix.Fields.UnderlyingCreditRating val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingCreditRating val) 
                { 
                    return IsSetUnderlyingCreditRating();
                }
                
                public bool IsSetUnderlyingCreditRating() 
                { 
                    return IsSetField(Tags.UnderlyingCreditRating);
                }
                public QuickFix.Fields.UnderlyingInstrRegistry UnderlyingInstrRegistry
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingInstrRegistry val = new QuickFix.Fields.UnderlyingInstrRegistry();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingInstrRegistry val) 
                { 
                    this.UnderlyingInstrRegistry = val;
                }
                
                public QuickFix.Fields.UnderlyingInstrRegistry Get(QuickFix.Fields.UnderlyingInstrRegistry val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingInstrRegistry val) 
                { 
                    return IsSetUnderlyingInstrRegistry();
                }
                
                public bool IsSetUnderlyingInstrRegistry() 
                { 
                    return IsSetField(Tags.UnderlyingInstrRegistry);
                }
                public QuickFix.Fields.UnderlyingPutOrCall UnderlyingPutOrCall
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingPutOrCall val = new QuickFix.Fields.UnderlyingPutOrCall();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingPutOrCall val) 
                { 
                    this.UnderlyingPutOrCall = val;
                }
                
                public QuickFix.Fields.UnderlyingPutOrCall Get(QuickFix.Fields.UnderlyingPutOrCall val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingPutOrCall val) 
                { 
                    return IsSetUnderlyingPutOrCall();
                }
                
                public bool IsSetUnderlyingPutOrCall() 
                { 
                    return IsSetField(Tags.UnderlyingPutOrCall);
                }
                public QuickFix.Fields.UnderlyingStrikePrice UnderlyingStrikePrice
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingStrikePrice val = new QuickFix.Fields.UnderlyingStrikePrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingStrikePrice val) 
                { 
                    this.UnderlyingStrikePrice = val;
                }
                
                public QuickFix.Fields.UnderlyingStrikePrice Get(QuickFix.Fields.UnderlyingStrikePrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingStrikePrice val) 
                { 
                    return IsSetUnderlyingStrikePrice();
                }
                
                public bool IsSetUnderlyingStrikePrice() 
                { 
                    return IsSetField(Tags.UnderlyingStrikePrice);
                }
                public QuickFix.Fields.StrikeExerciseStyle StrikeExerciseStyle
                { 
                    get 
                    {
                        QuickFix.Fields.StrikeExerciseStyle val = new QuickFix.Fields.StrikeExerciseStyle();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.StrikeExerciseStyle val) 
                { 
                    this.StrikeExerciseStyle = val;
                }
                
                public QuickFix.Fields.StrikeExerciseStyle Get(QuickFix.Fields.StrikeExerciseStyle val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.StrikeExerciseStyle val) 
                { 
                    return IsSetStrikeExerciseStyle();
                }
                
                public bool IsSetStrikeExerciseStyle() 
                { 
                    return IsSetField(Tags.StrikeExerciseStyle);
                }
                public QuickFix.Fields.HedgeOnly HedgeOnly
                { 
                    get 
                    {
                        QuickFix.Fields.HedgeOnly val = new QuickFix.Fields.HedgeOnly();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.HedgeOnly val) 
                { 
                    this.HedgeOnly = val;
                }
                
                public QuickFix.Fields.HedgeOnly Get(QuickFix.Fields.HedgeOnly val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.HedgeOnly val) 
                { 
                    return IsSetHedgeOnly();
                }
                
                public bool IsSetHedgeOnly() 
                { 
                    return IsSetField(Tags.HedgeOnly);
                }
                public QuickFix.Fields.HomeExchange HomeExchange
                { 
                    get 
                    {
                        QuickFix.Fields.HomeExchange val = new QuickFix.Fields.HomeExchange();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.HomeExchange val) 
                { 
                    this.HomeExchange = val;
                }
                
                public QuickFix.Fields.HomeExchange Get(QuickFix.Fields.HomeExchange val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.HomeExchange val) 
                { 
                    return IsSetHomeExchange();
                }
                
                public bool IsSetHomeExchange() 
                { 
                    return IsSetField(Tags.HomeExchange);
                }
                public QuickFix.Fields.IsDividendAdjusted IsDividendAdjusted
                { 
                    get 
                    {
                        QuickFix.Fields.IsDividendAdjusted val = new QuickFix.Fields.IsDividendAdjusted();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.IsDividendAdjusted val) 
                { 
                    this.IsDividendAdjusted = val;
                }
                
                public QuickFix.Fields.IsDividendAdjusted Get(QuickFix.Fields.IsDividendAdjusted val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.IsDividendAdjusted val) 
                { 
                    return IsSetIsDividendAdjusted();
                }
                
                public bool IsSetIsDividendAdjusted() 
                { 
                    return IsSetField(Tags.IsDividendAdjusted);
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
                public QuickFix.Fields.IncrementStrike IncrementStrike
                { 
                    get 
                    {
                        QuickFix.Fields.IncrementStrike val = new QuickFix.Fields.IncrementStrike();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.IncrementStrike val) 
                { 
                    this.IncrementStrike = val;
                }
                
                public QuickFix.Fields.IncrementStrike Get(QuickFix.Fields.IncrementStrike val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.IncrementStrike val) 
                { 
                    return IsSetIncrementStrike();
                }
                
                public bool IsSetIncrementStrike() 
                { 
                    return IsSetField(Tags.IncrementStrike);
                }
                public QuickFix.Fields.MinStrike MinStrike
                { 
                    get 
                    {
                        QuickFix.Fields.MinStrike val = new QuickFix.Fields.MinStrike();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MinStrike val) 
                { 
                    this.MinStrike = val;
                }
                
                public QuickFix.Fields.MinStrike Get(QuickFix.Fields.MinStrike val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MinStrike val) 
                { 
                    return IsSetMinStrike();
                }
                
                public bool IsSetMinStrike() 
                { 
                    return IsSetField(Tags.MinStrike);
                }
                public QuickFix.Fields.MaxStrike MaxStrike
                { 
                    get 
                    {
                        QuickFix.Fields.MaxStrike val = new QuickFix.Fields.MaxStrike();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MaxStrike val) 
                { 
                    this.MaxStrike = val;
                }
                
                public QuickFix.Fields.MaxStrike Get(QuickFix.Fields.MaxStrike val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MaxStrike val) 
                { 
                    return IsSetMaxStrike();
                }
                
                public bool IsSetMaxStrike() 
                { 
                    return IsSetField(Tags.MaxStrike);
                }
                public QuickFix.Fields.UnderlyingAccruedPremiumAmt UnderlyingAccruedPremiumAmt
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingAccruedPremiumAmt val = new QuickFix.Fields.UnderlyingAccruedPremiumAmt();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingAccruedPremiumAmt val) 
                { 
                    this.UnderlyingAccruedPremiumAmt = val;
                }
                
                public QuickFix.Fields.UnderlyingAccruedPremiumAmt Get(QuickFix.Fields.UnderlyingAccruedPremiumAmt val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingAccruedPremiumAmt val) 
                { 
                    return IsSetUnderlyingAccruedPremiumAmt();
                }
                
                public bool IsSetUnderlyingAccruedPremiumAmt() 
                { 
                    return IsSetField(Tags.UnderlyingAccruedPremiumAmt);
                }
                public QuickFix.Fields.UnderlyingEventPaymentAmt UnderlyingEventPaymentAmt
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingEventPaymentAmt val = new QuickFix.Fields.UnderlyingEventPaymentAmt();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingEventPaymentAmt val) 
                { 
                    this.UnderlyingEventPaymentAmt = val;
                }
                
                public QuickFix.Fields.UnderlyingEventPaymentAmt Get(QuickFix.Fields.UnderlyingEventPaymentAmt val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingEventPaymentAmt val) 
                { 
                    return IsSetUnderlyingEventPaymentAmt();
                }
                
                public bool IsSetUnderlyingEventPaymentAmt() 
                { 
                    return IsSetField(Tags.UnderlyingEventPaymentAmt);
                }
                public QuickFix.Fields.UnderlyingAlignmentInterestRate UnderlyingAlignmentInterestRate
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingAlignmentInterestRate val = new QuickFix.Fields.UnderlyingAlignmentInterestRate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingAlignmentInterestRate val) 
                { 
                    this.UnderlyingAlignmentInterestRate = val;
                }
                
                public QuickFix.Fields.UnderlyingAlignmentInterestRate Get(QuickFix.Fields.UnderlyingAlignmentInterestRate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingAlignmentInterestRate val) 
                { 
                    return IsSetUnderlyingAlignmentInterestRate();
                }
                
                public bool IsSetUnderlyingAlignmentInterestRate() 
                { 
                    return IsSetField(Tags.UnderlyingAlignmentInterestRate);
                }
                public QuickFix.Fields.UnderlyingRepurchaseDate UnderlyingRepurchaseDate
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingRepurchaseDate val = new QuickFix.Fields.UnderlyingRepurchaseDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingRepurchaseDate val) 
                { 
                    this.UnderlyingRepurchaseDate = val;
                }
                
                public QuickFix.Fields.UnderlyingRepurchaseDate Get(QuickFix.Fields.UnderlyingRepurchaseDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingRepurchaseDate val) 
                { 
                    return IsSetUnderlyingRepurchaseDate();
                }
                
                public bool IsSetUnderlyingRepurchaseDate() 
                { 
                    return IsSetField(Tags.UnderlyingRepurchaseDate);
                }
                public QuickFix.Fields.UnderlyingInterpolationFactor UnderlyingInterpolationFactor
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingInterpolationFactor val = new QuickFix.Fields.UnderlyingInterpolationFactor();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingInterpolationFactor val) 
                { 
                    this.UnderlyingInterpolationFactor = val;
                }
                
                public QuickFix.Fields.UnderlyingInterpolationFactor Get(QuickFix.Fields.UnderlyingInterpolationFactor val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingInterpolationFactor val) 
                { 
                    return IsSetUnderlyingInterpolationFactor();
                }
                
                public bool IsSetUnderlyingInterpolationFactor() 
                { 
                    return IsSetField(Tags.UnderlyingInterpolationFactor);
                }
                public QuickFix.Fields.NonCommoditizedMarket NonCommoditizedMarket
                { 
                    get 
                    {
                        QuickFix.Fields.NonCommoditizedMarket val = new QuickFix.Fields.NonCommoditizedMarket();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NonCommoditizedMarket val) 
                { 
                    this.NonCommoditizedMarket = val;
                }
                
                public QuickFix.Fields.NonCommoditizedMarket Get(QuickFix.Fields.NonCommoditizedMarket val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NonCommoditizedMarket val) 
                { 
                    return IsSetNonCommoditizedMarket();
                }
                
                public bool IsSetNonCommoditizedMarket() 
                { 
                    return IsSetField(Tags.NonCommoditizedMarket);
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
            }
        }
    }
}
