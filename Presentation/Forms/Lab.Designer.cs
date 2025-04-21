
namespace Presentation.Forms
{
    partial class Laboratorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Laboratorios));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbllaboratorio = new System.Windows.Forms.Label();
            this.checklab = new System.Windows.Forms.CheckBox();
            this.btnlab = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.dgvlaboratorio = new System.Windows.Forms.DataGridView();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlaboratorio)).BeginInit();
            this.SuspendLayout();
            // 
            // lbllaboratorio
            // 
            this.lbllaboratorio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbllaboratorio.AutoSize = true;
            this.lbllaboratorio.BackColor = System.Drawing.Color.Transparent;
            this.lbllaboratorio.Font = new System.Drawing.Font("Arial Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllaboratorio.ForeColor = System.Drawing.Color.White;
            this.lbllaboratorio.Location = new System.Drawing.Point(49, 9);
            this.lbllaboratorio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllaboratorio.Name = "lbllaboratorio";
            this.lbllaboratorio.Size = new System.Drawing.Size(590, 42);
            this.lbllaboratorio.TabIndex = 78;
            this.lbllaboratorio.Text = "Laboratorios clínicos almacenados";
            // 
            // checklab
            // 
            this.checklab.AutoSize = true;
            this.checklab.BackColor = System.Drawing.Color.Transparent;
            this.checklab.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checklab.ForeColor = System.Drawing.Color.Black;
            this.checklab.Location = new System.Drawing.Point(7, 257);
            this.checklab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checklab.Name = "checklab";
            this.checklab.Size = new System.Drawing.Size(315, 32);
            this.checklab.TabIndex = 79;
            this.checklab.Text = "Ver todos los laboratorios";
            this.checklab.UseVisualStyleBackColor = false;
            this.checklab.Visible = false;
            this.checklab.CheckedChanged += new System.EventHandler(this.checklab_CheckedChanged);
            // 
            // btnlab
            // 
            this.btnlab.AllowAnimations = true;
            this.btnlab.AllowMouseEffects = true;
            this.btnlab.AllowToggling = false;
            this.btnlab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnlab.AnimationSpeed = 200;
            this.btnlab.AutoGenerateColors = false;
            this.btnlab.AutoRoundBorders = false;
            this.btnlab.AutoSizeLeftIcon = true;
            this.btnlab.AutoSizeRightIcon = true;
            this.btnlab.BackColor = System.Drawing.Color.Transparent;
            this.btnlab.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnlab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlab.BackgroundImage")));
            this.btnlab.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.btnlab.ButtonText = "Ver laboratorio en una plantilla";
            this.btnlab.ButtonTextMarginLeft = 0;
            this.btnlab.ColorContrastOnClick = 45;
            this.btnlab.ColorContrastOnHover = 45;
            this.btnlab.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnlab.CustomizableEdges = borderEdges1;
            this.btnlab.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnlab.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnlab.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnlab.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnlab.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Disabled;
            this.btnlab.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlab.ForeColor = System.Drawing.Color.White;
            this.btnlab.IconLeft = null;
            this.btnlab.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlab.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnlab.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnlab.IconMarginLeft = 11;
            this.btnlab.IconPadding = 13;
            this.btnlab.IconRight = null;
            this.btnlab.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlab.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnlab.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnlab.IconSize = 27;
            this.btnlab.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnlab.IdleBorderRadius = 30;
            this.btnlab.IdleBorderThickness = 1;
            this.btnlab.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnlab.IdleIconLeftImage = null;
            this.btnlab.IdleIconRightImage = null;
            this.btnlab.IndicateFocus = false;
            this.btnlab.Location = new System.Drawing.Point(875, 239);
            this.btnlab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnlab.Name = "btnlab";
            this.btnlab.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnlab.OnDisabledState.BorderRadius = 39;
            this.btnlab.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnlab.OnDisabledState.BorderThickness = 1;
            this.btnlab.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnlab.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnlab.OnDisabledState.IconLeftImage = null;
            this.btnlab.OnDisabledState.IconRightImage = null;
            this.btnlab.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnlab.onHoverState.BorderRadius = 39;
            this.btnlab.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnlab.onHoverState.BorderThickness = 1;
            this.btnlab.onHoverState.FillColor = System.Drawing.Color.Navy;
            this.btnlab.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnlab.onHoverState.IconLeftImage = null;
            this.btnlab.onHoverState.IconRightImage = null;
            this.btnlab.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnlab.OnIdleState.BorderRadius = 39;
            this.btnlab.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.btnlab.OnIdleState.BorderThickness = 1;
            this.btnlab.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnlab.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnlab.OnIdleState.IconLeftImage = null;
            this.btnlab.OnIdleState.IconRightImage = null;
            this.btnlab.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnlab.OnPressedState.BorderRadius = 39;
            this.btnlab.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnlab.OnPressedState.BorderThickness = 1;
            this.btnlab.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnlab.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnlab.OnPressedState.IconLeftImage = null;
            this.btnlab.OnPressedState.IconRightImage = null;
            this.btnlab.Size = new System.Drawing.Size(364, 53);
            this.btnlab.TabIndex = 96;
            this.btnlab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnlab.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnlab.TextMarginLeft = 0;
            this.btnlab.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnlab.UseDefaultRadiusAndThickness = true;
            this.btnlab.Click += new System.EventHandler(this.btnlab_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(646, 42);
            this.label1.TabIndex = 98;
            this.label1.Text = "Mis laboratorios clínicos almacenados";
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 50;
            this.bunifuPanel1.BorderThickness = 0;
            this.bunifuPanel1.Controls.Add(this.label1);
            this.bunifuPanel1.Controls.Add(this.lbllaboratorio);
            this.bunifuPanel1.Location = new System.Drawing.Point(264, 132);
            this.bunifuPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(725, 59);
            this.bunifuPanel1.TabIndex = 102;
            // 
            // dgvlaboratorio
            // 
            this.dgvlaboratorio.AllowUserToAddRows = false;
            this.dgvlaboratorio.AllowUserToDeleteRows = false;
            this.dgvlaboratorio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvlaboratorio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvlaboratorio.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvlaboratorio.BackgroundColor = System.Drawing.Color.Black;
            this.dgvlaboratorio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvlaboratorio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvlaboratorio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvlaboratorio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvlaboratorio.ColumnHeadersHeight = 42;
            this.dgvlaboratorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvlaboratorio.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvlaboratorio.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvlaboratorio.EnableHeadersVisualStyles = false;
            this.dgvlaboratorio.GridColor = System.Drawing.Color.MediumPurple;
            this.dgvlaboratorio.Location = new System.Drawing.Point(0, 298);
            this.dgvlaboratorio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvlaboratorio.Name = "dgvlaboratorio";
            this.dgvlaboratorio.ReadOnly = true;
            this.dgvlaboratorio.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvlaboratorio.RowHeadersVisible = false;
            this.dgvlaboratorio.RowHeadersWidth = 50;
            this.dgvlaboratorio.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvlaboratorio.RowTemplate.Height = 32;
            this.dgvlaboratorio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvlaboratorio.Size = new System.Drawing.Size(1247, 330);
            this.dgvlaboratorio.TabIndex = 105;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Laboratorios
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1247, 628);
            this.Controls.Add(this.dgvlaboratorio);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.btnlab);
            this.Controls.Add(this.checklab);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Laboratorios";
            this.Text = "Laboratorios clínicos";
            this.Load += new System.EventHandler(this.Lab_Load);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlaboratorio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbllaboratorio;
        private System.Windows.Forms.CheckBox checklab;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnlab;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.DataGridView dgvlaboratorio;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}