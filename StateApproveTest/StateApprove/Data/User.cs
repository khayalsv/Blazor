namespace StateApprove.Data
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = "User";
        public double Amount { get; set; }
        public double AmountTo { get; set; }

        public Stage? Stage { get; set; }
        public int? StageId { get; set; }
    }
}
