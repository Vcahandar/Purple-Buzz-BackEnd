using PurpleFrontToBack.Models;

namespace PurpleFrontToBack.ViewModels
{
    public class HomeVM
    {
        public SliderImg SliderImgs { get; set; }
        public IEnumerable<SliderInfo> SliderInfos { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<RecentWork> RecentWorks { get; set; }

        public Service Services { get; set; }

    }
}
