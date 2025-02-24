using System.Runtime.Serialization;

namespace ChawlEvent.Model.Enum
{
    public enum ContributorType
    {
        [EnumMember(Value = "Owner")]
        Owner,
        [EnumMember(Value = "Rental")]
        Rental,
        [EnumMember(Value = "Outsider")]
        Outsider
    }
}
