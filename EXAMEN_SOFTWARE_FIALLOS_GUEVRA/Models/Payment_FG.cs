using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_SOFTWARE_FIALLOS_GUEVRA.Models
{
    //SOLID SRP: RESPONSABILIDAD UNICA DE ALMACENAR DATOS CON UN PAGO 
    public class Payment_FG
    { 
         
        public string _user { get; set; }
        public decimal _amount { get; set; }
        public string _payMethodType { get; set; }
    }
}
