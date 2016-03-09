using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Xrm.Framework.CI.Common.Entities
{
    [DataContract]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public enum LeadState
    {
        [EnumMember] Open = 0,

        [EnumMember] Qualified = 1,

        [EnumMember] Disqualified = 2
    }
}