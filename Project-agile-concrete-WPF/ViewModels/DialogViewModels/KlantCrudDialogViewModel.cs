using MaterialDesignThemes.Wpf;
using Project_agile_concrete_models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Project_agile_concrete_WPF.ViewModels.DialogViewModels
{
    public class KlantCrudDialogViewModel: BaseViewModel, IGenericCrudDialogViewModel<Klant>
    {
        public event EventHandler<Klant> CreateUpdateEvent;
        public event Action DeleteEvent;

        public Visibility BtwVisiblity { get; set; }
        public Visibility FirstNameVisiblity { get; set; }

        public Klant Klant { get; set; }

        private bool _isPartiCulier;

        public bool IsParticulier
        {
            get { return _isPartiCulier; }
            set
            {
                _isPartiCulier = value;

                if (Klant is null || Klant.Id == 0)
                    ActieTitel = IsParticulier ? "Particulier Toevoegen" : "Onderneming Toevoegen";
                else
                    ActieTitel = IsParticulier ? "Particulier Bewerken" : "Onderneming Bewerken";

                WisselZichtbaarheidBtwEnVoornaalm();
            }
        }

        private void WisselZichtbaarheidBtwEnVoornaalm()
        {
            BtwVisiblity = !IsParticulier ? Visibility.Visible : Visibility.Collapsed;
            FirstNameVisiblity = IsParticulier ? Visibility.Visible : Visibility.Collapsed;
        }

        public string ActieTitel { get; set; }

        public string DeleteConfirmationMessage { get; set; } = "Are your sure you want to delete this?";
        public string CommandName { get; set; }

        public override string this[string columnName] => string.Empty;


        public KlantCrudDialogViewModel(Klant geselecteerdeKlant)
        {
            ZichbaarheidDynamischePresentatieElementenBepalen(geselecteerdeKlant);
        }

        private void ZichbaarheidDynamischePresentatieElementenBepalen(Klant geselecteerdeKlant)
        {
            if (geselecteerdeKlant == null)
            {
                CommandName = "Create";
                ActieTitel = IsParticulier ? "Particulier Toevoegen" : "Onderneming Toevoegen";
                Klant = new Klant();
            }
            else
            {

                Klant =(Klant) geselecteerdeKlant.Clone();
               
                CommandName = "Update";
                IsParticulier = !string.IsNullOrWhiteSpace(Klant.Voornaam ?? string.Empty);
                ActieTitel = IsParticulier ? "Particulier Bewerken" : "Onderneming Bewerken";
            }

            WisselZichtbaarheidBtwEnVoornaalm();
        }

        public KlantCrudDialogViewModel()
        {

        }

        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            switch (parameter.ToString())
            {
                case "Create":

                    if (!Klant.IsGeldig())
                        return;

                    CreateUpdateEvent?.Invoke(this, Klant);
                    DialogHost.Close("CreateUpdateDialog");

                    break;
                case "Update":

                    if (!Klant.IsGeldig())
                        return;

                    CreateUpdateEvent?.Invoke(this, Klant);
                    DialogHost.Close("CreateUpdateDialog");

                    break;

                case "Confirm":
                    DeleteEvent?.Invoke();
                    DialogHost.Close("DeleteDialog");

                    break;


            }
        }
    }
}
