using FakeItEasy;
using Project_agile_concrete_DAL.UnitOfWork;
using Project_agile_concrete_models;
using Project_agile_concrete_WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAgileUnitTesting.ViewModels
{
    [TestFixture]
    public class ProductViewModelTests
    {
        ProductViewModel productViewModel = new ProductViewModel();
        private IUnitOfWork unitOfWork = A.Fake<IUnitOfWork>();
        [Test]
        public void Update_Product_Database()
        {
            //Arrange
            Product product = A.Fake<Product>();
            Product updateProduct = product;
            updateProduct.Naam = "testing";

            //Act
            unitOfWork.ProductRepo.Add(product);
            unitOfWork.ProductRepo.Update(updateProduct);

            //Assert
            A.CallTo(() => unitOfWork.ProductRepo.Update(updateProduct)).MustHaveHappened();
        }
        [Test]
        public void Delete_Product_Database()
        {
            //Arrange
            Product product = A.Fake<Product>();
            ObservableCollection<Product> producten;

            //Act
            producten = new ObservableCollection<Product>(unitOfWork.ProductRepo.Ophalen(x => x));
            unitOfWork.ProductRepo.Add(product);
            unitOfWork.ProductRepo.Delete(product);

            //Assert
            Assert.NotNull(producten);
            Assert.IsInstanceOf<ObservableCollection<Product>>(producten);
            A.CallTo(() => unitOfWork.ProductRepo.Delete(product)).MustHaveHappened();
        }
        [Test]
        public void Add_Stock_Succesfull()
        {
            //Arrange
            int totStocks = 0;
            int totStocksAdded = 0;
            productViewModel.StockWinkel.Id = 4;
            productViewModel.StockAantal = 74;
            productViewModel.StockWinkel = new Winkel();
            productViewModel.GeselecteerdeProduct.Id = 9;
            //Act
            totStocks = productViewModel.Stocks.Count();
            productViewModel.AanmakenStock();
            totStocksAdded = productViewModel.Stocks.Count();

            //Assert
            Assert.That(totStocksAdded, Is.GreaterThan(totStocks));
        }
        [Test]
        public void Update_Stock_Succesfull()
        {
            //Arrange
            Stock stock = A.Fake<Stock>();
            Stock updateStock = stock;
            updateStock.Aantal = 76;

            //Act
            unitOfWork.StockRepo.Add(stock);
            unitOfWork.StockRepo.Update(updateStock);

            //Assert
            A.CallTo(() => unitOfWork.StockRepo.Update(updateStock)).MustHaveHappened();
        }
        [Test]
        public void Search_Product()
        {
            //Arrange
            ObservableCollection<Stock> products = new ObservableCollection<Stock>();
            ObservableCollection<Stock> productsSearched = new ObservableCollection<Stock>();
            string search = "Sto";

            //Act
            products = productViewModel.Stocks;
            productViewModel.SearchQueryName= search;
            productsSearched = productViewModel.Stocks;

            //Assert
            Assert.That(products.Count(),Is.GreaterThanOrEqualTo(productsSearched.Count()));
        }
    }
}
