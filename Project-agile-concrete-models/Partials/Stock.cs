using System;

namespace Project_agile_concrete_models
{
    public partial class Stock : BasisKlasse
    {
        public override string this[string columnName]
        {
            get
            {
                if (columnName == "Aantal" && Aantal < 0)
                {
                    return "Aantal mag niet onder 0";
                }
                if (columnName == "ProductId" && ProductId <= 0)
                {
                    return "Selecteer bijhorend Product";
                }
                if (columnName == "WinkelId" && WinkelId <= 0)
                {
                    return "Selecteer bijhorende Winkel";
                }
                return columnName;  
            }
        }
    }
}

