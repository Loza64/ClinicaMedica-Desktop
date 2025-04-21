using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Presentation
{
    public partial class NotificacionItems : UserControl
    {
        public NotificacionItems()
        {
            InitializeComponent();
        }

        private string Titulo;
        private string Detalle;
        private DateTime Fecha;
        private string estado;

        [Category("Custom Props")]
        public string GetTitulo
        {
            get { return Titulo; }
            set { Titulo = value; }
        }

        [Category("Custom Props")]
        public string GetDetalle
        {
            get { return Detalle; }
            set { Detalle = value; }
        }

        [Category("Custom Props")]
        public DateTime GetFecha
        {
            get { return Fecha; }
            set { Fecha = value; }
        }

        [Category("Custom Props")]
        public string GetEstado
        {
            get { return estado; }
            set { estado = value; }
        }

        private void NotificacionItems_Load(object sender, EventArgs e)
        {
            lbltitle.Text = GetTitulo;
            lblbody.Text = GetDetalle;
            estado = GetEstado;
            Fecha = GetFecha;

            if (estado == "Leido")
            {
                CirclePicturebox.Visible = false;
            }

            if (estado == "No leido")
            {
                CirclePicturebox.Visible = true;
            }

            TimeSpan diferencia = DateTime.Now - Fecha;

            if (diferencia.TotalSeconds <= 60)
            {
                if ((int)diferencia.TotalSeconds == 1)
                {
                    lbltiempo.Text = "hace " + (int)diferencia.TotalSeconds + " segundo";
                }
                else
                {
                    lbltiempo.Text = "hace " + (int)diferencia.TotalSeconds + " segundos";
                }
            }
            else if (diferencia.TotalMinutes <= 60)
            {
                if ((int)diferencia.TotalMinutes == 1)
                {
                    lbltiempo.Text = "hace aproximadamente " + (int)diferencia.TotalMinutes + " minuto";

                }
                else
                {
                    lbltiempo.Text = "hace " + (int)diferencia.TotalMinutes + " minutos";
                }
            }
            else if (diferencia.TotalHours <= 24)
            {
                if ((int)diferencia.TotalHours == 1)
                {
                    lbltiempo.Text = "hace aproximadamente " + (int)diferencia.TotalHours + " hora";
                }
                else
                {
                    lbltiempo.Text = "hace " + (int)diferencia.TotalHours + " horas";
                }
            }
            else
            {
                if ((int)diferencia.TotalDays == 1)
                {
                    lbltiempo.Text = "hace aproximadamente " + (int)diferencia.Days + " dia";
                }
                else
                {
                    lbltiempo.Text = "hace " + (int)diferencia.Days + " dias";
                }
            }


        }
    }
}
