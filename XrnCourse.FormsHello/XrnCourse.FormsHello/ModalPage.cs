using System;
using Xamarin.Forms;

namespace XrnCourse.FormsHello
{
    public class ModalPage : ContentPage
    {
        public string NameEntered { get; set; }
        private Entry txtName = new Entry();

        public ModalPage()
        {
            //create the UI programmatically

            Button btnClose = new Button{
                Text = "Submit"
            };
            btnClose.Clicked += btnClose_Clicked;

            StackLayout layout = new StackLayout
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Children = {
                    new Label { Text = "Enter your name:" },
                    txtName,
                    btnClose
                }
            };
            Content = layout;
        }

        private async void btnClose_Clicked(object sender, EventArgs e)
        {
            NameEntered = txtName.Text; //fill property with user input
            await Navigation.PopModalAsync(true); //close modal
        }

        protected override bool OnBackButtonPressed()
        {
            return true; //don't allow back button when this window is opened
        }
    }
}