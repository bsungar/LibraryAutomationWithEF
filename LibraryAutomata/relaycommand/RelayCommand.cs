using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LibraryAutomata.relaycommand
{
    using LibraryAutomata.model;
    using System;
    using System.Windows.Input;

    public class RelayCommand : ICommand
    {
        private readonly Action<object> executeWithParam;
        private readonly Action executeWithoutParam;
        private readonly Func<bool> canExecute;
        private Book book;

        public event EventHandler CanExecuteChanged;

        public RelayCommand(Action<object> execute, Func<bool> canExecute = null)
        {
            this.executeWithParam = execute;
            this.canExecute = canExecute;
        }

        public RelayCommand(Action execute, Func<bool> canExecute = null)
        {
            this.executeWithoutParam = execute;
            this.canExecute = canExecute;
        }

        public RelayCommand(Book book)
        {
            this.book = book;
        }

        public bool CanExecute(object parameter)
        {
            return canExecute == null || canExecute();
        }

        public void Execute(object parameter)
        {
            if (executeWithParam != null)
                executeWithParam(parameter);
            else
                executeWithoutParam?.Invoke();
        }
    }
}