using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Xrm.Framework.CI.PowerShell.Common;

namespace Xrm.Framework.CI.PowerShell.Command
{
    [Cmdlet(VerbsCommon.Get, "XrmEntities")]
    [OutputType(typeof(IEnumerable<Entity>))]
    public class GetXrmEntitiesCommand : XrmCommandBase
    {
        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "QueryExpression")]
        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "AllExpression")]
        public string EntityName { get; set; }

        [Parameter(Mandatory = true, Position = 1, ParameterSetName = "QueryExpression")]
        public string Attribute { get; set; }

        [Parameter(Mandatory = true, Position = 2, ParameterSetName = "QueryExpression")]
        public ConditionOperator ConditionOperator { get; set; }

        [Parameter(Mandatory = false, Position = 3, ParameterSetName = "QueryExpression")]
        public object Value { get; set; }

        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "FetchExpression")]
        public string FetchXml { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();

            IEnumerable<Entity> result;

            // Its ParameterSet FetchExpression
            if (!String.IsNullOrEmpty(FetchXml))
            {
                base.WriteVerbose("Retrieving Entities using FetchXml");

                var fetchXmlToQueryExpressionRequest = new FetchXmlToQueryExpressionRequest { FetchXml = FetchXml };
                var response = (FetchXmlToQueryExpressionResponse)OrganizationService.Execute(fetchXmlToQueryExpressionRequest);
                var query = response.Query;
                result = OrganizationService.RetrieveAll(query);
            }
            // Its ParameterSet QueryExpression
            else if (!String.IsNullOrEmpty(Attribute))
            {
                base.WriteVerbose("Retrieving Entities using QueryExpression by Attribute");

                var query = new QueryExpression(EntityName) { ColumnSet = new ColumnSet(true) };

                // Its possible to choose a ConditionOperator which does not need a value.
                // e.g. for "NotNull" you must not add a condition with a value also not if the value is null.
                if (Value == null)
                {
                    query.Criteria.AddCondition(Attribute, ConditionOperator);
                }
                else
                {
                    query.Criteria.AddCondition(Attribute, ConditionOperator, Value);
                }
                result = OrganizationService.RetrieveAll(query);
            }
            // Its AllExpression
            else
            {
                base.WriteVerbose("Retrieving all Entities using QueryExpression");

                result = OrganizationService.RetrieveAll(new QueryExpression(EntityName) { ColumnSet = new ColumnSet(true) });
            }

            base.WriteVerbose(String.Format("{0} entities retrieved", result.Count()));

            WriteObject(result);
        }
    }
}
