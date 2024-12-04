
namespace MauiTestApp.ContentViews;

public partial class Springboard : ContentView
{
    public MobileMenu MenuItem { get; set; }
    public MenuStyleViewModel SpringboardViewModel { get; set; }

    public Springboard(MobileMenu menuItem, MenuStyleViewModel springboardViewModel)
	{
        MenuItem = menuItem;
        SpringboardViewModel = springboardViewModel;
		InitializeComponent();

        if (menuItem.ImageType != MenuImageType.None)
        {
            var imageView = new ImageView(menuItem, springboardViewModel.ImageSize);
            if (menuItem.ImageType == MenuImageType.UrlIcon) imageView.Padding = new Thickness(0, 5, 0, 0);
            ItemLayout.Add(imageView, 0, 0);
        }

        ItemLayout.BackgroundColor = Colors.;
        if (string.IsNullOrEmpty(MenuItem.BackgroundColor) && SiteConfiguration.SpringboardBackgroundGradient != null &&
            !string.IsNullOrEmpty(SiteConfiguration.SpringboardBackgroundGradient.Name))
        {
            var lgb = new LinearGradientBrush
            {
                StartPoint = SiteConfiguration.SpringboardBackgroundGradient.Start,
                EndPoint = SiteConfiguration.SpringboardBackgroundGradient.End,
                GradientStops = new GradientStopCollection()
            };
            foreach (var color in SiteConfiguration.SpringboardBackgroundGradient.Colors)
            {
                lgb.GradientStops.Add(new GradientStop
                {
                    Color = color.Color,
                    Offset = color.Offset
                });
            }
            ItemLayout.Background = lgb;
        }

        TextLayout.IsVisible = !MenuItem.ImageOnly;
        CountBubble.Count = MenuItem.Count;
        CountBubble.IsVisible = MenuItem.ShowCount;
    }
}