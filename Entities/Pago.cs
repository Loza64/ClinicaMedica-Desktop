using System;

namespace Entities
{
    public class Pago
    {
        public long Id { set; get; }
        public long IdCita { set; get; }
        public long IdUsuario { set; get; }
        public double SubTotal { set; get; }
        public double PagoTotal { set; get; }
        public DateTime FechaPago { set; get; }
        public Pago() { }

    }
}
