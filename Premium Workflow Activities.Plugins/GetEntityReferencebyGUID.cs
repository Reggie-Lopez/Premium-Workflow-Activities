using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Workflow;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Xml;


namespace PremiumWorkflowActivities.Plugins
{
    public partial class GetMembershipbyGUID : BaseWorkflow
    {

        //Input argument for GUID as string in formats accepted by the Parse Method
        [RequiredArgument]
        [Input("Primary Key (GUID)")]
        public InArgument<String> RecordId { get; set; }

        [Input("Target Entity")]
        [RequiredArgument()]
        [AttributeTarget("pwa_premiumworkflowactivityattributes", "pwa_entityreferenceentities")]
        public InArgument<OptionSetValue> EntityChosen { get; set; }




        protected override  void ExecuteInternal(LocalWorkflowContext context)
        {

            
            
            
            switch (this.EntityChosen.Get(context.CodeActivityContext).Value)
            {
                case 117300000:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuidaccount = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRefaccount = new EntityReference("account", newGuidaccount);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    AccountDefinedRecordId.Set(context.CodeActivityContext, recordIdRefaccount);

                    break;

                case 117300001:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuidclass = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRefclass = new EntityReference("cobalt_class", newGuidclass);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    ClassDefinedRecordId.Set(context.CodeActivityContext, recordIdRefclass);

                    break;

                case 117300002:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuidclassregfee = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRefclassregfee = new EntityReference("cobalt_classregistrationfee", newGuidclassregfee);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    ClassRegFeeDefinedRecordId.Set(context.CodeActivityContext, recordIdRefclassregfee);

                    break;

                case 117300003:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuidcommittee = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRefcommittee = new EntityReference("cobalt_committee", newGuidcommittee);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    CommitteeDefinedRecordId.Set(context.CodeActivityContext, recordIdRefcommittee);

                    break;

                case 117300004:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuidcommitteemem = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRefcommitteemem = new EntityReference("cobalt_committeemembership", newGuidcommitteemem);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    CommitteeMembershipDefinedRecordId.Set(context.CodeActivityContext, recordIdRefcommitteemem);

                    break;

                case 117300005:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuidcommitteenom = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRefcommitteenom = new EntityReference("cobalt_committeenomination", newGuidcommitteenom);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    CommitteeNominationDefinedRecordId.Set(context.CodeActivityContext, recordIdRefcommitteenom);

                    break;

                case 117300006:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuidcontact = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRefcontact = new EntityReference("contact", newGuidcontact);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    ContactDefinedRecordId.Set(context.CodeActivityContext, recordIdRefcontact);

                    break;

                case 117300007:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuidcontribution = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRefcontribution = new EntityReference("ramco_contribution", newGuidcontribution);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    ContributionDefinedRecordId.Set(context.CodeActivityContext, recordIdRefcontribution);

                    break;

                case 117300008:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuiddesignation = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRefdesignation = new EntityReference("ramco_designation", newGuiddesignation);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    DesignationDefinedRecordId.Set(context.CodeActivityContext, recordIdRefdesignation);

                    break;

                case 117300009:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuidduesitem = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRefduesitem = new EntityReference("cobalt_duesitem", newGuidduesitem);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    DuesItemDefinedRecordId.Set(context.CodeActivityContext, recordIdRefduesitem);

                    break;

                case 117300010:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuidduescycle = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRefduescycle = new EntityReference("cobalt_duescycle", newGuidduescycle);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    DuesCycleDefinedRecordId.Set(context.CodeActivityContext, recordIdRefduescycle);

                    break;

                case 117300011:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuidduesoption = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRefduesoption = new EntityReference("cobalt_duesoption", newGuidduesoption);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    DuesOptionDefinedRecordId.Set(context.CodeActivityContext, recordIdRefduesoption);

                    break;

                case 117300012:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuidmeeting = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRefmeeting = new EntityReference("cobalt_meeting", newGuidmeeting);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    MeetingDefinedRecordId.Set(context.CodeActivityContext, recordIdRefmeeting);

                    break;

                case 117300014:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuidmeetingactivity = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRefmeetingactivity = new EntityReference("cobalt_meetingactivity", newGuidmeetingactivity);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    MeetingActDefinedRecordId.Set(context.CodeActivityContext, recordIdRefmeetingactivity);

                    break;

                case 117300015:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuidmeetingactivityregfee = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRefmeetingactivityregfee = new EntityReference("ramco_meetingactivityregfee", newGuidmeetingactivityregfee);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    MeetingActRegFeeDefinedRecordId.Set(context.CodeActivityContext, recordIdRefmeetingactivityregfee);

                    break;

                case 117300013:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuidmeetingregistrationfee = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRefmeetingregistrationfee = new EntityReference("cobalt_meetingregistrationfee", newGuidmeetingregistrationfee);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    MeetingRegFeeDefinedRecordId.Set(context.CodeActivityContext, recordIdRefmeetingregistrationfee);

                    break;

                case 117300016:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuidmembership = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRefmembership = new EntityReference("cobalt_membership", newGuidmembership);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    MembershipDefinedRecordId.Set(context.CodeActivityContext, recordIdRefmembership);

                    break;

                case 117300017:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuidmembershipapplication = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRefmembershipapplication = new EntityReference("cobalt_membershipapplication", newGuidmembershipapplication);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    MembershipAppDefinedRecordId.Set(context.CodeActivityContext, recordIdRefmembershipapplication);

                    break;

                case 117300018:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuidofficemembership = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRefofficemembership = new EntityReference("ramco_officemembership", newGuidofficemembership);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    OfficeMembershipDefinedRecordId.Set(context.CodeActivityContext, recordIdRefofficemembership);

                    break;

                case 117300019:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuidofficetransfer = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRefofficetransfer = new EntityReference("ramco_officetransfer", newGuidofficetransfer);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    OfficeTransferDefinedRecordId.Set(context.CodeActivityContext, recordIdRefofficetransfer);

                    break;

                case 117300020:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuidorder = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdReforder = new EntityReference("salesorder", newGuidorder);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    OrderDefinedRecordId.Set(context.CodeActivityContext, recordIdReforder);

                    break;

                case 117300023:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuidpayment = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRefpayment = new EntityReference("cobalt_payment", newGuidpayment);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    PaymentDefinedRecordId.Set(context.CodeActivityContext, recordIdRefpayment);

                    break;

                case 117300029:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuidpaymentprofile = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRefpaymentprofile = new EntityReference("ramco_recurringpaymentprofile", newGuidpaymentprofile);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    PaymentProfileDefinedRecordId.Set(context.CodeActivityContext, recordIdRefpaymentprofile);

                    break;

                case 117300021:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuidpublication = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRefpublication = new EntityReference("cobalt_publication", newGuidpublication);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    PublicationDefinedRecordId.Set(context.CodeActivityContext, recordIdRefpublication);

                    break;

                case 117300022:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuidpublicationsubcription = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRefpublicationsubcription = new EntityReference("cobalt_publicationsubcription", newGuidpublicationsubcription);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    PublicationSubDefinedRecordId.Set(context.CodeActivityContext, recordIdRefpublicationsubcription);

                    break;

                case 117300024:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuidrefund = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRefrefund = new EntityReference("cobalt_refund", newGuidrefund);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    RefundDefinedRecordId.Set(context.CodeActivityContext, recordIdRefrefund);

                    break;

                case 117300025:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuidscheduledpayment = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRefscheduledpayment = new EntityReference("ramco_scheduledpayment", newGuidscheduledpayment);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    ScheduledPaymentDefinedRecordId.Set(context.CodeActivityContext, recordIdRefscheduledpayment);

                    break;

                case 117300026:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuidscheduledpaymentdetail = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRefscheduledpaymentdetail = new EntityReference("ramco_scheduledpaymentdetail", newGuidscheduledpaymentdetail);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    ScheduledPaymentDetDefinedRecordId.Set(context.CodeActivityContext, recordIdRefscheduledpaymentdetail);

                    break;

                case 117300027:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuidstatelicense = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRefstatelicense = new EntityReference("ramco_statelicense", newGuidstatelicense);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    StateLicenseDefinedRecordId.Set(context.CodeActivityContext, recordIdRefstatelicense);

                    break;

                case 117300028:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuidstorelocation = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRefstorelocation = new EntityReference("ramco_storelocation", newGuidstorelocation);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    StoreLocationDefinedRecordId.Set(context.CodeActivityContext, recordIdRefstorelocation);

                    break;

                default:
                    break;
            }


        }



        [Output("Account")]
        [ReferenceTarget("account")]
        public OutArgument<EntityReference> AccountDefinedRecordId { get; set; }

        [Output("Class")]
        [ReferenceTarget("cobalt_class")]
        public OutArgument<EntityReference> ClassDefinedRecordId { get; set; }

        [Output("Class Registration Fee")]
        [ReferenceTarget("cobalt_classregistrationfee")]
        public OutArgument<EntityReference> ClassRegFeeDefinedRecordId { get; set; }

        [Output("Committee")]
        [ReferenceTarget("cobalt_committee")]
        public OutArgument<EntityReference> CommitteeDefinedRecordId { get; set; }

        [Output("Committee Membership")]
        [ReferenceTarget("cobalt_committeemembership")]
        public OutArgument<EntityReference> CommitteeMembershipDefinedRecordId { get; set; }

        [Output("Committee Nomination")]
        [ReferenceTarget("cobalt_committeenomination")]
        public OutArgument<EntityReference> CommitteeNominationDefinedRecordId { get; set; }

        [Output("Contact")]
        [ReferenceTarget("contact")]
        public OutArgument<EntityReference> ContactDefinedRecordId { get; set; }

        [Output("Contribution")]
        [ReferenceTarget("ramco_contribution")]
        public OutArgument<EntityReference> ContributionDefinedRecordId { get; set; }

        [Output("Designation")]
        [ReferenceTarget("ramco_designation")]
        public OutArgument<EntityReference> DesignationDefinedRecordId { get; set; }

        [Output("Dues Cycle")]
        [ReferenceTarget("cobalt_duescycle")]
        public OutArgument<EntityReference> DuesCycleDefinedRecordId { get; set; }

        [Output("Dues Item")]
        [ReferenceTarget("cobalt_duesitem")]
        public OutArgument<EntityReference> DuesItemDefinedRecordId { get; set; }

        [Output("Dues Option")]
        [ReferenceTarget("cobalt_duesoption")]
        public OutArgument<EntityReference> DuesOptionDefinedRecordId { get; set; }

        [Output("Meeting")]
        [ReferenceTarget("cobalt_meeting")]
        public OutArgument<EntityReference> MeetingDefinedRecordId { get; set; }

        [Output("Meeting Activity")]
        [ReferenceTarget("cobalt_meetingactivity")]
        public OutArgument<EntityReference> MeetingActDefinedRecordId { get; set; }

        [Output("Meeting Activity Registration Fee")]
        [ReferenceTarget("cobalt_meetingactivityregfee")]
        public OutArgument<EntityReference> MeetingActRegFeeDefinedRecordId { get; set; }

        [Output("Meeting Registration Fee")]
        [ReferenceTarget("cobalt_meetingregistrationfee")]
        public OutArgument<EntityReference> MeetingRegFeeDefinedRecordId { get; set; }

        [Output("Membership")]
        [ReferenceTarget("cobalt_membership")]
        public OutArgument<EntityReference> MembershipDefinedRecordId { get; set; }

        [Output("Membership Application")]
        [ReferenceTarget("cobalt_membershipapplication")]
        public OutArgument<EntityReference> MembershipAppDefinedRecordId { get; set; }

        [Output("Office Membership")]
        [ReferenceTarget("ramco_officemembership")]
        public OutArgument<EntityReference> OfficeMembershipDefinedRecordId { get; set; }

        [Output("Office Transfer")]
        [ReferenceTarget("ramco_officetransfer")]
        public OutArgument<EntityReference> OfficeTransferDefinedRecordId { get; set; }

        [Output("Order")]
        [ReferenceTarget("salesorder")]
        public OutArgument<EntityReference> OrderDefinedRecordId { get; set; }

        [Output("Payment")]
        [ReferenceTarget("cobalt_payment")]
        public OutArgument<EntityReference> PaymentDefinedRecordId { get; set; }

        [Output("Payment Profile")]
        [ReferenceTarget("cobalt_recurringpaymentprofile")]
        public OutArgument<EntityReference> PaymentProfileDefinedRecordId { get; set; }

        [Output("Publication")]
        [ReferenceTarget("cobalt_publication")]
        public OutArgument<EntityReference> PublicationDefinedRecordId { get; set; }

        [Output("Publication Subscription")]
        [ReferenceTarget("cobalt_publicationsubscription")]
        public OutArgument<EntityReference> PublicationSubDefinedRecordId { get; set; }

        [Output("Refund")]
        [ReferenceTarget("cobalt_refund")]
        public OutArgument<EntityReference> RefundDefinedRecordId { get; set; }

        [Output("Scheduled Payment")]
        [ReferenceTarget("ramco_scheduledpayment")]
        public OutArgument<EntityReference> ScheduledPaymentDefinedRecordId { get; set; }

        [Output("Scheduled Payment Detail")]
        [ReferenceTarget("ramco_scheduledpaymentdetail")]
        public OutArgument<EntityReference> ScheduledPaymentDetDefinedRecordId { get; set; }

        [Output("State License")]
        [ReferenceTarget("ramco_statelicense")]
        public OutArgument<EntityReference> StateLicenseDefinedRecordId { get; set; }

        [Output("Store Location")]
        [ReferenceTarget("ramco_storelocation")]
        public OutArgument<EntityReference> StoreLocationDefinedRecordId { get; set; }
  
    }
}