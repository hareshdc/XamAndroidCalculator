using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;

namespace XamAndroidCalculator
{
	[Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
	public class MainActivity : Activity
	{
        Button btnCalculate;
        EditText etInput;
        TextView tvTip;
        TextView tvTotal;

        protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.Main);

            btnCalculate = FindViewById<Button>(Resource.Id.btnCalculate);
            etInput = FindViewById<EditText>(Resource.Id.etInput);
            tvTip = FindViewById<TextView>(Resource.Id.tvTipVal);
            tvTotal = FindViewById<TextView>(Resource.Id.tvTotalVal);

            btnCalculate.Click += BtnCalculate_Click;
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            string text = etInput.Text;

            double bill;

            if (Double.TryParse(text, out bill))
            {
                double tip = bill * 0.15;
                Console.Write(tip.ToString());
                double total = bill + tip;

                tvTip.Text = tip.ToString();
                tvTotal.Text = total.ToString();
            }
        }
    }
}

