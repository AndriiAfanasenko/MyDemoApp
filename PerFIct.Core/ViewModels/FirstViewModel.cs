using System;
using MvvmCross.Core.ViewModels;

namespace PerFIct.Core.ViewModels
{
    public class FirstViewModel:MvxViewModel
    {
        
        private string _name = "First";

        public string Name
        {
            get { return this._name; }
            set { _name = value; RaisePropertyChanged(()=>Name);}
        }
    }
}
