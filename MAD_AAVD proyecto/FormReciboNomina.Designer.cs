namespace MAD_AAVD_proyecto
{
    partial class FormReciboNomina
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.RECIBO_DGV_Percepciones = new System.Windows.Forms.DataGridView();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RECIBO_DGV_Deducciones = new System.Windows.Forms.DataGridView();
            this.Clave2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RECIBO_DTP_Fecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RECIBO_TXT_NombreEmpresa = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.RECIBO_TB_NombreEmp = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.RECIBO_TB_IdRecibo = new System.Windows.Forms.Label();
            this.RECIBO_TB_PeriodoPago = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.RECIBO_TB_FechaPago = new System.Windows.Forms.Label();
            this.RECIBO_TB_Imss = new System.Windows.Forms.Label();
            this.RECIBO_TB_Curp = new System.Windows.Forms.Label();
            this.RECIBO_TB_Rfc = new System.Windows.Forms.Label();
            this.RECIBO_TXT_RFC = new System.Windows.Forms.Label();
            this.RECIBO_TB_NoEmp = new System.Windows.Forms.Label();
            this.RECIBO_TB_Puesto = new System.Windows.Forms.Label();
            this.RECIBO_TB_Departamento = new System.Windows.Forms.Label();
            this.RECIBO_TB_DiasTrabajados = new System.Windows.Forms.Label();
            this.RECIBO_TB_SalarioDiario = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.RECIBO_TB_FechaAlta = new System.Windows.Forms.Label();
            this.RECIBO_TXT_RegistroPatronal = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.RECIBO_TXT_DomicilioFiscal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RECIBO_TXT_NoTel = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.RECIBO_TXT_Email = new System.Windows.Forms.Label();
            this.RECIBO_TB_Total = new System.Windows.Forms.Label();
            this.RECIBO_TB_TotalLetra = new System.Windows.Forms.Label();
            this.RECIBO_BTN_Aplicar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RECIBO_DGV_Percepciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RECIBO_DGV_Deducciones)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Recibo de nómina";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RECIBO_DGV_Percepciones
            // 
            this.RECIBO_DGV_Percepciones.AllowUserToAddRows = false;
            this.RECIBO_DGV_Percepciones.AllowUserToDeleteRows = false;
            this.RECIBO_DGV_Percepciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RECIBO_DGV_Percepciones.BackgroundColor = System.Drawing.Color.Black;
            this.RECIBO_DGV_Percepciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RECIBO_DGV_Percepciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clave,
            this.Concepto,
            this.Importe});
            this.RECIBO_DGV_Percepciones.Location = new System.Drawing.Point(22, 397);
            this.RECIBO_DGV_Percepciones.Name = "RECIBO_DGV_Percepciones";
            this.RECIBO_DGV_Percepciones.ReadOnly = true;
            this.RECIBO_DGV_Percepciones.RowHeadersWidth = 51;
            this.RECIBO_DGV_Percepciones.Size = new System.Drawing.Size(446, 155);
            this.RECIBO_DGV_Percepciones.TabIndex = 4;
            this.RECIBO_DGV_Percepciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RECIBO_DGV_Percepciones_CellContentClick);
            // 
            // Clave
            // 
            this.Clave.HeaderText = "Clave";
            this.Clave.MinimumWidth = 6;
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            // 
            // Concepto
            // 
            this.Concepto.HeaderText = "Concepto";
            this.Concepto.MinimumWidth = 6;
            this.Concepto.Name = "Concepto";
            this.Concepto.ReadOnly = true;
            // 
            // Importe
            // 
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.Importe.DefaultCellStyle = dataGridViewCellStyle7;
            this.Importe.HeaderText = "Importe";
            this.Importe.MinimumWidth = 6;
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // RECIBO_DGV_Deducciones
            // 
            this.RECIBO_DGV_Deducciones.AllowUserToAddRows = false;
            this.RECIBO_DGV_Deducciones.AllowUserToDeleteRows = false;
            this.RECIBO_DGV_Deducciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RECIBO_DGV_Deducciones.BackgroundColor = System.Drawing.Color.Black;
            this.RECIBO_DGV_Deducciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RECIBO_DGV_Deducciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clave2,
            this.Concepto2,
            this.Importe2});
            this.RECIBO_DGV_Deducciones.Location = new System.Drawing.Point(494, 397);
            this.RECIBO_DGV_Deducciones.Name = "RECIBO_DGV_Deducciones";
            this.RECIBO_DGV_Deducciones.ReadOnly = true;
            this.RECIBO_DGV_Deducciones.RowHeadersWidth = 51;
            this.RECIBO_DGV_Deducciones.Size = new System.Drawing.Size(446, 155);
            this.RECIBO_DGV_Deducciones.TabIndex = 5;
            // 
            // Clave2
            // 
            this.Clave2.HeaderText = "Clave";
            this.Clave2.MinimumWidth = 6;
            this.Clave2.Name = "Clave2";
            this.Clave2.ReadOnly = true;
            // 
            // Concepto2
            // 
            this.Concepto2.HeaderText = "Concepto";
            this.Concepto2.MinimumWidth = 6;
            this.Concepto2.Name = "Concepto2";
            this.Concepto2.ReadOnly = true;
            // 
            // Importe2
            // 
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            this.Importe2.DefaultCellStyle = dataGridViewCellStyle8;
            this.Importe2.HeaderText = "Importe";
            this.Importe2.MinimumWidth = 6;
            this.Importe2.Name = "Importe2";
            this.Importe2.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(183, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 39;
            this.label2.Text = "Percepciones";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Location = new System.Drawing.Point(22, 379);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(446, 3);
            this.panel2.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(660, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 23);
            this.label3.TabIndex = 41;
            this.label3.Text = "Deducciones";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Location = new System.Drawing.Point(494, 379);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 3);
            this.panel1.TabIndex = 41;
            // 
            // RECIBO_DTP_Fecha
            // 
            this.RECIBO_DTP_Fecha.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.RECIBO_DTP_Fecha.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.RECIBO_DTP_Fecha.CustomFormat = "MM/yyyy";
            this.RECIBO_DTP_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.RECIBO_DTP_Fecha.Location = new System.Drawing.Point(400, 83);
            this.RECIBO_DTP_Fecha.Name = "RECIBO_DTP_Fecha";
            this.RECIBO_DTP_Fecha.Size = new System.Drawing.Size(83, 20);
            this.RECIBO_DTP_Fecha.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(240, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 20);
            this.label4.TabIndex = 70;
            this.label4.Text = "Recibo de la fecha:";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Location = new System.Drawing.Point(0, 125);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(982, 3);
            this.panel3.TabIndex = 72;
            // 
            // RECIBO_TXT_NombreEmpresa
            // 
            this.RECIBO_TXT_NombreEmpresa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RECIBO_TXT_NombreEmpresa.AutoSize = true;
            this.RECIBO_TXT_NombreEmpresa.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RECIBO_TXT_NombreEmpresa.ForeColor = System.Drawing.Color.AliceBlue;
            this.RECIBO_TXT_NombreEmpresa.Location = new System.Drawing.Point(26, 136);
            this.RECIBO_TXT_NombreEmpresa.Name = "RECIBO_TXT_NombreEmpresa";
            this.RECIBO_TXT_NombreEmpresa.Size = new System.Drawing.Size(15, 23);
            this.RECIBO_TXT_NombreEmpresa.TabIndex = 73;
            this.RECIBO_TXT_NombreEmpresa.Text = " ";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightBlue;
            this.label6.Location = new System.Drawing.Point(584, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 19);
            this.label6.TabIndex = 74;
            this.label6.Text = "RFC:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.AliceBlue;
            this.label7.Location = new System.Drawing.Point(364, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 19);
            this.label7.TabIndex = 75;
            this.label7.Text = "Fecha de pago:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DodgerBlue;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.AliceBlue;
            this.label8.Location = new System.Drawing.Point(634, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 19);
            this.label8.TabIndex = 76;
            this.label8.Text = "Periodo de pago:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.AliceBlue;
            this.label9.Location = new System.Drawing.Point(430, 415);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 19);
            this.label9.TabIndex = 77;
            // 
            // RECIBO_TB_NombreEmp
            // 
            this.RECIBO_TB_NombreEmp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RECIBO_TB_NombreEmp.AutoSize = true;
            this.RECIBO_TB_NombreEmp.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RECIBO_TB_NombreEmp.ForeColor = System.Drawing.Color.AliceBlue;
            this.RECIBO_TB_NombreEmp.Location = new System.Drawing.Point(27, 230);
            this.RECIBO_TB_NombreEmp.Name = "RECIBO_TB_NombreEmp";
            this.RECIBO_TB_NombreEmp.Size = new System.Drawing.Size(10, 16);
            this.RECIBO_TB_NombreEmp.TabIndex = 78;
            this.RECIBO_TB_NombreEmp.Text = " ";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.LightBlue;
            this.label11.Location = new System.Drawing.Point(292, 230);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 16);
            this.label11.TabIndex = 79;
            this.label11.Text = "IMSS:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.LightBlue;
            this.label12.Location = new System.Drawing.Point(527, 230);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 16);
            this.label12.TabIndex = 80;
            this.label12.Text = "CURP:";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.LightBlue;
            this.label13.Location = new System.Drawing.Point(756, 230);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 16);
            this.label13.TabIndex = 81;
            this.label13.Text = "RFC:";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.LightBlue;
            this.label14.Location = new System.Drawing.Point(27, 280);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 16);
            this.label14.TabIndex = 82;
            this.label14.Text = "No. Empleado:";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.LightBlue;
            this.label15.Location = new System.Drawing.Point(292, 280);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 16);
            this.label15.TabIndex = 83;
            this.label15.Text = "Puesto:";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.LightBlue;
            this.label16.Location = new System.Drawing.Point(527, 280);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 16);
            this.label16.TabIndex = 84;
            this.label16.Text = "Departamento:";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.LightBlue;
            this.label17.Location = new System.Drawing.Point(27, 326);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(153, 16);
            this.label17.TabIndex = 85;
            this.label17.Text = "Días trabajados pagados:";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.LightBlue;
            this.label18.Location = new System.Drawing.Point(292, 326);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(146, 16);
            this.label18.TabIndex = 86;
            this.label18.Text = "Salario diario integrado:";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.Color.LightBlue;
            this.label19.Location = new System.Drawing.Point(527, 326);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(86, 16);
            this.label19.TabIndex = 87;
            this.label19.Text = "Fecha de alta:";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Location = new System.Drawing.Point(0, 575);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(982, 3);
            this.panel4.TabIndex = 41;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.LightBlue;
            this.label20.Location = new System.Drawing.Point(220, 595);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(48, 19);
            this.label20.TabIndex = 88;
            this.label20.Text = "Total:";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel5.Controls.Add(this.RECIBO_TB_IdRecibo);
            this.panel5.Controls.Add(this.RECIBO_TB_PeriodoPago);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label22);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.RECIBO_TB_FechaPago);
            this.panel5.Location = new System.Drawing.Point(0, 180);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(982, 34);
            this.panel5.TabIndex = 73;
            // 
            // RECIBO_TB_IdRecibo
            // 
            this.RECIBO_TB_IdRecibo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RECIBO_TB_IdRecibo.AutoSize = true;
            this.RECIBO_TB_IdRecibo.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RECIBO_TB_IdRecibo.ForeColor = System.Drawing.Color.AliceBlue;
            this.RECIBO_TB_IdRecibo.Location = new System.Drawing.Point(40, 10);
            this.RECIBO_TB_IdRecibo.Name = "RECIBO_TB_IdRecibo";
            this.RECIBO_TB_IdRecibo.Size = new System.Drawing.Size(10, 16);
            this.RECIBO_TB_IdRecibo.TabIndex = 105;
            this.RECIBO_TB_IdRecibo.Text = " ";
            // 
            // RECIBO_TB_PeriodoPago
            // 
            this.RECIBO_TB_PeriodoPago.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RECIBO_TB_PeriodoPago.AutoSize = true;
            this.RECIBO_TB_PeriodoPago.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RECIBO_TB_PeriodoPago.ForeColor = System.Drawing.Color.AliceBlue;
            this.RECIBO_TB_PeriodoPago.Location = new System.Drawing.Point(759, 10);
            this.RECIBO_TB_PeriodoPago.Name = "RECIBO_TB_PeriodoPago";
            this.RECIBO_TB_PeriodoPago.Size = new System.Drawing.Size(10, 16);
            this.RECIBO_TB_PeriodoPago.TabIndex = 104;
            this.RECIBO_TB_PeriodoPago.Text = " ";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.DodgerBlue;
            this.label22.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.AliceBlue;
            this.label22.Location = new System.Drawing.Point(10, 7);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(32, 19);
            this.label22.TabIndex = 90;
            this.label22.Text = "ID: ";
            // 
            // RECIBO_TB_FechaPago
            // 
            this.RECIBO_TB_FechaPago.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RECIBO_TB_FechaPago.AutoSize = true;
            this.RECIBO_TB_FechaPago.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RECIBO_TB_FechaPago.ForeColor = System.Drawing.Color.AliceBlue;
            this.RECIBO_TB_FechaPago.Location = new System.Drawing.Point(484, 10);
            this.RECIBO_TB_FechaPago.Name = "RECIBO_TB_FechaPago";
            this.RECIBO_TB_FechaPago.Size = new System.Drawing.Size(10, 16);
            this.RECIBO_TB_FechaPago.TabIndex = 103;
            this.RECIBO_TB_FechaPago.Text = " ";
            // 
            // RECIBO_TB_Imss
            // 
            this.RECIBO_TB_Imss.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RECIBO_TB_Imss.AutoSize = true;
            this.RECIBO_TB_Imss.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RECIBO_TB_Imss.ForeColor = System.Drawing.Color.AliceBlue;
            this.RECIBO_TB_Imss.Location = new System.Drawing.Point(332, 230);
            this.RECIBO_TB_Imss.Name = "RECIBO_TB_Imss";
            this.RECIBO_TB_Imss.Size = new System.Drawing.Size(10, 16);
            this.RECIBO_TB_Imss.TabIndex = 91;
            this.RECIBO_TB_Imss.Text = " ";
            // 
            // RECIBO_TB_Curp
            // 
            this.RECIBO_TB_Curp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RECIBO_TB_Curp.AutoSize = true;
            this.RECIBO_TB_Curp.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RECIBO_TB_Curp.ForeColor = System.Drawing.Color.AliceBlue;
            this.RECIBO_TB_Curp.Location = new System.Drawing.Point(572, 230);
            this.RECIBO_TB_Curp.Name = "RECIBO_TB_Curp";
            this.RECIBO_TB_Curp.Size = new System.Drawing.Size(10, 16);
            this.RECIBO_TB_Curp.TabIndex = 92;
            this.RECIBO_TB_Curp.Text = " ";
            // 
            // RECIBO_TB_Rfc
            // 
            this.RECIBO_TB_Rfc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RECIBO_TB_Rfc.AutoSize = true;
            this.RECIBO_TB_Rfc.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RECIBO_TB_Rfc.ForeColor = System.Drawing.Color.AliceBlue;
            this.RECIBO_TB_Rfc.Location = new System.Drawing.Point(790, 230);
            this.RECIBO_TB_Rfc.Name = "RECIBO_TB_Rfc";
            this.RECIBO_TB_Rfc.Size = new System.Drawing.Size(10, 16);
            this.RECIBO_TB_Rfc.TabIndex = 93;
            this.RECIBO_TB_Rfc.Text = " ";
            // 
            // RECIBO_TXT_RFC
            // 
            this.RECIBO_TXT_RFC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RECIBO_TXT_RFC.AutoSize = true;
            this.RECIBO_TXT_RFC.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RECIBO_TXT_RFC.ForeColor = System.Drawing.Color.AliceBlue;
            this.RECIBO_TXT_RFC.Location = new System.Drawing.Point(554, 157);
            this.RECIBO_TXT_RFC.Name = "RECIBO_TXT_RFC";
            this.RECIBO_TXT_RFC.Size = new System.Drawing.Size(10, 16);
            this.RECIBO_TXT_RFC.TabIndex = 94;
            this.RECIBO_TXT_RFC.Text = " ";
            // 
            // RECIBO_TB_NoEmp
            // 
            this.RECIBO_TB_NoEmp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RECIBO_TB_NoEmp.AutoSize = true;
            this.RECIBO_TB_NoEmp.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RECIBO_TB_NoEmp.ForeColor = System.Drawing.Color.AliceBlue;
            this.RECIBO_TB_NoEmp.Location = new System.Drawing.Point(115, 280);
            this.RECIBO_TB_NoEmp.Name = "RECIBO_TB_NoEmp";
            this.RECIBO_TB_NoEmp.Size = new System.Drawing.Size(10, 16);
            this.RECIBO_TB_NoEmp.TabIndex = 95;
            this.RECIBO_TB_NoEmp.Text = " ";
            // 
            // RECIBO_TB_Puesto
            // 
            this.RECIBO_TB_Puesto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RECIBO_TB_Puesto.AutoSize = true;
            this.RECIBO_TB_Puesto.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RECIBO_TB_Puesto.ForeColor = System.Drawing.Color.AliceBlue;
            this.RECIBO_TB_Puesto.Location = new System.Drawing.Point(342, 280);
            this.RECIBO_TB_Puesto.Name = "RECIBO_TB_Puesto";
            this.RECIBO_TB_Puesto.Size = new System.Drawing.Size(10, 16);
            this.RECIBO_TB_Puesto.TabIndex = 96;
            this.RECIBO_TB_Puesto.Text = " ";
            // 
            // RECIBO_TB_Departamento
            // 
            this.RECIBO_TB_Departamento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RECIBO_TB_Departamento.AutoSize = true;
            this.RECIBO_TB_Departamento.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RECIBO_TB_Departamento.ForeColor = System.Drawing.Color.AliceBlue;
            this.RECIBO_TB_Departamento.Location = new System.Drawing.Point(618, 280);
            this.RECIBO_TB_Departamento.Name = "RECIBO_TB_Departamento";
            this.RECIBO_TB_Departamento.Size = new System.Drawing.Size(10, 16);
            this.RECIBO_TB_Departamento.TabIndex = 97;
            this.RECIBO_TB_Departamento.Text = " ";
            // 
            // RECIBO_TB_DiasTrabajados
            // 
            this.RECIBO_TB_DiasTrabajados.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RECIBO_TB_DiasTrabajados.AutoSize = true;
            this.RECIBO_TB_DiasTrabajados.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RECIBO_TB_DiasTrabajados.ForeColor = System.Drawing.Color.AliceBlue;
            this.RECIBO_TB_DiasTrabajados.Location = new System.Drawing.Point(176, 326);
            this.RECIBO_TB_DiasTrabajados.Name = "RECIBO_TB_DiasTrabajados";
            this.RECIBO_TB_DiasTrabajados.Size = new System.Drawing.Size(10, 16);
            this.RECIBO_TB_DiasTrabajados.TabIndex = 98;
            this.RECIBO_TB_DiasTrabajados.Text = " ";
            // 
            // RECIBO_TB_SalarioDiario
            // 
            this.RECIBO_TB_SalarioDiario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RECIBO_TB_SalarioDiario.AutoSize = true;
            this.RECIBO_TB_SalarioDiario.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RECIBO_TB_SalarioDiario.ForeColor = System.Drawing.Color.AliceBlue;
            this.RECIBO_TB_SalarioDiario.Location = new System.Drawing.Point(436, 326);
            this.RECIBO_TB_SalarioDiario.Name = "RECIBO_TB_SalarioDiario";
            this.RECIBO_TB_SalarioDiario.Size = new System.Drawing.Size(10, 16);
            this.RECIBO_TB_SalarioDiario.TabIndex = 99;
            this.RECIBO_TB_SalarioDiario.Text = " ";
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel7.Location = new System.Drawing.Point(0, 260);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(982, 2);
            this.panel7.TabIndex = 75;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel8.Location = new System.Drawing.Point(-9, 309);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(982, 2);
            this.panel8.TabIndex = 100;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel9.Location = new System.Drawing.Point(0, 355);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(982, 2);
            this.panel9.TabIndex = 101;
            // 
            // RECIBO_TB_FechaAlta
            // 
            this.RECIBO_TB_FechaAlta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RECIBO_TB_FechaAlta.AutoSize = true;
            this.RECIBO_TB_FechaAlta.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RECIBO_TB_FechaAlta.ForeColor = System.Drawing.Color.AliceBlue;
            this.RECIBO_TB_FechaAlta.Location = new System.Drawing.Point(614, 326);
            this.RECIBO_TB_FechaAlta.Name = "RECIBO_TB_FechaAlta";
            this.RECIBO_TB_FechaAlta.Size = new System.Drawing.Size(10, 16);
            this.RECIBO_TB_FechaAlta.TabIndex = 102;
            this.RECIBO_TB_FechaAlta.Text = " ";
            // 
            // RECIBO_TXT_RegistroPatronal
            // 
            this.RECIBO_TXT_RegistroPatronal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RECIBO_TXT_RegistroPatronal.AutoSize = true;
            this.RECIBO_TXT_RegistroPatronal.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RECIBO_TXT_RegistroPatronal.ForeColor = System.Drawing.Color.AliceBlue;
            this.RECIBO_TXT_RegistroPatronal.Location = new System.Drawing.Point(447, 157);
            this.RECIBO_TXT_RegistroPatronal.Name = "RECIBO_TXT_RegistroPatronal";
            this.RECIBO_TXT_RegistroPatronal.Size = new System.Drawing.Size(10, 16);
            this.RECIBO_TXT_RegistroPatronal.TabIndex = 105;
            this.RECIBO_TXT_RegistroPatronal.Text = " ";
            // 
            // label36
            // 
            this.label36.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.LightBlue;
            this.label36.Location = new System.Drawing.Point(398, 136);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(140, 19);
            this.label36.TabIndex = 104;
            this.label36.Text = "Registro patronal:";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.LightBlue;
            this.label21.Location = new System.Drawing.Point(660, 591);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(117, 19);
            this.label21.TabIndex = 107;
            this.label21.Text = "Total con letra:";
            // 
            // RECIBO_TXT_DomicilioFiscal
            // 
            this.RECIBO_TXT_DomicilioFiscal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RECIBO_TXT_DomicilioFiscal.AutoSize = true;
            this.RECIBO_TXT_DomicilioFiscal.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RECIBO_TXT_DomicilioFiscal.ForeColor = System.Drawing.Color.AliceBlue;
            this.RECIBO_TXT_DomicilioFiscal.Location = new System.Drawing.Point(28, 161);
            this.RECIBO_TXT_DomicilioFiscal.Name = "RECIBO_TXT_DomicilioFiscal";
            this.RECIBO_TXT_DomicilioFiscal.Size = new System.Drawing.Size(10, 13);
            this.RECIBO_TXT_DomicilioFiscal.TabIndex = 109;
            this.RECIBO_TXT_DomicilioFiscal.Text = " ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightBlue;
            this.label5.Location = new System.Drawing.Point(695, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 19);
            this.label5.TabIndex = 110;
            this.label5.Text = "No. Telefónico:";
            // 
            // RECIBO_TXT_NoTel
            // 
            this.RECIBO_TXT_NoTel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RECIBO_TXT_NoTel.AutoSize = true;
            this.RECIBO_TXT_NoTel.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RECIBO_TXT_NoTel.ForeColor = System.Drawing.Color.AliceBlue;
            this.RECIBO_TXT_NoTel.Location = new System.Drawing.Point(812, 136);
            this.RECIBO_TXT_NoTel.Name = "RECIBO_TXT_NoTel";
            this.RECIBO_TXT_NoTel.Size = new System.Drawing.Size(10, 16);
            this.RECIBO_TXT_NoTel.TabIndex = 111;
            this.RECIBO_TXT_NoTel.Text = " ";
            // 
            // label35
            // 
            this.label35.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.LightBlue;
            this.label35.Location = new System.Drawing.Point(696, 155);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(54, 19);
            this.label35.TabIndex = 112;
            this.label35.Text = "email:";
            // 
            // RECIBO_TXT_Email
            // 
            this.RECIBO_TXT_Email.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RECIBO_TXT_Email.AutoSize = true;
            this.RECIBO_TXT_Email.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RECIBO_TXT_Email.ForeColor = System.Drawing.Color.AliceBlue;
            this.RECIBO_TXT_Email.Location = new System.Drawing.Point(756, 157);
            this.RECIBO_TXT_Email.Name = "RECIBO_TXT_Email";
            this.RECIBO_TXT_Email.Size = new System.Drawing.Size(10, 16);
            this.RECIBO_TXT_Email.TabIndex = 113;
            this.RECIBO_TXT_Email.Text = " ";
            // 
            // RECIBO_TB_Total
            // 
            this.RECIBO_TB_Total.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RECIBO_TB_Total.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RECIBO_TB_Total.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RECIBO_TB_Total.ForeColor = System.Drawing.Color.AliceBlue;
            this.RECIBO_TB_Total.Location = new System.Drawing.Point(155, 622);
            this.RECIBO_TB_Total.Name = "RECIBO_TB_Total";
            this.RECIBO_TB_Total.Size = new System.Drawing.Size(172, 17);
            this.RECIBO_TB_Total.TabIndex = 114;
            this.RECIBO_TB_Total.Text = " ";
            this.RECIBO_TB_Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RECIBO_TB_TotalLetra
            // 
            this.RECIBO_TB_TotalLetra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RECIBO_TB_TotalLetra.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RECIBO_TB_TotalLetra.ForeColor = System.Drawing.Color.AliceBlue;
            this.RECIBO_TB_TotalLetra.Location = new System.Drawing.Point(575, 622);
            this.RECIBO_TB_TotalLetra.Name = "RECIBO_TB_TotalLetra";
            this.RECIBO_TB_TotalLetra.Size = new System.Drawing.Size(271, 17);
            this.RECIBO_TB_TotalLetra.TabIndex = 115;
            this.RECIBO_TB_TotalLetra.Text = " ";
            this.RECIBO_TB_TotalLetra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RECIBO_BTN_Aplicar
            // 
            this.RECIBO_BTN_Aplicar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.RECIBO_BTN_Aplicar.FlatAppearance.BorderSize = 0;
            this.RECIBO_BTN_Aplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RECIBO_BTN_Aplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RECIBO_BTN_Aplicar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RECIBO_BTN_Aplicar.Location = new System.Drawing.Point(504, 79);
            this.RECIBO_BTN_Aplicar.Name = "RECIBO_BTN_Aplicar";
            this.RECIBO_BTN_Aplicar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RECIBO_BTN_Aplicar.Size = new System.Drawing.Size(98, 28);
            this.RECIBO_BTN_Aplicar.TabIndex = 116;
            this.RECIBO_BTN_Aplicar.Text = "Aplicar";
            this.RECIBO_BTN_Aplicar.UseVisualStyleBackColor = false;
            this.RECIBO_BTN_Aplicar.Click += new System.EventHandler(this.RECIBO_BTN_Aplicar_Click);
            // 
            // FormReciboNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(965, 640);
            this.Controls.Add(this.RECIBO_BTN_Aplicar);
            this.Controls.Add(this.RECIBO_TB_TotalLetra);
            this.Controls.Add(this.RECIBO_TB_Total);
            this.Controls.Add(this.RECIBO_TXT_Email);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.RECIBO_TXT_NoTel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RECIBO_TXT_DomicilioFiscal);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.RECIBO_TXT_RegistroPatronal);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.RECIBO_TB_FechaAlta);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.RECIBO_TB_SalarioDiario);
            this.Controls.Add(this.RECIBO_TB_DiasTrabajados);
            this.Controls.Add(this.RECIBO_TB_Departamento);
            this.Controls.Add(this.RECIBO_TB_Puesto);
            this.Controls.Add(this.RECIBO_TB_NoEmp);
            this.Controls.Add(this.RECIBO_TXT_RFC);
            this.Controls.Add(this.RECIBO_TB_Rfc);
            this.Controls.Add(this.RECIBO_TB_Curp);
            this.Controls.Add(this.RECIBO_TB_Imss);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.RECIBO_TB_NombreEmp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RECIBO_TXT_NombreEmpresa);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.RECIBO_DTP_Fecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.RECIBO_DGV_Deducciones);
            this.Controls.Add(this.RECIBO_DGV_Percepciones);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReciboNomina";
            this.Text = "FormReciboNomina";
            this.Load += new System.EventHandler(this.FormReciboNomina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RECIBO_DGV_Percepciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RECIBO_DGV_Deducciones)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView RECIBO_DGV_Percepciones;
        private System.Windows.Forms.DataGridView RECIBO_DGV_Deducciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker RECIBO_DTP_Fecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label RECIBO_TXT_NombreEmpresa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label RECIBO_TB_NombreEmp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label RECIBO_TB_Imss;
        private System.Windows.Forms.Label RECIBO_TB_Curp;
        private System.Windows.Forms.Label RECIBO_TB_Rfc;
        private System.Windows.Forms.Label RECIBO_TXT_RFC;
        private System.Windows.Forms.Label RECIBO_TB_NoEmp;
        private System.Windows.Forms.Label RECIBO_TB_Puesto;
        private System.Windows.Forms.Label RECIBO_TB_Departamento;
        private System.Windows.Forms.Label RECIBO_TB_DiasTrabajados;
        private System.Windows.Forms.Label RECIBO_TB_SalarioDiario;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label RECIBO_TB_PeriodoPago;
        private System.Windows.Forms.Label RECIBO_TB_FechaAlta;
        private System.Windows.Forms.Label RECIBO_TB_FechaPago;
        private System.Windows.Forms.Label RECIBO_TXT_RegistroPatronal;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label RECIBO_TXT_DomicilioFiscal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label RECIBO_TXT_NoTel;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label RECIBO_TXT_Email;
        private System.Windows.Forms.Label RECIBO_TB_Total;
        private System.Windows.Forms.Label RECIBO_TB_TotalLetra;
        private System.Windows.Forms.Button RECIBO_BTN_Aplicar;
        private System.Windows.Forms.Label RECIBO_TB_IdRecibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe2;
    }
}