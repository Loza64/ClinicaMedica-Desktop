
namespace Presentation
{
    partial class Welcome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progreso = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblusuario);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.progreso);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(751, 448);
            this.panel2.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 10.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(17, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 22);
            this.label5.TabIndex = 53;
            this.label5.Text = "V 2.9.7";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Arial Black", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(788, 72);
            this.label1.TabIndex = 47;
            this.label1.Text = "Clínica Médica Dra. Alba Loza";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblusuario
            // 
            this.lblusuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblusuario.BackColor = System.Drawing.Color.Transparent;
            this.lblusuario.Font = new System.Drawing.Font("Arial Black", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.ForeColor = System.Drawing.Color.Black;
            this.lblusuario.Location = new System.Drawing.Point(-22, 144);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(791, 45);
            this.lblusuario.TabIndex = 46;
            this.lblusuario.Text = "lblusuario";
            this.lblusuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(-20, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(789, 47);
            this.label2.TabIndex = 45;
            this.label2.Text = "Bienvenido usuario";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // progreso
            // 
            this.progreso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.progreso.Animated = true;
            this.progreso.AnimationInterval = 1;
            this.progreso.AnimationSpeed = 1;
            this.progreso.BackColor = System.Drawing.Color.Transparent;
            this.progreso.CircleMargin = 9;
            this.progreso.Font = new System.Drawing.Font("Arial Black", 29F, System.Drawing.FontStyle.Bold);
            this.progreso.ForeColor = System.Drawing.Color.Black;
            this.progreso.IsPercentage = false;
            this.progreso.LineProgressThickness = 18;
            this.progreso.LineThickness = 17;
            this.progreso.Location = new System.Drawing.Point(259, 204);
            this.progreso.Name = "progreso";
            this.progreso.ProgressAnimationSpeed = 200;
            this.progreso.ProgressBackColor = System.Drawing.Color.Navy;
            this.progreso.ProgressColor = System.Drawing.Color.Aqua;
            this.progreso.ProgressColor2 = System.Drawing.Color.Navy;
            this.progreso.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.progreso.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Gradient;
            this.progreso.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.progreso.SecondaryFont = new System.Drawing.Font("Arial Black", 13F, System.Drawing.FontStyle.Bold);
            this.progreso.Size = new System.Drawing.Size(227, 227);
            this.progreso.SubScriptColor = System.Drawing.Color.Black;
            this.progreso.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.progreso.SubScriptText = "%";
            this.progreso.SuperScriptColor = System.Drawing.Color.Black;
            this.progreso.SuperScriptMargin = new System.Windows.Forms.Padding(0);
            this.progreso.SuperScriptText = "";
            this.progreso.TabIndex = 44;
            this.progreso.Text = "0";
            this.progreso.TextMargin = new System.Windows.Forms.Padding(0);
            this.progreso.ValueByTransition = 0;
            this.progreso.ValueMargin = new System.Windows.Forms.Padding(0);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(751, 448);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Welcome";
            this.Opacity = 0D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuCircleProgress progreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}