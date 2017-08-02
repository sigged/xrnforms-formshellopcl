using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XrnCourse.FormsHello
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //wrap the MainPage in a NavigationPage
            MainPage = new NavigationPage(new MainPage());
        }
        
        protected override void OnStart()
        {
            Debug.WriteLine($"{DateTime.Now} - App meets world");
        }

        protected override void OnSleep()
        {
            Debug.WriteLine($"{DateTime.Now} - ZzzZzz");
        }

        protected override void OnResume()
        {
            Debug.WriteLine($"{DateTime.Now} - Wake up and smell the coffee");
        }
    }
}
