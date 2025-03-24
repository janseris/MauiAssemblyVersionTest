using Shared;

namespace VersionTestMaui
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            assemblyInfoLabel.Text = "Assembly: " + AsssemblyVersionHelper.GetApplicationProcessAssembly().ToString();
            versionLabel.Text = "Version: " + AsssemblyVersionHelper.GetApplicationProcessVersion().ToString();
        }
    }
}