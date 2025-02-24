using System.Runtime.Serialization;

namespace ChawlEvent.Model.Enum
{
    public enum ContributionMode
    {
        [EnumMember(Value = "Cash")]
        Cash,
        [EnumMember(Value = "GPay")]
        GPay
    }
}
