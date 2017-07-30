//ensures the PCL has access to this class. Must be defined outside of the namespace
[assembly: Xamarin.Forms.Dependency(typeof(XrnCourse.FormsHello.Droid.Services.MessageServiceDroid))]

namespace XrnCourse.FormsHello.Droid.Services
{

    public class MessageServiceDroid : IMessageService
    {
        public string GetWelcomeMessage()
        {
            return "Android!";
        }
    }
}