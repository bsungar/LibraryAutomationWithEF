using LibraryAutomata.Manager;
using LibraryAutomata.Navigation;
using LibraryAutomata.View;
using LibraryAutomata.viewmodel;
using System;
using System.Collections.Generic;
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

namespace LibraryAutomata
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private NavigationManager navigationManager;

        public MainWindow()
        {
            InitializeComponent();

            //navigationViewModel = new NavigationViewModel();
            //DataContext = navigationViewModel;
            MainFrame.Navigate(new LoginUserControl());
            NavigationManager.ViewChanged += NavigationManager_ViewChanged;
        }

        private void NavigationManager_ViewChanged()
        {
            MainFrame.Navigate(NavigationManager.CurrentView);
        }

        //public void OnSignInRequested(object sender, EventArgs e)
        //{
        //    // SignInUserControl sayfasını yükleme
        //    navigationViewModel.GoSignInCommand.Execute(null);
        //}

        //public void OnLoginRequested(object sender, EventArgs e)
        //{
        //    navigationViewModel.GoLoginCommand.Execute(null);
        //}

        //public void OnLibraryRequested(object sender, EventArgs e)
        //{
        //    navigationViewModel.GoLibraryCommand.Execute(null);
        //}
    }
}