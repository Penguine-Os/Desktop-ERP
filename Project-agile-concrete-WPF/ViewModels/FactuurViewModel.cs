using MaterialDesignThemes.Wpf;
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
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;

namespace Project_agile_concrete_WPF.ViewModels
{
    public class FactuurViewModel : BaseViewModel
    {
        IUnitOfWork _unitOfWork = new UnitOfWork(new ProjectDBContext());

     
        public bool StukkenLijstIsOpgevuld { get; set; }
        public bool BtwIsEnabled { get; set; }
        public Visibility KlantenKortingVisibility { get; set; } = Visibility.Collapsed;


        private int _categorieId;
        public int CategorieId
        {
            get { return _categorieId; }
            set
            {
                _categorieId = value;
                if (_categorieId > 0)
                {
                    ItemProducten = new ObservableCollection<Item>(Producten.Where(c => c.CategorieId == _categorieId));



                    return;
                    

                }

                ItemProducten = new ObservableCollection<Item>(Producten);

            }
        }
        public int CategorieSelectedIndex { get; set; } = -1;

        public int ProductEenheid { get; set; }

        private int _geselecteerdeBtw { get; set; }
        public int GeselecteerdeBtw
        {
            get { return _geselecteerdeBtw; }
            set
            {
                _geselecteerdeBtw = value;

                SubTotalCalculeren();
            }
        }
    
        public int KlantenKorting { get; set; }
        public int BtwSelectedIndex { get; set; }
      


        private string _searchQueryProductNaam;
        public string SearchQueryProductNaam
        {
            get { return _searchQueryProductNaam; }
            set
            {
                GeselecteerdeProduct = new Product();
                _searchQueryProductNaam = value;
                var filteredproducten = Producten.Where(x => x.Naam.Contains(_searchQueryProductNaam, StringComparison.OrdinalIgnoreCase));
                ItemProducten = new ObservableCollection<Item>(filteredproducten);
            }
        }

        private string _searchQueryKlant;

        public string SearchQueryKlant
        {
            get { return _searchQueryKlant; }
            set
            {
                _searchQueryKlant = value; 

                if (Klanten.Where(x => x.Naam.Contains(_searchQueryKlant)).Count() == 0 || string.IsNullOrWhiteSpace(_searchQueryKlant))
                {
                    _geselecteerdeKlant = null;
                    BtwIsEnabled = false;
                    BtwToeslagen = new ObservableCollection<int>(new int[] { 21 });
                    BtwSelectedIndex = 0;
                    KlantenKorting = 0;
                    KlantenKortingVisibility = Visibility.Collapsed;
                    SubTotalCalculeren();
                }

            }
        }
        public override string this[string columnName] => string.Empty;
        public string SubTotalMessageKey { get; set; }
        public string SubTotalMessageValue { get; set; }

        private Winkel _geselcteerdeWinkel;
        public Winkel GeselecteerdeWinkel
        {
            get { return _geselcteerdeWinkel; }
            set
            {
                _geselcteerdeWinkel = value;
            }
        }
        private Klant _geselecteerdeKlant;
        public Klant GeselecteerdeKlant
        {
            get { return _geselecteerdeKlant; }
            set
            {


                _geselecteerdeKlant = value;
         

                if (GeselecteerdeKlant is null)
                    return;

                var aantAankopen = 0;
                if (_geselecteerdeKlant.Factuurs != null)
                    aantAankopen = _geselecteerdeKlant.Factuurs.Count();


                if (!string.IsNullOrWhiteSpace(_geselecteerdeKlant?.BTWNummer))
                {

                    BtwIsEnabled = true;
                    BtwToeslagen = new ObservableCollection<int>(new int[] { 6, 0 });
                    KlantenKorting = (aantAankopen > 0 && (aantAankopen + 1) % 10 == 0) ? 30 : 15;

                }
                else
                {
                    BtwIsEnabled = false;
                    BtwToeslagen = new ObservableCollection<int>(new int[] { 21 });
                    KlantenKorting = (aantAankopen > 0 && (aantAankopen + 1) % 10 == 0) ? 15 : 5;
                }

                BtwSelectedIndex = 0;


                KlantenKortingVisibility = Visibility.Visible;
                SubTotalCalculeren();
            }
        }
        public ProductFactuur ProductFactuur { get; set; }


        public ObservableCollection<Item> ItemProducten { get; set; }
        private Item _geselecteerdeProduct;

        public Item GeselecteerdeProduct
        {
            get { return _geselecteerdeProduct; }
            set
            {
                if (value == null)
                    return;

                if (value.GetType() == typeof(Product))
                    _geselecteerdeProduct = (Product)value;
                else
                    _geselecteerdeProduct = (Dienst)value;
            }
        }
        public ObservableCollection<Klant> Klanten { get; set; }
        private ObservableCollection<Winkel> _winkels;
        public ObservableCollection<Winkel> Winkels
        {
            get { return _winkels; }
            set
            {
                _winkels = value;
            }
        }

        private ObservableCollection<Categorie> _categoriëen;

        public ObservableCollection<Categorie> Categoriëen
        {
            get { return _categoriëen; }
            set { _categoriëen = value; }

        }
        public ObservableCollection<int> BtwToeslagen { get; set; }

        public ObservableCollection<Item> Producten { get; set; }

        private ObservableCollection<ProductFactuur> _stukkenLijst;
        private ObservableCollection<ProductFactuur> _stukkenLijstDienst;
        private ObservableCollection<ProductFactuur> _stukkenLijstProduct;

        public ObservableCollection<ProductFactuur> StukkenLijst
        {
            get
            {

                return _stukkenLijst;
            }
            set
            {
                _stukkenLijst = value;
                if (_stukkenLijst?.Count() > 0)
                {
                    StukkenLijstIsOpgevuld = true;
                    SubTotalCalculeren();
                }
            }
        }
        public ObservableCollection<ProductFactuur> StukkenLijstDiensten
        {
            get
            {

                return _stukkenLijstDienst;
            }
            set
            {
                _stukkenLijstDienst = value;
                if (_stukkenLijstDienst?.Count() > 0)
                {
                    SubTotalCalculeren();
                }
            }
        }
        public ObservableCollection<ProductFactuur> StukkenLijstProducten
        {
            get
            {

                return _stukkenLijstProduct;
            }
            set
            {
                _stukkenLijstProduct = value;
                if (_stukkenLijstProduct?.Count() > 0)
                {
                    SubTotalCalculeren();
                }
            }
        }
        private List<Stock> _lijstStock;
        public List<Stock> LijstStock
        {
            get { return _lijstStock; }
            set
            {
                _lijstStock = value;
            }
        }
        private string _stockTekort;
        public string StockTekort
        {
            get { return _stockTekort; }
            set { _stockTekort = value; }
        }
        private List<ProductFactuur> _tempList;
        public List<ProductFactuur> TempList
        {
            get { return _tempList; }
            set { _tempList = value; }
        }
        public bool StockAangemaakt { get; set; }

        public FactuurViewModel()
        {
            InitializeContent();

        }

        private void InitializeContent()
        {
            StukkenLijst = new ObservableCollection<ProductFactuur>();
            StukkenLijstProducten = new ObservableCollection<ProductFactuur>(StukkenLijst.Where(x => x.ProductId != null));
            StukkenLijstDiensten = new ObservableCollection<ProductFactuur>(StukkenLijst.Where(x => x.DienstId != null));
            StukkenLijstIsOpgevuld = false;
            LijstStock = new List<Stock>(_unitOfWork.StockRepo.Ophalen(x => x.Winkel, p => p.Product));
            Winkels = new ObservableCollection<Winkel>(_unitOfWork.WinkelRepo.GetAll());
            BtwToeslagen = new ObservableCollection<int>(new int[] { 21, 6, 0 });
            BtwSelectedIndex = 0;
            Klanten = new ObservableCollection<Klant>(_unitOfWork.KlantRepo.Ophalen(x => x.Factuurs).OrderByDescending(x => x.BTWNummer));

            ItemProducten = new ObservableCollection<Item>();
            var products = new ObservableCollection<Item>(_unitOfWork.ProductRepo.GetAll().OrderBy(x => x.Prijs));
            var diensten = new ObservableCollection<Item>(_unitOfWork.DienstRepo.GetAll());
            foreach (var item in products) { ItemProducten.Add(item); };
            foreach (var item in diensten) { ItemProducten.Add(item); };

            ObservableCollection<Item> tempProducten = ItemProducten;

            foreach (var x in tempProducten) { x.EcoVisibility = x.EcoCheque ? Visibility.Visible : Visibility.Collapsed; };
            Producten = new ObservableCollection<Item>(tempProducten);
            ProductFactuur = new ProductFactuur();

            //x => x.EcoVisibility = x.EcoCheque ? Visibility.Visible : Visibility.Collapsed

            Categoriëen = new ObservableCollection<Categorie>(_unitOfWork.CategorieRepo.GetAll());
        }

        private void SubTotalCalculeren()
        {
            if (StukkenLijst == null || StukkenLijst.Count() < 0)
                return;

            decimal total = Math.Round(StukkenLijst.Select(x => x.Hoeveelheid * x.Product.Prijs).Sum(x => x));
            total += Math.Round(StukkenLijst.Select(x => x.Hoeveelheid * x.Dienst.Prijs).Sum(x => x));
            decimal btwToeslag = total * (GeselecteerdeBtw) / 100;
            decimal klatKorting = total * (KlantenKorting) / 100;

            decimal totalIncBtw = total + btwToeslag - klatKorting;

            StringBuilder sb = new();
            sb.AppendLine($"Total Excl. BTW:");
            sb.AppendLine($"{GeselecteerdeBtw}% BTW:");
            sb.AppendLine($"{KlantenKorting}% (Klantenkorting):");
            sb.AppendLine($"Total Incl. BTW:");

            StringBuilder sb2 = new();
            sb2.AppendLine($"   € {total}");
            sb2.AppendLine($" + € {btwToeslag}");
            sb2.AppendLine($" - € {klatKorting}");
            sb2.AppendLine($"   € {totalIncBtw}");

            SubTotalMessageKey = sb.ToString();
            SubTotalMessageValue = sb2.ToString();
        }
        private void ArtikelsToevoegen()
        {
            if (GeselecteerdeProduct is null) { return; }
            if (GeselecteerdeProduct.GetType() == typeof(Product) && GeselecteerdeProduct != null)
            {
                
                ProductFactuur = new ProductFactuur();
                ProductFactuur.FactuurId = 1;
                ProductFactuur.ProductId = GeselecteerdeProduct?.Id ?? 0;
                ProductFactuur.Dienst = new Dienst();
                ProductFactuur.Product = (Product)GeselecteerdeProduct;
                ProductFactuur.Hoeveelheid = ProductEenheid;
            }
            else
            {

                ProductFactuur = new ProductFactuur();
                ProductFactuur.FactuurId = 1;
                ProductFactuur.DienstId = GeselecteerdeProduct?.Id ?? 0;
                ProductFactuur.Dienst = (Dienst)GeselecteerdeProduct;
                ProductFactuur.Product = new Product();
                ProductFactuur.Hoeveelheid = ProductEenheid;

            }


            if (!ProductFactuur.IsGeldig())
                return;


            if (StukkenLijst.Contains(ProductFactuur))
            {
                StukkenLijst.First(x => x.ProductId == ProductFactuur.ProductId).Hoeveelheid += ProductEenheid;

                StukkenLijst = new ObservableCollection<ProductFactuur>(StukkenLijst);
                StukkenLijstProducten = new ObservableCollection<ProductFactuur>(StukkenLijst.Where(x => x.ProductId != null));
                StukkenLijstDiensten = new ObservableCollection<ProductFactuur>(StukkenLijst.Where(x => x.DienstId != null));
                ProductEenheid = 0;
            }
            else
            {
                StukkenLijst.Add(ProductFactuur);
                StukkenLijst = new ObservableCollection<ProductFactuur>(StukkenLijst);
                StukkenLijstProducten = new ObservableCollection<ProductFactuur>(StukkenLijst.Where(x => x.ProductId != null));
                StukkenLijstDiensten = new ObservableCollection<ProductFactuur>(StukkenLijst.Where(x => x.DienstId != null));
                ProductEenheid = 0;

            }
            SubTotalCalculeren();
        }
        private void ArtikelsVerwijderen()
        {
            StukkenLijst.Remove(ProductFactuur);
            StukkenLijstProducten = new ObservableCollection<ProductFactuur>(StukkenLijst.Where(x => x.ProductId != null));
            StukkenLijstDiensten = new ObservableCollection<ProductFactuur>(StukkenLijst.Where(x => x.DienstId != null));
            SubTotalCalculeren();
            StukkenLijstIsOpgevuld = StukkenLijst?.Count() > 0;
        }
        public void FactuurDoorsturen()
        {

            TempList = new List<ProductFactuur>();
            if (StukkenLijstDiensten.Count() > 0)
            {
                TempList.AddRange(StukkenLijstDiensten.ToList());
            }
            if (StukkenLijstProducten.Count() > 0)
            {
                TempList.AddRange(StukkenLijstProducten.ToList());
            }

            if (GeselecteerdeWinkel is object && GeselecteerdeWinkel.Id != null)
            {
                StockTekort = string.Empty;
                foreach (var item in TempList)
                {
                    int totStock = 0;
                    if (item.ProductId != null)
                    {
                        foreach (var stock in LijstStock)
                        {
                            if (item.ProductId == stock.ProductId)
                            {
                                totStock += stock.Aantal;
                            }
                        }
                        if (totStock < item.Hoeveelheid)
                        {
                            StockTekort += item.Product.Naam + Environment.NewLine;
                        }
                    }
                }
                if(StockTekort != string.Empty)
                {
                    AanvragenStockBestellen();
                }
                else
                {
                    FactuurAanmaken();
                }

            }
            else
            {
                int ok = 0;
                FoutmeldingInstellenNaSave(ok, "Gelieve een winkel te selecteren!");
            }


        }
        public void FactuurAanmaken()
        {
            var factuur = new Factuur()
            {
                Winkel = GeselecteerdeWinkel,
                WinkelId = GeselecteerdeWinkel.Id,
                Producten = TempList,
                Datum = DateTime.Now
            };
            if (GeselecteerdeKlant is object)
            {
                factuur.Klant = GeselecteerdeKlant;
                factuur.KlantId = GeselecteerdeKlant.Id;
            }
            if (!factuur.IsGeldig())
                return;
            _unitOfWork.FactuurRepo.FactuurAanmaken(factuur);
            int ok = _unitOfWork.Save();
            StockAangemaakt = ok > 0;
            FoutmeldingInstellenNaSave(ok, "Factuur is niet aangemaakt!");
        }
        public bool IsEnabledOnDialogClosed { get; set; } = true;
        private async void AanvragenStockBestellen()
        {
            ErrorStockDialogModel crudVm = new ErrorStockDialogModel();
            crudVm.ErrorMessage = "Dit zijn de producten die niet op stock zijn: "+ Environment.NewLine+ StockTekort + Environment.NewLine + "Wil je hier toch een bestelling van maken?";
            crudVm.FactuurEvent += FactuurAanmaken;
            ErrorStockDialog verwijderModal = new ErrorStockDialog
            {
                DataContext = crudVm
            };

            IsEnabledOnDialogClosed = false;
            await DialogHost.Show(verwijderModal, "ErrorStockDialog", null, ClosingEventHandler, ClosedEventHandler);
        }
        private async void FoutmeldingInstellenNaSave(int ok, string v)
        {
            if (ok <= 0)
            {
                ErrorMessageDialogModel errorVm = new ErrorMessageDialogModel();
                errorVm.ErrorMessage = v;
                ErrorDialog errorModal = new ErrorDialog();
                errorModal.DataContext = errorVm;
                await DialogHost.Show(errorModal, "ErrorDialog", null, ClosingEventHandler, ClosedEventHandler);

            }
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
            return true;
        }
        public void Reset()
        {
            SearchQueryProductNaam = string.Empty;
            CategorieSelectedIndex = -1;
            CategorieId = 0;
        }

        public override void Execute(object parameter)
        {
            switch (parameter.ToString())
            {
                case "winkelKarItemToevoegen":
                    ArtikelsToevoegen();
                    break;
                case "winkelKarItemVerwijderen":

                    if (ProductFactuur != null)
                        ArtikelsVerwijderen();
                    break;

                case "resetSearchQuery":
                    Reset();
                    break;
                case "OrderPlaatsen":
                    FactuurDoorsturen();
                    break;


            }
        }
    }
}

