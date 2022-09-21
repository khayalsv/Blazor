namespace StateApprove.Data
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Company";
        public string Description { get; set; } = "Description";

        public BaseCompany? BaseCompany { get; set; }
        public int? BaseCompanyId { get; set; }
        public List<Stage>? StageList { get; set; }
    }
}
