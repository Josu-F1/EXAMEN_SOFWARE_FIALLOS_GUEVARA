using EXAMEN_SOFTWARE_FIALLOS_GUEVRA.Interfaces;

namespace EXAMEN_SOFTWARE_FIALLOS_GUEVRA.PaymentMethods
{
    internal class TransferPayment_FG : IPaymentMethod_FG
    {
        public string ProcessPayment_FG(decimal amount, string user)
        {
            return $"Transfer payment of {amount:C} for user {user} processed successfully.";
        }
    }
}
