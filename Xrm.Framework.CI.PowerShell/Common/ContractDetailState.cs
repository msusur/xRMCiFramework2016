using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Xrm.Framework.CI.Common.Entities
{
    [DataContract]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public enum ContractDetailState
    {
        [EnumMember] Existing = 0,

        [EnumMember] Renewed = 1,

        [EnumMember] Canceled = 2,

        [EnumMember] Expired = 3
    }
}