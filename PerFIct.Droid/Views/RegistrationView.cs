﻿using System;
using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Support.V7.Widget;
using Android.Views;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Droid.Support.V7.AppCompat;
using PerFIct.Core.ViewModels;
using PerFIct.Droid.Adapters;
using PerFIct.Droid.Views.FragmentsMain;

namespace PerFIct.Droid.Views
{
    [Activity(Label = "View for RegistrationViewModel")]
    public class RegistrationView: MvxAppCompatActivity
    {
        private ViewPager _viewPager;
        private MvxViewPagerFragmentAdapter _adapter;

        public new RegistrationViewModel ViewModel
        {
            get { return (RegistrationViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.RegistrationLayout);

            var toolbar = FindViewById<Toolbar>(Resource.Id.main_toolbar);
           // toolbar.SetTitleTextColor(Resource.Color.black);
           
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

          
            //If you want to start at specific tab
            //viewPager.SetCurrentItem(ViewModel.CurrentPage, false);

            var tabLayout = FindViewById<TabLayout>(Resource.Id.main_tablayout);
            tabLayout.SetupWithViewPager(_viewPager);
        }
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Android.Resource.Id.Home:
                    this.OnBackPressed();
                    return true;
            }

            return base.OnOptionsItemSelected(item);
        }
    }
}