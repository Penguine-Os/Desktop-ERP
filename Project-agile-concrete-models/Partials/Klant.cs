using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Project_agile_concrete_models
{
    public partial class Klant : BasisKlasse
    {
        public override string this[string columnName]
        {
            get
            {
                if (columnName == "Naam" && string.IsNullOrWhiteSpace(Naam))
                {
                    return "Naam is een verplicht veld!";
                }
                if (columnName == "Email" && string.IsNullOrWhiteSpace(Email))
                {
                    return "Email is een verplicht veld!";
                }
                if (columnName == "Telefoon" && string.IsNullOrWhiteSpace(Telefoon))
                {
                    return "Telefoon is een verplicht veld!";
                }
                if (columnName == "Straat" && string.IsNullOrWhiteSpace(Straat))
                {
                    return "Straat is een verplicht veld!";
                }
                if (columnName == "Huisnummer" && Huisnummer <= 0)
                {
                    return "Huis N° verplicht & > 0";
                }
                if (columnName == "Gemeente" && string.IsNullOrWhiteSpace(Gemeente))
                {
                    return "Gemeente is een verplicht veld!";
                }
                if (columnName == "Postcode" && Postcode <= 0)
                {
                    return "Postcode is verplicht & > 0";
                }
                if (columnName == "Straat" && string.IsNullOrWhiteSpace(Straat))
                {
                    return "Straat is een verplicht veld!";
                }
                return "";
            }
        }
    }
}
