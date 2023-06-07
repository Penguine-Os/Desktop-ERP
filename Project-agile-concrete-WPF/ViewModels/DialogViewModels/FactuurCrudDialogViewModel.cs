using Project_agile_concrete_models;
using System;

namespace Project_agile_concrete_WPF.ViewModels.DialogViewModels
{
    public class FactuurCrudDialogViewModel : IGenericCrudDialogViewModel<Factuur>
    {
        public string DeleteConfirmationMessage { get; set; }
        public string CommandName { get; set; }

        public event EventHandler<Factuur> CreateUpdateEvent;
        public event Action DeleteEvent;
    }
}
