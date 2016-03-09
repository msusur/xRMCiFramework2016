using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Xrm.Framework.CI.Common.Entities
{
    [DataContract]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public enum QuoteState
    {
        [EnumMember] Draft = 0,

        [EnumMember] Active = 1,

        [EnumMember] Won = 2,

        [EnumMember] Closed = 3
    }
}