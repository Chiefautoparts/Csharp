namespace quotesPRAC.Models
{
    public class Quotes : BaseEntity
    {
        public int quotesid { get; set; }
        public string author { get; set; }
        public string comments { get; set; }
    }
}