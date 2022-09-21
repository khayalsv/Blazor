namespace StateApprove.Data
{
    public class Stage
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Stage";
        public int Sequence { get; set; }


        public Company? Company { get; set; }
        public int? CompanyId { get; set; }


        public List<User>? UserList { get; set; }
    }
}
