// Generator { Name = "SearchRowGenerator", Template = "ISearchRow" }

using System;
using System.Collections.Generic;

namespace SuiteTalk
{
    public partial class InboundShipmentSearchRow: ISearchAdvancedRow, ISearchAdvancedRow<InboundShipmentSearchRowBasic>, SupportsCustomSearchJoin
    {
        public InboundShipmentSearchRowBasic GetBasic() => this.basic;

        SearchRowBasic ISearchAdvancedRow.GetBasic() => this.basic;

        public InboundShipmentSearchRowBasic CreateBasic()
        {
            if (this.basic == null) this.basic = new InboundShipmentSearchRowBasic();
            return this.basic;
        }

        ISearchAdvancedRow<InboundShipmentSearchRowBasic> 
            ISearchAdvancedRow<InboundShipmentSearchRowBasic>.CreateBasic(Action<InboundShipmentSearchRowBasic> initializer) => this.CreateBasic(initializer);

        public InboundShipmentSearchRow CreateBasic(Action<InboundShipmentSearchRowBasic> initializer)
        {
            var basic = this.CreateBasic();
            initializer(basic);
            return this;
        }

        SearchRowBasic ISearchAdvancedRow.CreateBasic() => this.CreateBasic();

        public SearchRowBasic GetJoin(string joinName) => GetOrCreateJoin(this, joinName);

        public J GetJoin<J>(string joinName) where J: SearchRowBasic => (J)this.GetJoin(joinName);

        public SearchRowBasic CreateJoin(string joinName) => GetOrCreateJoin(this, joinName, true);

        public J CreateJoin<J>(string joinName) where J: SearchRowBasic => (J)this.CreateJoin(joinName);

        ISearchAdvancedRow<InboundShipmentSearchRowBasic> 
            ISearchAdvancedRow<InboundShipmentSearchRowBasic>.CreateJoin<J>(string joinName, Action<J> initializer) => this.CreateJoin(joinName, initializer);

        public InboundShipmentSearchRow CreateJoin<J>(string joinName, Action<J> initializer) where J: SearchRowBasic
        {
            J join =  this.CreateJoin<J>(joinName);
            initializer(join);
            return this;
        }

        // public IEnumerable<SearchRowBasic> GetJoins()
        // {
        //    yield return this.basic;
      //      yield return this.itemJoin;
      //      yield return this.itemReceiptJoin;
      //      yield return this.purchaseOrderJoin;
      //      yield return this.vendorJoin;
        //}


          public CustomSearchRowBasic[] GetCustomSearchJoin() => this.customSearchJoin;
  
          public CustomSearchRowBasic[] CreateCustomSearchJoin()
          {
              if (this.customSearchJoin == null) this.customSearchJoin = new CustomSearchRowBasic[0];
              return this.customSearchJoin;
          }
        private static SearchRowBasic GetOrCreateJoin(InboundShipmentSearchRow target, string joinName, bool createIfNull = false)
        {
            SearchRowBasic result;
            Func<SearchRowBasic> creator;

            switch (joinName)
            {
                case "basic":
                    result = target.basic;
                    creator = () => target.basic = new InboundShipmentSearchRowBasic();
                    break;


                case "itemJoin":
                    result = target.itemJoin;
                    creator = () => target.itemJoin = new ItemSearchRowBasic();
                    break;
        
                case "itemReceiptJoin":
                    result = target.itemReceiptJoin;
                    creator = () => target.itemReceiptJoin = new TransactionSearchRowBasic();
                    break;
        
                case "purchaseOrderJoin":
                    result = target.purchaseOrderJoin;
                    creator = () => target.purchaseOrderJoin = new TransactionSearchRowBasic();
                    break;
        
                case "vendorJoin":
                    result = target.vendorJoin;
                    creator = () => target.vendorJoin = new VendorSearchRowBasic();
                    break;
                        default:
                    throw new ArgumentException("InboundShipmentSearchRow does not have a " + joinName);
            }

            if (createIfNull && result == null) result = creator();
            return result;
        }
    }
}