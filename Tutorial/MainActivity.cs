using Android.App;
using Android.Widget;
using Android.OS;

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

            button.Click += Button_Click;
        }

        private void Button_Click(object sender, System.EventArgs e)
        {
            texto.Text = "Haz clicado el botón";
            Toast.MakeText(this, "Mensaje 1", ToastLength.Short).Show();
        }
    }
}

