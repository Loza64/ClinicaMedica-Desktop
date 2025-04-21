using System;

namespace Entities
{
    public class RecetaMedica
    {
        public long Id { set; get; }
        public long IdUserEmpleado { set; get; }
        public long IdUsuario { set; get; }
        public long Idcita { set; get; }
        public string DomicilioPaciente { set; get; }
        public string Empleado { set; get; }
        public string Diagnostico { set; get; }
        public string NombreComercialMedicina { set; get; }
        public string NombreMedicamento { set; get; }
        public string Cantidad { set; get; }
        public string Dosis { set; get; }
        public string ViaConsumo { set; get; }
        public DateTime FechaRecetada { set; get; }
        public RecetaMedica() { }
    }
}
