using System;
using MvvmCross.Core.ViewModels;

namespace PerFIct.Core.ViewModels
{
    public class SecondViewModel : MvxViewModel
    {
       
        private string _name = "Second";

        public string Name
        {
            get { return this._name; }
            set { _name = value; RaisePropertyChanged(() => Name); }
        }

    }
}
