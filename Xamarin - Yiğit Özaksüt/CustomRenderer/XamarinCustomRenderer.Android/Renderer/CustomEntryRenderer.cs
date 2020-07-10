using Android.Graphics;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinCustomRenderer.Droid.Renderer;

#pragma warning disable CS0612 // Type or member is obsolete
[assembly: ExportRenderer(typeof(Entry), typeof(CustomEntryRenderer))]
#pragma warning restore CS0612 // Type or member is obsolete

namespace XamarinCustomRenderer.Droid.Renderer
{
    [Obsolete]
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (Control == null)
                return;

            Control.SetBackgroundColor(Android.Graphics.Color.Yellow);
            Control.SetTextColor(Android.Graphics.Color.Red);
        }
    }
}