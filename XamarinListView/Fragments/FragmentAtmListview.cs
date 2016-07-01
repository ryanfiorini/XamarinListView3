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
    public class FragmentAtmListview : Android.Support.V4.App.Fragment
    {
        List<ATM> atms;
        ListView listView;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            return inflater.Inflate(Resource.Layout.fragment_atm_listview, container, false);
        }

        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);

            atms = new List<ATM> {
                new ATM {Address="111 James St., Lancaster, PA 17601", Distance="1.1 Mi" },
                new ATM {Address="222 Orange St., Lancaster, PA 17601", Distance="2.2 Mi" },
                new ATM {Address="333 King St., Lancaster, PA 17601", Distance="3.3 Mi" }
            };

            listView = Activity.FindViewById<ListView>(Resource.Id.listView1); // get reference to the ListView in the layout
                                                                               // populate the listview with data
            listView.Adapter = new HomeScreenAdapter(Activity, atms);
            listView.ItemClick += ListView_ItemClick;
        }

        private void ListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            throw new NotImplementedException();
        }

    }
}