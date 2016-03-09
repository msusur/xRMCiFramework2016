using System.Linq;
using System.Management.Automation;
using Xrm.Framework.CI.Common.Entities;

namespace Xrm.Framework.CI.PowerShell.Command
{
    [Cmdlet(VerbsCommon.Get, "XrmSolution")]
    public class GetXrmSolutionCommand : XrmCommandBase
    {
        #region Parameters

        [Parameter(Mandatory = true)]
        public string UniqueSolutionName { get; set; }

        #endregion

        #region Process Record

        protected override void ProcessRecord()
        {
            base.ProcessRecord();

            base.WriteVerbose(string.Format("Exporting Solution: {0}", UniqueSolutionName));

            using (var context = new CIContext(OrganizationService))
            {
                var query = from s in context.SolutionSet
                            where s.UniqueName == UniqueSolutionName
                            select s;

                Solution solution = query.FirstOrDefault();

                WriteObject(solution);
            }
        }

        #endregion
    }
}