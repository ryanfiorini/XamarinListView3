using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace XamarinListView.Fragments
{
    public class AtmFinderFragement : Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //FragmentTransaction transaction = FragmentManager.BeginTransaction();
            ////var fragment = new XamarinListView.FragmentAtmListview();
            //var fragment = new XamarinListView.FragmentAtmListview();
            //transaction.Replace(Resource.Id.vpPager, fragment);
            //transaction.Commit();

        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            return inflater.Inflate(Resource.Layout.fragment_main, container, false);

            //return base.OnCreateView(inflater, container, savedInstanceState);
        }
    }

    public class AtmFinderAdapter : Android.Support.V4.App.FragmentPagerAdapter
    {
        private readonly Android.Support.V4.App.Fragment[] _fragments;

        public AtmFinderAdapter(Android.Support.V4.App.FragmentManager fm, params Android.Support.V4.App.Fragment[] fragments) : base(fm)
        {
            _fragments = fragments;
        }

        public override int Count
        {
            get { return _fragments.Length; }
        }

        public override Android.Support.V4.App.Fragment GetItem(int position)
        {
            return _fragments[position];
        }

        public override Java.Lang.ICharSequence GetPageTitleFormatted(int position)
        {
            var title = String.Format("Tab {0}", position + 1);
            return new Java.Lang.String(title);
        }
    }

}