using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_agile_concrete_models
{
    [Table("Klanten")]
    public partial class Klant:BasisKlasse
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Naam { get; set; }
        public string Voornaam { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Telefoon { get; set; }
        [Required]
        public string Straat { get; set; }
        [Required]
        public int Huisnummer { get; set; }
        [Required]
        public string Gemeente { get; set; }
        [Required]
        public int Postcode { get; set; }
        public string BTWNummer { get; set; }
        public List<Factuur> Factuurs { get; set; }
    }
}
