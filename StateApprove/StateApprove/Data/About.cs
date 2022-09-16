namespace StateApprove.Data
{
    public class About
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Sequence { get; set; }
        public double Amount { get; set; }
        public Role? Role { get; set; }
        public int RoleId { get; set; }
    }
}
