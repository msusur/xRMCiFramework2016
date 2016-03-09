using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Xrm.Framework.CI.Common.Entities
{
    [DataContract]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public enum WorkflowState
    {
        [EnumMember] Draft = 0,

        [EnumMember] Activated = 1
    }
}