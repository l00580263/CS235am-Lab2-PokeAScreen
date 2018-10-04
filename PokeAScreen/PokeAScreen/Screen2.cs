using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace PokeAScreen
{
    [Activity(Label = "Screen2")]
    public class Screen2 : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // create ui
            var layout = new LinearLayout(this);
            layout.Orientation = Orientation.Vertical;
            var messageLabel = new TextView(this);
            layout.AddView(messageLabel);
            

            // enable 'up'
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);


            // change message
            var passedMessage = Intent.GetStringExtra("Screen1Message");
            var passedBool = Intent.GetBooleanExtra("Screen1Bool", false);
            if (passedMessage != null)
            {
                // greet
                messageLabel.Text = passedMessage;
            }
            else if (passedBool)
            {
                // poke
                messageLabel.Text = "Done been Poked.";
            }

            // set content
            SetContentView(layout);
        }


        // up functionality
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            if (item.ItemId != Android.Resource.Id.Home)
            {
                return base.OnOptionsItemSelected(item);
            }
            Finish();
            return true;
        }
    }
}