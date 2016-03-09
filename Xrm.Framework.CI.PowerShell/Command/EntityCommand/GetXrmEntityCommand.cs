using System;
using System.Management.Automation;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;

namespace Xrm.Framework.CI.PowerShell.Command
{
    [Cmdlet(VerbsCommon.Get, "XrmEntity")]
    [OutputType(typeof(Entity))]
    public class GetXrmEntityCommand : XrmCommandBase
    {
        #region Parameters

        [Parameter(Mandatory = true)]
        public string EntityName { get; set; }

        [Parameter(Mandatory = true)]
        public string Id { get; set; }

        #endregion

        #region Process Record

        protected override void ProcessRecord()
        {
            base.ProcessRecord();

            base.WriteVerbose(string.Format("Retrieving Entity: {0} {1}", EntityName, Id));

            Entity entity = OrganizationService.Retrieve(EntityName, Guid.Parse(Id), new ColumnSet(true));

            base.WriteVerbose(string.Format("Entity Retrieved: {0} {1}", entity.LogicalName, entity.Id));

            WriteObject(entity);
        }

        #endregion
    }
}