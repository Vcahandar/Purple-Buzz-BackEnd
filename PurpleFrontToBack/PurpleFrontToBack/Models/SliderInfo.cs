namespace PurpleFrontToBack.Models
{
    public class SliderInfo:BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string IsActive { get; set; }
        public int SliderImgId { get; set; }
        public SliderImg SliderImg { get; set; }
    }
}
