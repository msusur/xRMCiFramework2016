using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Xrm.Framework.CI.Common.Entities
{
    [DataContract]
    [GeneratedCode("CrmSvcUtil", "6.0.0000.0809")]
    public enum BulkDeleteOperationState
    {
        [EnumMember] Ready = 0,

        [EnumMember] Suspended = 1,

        [EnumMember] Locked = 2,

        [EnumMember] Completed = 3
    }
}