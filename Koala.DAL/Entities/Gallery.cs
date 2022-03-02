using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koala.DAL.Entities
{
    public class Gallery
    {
        public int ID { get; set; }
       

        [Column(TypeName = "varchar(50)"), Display(Name = "Kategori Adı"), StringLength(50), Required(ErrorMessage = "Galeri İsmi Boş Bırakılamaz...")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(150)"), Display(Name = "Açıklama"), StringLength(150)]
        public string Description { get; set; }

        public ICollection<GalleryPicture> GalleryPictures { get; set; }



    }
}
