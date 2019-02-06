using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace App1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {



        TextView ft, tt, bmi;
        EditText s1, o1, bmi1;
        Button cal, clear;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            ft = (TextView)FindViewById(Resource.Id.tvheight);
            tt = (TextView)FindViewById(Resource.Id.tvweight);
            bmi = (TextView)FindViewById(Resource.Id.tvbmi);
            s1 = (EditText)FindViewById(Resource.Id.etheight);
            o1 = (EditText)FindViewById(Resource.Id.etweight);
            bmi1 = (EditText)FindViewById(Resource.Id.etbmi);
            cal = (Button)FindViewById(Resource.Id.btcalc);
            clear = (Button)FindViewById(Resource.Id.btclr);
            cal.Click += delegate
            {
                if (s1.Text != "" && o1.Text != "")
                {

                    double c = double.Parse(s1.Text);
                    double f = double.Parse(o1.Text);
                    double d = f * f / c;
                    bmi1.Text = d.ToString();

                }






            };

            clear.Click += delegate
            {
                o1.Text = "";
                s1.Text = "";
                bmi1.Text = "";
            };
        }


        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View) sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
        }
	}
}

