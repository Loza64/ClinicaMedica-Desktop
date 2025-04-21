namespace Entities
{
    public class Expediente
    {
        public long Id { set; get; }
        public long IdCita { set; get; }
        public long IdUserEmpleado { set; get; }
        public string Diagnostico { set; get; }
        public string Tratamiento { set; get; }
        public string Antecedentes { set; get; }
        public string FechaExpediente { set; get; }
        public Expediente() { }
    }
}
