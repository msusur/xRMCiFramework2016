using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Management.Automation;
using System.Xml.Linq;

namespace Xrm.Framework.CI.PowerShell.Command
{
    [Cmdlet(VerbsCommon.Get, "XrmSolutionInfoFromZip")]
    public class GetXrmSolutionInfoFromZipCommand : Cmdlet
    {
        #region Parameters

        [Parameter(Mandatory = true)]
        public string SolutionFilePath { get; set; }

        #endregion

        #region Process Record

        protected override void ProcessRecord()
        {
            base.ProcessRecord();

            base.WriteVerbose(string.Format("Reading Solution Zip: {0}", SolutionFilePath));

            string uniqueName;
            string version;

            using (ZipArchive solutionZip = ZipFile.Open(SolutionFilePath, ZipArchiveMode.Read))
            {
                ZipArchiveEntry solutionEntry = solutionZip.GetEntry("solution.xml");

                using (var reader = new StreamReader(solutionEntry.Open()))
                {
                    XElement solutionNode = XElement.Load(reader);
                    uniqueName = solutionNode.Descendants("UniqueName").First().Value;
                    version = solutionNode.Descendants("Version").First().Value;
                }
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

    public class XrmSolutionInfo
    {
        public string UniqueName { get; set; }
        public string Version { get; set; }
    }
}