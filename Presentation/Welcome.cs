using Presentation.Cache;
using System;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            Application.EnableVisualStyles();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            progreso.Value = 0;
            lblusuario.Text = CacheSoftware.Employee.UserName;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.07;
            progreso.Value += 1;
            if (progreso.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Opacity -= 0.2;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                switch (CacheSoftware.Employee.Roll)
                {
                    case 1:
                        FormAdmin admin = new FormAdmin(); admin.Show(); this.Close();
                        break;

                    case 2:
                        FormEmployee employe = new FormEmployee(); employe.Show(); this.Close();
                        break;

                    case 3:
                        FormSecretary secretary = new FormSecretary(); secretary.Show(); this.Close();
                        break;

                    default:
                        MessageBox.Show("Lo sentimos el área en el que usted esta registrado no está disponible para esta versión, por faor procure" +
                            " que su aplicación este actualizado en la version mas reciente.", "Version antigua", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        break;
                }
            }
        }
    }
}
