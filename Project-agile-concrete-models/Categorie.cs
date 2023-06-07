using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_agile_concrete_models
{
    public  partial class Categorie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Naam { get; set; }

        public override string ToString()
        {
            return Naam;
        }
    }
}
