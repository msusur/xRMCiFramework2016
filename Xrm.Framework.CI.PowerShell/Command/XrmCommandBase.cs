using System.Management.Automation;
using Microsoft.Xrm.Client;
using Microsoft.Xrm.Client.Services;
using Microsoft.Xrm.Sdk;

namespace Xrm.Framework.CI.PowerShell.Command
{
    public abstract class XrmCommandBase : Cmdlet
    {
        protected IOrganizationService OrganizationService;

        /// <summary>
        /// Gets or sets the connection string to the CRM organization.
        /// </summary>
        /// <value>
        /// The connection string to the CRM organization.
        /// </value>
        [Parameter(Mandatory = true)]
        public string ConnectionString { get; set; }

        protected override void BeginProcessing()
        {
            base.BeginProcessing();

            CrmConnection connection = CrmConnection.Parse(ConnectionString);
            OrganizationService = new OrganizationService(connection);
        }

        protected override void EndProcessing()
        {
            base.EndProcessing();

            var typedService = OrganizationService as OrganizationService;
            if (typedService != null)
                typedService.Dispose();
        }
    }
}