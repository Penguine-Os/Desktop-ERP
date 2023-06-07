using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_agile_concrete_models
{
    [Table("Stock")]
    public partial class Stock : BasisKlasse
    {
       

        [Key]
        public int Id { get; set; }
        [Required]
        public int Aantal { get; set; }
        public Product Product { get; set; }
        public Winkel Winkel { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int WinkelId { get; set; }
    }
}
