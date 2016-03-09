using System;
using System.IO;
using System.Management.Automation;
using System.Threading;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;
using Xrm.Framework.CI.Common.Entities;

namespace Xrm.Framework.CI.PowerShell.Command
{
    [Cmdlet(VerbsData.Import, "XrmSolution")]
    public class ImportXrmSolutionCommand : XrmCommandBase
    {
        #region Parameters

        [Parameter(Mandatory = true)]
        public string SolutionFilePath { get; set; }

        [Parameter(Mandatory = false)]
        public bool PublishWorkflows { get; set; }

        [Parameter(Mandatory = false)]
        public bool ConvertToManaged { get; set; }

        [Parameter(Mandatory = false)]
        public bool OverwriteUnmanagedCustomizations { get; set; }

        [Parameter(Mandatory = false)]
        public bool SkipProductUpdateDependencies { get; set; }

        [Parameter(Mandatory = false)]
        public bool ImportAsync { get; set; }

        [Parameter(Mandatory = false)]
        public bool WaitForCompletion { get; set; }

        [Parameter(Mandatory = false)]
        public int SleepInterval { get; set; }

        [Parameter(Mandatory = false)]
        public int AsyncWaitTimeout { get; set; }

        [Parameter(Mandatory = false)]
        public Guid ImportJobId { get; set; }

        public ImportXrmSolutionCommand()
        {
            AsyncWaitTimeout = 15 * 60;
            SleepInterval = 15;
        }

        #endregion

        #region Process Record

        protected override void ProcessRecord()
        {
            base.ProcessRecord();

            base.WriteVerbose(string.Format("Importing Solution: {0}", SolutionFilePath));

            // TODO: I think this is not necessary because you will get back an Id if you overload Guid.Empty
            if (ImportJobId == Guid.Empty)
            {
                ImportJobId = Guid.NewGuid();
            }

            base.WriteVerbose(string.Format("ImportJobId {0}", ImportJobId));

            byte[] solutionBytes = File.ReadAllBytes(SolutionFilePath);

            var importSolutionRequest = new ImportSolutionRequest
            {
                CustomizationFile = solutionBytes,
                PublishWorkflows = PublishWorkflows,
                ConvertToManaged = ConvertToManaged,
                OverwriteUnmanagedCustomizations = OverwriteUnmanagedCustomizations,
                SkipProductUpdateDependencies = SkipProductUpdateDependencies,
                ImportJobId = ImportJobId,
                RequestId = ImportJobId
            };

            if (ImportAsync)
            {
                var asyncRequest = new ExecuteAsyncRequest
                {
                    Request = importSolutionRequest,
                    RequestId = ImportJobId
                };
                var asyncResponse = OrganizationService.Execute(asyncRequest) as ExecuteAsyncResponse;

                Guid asyncJobId = asyncResponse.AsyncJobId;

                WriteObject(asyncJobId);

                if (WaitForCompletion)
                {
                    AwaitCompletion(asyncJobId);
                }
            }
            else
            {
                OrganizationService.Execute(importSolutionRequest);
            }

            base.WriteVerbose(string.Format("{0} Imported Completed {1}", SolutionFilePath, ImportJobId));
        }

        private void AwaitCompletion(Guid asyncJobId)
        {
            DateTime end = DateTime.Now.AddSeconds(AsyncWaitTimeout);

            bool completed = false;
            while (!completed)
            {
                if (end < DateTime.Now)
                {
                    throw new Exception(string.Format("Import Timeout Exceeded: {0}", AsyncWaitTimeout));
                }

                Thread.Sleep(SleepInterval * 1000);

                AsyncOperation asyncOperation;

                try
                {
                    asyncOperation = OrganizationService.Retrieve("asyncoperation", asyncJobId,
                        new ColumnSet("asyncoperationid", "statuscode", "message")).ToEntity<AsyncOperation>();
                }
                catch (Exception ex)
                {
                    base.WriteWarning(ex.Message);
                    continue;
                }

                switch (asyncOperation.StatusCode.Value)
                {
                    //Succeeded
                    case 30:
                        completed = true;
                        break;
                    //Pausing //Canceling //Failed //Canceled
                    case 21:
                    case 22:
                    case 31:
                    case 32:
                        throw new Exception(string.Format("Solution Import Failed: {0} {1}",
                            asyncOperation.StatusCode.Value, asyncOperation.Message));
                }
            }
        }

        #endregion
    }
}