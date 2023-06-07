using NUnit.Framework.Constraints;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using Project_agile_concrete_WPF.ViewModels;
using Project_agile_concrete_WPF.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAgileUnitTesting.Views
{
    [TestFixture]
    public class ProductAankoopViewTest
    {
        string WindowsApplicationDriverUrl = "http://127.0.0.1:4723/";
        string WpfAppId = @"C:\Users\Stef\Documents\School\Agile en prog\it-graduaten\2022-GPR-Agile-Turnhout-Concrete\Project-agile-concrete\Project-agile-concrete-WPF\bin\Debug\net6.0-windows\Project-agile-concrete-WPF.exe";
        WindowsDriver<WindowsElement> session;
        WindowsElement item, klant, eenheid, add, voltooien;
        FactuurViewModel factuurViewModel = new FactuurViewModel();
        [SetUp]
        public void Setup()
        {
            var appiumOptions = new AppiumOptions();
            appiumOptions.AddAdditionalCapability("app", WpfAppId);
            session = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), appiumOptions);

            item = session.FindElementByAccessibilityId("Items");
            klant = session.FindElementByAccessibilityId("Klanten");
            eenheid = session.FindElementByAccessibilityId("Aantal");
            add = session.FindElementByAccessibilityId("Toevoegen");
            voltooien = session.FindElementByAccessibilityId("Verzenden");
        }
        [Test]
        public void GetProductAankoop()
        {
            //Act
            item.Click();
            factuurViewModel.GeselecteerdeProduct = factuurViewModel.Producten[2];
            klant.Click();
            factuurViewModel.GeselecteerdeKlant = factuurViewModel.Klanten[5];
            eenheid.SendKeys("23");
            add.Click();
            voltooien.Click();

            //Assert
            Assert.AreEqual("23", eenheid.Text);

        }
        [TearDown]
        public void TearDown()
        {
            eenheid.Clear();
        }
        [OneTimeTearDown]
        public void CloseSession()
        {
            session.Close();
        }

    }
}
