using EXAMEN_SOFTWARE_FIALLOS_GUEVRA.Interfaces;

namespace EXAMEN_SOFTWARE_FIALLOS_GUEVRA.Notifications
{
    public class WhatsAppNotification_FG : INotificationChannel_FG
    {
        public string SendNotification_FG(string message, string user)
        {
            return $"WhatsApp notification to {user}: {message}";
        }
    }
}
