using Android.App;
using Android.OS;
using Android.Support.V4.View;
using System.Collections.Generic;
using PerFIct.Droid.Views.Fragments;
using PerFIct.Droid.Adapters;
using Android.Support.Design.Widget;
using MvvmCross.Droid.Support.V7.AppCompat;
using Android.Content.PM;

namespace PerFIct.Droid.Views
{
    [Activity(Label = "View for MainViewModel", ScreenOrientation = ScreenOrientation.Portrait)]
    public class MainView : MvxAppCompatActivity
    {
        private ViewPager _viewPager;
        private MvxViewPagerFragmentAdapter _adapter;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MainLayout);
           
            var fragments = new List<MvxViewPagerFragmentAdapter.FragmentInfo>
              {
                new MvxViewPagerFragmentAdapter.FragmentInfo
                {
                  FragmentType = typeof(FirstFragment),
                },
                new MvxViewPagerFragmentAdapter.FragmentInfo
                {
                  FragmentType = typeof(SecondFragment),
                },
                new MvxViewPagerFragmentAdapter.FragmentInfo
                {
                  FragmentType = typeof(ThirdFragment),
                }
              };

            _viewPager = FindViewById<ViewPager>(Resource.Id.main_view_pager);
            _adapter = new MvxViewPagerFragmentAdapter(this, SupportFragmentManager, fragments);
            _viewPager.Adapter = _adapter;

            var dots = FindViewById<TabLayout>(Resource.Id.dots);
            dots.SetupWithViewPager(_viewPager, true); 

        }
    }     
}
