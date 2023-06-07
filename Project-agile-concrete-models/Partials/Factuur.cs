namespace Project_agile_concrete_models
{
    public partial class Factuur : BasisKlasse
    {
        public override string this[string columnName] 
        {
            get
            {
                if (columnName == "Datum" && Datum == null )
                {
                    return "Datum is een verplicht veld!";
                }
                if (columnName == "WinkelId" && WinkelId <=0 )
                {
                    return "Selecteer een winkel";
                }
                return "";
            }
        }
    }
    
}

