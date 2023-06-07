using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_agile_concrete_WPF.ViewModels.DialogViewModels
{
    public interface IGenericCrudDialogViewModel<T> where T : class
    {
        string DeleteConfirmationMessage { get; set; }
        string CommandName { get; set; }

        public event EventHandler<T> CreateUpdateEvent;
        public event Action DeleteEvent;

    }
}
