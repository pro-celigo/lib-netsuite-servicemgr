using System;

namespace SuiteTalk
{
    public partial class CustomerSearchRow: SearchRow, SupportsCustomSearchJoin
    {
        public SearchRowBasic GetBasic() => this.basic;

        public SearchRowBasic CreateBasic()
        {
            if (this.basic == null) this.basic = new CustomerSearchRowBasic();
            return this.basic;
        }

        public SearchRowBasic GetJoin(string joinName) => GetOrCreateJoin(this, joinName);

        public SearchRowBasic CreateJoin(string joinName) => GetOrCreateJoin(this, joinName, true);


          public CustomSearchRowBasic[] GetCustomSearchJoin() => this.customSearchJoin;
  
          public CustomSearchRowBasic[] CreateCustomSearchJoin()
          {
              if (this.customSearchJoin == null) this.customSearchJoin = new CustomSearchRowBasic[0];
              return this.customSearchJoin;
          }
        private static SearchRowBasic GetOrCreateJoin(CustomerSearchRow target, string joinName, bool createIfNull = false)
        {

            SearchRowBasic result;
            Func<SearchRowBasic> creator;

            switch (joinName)
            {

                case "billingAccountJoin":
                    result = target.billingAccountJoin;
                    creator = () => target.billingAccountJoin = new BillingAccountSearchRowBasic();
                    break;
        
                case "billingScheduleJoin":
                    result = target.billingScheduleJoin;
                    creator = () => target.billingScheduleJoin = new BillingScheduleSearchRowBasic();
                    break;
        
                case "callJoin":
                    result = target.callJoin;
                    creator = () => target.callJoin = new PhoneCallSearchRowBasic();
                    break;
        
                case "campaignResponseJoin":
                    result = target.campaignResponseJoin;
                    creator = () => target.campaignResponseJoin = new CampaignSearchRowBasic();
                    break;
        
                case "caseJoin":
                    result = target.caseJoin;
                    creator = () => target.caseJoin = new SupportCaseSearchRowBasic();
                    break;
        
                case "contactJoin":
                    result = target.contactJoin;
                    creator = () => target.contactJoin = new ContactSearchRowBasic();
                    break;
        
                case "contactPrimaryJoin":
                    result = target.contactPrimaryJoin;
                    creator = () => target.contactPrimaryJoin = new ContactSearchRowBasic();
                    break;
        
                case "eventJoin":
                    result = target.eventJoin;
                    creator = () => target.eventJoin = new CalendarEventSearchRowBasic();
                    break;
        
                case "fileJoin":
                    result = target.fileJoin;
                    creator = () => target.fileJoin = new FileSearchRowBasic();
                    break;
        
                case "hostedPageJoin":
                    result = target.hostedPageJoin;
                    creator = () => target.hostedPageJoin = new FileSearchRowBasic();
                    break;
        
                case "jobJoin":
                    result = target.jobJoin;
                    creator = () => target.jobJoin = new JobSearchRowBasic();
                    break;
        
                case "leadSourceJoin":
                    result = target.leadSourceJoin;
                    creator = () => target.leadSourceJoin = new CampaignSearchRowBasic();
                    break;
        
                case "messagesJoin":
                    result = target.messagesJoin;
                    creator = () => target.messagesJoin = new MessageSearchRowBasic();
                    break;
        
                case "messagesFromJoin":
                    result = target.messagesFromJoin;
                    creator = () => target.messagesFromJoin = new MessageSearchRowBasic();
                    break;
        
                case "messagesToJoin":
                    result = target.messagesToJoin;
                    creator = () => target.messagesToJoin = new MessageSearchRowBasic();
                    break;
        
                case "mseSubsidiaryJoin":
                    result = target.mseSubsidiaryJoin;
                    creator = () => target.mseSubsidiaryJoin = new MseSubsidiarySearchRowBasic();
                    break;
        
                case "opportunityJoin":
                    result = target.opportunityJoin;
                    creator = () => target.opportunityJoin = new OpportunitySearchRowBasic();
                    break;
        
                case "originatingLeadJoin":
                    result = target.originatingLeadJoin;
                    creator = () => target.originatingLeadJoin = new OriginatingLeadSearchRowBasic();
                    break;
        
                case "parentCustomerJoin":
                    result = target.parentCustomerJoin;
                    creator = () => target.parentCustomerJoin = new CustomerSearchRowBasic();
                    break;
        
                case "partnerJoin":
                    result = target.partnerJoin;
                    creator = () => target.partnerJoin = new PartnerSearchRowBasic();
                    break;
        
                case "pricingJoin":
                    result = target.pricingJoin;
                    creator = () => target.pricingJoin = new PricingSearchRowBasic();
                    break;
        
                case "purchasedItemJoin":
                    result = target.purchasedItemJoin;
                    creator = () => target.purchasedItemJoin = new ItemSearchRowBasic();
                    break;
        
                case "resourceAllocationJoin":
                    result = target.resourceAllocationJoin;
                    creator = () => target.resourceAllocationJoin = new ResourceAllocationSearchRowBasic();
                    break;
        
                case "salesRepJoin":
                    result = target.salesRepJoin;
                    creator = () => target.salesRepJoin = new EmployeeSearchRowBasic();
                    break;
        
                case "subCustomerJoin":
                    result = target.subCustomerJoin;
                    creator = () => target.subCustomerJoin = new CustomerSearchRowBasic();
                    break;
        
                case "taskJoin":
                    result = target.taskJoin;
                    creator = () => target.taskJoin = new TaskSearchRowBasic();
                    break;
        
                case "timeJoin":
                    result = target.timeJoin;
                    creator = () => target.timeJoin = new TimeBillSearchRowBasic();
                    break;
        
                case "topLevelParentJoin":
                    result = target.topLevelParentJoin;
                    creator = () => target.topLevelParentJoin = new CustomerSearchRowBasic();
                    break;
        
                case "transactionJoin":
                    result = target.transactionJoin;
                    creator = () => target.transactionJoin = new TransactionSearchRowBasic();
                    break;
        
                case "upsellItemJoin":
                    result = target.upsellItemJoin;
                    creator = () => target.upsellItemJoin = new ItemSearchRowBasic();
                    break;
        
                case "userJoin":
                    result = target.userJoin;
                    creator = () => target.userJoin = new EmployeeSearchRowBasic();
                    break;
        
                case "userNotesJoin":
                    result = target.userNotesJoin;
                    creator = () => target.userNotesJoin = new NoteSearchRowBasic();
                    break;
        
                case "webSiteCategoryJoin":
                    result = target.webSiteCategoryJoin;
                    creator = () => target.webSiteCategoryJoin = new SiteCategorySearchRowBasic();
                    break;
        
                case "webSiteItemJoin":
                    result = target.webSiteItemJoin;
                    creator = () => target.webSiteItemJoin = new ItemSearchRowBasic();
                    break;
                        default:
                    throw new ArgumentException("CustomerSearchRow does not have a " + joinName);
            }

            if (createIfNull && result == null) result = creator();
            return result;
                }
    }
}