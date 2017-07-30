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
    }
}
