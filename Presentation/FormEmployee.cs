using FontAwesome.Sharp;
using Logic;
using MySql.Data.MySqlClient;
using Presentation.Cache;
using Presentation.Forms;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Presentation
{
    public partial class FormEmployee : Form
    {

        private IconButton currenbutton;
        private Panel leftborderpanel;
        private Form currentchildform = null;

        public FormEmployee()
        {
            InitializeComponent();
            leftborderpanel = new Panel();
            leftborderpanel.Size = new Size(8, 71);
            panelmenu.Controls.Add(leftborderpanel);
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        #region functions-menu
        private void activatemenu(object senderBTN, Color color)
        {
            if (senderBTN != null)
            {
                disablemenu();
                //button
                currenbutton = (IconButton)senderBTN;
                currenbutton.BackColor = Color.FromArgb(37, 36, 81);
                currenbutton.ForeColor = color;
                currenbutton.IconColor = color;
                currenbutton.TextAlign = ContentAlignment.MiddleCenter;
                currenbutton.ImageAlign = ContentAlignment.MiddleRight;
                currenbutton.TextImageRelation = TextImageRelation.TextBeforeImage;
                //Panelleft
                leftborderpanel.BackColor = color;
                leftborderpanel.Location = new Point(0, currenbutton.Location.Y);
                leftborderpanel.Visible = true;
                leftborderpanel.BringToFront();
                //childformiconchar
                IconCurremtChildForm.IconChar = currenbutton.IconChar;
                IconCurremtChildForm.IconColor = color;

            }
        }
        private void disablemenu()
        {
            if (currenbutton != null)
            {
                currenbutton.BackColor = Color.Transparent;
                currenbutton.ForeColor = Color.White;
                currenbutton.IconColor = Color.White;
                currenbutton.TextAlign = ContentAlignment.MiddleLeft;
                currenbutton.ImageAlign = ContentAlignment.MiddleLeft;
                currenbutton.TextImageRelation = TextImageRelation.ImageBeforeText;
                leftborderpanel.Visible = false;
                IconCurremtChildForm.IconChar = IconChar.Home;
                IconCurremtChildForm.IconColor = Color.White;
            }
        }

        public struct RGBCOLORS
        {
            public static Color color = Color.GreenYellow;
        }

        #endregion
        #region OpenForms_Childs
        private void OpenChildForm(Form childforms)
        {
            if (currentchildform != null)
            {
                currentchildform.Close();
            }
            currentchildform = childforms;
            childforms.TopLevel = false;
            childforms.FormBorderStyle = FormBorderStyle.None;
            childforms.Dock = DockStyle.Fill;
            PanelDesktop.Controls.Add(childforms);
            PanelDesktop.Tag = childforms;
            childforms.BringToFront();
            childforms.Show();
            Btnchild.Text = childforms.Text;
        }
        #endregion
        #region DLL
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        private void panel1_MouseMove_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void FormEmployee_Load(object sender, EventArgs e)
        {
            AppTime.Start();
        }
        private void LoadUserData()
        {
            try
            {
                username.Text = CacheSoftware.Employee.UserName;
                imgusuario.Image = Image.FromStream(new MemoryStream(CacheSoftware.Employee.Imagen));
                long count = LNNotificacion.GetInstance().CountNotificacion(CacheSoftware.Employee.Id);
                if (count > 0)
                {
                    btnnotificacion.IconFont = IconFont.Solid;
                    panelcount.Visible = true;
                    if (count < 10)
                    {
                        lblcountnotifiacion.Text = Convert.ToString(count);
                    }
                    else
                    {
                        lblcountnotifiacion.Text = "+9";
                    }
                }
                else
                {
                    btnnotificacion.IconFont = IconFont.Regular;
                    panelcount.Visible = false;
                }
            }
            catch (TimeoutException ex)
            {
                AppTime.Stop();
                DialogResult dr = MessageBox.Show("Información del error: " + ex.Message.ToString() + " ¿desea cerrar la aplicacion?", "Lo sentimos, ocurrio un error inesperado", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    MessageBox.Show("Si el error aun persiste por favor comuniquese con UFOSTART DEVELOPMENT lo mas breve posible");
                    Application.Exit();
                }
                else
                {
                    Application.Restart();
                }
            }
            catch (NullReferenceException ex)
            {
                AppTime.Stop();
                DialogResult dr = MessageBox.Show("Información del error: " + ex.Message.ToString() + " ¿desea cerrar la aplicacion?", "Lo sentimos, ocurrio un error inesperado", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    MessageBox.Show("Si el error aun persiste por favor comuniquese con UFOSTART DEVELOPMENT lo mas breve posible");
                    Application.Exit();
                }
                else
                {
                    Application.Restart();
                }
            }
            catch (MySqlException ex)
            {
                AppTime.Stop();
                DialogResult dr = MessageBox.Show("Información del error: " + ex.Message.ToString() + " ¿desea cerrar la aplicacion?", "Lo sentimos, ocurrio un error inesperado", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    MessageBox.Show("Si el error aun persiste por favor comuniquese con UFOSTART DEVELOPMENT lo mas breve posible");
                    Application.Exit();
                }
                else
                {
                    Application.Restart();
                }
            }
            catch (Exception ex)
            {
                AppTime.Stop();
                DialogResult dr = MessageBox.Show("Información del error: " + ex.Message.ToString() + " ¿desea cerrar la aplicacion?", "Lo sentimos, ocurrio un error inesperado", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    MessageBox.Show("Si el error aun persiste por favor comuniquese con UFOSTART DEVELOPMENT lo mas breve posible");
                    Application.Exit();
                }
                else
                {
                    Application.Restart();
                }
            }
        }
        public void CountsData()
        {
            try
            {
                #region CountsData
                txtnumpaciente.Text = LimitCount(LNUsuario.GetInstance().Countusers());
                txtnumcitas.Text = LimitCount(LNCita.GetInstance().CountDates());
                txtnumempleado.Text = LimitCount(LNUserEmpleado.GetInstance().CountEmployees());
                txtnumreceta.Text = LimitCount(LNRecetaMedica.GetInstance().CountRecetas());
                txtnumlabs.Text = LimitCount(LNLaboratorio.GetInstance().CountLabs());
                txtnumexpedientes.Text = LimitCount(LNExpediente.GetInstance().CountExpediente());
                #endregion
            }
            catch (TimeoutException ex)
            {
                AppTime.Stop();
                DialogResult dr = MessageBox.Show("Información del error: " + ex.Message.ToString() + " ¿desea cerrar la aplicacion?", "Lo sentimos, ocurrio un error inesperado", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    MessageBox.Show("Si el error aun persiste por favor comuniquese con UFOSTART DEVELOPMENT lo mas breve posible");
                    Application.Exit();
                }
                else
                {
                    Application.Restart();
                }
            }
            catch (NullReferenceException ex)
            {
                AppTime.Stop();
                DialogResult dr = MessageBox.Show("Información del error: " + ex.Message.ToString() + " ¿desea cerrar la aplicacion?", "Lo sentimos, ocurrio un error inesperado", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    MessageBox.Show("Si el error aun persiste por favor comuniquese con UFOSTART DEVELOPMENT lo mas breve posible");
                    Application.Exit();
                }
                else
                {
                    Application.Restart();
                }
            }
            catch (MySqlException ex)
            {
                AppTime.Stop();
                DialogResult dr = MessageBox.Show("Información del error: " + ex.Message.ToString() + " ¿desea cerrar la aplicacion?", "Lo sentimos, ocurrio un error inesperado", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    MessageBox.Show("Si el error aun persiste por favor comuniquese con UFOSTART DEVELOPMENT lo mas breve posible");
                    Application.Exit();
                }
                else
                {
                    Application.Restart();
                }
            }
            catch (Exception ex)
            {
                AppTime.Stop();
                DialogResult dr = MessageBox.Show("Información del error: " + ex.Message.ToString() + " ¿desea cerrar la aplicacion?", "Lo sentimos, ocurrio un error inesperado", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    MessageBox.Show("Si el error aun persiste por favor comuniquese con UFOSTART DEVELOPMENT lo mas breve posible");
                    Application.Exit();
                }
                else
                {
                    Application.Restart();
                }
            }
        }
        private string LimitCount(long number)
        {
            if (number < 1000)
            {
                return number.ToString();
            }
            else
            {
                return "+999";
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            PanelDesktop.BackColor = Color.FromArgb(0, 65, 109);
            activatemenu(sender, RGBCOLORS.color);
            OpenChildForm(new Expedientes());
        }

        private void referencias_Click(object sender, EventArgs e)
        {
            PanelDesktop.BackColor = Color.FromArgb(0, 65, 109);
            activatemenu(sender, RGBCOLORS.color);
            OpenChildForm(new Areas());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            PanelDesktop.BackColor = Color.FromArgb(0, 65, 109);
            activatemenu(sender, RGBCOLORS.color);
            OpenChildForm(new Citas());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            PanelDesktop.BackColor = Color.FromArgb(0, 65, 109);
            activatemenu(sender, RGBCOLORS.color);
            OpenChildForm(new Asistencias());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (LNArea.GetInstance().GetArea(CacheSoftware.Employee.Area) == "Laboratorio clínico")
            {
                PanelDesktop.BackColor = Color.FromArgb(0, 65, 109);
                activatemenu(sender, RGBCOLORS.color);
                OpenChildForm(new Laboratorios());
            }
            else
            {
                MessageBox.Show("Lo sentimos pero esta información es confidencial y solo los del área de laboratorio clínico tienen derecho a acceder a esta sección", "Acceso denegao", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            PanelDesktop.BackColor = Color.FromArgb(0, 65, 109);
            activatemenu(sender, RGBCOLORS.color);
            OpenChildForm(new RecetasMedicas());
        }

        private void btnacces_Click_1(object sender, EventArgs e)
        {
            panelacces.BringToFront();
            if (panelacces.Visible == false)
            {
                panelacces.Visible = true;
            }
            else
            {
                panelacces.Visible = false;
            }
        }

        private void btnnotificaciones_Click(object sender, EventArgs e)
        {
            Notificaciones notificaciones = new Notificaciones();
            long count = LNNotificacion.GetInstance().CountNotificacion(CacheSoftware.Employee.Id);
            if (count > 0)
            {
                btnnotificacion.IconFont = IconFont.Solid;
                panelcount.Visible = true;
                if (count < 10)
                {
                    lblcountnotifiacion.Text = Convert.ToString(count);
                }
                else
                {
                    lblcountnotifiacion.Text = "+9";
                }
            }
            else
            {
                btnnotificacion.IconFont = IconFont.Regular;
                panelcount.Visible = false;
            }
            notificaciones.ShowDialog();
        }

        private void AppTime_Tick(object sender, EventArgs e)
        {
            LoadUserData();
            CountsData();
        }

        private void btnperfil_Click(object sender, EventArgs e)
        {
            PanelDesktop.BackColor = Color.FromArgb(0, 65, 109);
            OpenChildForm(new MiPerfil());
            IconCurremtChildForm.IconChar = IconChar.UserAlt;
            IconCurremtChildForm.IconColor = Color.GreenYellow;
            if (panelacces.Visible == true) panelacces.Visible = false;
        }

        private void btnaboutus_Click(object sender, EventArgs e)
        {
            PanelDesktop.BackColor = Color.FromArgb(0, 65, 109);
            if (panelacces.Visible == true) panelacces.Visible = false;
            AboutUs aboutUs = new AboutUs();
            aboutUs.ShowDialog();
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Estas seguro de que quieres cerrar sesión?", "Clínica Médica", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                Application.Restart();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnHome1_Click(object sender, EventArgs e)
        {
            PanelDesktop.BackColor = Color.WhiteSmoke;
            disablemenu();
            Btnchild.Text = "Area principal";
            try
            {
                currentchildform.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Usted ya se encuentra en el área principal.");
            }
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            PanelDesktop.BackColor = Color.WhiteSmoke;
            disablemenu();
            Btnchild.Text = "Area principal";
            try
            {
                currentchildform.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Usted ya se encuentra en el área principal.");
            }
        }
    }
}

