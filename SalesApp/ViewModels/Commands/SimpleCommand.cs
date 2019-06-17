using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SalesApp.ViewModels.Commands
{
    public class SimpleCommand : ICommand
    {
        public ViewModelBase ViewModel { get; set; }
        public SimpleCommand(ViewModelBase viewModel)
        {
            ViewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ViewModel.SimpleMethod();
        }
    }
}
