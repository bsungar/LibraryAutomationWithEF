using LibraryAutomata.Manager;
using LibraryAutomata.model;
using LibraryAutomata.View;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace LibraryAutomata.Service
{
    public class DbService
    {
        public User AddUser(User user)
        {
            using (var context = new LibraryDbContext())
            {
                var user1 = context.Users.Where(i => i.Name == user.Name).FirstOrDefault();
                if (user1 != null)
                {
                    return null;
                }

                var AddedUser = context.Users.Add(user1).Entity;
                context.SaveChanges();

                return AddedUser;

            }
        }

        public User Login(string email, string password)
        {
            using (var context = new LibraryDbContext())
            {
                var whre = context.Users.FirstOrDefault(i => i.Email == email & i.Password == password);
                return whre;

            }




        }
        public static User SignIn(string email, string name, string surname, string password)
        {
            using (var context = new LibraryDbContext())
            {
                using (var dbContextTransaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var newUser = new User
                        {
                            Email = email,
                            Name = name,
                            Surname = surname,
                            Password = password
                        };

                        var addedUser = context.Users.Add(newUser).Entity;
                        var result = context.SaveChanges();
                        dbContextTransaction.Commit();


                        MessageBox.Show("Kaydınız başarıyla oluşturuldu.Şimdi giriş yapabilirsiniz.");
                        NavigationManager.CurrentView = new LoginUserControl();
                        return addedUser;
                    }
                    catch (Exception ex)
                    {
                        dbContextTransaction.Rollback();
                        MessageBox.Show("Bir hata oluştu: " + ex.Message);
                        return null;
                    }

                }
            }
        }

        public void AddBook(string title, string authorname, string category, string description)
        {
            try
            {
                var book = new Book { Title = title, AuthorName = authorname, Description = description, Genre = category };

                using var context = new LibraryDbContext();
                context.Books.Add(book);

                context.SaveChanges();

            }
            catch (Exception)
            {

            }

        }

        public void SearchBook(string title, string authorname, TextBox titleTextBox, TextBox authorTextBox)
        {
            using var context = new LibraryDbContext();

            var book1 = context.Books.FirstOrDefault(b => b.Title == title && b.AuthorName == authorname);
            if (book1 == null)
            {
                MessageBox.Show("Kitap bulundu.");
                titleTextBox.Text = book1.Title;
                authorTextBox.Text = book1.AuthorName;
                context.SaveChanges();

            }

        }
        public void DeleteBook(string title, string authorname)
        {
            using var context = new LibraryDbContext();
            var bookToDelete = context.Books.FirstOrDefault(c => c.Title == title && c.AuthorName == authorname);
            if (bookToDelete != null)
            {
                MessageBox.Show("Kitap silindi.");
                context.Books.Remove(bookToDelete);
                context.SaveChanges();
            }
        }
    }
}

