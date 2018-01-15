using System;
using System.Windows.Input;
using MvvmCross.Core.Navigation;

using MvvmValidation;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using PerFIct.Core.Common;


namespace PerFIct.Core.ViewModels
{


    public class ExerciserViewModel:MvxViewModel
    {
        public ICommand GoToSignIn => new MvxCommand(() => ShowViewModel<SignInViewModel>());
        private ValidationHelper _validator ;

      
        private string _email;
        public string Email
        {
            get => _email;
            set { _email = value; RaisePropertyChanged(() => Email); }
        }
        private ObservableDictionary<string, string> _errors;
        public ObservableDictionary<string, string> Errors
        {
            get => _errors;
            set { _errors = value; RaisePropertyChanged(() => Errors); }
        }
       

        public MvxCommand SigninCommand => new MvxCommand(() => Validate());
       
       
        private bool Validate()
        {
            _validator = new ValidationHelper();
            _validator.AddRequiredRule(() => Email, "Email is required.");
           

            var result = _validator.ValidateAll();

            Errors = result.AsObservableDictionary();

            return result.IsValid;
        }
    }
}
