using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_agile_concrete_models
{
    [Table("Facturen")]
    public partial class Factuur
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime Datum { get; set; }
        [Required]
        public int WinkelId { get; set; }
        [ForeignKey("WinkelId")]
        public Winkel Winkel { get; set; }        
        public int? KlantId { get; set; }
        [ForeignKey("KlantId")]
        public Klant Klant { get; set; }
        public List<ProductFactuur> Producten { get; set; }
        
    }
}
