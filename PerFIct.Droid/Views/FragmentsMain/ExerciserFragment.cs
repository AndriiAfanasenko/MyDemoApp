
using Android.Runtime;
using Android.Views;
using MvvmCross.Droid.Support.V4;
using PerFIct.Core.ViewModels;

namespace PerFIct.Droid.Views.FragmentsMain
{
    [Register("perfict.droid.views.fragmentsmain.ExerciserFragment")]
    public class ExerciserFragment: MvxFragment
    {

      public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Android.OS.Bundle savedInstanceState)
      {
            var ignore = base.OnCreateView(inflater, container, savedInstanceState);
            var view = inflater.Inflate(Resource.Layout.ExerciserFragment, null);

            return view;
      }
 
    }
}
