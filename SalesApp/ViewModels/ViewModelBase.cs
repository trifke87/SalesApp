using SalesApp.Models;
using SalesApp.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesApp.ViewModels
{
    public class ViewModelBase
    {
        public SimpleCommand SimpleCommand { get; set; }
        public ParameterCommand ParameterCommand { get; set; }
        public ViewModelBase()
        {
            SimpleCommand = new SimpleCommand(this);
            ParameterCommand = new ParameterCommand(this);
        }

        public void SimpleMethod()
        {
            Debug.WriteLine("Hello!");
        }
        public void ParametharMethod(Material material)
        {
            //Debug.WriteLine(parameter);

        }
    }
}
