using EXAMEN_SOFTWARE_FIALLOS_GUEVRA.Interfaces;
using EXAMEN_SOFTWARE_FIALLOS_GUEVRA.Models;
using EXAMEN_SOFTWARE_FIALLOS_GUEVRA.Notifications;
using EXAMEN_SOFTWARE_FIALLOS_GUEVRA.PaymentMethods;
using EXAMEN_SOFTWARE_FIALLOS_GUEVRA.Services;

namespace EXAMEN_SOFTWARE_FIALLOS_GUEVRA
{
    //// SRP cada clase tiene una única responsabilidad
    /// OCP se pueden agregar nuevos métodos de pago o notificaciones sin modificar este código
    public class Program
    {
        static void Main(string[] args)

        {
            // Inyección de dependencias manual
            IPaymentMethod_FG[] paymentMethods = {
                new CardPayment_FG(),
                new CashPayment_FG(),
                new TransferPayment_FG()
            };

            INotificationChannel_FG[] notificationChannels = {
                new EmailNotification_FG(),
                new SMSNotification_FG(),
                new WhatsAppNotification_FG()
            };

            Payment_FG[] payments = {
                new Payment_FG { _user = "Josue", _amount = 100.50m, _payMethodType = "Card" },
                new Payment_FG { _user = "Marlon", _amount = 75.20m, _payMethodType = "Cash" },
                new Payment_FG { _user = "luis", _amount = 220.10m, _payMethodType = "Transfer" }
            };

            var processor = new PaymentProcessor_FG(paymentMethods, notificationChannels);
            IOutput_FG output = new ConsoleOutput_FG();

            foreach (var p in payments)
            {
                var result = processor.ProcessPayment_FG(p);
                output.ShowResult_FG(result);
            }

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();

        }
    }
}

    

