using Project_agile_concrete_models;
using Project_agile_concrete_WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project_agile_concrete_WPF.Views
{
    /// <summary>
    /// Interaction logic for ProductAankoopView.xaml
    /// </summary>
    public partial class ProductAankoopView : UserControl
    {
        public ProductAankoopView()
        {
            InitializeComponent();
        }

    

        private void btnVerhoog_Click(object sender, RoutedEventArgs e)
        {
            var tempContext = this.DataContext as FactuurViewModel;
            if (sender is Button button)
            {
                if (button.DataContext is ProductFactuur pf)
                {
                    pf.Hoeveelheid++;
                    tempContext!.StukkenLijst = new ObservableCollection<ProductFactuur>(tempContext.StukkenLijst);
                    tempContext!.StukkenLijstProducten = new ObservableCollection<ProductFactuur>(tempContext!.StukkenLijst.Where(x => x.ProductId != null));
                    tempContext!.StukkenLijstDiensten = new ObservableCollection<ProductFactuur>(tempContext!.StukkenLijst.Where(x => x.DienstId != null));

                }
            }

        }

        private void btnVerlaag_Click(object sender, RoutedEventArgs e)
        {
            var tempContext = this.DataContext as FactuurViewModel;
            if (sender is Button button)
            {
                if (button.DataContext is ProductFactuur pf)
                {
                    pf.Hoeveelheid--;

                    if (pf.Hoeveelheid > 0)
                    {
                        tempContext!.StukkenLijst = new ObservableCollection<ProductFactuur>(tempContext.StukkenLijst);
                        tempContext!.StukkenLijstProducten = new ObservableCollection<ProductFactuur>(tempContext!.StukkenLijst.Where(x => x.ProductId != null));
                        tempContext!.StukkenLijstDiensten = new ObservableCollection<ProductFactuur>(tempContext!.StukkenLijst.Where(x => x.DienstId != null));
                        return;
                    }

                    tempContext!.StukkenLijst.Remove(pf);

                    if (tempContext.StukkenLijst.Count() > 0)
                    {
                        tempContext!.StukkenLijst = new ObservableCollection<ProductFactuur>(tempContext.StukkenLijst);
                        tempContext!.StukkenLijstProducten = new ObservableCollection<ProductFactuur>(tempContext!.StukkenLijst.Where(x => x.ProductId != null));
                        tempContext!.StukkenLijstDiensten = new ObservableCollection<ProductFactuur>(tempContext!.StukkenLijst.Where(x => x.DienstId != null));
                        return ;
                    }
                    tempContext!.StukkenLijstProducten = new ObservableCollection<ProductFactuur>(tempContext!.StukkenLijst.Where(x => x.ProductId != null));
                    tempContext!.StukkenLijstDiensten = new ObservableCollection<ProductFactuur>(tempContext!.StukkenLijst.Where(x => x.DienstId != null));
                    tempContext.StukkenLijstIsOpgevuld = false;
                  

                }
            }
        }

        private void txtEenheid_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void btn_OrderPlaatsen_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is FactuurViewModel fvm)
            {
                fvm.FactuurDoorsturen();
                if (fvm.StockAangemaakt)
                {
                    DataContext = new FactuurViewModel();
                }
            }

        }
    }
}
