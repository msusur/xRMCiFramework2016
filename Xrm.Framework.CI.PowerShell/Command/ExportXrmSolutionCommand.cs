using System;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Text;
using Microsoft.Crm.Sdk.Messages;
using Xrm.Framework.CI.Common.Entities;

namespace Xrm.Framework.CI.PowerShell.Command
{
    [Cmdlet(VerbsData.Export, "XrmSolution")]
    public class ExportXrmSolutionCommand : XrmCommandBase
    {
        #region Parameters

        [Parameter(Mandatory = true)]
        public string UniqueSolutionName { get; set; }

        [Parameter(Mandatory = true)]
        public bool Managed { get; set; }

        [Parameter(Mandatory = true)]
        public string OutputFolder { get; set; }

        [Parameter(Mandatory = false)]
        public bool IncludeVersionInName { get; set; }

        [Parameter(Mandatory = false)]
        public bool ExportAutoNumberingSettings { get; set; }

        [Parameter(Mandatory = false)]
        public bool ExportCalendarSettings { get; set; }

        [Parameter(Mandatory = false)]
        public bool ExportCustomizationSettings { get; set; }

        [Parameter(Mandatory = false)]
        public bool ExportEmailTrackingSettings { get; set; }

        [Parameter(Mandatory = false)]
        public bool ExportGeneralSettings { get; set; }

        [Parameter(Mandatory = false)]
        public bool ExportIsvConfig { get; set; }

        [Parameter(Mandatory = false)]
        public bool ExportMarketingSettings { get; set; }

        [Parameter(Mandatory = false)]
        public bool ExportOutlookSynchronizationSettings { get; set; }

        [Parameter(Mandatory = false)]
        public bool ExportRelationshipRoles { get; set; }

        public ExportXrmSolutionCommand()
        {
            IncludeVersionInName = false;
        }

        #endregion

        #region Process Record

        protected override void ProcessRecord()
        {
            base.ProcessRecord();

            base.WriteVerbose(string.Format("Exporting Solution: {0}", UniqueSolutionName));

            var solutionFile = new StringBuilder();
            Solution solution;

            using (var context = new CIContext(OrganizationService))
            {
                var query = from s in context.SolutionSet
                            where s.UniqueName == UniqueSolutionName
                            select s;

                solution = query.FirstOrDefault();
            }

            if (solution == null)
            {
                throw new Exception(string.Format("Solution {0} could not be found", UniqueSolutionName));
            }
            solutionFile.Append(UniqueSolutionName);

            if (IncludeVersionInName)
            {
                solutionFile.Append("_");
                solutionFile.Append(solution.Version.Replace(".", "_"));
            }

            if (Managed)
            {
                solutionFile.Append("_managed");
            }

            solutionFile.Append(".zip");

            var exportSolutionRequest = new ExportSolutionRequest
            {
                Managed = Managed,
                SolutionName = UniqueSolutionName,
                ExportAutoNumberingSettings = ExportAutoNumberingSettings,
                ExportCalendarSettings = ExportCalendarSettings,
                ExportCustomizationSettings = ExportCustomizationSettings,
                ExportEmailTrackingSettings = ExportEmailTrackingSettings,
                ExportGeneralSettings = ExportGeneralSettings,
                ExportIsvConfig = ExportIsvConfig,
                ExportMarketingSettings = ExportMarketingSettings,
                ExportOutlookSynchronizationSettings = ExportOutlookSynchronizationSettings,
                ExportRelationshipRoles = ExportRelationshipRoles
            };

            var exportSolutionResponse = OrganizationService.Execute(exportSolutionRequest) as ExportSolutionResponse;

            string solutionFilePath = Path.Combine(OutputFolder, solutionFile.ToString());
            File.WriteAllBytes(solutionFilePath, exportSolutionResponse.ExportSolutionFile);

            base.WriteObject(solutionFile.ToString());
        }

        #endregion
    }
}