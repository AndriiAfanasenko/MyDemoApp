using System;
using Android.Content;
using Android.Runtime;
using Android.Text;
using Android.Text.Method;
using Android.Text.Style;
using Android.Views;
using Android.Widget;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Support.V4;

namespace PerFIct.Droid.Views.FragmentsMain
{
    [Register("perfict.droid.views.fragmentsmain.ExerciserFragment")]
    public class ExerciserFragment:MvxFragment
    {
     
      public override View OnCreateView(Android.Views.LayoutInflater inflater, Android.Views.ViewGroup container, Android.OS.Bundle savedInstanceState)
        {
            var ignore = base.OnCreateView(inflater, container, savedInstanceState);
            var view = inflater.Inflate(Resource.Layout.ExerciserFragment, null);

            //var tv = view.FindViewById<TextView>(Resource.Id.tvHaveAccount);

           

            return this.BindingInflate(Resource.Layout.ExerciserFragment, null);
        }
    }
}
