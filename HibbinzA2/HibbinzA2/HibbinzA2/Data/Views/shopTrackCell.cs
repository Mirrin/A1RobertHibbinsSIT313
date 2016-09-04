using System;
using Xamarin.Forms;

namespace HibbinzA2.Data.Views
{
    public class shopTrackCell : ViewCell
    {
        public shopTrackCell()
        {
            var label = new Label
            {
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.StartAndExpand
            };

            label.SetBinding(Label.TextProperty, "Name");

            var tick = new Image
            {
                Source = FileImageSource.FromFile("check.png"),
                HorizontalOptions = LayoutOptions.End
            };

            tick.SetBinding(Image.IsVisibleProperty, "Done");

            var layout = new StackLayout
            {
                Padding = new Thickness(20, 0, 20, 0),
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                Children = { label, tick }
            };

            View = layout;
        }
    }
}

