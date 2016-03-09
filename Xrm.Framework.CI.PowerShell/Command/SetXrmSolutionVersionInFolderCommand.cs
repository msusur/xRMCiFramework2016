using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Xml.Linq;

namespace Xrm.Framework.CI.PowerShell.Command
{
    [Cmdlet(VerbsCommon.Set, "XrmSolutionVersionInFolder")]
    public class SetXrmSolutionVersionInFolderCommand : Cmdlet
    {
        #region Parameters

        [Parameter(Mandatory = true)]
        public string SolutionFilesFolderPath { get; set; }

        [Parameter(Mandatory = true)]
        public string Version { get; set; }

        #endregion

        #region Process Record

        protected override void ProcessRecord()
        {
            base.ProcessRecord();

            string solutionFile = SolutionFilesFolderPath + "\\Other\\Solution.xml";

            base.WriteVerbose(string.Format("Reading Solution File: {0}", solutionFile));

            XElement solutionNode;

            using (var reader = new StreamReader(solutionFile))
            {
                solutionNode = XElement.Load(reader);
                string uniqueName = solutionNode.Descendants("UniqueName").First().Value;

                base.WriteVerbose(string.Format("Updating Version for Solution: {0}", uniqueName));

                solutionNode.Descendants("Version").First().Value = Version;
            }

            solutionNode.Save(solutionFile);
        }

        #endregion
    }
}