// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX41;

public class IndicationofInterest : Message
{
    public const string MsgType = "6";

    public IndicationofInterest() : base()
    {
        Header.SetField(new MsgType("6"));
    }

    public IndicationofInterest(
            IOIid aIOIid,
            IOITransType aIOITransType,
            Symbol aSymbol,
            Side aSide,
            IOIShares aIOIShares
        ) : this()
    {
        IOIid = aIOIid;
        IOITransType = aIOITransType;
        Symbol = aSymbol;
        Side = aSide;
        IOIShares = aIOIShares;
    }

    public IOIid IOIid
    {
        get
        {
            IOIid val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(IOIid val) { IOIid = val; }
    public IOIid Get(IOIid val) { GetField(val); return val; }
    public bool IsSet(IOIid val) { return IsSetIOIid(); }
    public bool IsSetIOIid() { return IsSetField(Tags.IOIid); }

    public IOITransType IOITransType
    {
        get
        {
            IOITransType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(IOITransType val) { IOITransType = val; }
    public IOITransType Get(IOITransType val) { GetField(val); return val; }
    public bool IsSet(IOITransType val) { return IsSetIOITransType(); }
    public bool IsSetIOITransType() { return IsSetField(Tags.IOITransType); }

    public IOIRefID IOIRefID
    {
        get
        {
            IOIRefID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(IOIRefID val) { IOIRefID = val; }
    public IOIRefID Get(IOIRefID val) { GetField(val); return val; }
    public bool IsSet(IOIRefID val) { return IsSetIOIRefID(); }
    public bool IsSetIOIRefID() { return IsSetField(Tags.IOIRefID); }

    public Symbol Symbol
    {
        get
        {
            Symbol val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Symbol val) { Symbol = val; }
    public Symbol Get(Symbol val) { GetField(val); return val; }
    public bool IsSet(Symbol val) { return IsSetSymbol(); }
    public bool IsSetSymbol() { return IsSetField(Tags.Symbol); }

    public SymbolSfx SymbolSfx
    {
        get
        {
            SymbolSfx val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SymbolSfx val) { SymbolSfx = val; }
    public SymbolSfx Get(SymbolSfx val) { GetField(val); return val; }
    public bool IsSet(SymbolSfx val) { return IsSetSymbolSfx(); }
    public bool IsSetSymbolSfx() { return IsSetField(Tags.SymbolSfx); }

    public SecurityID SecurityID
    {
        get
        {
            SecurityID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecurityID val) { SecurityID = val; }
    public SecurityID Get(SecurityID val) { GetField(val); return val; }
    public bool IsSet(SecurityID val) { return IsSetSecurityID(); }
    public bool IsSetSecurityID() { return IsSetField(Tags.SecurityID); }

    public IDSource IDSource
    {
        get
        {
            IDSource val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(IDSource val) { IDSource = val; }
    public IDSource Get(IDSource val) { GetField(val); return val; }
    public bool IsSet(IDSource val) { return IsSetIDSource(); }
    public bool IsSetIDSource() { return IsSetField(Tags.IDSource); }

    public SecurityType SecurityType
    {
        get
        {
            SecurityType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecurityType val) { SecurityType = val; }
    public SecurityType Get(SecurityType val) { GetField(val); return val; }
    public bool IsSet(SecurityType val) { return IsSetSecurityType(); }
    public bool IsSetSecurityType() { return IsSetField(Tags.SecurityType); }

    public MaturityMonthYear MaturityMonthYear
    {
        get
        {
            MaturityMonthYear val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MaturityMonthYear val) { MaturityMonthYear = val; }
    public MaturityMonthYear Get(MaturityMonthYear val) { GetField(val); return val; }
    public bool IsSet(MaturityMonthYear val) { return IsSetMaturityMonthYear(); }
    public bool IsSetMaturityMonthYear() { return IsSetField(Tags.MaturityMonthYear); }

    public MaturityDay MaturityDay
    {
        get
        {
            MaturityDay val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MaturityDay val) { MaturityDay = val; }
    public MaturityDay Get(MaturityDay val) { GetField(val); return val; }
    public bool IsSet(MaturityDay val) { return IsSetMaturityDay(); }
    public bool IsSetMaturityDay() { return IsSetField(Tags.MaturityDay); }

    public PutOrCall PutOrCall
    {
        get
        {
            PutOrCall val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PutOrCall val) { PutOrCall = val; }
    public PutOrCall Get(PutOrCall val) { GetField(val); return val; }
    public bool IsSet(PutOrCall val) { return IsSetPutOrCall(); }
    public bool IsSetPutOrCall() { return IsSetField(Tags.PutOrCall); }

    public StrikePrice StrikePrice
    {
        get
        {
            StrikePrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(StrikePrice val) { StrikePrice = val; }
    public StrikePrice Get(StrikePrice val) { GetField(val); return val; }
    public bool IsSet(StrikePrice val) { return IsSetStrikePrice(); }
    public bool IsSetStrikePrice() { return IsSetField(Tags.StrikePrice); }

    public OptAttribute OptAttribute
    {
        get
        {
            OptAttribute val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OptAttribute val) { OptAttribute = val; }
    public OptAttribute Get(OptAttribute val) { GetField(val); return val; }
    public bool IsSet(OptAttribute val) { return IsSetOptAttribute(); }
    public bool IsSetOptAttribute() { return IsSetField(Tags.OptAttribute); }

    public SecurityExchange SecurityExchange
    {
        get
        {
            SecurityExchange val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecurityExchange val) { SecurityExchange = val; }
    public SecurityExchange Get(SecurityExchange val) { GetField(val); return val; }
    public bool IsSet(SecurityExchange val) { return IsSetSecurityExchange(); }
    public bool IsSetSecurityExchange() { return IsSetField(Tags.SecurityExchange); }

    public Issuer Issuer
    {
        get
        {
            Issuer val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Issuer val) { Issuer = val; }
    public Issuer Get(Issuer val) { GetField(val); return val; }
    public bool IsSet(Issuer val) { return IsSetIssuer(); }
    public bool IsSetIssuer() { return IsSetField(Tags.Issuer); }

    public SecurityDesc SecurityDesc
    {
        get
        {
            SecurityDesc val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecurityDesc val) { SecurityDesc = val; }
    public SecurityDesc Get(SecurityDesc val) { GetField(val); return val; }
    public bool IsSet(SecurityDesc val) { return IsSetSecurityDesc(); }
    public bool IsSetSecurityDesc() { return IsSetField(Tags.SecurityDesc); }

    public Side Side
    {
        get
        {
            Side val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Side val) { Side = val; }
    public Side Get(Side val) { GetField(val); return val; }
    public bool IsSet(Side val) { return IsSetSide(); }
    public bool IsSetSide() { return IsSetField(Tags.Side); }

    public IOIShares IOIShares
    {
        get
        {
            IOIShares val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(IOIShares val) { IOIShares = val; }
    public IOIShares Get(IOIShares val) { GetField(val); return val; }
    public bool IsSet(IOIShares val) { return IsSetIOIShares(); }
    public bool IsSetIOIShares() { return IsSetField(Tags.IOIShares); }

    public Price Price
    {
        get
        {
            Price val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Price val) { Price = val; }
    public Price Get(Price val) { GetField(val); return val; }
    public bool IsSet(Price val) { return IsSetPrice(); }
    public bool IsSetPrice() { return IsSetField(Tags.Price); }

    public Currency Currency
    {
        get
        {
            Currency val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Currency val) { Currency = val; }
    public Currency Get(Currency val) { GetField(val); return val; }
    public bool IsSet(Currency val) { return IsSetCurrency(); }
    public bool IsSetCurrency() { return IsSetField(Tags.Currency); }

    public ValidUntilTime ValidUntilTime
    {
        get
        {
            ValidUntilTime val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ValidUntilTime val) { ValidUntilTime = val; }
    public ValidUntilTime Get(ValidUntilTime val) { GetField(val); return val; }
    public bool IsSet(ValidUntilTime val) { return IsSetValidUntilTime(); }
    public bool IsSetValidUntilTime() { return IsSetField(Tags.ValidUntilTime); }

    public IOIQltyInd IOIQltyInd
    {
        get
        {
            IOIQltyInd val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(IOIQltyInd val) { IOIQltyInd = val; }
    public IOIQltyInd Get(IOIQltyInd val) { GetField(val); return val; }
    public bool IsSet(IOIQltyInd val) { return IsSetIOIQltyInd(); }
    public bool IsSetIOIQltyInd() { return IsSetField(Tags.IOIQltyInd); }

    public IOIOthSvc IOIOthSvc
    {
        get
        {
            IOIOthSvc val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(IOIOthSvc val) { IOIOthSvc = val; }
    public IOIOthSvc Get(IOIOthSvc val) { GetField(val); return val; }
    public bool IsSet(IOIOthSvc val) { return IsSetIOIOthSvc(); }
    public bool IsSetIOIOthSvc() { return IsSetField(Tags.IOIOthSvc); }

    public IOINaturalFlag IOINaturalFlag
    {
        get
        {
            IOINaturalFlag val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(IOINaturalFlag val) { IOINaturalFlag = val; }
    public IOINaturalFlag Get(IOINaturalFlag val) { GetField(val); return val; }
    public bool IsSet(IOINaturalFlag val) { return IsSetIOINaturalFlag(); }
    public bool IsSetIOINaturalFlag() { return IsSetField(Tags.IOINaturalFlag); }

    public NoIOIQualifiers NoIOIQualifiers
    {
        get
        {
            NoIOIQualifiers val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoIOIQualifiers val) { NoIOIQualifiers = val; }
    public NoIOIQualifiers Get(NoIOIQualifiers val) { GetField(val); return val; }
    public bool IsSet(NoIOIQualifiers val) { return IsSetNoIOIQualifiers(); }
    public bool IsSetNoIOIQualifiers() { return IsSetField(Tags.NoIOIQualifiers); }

    public Text Text
    {
        get
        {
            Text val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Text val) { Text = val; }
    public Text Get(Text val) { GetField(val); return val; }
    public bool IsSet(Text val) { return IsSetText(); }
    public bool IsSetText() { return IsSetField(Tags.Text); }

    public TransactTime TransactTime
    {
        get
        {
            TransactTime val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TransactTime val) { TransactTime = val; }
    public TransactTime Get(TransactTime val) { GetField(val); return val; }
    public bool IsSet(TransactTime val) { return IsSetTransactTime(); }
    public bool IsSetTransactTime() { return IsSetField(Tags.TransactTime); }

    public URLLink URLLink
    {
        get
        {
            URLLink val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(URLLink val) { URLLink = val; }
    public URLLink Get(URLLink val) { GetField(val); return val; }
    public bool IsSet(URLLink val) { return IsSetURLLink(); }
    public bool IsSetURLLink() { return IsSetField(Tags.URLLink); }

    public class NoIOIQualifiersGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.IOIQualifier, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.IOIQualifier, 0};

        public NoIOIQualifiersGroup()
          : base(Tags.NoIOIQualifiers, Tags.IOIQualifier, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoIOIQualifiersGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public IOIQualifier IOIQualifier
        {
            get
            {
                IOIQualifier val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(IOIQualifier val) { IOIQualifier = val; }
        public IOIQualifier Get(IOIQualifier val) { GetField(val); return val; }
        public bool IsSet(IOIQualifier val) { return IsSetIOIQualifier(); }
        public bool IsSetIOIQualifier() { return IsSetField(Tags.IOIQualifier); }
    }
}
