using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace MicrosoftCatalog
{
    [Activity(Label = "MicrosoftCatalog", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Button buttonPrev;
        Button buttonNext;
        TextView textTitle;
        int i;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            buttonPrev = FindViewById<Button>(Resource.Id.ButtonPrev);
            buttonNext = FindViewById<Button>(Resource.Id.buttonNext);
            textTitle = FindViewById<TextView>(Resource.Id.textTitle);

            buttonPrev.Click += ButtonPrev_Click;
            buttonNext.Click += ButtonNext_Click;
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            
            textTitle.Text = "Next clicked.";
        }

        private void ButtonPrev_Click(object sender, EventArgs e)
        {
            
            textTitle.Text = "Prev clicked.";
        }
    }
}

