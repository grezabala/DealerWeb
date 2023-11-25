namespace DealerWebApp.DealertWeb.Models
{
    public class MPortadas
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public List<MBrands>? MBrands { get; set; }
    }
}
