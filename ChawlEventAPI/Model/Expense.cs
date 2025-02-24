namespace ChawlEvent.Model
{
    public class Expense
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Amount { get; set; }
        public int ExpenseAssetId { get; set; }
        public DateTime Date { get; set; }
        public bool IsSettled { get; set; }
    }
}
