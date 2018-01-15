using System;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Support.V4;
using PerFIct.Core.ViewModels;

namespace PerFIct.Droid.Views.FragmentsMain
{
    [Register("perfict.droid.views.fragmentsmain.TrainerFragment")]
    public class TrainerFragment : MvxFragment<TrainerViewModel>
    {
       
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Android.OS.Bundle savedInstanceState)
        {
            var ignore = base.OnCreateView(inflater, container, savedInstanceState);
        
           
            var view = this.BindingInflate(Resource.Layout.TrainerFragment, null);

            var buttonGoToPerfict = view.FindViewById<Button>(Resource.Id.buttonGoToPerfict);

            buttonGoToPerfict.Click += ButtonGoToPerfict_Click;

            return view;
        }

        private void ButtonGoToPerfict_Click(object sender, EventArgs e)
        {
            var uri = Android.Net.Uri.Parse("http://www.perfict.com");
            var intent = new Intent(Intent.ActionView, uri);
            StartActivity(intent);
        }
    }
}
