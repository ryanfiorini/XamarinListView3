using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.V4.App;
using XamarinListView.Fragments;

namespace XamarinListView
{
    public class AtmFinderAdapter : FragmentPagerAdapter
    {
        private readonly Android.Support.V4.App.Fragment[] _fragments;

        public AtmFinderAdapter(FragmentManager fm, params Fragment[] fragments) : base(fm)
        {
            _fragments = fragments;
        }

        public override int Count
        {
            get { return _fragments.Length; }
        }

        public override Fragment GetItem(int position)
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