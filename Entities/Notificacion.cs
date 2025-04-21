using System;

namespace Entities
{
    public class Notificacion
    {
        public long Id { get; set; }
        public long IdEmpleado { get; set; }
        public string Titulo { get; set; }
        public string DetalleNotificacion { get; set; }
        public DateTime FechaNotificacion { get; set; }
        public string Estado { get; set; }

        public Notificacion() { }
    }
}
