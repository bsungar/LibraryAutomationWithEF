using LibraryAutomata.relaycommand;
using LibraryAutomata.View;
using System.ComponentModel;
using System.Windows.Controls;

namespace LibraryAutomata.Manager
{
    public class NavigationManager
    {

        //public event PropertyChangedEventHandler? PropertyChanged;
        //protected void OnPropertyChanged(string propertyName)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}
        private static UserControl currentView;

        public delegate void ViewChangedDelegate();

        public static event ViewChangedDelegate ViewChanged;


        public static UserControl CurrentView
        {
            get { return currentView; }
            set
            {
                currentView = value;
                ViewChanged();
            }
        }
        //public RelayCommand GoSignInCommand { get; }
        //public RelayCommand GoLoginCommand { get; }
        //public RelayCommand GoLibraryCommand { get; }

        public NavigationManager()
        {
            //GoSignInCommand = new RelayCommand(GoSignIn);
            //GoLoginCommand = new RelayCommand(GoLogin);
            //GoLibraryCommand = new RelayCommand(GoLibrary);
            //CurrentView = new LoginUserControl();
        }

        //private void GoSignIn(object parameter)
        //{
        //    CurrentView = new LibraryAutomata.View.SignIn();
        //}

        //private void GoLogin(object parameter)
        //{
        //    CurrentView = new LibraryAutomata.View.LoginUserControl();
        //}

        //private void GoLibrary(object parameter)
        //{
        //    CurrentView = new LibraryAutomata.View.Library();
        //}
    }
}
