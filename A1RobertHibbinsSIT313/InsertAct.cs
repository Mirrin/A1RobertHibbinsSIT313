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
    [Activity(Label = "InsertAct")]
    public class InsertAct : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.InsertLayout);
            Button btnAdd = FindViewById<Button>(Resource.Id.btnTask);
            btnAdd.Click += btnAdd_Click;

        }


        // on click method for create table.
        void btnAdd_Click(object sender, EventArgs e)
        {
            EditText txtTask = FindViewById<EditText>(Resource.Id.txtTask);
            DBRepository dbr = new DBRepository();
        
            string result = dbr.InsertRecord(txtTask.Text);
            Toast.MakeText(this, result, ToastLength.Short).Show();

        }

    }
}