namespace Entities
{
    public class DetallePago
    {
        public int Nº { get; set; }
        public long IdPago { get; set; }
        public string Detalle { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
        public double SubTotal { get; set; }
        public double PagoTotal { get; set; }
        public DetallePago() { }
    }
}
