using LibraryAutomata.relaycommand;
using LibraryAutomata.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace LibraryAutomata.Navigation
{
    public class NavigationViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private UserControl currentView;

        public UserControl CurrentView
        {
            get { return currentView; }
            set
            {
                currentView = value;
                OnPropertyChanged(nameof(CurrentView));
            }
        }
        public RelayCommand GoSignInCommand { get; }
        public RelayCommand GoLoginCommand { get; }
        public RelayCommand GoLibraryCommand { get; }

        public NavigationViewModel()
        {
           
            GoSignInCommand = new RelayCommand(GoSignIn);
            GoLoginCommand = new RelayCommand(GoLogin);
            //GoLibraryCommand = new RelayCommand(GoLibrary);
            CurrentView = new LoginUserControl();
        }

        private void GoSignIn(object parameter)
        {
            CurrentView = new LibraryAutomata.View.SignIn();
        }

        private void GoLogin(object parameter)
        {
            CurrentView = new LibraryAutomata.View.LoginUserControl();
        }

        private void GoLibrary(object parameter)
        {
            CurrentView = new LibraryAutomata.View.Library();
        }

    }


}