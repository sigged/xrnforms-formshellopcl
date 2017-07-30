//ensures the PCL has access to this class. Must be defined outside of the namespace
[assembly: Xamarin.Forms.Dependency(typeof(XrnCourse.FormsHello.UWP.Services.MessageServiceUwp))]

namespace XrnCourse.FormsHello.UWP.Services
{
    public class MessageServiceUwp : IMessageService
    {
        public string GetWelcomeMessage()
        {
            return "UWP!";
        }
    }
}
