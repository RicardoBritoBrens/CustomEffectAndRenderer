using System;
using ChapterOne.CustomControls;
using ChapterOne.iOS.CustomRenderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(MyEntry), typeof(MyEntryRenderer))]
namespace ChapterOne.iOS.CustomRenderers
{
    public class MyEntryRenderer : EntryRenderer
    {
        public MyEntryRenderer()
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                // Platform native control is created here, have at it
                Control.BackgroundColor = UIColor.FromRGB(42, 42, 42);
                Control.BorderStyle = UITextBorderStyle.Line;
            }
        }
    }
}
