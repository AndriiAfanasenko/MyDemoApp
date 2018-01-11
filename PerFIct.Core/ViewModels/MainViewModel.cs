using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmCross.Core.ViewModels;

namespace PerFIct.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
       /* public FirstViewModel First { get; private set; }
        public SecondViewModel Second { get; private set; }
        public ThirdViewModel Third { get; private set; }  
        public MainViewModel()
        {
            First = new FirstViewModel();
            Second = new SecondViewModel();
            Third = new ThirdViewModel();
        }   */
        public ICommand GoToSignUp => new MvxCommand(() => ShowViewModel<RegistrationViewModel>());
       
    }
}