using System;

namespace Entities
{
    public class UserEmpleado
    {
        public long Id { set; get; }
        public byte[] Imagen { set; get; }
        public string Direccion { set; get; }
        public int Edad { set; get; }
        public string Email { set; get; }
        public DateTime Nacimiento { set; get; }
        public string NombreCompleto { set; get; }
        public string UserName { set; get; }
        public long Roll { set; get; }
        public string Dui { set; get; }
        public string Genero { set; get; }
        public string Telefono { set; get; }
        public long Area { set; get; }
        public string Password { set; get; }
        public bool Estado { set; get; }
        public UserEmpleado() { }
    }
}
