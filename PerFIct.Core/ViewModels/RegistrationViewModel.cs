using System;
using MvvmCross.Core.ViewModels;

namespace PerFIct.Core.ViewModels
{
    public class RegistrationViewModel:MvxViewModel
    {
        public FirstViewModel First { get; private set; }
        public SecondViewModel Second { get; private set; }

        public RegistrationViewModel()
        {
            First = new FirstViewModel();
            Second = new SecondViewModel();
        }
    }
}
