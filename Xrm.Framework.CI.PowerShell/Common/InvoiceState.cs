using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Xrm.Framework.CI.Common.Entities
{
    [DataContract]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public enum InvoiceState
    {
        [EnumMember] Active = 0,

        [EnumMember] Closed = 1,

        [EnumMember] Paid = 2,

        [EnumMember] Canceled = 3
    }
}