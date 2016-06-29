using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace XamarinListView
{
    [Activity(Label = "XamarinListView", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            if (bundle == null)
            {
                FragmentTransaction transaction = FragmentManager.BeginTransaction();
                var fragment = new XamarinListView.FragmentAtmListview();
                transaction.Replace(Resource.Id.titles_fragment, fragment);
                transaction.Commit();
            }
        }
    }
}

