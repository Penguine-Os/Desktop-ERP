namespace Project_agile_concrete_models
{
    public partial class Categorie : BasisKlasse
    {
        public override string this[string columnName]
        {
            get
            {
                if (columnName == "Naam" && string.IsNullOrWhiteSpace(Naam))
                {
                    return "Naam is een verplicht veld!";
                }

                return "";
            }
        }
    }
}

