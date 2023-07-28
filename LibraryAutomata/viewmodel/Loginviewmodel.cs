using LibraryAutomata.Manager;
using LibraryAutomata.relaycommand;
using LibraryAutomata.Service;
using LibraryAutomata.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace LibraryAutomata.viewmodel
{
    public class Loginviewmodel : INotifyPropertyChanged
    {
        DbService dbService = new DbService();

      
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private string email;
        private string password;


        public string Email
        {
           get { return email; } set {  email = value; OnPropertyChanged(nameof(Email)); }
        }

        public string Password
        {
            get => password; set
            {
                password = value; OnPropertyChanged(nameof(Password));
            }
        }
        private RelayCommand loginCommand;

        public RelayCommand LoginCommand { get { return loginCommand; } }

        public Loginviewmodel()
        {   
            loginCommand = new RelayCommand(Login);
        }

        private void Login()
        {
            var user = dbService.Login(Email, Password);
            if (user !=null)
            {
                //login okey
                UserManager.IsLoggedIn = true;
                UserManager.LoggedUser = user;
                MessageBox.Show("Welcome");
                NavigationManager.CurrentView = new Library();



            }

            else
            {
                UserManager.IsLoggedIn= false;
                UserManager.LoggedUser = null;
                
                MessageBox.Show("Kullanıcı bulunamadı. Kayıt olun.");
                NavigationManager.CurrentView = new SignInView();
                

            }

        }

      

    
    
    
    }
}
