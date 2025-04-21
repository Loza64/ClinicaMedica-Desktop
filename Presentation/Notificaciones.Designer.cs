namespace Presentation
{
    partial class Notificaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notificaciones));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuPanel8 = new Bunifu.UI.WinForms.BunifuPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnNoLeidas = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.notifiacionesleidas = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.NotificationsPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.bunifuPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(0, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(670, 87);
            this.label2.TabIndex = 1;
            this.label2.Text = "No hay notificaciones.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.bunifuPanel8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnNoLeidas);
            this.panel1.Controls.Add(this.notifiacionesleidas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 100);
            this.panel1.TabIndex = 106;
            // 
            // bunifuPanel8
            // 
            this.bunifuPanel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPanel8.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.bunifuPanel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel8.BackgroundImage")));
            this.bunifuPanel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel8.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel8.BorderRadius = 30;
            this.bunifuPanel8.BorderThickness = 1;
            this.bunifuPanel8.Controls.Add(this.button2);
            this.bunifuPanel8.Location = new System.Drawing.Point(575, -14);
            this.bunifuPanel8.Name = "bunifuPanel8";
            this.bunifuPanel8.ShowBorders = true;
            this.bunifuPanel8.Size = new System.Drawing.Size(59, 51);
            this.bunifuPanel8.TabIndex = 105;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Black", 10.75F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(6, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 30);
            this.button2.TabIndex = 11;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(616, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Notificaciones";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnNoLeidas
            // 
            this.BtnNoLeidas.AllowAnimations = true;
            this.BtnNoLeidas.AllowMouseEffects = true;
            this.BtnNoLeidas.AllowToggling = false;
            this.BtnNoLeidas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnNoLeidas.AnimationSpeed = 200;
            this.BtnNoLeidas.AutoGenerateColors = false;
            this.BtnNoLeidas.AutoRoundBorders = false;
            this.BtnNoLeidas.AutoSizeLeftIcon = true;
            this.BtnNoLeidas.AutoSizeRightIcon = true;
            this.BtnNoLeidas.BackColor = System.Drawing.Color.Transparent;
            this.BtnNoLeidas.BackColor1 = System.Drawing.Color.Navy;
            this.BtnNoLeidas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnNoLeidas.BackgroundImage")));
            this.BtnNoLeidas.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnNoLeidas.ButtonText = "No leidas";
            this.BtnNoLeidas.ButtonTextMarginLeft = 0;
            this.BtnNoLeidas.ColorContrastOnClick = 45;
            this.BtnNoLeidas.ColorContrastOnHover = 45;
            this.BtnNoLeidas.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.BtnNoLeidas.CustomizableEdges = borderEdges1;
            this.BtnNoLeidas.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnNoLeidas.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnNoLeidas.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnNoLeidas.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnNoLeidas.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.BtnNoLeidas.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNoLeidas.ForeColor = System.Drawing.Color.White;
            this.BtnNoLeidas.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNoLeidas.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BtnNoLeidas.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BtnNoLeidas.IconMarginLeft = 11;
            this.BtnNoLeidas.IconPadding = 10;
            this.BtnNoLeidas.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNoLeidas.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BtnNoLeidas.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtnNoLeidas.IconSize = 25;
            this.BtnNoLeidas.IdleBorderColor = System.Drawing.Color.White;
            this.BtnNoLeidas.IdleBorderRadius = 30;
            this.BtnNoLeidas.IdleBorderThickness = 3;
            this.BtnNoLeidas.IdleFillColor = System.Drawing.Color.Navy;
            this.BtnNoLeidas.IdleIconLeftImage = null;
            this.BtnNoLeidas.IdleIconRightImage = null;
            this.BtnNoLeidas.IndicateFocus = false;
            this.BtnNoLeidas.Location = new System.Drawing.Point(329, 51);
            this.BtnNoLeidas.Name = "BtnNoLeidas";
            this.BtnNoLeidas.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnNoLeidas.OnDisabledState.BorderRadius = 30;
            this.BtnNoLeidas.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnNoLeidas.OnDisabledState.BorderThickness = 3;
            this.BtnNoLeidas.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnNoLeidas.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnNoLeidas.OnDisabledState.IconLeftImage = null;
            this.BtnNoLeidas.OnDisabledState.IconRightImage = null;
            this.BtnNoLeidas.onHoverState.BorderColor = System.Drawing.Color.White;
            this.BtnNoLeidas.onHoverState.BorderRadius = 30;
            this.BtnNoLeidas.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnNoLeidas.onHoverState.BorderThickness = 3;
            this.BtnNoLeidas.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnNoLeidas.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BtnNoLeidas.onHoverState.IconLeftImage = null;
            this.BtnNoLeidas.onHoverState.IconRightImage = null;
            this.BtnNoLeidas.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.BtnNoLeidas.OnIdleState.BorderRadius = 30;
            this.BtnNoLeidas.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnNoLeidas.OnIdleState.BorderThickness = 3;
            this.BtnNoLeidas.OnIdleState.FillColor = System.Drawing.Color.Navy;
            this.BtnNoLeidas.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BtnNoLeidas.OnIdleState.IconLeftImage = null;
            this.BtnNoLeidas.OnIdleState.IconRightImage = null;
            this.BtnNoLeidas.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.BtnNoLeidas.OnPressedState.BorderRadius = 30;
            this.BtnNoLeidas.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnNoLeidas.OnPressedState.BorderThickness = 3;
            this.BtnNoLeidas.OnPressedState.FillColor = System.Drawing.Color.Navy;
            this.BtnNoLeidas.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BtnNoLeidas.OnPressedState.IconLeftImage = null;
            this.BtnNoLeidas.OnPressedState.IconRightImage = null;
            this.BtnNoLeidas.Size = new System.Drawing.Size(261, 40);
            this.BtnNoLeidas.TabIndex = 1;
            this.BtnNoLeidas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnNoLeidas.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnNoLeidas.TextMarginLeft = 0;
            this.BtnNoLeidas.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtnNoLeidas.UseDefaultRadiusAndThickness = true;
            this.BtnNoLeidas.Click += new System.EventHandler(this.BtnNoLeidas_Click);
            // 
            // notifiacionesleidas
            // 
            this.notifiacionesleidas.AllowAnimations = true;
            this.notifiacionesleidas.AllowMouseEffects = true;
            this.notifiacionesleidas.AllowToggling = false;
            this.notifiacionesleidas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.notifiacionesleidas.AnimationSpeed = 200;
            this.notifiacionesleidas.AutoGenerateColors = false;
            this.notifiacionesleidas.AutoRoundBorders = false;
            this.notifiacionesleidas.AutoSizeLeftIcon = true;
            this.notifiacionesleidas.AutoSizeRightIcon = true;
            this.notifiacionesleidas.BackColor = System.Drawing.Color.Transparent;
            this.notifiacionesleidas.BackColor1 = System.Drawing.Color.Navy;
            this.notifiacionesleidas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("notifiacionesleidas.BackgroundImage")));
            this.notifiacionesleidas.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.notifiacionesleidas.ButtonText = "Todas";
            this.notifiacionesleidas.ButtonTextMarginLeft = 0;
            this.notifiacionesleidas.ColorContrastOnClick = 45;
            this.notifiacionesleidas.ColorContrastOnHover = 45;
            this.notifiacionesleidas.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.notifiacionesleidas.CustomizableEdges = borderEdges2;
            this.notifiacionesleidas.DialogResult = System.Windows.Forms.DialogResult.None;
            this.notifiacionesleidas.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.notifiacionesleidas.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.notifiacionesleidas.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.notifiacionesleidas.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.notifiacionesleidas.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notifiacionesleidas.ForeColor = System.Drawing.Color.White;
            this.notifiacionesleidas.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.notifiacionesleidas.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.notifiacionesleidas.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.notifiacionesleidas.IconMarginLeft = 11;
            this.notifiacionesleidas.IconPadding = 10;
            this.notifiacionesleidas.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.notifiacionesleidas.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.notifiacionesleidas.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.notifiacionesleidas.IconSize = 25;
            this.notifiacionesleidas.IdleBorderColor = System.Drawing.Color.White;
            this.notifiacionesleidas.IdleBorderRadius = 30;
            this.notifiacionesleidas.IdleBorderThickness = 3;
            this.notifiacionesleidas.IdleFillColor = System.Drawing.Color.Navy;
            this.notifiacionesleidas.IdleIconLeftImage = null;
            this.notifiacionesleidas.IdleIconRightImage = null;
            this.notifiacionesleidas.IndicateFocus = false;
            this.notifiacionesleidas.Location = new System.Drawing.Point(39, 51);
            this.notifiacionesleidas.Name = "notifiacionesleidas";
            this.notifiacionesleidas.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.notifiacionesleidas.OnDisabledState.BorderRadius = 30;
            this.notifiacionesleidas.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.notifiacionesleidas.OnDisabledState.BorderThickness = 3;
            this.notifiacionesleidas.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.notifiacionesleidas.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.notifiacionesleidas.OnDisabledState.IconLeftImage = null;
            this.notifiacionesleidas.OnDisabledState.IconRightImage = null;
            this.notifiacionesleidas.onHoverState.BorderColor = System.Drawing.Color.White;
            this.notifiacionesleidas.onHoverState.BorderRadius = 30;
            this.notifiacionesleidas.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.notifiacionesleidas.onHoverState.BorderThickness = 3;
            this.notifiacionesleidas.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.notifiacionesleidas.onHoverState.ForeColor = System.Drawing.Color.White;
            this.notifiacionesleidas.onHoverState.IconLeftImage = null;
            this.notifiacionesleidas.onHoverState.IconRightImage = null;
            this.notifiacionesleidas.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.notifiacionesleidas.OnIdleState.BorderRadius = 30;
            this.notifiacionesleidas.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.notifiacionesleidas.OnIdleState.BorderThickness = 3;
            this.notifiacionesleidas.OnIdleState.FillColor = System.Drawing.Color.Navy;
            this.notifiacionesleidas.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.notifiacionesleidas.OnIdleState.IconLeftImage = null;
            this.notifiacionesleidas.OnIdleState.IconRightImage = null;
            this.notifiacionesleidas.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.notifiacionesleidas.OnPressedState.BorderRadius = 30;
            this.notifiacionesleidas.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.notifiacionesleidas.OnPressedState.BorderThickness = 3;
            this.notifiacionesleidas.OnPressedState.FillColor = System.Drawing.Color.Navy;
            this.notifiacionesleidas.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.notifiacionesleidas.OnPressedState.IconLeftImage = null;
            this.notifiacionesleidas.OnPressedState.IconRightImage = null;
            this.notifiacionesleidas.Size = new System.Drawing.Size(261, 40);
            this.notifiacionesleidas.TabIndex = 1;
            this.notifiacionesleidas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.notifiacionesleidas.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.notifiacionesleidas.TextMarginLeft = 0;
            this.notifiacionesleidas.TextPadding = new System.Windows.Forms.Padding(0);
            this.notifiacionesleidas.UseDefaultRadiusAndThickness = true;
            this.notifiacionesleidas.Click += new System.EventHandler(this.notifiacionesleidas_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // NotificationsPanel
            // 
            this.NotificationsPanel.AutoScroll = true;
            this.NotificationsPanel.BackColor = System.Drawing.Color.Transparent;
            this.NotificationsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NotificationsPanel.Location = new System.Drawing.Point(0, 100);
            this.NotificationsPanel.Name = "NotificationsPanel";
            this.NotificationsPanel.Size = new System.Drawing.Size(616, 548);
            this.NotificationsPanel.TabIndex = 108;
            // 
            // Notificaciones
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(616, 648);
            this.Controls.Add(this.NotificationsPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Notificaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notificaciones";
            this.Load += new System.EventHandler(this.Notificaciones_Load);
            this.panel1.ResumeLayout(false);
            this.bunifuPanel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 BtnNoLeidas;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 notifiacionesleidas;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel8;
        private System.Windows.Forms.Button button2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel NotificationsPanel;
    }
}