using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koala.DAL.Entities
{
    public class EventPicture
    {
        public int ID { get; set; }

        [Column(TypeName = "varchar(50)"), Display(Name = "Adı"), StringLength(50)]
        public string Name { get; set; }

        [Column(TypeName = "varchar(150)"), Display(Name = "Galeri Yolu"), StringLength(150), Required(ErrorMessage = "Galeri Yolu Boş Geçilemez...")]
        public string Path { get; set; }
        public int EventID { get; set; }
        public bool Enabled { get; set; }
        public Event Event { get; set; }

    }
}
