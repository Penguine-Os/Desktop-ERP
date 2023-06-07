using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_agile_concrete_WPF.ViewModels.DialogViewModels
{
    class ErrorMessageDialogModel:BaseViewModel
    {
        public ErrorMessageDialogModel() { }
        public string ErrorMessage { get; set; }

        public override string this[string columnName] => throw new NotImplementedException();

        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            switch (parameter.ToString())
            {

                case "Confirm":
                    DialogHost.Close("ErrorDialog");

                    break;
                default:
                    DialogHost.Close("ErrorDialog");
                    break;
            }
        }
    }
}
