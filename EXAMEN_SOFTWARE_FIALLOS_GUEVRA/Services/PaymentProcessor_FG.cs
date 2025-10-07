using EXAMEN_SOFTWARE_FIALLOS_GUEVRA.Interfaces;
using EXAMEN_SOFTWARE_FIALLOS_GUEVRA.Models;

namespace EXAMEN_SOFTWARE_FIALLOS_GUEVRA.Services
{
    public class PaymentProcessor_FG
    {
        private readonly IPaymentMethod_FG[] _paymentMethods;
        private readonly INotificationChannel_FG[] _notificationChannels;

        public PaymentProcessor_FG(IPaymentMethod_FG[] paymentMethods, INotificationChannel_FG[] notificationChannels)
        {
            _paymentMethods = paymentMethods;
            _notificationChannels = notificationChannels;
        }

        public PaymentResult_FG ProcessPayment_FG(Payment_FG payment)
        {
            string summary = "";
            foreach (var method in _paymentMethods)
            {
                if (method.GetType().Name.StartsWith(payment._payMethodType))
                {
                    summary = method.ProcessPayment_FG(payment._amount, payment._user);
                    break;
                }
            }

            string[] sentNotifications = new string[_notificationChannels.Length];
            for (int i = 0; i < _notificationChannels.Length; i++)
            {
                sentNotifications[i] = _notificationChannels[i].SendNotification_FG($"Pago realizado: ${payment._amount}", payment._user);
            }

            return new PaymentResult_FG { _summary = summary, _sentNotifications = sentNotifications };
        }
    }
}
