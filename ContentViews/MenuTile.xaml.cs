using MauiTestApp.Models;

namespace MauiTestApp.ContentViews;

public partial class Tile : ContentView
{
    public MobileMenu MenuItem { get; set; }

    public Tile(MobileMenu menuItem)
    {
        MenuItem = menuItem;
        InitializeComponent();
        ItemBorder.BackgroundColor = Colors.Azure;
        Description.IsVisible = !string.IsNullOrEmpty(MenuItem.Description);

            var imageView = new ImageView(MenuItem, 100);
                imageView.VerticalOptions = imageView.HorizontalOptions = LayoutOptions.Fill;
                imageView.WidthRequest = 100;
            ItemLayout.AddWithSpan(imageView, 0, 0, 2);

        CountBubble.Count = MenuItem.Count;
        CountBubble.IsVisible = MenuItem.ShowCount;
    }

}