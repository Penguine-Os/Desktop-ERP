using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Project_agile_concrete_models
{
    [Table("Diensten")]
    public partial class Dienst: Item, ICloneable
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Naam { get; set; }
        public Categorie Categorie { get; set; }
        [Required]
        public int CategorieId { get; set; }
        [Required]
        public decimal Prijs {get; set; }
        [NotMapped]
        public bool EcoCheque { get; set; }
        [NotMapped]
        public string EcoIconSource { get; set; }
        [NotMapped]
        public string ImageSource { get; set; } /*= "placeholder1.jpg";*/
        [NotMapped]
        public Visibility EcoVisibility { get; set; }
        public Dienst()
        {
            ImageSource = GetFullPath("placeholder1.jpg");
            EcoIconSource = GetFullPath("eco.png");

        }
        private string GetFullPath(string fileName)
        {
            var currentDirectory = Environment.CurrentDirectory;
            var junk = "bin\\Debug\\net6.0-windows";
            var fullPath = currentDirectory.Substring(0, currentDirectory.Length - junk.Length) + $@"Assets\Images\{fileName}";
            return fullPath;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
