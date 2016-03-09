using System;
using System.Linq;
using System.Management.Automation;
using Xrm.Framework.CI.Common.Entities;

namespace Xrm.Framework.CI.PowerShell.Command
{
    [Cmdlet(VerbsCommon.Set, "XrmSolutionVersion")]
    public class SetXrmSolutionVersionCommand : XrmCommandBase
    {
        #region Parameters

        [Parameter(Mandatory = true)]
        public string SolutionName { get; set; }

        [Parameter(Mandatory = true)]
        public string Version { get; set; }

        #endregion

        #region Process Record

        protected override void ProcessRecord()
        {
            base.ProcessRecord();

            base.WriteVerbose(string.Format("Updating Solution {0} Version: {1}", SolutionName, Version));

            Solution solution;

            using (var context = new CIContext(OrganizationService))
            {
                var query = from s in context.SolutionSet
                            where s.UniqueName == SolutionName
                            select s;

                solution = query.FirstOrDefault();
            }

            if (solution == null)
            {
                throw new Exception(string.Format("Solution {0} could not be found", SolutionName));
            }

            var update = new Solution
            {
                Id = solution.Id,
                Version = Version
            };

            OrganizationService.Update(update);

            base.WriteVerbose(string.Format("Solution {0} Update to Version: {1}", SolutionName, Version));
        }

        #endregion
    }
}