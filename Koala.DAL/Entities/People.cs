using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koala.DAL.Entities
{
    public class People
    {
        public int ID { get; set; }

        [Column(TypeName = "varchar(150)"), Display(Name = "İsim"), StringLength(150)]

        public string Name { get; set; }

        [Column(TypeName = "varchar(150)"), Display(Name = "Unvan"), StringLength(150)]

        public string Title { get; set; }

        [Column(TypeName = "varchar(150)"), Display(Name = "Galeri Yolu"), StringLength(150), Required(ErrorMessage = "Galeri Yolu Boş Geçilemez...")]

        public string Path { get; set; }
    }
}
