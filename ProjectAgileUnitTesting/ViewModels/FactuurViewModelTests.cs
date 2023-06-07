using FakeItEasy;
using Project_agile_concrete_DAL.UnitOfWork;
using Project_agile_concrete_models;
using Project_agile_concrete_WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAgileUnitTesting.ViewModels
{
    [TestFixture]
    public class FactuurViewModelTests
    {
        FactuurViewModel factuurViewModel = new FactuurViewModel();
        private IUnitOfWork unitOfWork = A.Fake<IUnitOfWork>();
        [Test]
        public void Generate_Factuur_Database()
        {
            //Arrange
            Factuur factuur = A.Fake<Factuur>();

            //Act
            unitOfWork.FactuurRepo.FactuurAanmaken(factuur);

            //Assert
            A.CallTo(() => unitOfWork.FactuurRepo.FactuurAanmaken(factuur)).MustHaveHappened();
        }
        [Test]
        public void Test_Filters()
        {
            //Arrange
            string search = "Sto";
            int count = 0;

            //Act
            count = factuurViewModel.ItemProducten.Count();
            factuurViewModel.SearchQueryProductNaam = search;

            //Assert
            Assert.That(count, Is.GreaterThan(factuurViewModel.ItemProducten.Count()));
        }
        [Test]
        public void Test_Reset_Filters()
        {
            //Arrange
            string search = "Sto";
            int count = 0;

            //Act
            factuurViewModel.SearchQueryProductNaam = search;
            count = factuurViewModel.ItemProducten.Count();
            factuurViewModel.Reset();

            //Assert
            Assert.That(count, Is.LessThan(factuurViewModel.ItemProducten.Count()));
        }
        [Test]
        public void Add_Factuur_Failure()
        {
            //Arrange
            int totFacturen = factuurViewModel.Klanten[1].Factuurs.Count();
            factuurViewModel.GeselecteerdeKlant = factuurViewModel.Klanten[1];

            //Act
            factuurViewModel.FactuurDoorsturen();

            //Assert
            Assert.That(totFacturen, Is.EqualTo(factuurViewModel.Klanten[1].Factuurs.Count()));
        }

    }
}
