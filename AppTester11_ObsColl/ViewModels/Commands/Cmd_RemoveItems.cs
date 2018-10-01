using Models;
using System;
using System.Windows.Input;
using ViewModels;

namespace ViewModels.Commands
{
    public class Cmd_RemoveItems: ICommand
    {
        public VM_Content ViewModel { get; set; }

        public Cmd_RemoveItems(VM_Content viewModel)
        {
            ViewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            //if (parameter != null)
            //{
            //    var s = parameter as String;
            //    s = s.Trim();
            //    if (String.IsNullOrEmpty(s))
            //        return false;

            //    return true;
            //}
            //return false;
            return true;
        }

        public void Execute(object parameter)
        {
            ViewModel.RemoveItems(parameter as Content);
        }

    }
}