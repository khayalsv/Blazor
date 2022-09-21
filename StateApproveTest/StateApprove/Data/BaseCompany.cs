namespace StateApprove.Data
{
    public class BaseCompany
    {
        public int Id { get; set; }
        public string Name { get; set; } = "BaseCompany";

        public List<Company>? Companies { get; set; }
    }
}
