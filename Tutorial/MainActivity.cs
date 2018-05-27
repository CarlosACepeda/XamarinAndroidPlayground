using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using System;

namespace Tutorial
{
    [Activity(Label = "Tutorial", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private Button button;
        private TextView texto;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            button = FindViewById<Button>(Resource.Id.btnClick);
            texto = FindViewById<TextView>(Resource.Id.txtTexto);
        }
        protected override void OnResume()
        {
            base.OnResume();
            button.Click += Button_Click;
        }
        protected override void OnPause()
        {
            base.OnPause();
            button.Click -= Button_Click;
        }
        protected override void OnDestroy()
        {
            base.OnDestroy();
            button.Dispose();
            button = null;
            texto.Dispose();
            texto = null;
            texto.Dispose();
            GC.Collect();
        }
        private void Button_Click(object sender, System.EventArgs e)
        {
            texto.Text = "Haz clicado el botón";
            Toast.MakeText(this, "Mensaje 1", ToastLength.Short).Show();
            Intent intent = new Intent(this, typeof(SecondActivity));
            StartActivity(intent);
        }
    }
}
