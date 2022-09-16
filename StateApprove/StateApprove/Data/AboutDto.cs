namespace StateApprove.Data
{
    public class AboutDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Sequence { get; set; }
        public double Amount { get; set; }
        public int RoleId { get; set; }
        public string? RoleName { get; set; }

        public static Func<About, AboutDto> AboutFunc = (about) =>
            new AboutDto
            {
                Id = about.Id,
                Name = about.Name,
                Sequence=about.Sequence,
                Amount = about.Amount,
                RoleId = about.RoleId,
                RoleName = about.Role?.Name
            };

    }
}
