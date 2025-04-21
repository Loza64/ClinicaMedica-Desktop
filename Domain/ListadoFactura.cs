namespace Domain
{
    public class ListadoFactura
    {
        public int Nº { get; set; }
        public string Detalle { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
        public double SubTotal { get; set; }
        public double PagoTotal { get; set; }
        public ListadoFactura() { }
    }
}
