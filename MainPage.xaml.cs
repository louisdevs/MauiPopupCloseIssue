using CommunityToolkit.Maui.Views;

namespace PopupCloseIssue
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var content = new ContentView() { BackgroundColor = Colors.Red, WidthRequest = 100, HeightRequest = 100 };
            content.Content = new Label() { Text = "popup" };
            var popup = new Popup() { CanBeDismissedByTappingOutsideOfPopup = true, Content = content };

            this.ShowPopup(popup);
        }
    }
}
