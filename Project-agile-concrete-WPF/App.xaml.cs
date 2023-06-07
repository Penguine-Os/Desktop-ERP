using Project_agile_concrete_WPF.ViewModels;
using Project_agile_concrete_WPF.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Project_agile_concrete_WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender,StartupEventArgs e)
        {
            MainViewModel viewmodel = new MainViewModel();
            MainView view = new MainView();
            view.DataContext = viewmodel;
            view.Show();
        }
    }
}
