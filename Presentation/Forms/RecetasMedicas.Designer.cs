
namespace Presentation.Forms
{
    partial class RecetasMedicas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecetasMedicas));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.dgvrecetas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.checkallreceta = new System.Windows.Forms.CheckBox();
            this.btnreceta = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrecetas)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvrecetas
            // 
            this.dgvrecetas.AllowUserToAddRows = false;
            this.dgvrecetas.AllowUserToDeleteRows = false;
            this.dgvrecetas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvrecetas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvrecetas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvrecetas.BackgroundColor = System.Drawing.Color.Black;
            this.dgvrecetas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvrecetas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvrecetas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvrecetas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvrecetas.ColumnHeadersHeight = 42;
            this.dgvrecetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvrecetas.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvrecetas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvrecetas.EnableHeadersVisualStyles = false;
            this.dgvrecetas.GridColor = System.Drawing.Color.MediumPurple;
            this.dgvrecetas.Location = new System.Drawing.Point(0, 282);
            this.dgvrecetas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvrecetas.Name = "dgvrecetas";
            this.dgvrecetas.ReadOnly = true;
            this.dgvrecetas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvrecetas.RowHeadersVisible = false;
            this.dgvrecetas.RowHeadersWidth = 50;
            this.dgvrecetas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvrecetas.RowTemplate.Height = 32;
            this.dgvrecetas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvrecetas.Size = new System.Drawing.Size(1213, 308);
            this.dgvrecetas.TabIndex = 20;
            this.dgvrecetas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvrecetas_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Arial Black", 13.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(624, 32);
            this.label1.TabIndex = 70;
            this.label1.Text = "Recetas Médica que fueron enviadas a pacientes";
            // 
            // checkallreceta
            // 
            this.checkallreceta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkallreceta.AutoSize = true;
            this.checkallreceta.BackColor = System.Drawing.Color.DodgerBlue;
            this.checkallreceta.Font = new System.Drawing.Font("Arial Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkallreceta.ForeColor = System.Drawing.Color.White;
            this.checkallreceta.Location = new System.Drawing.Point(852, 1);
            this.checkallreceta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkallreceta.Name = "checkallreceta";
            this.checkallreceta.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.checkallreceta.Size = new System.Drawing.Size(360, 31);
            this.checkallreceta.TabIndex = 80;
            this.checkallreceta.Text = "Ver todas las recetas médicas\r\n";
            this.checkallreceta.UseVisualStyleBackColor = false;
            this.checkallreceta.CheckedChanged += new System.EventHandler(this.checkallreceta_CheckedChanged);
            // 
            // btnreceta
            // 
            this.btnreceta.AllowAnimations = true;
            this.btnreceta.AllowMouseEffects = true;
            this.btnreceta.AllowToggling = false;
            this.btnreceta.AnimationSpeed = 200;
            this.btnreceta.AutoGenerateColors = false;
            this.btnreceta.AutoRoundBorders = false;
            this.btnreceta.AutoSizeLeftIcon = true;
            this.btnreceta.AutoSizeRightIcon = true;
            this.btnreceta.BackColor = System.Drawing.Color.Transparent;
            this.btnreceta.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnreceta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnreceta.BackgroundImage")));
            this.btnreceta.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.btnreceta.ButtonText = "Mostrar receta médica en una plantilla";
            this.btnreceta.ButtonTextMarginLeft = 0;
            this.btnreceta.ColorContrastOnClick = 45;
            this.btnreceta.ColorContrastOnHover = 45;
            this.btnreceta.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnreceta.CustomizableEdges = borderEdges3;
            this.btnreceta.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnreceta.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnreceta.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnreceta.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnreceta.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Disabled;
            this.btnreceta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreceta.ForeColor = System.Drawing.Color.White;
            this.btnreceta.IconLeft = null;
            this.btnreceta.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreceta.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnreceta.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnreceta.IconMarginLeft = 11;
            this.btnreceta.IconPadding = 10;
            this.btnreceta.IconRight = null;
            this.btnreceta.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnreceta.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnreceta.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnreceta.IconSize = 27;
            this.btnreceta.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnreceta.IdleBorderRadius = 30;
            this.btnreceta.IdleBorderThickness = 1;
            this.btnreceta.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnreceta.IdleIconLeftImage = null;
            this.btnreceta.IdleIconRightImage = null;
            this.btnreceta.IndicateFocus = false;
            this.btnreceta.Location = new System.Drawing.Point(7, 226);
            this.btnreceta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnreceta.Name = "btnreceta";
            this.btnreceta.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnreceta.OnDisabledState.BorderRadius = 30;
            this.btnreceta.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnreceta.OnDisabledState.BorderThickness = 1;
            this.btnreceta.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnreceta.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnreceta.OnDisabledState.IconLeftImage = null;
            this.btnreceta.OnDisabledState.IconRightImage = null;
            this.btnreceta.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnreceta.onHoverState.BorderRadius = 30;
            this.btnreceta.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnreceta.onHoverState.BorderThickness = 1;
            this.btnreceta.onHoverState.FillColor = System.Drawing.Color.Navy;
            this.btnreceta.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnreceta.onHoverState.IconLeftImage = null;
            this.btnreceta.onHoverState.IconRightImage = null;
            this.btnreceta.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnreceta.OnIdleState.BorderRadius = 30;
            this.btnreceta.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.btnreceta.OnIdleState.BorderThickness = 1;
            this.btnreceta.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnreceta.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnreceta.OnIdleState.IconLeftImage = null;
            this.btnreceta.OnIdleState.IconRightImage = null;
            this.btnreceta.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnreceta.OnPressedState.BorderRadius = 30;
            this.btnreceta.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnreceta.OnPressedState.BorderThickness = 1;
            this.btnreceta.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnreceta.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnreceta.OnPressedState.IconLeftImage = null;
            this.btnreceta.OnPressedState.IconRightImage = null;
            this.btnreceta.Size = new System.Drawing.Size(420, 48);
            this.btnreceta.TabIndex = 90;
            this.btnreceta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnreceta.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnreceta.TextMarginLeft = 0;
            this.btnreceta.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnreceta.UseDefaultRadiusAndThickness = true;
            this.btnreceta.Click += new System.EventHandler(this.btnreceta_Click);
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 50;
            this.bunifuPanel1.BorderThickness = 0;
            this.bunifuPanel1.Controls.Add(this.label2);
            this.bunifuPanel1.Controls.Add(this.label1);
            this.bunifuPanel1.Location = new System.Drawing.Point(240, 130);
            this.bunifuPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(748, 59);
            this.bunifuPanel1.TabIndex = 102;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Arial Black", 13.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(126, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(446, 32);
            this.label2.TabIndex = 91;
            this.label2.Text = "Mis recetas médicas almacenadas";
            // 
            // RecetasMedicas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1213, 590);
            this.Controls.Add(this.btnreceta);
            this.Controls.Add(this.checkallreceta);
            this.Controls.Add(this.dgvrecetas);
            this.Controls.Add(this.bunifuPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RecetasMedicas";
            this.Text = "Recetas médicas";
            this.Load += new System.EventHandler(this.RecetasMedicas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvrecetas)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvrecetas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkallreceta;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnreceta;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label2;
    }
}