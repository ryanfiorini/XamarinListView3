using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace XamarinListView.Fragments
{
    public class PagerFragment : Android.Support.V4.App.Fragment
    {
        int IDIMG { get; set; }

        public PagerFragment()
        {
            IDIMG = 4;
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.DemoFragment, container, false);
            //((ImageView)view.FindViewById(Resource.Id.imageview_card)).SetImageResource(IDIMG);
            return view;
        }
    }
}