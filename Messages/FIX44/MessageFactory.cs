// This is a generated file.  Don't edit it directly!

using System.Collections.Generic;
using QuickFix.FixValues;

namespace QuickFix
{
    namespace FIX44
    {
        public class MessageFactory : IMessageFactory
        {
            public ICollection<string> GetSupportedBeginStrings()
            {
				return new [] { BeginString.FIX44 };
            }

			
            public QuickFix.Message Create(string beginString, QuickFix.Fields.ApplVerID applVerId, string msgType)
            {
                return Create(beginString, msgType);
            }


            public QuickFix.Message Create(string beginString, string msgType)
            {
                switch (msgType)
                {
                    case QuickFix.FIX44.Heartbeat.MsgType: return new QuickFix.FIX44.Heartbeat();
                    case QuickFix.FIX44.Logon.MsgType: return new QuickFix.FIX44.Logon();
                    case QuickFix.FIX44.TestRequest.MsgType: return new QuickFix.FIX44.TestRequest();
                    case QuickFix.FIX44.ResendRequest.MsgType: return new QuickFix.FIX44.ResendRequest();
                    case QuickFix.FIX44.Reject.MsgType: return new QuickFix.FIX44.Reject();
                    case QuickFix.FIX44.SequenceReset.MsgType: return new QuickFix.FIX44.SequenceReset();
                    case QuickFix.FIX44.Logout.MsgType: return new QuickFix.FIX44.Logout();
                    case QuickFix.FIX44.BusinessMessageReject.MsgType: return new QuickFix.FIX44.BusinessMessageReject();
                    case QuickFix.FIX44.News.MsgType: return new QuickFix.FIX44.News();
                    case QuickFix.FIX44.DefinedStrategy.MsgType: return new QuickFix.FIX44.DefinedStrategy();
                    case QuickFix.FIX44.SecurityDefinitionRequest.MsgType: return new QuickFix.FIX44.SecurityDefinitionRequest();
                    case QuickFix.FIX44.SecurityDefinition.MsgType: return new QuickFix.FIX44.SecurityDefinition();
                    case QuickFix.FIX44.TradeCaptureReportRequest.MsgType: return new QuickFix.FIX44.TradeCaptureReportRequest();
                    case QuickFix.FIX44.TradeCaptureReportRequestAck.MsgType: return new QuickFix.FIX44.TradeCaptureReportRequestAck();
                    case QuickFix.FIX44.TradeCaptureReport.MsgType: return new QuickFix.FIX44.TradeCaptureReport();
                    case QuickFix.FIX44.UserCompanyRequest.MsgType: return new QuickFix.FIX44.UserCompanyRequest();
                    case QuickFix.FIX44.UserCompanyResponse.MsgType: return new QuickFix.FIX44.UserCompanyResponse();
                    case QuickFix.FIX44.IndicationOfInterest.MsgType: return new QuickFix.FIX44.IndicationOfInterest();
                    case QuickFix.FIX44.Advertisement.MsgType: return new QuickFix.FIX44.Advertisement();
                    case QuickFix.FIX44.ExecutionReport.MsgType: return new QuickFix.FIX44.ExecutionReport();
                    case QuickFix.FIX44.Email.MsgType: return new QuickFix.FIX44.Email();
                    case QuickFix.FIX44.NewOrderSingle.MsgType: return new QuickFix.FIX44.NewOrderSingle();
                    case QuickFix.FIX44.ListStatusRequest.MsgType: return new QuickFix.FIX44.ListStatusRequest();
                    case QuickFix.FIX44.QuoteRequest.MsgType: return new QuickFix.FIX44.QuoteRequest();
                    case QuickFix.FIX44.Quote.MsgType: return new QuickFix.FIX44.Quote();
                    case QuickFix.FIX44.NewOrderCross.MsgType: return new QuickFix.FIX44.NewOrderCross();
                }

                return new QuickFix.Message();
            }


            public Group Create(string beginString, string msgType, int correspondingFieldID)
            {
                if (QuickFix.FIX44.Logon.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoMsgTypes: return new QuickFix.FIX44.Logon.NoMsgTypesGroup();
                    }
                }

                if (QuickFix.FIX44.News.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.LinesOfText: return new QuickFix.FIX44.News.LinesOfTextGroup();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX44.News.NoRelatedSymGroup();
                    }
                }

                if (QuickFix.FIX44.DefinedStrategy.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoBlockDetails: return new QuickFix.FIX44.DefinedStrategy.NoBlockDetailsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.DefinedStrategy.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.DefinedStrategy.NoLegsGroup();
                    }
                }

                if (QuickFix.FIX44.SecurityDefinition.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.SecurityDefinition.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.SecurityDefinition.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoBlockDetails: return new QuickFix.FIX44.SecurityDefinition.NoUnderlyingsGroup.NoBlockDetailsGroup();
                    }
                }

                if (QuickFix.FIX44.TradeCaptureReportRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.TradeCaptureReportRequest.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.TradeCaptureReportRequest.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoDates: return new QuickFix.FIX44.TradeCaptureReportRequest.NoDatesGroup();
                    }
                }

                if (QuickFix.FIX44.TradeCaptureReportRequestAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.TradeCaptureReportRequestAck.NoUnderlyingsGroup();
                    }
                }

                if (QuickFix.FIX44.TradeCaptureReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoCombiDefinitions: return new QuickFix.FIX44.TradeCaptureReport.NoCombiDefinitionsGroup();
                        case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX44.TradeCaptureReport.NoSidesGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.TradeCaptureReport.NoSidesGroup.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX44.TradeCaptureReport.NoSidesGroup.NoAllocsGroup();
                        case QuickFix.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FIX44.TradeCaptureReport.NoSidesGroup.NoAllocsGroup.NoNested2PartyIDsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.TradeCaptureReport.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX44.TradeCaptureReport.NoLegsGroup.NoNestedPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX44.UserCompanyResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.UserCompanyResponse.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.UserCompanyResponse.NoPartyIDsGroup.NoPartySubIDsGroup();
                    }
                }

                if (QuickFix.FIX44.IndicationOfInterest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.IndicationOfInterest.NoUnderlyingsGroup();
                    }
                }

                if (QuickFix.FIX44.NewOrderSingle.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.NewOrderSingle.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.NewOrderSingle.NoPartyIDsGroup.NoPartySubIDsGroup();
                    }
                }

                if (QuickFix.FIX44.QuoteRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup.NoLegsGroup();
                    }
                }

                if (QuickFix.FIX44.Quote.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.Quote.NoLegsGroup();
                    }
                }

                if (QuickFix.FIX44.NewOrderCross.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX44.NewOrderCross.NoSidesGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.NewOrderCross.NoSidesGroup.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.NewOrderCross.NoSidesGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
                    }
                }

                return null;
            }

        }
    }
}
