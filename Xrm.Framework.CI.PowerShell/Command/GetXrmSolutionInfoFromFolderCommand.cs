using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Xml.Linq;

namespace Xrm.Framework.CI.PowerShell.Command
{
    [Cmdlet(VerbsCommon.Get, "XrmSolutionInfoFromFolder")]
    public class GetXrmSolutionInfoFromFolderCommand : Cmdlet
    {
        #region Parameters

        [Parameter(Mandatory = true)]
        public string SolutionFilesFolderPath { get; set; }

        #endregion

        #region Process Record

        protected override void ProcessRecord()
        {
            base.ProcessRecord();

            base.WriteVerbose(string.Format("Reading Solution Files Folder: {0}", SolutionFilesFolderPath));

            string uniqueName;
            string version;

            using (var reader = new StreamReader(SolutionFilesFolderPath + "\\Other\\Solution.xml"))
            {
                XElement solutionNode = XElement.Load(reader);
                uniqueName = solutionNode.Descendants("UniqueName").First().Value;
                version = solutionNode.Descendants("Version").First().Value;
            }

            var info = new XrmSolutionInfo
            {
                UniqueName = uniqueName,
                Version = version
            };

            base.WriteObject(info);
        }

        #endregion
    }
}