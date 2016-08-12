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
    [Activity(Label = "UpdateTaskAct")]
    public class UpdateTaskAct : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.UpdateLayout);
            // search button 
            Button btnSearch = FindViewById<Button>(Resource.Id.btnSearch);
            btnSearch.Click += btnSearch_Click;

            // update button 
            Button btnUpdate = FindViewById<Button>(Resource.Id.btnUpdate);
            btnUpdate.Click += btnUpdate_Click;

        }

        // update

        void btnUpdate_Click(object sender, EventArgs e)
        {
            EditText txtId = FindViewById<EditText>(Resource.Id.txtTaskID);
            EditText txtTask = FindViewById<EditText>(Resource.Id.txtTask);
            DBRepository dbr = new DBRepository();
            string result = dbr.updateRecord(int.Parse(txtId.Text), txtTask.Text);
            Toast.MakeText(this, result, ToastLength.Short).Show();
        }
            // search 

            void btnSearch_Click(object sender, EventArgs e)
        {

            DBRepository dbr = new DBRepository();
            EditText txtId = FindViewById<EditText>(Resource.Id.txtTaskID);
            EditText txtTask = FindViewById<EditText>(Resource.Id.txtTask);
            txtTask.Text = dbr.GetTaskById(int.Parse(txtId.Text));




            
       






        }
    }
}