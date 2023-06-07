using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_agile_concrete_models
{
    public class Winkel
    {
        [Required]
        public string Gemeente { get; set; }
        [Required]
        public string Naam { get; set; }
        [Key]
        public int Id { get; set; }
        [Required]
        public int Postcode { get; set; }
        public List<Factuur> Facturen { get; set; }
        public override string ToString()
        {
            return Naam;
        }
    }
}
