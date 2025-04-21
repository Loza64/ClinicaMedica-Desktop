using System;

namespace Entities
{
    public class Cita
    {
        public string email { set; get; }
        public string usuario { set; get; }
        public long id_usuario { set; get; }
        public string nombrepaciente { set; get; }
        public string parentesco { set; get; }
        public string padecimento { set; get; }
        public string alergias { set; get; }
        public string enfermedad_sintomas { set; get; }
        public DateTime fecha_reservación { set; get; }
        public DateTime hora { set; get; }
        public long id_cita { set; get; }
        public string Estado { set; get; }
        public Cita() { }

    }
}
