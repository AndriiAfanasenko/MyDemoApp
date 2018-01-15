using System;
using System.Windows.Input;
using MvvmCross.Core.ViewModels;

namespace PerFIct.Core.ViewModels
{
    public class TrainerViewModel : MvxViewModel
    {
        public ICommand GoToSignIn => new MvxCommand(() => ShowViewModel<SignInViewModel>());
    }
}
