using Xamarin.Forms;

namespace XrnCourse.FormsHello
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var msgService = DependencyService.Get<IMessageService>();
            lblWelcome.Text = "Hello, " + msgService.GetWelcomeMessage();
        }

        private async void btnAlertPage_Clicked(object sender, System.EventArgs e)
        {
            //navigate to AlertPage
            await Navigation.PushAsync(new AlertPage());
        }

    }
}
