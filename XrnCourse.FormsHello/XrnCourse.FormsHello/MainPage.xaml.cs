using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XrnCourse.FormsHello
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Application.Current.ModalPopped += modalPopped;

            var msgService = DependencyService.Get<IMessageService>();
            lblWelcome.Text = "Hello, " + msgService.GetWelcomeMessage();
        }

        private async void btnAlertPage_Clicked(object sender, System.EventArgs e)
        {
            //navigate to AlertPage
            await Navigation.PushAsync(new AlertPage());
        }

        private async void btnActionSheet_Clicked(object sender, System.EventArgs e)
        {
            string action = await DisplayActionSheet("ActionSheet: What to do?", 
                "Cancel", null, "Show me the time", "Tell a joke", "Wait 3 seconds");

            if (action == "Show me the time")
                await DisplayAlert("Time",
                        $"It's now {DateTime.Now.ToString("HH:mm")},Almost beer-o-clock!", 
                        "OK");
            else if (action == "Tell a joke")
                await DisplayAlert("Joke", 
                        $"Why is six afraid of seven?{Environment.NewLine}Because seven ate nine.", 
                        "LOL", "I don't get it");
            else if (action == "Wait 3 seconds")
            {
                await Task.Delay(3000);
                await DisplayAlert("Wait 3 seconds", "The wait is over.", "Ok");
            }
        }

        private async void btnShowModal_Clicked(object sender, EventArgs e)
        {
            //display ModalPage
            var modalPage = new ModalPage();
            await Navigation.PushModalAsync(modalPage, true);
        }

        private async void modalPopped(object sender, ModalPoppedEventArgs e)
        {
            if (e.Modal is ModalPage)
                await DisplayAlert("Modal Result", 
                    $"You entered {(e.Modal as ModalPage).NameEntered}",  "I know!");
        }

        private async void btnRandomNumber_Clicked(object sender, EventArgs e)
        {
            //navigate to RandomNumberPage
            await Navigation.PushAsync(new RandomNumberPage());
        }
    }
}
