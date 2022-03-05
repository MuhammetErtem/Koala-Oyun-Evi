using Koala.DAL.Entities;

namespace Koala.WEBUI.ViewModels
{
    public class IndexVm
    {
        public IEnumerable<Slider> Slider { get; set; }
        public IEnumerable<GalleryPicture> GalleryPicture { get; set; }
        public IEnumerable<People> People { get; set; }



    }
}
