using Android.App;
using Android.OS;
using Android.Support.V4.View;
using MvvmCross.Droid.Support.V4;
using System.Collections.Generic;
using PerFIct.Droid.Views.Fragments;
using PerFIct.Droid.Adapters;
using PerFIct.Core.ViewModels;
//using com.refractored;
using Android.Support.Design.Widget;

using MvvmCross.Droid.Support.V7.AppCompat;
using Android.Support.V7.Widget;
using Com.Viewpagerindicator;
//using ViewPagerIndicator;

namespace PerFIct.Droid.Views
{
    [Activity(Label = "View for MainViewModel")]
    public class MainView : MvxAppCompatActivity
    {
        private ViewPager _viewPager;
        private CirclePageIndicator _pageIndicator;
        private MvxViewPagerFragmentAdapter _adapter;

     /*   public new MainViewModel ViewModel
        {
            get { return (MainViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }*/

       
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MainLayout);

            var fragments = new List<MvxViewPagerFragmentAdapter.FragmentInfo>
              {
                new MvxViewPagerFragmentAdapter.FragmentInfo
                {
                  FragmentType = typeof(FirstFragment),
                /*  Title = "First Fragment",
                  ViewModel = ViewModel.First*/
                },
                new MvxViewPagerFragmentAdapter.FragmentInfo
                {
                  FragmentType = typeof(SecondFragment),
                  /*Title = "Second Fragment",
                  ViewModel = ViewModel.Second*/
                },
                new MvxViewPagerFragmentAdapter.FragmentInfo
                {
                  FragmentType = typeof(ThirdFragment),
                 /* Title = "Third Fragment",
                  ViewModel = ViewModel.Third*/
                }
              };

            //var toolbar = FindViewById<Toolbar>(Resource.Id.main_toolbar);

          /*  SetSupportActionBar(toolbar);
            SupportActionBar.SetDisplayHomeAsUpEnabled(false);
            SupportActionBar.Title = "SampleTabs";*/

            _viewPager = FindViewById<ViewPager>(Resource.Id.main_view_pager);
            _adapter = new MvxViewPagerFragmentAdapter(this, SupportFragmentManager, fragments);
            _viewPager.Adapter = _adapter;

            //var dots = FindViewById<TabLayout>(Resource.Id.dots);
            //dots.SetupWithViewPager(_viewPager, false); // <- magic here

          /*  var tabLayout = FindViewById<TabLayout>(Resource.Id.main_tablayout);
            tabLayout.SetupWithViewPager(_viewPager);*/


            _pageIndicator = FindViewById<CirclePageIndicator>(Resource.Id.indicator);

            _pageIndicator.SetViewPager(_viewPager);

        }
    }
}
