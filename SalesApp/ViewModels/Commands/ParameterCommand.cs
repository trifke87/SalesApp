using SalesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace SalesApp.ViewModels.Commands
{
    public class ParameterCommand : ICommand
    {

        public ViewModelBase ViewModel { get; set; }

        public ParameterCommand(ViewModelBase viewModel)
        {
            ViewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            if(parameter != null)
            {
                var parameterString = parameter as String;
                parameterString = parameterString.Trim();
                if (String.IsNullOrEmpty(parameterString))
                    return false;

                return true;

            }
            return false;
        }

        public void Execute(object parameter)
        {
            
            //ViewModel.ParametharMethod(parameter as String);
        }
    }
}
