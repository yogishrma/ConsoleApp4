using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace bmi_calculator
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {



        TextView qt, pt, bmi;
        EditText n1, m1, bmi1;
        Button cal, clear;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            qt = (TextView)FindViewById(Resource.Id.tvheight);
            pt = (TextView)FindViewById(Resource.Id.tvweight);
            bmi = (TextView)FindViewById(Resource.Id.tvbmi);
            n1 = (EditText)FindViewById(Resource.Id.etheight);
            m1 = (EditText)FindViewById(Resource.Id.etweight);
            bmi1 = (EditText)FindViewById(Resource.Id.etbmi);
            cal = (Button)FindViewById(Resource.Id.btcalc);
            clear = (Button)FindViewById(Resource.Id.btclr);
            cal.Click += delegate
            {
                if (n1.Text != "" && m1.Text != "")
                {

                    double c = double.Parse(n1.Text);
                    double f = double.Parse(m1.Text);
                    double d = f * f / c;
                    bmi1.Text = d.ToString();

                }






            };

            clear.Click += delegate
            {
                n1.Text = "";
                m1.Text = "";
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

