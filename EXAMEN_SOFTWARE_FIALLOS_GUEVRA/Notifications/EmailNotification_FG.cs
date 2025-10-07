using EXAMEN_SOFTWARE_FIALLOS_GUEVRA.Interfaces;

namespace EXAMEN_SOFTWARE_FIALLOS_GUEVRA.Notifications
{
    public class EmailNotification_FG : INotificationChannel_FG
    {
        //SRP:IMPLEMENTA LA INTERFAZ Y LE DA EL COMPTARMIENTO DEL METODO COMO NOTIFICACION DE EMAIL
        // LSP: Las clases derivadas pueden sustituir a sus clases padre
        public string SendNotification_FG(string message, string user)
        {
            return $"Email notification to {user}: {message}";
        }
    }
}
