namespace EXAMEN_SOFTWARE_FIALLOS_GUEVRA.Models
{ 
    public class PaymentResult_FG
    {
        //SOLID SRP: RESPONSABLIDAD UNICA DE ALMANCENAR EL RESUKTADI DEL PAGO
        public string _summary { get; set; }
        public string[] _sentNotifications { get; set; }
    }
}
