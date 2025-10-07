using EXAMEN_SOFTWARE_FIALLOS_GUEVRA.Interfaces;

namespace EXAMEN_SOFTWARE_FIALLOS_GUEVRA.PaymentMethods
{
    public class CashPayment_FG : IPaymentMethod_FG
    {
        public string ProcessPayment_FG(decimal amount, string user)
        {
          
            return $"Cash payment of {amount:C} for user {user} processed successfully.";
        }
    }
}
