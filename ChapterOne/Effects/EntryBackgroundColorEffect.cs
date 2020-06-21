using System;
using Xamarin.Forms;

namespace ChapterOne.Effects
{
    public class EntryBackgroundColorEffect : RoutingEffect
    {
        public Color BackgroundColor { get; set; }
        public EntryBackgroundColorEffect() : base($"com.ChapterOne.{nameof(EntryBackgroundColorEffect)}")
        {
        }
    }
}
