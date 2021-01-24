using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace LuckyNumber
{
    [Activity(Label = "@string/LuckyNumber", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private SeekBar _seekBar;
        private TextView _resultTextView;
        private Button _rollButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            _seekBar = FindViewById<SeekBar>(Resource.Id.seekBar);
            _resultTextView = FindViewById<TextView>(Resource.Id.resultTestView);
            _resultTextView.Text = "9";
            _rollButton = (Button) FindViewById(Resource.Id.rollButton);

        }
    }
}