using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XrnCourse.FormsHello
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlertPage : ContentPage
    {
        public AlertPage()
        {
            InitializeComponent();
        }

        private async void btnPopupHello_Clicked(object sender, System.EventArgs e)
        {
            await DisplayAlert("Alert", "Hello there!", "Hi!");
        }

        private async void btnGoBack_Clicked(object sender, System.EventArgs e)
        {
            if(await DisplayAlert("Goin' back", "Wanna go back?", "Yep", "No, wait!"))
                await Navigation.PopAsync(true);
        }
    }
}