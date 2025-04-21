
namespace Presentation.Forms
{
    partial class Paciente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paciente));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.GridUsers = new System.Windows.Forms.DataGridView();
            this.btnmostrarfactura = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnimagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblnumeroinhabilitados = new System.Windows.Forms.Label();
            this.lblnumerohabilitados = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblnumero = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkfactura = new System.Windows.Forms.CheckBox();
            this.btnddeletedissabledusers = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnregister = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnreservar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnshow = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.textshare = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // GridUsers
            // 
            this.GridUsers.AllowUserToAddRows = false;
            this.GridUsers.AllowUserToDeleteRows = false;
            this.GridUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridUsers.BackgroundColor = System.Drawing.Color.Black;
            this.GridUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.GridUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridUsers.ColumnHeadersHeight = 38;
            this.GridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GridUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnmostrarfactura,
            this.btnimagen});
            this.GridUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridUsers.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridUsers.EnableHeadersVisualStyles = false;
            this.GridUsers.GridColor = System.Drawing.Color.White;
            this.GridUsers.Location = new System.Drawing.Point(0, 318);
            this.GridUsers.Margin = new System.Windows.Forms.Padding(4);
            this.GridUsers.Name = "GridUsers";
            this.GridUsers.ReadOnly = true;
            this.GridUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridUsers.RowHeadersWidth = 35;
            this.GridUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridUsers.Size = new System.Drawing.Size(1385, 368);
            this.GridUsers.TabIndex = 19;
            this.GridUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridUsers_CellContentClick);
            // 
            // btnmostrarfactura
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.btnmostrarfactura.DefaultCellStyle = dataGridViewCellStyle2;
            this.btnmostrarfactura.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmostrarfactura.HeaderText = "";
            this.btnmostrarfactura.MinimumWidth = 50;
            this.btnmostrarfactura.Name = "btnmostrarfactura";
            this.btnmostrarfactura.ReadOnly = true;
            this.btnmostrarfactura.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnmostrarfactura.Text = "Ver factura";
            this.btnmostrarfactura.UseColumnTextForButtonValue = true;
            this.btnmostrarfactura.Width = 50;
            // 
            // btnimagen
            // 
            this.btnimagen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btnimagen.HeaderText = "";
            this.btnimagen.Image = ((System.Drawing.Image)(resources.GetObject("btnimagen.Image")));
            this.btnimagen.MinimumWidth = 10;
            this.btnimagen.Name = "btnimagen";
            this.btnimagen.ReadOnly = true;
            this.btnimagen.Width = 10;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.MinimumWidth = 46;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // checkBox
            // 
            this.checkBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox.AutoSize = true;
            this.checkBox.BackColor = System.Drawing.Color.Transparent;
            this.checkBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.checkBox.ForeColor = System.Drawing.Color.Black;
            this.checkBox.Location = new System.Drawing.Point(1112, 2);
            this.checkBox.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(269, 23);
            this.checkBox.TabIndex = 28;
            this.checkBox.Text = "Mostrar usuarios inhabilitados";
            this.checkBox.UseVisualStyleBackColor = false;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1332, 262);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 60;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblnumeroinhabilitados
            // 
            this.lblnumeroinhabilitados.AutoSize = true;
            this.lblnumeroinhabilitados.BackColor = System.Drawing.Color.Transparent;
            this.lblnumeroinhabilitados.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblnumeroinhabilitados.ForeColor = System.Drawing.Color.Black;
            this.lblnumeroinhabilitados.Location = new System.Drawing.Point(187, 42);
            this.lblnumeroinhabilitados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnumeroinhabilitados.Name = "lblnumeroinhabilitados";
            this.lblnumeroinhabilitados.Size = new System.Drawing.Size(87, 19);
            this.lblnumeroinhabilitados.TabIndex = 76;
            this.lblnumeroinhabilitados.Text = "lblnumero";
            // 
            // lblnumerohabilitados
            // 
            this.lblnumerohabilitados.AutoSize = true;
            this.lblnumerohabilitados.BackColor = System.Drawing.Color.Transparent;
            this.lblnumerohabilitados.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblnumerohabilitados.ForeColor = System.Drawing.Color.Black;
            this.lblnumerohabilitados.Location = new System.Drawing.Point(172, 85);
            this.lblnumerohabilitados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnumerohabilitados.Name = "lblnumerohabilitados";
            this.lblnumerohabilitados.Size = new System.Drawing.Size(87, 19);
            this.lblnumerohabilitados.TabIndex = 75;
            this.lblnumerohabilitados.Text = "lblnumero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(0, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 19);
            this.label5.TabIndex = 74;
            this.label5.Text = "Usuarios inhabilitados: ";
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.BackColor = System.Drawing.Color.Transparent;
            this.lblnumero.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblnumero.ForeColor = System.Drawing.Color.Black;
            this.lblnumero.Location = new System.Drawing.Point(279, 2);
            this.lblnumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(87, 19);
            this.lblnumero.TabIndex = 72;
            this.lblnumero.Text = "lblnumero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(0, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 19);
            this.label3.TabIndex = 71;
            this.label3.Text = "Numero de usuarios registrados: ";
            // 
            // checkfactura
            // 
            this.checkfactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkfactura.AutoSize = true;
            this.checkfactura.BackColor = System.Drawing.Color.Transparent;
            this.checkfactura.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.checkfactura.ForeColor = System.Drawing.Color.Black;
            this.checkfactura.Location = new System.Drawing.Point(1144, 37);
            this.checkfactura.Margin = new System.Windows.Forms.Padding(4);
            this.checkfactura.Name = "checkfactura";
            this.checkfactura.Size = new System.Drawing.Size(237, 23);
            this.checkfactura.TabIndex = 86;
            this.checkfactura.Text = "Mostrar todas las facturas";
            this.checkfactura.UseVisualStyleBackColor = false;
            this.checkfactura.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnddeletedissabledusers
            // 
            this.btnddeletedissabledusers.AllowAnimations = true;
            this.btnddeletedissabledusers.AllowMouseEffects = true;
            this.btnddeletedissabledusers.AllowToggling = false;
            this.btnddeletedissabledusers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnddeletedissabledusers.AnimationSpeed = 200;
            this.btnddeletedissabledusers.AutoGenerateColors = false;
            this.btnddeletedissabledusers.AutoRoundBorders = false;
            this.btnddeletedissabledusers.AutoSizeLeftIcon = true;
            this.btnddeletedissabledusers.AutoSizeRightIcon = true;
            this.btnddeletedissabledusers.BackColor = System.Drawing.Color.Transparent;
            this.btnddeletedissabledusers.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnddeletedissabledusers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnddeletedissabledusers.BackgroundImage")));
            this.btnddeletedissabledusers.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.btnddeletedissabledusers.ButtonText = "Eliminar usuarios inhabilitados";
            this.btnddeletedissabledusers.ButtonTextMarginLeft = 0;
            this.btnddeletedissabledusers.ColorContrastOnClick = 45;
            this.btnddeletedissabledusers.ColorContrastOnHover = 45;
            this.btnddeletedissabledusers.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnddeletedissabledusers.CustomizableEdges = borderEdges1;
            this.btnddeletedissabledusers.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnddeletedissabledusers.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnddeletedissabledusers.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnddeletedissabledusers.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnddeletedissabledusers.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Disabled;
            this.btnddeletedissabledusers.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnddeletedissabledusers.ForeColor = System.Drawing.Color.White;
            this.btnddeletedissabledusers.IconLeft = null;
            this.btnddeletedissabledusers.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnddeletedissabledusers.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnddeletedissabledusers.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnddeletedissabledusers.IconMarginLeft = 11;
            this.btnddeletedissabledusers.IconPadding = 10;
            this.btnddeletedissabledusers.IconRight = null;
            this.btnddeletedissabledusers.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnddeletedissabledusers.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnddeletedissabledusers.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnddeletedissabledusers.IconSize = 27;
            this.btnddeletedissabledusers.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnddeletedissabledusers.IdleBorderRadius = 30;
            this.btnddeletedissabledusers.IdleBorderThickness = 1;
            this.btnddeletedissabledusers.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnddeletedissabledusers.IdleIconLeftImage = null;
            this.btnddeletedissabledusers.IdleIconRightImage = null;
            this.btnddeletedissabledusers.IndicateFocus = false;
            this.btnddeletedissabledusers.Location = new System.Drawing.Point(697, 262);
            this.btnddeletedissabledusers.Margin = new System.Windows.Forms.Padding(4);
            this.btnddeletedissabledusers.Name = "btnddeletedissabledusers";
            this.btnddeletedissabledusers.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnddeletedissabledusers.OnDisabledState.BorderRadius = 30;
            this.btnddeletedissabledusers.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnddeletedissabledusers.OnDisabledState.BorderThickness = 1;
            this.btnddeletedissabledusers.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnddeletedissabledusers.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnddeletedissabledusers.OnDisabledState.IconLeftImage = null;
            this.btnddeletedissabledusers.OnDisabledState.IconRightImage = null;
            this.btnddeletedissabledusers.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnddeletedissabledusers.onHoverState.BorderRadius = 30;
            this.btnddeletedissabledusers.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnddeletedissabledusers.onHoverState.BorderThickness = 1;
            this.btnddeletedissabledusers.onHoverState.FillColor = System.Drawing.Color.Navy;
            this.btnddeletedissabledusers.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnddeletedissabledusers.onHoverState.IconLeftImage = null;
            this.btnddeletedissabledusers.onHoverState.IconRightImage = null;
            this.btnddeletedissabledusers.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnddeletedissabledusers.OnIdleState.BorderRadius = 30;
            this.btnddeletedissabledusers.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.btnddeletedissabledusers.OnIdleState.BorderThickness = 1;
            this.btnddeletedissabledusers.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnddeletedissabledusers.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnddeletedissabledusers.OnIdleState.IconLeftImage = null;
            this.btnddeletedissabledusers.OnIdleState.IconRightImage = null;
            this.btnddeletedissabledusers.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnddeletedissabledusers.OnPressedState.BorderRadius = 30;
            this.btnddeletedissabledusers.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnddeletedissabledusers.OnPressedState.BorderThickness = 1;
            this.btnddeletedissabledusers.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnddeletedissabledusers.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnddeletedissabledusers.OnPressedState.IconLeftImage = null;
            this.btnddeletedissabledusers.OnPressedState.IconRightImage = null;
            this.btnddeletedissabledusers.Size = new System.Drawing.Size(351, 48);
            this.btnddeletedissabledusers.TabIndex = 89;
            this.btnddeletedissabledusers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnddeletedissabledusers.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnddeletedissabledusers.TextMarginLeft = 0;
            this.btnddeletedissabledusers.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnddeletedissabledusers.UseDefaultRadiusAndThickness = true;
            this.btnddeletedissabledusers.Click += new System.EventHandler(this.btndeleteuserdisable);
            // 
            // btnregister
            // 
            this.btnregister.AllowAnimations = true;
            this.btnregister.AllowMouseEffects = true;
            this.btnregister.AllowToggling = false;
            this.btnregister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnregister.AnimationSpeed = 200;
            this.btnregister.AutoGenerateColors = false;
            this.btnregister.AutoRoundBorders = false;
            this.btnregister.AutoSizeLeftIcon = true;
            this.btnregister.AutoSizeRightIcon = true;
            this.btnregister.BackColor = System.Drawing.Color.Transparent;
            this.btnregister.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnregister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnregister.BackgroundImage")));
            this.btnregister.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.btnregister.ButtonText = "Nuevo Paciente";
            this.btnregister.ButtonTextMarginLeft = 0;
            this.btnregister.ColorContrastOnClick = 45;
            this.btnregister.ColorContrastOnHover = 45;
            this.btnregister.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnregister.CustomizableEdges = borderEdges2;
            this.btnregister.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnregister.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnregister.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnregister.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnregister.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Disabled;
            this.btnregister.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnregister.ForeColor = System.Drawing.Color.White;
            this.btnregister.IconLeft = null;
            this.btnregister.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnregister.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnregister.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnregister.IconMarginLeft = 11;
            this.btnregister.IconPadding = 10;
            this.btnregister.IconRight = null;
            this.btnregister.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnregister.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnregister.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnregister.IconSize = 27;
            this.btnregister.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnregister.IdleBorderRadius = 30;
            this.btnregister.IdleBorderThickness = 1;
            this.btnregister.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnregister.IdleIconLeftImage = null;
            this.btnregister.IdleIconRightImage = null;
            this.btnregister.IndicateFocus = false;
            this.btnregister.Location = new System.Drawing.Point(1088, 262);
            this.btnregister.Margin = new System.Windows.Forms.Padding(4);
            this.btnregister.Name = "btnregister";
            this.btnregister.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnregister.OnDisabledState.BorderRadius = 30;
            this.btnregister.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnregister.OnDisabledState.BorderThickness = 1;
            this.btnregister.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnregister.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnregister.OnDisabledState.IconLeftImage = null;
            this.btnregister.OnDisabledState.IconRightImage = null;
            this.btnregister.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnregister.onHoverState.BorderRadius = 30;
            this.btnregister.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnregister.onHoverState.BorderThickness = 1;
            this.btnregister.onHoverState.FillColor = System.Drawing.Color.Navy;
            this.btnregister.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnregister.onHoverState.IconLeftImage = null;
            this.btnregister.onHoverState.IconRightImage = null;
            this.btnregister.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnregister.OnIdleState.BorderRadius = 30;
            this.btnregister.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.btnregister.OnIdleState.BorderThickness = 1;
            this.btnregister.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnregister.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnregister.OnIdleState.IconLeftImage = null;
            this.btnregister.OnIdleState.IconRightImage = null;
            this.btnregister.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnregister.OnPressedState.BorderRadius = 30;
            this.btnregister.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnregister.OnPressedState.BorderThickness = 1;
            this.btnregister.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnregister.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnregister.OnPressedState.IconLeftImage = null;
            this.btnregister.OnPressedState.IconRightImage = null;
            this.btnregister.Size = new System.Drawing.Size(197, 48);
            this.btnregister.TabIndex = 90;
            this.btnregister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnregister.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnregister.TextMarginLeft = 0;
            this.btnregister.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnregister.UseDefaultRadiusAndThickness = true;
            this.btnregister.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // btnreservar
            // 
            this.btnreservar.AllowAnimations = true;
            this.btnreservar.AllowMouseEffects = true;
            this.btnreservar.AllowToggling = false;
            this.btnreservar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnreservar.AnimationSpeed = 200;
            this.btnreservar.AutoGenerateColors = false;
            this.btnreservar.AutoRoundBorders = false;
            this.btnreservar.AutoSizeLeftIcon = true;
            this.btnreservar.AutoSizeRightIcon = true;
            this.btnreservar.BackColor = System.Drawing.Color.Transparent;
            this.btnreservar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnreservar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnreservar.BackgroundImage")));
            this.btnreservar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.btnreservar.ButtonText = "Reservar cita";
            this.btnreservar.ButtonTextMarginLeft = 0;
            this.btnreservar.ColorContrastOnClick = 45;
            this.btnreservar.ColorContrastOnHover = 45;
            this.btnreservar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnreservar.CustomizableEdges = borderEdges3;
            this.btnreservar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnreservar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnreservar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnreservar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnreservar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Disabled;
            this.btnreservar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnreservar.ForeColor = System.Drawing.Color.White;
            this.btnreservar.IconLeft = null;
            this.btnreservar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreservar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnreservar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnreservar.IconMarginLeft = 11;
            this.btnreservar.IconPadding = 10;
            this.btnreservar.IconRight = null;
            this.btnreservar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnreservar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnreservar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnreservar.IconSize = 27;
            this.btnreservar.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnreservar.IdleBorderRadius = 30;
            this.btnreservar.IdleBorderThickness = 1;
            this.btnreservar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnreservar.IdleIconLeftImage = null;
            this.btnreservar.IdleIconRightImage = null;
            this.btnreservar.IndicateFocus = false;
            this.btnreservar.Location = new System.Drawing.Point(512, 263);
            this.btnreservar.Margin = new System.Windows.Forms.Padding(4);
            this.btnreservar.Name = "btnreservar";
            this.btnreservar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnreservar.OnDisabledState.BorderRadius = 30;
            this.btnreservar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnreservar.OnDisabledState.BorderThickness = 1;
            this.btnreservar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnreservar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnreservar.OnDisabledState.IconLeftImage = null;
            this.btnreservar.OnDisabledState.IconRightImage = null;
            this.btnreservar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnreservar.onHoverState.BorderRadius = 30;
            this.btnreservar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnreservar.onHoverState.BorderThickness = 1;
            this.btnreservar.onHoverState.FillColor = System.Drawing.Color.Navy;
            this.btnreservar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnreservar.onHoverState.IconLeftImage = null;
            this.btnreservar.onHoverState.IconRightImage = null;
            this.btnreservar.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnreservar.OnIdleState.BorderRadius = 30;
            this.btnreservar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.btnreservar.OnIdleState.BorderThickness = 1;
            this.btnreservar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnreservar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnreservar.OnIdleState.IconLeftImage = null;
            this.btnreservar.OnIdleState.IconRightImage = null;
            this.btnreservar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnreservar.OnPressedState.BorderRadius = 30;
            this.btnreservar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnreservar.OnPressedState.BorderThickness = 1;
            this.btnreservar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnreservar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnreservar.OnPressedState.IconLeftImage = null;
            this.btnreservar.OnPressedState.IconRightImage = null;
            this.btnreservar.Size = new System.Drawing.Size(161, 48);
            this.btnreservar.TabIndex = 91;
            this.btnreservar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnreservar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnreservar.TextMarginLeft = 0;
            this.btnreservar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnreservar.UseDefaultRadiusAndThickness = true;
            this.btnreservar.Click += new System.EventHandler(this.bunifuButton2_Click);
            // 
            // btnshow
            // 
            this.btnshow.AllowAnimations = true;
            this.btnshow.AllowMouseEffects = true;
            this.btnshow.AllowToggling = false;
            this.btnshow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnshow.AnimationSpeed = 200;
            this.btnshow.AutoGenerateColors = false;
            this.btnshow.AutoRoundBorders = false;
            this.btnshow.AutoSizeLeftIcon = true;
            this.btnshow.AutoSizeRightIcon = true;
            this.btnshow.BackColor = System.Drawing.Color.Transparent;
            this.btnshow.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnshow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnshow.BackgroundImage")));
            this.btnshow.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.btnshow.ButtonText = "Ver perfil";
            this.btnshow.ButtonTextMarginLeft = 0;
            this.btnshow.ColorContrastOnClick = 45;
            this.btnshow.ColorContrastOnHover = 45;
            this.btnshow.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnshow.CustomizableEdges = borderEdges4;
            this.btnshow.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnshow.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnshow.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnshow.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnshow.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Disabled;
            this.btnshow.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnshow.ForeColor = System.Drawing.Color.White;
            this.btnshow.IconLeft = null;
            this.btnshow.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnshow.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnshow.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnshow.IconMarginLeft = 11;
            this.btnshow.IconPadding = 10;
            this.btnshow.IconRight = null;
            this.btnshow.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnshow.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnshow.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnshow.IconSize = 27;
            this.btnshow.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnshow.IdleBorderRadius = 30;
            this.btnshow.IdleBorderThickness = 1;
            this.btnshow.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnshow.IdleIconLeftImage = null;
            this.btnshow.IdleIconRightImage = null;
            this.btnshow.IndicateFocus = false;
            this.btnshow.Location = new System.Drawing.Point(344, 263);
            this.btnshow.Margin = new System.Windows.Forms.Padding(4);
            this.btnshow.Name = "btnshow";
            this.btnshow.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnshow.OnDisabledState.BorderRadius = 30;
            this.btnshow.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnshow.OnDisabledState.BorderThickness = 1;
            this.btnshow.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnshow.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnshow.OnDisabledState.IconLeftImage = null;
            this.btnshow.OnDisabledState.IconRightImage = null;
            this.btnshow.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnshow.onHoverState.BorderRadius = 30;
            this.btnshow.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnshow.onHoverState.BorderThickness = 1;
            this.btnshow.onHoverState.FillColor = System.Drawing.Color.Navy;
            this.btnshow.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnshow.onHoverState.IconLeftImage = null;
            this.btnshow.onHoverState.IconRightImage = null;
            this.btnshow.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnshow.OnIdleState.BorderRadius = 30;
            this.btnshow.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.btnshow.OnIdleState.BorderThickness = 1;
            this.btnshow.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnshow.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnshow.OnIdleState.IconLeftImage = null;
            this.btnshow.OnIdleState.IconRightImage = null;
            this.btnshow.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnshow.OnPressedState.BorderRadius = 30;
            this.btnshow.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnshow.OnPressedState.BorderThickness = 1;
            this.btnshow.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnshow.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnshow.OnPressedState.IconLeftImage = null;
            this.btnshow.OnPressedState.IconRightImage = null;
            this.btnshow.Size = new System.Drawing.Size(143, 48);
            this.btnshow.TabIndex = 92;
            this.btnshow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnshow.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnshow.TextMarginLeft = 0;
            this.btnshow.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnshow.UseDefaultRadiusAndThickness = true;
            this.btnshow.Click += new System.EventHandler(this.bunifuButton3_Click);
            // 
            // textshare
            // 
            this.textshare.AcceptsReturn = false;
            this.textshare.AcceptsTab = false;
            this.textshare.AnimationSpeed = 200;
            this.textshare.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textshare.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textshare.AutoSizeHeight = true;
            this.textshare.BackColor = System.Drawing.Color.Transparent;
            this.textshare.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textshare.BackgroundImage")));
            this.textshare.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.textshare.BorderColorDisabled = System.Drawing.Color.Silver;
            this.textshare.BorderColorHover = System.Drawing.Color.White;
            this.textshare.BorderColorIdle = System.Drawing.Color.White;
            this.textshare.BorderRadius = 25;
            this.textshare.BorderThickness = 1;
            this.textshare.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textshare.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textshare.DefaultFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.textshare.DefaultText = "";
            this.textshare.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textshare.ForeColor = System.Drawing.Color.White;
            this.textshare.HideSelection = true;
            this.textshare.IconLeft = null;
            this.textshare.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.textshare.IconPadding = 10;
            this.textshare.IconRight = null;
            this.textshare.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.textshare.Lines = new string[0];
            this.textshare.Location = new System.Drawing.Point(4, 262);
            this.textshare.Margin = new System.Windows.Forms.Padding(4);
            this.textshare.MaxLength = 32767;
            this.textshare.MinimumSize = new System.Drawing.Size(1, 1);
            this.textshare.Modified = false;
            this.textshare.Multiline = false;
            this.textshare.Name = "textshare";
            stateProperties1.BorderColor = System.Drawing.Color.White;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textshare.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Silver;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.textshare.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.White;
            stateProperties3.FillColor = System.Drawing.Color.Silver;
            stateProperties3.ForeColor = System.Drawing.Color.White;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textshare.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.White;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textshare.OnIdleState = stateProperties4;
            this.textshare.Padding = new System.Windows.Forms.Padding(4);
            this.textshare.PasswordChar = '\0';
            this.textshare.PlaceholderForeColor = System.Drawing.Color.Black;
            this.textshare.PlaceholderText = "Realizar Busqueda";
            this.textshare.ReadOnly = false;
            this.textshare.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textshare.SelectedText = "";
            this.textshare.SelectionLength = 0;
            this.textshare.SelectionStart = 0;
            this.textshare.ShortcutsEnabled = true;
            this.textshare.Size = new System.Drawing.Size(273, 43);
            this.textshare.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.textshare.TabIndex = 97;
            this.textshare.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textshare.TextMarginBottom = 0;
            this.textshare.TextMarginLeft = 3;
            this.textshare.TextMarginTop = 0;
            this.textshare.TextPlaceholder = "Realizar Busqueda";
            this.textshare.UseSystemPasswordChar = false;
            this.textshare.WordWrap = true;
            this.textshare.TextChanged += new System.EventHandler(this.textnumber_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(0, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 19);
            this.label4.TabIndex = 73;
            this.label4.Text = "Usuarios habilitados: ";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Paciente
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1385, 686);
            this.Controls.Add(this.lblnumero);
            this.Controls.Add(this.textshare);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.btnreservar);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.btnddeletedissabledusers);
            this.Controls.Add(this.checkfactura);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.GridUsers);
            this.Controls.Add(this.lblnumeroinhabilitados);
            this.Controls.Add(this.lblnumerohabilitados);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Paciente";
            this.Text = "Pacientes registrados";
            this.Load += new System.EventHandler(this.Paciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView GridUsers;
        private System.Windows.Forms.Label lblnumeroinhabilitados;
        private System.Windows.Forms.Label lblnumerohabilitados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkfactura;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnddeletedissabledusers;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnregister;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnreservar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnshow;
        private Bunifu.UI.WinForms.BunifuTextBox textshare;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewButtonColumn btnmostrarfactura;
        private System.Windows.Forms.DataGridViewImageColumn btnimagen;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}