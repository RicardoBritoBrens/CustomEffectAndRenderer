using System;
using System.Linq;
using ChapterOne.Effects;
using ChapterOne.iOS.Effects;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("com.ChapterOne")]
[assembly: ExportEffect(typeof(BackgroundiOSColorEffect), nameof(EntryBackgroundColorEffect))]
namespace ChapterOne.iOS.Effects
{
    public class BackgroundiOSColorEffect : PlatformEffect
    {
        public BackgroundiOSColorEffect()
        {
        }

        protected override void OnAttached()
        {
            try
            {
                // Implementation using static color change
                // Control.BackgroundColor = UIColor.FromRGB(42, 42, 42);

                // Implementation using dynamic color change
                var effect = (EntryBackgroundColorEffect)Element.Effects.
                    FirstOrDefault(e => e is EntryBackgroundColorEffect);

                if (effect != null)
                {
                    Control.BackgroundColor = effect.BackgroundColor.ToUIColor();
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
