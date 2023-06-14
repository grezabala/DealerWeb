namespace DealerWebApp.DealertWeb.Models
{
    public class MCars
    {
        public int CardId { get; set; }
        public string NameCard { get; set; }
        public List<MVehiculos> MVehiculos { get; set; }
    }
}
