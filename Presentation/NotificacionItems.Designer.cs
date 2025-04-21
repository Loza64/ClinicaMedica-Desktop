namespace Presentation
{
    partial class NotificacionItems
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificacionItems));
            this.lbltitle = new System.Windows.Forms.Label();
            this.lblbody = new System.Windows.Forms.Label();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.CirclePicturebox = new Bunifu.UI.WinForms.BunifuPanel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.lbltiempo = new System.Windows.Forms.Label();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltitle.BackColor = System.Drawing.Color.Transparent;
            this.lbltitle.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbltitle.Location = new System.Drawing.Point(71, 3);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(495, 24);
            this.lbltitle.TabIndex = 28;
            this.lbltitle.Text = "Title";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblbody
            // 
            this.lblbody.AllowDrop = true;
            this.lblbody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblbody.BackColor = System.Drawing.Color.Transparent;
            this.lblbody.Font = new System.Drawing.Font("Arial Narrow", 11.1F, System.Drawing.FontStyle.Bold);
            this.lblbody.ForeColor = System.Drawing.Color.Gray;
            this.lblbody.Location = new System.Drawing.Point(75, 29);
            this.lblbody.Name = "lblbody";
            this.lblbody.Size = new System.Drawing.Size(491, 61);
            this.lblbody.TabIndex = 29;
            this.lblbody.Text = "Body";
            this.lblbody.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 35;
            this.bunifuPanel1.BorderThickness = 4;
            this.bunifuPanel1.Controls.Add(this.CirclePicturebox);
            this.bunifuPanel1.Controls.Add(this.iconPictureBox1);
            this.bunifuPanel1.Controls.Add(this.lbltitle);
            this.bunifuPanel1.Controls.Add(this.lbltiempo);
            this.bunifuPanel1.Controls.Add(this.lblbody);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(589, 117);
            this.bunifuPanel1.TabIndex = 1;
            // 
            // CirclePicturebox
            // 
            this.CirclePicturebox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CirclePicturebox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.CirclePicturebox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CirclePicturebox.BackgroundImage")));
            this.CirclePicturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CirclePicturebox.BorderColor = System.Drawing.Color.Transparent;
            this.CirclePicturebox.BorderRadius = 10;
            this.CirclePicturebox.BorderThickness = 1;
            this.CirclePicturebox.Location = new System.Drawing.Point(569, 52);
            this.CirclePicturebox.Name = "CirclePicturebox";
            this.CirclePicturebox.ShowBorders = true;
            this.CirclePicturebox.Size = new System.Drawing.Size(13, 13);
            this.CirclePicturebox.TabIndex = 35;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ClinicMedical;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.AppWorkspace;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 61;
            this.iconPictureBox1.Location = new System.Drawing.Point(9, 32);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(61, 61);
            this.iconPictureBox1.TabIndex = 34;
            this.iconPictureBox1.TabStop = false;
            // 
            // lbltiempo
            // 
            this.lbltiempo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltiempo.BackColor = System.Drawing.Color.Transparent;
            this.lbltiempo.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbltiempo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbltiempo.Location = new System.Drawing.Point(72, 92);
            this.lbltiempo.Name = "lbltiempo";
            this.lbltiempo.Size = new System.Drawing.Size(494, 18);
            this.lbltiempo.TabIndex = 33;
            this.lbltiempo.Text = "Time";
            this.lbltiempo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NotificacionItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.bunifuPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "NotificacionItems";
            this.Size = new System.Drawing.Size(589, 117);
            this.Load += new System.EventHandler(this.NotificacionItems_Load);
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        public System.Windows.Forms.Label lbltitle;
        public System.Windows.Forms.Label lblbody;
        public System.Windows.Forms.Label lbltiempo;
        private Bunifu.UI.WinForms.BunifuPanel CirclePicturebox;
    }
}
