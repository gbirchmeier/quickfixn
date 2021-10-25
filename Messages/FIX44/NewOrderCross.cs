// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX44 
    {
        public class NewOrderCross : Message
        {
            public const string MsgType = "s";

            public NewOrderCross() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("s"));
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
            public class NoSidesGroup : Group
            {
                public static int[] fieldOrder = {Tags.Side, Tags.ClOrdID, Tags.NoPartyIDs, 0};
            
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
                            public class NoPartyIDsGroup : Group
                {
                    public static int[] fieldOrder = {Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.NoPartySubIDs, 0};
                
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
                    public QuickFix.Fields.NoPartySubIDs NoPartySubIDs
                    { 
                        get 
                        {
                            QuickFix.Fields.NoPartySubIDs val = new QuickFix.Fields.NoPartySubIDs();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoPartySubIDs val) 
                    { 
                        this.NoPartySubIDs = val;
                    }
                    
                    public QuickFix.Fields.NoPartySubIDs Get(QuickFix.Fields.NoPartySubIDs val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoPartySubIDs val) 
                    { 
                        return IsSetNoPartySubIDs();
                    }
                    
                    public bool IsSetNoPartySubIDs() 
                    { 
                        return IsSetField(Tags.NoPartySubIDs);
                    }
                                    public class NoPartySubIDsGroup : Group
                    {
                        public static int[] fieldOrder = {Tags.PartySubID, Tags.PartySubIDType, 0};
                    
                        public NoPartySubIDsGroup() 
                          :base( Tags.NoPartySubIDs, Tags.PartySubID, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoPartySubIDsGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                        public QuickFix.Fields.PartySubID PartySubID
                        { 
                            get 
                            {
                                QuickFix.Fields.PartySubID val = new QuickFix.Fields.PartySubID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.PartySubID val) 
                        { 
                            this.PartySubID = val;
                        }
                        
                        public QuickFix.Fields.PartySubID Get(QuickFix.Fields.PartySubID val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.PartySubID val) 
                        { 
                            return IsSetPartySubID();
                        }
                        
                        public bool IsSetPartySubID() 
                        { 
                            return IsSetField(Tags.PartySubID);
                        }
                        public QuickFix.Fields.PartySubIDType PartySubIDType
                        { 
                            get 
                            {
                                QuickFix.Fields.PartySubIDType val = new QuickFix.Fields.PartySubIDType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.PartySubIDType val) 
                        { 
                            this.PartySubIDType = val;
                        }
                        
                        public QuickFix.Fields.PartySubIDType Get(QuickFix.Fields.PartySubIDType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.PartySubIDType val) 
                        { 
                            return IsSetPartySubIDType();
                        }
                        
                        public bool IsSetPartySubIDType() 
                        { 
                            return IsSetField(Tags.PartySubIDType);
                        }
                    
                    }
                }
            }
        }
    }
}
