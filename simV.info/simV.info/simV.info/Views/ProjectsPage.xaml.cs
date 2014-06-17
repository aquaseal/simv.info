using simV.info.Models;
using simV.info.ViewModels;
using Xamarin.Forms;

namespace simV.info.Views
{
    public partial class ProjectsPage
    {
        public ProjectsPage()
        {
            InitializeComponent();
            this.BindingContext = new ProjectsViewModel();
        }

        public void OnItemSelected(object sender, ItemTappedEventArgs args)
        {
            var project = args.Item as Project;
            if (null == project)
                return;

            Navigation.PushAsync(new ProjectDetailsPage(project));
            listViewProjects.SelectedItem = null;
        }

    }
}