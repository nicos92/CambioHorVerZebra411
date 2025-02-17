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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCambiar = new System.Windows.Forms.Button();
            this.LblHorizontal = new System.Windows.Forms.Label();
            this.LblVertical = new System.Windows.Forms.Label();
            this.TrackBarHorizontal = new System.Windows.Forms.TrackBar();
            this.TrackBarVertical = new System.Windows.Forms.TrackBar();
            this.PrintDialog = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarHorizontal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarVertical)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.LblTitulo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.BtnCambiar, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.LblHorizontal, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.LblVertical, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.TrackBarHorizontal, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TrackBarVertical, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(768, 445);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // LblTitulo
            // 
            this.LblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblTitulo.Location = new System.Drawing.Point(294, 11);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(178, 32);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "ZEBRA ZT-411";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(153, 66);
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
            this.label2.Location = new System.Drawing.Point(170, 231);
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
            this.BtnCambiar.Location = new System.Drawing.Point(319, 385);
            this.BtnCambiar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCambiar.Name = "BtnCambiar";
            this.BtnCambiar.Size = new System.Drawing.Size(128, 60);
            this.BtnCambiar.TabIndex = 3;
            this.BtnCambiar.Text = "Enviar";
            this.BtnCambiar.UseVisualStyleBackColor = false;
            this.BtnCambiar.Click += new System.EventHandler(this.BtnCambiar_Click);
            // 
            // LblHorizontal
            // 
            this.LblHorizontal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblHorizontal.AutoSize = true;
            this.LblHorizontal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHorizontal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblHorizontal.Location = new System.Drawing.Point(299, 121);
            this.LblHorizontal.Name = "LblHorizontal";
            this.LblHorizontal.Size = new System.Drawing.Size(169, 32);
            this.LblHorizontal.TabIndex = 4;
            this.LblHorizontal.Text = "LblHorizontal";
            // 
            // LblVertical
            // 
            this.LblVertical.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblVertical.AutoSize = true;
            this.LblVertical.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVertical.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblVertical.Location = new System.Drawing.Point(316, 286);
            this.LblVertical.Name = "LblVertical";
            this.LblVertical.Size = new System.Drawing.Size(134, 32);
            this.LblVertical.TabIndex = 5;
            this.LblVertical.Text = "LblVertical";
            // 
            // TrackBarHorizontal
            // 
            this.TrackBarHorizontal.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.TrackBarHorizontal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrackBarHorizontal.Location = new System.Drawing.Point(46, 173);
            this.TrackBarHorizontal.Margin = new System.Windows.Forms.Padding(8);
            this.TrackBarHorizontal.Maximum = 100;
            this.TrackBarHorizontal.Minimum = -100;
            this.TrackBarHorizontal.Name = "TrackBarHorizontal";
            this.TrackBarHorizontal.Size = new System.Drawing.Size(675, 39);
            this.TrackBarHorizontal.TabIndex = 6;
            this.TrackBarHorizontal.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.TrackBarHorizontal.Scroll += new System.EventHandler(this.TrackBarHorizontal_Scroll);
            // 
            // TrackBarVertical
            // 
            this.TrackBarVertical.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.TrackBarVertical.Location = new System.Drawing.Point(46, 338);
            this.TrackBarVertical.Margin = new System.Windows.Forms.Padding(8);
            this.TrackBarVertical.Maximum = 100;
            this.TrackBarVertical.Minimum = -100;
            this.TrackBarVertical.Name = "TrackBarVertical";
            this.TrackBarVertical.Size = new System.Drawing.Size(675, 39);
            this.TrackBarVertical.TabIndex = 7;
            this.TrackBarVertical.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.TrackBarVertical.Scroll += new System.EventHandler(this.TrackBarVertical_Scroll);
            // 
            // PrintDialog
            // 
            this.PrintDialog.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nicos92 Zebra ZT-411";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarHorizontal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarVertical)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCambiar;
        private System.Windows.Forms.Label LblHorizontal;
        private System.Windows.Forms.Label LblVertical;
        private System.Windows.Forms.TrackBar TrackBarHorizontal;
        private System.Windows.Forms.TrackBar TrackBarVertical;
        private System.Windows.Forms.PrintDialog PrintDialog;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

