using LibraryAutomata.relaycommand;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using System.Windows;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Windows.Controls;
using System.Windows.Input;
using LibraryAutomata.View;

namespace LibraryAutomata
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);


            //LoginUserControl loginPage = new LoginUserControl();
            //MainWindow = new MainWindow();
            
            //MainWindow.Content = loginPage;
            //MainWindow.Show();
        }
    }
}