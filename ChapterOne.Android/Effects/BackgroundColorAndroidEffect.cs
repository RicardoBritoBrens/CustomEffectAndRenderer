using System;
using ChapterOne.Droid.Effects;
using ChapterOne.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using System.Linq;
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
                // Implementation using static color change
                //Control.SetBackgroundColor(Android.Graphics.Color.Red);

                var effect = (EntryBackgroundColorEffect)Element.Effects.
                    FirstOrDefault(e => e is EntryBackgroundColorEffect);

                // Implementation using dynamic color change
                if (Control != null)
                {
                    Control.SetBackgroundColor(effect.BackgroundColor.ToAndroid());
                }


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
