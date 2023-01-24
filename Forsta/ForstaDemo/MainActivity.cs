using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Com.Confirmit.Mobilesdk;

namespace ForstaDemo
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            //forsta plus server
            var serverId = ConfirmitServer.Instance.UK.ServerId;

            // digital feedback program key
            var programKey = "3Xqe05";

            try
            {
                var result = TriggerSDK.Instance.Download(serverId, programKey);
                if (result != null)
                {

                }
                else
                {

                }
            }
            catch (System.Exception)
            {

            }
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}