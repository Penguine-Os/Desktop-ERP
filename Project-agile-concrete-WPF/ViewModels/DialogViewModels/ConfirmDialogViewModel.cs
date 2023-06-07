using MaterialDesignThemes.Wpf;
using Project_agile_concrete_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_agile_concrete_WPF.ViewModels.DialogViewModels
{
    public class ConfirmDialogViewModel:BaseViewModel
    {
        public ConfirmDialogViewModel() { }
        public override string this[string columnName] => throw new NotImplementedException();

        public event Action Confirm;
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            switch (parameter.ToString())
            {

                case "Confirm":
                    Confirm?.Invoke();
                    DialogHost.Close("ConfirmCloseDialog");

                    break;
                default:
                    DialogHost.Close("ConfirmCloseDialog");
                    break;
            }
        }
    }
}
