using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Xrm.Framework.CI.Common.Entities
{
    [DataContract]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public enum OpportunityState
    {
        [EnumMember] Open = 0,

        [EnumMember] Won = 1,

        [EnumMember] Lost = 2
    }
}