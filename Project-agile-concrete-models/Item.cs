using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Project_agile_concrete_models
{
    public interface Item
    {
        int Id { get; }
        string Naam { get; }
        decimal Prijs { get; }
        int CategorieId { get; }
        bool EcoCheque { get; }
        string EcoIconSource { get; }
        string ImageSource { get; set; } /*= "placeholder1.jpg";*/
        Visibility EcoVisibility { get; set; }
    }
}
