using MauiTestApp.Models;

namespace MauiTestApp.ContentViews;

public class ImageView : ContentView
{
	public ImageView(MobileMenu menuItem, int height)
    {
                Content = new Image
                {
                    Source = menuItem.Image,
                    // Springboards will show the image in the size to fit the area.
                    Aspect = Aspect.AspectFill,
                };
        AutomationProperties.SetIsInAccessibleTree(Content, false);
    }
}