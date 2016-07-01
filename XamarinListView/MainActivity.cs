using System;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using Android.Support.V4.View;
using XamarinListView.Transforms;
using Android.App;
using XamarinListView.Fragments;

namespace XamarinListView
{
    [Activity(Label = "XamarinListView", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Android.Support.V4.App.FragmentActivity, ViewPager.IOnPageChangeListener
    {
        int count = 1;
        private ViewPager mCardsViewPager;

        public void OnPageScrolled(int position, float positionOffset, int positionOffsetPixels)
        {
        }

        public void OnPageScrollStateChanged(int state)
        {
        }

        public void OnPageSelected(int position)
        {
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //if (bundle == null)
            //{
            //    FragmentTransaction transaction = FragmentManager.BeginTransaction();
            //    var fragment = new XamarinListView.FragmentAtmListview();
            //    //var fragment = new XamarinListView.Fragments.FragmentMain();
            //    transaction.Replace(Resource.Id.titles_fragment, fragment);
            //    transaction.Commit();
            //}

            //var view = FindViewById<ViewPager>(Resource.Id.)

            var adapter =
                    new AtmFinderAdapter(SupportFragmentManager,
                        new FirstFragement(), new FragmentAtmListview(), new PagerFragment());
            var viewPager = FindViewById<Android.Support.V4.View.ViewPager>(Resource.Id.viewPager);
            viewPager.Adapter = adapter;
        }
    }
}

