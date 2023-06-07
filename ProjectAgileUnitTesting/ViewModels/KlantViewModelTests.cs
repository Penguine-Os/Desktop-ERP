using FakeItEasy;
using Microsoft.IdentityModel.Tokens;
using Project_agile_concrete_DAL.UnitOfWork;
using Project_agile_concrete_models;
using Project_agile_concrete_WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAgileUnitTesting.ViewModels
{
    [TestFixture]
    public class KlantViewModelTests
    {
        KlantViewModel klantViewModel = new KlantViewModel();
        private IUnitOfWork unitOfWork = A.Fake<IUnitOfWork>();
        [Test]
        public void Add_Klant_Succesfull()
        {
            //Arrange
            int totKlanten = klantViewModel.Klanten.Count();
            Klant testKlant = new Klant()
            {
                Naam = "test",
                Email = "test",
                Telefoon = "test",
                Straat = "test",
                Huisnummer = 10,
                Gemeente = "test",
                Postcode = 1234,
                Voornaam = "test"
            };

            //Act
            klantViewModel.AanmakenKlantEventHandler(null, testKlant);

            //Assert
            Assert.That(klantViewModel.Klanten.Count(), Is.EqualTo(totKlanten + 1));
        }
        [Test]
        public void Add_Klant_Failure()
        {
            //Arrange
            int totKlanten = klantViewModel.Klanten.Count();
            Klant testKlant = new Klant()
            {
                Email = "test",
                Telefoon = "test",
                Huisnummer = 10,
                Gemeente = "test",
                Postcode = 1234,
                Voornaam = "test"
            };

            //Act
            klantViewModel.AanmakenKlantEventHandler(null, testKlant);

            //Assert
            Assert.That(klantViewModel.Klanten.Count(), Is.EqualTo(totKlanten));
        }
        [Test]
        public void Ophalen_Klanten_Database()
        {
            //Arrange
            ObservableCollection<Klant> klanten;

            //Act
            klanten = new ObservableCollection<Klant>(unitOfWork.KlantRepo.Ophalen(x => x.Factuurs));

            //Assert
            Assert.NotNull(klanten);
            Assert.IsInstanceOf<ObservableCollection<Klant>>(klanten);
        }
        [Test]
        public void ZoekOpPK_Returns1Klant()
        {
            //Arrange
            Klant klant = A.Fake<Klant>();

            //Act
            klant = unitOfWork.KlantRepo.ZoekOpPK(klant.Id);

            //Assert
            Assert.NotNull(klant);
            Assert.IsInstanceOf<Klant>(klant);
        }
        [Test]
        public void Delete_Klant_Database()
        {
            //Arrange
            Klant klant = A.Fake<Klant>();
            ObservableCollection<Klant> Klanten;

            //Act
            Klanten = new ObservableCollection<Klant>(unitOfWork.KlantRepo.Ophalen(x => x.Factuurs));
            unitOfWork.KlantRepo.Add(klant);
            unitOfWork.KlantRepo.Delete(klant);

            //Assert
            Assert.NotNull(Klanten);
            Assert.IsInstanceOf<ObservableCollection<Klant>>(Klanten);
            A.CallTo(() => unitOfWork.KlantRepo.Delete(klant)).MustHaveHappened();
        }
    }
}
