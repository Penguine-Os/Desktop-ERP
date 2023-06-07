using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_agile_concrete_models
{
    
    public abstract class BasisKlasse : IDataErrorInfo, ICloneable
    {
        public bool IsGeldig() => string.IsNullOrWhiteSpace(Error);

        public virtual object Clone()
        {
            return MemberwiseClone();
        }

        public abstract string this[string columnName] { get; }

        public string Error
        {
            get
            {
                string errorMessage = "";

                foreach (var item in this.GetType().GetProperties())
                {
                    if (item.CanRead)
                    {

                        string error = this[item.Name];
                        if (!string.IsNullOrWhiteSpace(error))
                        {
                            errorMessage += error + Environment.NewLine;
                        }
                    }
                }
                return errorMessage;
            }
        }
    }
}
