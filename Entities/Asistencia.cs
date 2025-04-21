using System;

namespace Entities
{
    public class Asistencia
    {
        public long Id { set; get; }
        public long IdCita { set; get; }
        public long IdEmpleado { set; get; }
        public string MotivoCita { set; get; }
        public DateTime FechaAsistencia { set; get; }
        public Asistencia() { }
    }
}

