namespace StateApprove.Data
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Sequence { get; set; }

        public List<About>? AboutList { get; set; }
    }
}
