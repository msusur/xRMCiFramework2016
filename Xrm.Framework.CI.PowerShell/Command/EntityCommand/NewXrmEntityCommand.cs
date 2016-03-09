using System.Management.Automation;
using Microsoft.Xrm.Sdk;

namespace Xrm.Framework.CI.PowerShell.Command
{
    [Cmdlet(VerbsCommon.New, "XrmEntity")]
    [OutputType(typeof(Entity))]
    public class NewXrmEntityCommand : Cmdlet
    {
        #region Parameters

        [Parameter(Mandatory = true)]
        public string EntityName { get; set; }

        #endregion

        #region Process Record

        protected override void ProcessRecord()
        {
            base.ProcessRecord();

            base.WriteVerbose(string.Format("New Entity: {0}", EntityName));

            WriteObject(new Entity(EntityName));
        }

        #endregion
    }
}