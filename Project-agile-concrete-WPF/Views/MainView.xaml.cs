using MaterialDesignThemes.Wpf;
using Project_agile_concrete_WPF.ViewModels;
using Project_agile_concrete_WPF.ViewModels.DialogViewModels;
using Project_agile_concrete_WPF.Views.Dialogs;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace Project_agile_concrete_WPF.Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
        }
        public bool IsEnabledOnDialogClosed { get; set; } = true;
        public async void CloseConfirm()
        {
            ConfirmDialogViewModel confirmVm = new ConfirmDialogViewModel();
            confirmVm.Confirm += DeleteOnConfirm;
            ConfirmCloseDialog verwijderModal = new ConfirmCloseDialog();
            verwijderModal.DataContext = confirmVm;
            await DialogHost.Show(verwijderModal, "ConfirmCloseDialog", null, ClosingEventHandler, ClosedEventHandler);

        }
        private void DeleteOnConfirm()
        {
            this.Close();
        }
        private void ClosingEventHandler(object sender, DialogClosingEventArgs eventArgs)
        {
            //eventArgs.Cancel();
            IsEnabledOnDialogClosed = true;
            Debug.WriteLine("You can intercept the closing event, and cancel here.");
        }
        private void ClosedEventHandler(object sender, DialogClosedEventArgs eventArgs)
            => Debug.WriteLine("You can intercept the closed event here (1).");
        private void tabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            string selectedTab = (tabControl.SelectedItem as TabItem).Name;
            switch (selectedTab)
            {

                case "tabKlant":
                    ContentWindow.Content = new KlantView(new KlantViewModel());
                    break;
                case "tabProductBeheer":
                    ContentWindow.Content = new ProductView();

                    break;
                case "tabAankoop":
                    ContentWindow.Content = new ProductAankoopView();
                    break;

                case "tabExit":
                    CloseConfirm();
                    
                    break;
            }
        }

    }
}
