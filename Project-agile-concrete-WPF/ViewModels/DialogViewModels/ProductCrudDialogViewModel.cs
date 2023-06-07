using MaterialDesignThemes.Wpf;
using Project_agile_concrete_models;
using Project_agile_concrete_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.VisualBasic;
using System.Windows.Documents;

namespace Project_agile_concrete_WPF.ViewModels.DialogViewModels
{
    public class ProductCrudDialogViewModel : BaseViewModel, IGenericCrudDialogViewModel<Product>
    {
        public override string this[string columnName] => throw new NotImplementedException();

        public string DeleteConfirmationMessage { get; set; } = "Ben je zeker dat je dit wilt verwijderen?";
        public string CommandName { get; set; }

        public event EventHandler<Product> CreateUpdateEvent;
        public event Action DeleteEvent;
        public Categorie GeselecteerdeCategorie { get; set; }
        public Product GeselecteerdeProduct { get; set; }
        public Stock Stock { get; set; }
        public Product ProductRecord { get; set; }
        public Product ProductRecords { get; set; }
        public List<Categorie> Categories { get; set; }

        public ProductCrudDialogViewModel(Product GeselecteerdeProduct, List<Categorie> categories)
        {   
            ZichbaarheidDynamischePresentatieElementenBepalen(GeselecteerdeProduct);

            ProductRecords = GeselecteerdeProduct;


            Categories = categories ?? new List<Categorie>();


            if (GeselecteerdeProduct != null)
            {

                GeselecteerdeCategorie = GeselecteerdeProduct.Categorie;
            }

        }


        private void ZichbaarheidDynamischePresentatieElementenBepalen(Product GeselecteerdeProduct)
        {
            ProductRecords = new Product();
            ProductRecord = new Product();

            if (GeselecteerdeProduct == null)
            {
                CommandName = "Create";


            }
            else
            {


                CommandName = "Update";
                ProductRecords.Naam = GeselecteerdeProduct.Naam;
                ProductRecords.CategorieId = GeselecteerdeProduct.CategorieId;
                ProductRecords.Prijs = GeselecteerdeProduct.Prijs;
                ProductRecords.EcoCheque = GeselecteerdeProduct.EcoCheque;

                ProductRecord = ProductRecords;
            }
        }



        public ProductCrudDialogViewModel()
        {

        }

        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            switch (parameter.ToString())
            {
                case "Create":

                    CreatePruduct();

                    break;
                case "Update":
                    UpdateProductRecords();


                    break;

                case "Confirm":
                    DeletProduct();

                    break;


            }

        }

        private void DeletProduct()
        {
            DeleteEvent?.Invoke();
            DialogHost.Close("DeleteDialog");
        }

        public void UpdateProductRecords()
        {


            if (!ProductRecords.IsGeldig())
                return;

            ProductRecords.Naam = ProductRecord.Naam;
            ProductRecords.Categorie.Naam = GeselecteerdeCategorie.Naam;
            ProductRecords.CategorieId= GeselecteerdeCategorie.Id;
            ProductRecords.EcoCheque = ProductRecord.EcoCheque;
            ProductRecords.Prijs = ProductRecord.Prijs;
            CreateUpdateEvent?.Invoke(this, ProductRecords);
            DialogHost.Close("CreateUpdateDialog");
        }
        public void CreatePruduct()
        {
            //////NEEEDS SOME WORK 
            ProductRecord.Categorie = GeselecteerdeCategorie;
            ProductRecord.CategorieId = GeselecteerdeCategorie.Id;

            if (!ProductRecord.IsGeldig())
                return;
            CreateUpdateEvent?.Invoke(this, ProductRecord);
            DialogHost.Close("CreateUpdateDialog");
        }


    }
}
