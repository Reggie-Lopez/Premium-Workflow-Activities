using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Workflow;
using Microsoft.Crm.Sdk.Messages;


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
        [AttributeTarget("pwa_premiumworkflowactivityattributes", "pwa_EntityReferenceEntities")]
        public InArgument<OptionSetValue> EntityChosen { get; set; }




        protected override void ExecuteInternal(LocalWorkflowContext context)
        {

            switch (this.EntityChosen.Get(context).value)
            {
                case 117300000:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuid = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRef = new EntityReference("account", newGuid);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    AccountDefinedRecordId.Set(context.CodeActivityContext, recordIdRef);

                    break;

                case 117300001:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuid = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRef = new EntityReference("cobalt_class", newGuid);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    classDefinedRecordId.Set(context.CodeActivityContext, recordIdRef);

                    break;

                case 117300002:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuid = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRef = new EntityReference("cobalt_classregistrationfee", newGuid);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    ClassRegFeeDefinedRecordId.Set(context.CodeActivityContext, recordIdRef);

                    break;

                case 117300003:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuid = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRef = new EntityReference("cobalt_committee", newGuid);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    CommitteeDefinedRecordId.Set(context.CodeActivityContext, recordIdRef);

                    break;

                case 117300004:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuid = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRef = new EntityReference("cobalt_committeemembership", newGuid);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    CommitteeMembershipDefinedRecordId.Set(context.CodeActivityContext, recordIdRef);

                    break;

                case 117300005:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuid = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRef = new EntityReference("cobalt_committeenomination", newGuid);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    CommitteeNominationDefinedRecordId.Set(context.CodeActivityContext, recordIdRef);

                    break;

                case 117300006:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuid = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRef = new EntityReference("contact", newGuid);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    ContactDefinedRecordId.Set(context.CodeActivityContext, recordIdRef);

                    break;

                case 117300007:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuid = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRef = new EntityReference("ramco_contribution", newGuid);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    ContributionDefinedRecordId.Set(context.CodeActivityContext, recordIdRef);

                    break;

                case 117300008:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuid = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRef = new EntityReference("ramco_designation", newGuid);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    DesignationDefinedRecordId.Set(context.CodeActivityContext, recordIdRef);

                    break;

                case 117300009:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuid = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRef = new EntityReference("cobalt_duesitem", newGuid);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    DuesItemDefinedRecordId.Set(context.CodeActivityContext, recordIdRef);

                    break;

                case 117300010:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuid = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRef = new EntityReference("cobalt_duescycle", newGuid);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    DuesCycleDefinedRecordId.Set(context.CodeActivityContext, recordIdRef);

                    break;

                case 117300011:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuid = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRef = new EntityReference("cobalt_duesoption", newGuid);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    DuesOptionDefinedRecordId.Set(context.CodeActivityContext, recordIdRef);

                    break;

                case 117300012:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuid = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRef = new EntityReference("cobalt_meeting", newGuid);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    MeetingDefinedRecordId.Set(context.CodeActivityContext, recordIdRef);

                    break;

                case 117300014:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuid = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRef = new EntityReference("cobalt_meetingactivity", newGuid);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    MeetingActDefinedRecordId.Set(context.CodeActivityContext, recordIdRef);

                    break;

                case 117300015:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuid = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRef = new EntityReference("ramco_meetingactivityregfee", newGuid);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    MeetingActRegFeeDefinedRecordId.Set(context.CodeActivityContext, recordIdRef);

                    break;

                case 117300013:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuid = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRef = new EntityReference("cobalt_meetingregistrationfee", newGuid);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    MeetingRegFeeDefinedRecordId.Set(context.CodeActivityContext, recordIdRef);

                    break;

                case 117300016:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuid = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRef = new EntityReference("cobalt_membership", newGuid);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    MembershipDefinedRecordId.Set(context.CodeActivityContext, recordIdRef);

                    break;

                case 117300017:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuid = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRef = new EntityReference("cobalt_membershipapplication", newGuid);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    MembershipAppDefinedRecordId.Set(context.CodeActivityContext, recordIdRef);

                    break;

                case 117300018:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuid = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRef = new EntityReference("ramco_officemembership", newGuid);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    OfficeMembershipDefinedRecordId.Set(context.CodeActivityContext, recordIdRef);

                    break;

                case 117300019:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuid = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRef = new EntityReference("ramco_officetransfer", newGuid);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    OfficeTransferDefinedRecordId.Set(context.CodeActivityContext, recordIdRef);

                    break;

                case 117300020:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuid = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRef = new EntityReference("salesorder", newGuid);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    OrderDefinedRecordId.Set(context.CodeActivityContext, recordIdRef);

                    break;

                case 117300023:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuid = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRef = new EntityReference("cobalt_payment", newGuid);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    PaymentDefinedRecordId.Set(context.CodeActivityContext, recordIdRef);

                    break;

                case 117300029:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuid = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRef = new EntityReference("ramco_recurringpaymentprofile", newGuid);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    PaymentProfileDefinedRecordId.Set(context.CodeActivityContext, recordIdRef);

                    break;

                case 117300021:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuid = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRef = new EntityReference("cobalt_publication", newGuid);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    PublicationDefinedRecordId.Set(context.CodeActivityContext, recordIdRef);

                    break;

                case 117300022:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuid = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRef = new EntityReference("cobalt_publicationsubcription", newGuid);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    PublicationSubDefinedRecordId.Set(context.CodeActivityContext, recordIdRef);

                    break;

                case 117300024:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuid = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRef = new EntityReference("cobalt_refund", newGuid);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    RefundDefinedRecordId.Set(context.CodeActivityContext, recordIdRef);

                    break;

                case 117300025:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuid = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRef = new EntityReference("ramco_scheduledpayment", newGuid);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    ScheduledPaymentDefinedRecordId.Set(context.CodeActivityContext, recordIdRef);

                    break;

                case 117300026:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuid = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRef = new EntityReference("ramco_scheduledpaymentdetail", newGuid);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    ScheduledPaymentDetDefinedRecordId.Set(context.CodeActivityContext, recordIdRef);

                    break;

                case 117300027:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuid = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRef = new EntityReference("ramco_statelicense", newGuid);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    StateLicenseDefinedRecordId.Set(context.CodeActivityContext, recordIdRef);

                    break;

                case 117300028:

                    // Todo: Convert GUID to Entity Reference Link
                    Guid newGuid = Guid.Parse(this.RecordId.Get(context.CodeActivityContext));
                    EntityReference recordIdRef = new EntityReference("ramco_storelocation", newGuid);
                    //this.definedRecordId.Set(context.CodeActivityContext, recordIdRef);
                    StoreLocationDefinedRecordId.Set(context.CodeActivityContext, recordIdRef);

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
        [ReferenceTarget("cobalt_classegistrationfee")]
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
        [ReferenceTarget("Contact")]
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
        [ReferenceTarget("ramco_meetingactivityregfee")]
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
        [ReferenceTarget("ramco_recurringpaymentprofile")]
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
  -
    }
}