namespace PurpleFrontToBack.Models
{
    public class Package:BaseEntity
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string BgColor { get; set; }
        public ICollection<Offer> Offers { get; set; }
    }
}
