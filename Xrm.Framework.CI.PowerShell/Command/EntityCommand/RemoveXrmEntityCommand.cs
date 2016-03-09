using System;
using System.Management.Automation;

namespace Xrm.Framework.CI.PowerShell.Command
{
    [Cmdlet(VerbsCommon.Remove, "XrmEntity")]
    public class RemoveXrmEntityCommand : XrmCommandBase
    {
        #region Parameters

        [Parameter(Mandatory = true)]
        public string EntityName { get; set; }

        [Parameter(Mandatory = true)]
        public Guid Id { get; set; }

        #endregion

        #region Process Record

        protected override void ProcessRecord()
        {
            base.ProcessRecord();

            base.WriteVerbose(string.Format("Deleting Entity: {0} {1}", EntityName, Id));

            OrganizationService.Delete(EntityName, Id);

            base.WriteVerbose(string.Format("Entity Deleted: {0} {1}", EntityName, Id));
        }

        #endregion
    }
}