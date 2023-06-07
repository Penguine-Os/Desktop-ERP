using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_agile_concrete_WPF.ViewModels.DialogViewModels
{
    class ErrorStockDialogModel:BaseViewModel
    {
        public ErrorStockDialogModel() { }
        public string ErrorMessage { get; set; }
        public Action FactuurEvent;

        public override string this[string columnName] => throw new NotImplementedException();

        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            switch (parameter.ToString())
            {

                case "Confirm":
                    FactuurEvent?.Invoke();
                    DialogHost.Close("ErrorStockDialog");                    
                    break;
                default:
                    DialogHost.Close("ErrorStockDialog");
                    break;
            }
        }
    }
}

