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
    [Activity(Label = "Act2")]
    public class Act2 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // this ties our activity with our layout page
            SetContentView(Resource.Layout.Activity2);
            // Create the database

            Button btnCreateDB = FindViewById<Button>(Resource.Id.btnCreateDb);
            btnCreateDB.Click += btnCreateDB_Click;

            // create Table.
            Button btnCreatTable = FindViewById<Button>(Resource.Id.btnCreateTable);
            btnCreatTable.Click += btnCreateTable_Click;

            // insert record 
            Button btnAddRecord = FindViewById<Button>(Resource.Id.btnInsert);
            btnAddRecord.Click += btnAddRecord_Click;

            // to get data
            Button btnGetAll = FindViewById<Button>(Resource.Id.btnGetData);
            btnGetAll.Click += btnGetAll_Click;

            // to search records 
            Button btnGetById = FindViewById<Button>(Resource.Id.btnGetID);
            btnGetById.Click += btnGetById_Click;

            // update 

            // to search records 
            Button btnUpdate = FindViewById<Button>(Resource.Id.btnUpdate);
            btnUpdate.Click += btnUpdate_Click;

            //delete list records
            Button btnDelete = FindViewById<Button>(Resource.Id.btnDelete);
            btnDelete.Click += btnDelete_Click;


        }



        // delete a record in a new window 

        void btnDelete_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(DeleteAct));


        }

        // update a record in a new window 

        void btnUpdate_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(UpdateTaskAct));


        }





        // search record intent 

        void btnGetById_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(SearchAct));


        }


        // Get all data on click 

        void btnGetAll_Click(object sender, EventArgs e)
        {
            DBRepository dbr = new DBRepository();
            var result = dbr.GetAllRecords();
            Toast.MakeText(this, result, ToastLength.Short).Show();

        }

        // add record intent 

        void btnAddRecord_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(InsertAct));


        }
        // create Data base on clikc method
        void btnCreateDB_Click ( object sender, EventArgs e)
        {
            DBRepository dbr = new DBRepository();
            var result = dbr.CreateDB();
            Toast.MakeText(this, result, ToastLength.Short).Show();

              }



        // on click method for create table.
        void btnCreateTable_Click(object sender, EventArgs e)
        {
            DBRepository dbr = new DBRepository();
            var result = dbr.CreateTable();
            Toast.MakeText(this, result, ToastLength.Short).Show();

        }



    }
}