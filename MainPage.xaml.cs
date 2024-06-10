using System.Collections.ObjectModel;

namespace Maui_IssueReleaseModeNotRendering
{
    public partial class MainPage : ContentPage
    {
        public ViewModelMainPage VmMainPage = new ViewModelMainPage();

        public MainPage()
        {
            InitializeComponent();

            BindingContext = VmMainPage;
        }
    }
}
