using System;
using System.Management.Automation;
using Microsoft.Xrm.Sdk;

namespace Xrm.Framework.CI.PowerShell.Command
{
    [Cmdlet(VerbsCommon.Add, "XrmEntity")]
    [OutputType(typeof(Guid))]
    public class AddXrmEntityCommand : XrmCommandBase
    {
        #region Parameters

        [Parameter(Mandatory = true)]
        public Entity EntityObject { get; set; }

        #endregion

        #region Process Record

        protected override void ProcessRecord()
        {
            base.ProcessRecord();

            WriteVerbose(string.Format("Creating Entity: {0}", EntityObject));

            Guid id = OrganizationService.Create(EntityObject);
            WriteObject(id);

            WriteVerbose(string.Format("Entity Created: {0}", EntityObject));
        }

        #endregion
    }
}