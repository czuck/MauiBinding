using MauiTestApp.ContentViews;
using MauiTestApp.Models;

namespace MauiTestApp.Pages;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
        var menuModel = GetTestMenuModel();
        var i = 0;
        foreach (var item in menuModel.MenuList)
        {
            MenuGrid.Add(new Tile(item), i++, 1);
        }

    }

    public MenuModel GetTestMenuModel()
    {
        return new MenuModel
        {
            ShowImages = true,
            MenuList = new List<MobileMenu>
            {
                new MobileMenu
                {
                    Image = "dotnet_bot",
                    Title = "One Item",
                    ShowCount = true,
                    Count = 5,
                    Description = "This item has a count"
                },
                new MobileMenu
                {
                    Image = "dotnet_bot",
                    Title = "Different Item",
                    ShowCount = false,
                    Description = "This item doesn't have a count"
                },
                new MobileMenu
                {
                    Image = "dotnet_bot",
                    Title = "Another Item",
                    ShowCount = true,
                    Count = 3,
                    Description = "This item also has a count"
                }
            }
        };
    }

}