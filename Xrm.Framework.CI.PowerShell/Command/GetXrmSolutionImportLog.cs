using System;
using System.IO;
using System.Management.Automation;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;
using Xrm.Framework.CI.Common.Entities;

namespace Xrm.Framework.CI.PowerShell.Command
{
    [Cmdlet(VerbsCommon.Get, "XrmSolutionImportLog")]
    public class GetXrmSolutionImportLogCommand : XrmCommandBase
    {
        #region Parameters

        [Parameter(Mandatory = true)]
        public Guid ImportJobId
        {
            get { return importJobId; }
            set { importJobId = value; }
        }

        private Guid importJobId;

        [Parameter(Mandatory = false)]
        public string OutputFile
        {
            get { return outputFile; }
            set { outputFile = value; }
        }

        private string outputFile;

        #endregion

        #region Process Record

        protected override void ProcessRecord()
        {
            base.ProcessRecord();

            base.WriteVerbose(string.Format("Downloading Solution Import Log for: {0}", ImportJobId));

            var importJob = OrganizationService.Retrieve(ImportJob.EntityLogicalName, importJobId, new ColumnSet(true)).ToEntity<ImportJob>();

            var importLogRequest = new RetrieveFormattedImportJobResultsRequest
            {
                ImportJobId = importJobId
            };
            var importLogResponse =
                (RetrieveFormattedImportJobResultsResponse)OrganizationService.Execute(importLogRequest);

            if (!string.IsNullOrEmpty(outputFile))
            {
                File.WriteAllText(outputFile, importLogResponse.FormattedResults);
            }

            WriteObject(importJob);

            base.WriteVerbose(string.Format("Solution Import Log Downloaded Successfully"));
        }

        #endregion
    }
}