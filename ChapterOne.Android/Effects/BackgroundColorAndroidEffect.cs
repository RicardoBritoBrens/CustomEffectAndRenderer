using System;
using ChapterOne.Droid.Effects;
using ChapterOne.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("com.ChapterOne")]
[assembly: ExportEffect(typeof(BackgroundColorAndroidEffect), nameof(EntryBackgroundColorEffect))]
namespace ChapterOne.Droid.Effects
{

    public class BackgroundColorAndroidEffect : PlatformEffect
    {
        public BackgroundColorAndroidEffect()
        {
        }

        protected override void OnAttached()
        {
            try
            {
                Control.SetBackgroundColor(Android.Graphics.Color.Red);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        protected override void OnDetached()
        {
            throw new NotImplementedException();
        }
    }
}
