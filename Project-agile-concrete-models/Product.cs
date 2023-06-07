using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;


using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows;

namespace Project_agile_concrete_models
{
    [Table("Producten")]
    public partial class Product : Item
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Naam { get; set; }
        [Required]
        public bool EcoCheque { get; set; }
        [Required]
        public decimal Prijs { get; set; }
        public Categorie Categorie { get; set; }
        [Required]
        public int CategorieId { get; set; }
        public List<Stock> Stocks { get; set; }

        [NotMapped]
        public string ImageSource { get; set; } /*= "placeholder1.jpg";*/
        [NotMapped]
        public string EcoIconSource { get; set; }
        [NotMapped]
        public Visibility EcoVisibility { get; set; }
        [NotMapped]
        public int StockTot { get; set; }
        public Product()
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


    }
}
