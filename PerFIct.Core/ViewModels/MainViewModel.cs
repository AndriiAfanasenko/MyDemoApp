using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmCross.Core.ViewModels;

namespace PerFIct.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        public ICommand GoToSignUp => new MvxCommand(() => ShowViewModel<RegistrationViewModel>());
    }
}