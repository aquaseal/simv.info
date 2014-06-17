using simV.info.Views;
using Xamarin.Forms;

namespace simV.info
{
    public class App
    {
        public static Page GetMainPage()
        {
            var tabbedPage = new TabbedPage();
            tabbedPage.Children.Add(new ProjectsPage() { Title = "products" });
            tabbedPage.Children.Add(new MapPage() { Title = "map" });
            tabbedPage.Children.Add(new DirectoryPage() { Title = "directory" });
            return tabbedPage;
        }
    }
}