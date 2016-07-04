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
    public class AtmListviewFragment : Android.Support.V4.App.Fragment
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
            listView.Adapter = new AtmListviewAdapter(Activity, atms);
            listView.ItemClick += ListView_ItemClick;
        }

        private void ListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            throw new NotImplementedException();
        }

    }

    public class AtmListviewAdapter : BaseAdapter<ATM>
    {
        List<ATM> items;
        Activity context;
        public AtmListviewAdapter(Activity context, List<ATM> items)
            : base()
        {
            this.context = context;
            this.items = items;
        }
        public override long GetItemId(int position)
        {
            return position;
        }
        public override ATM this[int position]
        {
            get { return items[position]; }
        }
        public override int Count
        {
            get { return items.Count; }
        }
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = items[position];
            View view = convertView;
            if (view == null) // no view to re-use, create new
                view = context.LayoutInflater.Inflate(Resource.Layout.CustomListView, null);
            view.FindViewById<TextView>(Resource.Id.Text1).Text = item.Address;
            view.FindViewById<TextView>(Resource.Id.Text2).Text = item.Distance;
            //view.FindViewById<ImageView>(Resource.Id.Image).SetImageResource(item.ImageResourceId);
            return view;
        }
    }

}