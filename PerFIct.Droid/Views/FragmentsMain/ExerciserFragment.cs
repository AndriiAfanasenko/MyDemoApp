using System;
using System.Text.RegularExpressions;
using Android.Content;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Text;
using Android.Text.Method;
using Android.Text.Style;
using Android.Views;
using Android.Widget;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace PerFIct.Droid.Views.FragmentsMain
{
    [Register("perfict.droid.views.fragmentsmain.ExerciserFragment")]
    public class ExerciserFragment: MvxFragment
    {
     
      public override View OnCreateView(Android.Views.LayoutInflater inflater, Android.Views.ViewGroup container, Android.OS.Bundle savedInstanceState)
        {
            var ignore = base.OnCreateView(inflater, container, savedInstanceState);
            var view = inflater.Inflate(Resource.Layout.ExerciserFragment, null);

            var text = view.FindViewById<TextInputEditText>(Resource.Id.name_edittext);
            var button = view.FindViewById<Button>(Resource.Id.button_sign_up);


                button.Click += Button_Click;
               
          
             void Button_Click(object sender, EventArgs e)
            {
                if (string.IsNullOrEmpty(text.Text))
                {
                    text.SetError("Text Can't be empty!", null);

                }
            }
            return view;
        }

       
    }
}
