namespace Entities
{
    public class LaboratorioClinico
    {
        public long Id { set; get; }
        public long IdUserEmpleado { set; get; }
        public long IdUsuario { set; get; }
        public string Fecha { set; get; }
        public string Folio { set; get; }
        public string ListaDeExamanes { set; get; }
        public LaboratorioClinico() { }
    }
}
