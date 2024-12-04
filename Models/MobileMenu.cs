namespace MauiTestApp.Models
{
    public class MenuModel
    {
        public bool ShowImages { get; set; }
        public IList<MobileMenu> MenuList { get; set; }

    }

    public class Menu
    {
        public bool IsLoggedOn { get; set; }
        public IEnumerable<MobileMenu> MenuItems { get; set; }
    }

    public class MobileMenu
    {
        public string Image { get; set; }
        public string Title { get; set; }
        public bool ShowCount { get; set; }
        public int Count { get; set; }
        public string sCount
        {
            get { return Count.ToString(); }
        }
        public string Description { get; set; }
    }


}