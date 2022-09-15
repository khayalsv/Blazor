using System.Text.Json.Serialization;

namespace EFRelationAPI.Data
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string RpgClass { get; set; } = string.Empty;
        [JsonIgnore]
        public User User { get; set; }
        public int UserId { get; set; }


    }
}
