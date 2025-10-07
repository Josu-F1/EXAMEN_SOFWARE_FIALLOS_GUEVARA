using EXAMEN_SOFTWARE_FIALLOS_GUEVRA.Interfaces;
using EXAMEN_SOFTWARE_FIALLOS_GUEVRA.Models;

namespace EXAMEN_SOFTWARE_FIALLOS_GUEVRA.Services
{
    // SRP: Solo se encarga de mostrar el resultado en consola
    public class ConsoleOutput_FG : IOutput_FG
    {
        public void ShowResult_FG(PaymentResult_FG result)
        {
            Console.WriteLine("******************************");
            Console.WriteLine(result._summary);
            Console.WriteLine("Notifications sent");
            for (int i = 0; i < result._sentNotifications.Length; i++)
            {
                Console.WriteLine(" - " + result._sentNotifications[i]);
            }
        }
    }
}
