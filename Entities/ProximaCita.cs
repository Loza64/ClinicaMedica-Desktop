using System;

namespace Entities
{
    public class ProximaCita
    {
        public long Idempleado { set; get; }
        public long IdUsuario { set; get; }
        public long Idcita { set; get; }
        public DateTime Proximacita { set; get; }
        public DateTime hora { set; get; }
        public ProximaCita() { }
    }
}
