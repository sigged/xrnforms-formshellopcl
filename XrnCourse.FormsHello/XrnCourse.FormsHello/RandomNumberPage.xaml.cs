using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XrnCourse.FormsHello
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RandomNumberPage : ContentPage
    {
        Random rnd = new Random();
        bool pageVisible = false;
        int total = 0;

        public RandomNumberPage()
        {
            InitializeComponent();

            if (Application.Current.Properties.ContainsKey("RandomNumberPage_Total"))
                total = (int) Application.Current.Properties["RandomNumberPage_Total"];
            lblTotal.Text = total.ToString("N0");
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();
            pageVisible = true;
            Device.StartTimer(TimeSpan.FromMilliseconds(1000), GenerateNumber);
        }

        protected override void OnDisappearing()
        {
            pageVisible = false;
            base.OnDisappearing();
        }

        private void btnClearTotal_Clicked(object sender, EventArgs e)
        {
            Application.Current.Properties["RandomNumberPage_Total"] = null;
            Application.Current.SavePropertiesAsync();
            total = 0;
            lblTotal.Text = "-";
        }

        private bool GenerateNumber()
        {
            int number = rnd.Next(100);
            Debug.WriteLine($"Last Random Number: {number}");
            total += number;

            Application.Current.Properties["RandomNumberPage_Total"] = total;
            Application.Current.SavePropertiesAsync();

            lblTotal.Text = total.ToString("N0");
            lblNumber.Text = number.ToString();
            return pageVisible; //true = repeat
        }
    }
}