namespace CambioHorVerZebra411
{
    partial class FormMain
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCambiar = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnBajarHor = new Controles.NSButton();
            this.BtnSubirHor = new Controles.NSButton();
            this.TxtHorizontal = new Controles.NSTextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnBajarVer = new Controles.NSButton();
            this.BtnSubirVer = new Controles.NSButton();
            this.TxtVertical = new Controles.NSTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnBajarContraste = new Controles.NSButton();
            this.BtnSubirContraste = new Controles.NSButton();
            this.TxtContraste = new Controles.NSTextBox();
            this.PrintDialog = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.TimerHorizontal = new System.Windows.Forms.Timer(this.components);
            this.TimerVertical = new System.Windows.Forms.Timer(this.components);
            this.TimerContraste = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.LblTitulo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.BtnCambiar, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(768, 524);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // LblTitulo
            // 
            this.LblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblTitulo.Location = new System.Drawing.Point(242, 17);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(282, 32);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "ZEBRA ZT-230-410-411";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(153, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Desplazamiento Horizontal de Etiqueta";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(170, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(426, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Desplazamiento Vertical de Etiqueta";
            // 
            // BtnCambiar
            // 
            this.BtnCambiar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnCambiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(115)))), ((int)(((byte)(71)))));
            this.BtnCambiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(125)))), ((int)(((byte)(71)))));
            this.BtnCambiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(155)))), ((int)(((byte)(71)))));
            this.BtnCambiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(125)))), ((int)(((byte)(71)))));
            this.BtnCambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCambiar.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCambiar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnCambiar.Location = new System.Drawing.Point(319, 461);
            this.BtnCambiar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCambiar.Name = "BtnCambiar";
            this.BtnCambiar.Size = new System.Drawing.Size(128, 58);
            this.BtnCambiar.TabIndex = 3;
            this.BtnCambiar.Text = "Enviar";
            this.BtnCambiar.UseVisualStyleBackColor = false;
            this.BtnCambiar.Click += new System.EventHandler(this.BtnCambiar_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel2.Controls.Add(this.BtnBajarHor, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnSubirHor, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.TxtHorizontal, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(41, 267);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(685, 54);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // BtnBajarHor
            // 
            this.BtnBajarHor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.BtnBajarHor.BackGroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.BtnBajarHor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.BtnBajarHor.BorderRadius = 16;
            this.BtnBajarHor.BorderSize = 0;
            this.BtnBajarHor.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnBajarHor.FlatAppearance.BorderSize = 0;
            this.BtnBajarHor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBajarHor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBajarHor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.BtnBajarHor.Image = global::CambioHorVerZebra411.Properties.Resources.icons8flechaabajo26;
            this.BtnBajarHor.Location = new System.Drawing.Point(241, 3);
            this.BtnBajarHor.Name = "BtnBajarHor";
            this.BtnBajarHor.Size = new System.Drawing.Size(48, 48);
            this.BtnBajarHor.TabIndex = 11;
            this.BtnBajarHor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.BtnBajarHor.UseVisualStyleBackColor = false;
            this.BtnBajarHor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnBajarHor_MouseDown);
            this.BtnBajarHor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnBajarHor_MouseUp);
            // 
            // BtnSubirHor
            // 
            this.BtnSubirHor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.BtnSubirHor.BackGroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.BtnSubirHor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.BtnSubirHor.BorderRadius = 16;
            this.BtnSubirHor.BorderSize = 0;
            this.BtnSubirHor.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnSubirHor.FlatAppearance.BorderSize = 0;
            this.BtnSubirHor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubirHor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubirHor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.BtnSubirHor.Image = global::CambioHorVerZebra411.Properties.Resources.icons8flechaarriba26;
            this.BtnSubirHor.Location = new System.Drawing.Point(394, 3);
            this.BtnSubirHor.Name = "BtnSubirHor";
            this.BtnSubirHor.Size = new System.Drawing.Size(48, 48);
            this.BtnSubirHor.TabIndex = 9;
            this.BtnSubirHor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.BtnSubirHor.UseVisualStyleBackColor = false;
            this.BtnSubirHor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnSubirHor_MouseDown);
            this.BtnSubirHor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnSubirHor_MouseUp);
            // 
            // TxtHorizontal
            // 
            this.TxtHorizontal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.TxtHorizontal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.TxtHorizontal.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.TxtHorizontal.BorderSize = 2;
            this.TxtHorizontal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHorizontal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TxtHorizontal.Location = new System.Drawing.Point(296, 4);
            this.TxtHorizontal.Margin = new System.Windows.Forms.Padding(4);
            this.TxtHorizontal.Multiline = false;
            this.TxtHorizontal.Name = "TxtHorizontal";
            this.TxtHorizontal.Padding = new System.Windows.Forms.Padding(7);
            this.TxtHorizontal.PasswordChar = false;
            this.TxtHorizontal.ReadOnly = false;
            this.TxtHorizontal.SelectionLength = 0;
            this.TxtHorizontal.SelectionStart = 0;
            this.TxtHorizontal.Size = new System.Drawing.Size(91, 45);
            this.TxtHorizontal.TabIndex = 10;
            this.TxtHorizontal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtHorizontal.UnderLinesStyle = false;
            this.TxtHorizontal._TextChanged += new System.EventHandler(this.TxtHorizontal__TextChanged);
            this.TxtHorizontal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtHorizontal_KeyPress);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel3.Controls.Add(this.BtnBajarVer, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.BtnSubirVer, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.TxtVertical, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(41, 393);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(685, 60);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // BtnBajarVer
            // 
            this.BtnBajarVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.BtnBajarVer.BackGroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.BtnBajarVer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.BtnBajarVer.BorderRadius = 16;
            this.BtnBajarVer.BorderSize = 0;
            this.BtnBajarVer.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnBajarVer.FlatAppearance.BorderSize = 0;
            this.BtnBajarVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBajarVer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBajarVer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.BtnBajarVer.Image = global::CambioHorVerZebra411.Properties.Resources.icons8flechaabajo26;
            this.BtnBajarVer.Location = new System.Drawing.Point(241, 3);
            this.BtnBajarVer.Name = "BtnBajarVer";
            this.BtnBajarVer.Size = new System.Drawing.Size(48, 54);
            this.BtnBajarVer.TabIndex = 11;
            this.BtnBajarVer.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.BtnBajarVer.UseVisualStyleBackColor = false;
            this.BtnBajarVer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnBajarVer_MouseDown);
            this.BtnBajarVer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnBajarVer_MouseUp);
            // 
            // BtnSubirVer
            // 
            this.BtnSubirVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.BtnSubirVer.BackGroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.BtnSubirVer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.BtnSubirVer.BorderRadius = 16;
            this.BtnSubirVer.BorderSize = 0;
            this.BtnSubirVer.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnSubirVer.FlatAppearance.BorderSize = 0;
            this.BtnSubirVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubirVer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubirVer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.BtnSubirVer.Image = global::CambioHorVerZebra411.Properties.Resources.icons8flechaarriba26;
            this.BtnSubirVer.Location = new System.Drawing.Point(394, 3);
            this.BtnSubirVer.Name = "BtnSubirVer";
            this.BtnSubirVer.Size = new System.Drawing.Size(48, 54);
            this.BtnSubirVer.TabIndex = 9;
            this.BtnSubirVer.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.BtnSubirVer.UseVisualStyleBackColor = false;
            this.BtnSubirVer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnSubirVer_MouseDown);
            this.BtnSubirVer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnSubirVer_MouseUp);
            // 
            // TxtVertical
            // 
            this.TxtVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.TxtVertical.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.TxtVertical.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.TxtVertical.BorderSize = 2;
            this.TxtVertical.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVertical.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TxtVertical.Location = new System.Drawing.Point(296, 4);
            this.TxtVertical.Margin = new System.Windows.Forms.Padding(4);
            this.TxtVertical.Multiline = false;
            this.TxtVertical.Name = "TxtVertical";
            this.TxtVertical.Padding = new System.Windows.Forms.Padding(7);
            this.TxtVertical.PasswordChar = false;
            this.TxtVertical.ReadOnly = false;
            this.TxtVertical.SelectionLength = 0;
            this.TxtVertical.SelectionStart = 0;
            this.TxtVertical.Size = new System.Drawing.Size(91, 45);
            this.TxtVertical.TabIndex = 10;
            this.TxtVertical.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtVertical.UnderLinesStyle = false;
            this.TxtVertical._TextChanged += new System.EventHandler(this.TxtVertical__TextChanged);
            this.TxtVertical.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtVertical_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(321, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "Contraste";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel4.Controls.Add(this.BtnBajarContraste, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.BtnSubirContraste, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.TxtContraste, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(41, 135);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(685, 54);
            this.tableLayoutPanel4.TabIndex = 12;
            // 
            // BtnBajarContraste
            // 
            this.BtnBajarContraste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.BtnBajarContraste.BackGroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.BtnBajarContraste.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.BtnBajarContraste.BorderRadius = 16;
            this.BtnBajarContraste.BorderSize = 0;
            this.BtnBajarContraste.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnBajarContraste.FlatAppearance.BorderSize = 0;
            this.BtnBajarContraste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBajarContraste.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBajarContraste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.BtnBajarContraste.Image = global::CambioHorVerZebra411.Properties.Resources.icons8flechaabajo26;
            this.BtnBajarContraste.Location = new System.Drawing.Point(241, 3);
            this.BtnBajarContraste.Name = "BtnBajarContraste";
            this.BtnBajarContraste.Size = new System.Drawing.Size(48, 48);
            this.BtnBajarContraste.TabIndex = 11;
            this.BtnBajarContraste.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.BtnBajarContraste.UseVisualStyleBackColor = false;
            this.BtnBajarContraste.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnBajarContraste_MouseDown);
            this.BtnBajarContraste.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnBajarContraste_MouseUp);
            // 
            // BtnSubirContraste
            // 
            this.BtnSubirContraste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.BtnSubirContraste.BackGroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.BtnSubirContraste.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.BtnSubirContraste.BorderRadius = 16;
            this.BtnSubirContraste.BorderSize = 0;
            this.BtnSubirContraste.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnSubirContraste.FlatAppearance.BorderSize = 0;
            this.BtnSubirContraste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubirContraste.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubirContraste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.BtnSubirContraste.Image = global::CambioHorVerZebra411.Properties.Resources.icons8flechaarriba26;
            this.BtnSubirContraste.Location = new System.Drawing.Point(394, 3);
            this.BtnSubirContraste.Name = "BtnSubirContraste";
            this.BtnSubirContraste.Size = new System.Drawing.Size(48, 48);
            this.BtnSubirContraste.TabIndex = 9;
            this.BtnSubirContraste.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.BtnSubirContraste.UseVisualStyleBackColor = false;
            this.BtnSubirContraste.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnSubirContraste_MouseDown);
            this.BtnSubirContraste.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnSubirContraste_MouseUp);
            // 
            // TxtContraste
            // 
            this.TxtContraste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.TxtContraste.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.TxtContraste.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.TxtContraste.BorderSize = 2;
            this.TxtContraste.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContraste.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TxtContraste.Location = new System.Drawing.Point(296, 4);
            this.TxtContraste.Margin = new System.Windows.Forms.Padding(4);
            this.TxtContraste.Multiline = false;
            this.TxtContraste.Name = "TxtContraste";
            this.TxtContraste.Padding = new System.Windows.Forms.Padding(7);
            this.TxtContraste.PasswordChar = false;
            this.TxtContraste.ReadOnly = false;
            this.TxtContraste.SelectionLength = 0;
            this.TxtContraste.SelectionStart = 0;
            this.TxtContraste.Size = new System.Drawing.Size(91, 45);
            this.TxtContraste.TabIndex = 10;
            this.TxtContraste.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtContraste.UnderLinesStyle = false;
            this.TxtContraste._TextChanged += new System.EventHandler(this.TxtContraste__TextChanged);
            this.TxtContraste.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtContraste_KeyPress);
            // 
            // PrintDialog
            // 
            this.PrintDialog.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // TimerHorizontal
            // 
            this.TimerHorizontal.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // TimerVertical
            // 
            this.TimerVertical.Tick += new System.EventHandler(this.TimerVertical_Tick);
            // 
            // TimerContraste
            // 
            this.TimerContraste.Tick += new System.EventHandler(this.TimerContraste_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(784, 540);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nicos92 Zebra ZT-411";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCambiar;
        private System.Windows.Forms.PrintDialog PrintDialog;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Controles.NSButton BtnSubirHor;
        private Controles.NSTextBox TxtHorizontal;
        private Controles.NSButton BtnBajarHor;
        private System.Windows.Forms.Timer TimerHorizontal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Controles.NSButton BtnBajarVer;
        private Controles.NSButton BtnSubirVer;
        private Controles.NSTextBox TxtVertical;
        private System.Windows.Forms.Timer TimerVertical;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Controles.NSButton BtnBajarContraste;
        private Controles.NSButton BtnSubirContraste;
        private Controles.NSTextBox TxtContraste;
        private System.Windows.Forms.Timer TimerContraste;
    }
}

