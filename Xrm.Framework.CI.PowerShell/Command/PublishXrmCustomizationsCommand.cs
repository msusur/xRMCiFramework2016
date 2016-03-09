﻿using System.Management.Automation;
using Microsoft.Crm.Sdk.Messages;

namespace Xrm.Framework.CI.PowerShell.Command
{
    [Cmdlet(VerbsData.Publish, "XrmCustomizations")]
    public class PublishXrmCustomizationsCommand : XrmCommandBase
    {
        #region Process Record

        protected override void ProcessRecord()
        {
            base.ProcessRecord();

            base.WriteVerbose(string.Format("Publishing Customizations"));

            var publishAllXmlRequest = new PublishAllXmlRequest();
            OrganizationService.Execute(publishAllXmlRequest);

            base.WriteVerbose(string.Format("Publish Customizations Completed"));
        }

        #endregion
    }
}