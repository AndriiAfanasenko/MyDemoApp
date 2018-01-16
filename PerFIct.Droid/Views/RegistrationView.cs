using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Views.InputMethods;
using MvvmCross.Droid.Support.V7.AppCompat;
using PerFIct.Core.ViewModels;
using PerFIct.Droid.Adapters;
using PerFIct.Droid.Views.FragmentsMain;
using static Android.Support.Design.Widget.TabLayout;

namespace PerFIct.Droid.Views
{
    [Activity(Label = "View for RegistrationViewModel")]
    public class RegistrationView: MvxAppCompatActivity<RegistrationViewModel>
    {
        private ViewPager _viewPager;
        private MvxViewPagerFragmentAdapter _adapter;

        public new RegistrationViewModel ViewModel
        {
            get { return base.ViewModel; }
            set { base.ViewModel = value; }
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.RegistrationLayout);
            
            var toolbar = FindViewById<Toolbar>(Resource.Id.main_toolbar);
           
            SetSupportActionBar(toolbar);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            SupportActionBar.Title = "Sign up";

            var fragments = new List<MvxViewPagerFragmentAdapter.FragmentInfo>
            {
                new MvxViewPagerFragmentAdapter.FragmentInfo
                {
                  FragmentType = typeof(ExerciserFragment),
                  Title = "EXERCISER",
                  ViewModel = ViewModel.First
                },
                new MvxViewPagerFragmentAdapter.FragmentInfo
                {
                  FragmentType = typeof(TrainerFragment),
                  Title = "TRAINER",
                  ViewModel = ViewModel.Second
                }
            };

            _viewPager = FindViewById<ViewPager>(Resource.Id.main_view_pager);
            _adapter = new MvxViewPagerFragmentAdapter(this, SupportFragmentManager, fragments);
            _viewPager.Adapter = _adapter;

            var tabLayout = FindViewById<TabLayout>(Resource.Id.main_tablayout);
            tabLayout.SetupWithViewPager(_viewPager);

            tabLayout.TabSelected += (sender, args) =>
            {
                  DismissKeyboard();
            };
            DismissKeyboard();
        }

        private void DismissKeyboard()
        {
            var view = CurrentFocus;
            if (view != null)
            {
                var imm = (InputMethodManager)GetSystemService(InputMethodService);
                imm.HideSoftInputFromWindow(view.WindowToken, 0);
            }
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
