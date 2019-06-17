using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SalesApp.ViewModels.Commands
{
    public class MaterialSave : ICommand
    {

        private MaterialViewModel _viewModel;

        public MaterialSave(MaterialViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            if (_viewModel.CanSave && String.IsNullOrWhiteSpace(_viewModel.Material.Error))
                return true;
            else
                return false;
            //return _viewModel.CanSave;
            //return String.IsNullOrWhiteSpace(_viewModel.Material.Error);
        }

        public void Execute(object parameter)
        {
            _viewModel.SaveChanges();
        }
    }
}
