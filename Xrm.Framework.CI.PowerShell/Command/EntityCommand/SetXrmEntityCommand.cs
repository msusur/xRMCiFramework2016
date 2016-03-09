using System.Management.Automation;
using Microsoft.Xrm.Sdk;

namespace Xrm.Framework.CI.PowerShell.Command
{
    [Cmdlet(VerbsCommon.Set, "XrmEntity")]
    public class SetXrmEntityCommand : XrmCommandBase
    {
        #region Parameters

        [Parameter(Mandatory = true)]
        public Entity EntityObject { get; set; }

        #endregion

        #region Process Record

        protected override void ProcessRecord()
        {
            base.ProcessRecord();

            base.WriteVerbose(string.Format("Updating Entity: {0}", EntityObject));

            OrganizationService.Update(EntityObject);

            base.WriteVerbose(string.Format("Entity Updated: {0}", EntityObject));
        }

        #endregion
    }
}