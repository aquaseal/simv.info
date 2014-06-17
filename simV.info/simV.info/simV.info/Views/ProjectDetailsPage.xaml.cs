using simV.info.Models;
using Xamarin.Forms;

namespace simV.info.Views
{
    public partial class ProjectDetailsPage
    {
        public ProjectDetailsPage(Project project)
        {
            InitializeComponent();
            this.BindingContext = project;

            labelLink.GestureRecognizers.Add(new TapGestureRecognizer((args) =>
            {
                var label = args as Label;
                if (null == label)
                    return;

                Navigation.PushAsync(new WebViewPage() { BindingContext = label.Text });
            }));

        }
    }
}