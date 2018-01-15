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
        private ValidationHelper _validator;
        public ICommand GoToSignIn => new MvxCommand(() => ShowViewModel<SignInViewModel>());
        public MvxCommand SigninCommand => new MvxCommand(() => Validate());

        private string _name;
        public string Name
        {
            get => _name;
            set { _name = value; RaisePropertyChanged(() => Name); }
        }

        private string _userName;
        public string UserName
        {
            get => _userName;
            set { _userName = value; RaisePropertyChanged(() => UserName); }
        }

        private string _email;
        public string Email
        {
            get => _email;
            set { _email = value; RaisePropertyChanged(() => Email); }
        }

        private string _password;
        public string Password
        {
            get => _password;
            set { _password = value; RaisePropertyChanged(() => Password); }
        }

        private ObservableDictionary<string, string> _errors;
        public ObservableDictionary<string, string> Errors
        {
            get => _errors;
            set { _errors = value; RaisePropertyChanged(() => Errors); }
        }
       
        private bool Validate()
        {
            _validator = new ValidationHelper();
            _validator.AddRequiredRule(() => Name, "Name is required.");
            _validator.AddRequiredRule(() => UserName, "Username is required.");
            _validator.AddRequiredRule(() => Email, "Email is required.");
            _validator.AddRequiredRule(() => Password, "Password is required.");
           
            var result = _validator.ValidateAll();
            Errors = result.AsObservableDictionary();

            return result.IsValid;
        }
    }
}
