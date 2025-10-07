using EXAMEN_SOFTWARE_FIALLOS_GUEVRA.Interfaces;

namespace EXAMEN_SOFTWARE_FIALLOS_GUEVRA.PaymentMethods
{
    public class CardPayment_FG : IPaymentMethod_FG
    {
        public string ProcessPayment_FG(decimal amount, string user)
        {
            
            return $"Card payment of {amount:C} for user {user} processed successfully.";
        }
    }
}
