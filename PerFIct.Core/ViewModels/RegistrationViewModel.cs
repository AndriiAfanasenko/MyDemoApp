using System;
using MvvmCross.Core.ViewModels;

namespace PerFIct.Core.ViewModels
{
    public class RegistrationViewModel:MvxViewModel
    {
        public ExerciserViewModel First { get; private set; }
        public TrainerViewModel Second { get; private set; }

        public RegistrationViewModel()
        {
            First = new ExerciserViewModel();
            Second = new TrainerViewModel();
        }
    }
}
