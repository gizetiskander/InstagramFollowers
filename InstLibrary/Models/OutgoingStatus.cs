using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace InstLibrary.Models
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OutgoingStatus
    {
        [EnumMember(Value = "follows")]
        Follows,
        [EnumMember(Value = "requested")]
        Requested,
        [EnumMember(Value = "none")]
        None
    }
}