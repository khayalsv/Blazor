using System.Text.Json.Serialization;

namespace EFRelationAPI.Data
{
    public class CreateCharacterDto
    {
        public string Name { get; set; } = string.Empty;
        public string RpgClass { get; set; } = string.Empty;
        public int UserId { get; set; }
    }
}
