using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Xrm.Framework.CI.Common.Entities
{
    [DataContract]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public enum ContractState
    {
        [EnumMember] Draft = 0,

        [EnumMember] Invoiced = 1,

        [EnumMember] Active = 2,

        [EnumMember] OnHold = 3,

        [EnumMember] Canceled = 4,

        [EnumMember] Expired = 5
    }
}