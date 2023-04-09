namespace PurpleFrontToBack.Models
{
    public class ProductImg:BaseEntity
    {
        public string Image { get; set; }
        public bool IsMain { get; set; } = false;
        public int ProductId { get; set; }
        public Product Product { get; set; }


    }
}
