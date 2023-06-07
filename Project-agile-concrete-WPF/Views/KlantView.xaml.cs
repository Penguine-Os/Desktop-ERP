using Project_agile_concrete_models;
using Project_agile_concrete_WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
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
    /// Interaction logic for KlantView.xaml
    /// </summary>
    public partial class KlantView : UserControl
    {
        private readonly KlantViewModel _klantViewModel;

        public KlantView(KlantViewModel klantViewModel)
        {
            InitializeComponent();
            _klantViewModel = klantViewModel;
            DataContext = _klantViewModel;
        }

        private void KlntGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (KlntGrid.SelectedItem is Klant klant)
            {
                KlntGrid.ScrollIntoView(klant);
            }
          
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                if (button.DataContext is Factuur klantFactuur)
                {
                    _klantViewModel.StukkenLijst = new List<ProductFactuur>(klantFactuur.Producten);
                    _klantViewModel.Producten = new ObservableCollection<ProductFactuur>(klantFactuur.Producten.Where(x=>x.ProductId!=null));
                    _klantViewModel.FactuurDiensten = new ObservableCollection<ProductFactuur>(klantFactuur.Producten.Where(x => x.DienstId != null));                    
                }
            }

        }
    }
}
