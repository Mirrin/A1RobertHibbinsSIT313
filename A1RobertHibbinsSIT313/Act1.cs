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

namespace A1RobertHibbinsSIT313
{
    [Activity(Label = "Act1")]
    public class Act1 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // this ties our activity with our layout page
            SetContentView(Resource.Layout.Activity1);
            // Create your application here


            TextView name = FindViewById<TextView>(Resource.Id.nameLabel);
            name.Text = Data.Name;

        }
    }
}