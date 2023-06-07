using MaterialDesignThemes.Wpf;
using Microsoft.EntityFrameworkCore;
using Project_agile_concrete_DAL;
using Project_agile_concrete_DAL.UnitOfWork;
using Project_agile_concrete_models;
using Project_agile_concrete_WPF.ViewModels.DialogViewModels;
using Project_agile_concrete_WPF.Views.Dialogs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;

using System.Text;

using System.Windows;
using System.Windows.Media.Imaging;

namespace Project_agile_concrete_WPF.ViewModels
{

    public class KlantViewModel : BaseViewModel
    {

        private IUnitOfWork _unitOfWork = new UnitOfWork(new ProjectDBContext());
        public ObservableCollection<Klant> AlleKlanten { get; set; }

        public Visibility GroupBoxIsVisible { get; set; } = Visibility.Hidden;
        public bool FactuurIsSelected { get; set; } = false;
        public bool kltGridIsEnabled { get; set; } = true;
        private bool _drawerIsOpen;

        public bool DrawerIsOpen
        {
            get { return _drawerIsOpen; }
            set
            {
                _drawerIsOpen = value;
                kltGridIsEnabled = !_drawerIsOpen;
            }
        }


        public string SubTotalMessageValue { get; set; }
        public string SubTotalMessageKey { get; set; }
        private ObservableCollection<ProductFactuur> _producten;
        public ObservableCollection<ProductFactuur> Producten
        {
            get { return _producten; }
            set
            {
                _producten = value;
            }

        }
        private Factuur _geselecteerdeFactuur;

        public Factuur GeselecteerdeFactuur
        {
            get { return _geselecteerdeFactuur; }
            set
            {
                _geselecteerdeFactuur = value;
                var productList = _geselecteerdeFactuur?.Producten ?? new List<ProductFactuur>();
                Producten = new ObservableCollection<ProductFactuur>(productList.Where(x => x.ProductId != null));
                FactuurDiensten = new ObservableCollection<ProductFactuur>(productList?.Where(x => x.DienstId != null));
                FactuurIsSelected = true;
                SubTotalCalculeren(productList);
            }
        }

        private void SubTotalCalculeren(List<ProductFactuur> productList)
        {
            var btw = string.IsNullOrWhiteSpace(GeselecteerdeKlant.BTWNummer) ? 21 : 6;
            decimal ttl = 0;
            if (productList is null)
            {
                return;
            }
            foreach (var item in productList)
            {
                if (item.ProductId != null)
                    ttl += Math.Round(item.Hoeveelheid * item.Product.Prijs);
                else
                    ttl += Math.Round(item.Hoeveelheid * item.Dienst.Prijs);
            }
            StringBuilder sb = new();
            sb.AppendLine($"Total Excl. BTW:");
            sb.AppendLine($"{btw}% BTW:");
            sb.AppendLine($"Total Incl. BTW:");

            StringBuilder sb2 = new();
            sb2.AppendLine($"€ {ttl}");
            sb2.AppendLine($"€ {(ttl * btw) / 100}");
            sb2.AppendLine($"€ {ttl + (ttl * btw) / 100}");

            SubTotalMessageKey = sb.ToString();
            SubTotalMessageValue = sb2.ToString();
        }
        private List<Factuur> _lijstKlantFactuur;
        public List<Factuur> LijstKlantFactuur
        {
            get { return _lijstKlantFactuur; }
            set
            {
                if (GeselecteerdeKlant != null)
                    _lijstKlantFactuur = _unitOfWork.FactuurRepo.Ophalen(x => x.KlantId == GeselecteerdeKlant.Id, p => p.Producten).ToList();
                else
                    _lijstKlantFactuur = new List<Factuur>();

            }
        }
        public bool IsEnabledOnDialogClosed { get; set; } = true;
        public int BackgroundVisibility { get; set; } = 1;
        private string Foutmelding;

        private string _searchQuery;

        public string SearchQueryName
        {
            get { return _searchQuery; }
            set
            {
                _searchQuery = value;

                var filteredKlanten = AlleKlanten.Where(x => x.Naam.Contains(_searchQuery, StringComparison.OrdinalIgnoreCase));
                Klanten = new ObservableCollection<Klant>(filteredKlanten);

            }
        }

        private string _searchQueryBtw;

        public string SearchQueryBtw
        {
            get { return _searchQueryBtw; }
            set
            {
                _searchQueryBtw = value;

                if (string.IsNullOrWhiteSpace(_searchQueryBtw))
                {
                    Klanten = new ObservableCollection<Klant>(AlleKlanten);
                    return;
                }
                var filteredKlanten = AlleKlanten.Where(x =>
                {
                    if (x.BTWNummer is not null)
                        return x.BTWNummer.Contains(_searchQueryBtw);

                    return false;
                }).ToList();

                Klanten = new ObservableCollection<Klant>(filteredKlanten);



            }
        }
        private List<ProductFactuur> _stukkenLijst;
        public List<ProductFactuur> StukkenLijst
        {
            get { return _stukkenLijst; }
            set { _stukkenLijst = value; }
        }


        private Klant _geslecteerdeKlant;

        public Klant GeselecteerdeKlant
        {
            get { return _geslecteerdeKlant; }
            set
            {
                _geslecteerdeKlant = value;

                LijstKlantFactuur = new List<Factuur>(_geslecteerdeKlant?.Factuurs ?? new List<Factuur>());
                if (GeselecteerdeKlant != null)
                {
                    GeselecteerdeKlant.Factuurs = LijstKlantFactuur.ToList();
                    BackgroundVisibility = LijstKlantFactuur.Count() > 0 ? 0 : 1;
                    GroupBoxIsVisible = LijstKlantFactuur.Count() > 0 && _geslecteerdeKlant is not null ? Visibility.Visible : Visibility.Collapsed;
                }
                else
                {
                    LijstKlantFactuur = new List<Factuur>();
                    BackgroundVisibility = 1;
                    GroupBoxIsVisible = Visibility.Hidden;
                }
                DrawerHost drawerHost = new DrawerHost();

            }
        }
        private Klant _klantRecord;
        public Klant KlantRecord
        {
            get { return _klantRecord; }
            set
            {
                _klantRecord = value;
            }
        }

        private ObservableCollection<Klant> _klanten;
        private List<Factuur> _factuurs;
        private List<Product> _products;
        private List<Dienst> _dienst;

        public ObservableCollection<Klant> Klanten
        {
            get { return _klanten; }
            set { _klanten = value; }
        }
        public List<Factuur> Facturen
        {
            get { return _factuurs; }
            set { _factuurs = value; }
        }
        public List<Product> Products
        {
            get { return _products; }
            set { _products = value; }
        }
        public List<Dienst> Diensten
        {
            get { return _dienst; }
            set
            {
                _dienst = value;

            }
        }
        private ObservableCollection<ProductFactuur> _factuurDiensten;
        public ObservableCollection<ProductFactuur> FactuurDiensten
        {
            get { return _factuurDiensten; }
            set
            {
                _factuurDiensten = value;
                SubTotalCalculeren(StukkenLijst);
            }
        }

        public override string this[string columnName] => string.Empty;

        public BitmapImage ImageSource { get; set; }

        public KlantViewModel()
        {
            Products = new List<Product>(_unitOfWork.ProductRepo.Ophalen(p => p.Categorie));
            Diensten = new List<Dienst>(_unitOfWork.DienstRepo.Ophalen(p => p.Categorie));
            Klanten = new ObservableCollection<Klant>(_unitOfWork.KlantRepo.Ophalen(x => x.Factuurs));
            Facturen = new List<Factuur>(_unitOfWork.FactuurRepo.Ophalen(p => p.Producten));

            AlleKlanten = Klanten;
            ImageSource = new BitmapImage(new Uri(AssignFullPath("ConstructionImg.png"), UriKind.RelativeOrAbsolute));
        }
        private string AssignFullPath(string fileName)
        {
            return Environment.CurrentDirectory.Split("bin")[0] + @$"Assets\Images\{fileName}";
        }


        public void AanmakenKlantEventHandler(object sender, Klant EventArgs)
        {
            KlantRecord = EventArgs;
            if (KlantRecord.IsGeldig())
            {
                _unitOfWork.KlantRepo.Add(KlantRecord);
                int ok = _unitOfWork.Save();

                FoutmeldingInstellenNaSave(ok, "Klant is niet toegevoegd.");

            }

        }

        private void FoutmeldingInstellenNaSave(int ok, string v)
        {
            if (ok > 0)
            {
                RefreshKlanten();
                Resetten();
            }
            else
            {

                MessageBox.Show(v);
            }
        }


        private void Resetten()
        {
            if (this.IsGeldig())
            {
                GeselecteerdeKlant = null;
                KlantRecord = new Klant();
            }
            else
            {
                MessageBox.Show(this.Error);
            }
        }

        private void RefreshKlanten()
        {

            Klanten = new ObservableCollection<Klant>(_unitOfWork.KlantRepo.GetAll());

        }

        public void UpdateKlantEventHandler(object sender, Klant EventArgs)
        {

            KlantRecord = EventArgs;
            if (KlantRecord != null)
            {
                if (KlantRecord.IsGeldig())
                {
                    _unitOfWork.KlantRepo.Update(KlantRecord);
                    int ok = _unitOfWork.Save();
                    FoutmeldingInstellenNaSave(ok, "Klant is niet aangepast.");
                }
            }
            else
            {
                MessageBox.Show("Selecteer een klant!");
            }

        }
        private void VerwijderKlantEventHandler()
        {
            if (GeselecteerdeKlant != null)
            {
                Klant klant = _unitOfWork.KlantRepo.ZoekOpPK(GeselecteerdeKlant.Id);
                _unitOfWork.KlantRepo.Delete(klant);
                int ok = _unitOfWork.Save();
                FoutmeldingInstellenNaSave(ok, "Klant is niet verwijderd.");
            }
            else
            {
                MessageBox.Show("Eerst klant selecteren");
            }
        }
        private async void AanmaakBewerkKlant()
        {
            KlantCrudDialogViewModel crudVm = new KlantCrudDialogViewModel(GeselecteerdeKlant);

            crudVm.CreateUpdateEvent += GeselecteerdeKlant == null ? AanmakenKlantEventHandler! : UpdateKlantEventHandler!;


            var view = new CreateUpdateKlantDialog
            {
                DataContext = crudVm
            };

            IsEnabledOnDialogClosed = false;

            await DialogHost.Show(view, "CreateUpdateDialog", null, ClosingEventHandler, ClosedEventHandler);

        }
        private void ExecuteRunDialog(Action openModal)
        {
            openModal?.Invoke();
        }
        private void ClosingEventHandler(object sender, DialogClosingEventArgs eventArgs)
        {
            //eventArgs.Cancel();
            IsEnabledOnDialogClosed = true;
            Debug.WriteLine("You can intercept the closing event, and cancel here.");
        }

        private void ClosedEventHandler(object sender, DialogClosedEventArgs eventArgs)
            => Debug.WriteLine("You can intercept the closed event here (1).");

        public override bool CanExecute(object parameter)
        {
            switch (parameter.ToString())
            {

                case "klantBewerken":
                case "KlantenVerwijderen":
                case "SelectieVerwijderen":
                    return GeselecteerdeKlant is not null;
            }
            return true;
        }

        public override void Execute(object parameter)
        {
            switch (parameter.ToString())
            {

                case "KlantenVerwijderen":
                    VerwijderKlantDialogOpenen();
                    break;
                case "klantToevoegen":
                    GeselecteerdeKlant = null;
                    ExecuteRunDialog(AanmaakBewerkKlant);
                    break;
                case "klantBewerken":
                    ExecuteRunDialog(AanmaakBewerkKlant);
                    break;
                case "SelectieVerwijderen":
                    GeselecteerdeKlant = null;
                    BackgroundVisibility = 1;
                    break;
            }
        }



        private async void VerwijderKlantDialogOpenen()
        {
            KlantCrudDialogViewModel crudVm = new KlantCrudDialogViewModel();
            crudVm.DeleteEvent += VerwijderKlantEventHandler;

            DeleteDialog verwijderModal = new DeleteDialog
            {
                DataContext = crudVm
            };

            IsEnabledOnDialogClosed = false;
            await DialogHost.Show(verwijderModal, "DeleteDialog", null, ClosingEventHandler, ClosedEventHandler);

        }


    }


}
