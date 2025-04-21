namespace Presentation
{
    partial class TargetEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TargetEmployee));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.pannel3 = new Bunifu.UI.WinForms.BunifuPanel();
            this.imgusuario = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.imgarco = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.BtnViewProfile = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.lblroll = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblestado = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblarea = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblusuario = new Bunifu.UI.WinForms.BunifuLabel();
            this.pannel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgusuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgarco)).BeginInit();
            this.SuspendLayout();
            // 
            // pannel3
            // 
            this.pannel3.BackgroundColor = System.Drawing.Color.White;
            this.pannel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pannel3.BackgroundImage")));
            this.pannel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pannel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pannel3.BorderRadius = 25;
            this.pannel3.BorderThickness = 4;
            this.pannel3.Controls.Add(this.imgusuario);
            this.pannel3.Controls.Add(this.imgarco);
            this.pannel3.Controls.Add(this.BtnViewProfile);
            this.pannel3.Controls.Add(this.lblroll);
            this.pannel3.Controls.Add(this.lblestado);
            this.pannel3.Controls.Add(this.lblarea);
            this.pannel3.Controls.Add(this.lblusuario);
            this.pannel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pannel3.Location = new System.Drawing.Point(0, 0);
            this.pannel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pannel3.Name = "pannel3";
            this.pannel3.ShowBorders = true;
            this.pannel3.Size = new System.Drawing.Size(424, 238);
            this.pannel3.TabIndex = 2;
            // 
            // imgusuario
            // 
            this.imgusuario.AllowFocused = false;
            this.imgusuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgusuario.AutoSizeHeight = true;
            this.imgusuario.BorderRadius = 57;
            this.imgusuario.Image = ((System.Drawing.Image)(resources.GetObject("imgusuario.Image")));
            this.imgusuario.IsCircle = true;
            this.imgusuario.Location = new System.Drawing.Point(48, 28);
            this.imgusuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imgusuario.Name = "imgusuario";
            this.imgusuario.Size = new System.Drawing.Size(115, 115);
            this.imgusuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgusuario.TabIndex = 105;
            this.imgusuario.TabStop = false;
            this.imgusuario.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // imgarco
            // 
            this.imgarco.AllowFocused = false;
            this.imgarco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgarco.AutoSizeHeight = true;
            this.imgarco.BorderRadius = 76;
            this.imgarco.Image = ((System.Drawing.Image)(resources.GetObject("imgarco.Image")));
            this.imgarco.IsCircle = true;
            this.imgarco.Location = new System.Drawing.Point(32, 12);
            this.imgarco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imgarco.Name = "imgarco";
            this.imgarco.Size = new System.Drawing.Size(152, 152);
            this.imgarco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgarco.TabIndex = 104;
            this.imgarco.TabStop = false;
            this.imgarco.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // BtnViewProfile
            // 
            this.BtnViewProfile.AllowAnimations = true;
            this.BtnViewProfile.AllowMouseEffects = true;
            this.BtnViewProfile.AllowToggling = false;
            this.BtnViewProfile.AnimationSpeed = 200;
            this.BtnViewProfile.AutoGenerateColors = false;
            this.BtnViewProfile.AutoRoundBorders = false;
            this.BtnViewProfile.AutoSizeLeftIcon = true;
            this.BtnViewProfile.AutoSizeRightIcon = true;
            this.BtnViewProfile.BackColor = System.Drawing.Color.Transparent;
            this.BtnViewProfile.BackColor1 = System.Drawing.Color.White;
            this.BtnViewProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnViewProfile.BackgroundImage")));
            this.BtnViewProfile.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnViewProfile.ButtonText = "Ver perfil";
            this.BtnViewProfile.ButtonTextMarginLeft = 0;
            this.BtnViewProfile.ColorContrastOnClick = 45;
            this.BtnViewProfile.ColorContrastOnHover = 45;
            this.BtnViewProfile.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.BtnViewProfile.CustomizableEdges = borderEdges1;
            this.BtnViewProfile.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnViewProfile.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnViewProfile.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnViewProfile.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnViewProfile.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Disabled;
            this.BtnViewProfile.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold);
            this.BtnViewProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnViewProfile.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnViewProfile.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BtnViewProfile.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BtnViewProfile.IconMarginLeft = 11;
            this.BtnViewProfile.IconPadding = 10;
            this.BtnViewProfile.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnViewProfile.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BtnViewProfile.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtnViewProfile.IconSize = 25;
            this.BtnViewProfile.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnViewProfile.IdleBorderRadius = 30;
            this.BtnViewProfile.IdleBorderThickness = 3;
            this.BtnViewProfile.IdleFillColor = System.Drawing.Color.White;
            this.BtnViewProfile.IdleIconLeftImage = null;
            this.BtnViewProfile.IdleIconRightImage = null;
            this.BtnViewProfile.IndicateFocus = false;
            this.BtnViewProfile.Location = new System.Drawing.Point(52, 166);
            this.BtnViewProfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnViewProfile.Name = "BtnViewProfile";
            this.BtnViewProfile.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnViewProfile.OnDisabledState.BorderRadius = 30;
            this.BtnViewProfile.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnViewProfile.OnDisabledState.BorderThickness = 3;
            this.BtnViewProfile.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnViewProfile.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnViewProfile.OnDisabledState.IconLeftImage = null;
            this.BtnViewProfile.OnDisabledState.IconRightImage = null;
            this.BtnViewProfile.onHoverState.BorderColor = System.Drawing.Color.Blue;
            this.BtnViewProfile.onHoverState.BorderRadius = 30;
            this.BtnViewProfile.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnViewProfile.onHoverState.BorderThickness = 3;
            this.BtnViewProfile.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnViewProfile.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BtnViewProfile.onHoverState.IconLeftImage = null;
            this.BtnViewProfile.onHoverState.IconRightImage = null;
            this.BtnViewProfile.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnViewProfile.OnIdleState.BorderRadius = 30;
            this.BtnViewProfile.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnViewProfile.OnIdleState.BorderThickness = 3;
            this.BtnViewProfile.OnIdleState.FillColor = System.Drawing.Color.White;
            this.BtnViewProfile.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnViewProfile.OnIdleState.IconLeftImage = null;
            this.BtnViewProfile.OnIdleState.IconRightImage = null;
            this.BtnViewProfile.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnViewProfile.OnPressedState.BorderRadius = 30;
            this.BtnViewProfile.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnViewProfile.OnPressedState.BorderThickness = 3;
            this.BtnViewProfile.OnPressedState.FillColor = System.Drawing.Color.White;
            this.BtnViewProfile.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnViewProfile.OnPressedState.IconLeftImage = null;
            this.BtnViewProfile.OnPressedState.IconRightImage = null;
            this.BtnViewProfile.Size = new System.Drawing.Size(313, 48);
            this.BtnViewProfile.TabIndex = 10;
            this.BtnViewProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnViewProfile.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnViewProfile.TextMarginLeft = 0;
            this.BtnViewProfile.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtnViewProfile.UseDefaultRadiusAndThickness = true;
            this.BtnViewProfile.Click += new System.EventHandler(this.BtnViewProfile_Click_1);
            // 
            // lblroll
            // 
            this.lblroll.AllowParentOverrides = false;
            this.lblroll.AutoEllipsis = false;
            this.lblroll.CursorType = null;
            this.lblroll.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.lblroll.Location = new System.Drawing.Point(223, 94);
            this.lblroll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblroll.Name = "lblroll";
            this.lblroll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblroll.Size = new System.Drawing.Size(54, 24);
            this.lblroll.TabIndex = 5;
            this.lblroll.Text = "lblroll";
            this.lblroll.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblroll.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblestado
            // 
            this.lblestado.AllowParentOverrides = false;
            this.lblestado.AutoEllipsis = false;
            this.lblestado.CursorType = null;
            this.lblestado.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.lblestado.Location = new System.Drawing.Point(223, 124);
            this.lblestado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblestado.Name = "lblestado";
            this.lblestado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblestado.Size = new System.Drawing.Size(85, 24);
            this.lblestado.TabIndex = 4;
            this.lblestado.Text = "lblestado";
            this.lblestado.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblestado.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblarea
            // 
            this.lblarea.AllowParentOverrides = false;
            this.lblarea.AutoEllipsis = false;
            this.lblarea.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblarea.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblarea.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.lblarea.Location = new System.Drawing.Point(223, 62);
            this.lblarea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblarea.Name = "lblarea";
            this.lblarea.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblarea.Size = new System.Drawing.Size(64, 24);
            this.lblarea.TabIndex = 3;
            this.lblarea.Text = "lblarea";
            this.lblarea.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblarea.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblusuario
            // 
            this.lblusuario.AllowParentOverrides = false;
            this.lblusuario.AutoEllipsis = false;
            this.lblusuario.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblusuario.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblusuario.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.lblusuario.Location = new System.Drawing.Point(223, 31);
            this.lblusuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblusuario.Size = new System.Drawing.Size(91, 24);
            this.lblusuario.TabIndex = 2;
            this.lblusuario.Text = "lblusuario";
            this.lblusuario.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblusuario.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // TargetEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pannel3);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.Name = "TargetEmployee";
            this.Size = new System.Drawing.Size(424, 238);
            this.Load += new System.EventHandler(this.TargetEmployee_Load);
            this.pannel3.ResumeLayout(false);
            this.pannel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgusuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgarco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel pannel3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 BtnViewProfile;
        public Bunifu.UI.WinForms.BunifuLabel lblroll;
        public Bunifu.UI.WinForms.BunifuLabel lblestado;
        public Bunifu.UI.WinForms.BunifuLabel lblarea;
        public Bunifu.UI.WinForms.BunifuLabel lblusuario;
        private Bunifu.UI.WinForms.BunifuPictureBox imgusuario;
        private Bunifu.UI.WinForms.BunifuPictureBox imgarco;
    }
}
