using System;
using Android.Runtime;
using Android.Text;
using Android.Widget;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Support.V4;

namespace PerFIct.Droid.Views.FragmentsMain
{
    [Register("perfict.droid.views.fragmentsmain.TrainerFragment")]
    public class TrainerFragment : MvxFragment
    {
        public override Android.Views.View OnCreateView(Android.Views.LayoutInflater inflater, Android.Views.ViewGroup container, Android.OS.Bundle savedInstanceState)
        {
            var ignore = base.OnCreateView(inflater, container, savedInstanceState);
            var view = inflater.Inflate(Resource.Layout.TrainerFragment, null);
           

            return view;
        }
    }
}
