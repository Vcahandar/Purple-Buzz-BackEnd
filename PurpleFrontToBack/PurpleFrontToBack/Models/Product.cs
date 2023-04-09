namespace PurpleFrontToBack.Models
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<ProductImg> Images { get; set; }
        public int CategoryId { get; set; }
        public Category Categories { get; set; }


    }
}
