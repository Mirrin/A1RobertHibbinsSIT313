using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace A1RobertHibbinsSIT313
{
    [Activity(Label = "A1RobertHibbinsSIT313", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
       

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it

            // this is for button 1 to go to activity 1 
            Button act1Btn = FindViewById<Button>(Resource.Id.act1Btn);
            act1Btn.Click += (sender, e) =>

            {

                EditText name = FindViewById<EditText>(Resource.Id.nameBox);
                Data.Name = name.Text;
                // sets intent to start new activity
                var intent = new Intent(this, typeof(Act1));
                StartActivity(intent);

            };

            // this controls the intent for the button press for activity 2
            Button act2Btn = FindViewById<Button>(Resource.Id.act2Btn);
            act2Btn.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(Act2));
                StartActivity(intent);

            };


        }
    }
}

