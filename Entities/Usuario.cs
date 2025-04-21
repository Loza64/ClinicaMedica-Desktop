using System;

namespace Entities
{
    public class Usuario
    {
        public long Id { set; get; }
        public byte[] Imagen { set; get; }
        public string Username { set; get; }
        public string NombreCompleto { set; get; }
        public DateTime Nacimiento { set; get; }
        public int Edad { set; get; }
        public string Dui { set; get; }
        public string Direccion { set; get; }
        public string Genero { set; get; }
        public string Telefono { set; get; }
        public string Email { set; get; }
        public string Password { set; get; }
        public bool EstadoUsuario { set; get; }
        public bool Confirmacion { set; get; }
        public Usuario() { }
    }
}
