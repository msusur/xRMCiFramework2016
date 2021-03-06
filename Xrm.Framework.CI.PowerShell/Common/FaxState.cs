using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Xrm.Framework.CI.Common.Entities
{
    [DataContract]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public enum FaxState
    {
        [EnumMember] Open = 0,

        [EnumMember] Completed = 1,

        [EnumMember] Canceled = 2
    }
}