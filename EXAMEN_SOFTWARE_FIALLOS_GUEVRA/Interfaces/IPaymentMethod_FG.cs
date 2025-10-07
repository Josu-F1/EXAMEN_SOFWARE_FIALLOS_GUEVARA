using System.Globalization;

namespace EXAMEN_SOFTWARE_FIALLOS_GUEVRA.Interfaces
{
    public interface IPaymentMethod_FG
    {
       string ProcessPayment_FG(decimal amount, string user);
    }
}
