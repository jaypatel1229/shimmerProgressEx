using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Supercharge;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CircleProgressBar
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

            var shimmerLayout = FindViewById<ShimmerLayout>(Resource.Id.shimmer_layout);
            shimmerLayout.StartShimmerAnimation();
                     
        }
    }
}