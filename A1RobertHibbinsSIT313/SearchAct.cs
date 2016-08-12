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
using A1RobertHibbinsSIT313.Assets.ORM;

namespace A1RobertHibbinsSIT313
{
    [Activity(Label = "SearchAct")]
    public class SearchAct : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.searchLayout);
            Button btnSearch = FindViewById<Button>(Resource.Id.btnSearch);
            btnSearch.Click += btnSearch_Click;

            // Create your application here
        }

        void btnSearch_Click (object sender, EventArgs e)
        {
            DBRepository dbr = new DBRepository();
            EditText txtId = FindViewById<EditText>(Resource.Id.txtTaskID);
            string task = dbr.GetTaskById(int.Parse(txtId.Text));
            Toast.MakeText(this, task, ToastLength.Short).Show();


        }
    }
}