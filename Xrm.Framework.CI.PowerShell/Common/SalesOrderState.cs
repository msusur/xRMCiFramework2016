using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Xrm.Framework.CI.Common.Entities
{
    [DataContract]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public enum SalesOrderState
    {
        [EnumMember] Active = 0,

        [EnumMember] Submitted = 1,

        [EnumMember] Canceled = 2,

        [EnumMember] Fulfilled = 3,

        [EnumMember] Invoiced = 4
    }
}