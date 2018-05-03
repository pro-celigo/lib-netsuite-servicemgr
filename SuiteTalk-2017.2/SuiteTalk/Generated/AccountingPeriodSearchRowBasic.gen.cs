//~ Generated by SearchStubs/SearchRowBasic

using System;
using System.Collections.Generic;

namespace SuiteTalk
{
    partial class AccountingPeriodSearchRowBasic
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

        class ColumnFactory:  ColumnFactory<AccountingPeriodSearchRowBasic>
        {
            protected override Dictionary<string, Action<AccountingPeriodSearchRowBasic>> InitializeColumnBuilders()
            {
                return new Dictionary<string, Action<AccountingPeriodSearchRowBasic>> {
                    { "allLocked", r => r.@allLocked = new [] { new SearchColumnBooleanField { customLabel = "allLocked" } } },
                    { "allowNonGLChanges", r => r.@allowNonGLChanges = new [] { new SearchColumnBooleanField { customLabel = "allowNonGLChanges" } } },
                    { "apLocked", r => r.@apLocked = new [] { new SearchColumnBooleanField { customLabel = "apLocked" } } },
                    { "arLocked", r => r.@arLocked = new [] { new SearchColumnBooleanField { customLabel = "arLocked" } } },
                    { "closed", r => r.@closed = new [] { new SearchColumnBooleanField { customLabel = "closed" } } },
                    { "closedOnDate", r => r.@closedOnDate = new [] { new SearchColumnDateField { customLabel = "closedOnDate" } } },
                    { "endDate", r => r.@endDate = new [] { new SearchColumnDateField { customLabel = "endDate" } } },
                    { "internalId", r => r.@internalId = new [] { new SearchColumnSelectField { customLabel = "internalId" } } },
                    { "isAdjust", r => r.@isAdjust = new [] { new SearchColumnBooleanField { customLabel = "isAdjust" } } },
                    { "isInactive", r => r.@isInactive = new [] { new SearchColumnBooleanField { customLabel = "isInactive" } } },
                    { "isQuarter", r => r.@isQuarter = new [] { new SearchColumnBooleanField { customLabel = "isQuarter" } } },
                    { "isYear", r => r.@isYear = new [] { new SearchColumnBooleanField { customLabel = "isYear" } } },
                    { "parent", r => r.@parent = new [] { new SearchColumnSelectField { customLabel = "parent" } } },
                    { "payrollLocked", r => r.@payrollLocked = new [] { new SearchColumnBooleanField { customLabel = "payrollLocked" } } },
                    { "periodName", r => r.@periodName = new [] { new SearchColumnStringField { customLabel = "periodName" } } },
                    { "startDate", r => r.@startDate = new [] { new SearchColumnDateField { customLabel = "startDate" } } },
                };
            }
        }
    }
}