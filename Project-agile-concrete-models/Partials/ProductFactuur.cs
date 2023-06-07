using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project_agile_concrete_models
{
    public partial class ProductFactuur : BasisKlasse
    {
        public override string this[string columnName]
        {
            get
            {
                if (columnName == "FactuurId" && FactuurId <=0)
                {
                    return "Selecteer bijhorend Factuur";
                }
                if (columnName == "ProductId" && ProductId <= 0)
                {
                    return "Selecteer bijhorend Product";
                }
                if (columnName == "Hoeveelheid" && Hoeveelheid <= 0)
                {
                    return "Eenheid product moet groter zijn dan 0";
                }
                return "";
            }
        }

        public override bool Equals(object obj)
        {

            if(Product is Product && Product.Id!=null && obj is ProductFactuur productFactuur && productFactuur.Product!=null) 
            {
                return  productFactuur.Product.Id == Product.Id;
            }
            else if (Dienst != null && obj is ProductFactuur dienstFactuur && dienstFactuur.Dienst!=null)
            {
                return dienstFactuur.DienstId == Dienst.Id;
            }
            else
            {
                return false;
            }

        }

        public override object Clone()
        {
            ProductFactuur productFactuur = (ProductFactuur) MemberwiseClone();
       //     productFactuur.Factuur = (Factuur)Factuur.Clone();
            productFactuur.Product = (Product)Product.Clone();
            productFactuur.Dienst = (Dienst)Dienst.Clone();

            return productFactuur;

        }
    }
}

