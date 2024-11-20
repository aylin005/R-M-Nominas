namespace MAD_AAVD_proyecto
{
    partial class FormEmployReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.HDCOUNTER_Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RGN_BTN_Filtrar = new System.Windows.Forms.Button();
            this.RGN_DTP_FiltroFecha = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.RGN_LBL_Loading = new System.Windows.Forms.Label();
            this.RGN_DGV_Reporte = new System.Windows.Forms.DataGridView();
            this.noEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalarioDiario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RGN_DGV_Reporte)).BeginInit();
            this.SuspendLayout();
            // 
            // HDCOUNTER_Title
            // 
            this.HDCOUNTER_Title.Location = new System.Drawing.Point(0, 0);
            this.HDCOUNTER_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HDCOUNTER_Title.Name = "HDCOUNTER_Title";
            this.HDCOUNTER_Title.Size = new System.Drawing.Size(119, 22);
            this.HDCOUNTER_Title.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(588, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(608, 57);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reporte General de Nómina";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(-3, 193);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1749, 2);
            this.panel2.TabIndex = 67;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Controls.Add(this.panel12);
            this.panel7.Location = new System.Drawing.Point(0, -25);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1749, 2);
            this.panel7.TabIndex = 70;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1749, 2);
            this.panel8.TabIndex = 69;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel9.Location = new System.Drawing.Point(0, 273);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1749, 2);
            this.panel9.TabIndex = 40;
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Location = new System.Drawing.Point(0, -74);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1749, 2);
            this.panel10.TabIndex = 68;
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel11.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel11.Location = new System.Drawing.Point(0, 273);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1749, 2);
            this.panel11.TabIndex = 40;
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel12.Location = new System.Drawing.Point(0, 273);
            this.panel12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1749, 2);
            this.panel12.TabIndex = 40;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1749, 2);
            this.panel5.TabIndex = 69;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel6.Location = new System.Drawing.Point(0, 273);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1749, 2);
            this.panel6.TabIndex = 40;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(0, -74);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1749, 2);
            this.panel3.TabIndex = 68;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Location = new System.Drawing.Point(0, 273);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1749, 2);
            this.panel4.TabIndex = 40;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Location = new System.Drawing.Point(0, 273);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1749, 2);
            this.panel1.TabIndex = 40;
            // 
            // RGN_BTN_Filtrar
            // 
            this.RGN_BTN_Filtrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RGN_BTN_Filtrar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.RGN_BTN_Filtrar.FlatAppearance.BorderSize = 0;
            this.RGN_BTN_Filtrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RGN_BTN_Filtrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RGN_BTN_Filtrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RGN_BTN_Filtrar.Location = new System.Drawing.Point(981, 129);
            this.RGN_BTN_Filtrar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.RGN_BTN_Filtrar.Name = "RGN_BTN_Filtrar";
            this.RGN_BTN_Filtrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RGN_BTN_Filtrar.Size = new System.Drawing.Size(133, 41);
            this.RGN_BTN_Filtrar.TabIndex = 68;
            this.RGN_BTN_Filtrar.Text = "Filtrar";
            this.RGN_BTN_Filtrar.UseVisualStyleBackColor = false;
            this.RGN_BTN_Filtrar.Click += new System.EventHandler(this.RGN_BTN_Filtrar_Click);
            // 
            // RGN_DTP_FiltroFecha
            // 
            this.RGN_DTP_FiltroFecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RGN_DTP_FiltroFecha.CustomFormat = "dd/MMM/yyyy";
            this.RGN_DTP_FiltroFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.RGN_DTP_FiltroFecha.Location = new System.Drawing.Point(780, 138);
            this.RGN_DTP_FiltroFecha.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.RGN_DTP_FiltroFecha.MaxDate = new System.DateTime(2080, 9, 22, 0, 0, 0, 0);
            this.RGN_DTP_FiltroFecha.MinDate = new System.DateTime(1924, 9, 22, 0, 0, 0, 0);
            this.RGN_DTP_FiltroFecha.Name = "RGN_DTP_FiltroFecha";
            this.RGN_DTP_FiltroFecha.Size = new System.Drawing.Size(168, 22);
            this.RGN_DTP_FiltroFecha.TabIndex = 70;
            this.RGN_DTP_FiltroFecha.Value = new System.DateTime(2024, 11, 14, 0, 0, 0, 0);
            this.RGN_DTP_FiltroFecha.ValueChanged += new System.EventHandler(this.RGN_DTP_FiltroFecha_ValueChanged);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.AliceBlue;
            this.button2.Location = new System.Drawing.Point(671, 128);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(91, 41);
            this.button2.TabIndex = 74;
            this.button2.Text = "Fecha:";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // RGN_LBL_Loading
            // 
            this.RGN_LBL_Loading.AutoSize = true;
            this.RGN_LBL_Loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RGN_LBL_Loading.ForeColor = System.Drawing.Color.SkyBlue;
            this.RGN_LBL_Loading.Location = new System.Drawing.Point(853, 95);
            this.RGN_LBL_Loading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RGN_LBL_Loading.Name = "RGN_LBL_Loading";
            this.RGN_LBL_Loading.Size = new System.Drawing.Size(82, 18);
            this.RGN_LBL_Loading.TabIndex = 109;
            this.RGN_LBL_Loading.Text = "Loading...";
            this.RGN_LBL_Loading.Visible = false;
            this.RGN_LBL_Loading.Click += new System.EventHandler(this.RGN_LBL_Loading_Click);
            // 
            // RGN_DGV_Reporte
            // 
            this.RGN_DGV_Reporte.AllowUserToAddRows = false;
            this.RGN_DGV_Reporte.AllowUserToDeleteRows = false;
            this.RGN_DGV_Reporte.AllowUserToOrderColumns = true;
            this.RGN_DGV_Reporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RGN_DGV_Reporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RGN_DGV_Reporte.BackgroundColor = System.Drawing.Color.Black;
            this.RGN_DGV_Reporte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RGN_DGV_Reporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.RGN_DGV_Reporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RGN_DGV_Reporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noEmp,
            this.Nombre,
            this.Departamento,
            this.Puesto,
            this.FechaIngreso,
            this.SalarioDiario,
            this.Edad});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RGN_DGV_Reporte.DefaultCellStyle = dataGridViewCellStyle6;
            this.RGN_DGV_Reporte.GridColor = System.Drawing.Color.DodgerBlue;
            this.RGN_DGV_Reporte.Location = new System.Drawing.Point(37, 220);
            this.RGN_DGV_Reporte.Margin = new System.Windows.Forms.Padding(0);
            this.RGN_DGV_Reporte.Name = "RGN_DGV_Reporte";
            this.RGN_DGV_Reporte.ReadOnly = true;
            this.RGN_DGV_Reporte.RowHeadersWidth = 51;
            this.RGN_DGV_Reporte.Size = new System.Drawing.Size(1659, 794);
            this.RGN_DGV_Reporte.TabIndex = 110;
            // 
            // noEmp
            // 
            this.noEmp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.noEmp.HeaderText = "No Empleado";
            this.noEmp.MinimumWidth = 6;
            this.noEmp.Name = "noEmp";
            this.noEmp.ReadOnly = true;
            this.noEmp.Width = 120;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 85;
            // 
            // Departamento
            // 
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.MinimumWidth = 6;
            this.Departamento.Name = "Departamento";
            this.Departamento.ReadOnly = true;
            // 
            // Puesto
            // 
            this.Puesto.HeaderText = "Puesto";
            this.Puesto.MinimumWidth = 6;
            this.Puesto.Name = "Puesto";
            this.Puesto.ReadOnly = true;
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.HeaderText = "Fecha Ingreso";
            this.FechaIngreso.MinimumWidth = 6;
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.ReadOnly = true;
            // 
            // SalarioDiario
            // 
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.SalarioDiario.DefaultCellStyle = dataGridViewCellStyle5;
            this.SalarioDiario.HeaderText = "Salario Diario";
            this.SalarioDiario.MinimumWidth = 6;
            this.SalarioDiario.Name = "SalarioDiario";
            this.SalarioDiario.ReadOnly = true;
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.MinimumWidth = 6;
            this.Edad.Name = "Edad";
            this.Edad.ReadOnly = true;
            // 
            // FormEmployReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(1747, 922);
            this.Controls.Add(this.RGN_DGV_Reporte);
            this.Controls.Add(this.RGN_LBL_Loading);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.RGN_DTP_FiltroFecha);
            this.Controls.Add(this.RGN_BTN_Filtrar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HDCOUNTER_Title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormEmployReport";
            this.Text = "FormEmployReport";
            this.Load += new System.EventHandler(this.FormEmployReport_Load);
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RGN_DGV_Reporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HDCOUNTER_Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RGN_BTN_Filtrar;
        private System.Windows.Forms.DateTimePicker RGN_DTP_FiltroFecha;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label RGN_LBL_Loading;
        private System.Windows.Forms.DataGridView RGN_DGV_Reporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn noEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalarioDiario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
    }
}