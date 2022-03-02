using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koala.DAL.Entities
{
    public abstract class Kitchen
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(50)"), Display(Name = "Menü"), StringLength(50)]
        public string Name { get; set; }
    }
}
