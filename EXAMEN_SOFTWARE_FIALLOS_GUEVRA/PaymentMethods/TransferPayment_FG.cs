using EXAMEN_SOFTWARE_FIALLOS_GUEVRA.Interfaces;

namespace EXAMEN_SOFTWARE_FIALLOS_GUEVRA.PaymentMethods
{

    // SRP: Esta clase se encarga solo de procesar pagos con transferencia
    // OCP: Podemos agregar más métodos de pago sin modificar esta clase, solo extendiendo la interfaz.
    // LSP: Las clases derivadas pueden sustituir a sus clases padre
    internal class TransferPayment_FG : IPaymentMethod_FG
    {
        public string ProcessPayment_FG(decimal amount, string user)
        {
            return $"Transfer payment of {amount} for user {user} processed successfully.";
        }
    }
}
