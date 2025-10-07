using EXAMEN_SOFTWARE_FIALLOS_GUEVRA.Interfaces;

namespace EXAMEN_SOFTWARE_FIALLOS_GUEVRA.Notifications
{
    internal class SMSNotification_FG : INotificationChannel_FG
    {
        public string SendNotification_FG(string message, string user)
        {
            return $"SMS notification to {user}: {message}";
        }
    }
}
