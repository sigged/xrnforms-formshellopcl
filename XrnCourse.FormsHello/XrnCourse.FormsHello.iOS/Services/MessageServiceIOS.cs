//ensures the PCL has access to this class. Must be defined outside of the namespace
[assembly: Xamarin.Forms.Dependency(typeof(XrnCourse.FormsHello.iOS.Services.MessageServiceIOS))]

namespace XrnCourse.FormsHello.iOS.Services
{
    
    public class MessageServiceIOS : IMessageService
    {
        public string GetWelcomeMessage()
        {
            return "IOS!";
        }
    }
}