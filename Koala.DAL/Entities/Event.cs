using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koala.DAL.Entities
{
    public class Event
    {
        public int ID { get; set; }

        [Column(TypeName = "varchar(50)"), Display(Name = "Başlık"), StringLength(50)]
        public string Name { get; set; }
        [Column(TypeName = "text"), Display(Name = "Açıklama")]
        public string Description { get; set; }
        [Display(Name = "Kayıt Tarihi")]
        public DateTime DateOfEvent { get; set; }
        public bool Enabled { get; set; }
        public ICollection<EventPicture> EventPictures { get; set; }
    }
}
