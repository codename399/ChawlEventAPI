using System.Runtime.Serialization;

namespace ChawlEvent.Model.Enum
{
    public enum UserType
    {
        [EnumMember(Value = "Regular")]
        Regular,
        [EnumMember(Value = "Admin")]
        Admin,
        [EnumMember(Value = "SuperAdmin")]
        SuperAdmin
    }
}
