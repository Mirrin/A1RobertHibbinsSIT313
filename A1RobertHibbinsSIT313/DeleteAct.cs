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
    [Activity(Label = "DeleteAct")]
    public class DeleteAct : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);


            SetContentView(Resource.Layout.ListRemove);


            Button btnRemove = FindViewById<Button>(Resource.Id.btnDelete);
            btnRemove.Click += btnRemove_Click;


            // Create your application here
        }

        void btnRemove_Click(object sender, EventArgs e)
        {
            DBRepository dbr = new DBRepository();
            EditText txtTaskId = FindViewById<EditText>(Resource.Id.txtTaskID);
         
         
            string result = dbr.RemoveTask(int.Parse(txtTaskId.Text));
            Toast.MakeText(this, result, ToastLength.Short).Show();
        }
    }
}