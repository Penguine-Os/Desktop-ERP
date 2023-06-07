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
using System.Threading.Tasks;
using System.Windows;

namespace Project_agile_concrete_WPF.ViewModels
{
    public class ProductViewModel : BaseViewModel
    {
        private IUnitOfWork _unitOfWork = new UnitOfWork(new ProjectDBContext());
        public event EventHandler<Stock> CreateUpdateEvent;

        public List<Categorie> AlleCategories { get; set; }
      
        public ObservableCollection<Product> AlleProducten 
        { 
            get; 
            set; 
        }
        public ObservableCollection<Stock> AlleStocks { get; set; }
        public List<Winkel> AlleWinkels { get; set; }
        public bool IsEnabledOnDialogClosed { get; set; } = true;
        public Stock Stocken { get; set; }
        public Stock Stockens { get; set; }
        public int BackgroundVisibility { get; set; } = 1;
        public string CommandName { get; set; }

        private string _searchQuery;

        public string SearchQueryName
        {
            get { return _searchQuery; }
            set
            {
                _searchQuery = value;

                var filteredproducten = AlleProducten.Where(x => x.Naam.Contains(_searchQuery, StringComparison.OrdinalIgnoreCase));
                Producten = new ObservableCollection<Product>(filteredproducten);

            }
        }

        private string _searchQueryCategory;

        public string SearchQueryCategory
        {
            get { return _searchQueryCategory; }
            set
            {
                _searchQueryCategory = value;

                if (string.IsNullOrWhiteSpace(_searchQueryCategory))
                {
                    Producten = new ObservableCollection<Product>(AlleProducten);
                    return;
                }
                var filterProduct = AlleProducten.Where(x =>
                {
                    if (x.Categorie.Naam is not null)
                        return x.Categorie.Naam.Contains(_searchQueryCategory);

                    return false;
                }).ToList();

                Producten = new ObservableCollection<Product>(filterProduct);

            }
        }
        private Stock _geslecteerdestock;


        public Stock GeselecteerdeStock
        {
            get { return _geslecteerdestock; }
            set
            {
                _geslecteerdestock = value;
                Stocken = GeselecteerdeStock;
                
                if (GeselecteerdeStock != null)
                {
                    //Stock tempstock = new Stock();
                    //tempstock.Winkel = GeselecteerdeStock.Winkel;
                    //tempstock.Aantal = GeselecteerdeStock.Aantal;
                    //tempstock.Product = GeselecteerdeStock.Product;
                    //tempstock.Id= GeselecteerdeStock.Id;
                    StockAantal = value.Aantal;
                    StockWinkel = value.Winkel;
                    stockRecord = Stocken;   
                }

            }
        }

        private Stock _stockRecord;
        public Stock stockRecord
        {
            get { return _stockRecord; }
            set { 
                _stockRecord = value; 
                
            }
        }
        private int _stockAantal;
        public int StockAantal {
            get { return _stockAantal; } 
            set
            {
                _stockAantal = value;
            }
        }
        private Winkel _stockWinkel;

        public Winkel StockWinkel
        {
            get { return _stockWinkel; }
            set { _stockWinkel = value; }
        }

        private ObservableCollection<Stock> _stocks;

        public ObservableCollection<Stock> Stocks
        {
            get { return _stocks; }
            set { _stocks = value; }
        }
        private Winkel _geslecteerdewinkel;


        public Winkel GeselecteerdeWinkel
        {
            get { return _geslecteerdewinkel; }
            set
            {
                _geslecteerdewinkel = value;
                
            }
        }

        private ObservableCollection<Winkel> _winkels;

        public ObservableCollection<Winkel> Winkels
        {
            get { return _winkels; }
            set { _winkels = value;}
        }



        private Product _geselecteerdeproduct;


        public Product GeselecteerdeProduct
        {
            get { return _geselecteerdeproduct; }
            set
            {
                _geselecteerdeproduct = value;
                if (GeselecteerdeProduct is not null)
                {
                    Stocks = new ObservableCollection<Stock>(_unitOfWork.StockRepo
                    .Ophalen(p => p.Product, w => w.Winkel, c => c.Product.Categorie).Where(s => s.ProductId == GeselecteerdeProduct.Id));
                }
                StockWinkel = new Winkel();
                StockAantal = 0;
            }
        }

        private Categorie _geslecteerdecategorie;


        public Categorie GeselecteerdeCategorie
        {
            get { return _geslecteerdecategorie; }
            set
            {
                _geslecteerdecategorie = value;

            }
        }

        private Product _productRecord;
        public Product productRecord
        {
            get { return _productRecord; }
            set { _productRecord = value; }
        }
        private ObservableCollection<Product> _producten;
        public ObservableCollection<Product> Producten
        {
            get { return _producten; }
            set { 
                _producten = value; 
                foreach(var product in Producten)
                {
                    product.StockTot = 0;
                    if (product.Stocks != null)
                    {
                        foreach(var stock in product.Stocks)
                        {
                            product.StockTot += stock.Aantal;
                        }
                    }
                }
            }
        }
        private List<Categorie> _categorie;

        public List<Categorie> Categorien
        {
            get { return _categorie; }
            set { _categorie = value; }
        }
        public ProductViewModel()
        {
            Producten = new ObservableCollection<Product>(_unitOfWork.ProductRepo.Ophalen(st => st.Stocks, c => c.Categorie));
            Categorien = new List<Categorie>(_unitOfWork.CategorieRepo.GetAll());
            Winkels = new ObservableCollection<Winkel>(_unitOfWork.WinkelRepo.GetAll());

            AlleStocks = Stocks;
            AlleProducten = Producten;
            Stocken = new Stock();
            stockRecord = new Stock();
        }
        public override string this[string columnName] => string.Empty;
        public void AanmakenProductEventHandler(object sender, Product EventArgs)
        {
            productRecord = EventArgs;
            if (productRecord.IsGeldig())
            {
                _unitOfWork.ProductRepo.Add(productRecord);
                int ok = _unitOfWork.Save();

                FoutmeldingInstellenNaSave(ok, "product is niet toegevoegd.");

            }

        }
        public void UpdateProductEventHandler(object sender, Product EventArgs)
        {
            productRecord = EventArgs;
            if (productRecord.IsGeldig())
            {
                _unitOfWork.ProductRepo.ToevoegenOfAanpassen(productRecord);
                int ok = _unitOfWork.Save();

                FoutmeldingInstellenNaSave(ok, "product is niet aangepast.");

            }
            else
            {
                MessageBox.Show("Selecteer een product!");
            }

        }
        private void VerwijderProductEventHandler()
        {
            if (GeselecteerdeProduct != null)
            {

                _unitOfWork.ProductRepo.Delete(GeselecteerdeProduct);
                int ok = _unitOfWork.Save();
                FoutmeldingInstellenNaSave(ok, "product is niet verwijderd.");
            }
            else
            {
                MessageBox.Show("Eerst product selecteren");
            }
        }
        private void FoutmeldingInstellenNaSave(int ok, string v)
        {
            if (ok > 0)
            {
                RefreshProduct();
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
                GeselecteerdeStock = null;

            }
            else
            {
                MessageBox.Show(this.Error);
            }
        }
        private void RefreshProduct()
        {

            Producten = new ObservableCollection<Product>(_unitOfWork.ProductRepo.Ophalen(st => st.Stocks, c => c.Categorie));
            //Stocks = new ObservableCollection<Stock>(_unitOfWork.StockRepo.Ophalen(p => p.Product, w => w.Winkel, c => c.Product.Categorie).Where(s => s.ProductId == GeselecteerdeProduct.Id));
        }


        private async void AanmaakBewerkProduct()
        {
            ProductCrudDialogViewModel crudVm = new ProductCrudDialogViewModel(GeselecteerdeProduct, Categorien);

            crudVm.CreateUpdateEvent += GeselecteerdeProduct == null ? AanmakenProductEventHandler! : UpdateProductEventHandler!;


            var view = new AddProductDialog
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

                case "ProductBewerken":
                case "ProductVerwijderen":
                case "ProductZoeken":
                    return GeselecteerdeProduct is not null;
                case "StockBewerken":
                case "StockVerwijderen":
                    return GeselecteerdeStock is not null;
                case "StockToevoegen":
                    return GeselecteerdeProduct is not null && StockAantal > 0 && StockWinkel is not null;

            }
            return true;
        }



        public override void Execute(object parameter)
        {
            switch (parameter.ToString())
            {

                case "ProductVerwijderen":
                    VerwijderProductDialogOpenen();
                    break;
                case "ProductToevoegen":
                    GeselecteerdeProduct = null;
                    ExecuteRunDialog(AanmaakBewerkProduct);
                    break;
                case "ProductBewerken":
                    ExecuteRunDialog(AanmaakBewerkProduct);
                    break;
                case "ProductZoeken":
                    GeselecteerdeProduct = null;
                    BackgroundVisibility = 1;
                    break;
                case "ProductenLijst":

                    _searchQueryCategory = null;
                    _geslecteerdecategorie = null;
                    Producten = new ObservableCollection<Product>(AlleProducten);
                    Categorien = null;
                    Categorien = new List<Categorie>(_unitOfWork.CategorieRepo.GetAll());

                    break;
                case "StockToevoegen":
                    
                    AanmakenStock();

                    Winkels = null;
                    Winkels = new ObservableCollection<Winkel>(_unitOfWork.WinkelRepo.GetAll());


                    break;
                case "StockBewerken":
                    //StockGegevensAanpassen();
                    updatestock();

                    break;
                case "StockVerwijderen":
                    Verwijderstock();
                    break;
            }
        }

        
        private async void VerwijderProductDialogOpenen()
        {
            ProductCrudDialogViewModel crudVm = new ProductCrudDialogViewModel();
            crudVm.DeleteEvent += VerwijderProductEventHandler;

            DeleteDialog verwijderModal = new DeleteDialog
            {
                DataContext = crudVm
            };

            IsEnabledOnDialogClosed = false;
            await DialogHost.Show(verwijderModal, "DeleteDialog", null, ClosingEventHandler, ClosedEventHandler);

        }

        public void AanmakenStock()
        {
            int ok = 0;
            stockRecord = new Stock();
            stockRecord.ProductId = GeselecteerdeProduct.Id;
            stockRecord.Aantal = StockAantal;
            stockRecord.Winkel = StockWinkel;
            stockRecord.WinkelId = StockWinkel.Id;
            if (!stockRecord.IsGeldig())
            {
                _unitOfWork.StockRepo.ToevoegenOfAanpassen(stockRecord);
                ok = _unitOfWork.Save();

                FoutmeldingInstellenNaSave(ok, "stock is niet toegevoegd.");

            }
            if (ok > 0)
            {
                Stocks = new ObservableCollection<Stock>(_unitOfWork.StockRepo
                    .Ophalen(p => p.Product, w => w.Winkel, c => c.Product.Categorie).Where(s => s.ProductId == GeselecteerdeProduct.Id));
            }
        }

        public void updatestock()
        {
            stockRecord.Winkel = StockWinkel;
            stockRecord.WinkelId = StockWinkel.Id;
            stockRecord.Aantal = StockAantal;
            if (!stockRecord.IsGeldig())
            {
                _unitOfWork.StockRepo.ToevoegenOfAanpassen(stockRecord);
                int ok = _unitOfWork.Save();

                FoutmeldingInstellenNaSave(ok, "stock is niet toegevoegd.");
                StockWinkel = new Winkel();
                StockAantal = 0;
            }

        }
        private void Verwijderstock()
        {
            if (GeselecteerdeStock != null)
            {

                _unitOfWork.StockRepo.Delete(GeselecteerdeStock);
                int ok = _unitOfWork.Save();
                FoutmeldingInstellenNaSave(ok, "Stock is niet verwijderd.");
                StockWinkel = new Winkel();
                StockAantal = 0;
            }
            else
            {
                MessageBox.Show("Eerst stock selecteren");
                StockWinkel = new Winkel();
                StockAantal = 0;
            }
        }
    }
}
