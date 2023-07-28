using LibraryAutomata.model;
using LibraryAutomata.relaycommand;
using LibraryAutomata.Service;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace LibraryAutomata.viewmodel
{
    public class Libraryviewmodel : INotifyPropertyChanged
    {

        DbService service = new DbService();
        public event PropertyChangedEventHandler? PropertyChanged;


        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

      
        private string category;
        private string title;
        private string authorname;
        private string description;

        public string Category
        {
            get { return category; }
            set { category = value; OnPropertyChanged("Category"); }
        }

        public string Title
        {
            get => title; set
            {
                title = value; OnPropertyChanged("Title");
            }
        }
        public string AuthorName
        {
            get { return authorname; }
            set { authorname = value; OnPropertyChanged("AuthorName"); }
        }

        public string Description
        {
            get { return description; }
            set { description = value; OnPropertyChanged("Description"); }
        }


        public Libraryviewmodel()
        {

            SearchCommand = new RelayCommand(Search);
            AddCommand = new RelayCommand(Add);
            DeleteCommand = new RelayCommand(Delete);

            Books = new ObservableCollection<Book>(GetBooks());


        }
        private Book currentBook;

        public Book CurrentBook
        {
            get { return currentBook; }
            set
            {
                currentBook = value;
                OnPropertyChanged(nameof(CurrentBook));
            }
        }


        private RelayCommand searchCommand;
        public RelayCommand SearchCommand
        {
            get { return searchCommand; }
            set { searchCommand = value; OnPropertyChanged("SearchCommand"); }
        }

    
        private RelayCommand deleteCommand;
        public RelayCommand DeleteCommand
        {
            get { return deleteCommand; }
            set {  deleteCommand = value; OnPropertyChanged("DeleteCommand"); }
        }


        private void Delete()
        {
            service.DeleteBook(title, authorname);
            using var context = new LibraryDbContext();


            context.SaveChanges();
        }
        
        
        
        private void Search()
        {


            using (var context = new LibraryDbContext())
            {
                var currentBook = context.Books.FirstOrDefault(x => x.Title == title || x.AuthorName == authorname);
                Books = new ObservableCollection<Book>(context.Books.Where(i => i.Title.Contains(title)));
                //if (currentBook != null)
                //{
                //    AuthorName = currentBook.AuthorName;
                //    Title = currentBook.Title;


                //}
                //else
                //{
                //    MessageBox.Show("Kitap bulunamadı.");

                //    //return null;
                //} 
            }
        }

        public List<Book> GetBooks()
        {
            using (var context = new LibraryDbContext())
            {
                return  context.Books.ToList();
                
            }
        }

        private RelayCommand addcommand;
        public RelayCommand AddCommand
        {
            get { return addcommand; }
            set {  addcommand = value; OnPropertyChanged("AddCommand"); }
        }

        public void Add()
        {
            try
            {
            service.AddBook(title, authorname, category, description);
                using var context = new LibraryDbContext();

                

                context.SaveChanges();
                Books = new ObservableCollection<Book>(GetBooks());


            }
            catch (Exception)
            {
                //return null;
            }
            
        }

        private ObservableCollection<Book> _books;

        public ObservableCollection<Book> Books
        {
            get
            {
                return _books;
            }
            set { _books = value; OnPropertyChanged("Books"); }
        }


    }
}
