using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace PokeAScreen
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class Screen1 : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);


            // create ui
            var layout = new LinearLayout(this);
            layout.Orientation = Orientation.Vertical;
            var pokeButton = new Button(this);
            var hiButton = new Button(this);

            pokeButton.Text = "Poke Screen 2";
            hiButton.Text = "Greet Screen 2";


            // add ui controls to layout
            layout.AddView(pokeButton);
            layout.AddView(hiButton);
            // set layout
            SetContentView(layout);


            // event handlers
            pokeButton.Click += (sender, e) =>
            {
                // create intent
                var poke = new Intent(this, typeof(Screen2));
                // add key-value pair
                poke.PutExtra("Screen1Bool", true);
                // start screen 2
                StartActivity(poke);
            };

            hiButton.Click += (sender, e) =>
            {
                // create intent
                var greet = new Intent(this, typeof(Screen2));
                // add key-value pair
                greet.PutExtra("Screen1Message", "Screensons Greetings");
                // start screen 2
                StartActivity(greet);
            };
        }
    }
}