using LibraryAutomata.model;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutomata.Manager
{
    public class UserManager
    {
        public static bool IsLoggedIn { get; set; }
        public static User LoggedUser { get; set; }

       

    }
}
