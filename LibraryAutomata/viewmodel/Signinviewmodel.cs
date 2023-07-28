using LibraryAutomata.Manager;
using LibraryAutomata.relaycommand;
using LibraryAutomata.Service;
using LibraryAutomata.View;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LibraryAutomata.viewmodel
{
    public class Signinviewmodel : INotifyPropertyChanged
    {
        public event EventHandler<EventArgs> LoginRequested;
        private void OnLoginRequested()
        {
            LoginRequested?.Invoke(this, EventArgs.Empty);
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string email;
        private string password;
        private string name;
        private string surname;

        public string Email { get { return email; } set { email = value; OnPropertyChanged(nameof(email)); } }
        public string Password { get { return password; } set { password = value; OnPropertyChanged(nameof(password)); } }

        public string Name { get { return name; } set { name = value; OnPropertyChanged(nameof(name)); } }
        public string Surname { get { return surname; } set { surname = value; OnPropertyChanged(nameof(surname)); } }


        private RelayCommand signinCommand;
        public RelayCommand SigninCommand
        {
            get { return signinCommand; }
        }

        public Signinviewmodel()
        {
            signinCommand = new RelayCommand(SignIn);
        }


        private void SignIn()
        {
            try
            {
                var newUser = DbService.SignIn(email, name, surname, password);
                if (newUser != null)
                {
                    MessageBox.Show("Kaydınız başarıyla oluşturuldu.Şimdi giriş yapabilirsiniz.");
                    NavigationManager.CurrentView = new LoginUserControl();
                }
                else
                {
                    MessageBox.Show("Bir sorun oluştu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

    }
}




    
