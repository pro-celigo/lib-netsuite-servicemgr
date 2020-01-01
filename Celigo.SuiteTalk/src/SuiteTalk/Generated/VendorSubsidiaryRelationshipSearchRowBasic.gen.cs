//~ Generated by SearchStubs/SearchRowBasic

using System;
using System.Collections.Generic;

namespace SuiteTalk
{
    partial class VendorSubsidiaryRelationshipSearchRowBasic
    {
        // TODO: Make this Lazy and Weak referenced so that it can be garbaged collected
        private static readonly Lazy<ColumnFactory> columnFactoryLoader = new Lazy<ColumnFactory>(() => new ColumnFactory());

        public override void SetColumns(string[] columnNames)
        {
            var factory = columnFactoryLoader.Value;
            for (int i = 0; i < columnNames.Length; i++)
            {
                factory.BuildColumn(this, columnNames[i]);
            }
        }

        class ColumnFactory:  ColumnFactory<VendorSubsidiaryRelationshipSearchRowBasic>
        {
            protected override Dictionary<string, Action<VendorSubsidiaryRelationshipSearchRowBasic>> InitializeColumnBuilders()
            {
                return new Dictionary<string, Action<VendorSubsidiaryRelationshipSearchRowBasic>> {
                    { "balance", r => r.@balance = new [] { new SearchColumnDoubleField { customLabel = "balance" } } },
                    { "balancebase", r => r.@balancebase = new [] { new SearchColumnDoubleField { customLabel = "balancebase" } } },
                    { "baseCurrency", r => r.@baseCurrency = new [] { new SearchColumnSelectField { customLabel = "baseCurrency" } } },
                    { "creditlimit", r => r.@creditlimit = new [] { new SearchColumnDoubleField { customLabel = "creditlimit" } } },
                    { "entity", r => r.@entity = new [] { new SearchColumnSelectField { customLabel = "entity" } } },
                    { "externalId", r => r.@externalId = new [] { new SearchColumnSelectField { customLabel = "externalId" } } },
                    { "internalId", r => r.@internalId = new [] { new SearchColumnSelectField { customLabel = "internalId" } } },
                    { "inTransitBalance", r => r.@inTransitBalance = new [] { new SearchColumnDoubleField { customLabel = "inTransitBalance" } } },
                    { "inTransitBalanceBase", r => r.@inTransitBalanceBase = new [] { new SearchColumnDoubleField { customLabel = "inTransitBalanceBase" } } },
                    { "isprimarysub", r => r.@isprimarysub = new [] { new SearchColumnBooleanField { customLabel = "isprimarysub" } } },
                    { "primaryCurrency", r => r.@primaryCurrency = new [] { new SearchColumnSelectField { customLabel = "primaryCurrency" } } },
                    { "subsidiary", r => r.@subsidiary = new [] { new SearchColumnSelectField { customLabel = "subsidiary" } } },
                    { "taxitem", r => r.@taxitem = new [] { new SearchColumnSelectField { customLabel = "taxitem" } } },
                    { "unbilledorders", r => r.@unbilledorders = new [] { new SearchColumnDoubleField { customLabel = "unbilledorders" } } },
                    { "unbilledordersbase", r => r.@unbilledordersbase = new [] { new SearchColumnDoubleField { customLabel = "unbilledordersbase" } } },
                };
            }
        }
    }
}