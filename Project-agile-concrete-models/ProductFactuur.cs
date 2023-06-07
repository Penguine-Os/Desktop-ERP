using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_agile_concrete_models
{
    public partial class ProductFactuur
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("FactuurId")]
        public int FactuurId { get; set; }
        [ForeignKey("ProductId")]
        public int? ProductId { get; set; }
        [ForeignKey("DienstId")]
        public int? DienstId { get; set; }
        public Dienst Dienst { get; set; }
        public Factuur Factuur { get; set; }
        public Product Product { get; set; }

        private int _Hoeveelheid;

        public int Hoeveelheid
        {
            get { return _Hoeveelheid; }
            set
            {
                _Hoeveelheid = value < 0 ? 0 : value;
            }
        }

    }
}
