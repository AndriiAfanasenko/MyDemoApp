using Android.App;
using Android.OS;
using Android.Support.V7.Widget;
using Android.Views;
using MvvmCross.Droid.Support.V7.AppCompat;
using System.Reflection.Emit;

namespace PerFIct.Droid.Views
{
    [Activity(Label = "View for SignInViewModel", NoHistory =true)]
    public class SignInView : MvxAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.SignInLayout);

           var toolbar1 = FindViewById<Toolbar>(Resource.Id.toolbar_sign_in);

            SetSupportActionBar(toolbar1);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            SupportActionBar.Title = "Sign in";
        }
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Android.Resource.Id.Home:
                    OnBackPressed();
                    return true;
            }

            return base.OnOptionsItemSelected(item);
        }
    }
}