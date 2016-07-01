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
    public class MainFragement : Fragment
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
            //return inflater.Inflate(Resource.Layout.fragment_main, container, false);

            return base.OnCreateView(inflater, container, savedInstanceState);
        }
    }
}