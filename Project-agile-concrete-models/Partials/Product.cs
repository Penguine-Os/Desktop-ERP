using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_agile_concrete_models
{
    public partial class Product : BasisKlasse
    {
        public override string this[string columnName]
        {
            get

            {
                if (columnName == "Naam" && string.IsNullOrWhiteSpace(Naam))
                {
                    return "Naam is een verplicht veld!";
                }
                if (columnName == "Prijs" && Prijs <= 0)
                {
                    return "Prijs moet groter zijn dan 0!";
                }
                if (columnName == "Categorie" && CategorieId <= 0)
                {
                    return "Categorie moet geselecteerd worden";
                }
                return "";
            }
        }
    }
}

