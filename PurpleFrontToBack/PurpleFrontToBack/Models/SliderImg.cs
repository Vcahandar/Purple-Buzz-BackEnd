namespace PurpleFrontToBack.Models
{
    public class SliderImg:BaseEntity
    {
        public string? Image { get; set; }
        public ICollection<SliderInfo> SliderInfos { get; set; }
    }
}
