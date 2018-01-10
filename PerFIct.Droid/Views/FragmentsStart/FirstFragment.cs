﻿using System;
using Android.OS;
using Android.Runtime;
using Android.Views;
using PerFIct.Core.ViewModels;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Binding.Droid.BindingContext;
using System.Collections.Generic;

namespace PerFIct.Droid.Views.Fragments
{
    [Register("perfict.droid.views.fragments.FirstFragment")]
    public class FirstFragment : MvxFragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignore = base.OnCreateView(inflater, container, savedInstanceState);
            return this.BindingInflate(Resource.Layout.FirstStartFragment, null);
        }
    }
}
