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
            this.label1 = new System.Windows.Forms.Label();
            this.RECIBO_DGV_Percepciones = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RECIBO_DGV_Deducciones = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GREPORTE_DTP_date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RECIBO_TXT_RazonSocial = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
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
            this.label34 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.RECIBO_TXT_RFC = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label32 = new System.Windows.Forms.Label();
            this.RECIBO_TXT_RegistroPatronal = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.RECIBO_TXT_DomicilioFiscal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RECIBO_TXT_NoTel = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.RECIBO_TXT_Email = new System.Windows.Forms.Label();
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
            // 
            // RECIBO_DGV_Percepciones
            // 
            this.RECIBO_DGV_Percepciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RECIBO_DGV_Percepciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RECIBO_DGV_Percepciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Concepto,
            this.Column2});
            this.RECIBO_DGV_Percepciones.Location = new System.Drawing.Point(22, 397);
            this.RECIBO_DGV_Percepciones.Name = "RECIBO_DGV_Percepciones";
            this.RECIBO_DGV_Percepciones.RowHeadersWidth = 51;
            this.RECIBO_DGV_Percepciones.Size = new System.Drawing.Size(446, 155);
            this.RECIBO_DGV_Percepciones.TabIndex = 4;
            this.RECIBO_DGV_Percepciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RECIBO_DGV_Percepciones_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Clave";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Concepto
            // 
            this.Concepto.HeaderText = "Concepto";
            this.Concepto.MinimumWidth = 6;
            this.Concepto.Name = "Concepto";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Importe";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // RECIBO_DGV_Deducciones
            // 
            this.RECIBO_DGV_Deducciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RECIBO_DGV_Deducciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RECIBO_DGV_Deducciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.RECIBO_DGV_Deducciones.Location = new System.Drawing.Point(494, 397);
            this.RECIBO_DGV_Deducciones.Name = "RECIBO_DGV_Deducciones";
            this.RECIBO_DGV_Deducciones.RowHeadersWidth = 51;
            this.RECIBO_DGV_Deducciones.Size = new System.Drawing.Size(446, 155);
            this.RECIBO_DGV_Deducciones.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Clave";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Concepto";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Importe";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
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
            // GREPORTE_DTP_date
            // 
            this.GREPORTE_DTP_date.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.GREPORTE_DTP_date.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.GREPORTE_DTP_date.CustomFormat = "MM/yyyy";
            this.GREPORTE_DTP_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.GREPORTE_DTP_date.Location = new System.Drawing.Point(539, 84);
            this.GREPORTE_DTP_date.Name = "GREPORTE_DTP_date";
            this.GREPORTE_DTP_date.Size = new System.Drawing.Size(83, 20);
            this.GREPORTE_DTP_date.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(358, 84);
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
            // RECIBO_TXT_RazonSocial
            // 
            this.RECIBO_TXT_RazonSocial.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RECIBO_TXT_RazonSocial.AutoSize = true;
            this.RECIBO_TXT_RazonSocial.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RECIBO_TXT_RazonSocial.ForeColor = System.Drawing.Color.AliceBlue;
            this.RECIBO_TXT_RazonSocial.Location = new System.Drawing.Point(26, 136);
            this.RECIBO_TXT_RazonSocial.Name = "RECIBO_TXT_RazonSocial";
            this.RECIBO_TXT_RazonSocial.Size = new System.Drawing.Size(47, 23);
            this.RECIBO_TXT_RazonSocial.TabIndex = 73;
            this.RECIBO_TXT_RazonSocial.Text = "nom";
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
            this.label7.Location = new System.Drawing.Point(271, 7);
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
            this.label8.Location = new System.Drawing.Point(617, 7);
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
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.AliceBlue;
            this.label10.Location = new System.Drawing.Point(27, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(225, 16);
            this.label10.TabIndex = 78;
            this.label10.Text = "AYLIN CELESTE RODRÍGUEZ CAVAZOS";
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
            this.panel4.Location = new System.Drawing.Point(0, 583);
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
            this.label20.Location = new System.Drawing.Point(217, 600);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(48, 19);
            this.label20.TabIndex = 88;
            this.label20.Text = "Total:";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel5.Controls.Add(this.label34);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label22);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label33);
            this.panel5.Location = new System.Drawing.Point(0, 180);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(982, 34);
            this.panel5.TabIndex = 73;
            // 
            // label34
            // 
            this.label34.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.AliceBlue;
            this.label34.Location = new System.Drawing.Point(747, 10);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(162, 16);
            this.label34.TabIndex = 104;
            this.label34.Text = "01/sep/2024 - 30/sep/2024";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.DodgerBlue;
            this.label22.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.AliceBlue;
            this.label22.Location = new System.Drawing.Point(18, 7);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(138, 19);
            this.label22.TabIndex = 90;
            this.label22.Text = "Recibo de nómina";
            // 
            // label33
            // 
            this.label33.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.AliceBlue;
            this.label33.Location = new System.Drawing.Point(396, 10);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(146, 16);
            this.label33.TabIndex = 103;
            this.label33.Text = "30/sep/2024 11:00:00 PM";
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.AliceBlue;
            this.label23.Location = new System.Drawing.Point(332, 230);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(102, 16);
            this.label23.TabIndex = 91;
            this.label23.Text = "92-91-90-8443-1";
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.AliceBlue;
            this.label24.Location = new System.Drawing.Point(572, 230);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(141, 16);
            this.label24.TabIndex = 92;
            this.label24.Text = "ROCA050814MNLDVYA9";
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.AliceBlue;
            this.label25.Location = new System.Drawing.Point(786, 230);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(104, 16);
            this.label25.TabIndex = 93;
            this.label25.Text = "CUPU800825569";
            // 
            // RECIBO_TXT_RFC
            // 
            this.RECIBO_TXT_RFC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RECIBO_TXT_RFC.AutoSize = true;
            this.RECIBO_TXT_RFC.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RECIBO_TXT_RFC.ForeColor = System.Drawing.Color.AliceBlue;
            this.RECIBO_TXT_RFC.Location = new System.Drawing.Point(554, 157);
            this.RECIBO_TXT_RFC.Name = "RECIBO_TXT_RFC";
            this.RECIBO_TXT_RFC.Size = new System.Drawing.Size(106, 16);
            this.RECIBO_TXT_RFC.TabIndex = 94;
            this.RECIBO_TXT_RFC.Text = "ABC 680524 P-76";
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.AliceBlue;
            this.label27.Location = new System.Drawing.Point(115, 280);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(36, 16);
            this.label27.TabIndex = 95;
            this.label27.Text = "00118";
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.AliceBlue;
            this.label28.Location = new System.Drawing.Point(340, 280);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(126, 16);
            this.label28.TabIndex = 96;
            this.label28.Text = "Programador Junior";
            // 
            // label29
            // 
            this.label29.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.AliceBlue;
            this.label29.Location = new System.Drawing.Point(618, 280);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(71, 16);
            this.label29.TabIndex = 97;
            this.label29.Text = "Desarrollo";
            // 
            // label30
            // 
            this.label30.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.AliceBlue;
            this.label30.Location = new System.Drawing.Point(176, 326);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(18, 16);
            this.label30.TabIndex = 98;
            this.label30.Text = "21";
            // 
            // label31
            // 
            this.label31.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.AliceBlue;
            this.label31.Location = new System.Drawing.Point(436, 326);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(35, 16);
            this.label31.TabIndex = 99;
            this.label31.Text = "$600";
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
            // label32
            // 
            this.label32.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.AliceBlue;
            this.label32.Location = new System.Drawing.Point(610, 326);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(80, 16);
            this.label32.TabIndex = 102;
            this.label32.Text = "14/mar/2024";
            // 
            // RECIBO_TXT_RegistroPatronal
            // 
            this.RECIBO_TXT_RegistroPatronal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RECIBO_TXT_RegistroPatronal.AutoSize = true;
            this.RECIBO_TXT_RegistroPatronal.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RECIBO_TXT_RegistroPatronal.ForeColor = System.Drawing.Color.AliceBlue;
            this.RECIBO_TXT_RegistroPatronal.Location = new System.Drawing.Point(447, 157);
            this.RECIBO_TXT_RegistroPatronal.Name = "RECIBO_TXT_RegistroPatronal";
            this.RECIBO_TXT_RegistroPatronal.Size = new System.Drawing.Size(31, 16);
            this.RECIBO_TXT_RegistroPatronal.TabIndex = 105;
            this.RECIBO_TXT_RegistroPatronal.Text = "Y52:";
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
            // label37
            // 
            this.label37.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.Color.AliceBlue;
            this.label37.Location = new System.Drawing.Point(209, 626);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(66, 16);
            this.label37.TabIndex = 106;
            this.label37.Text = "$12,600.00";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.LightBlue;
            this.label21.Location = new System.Drawing.Point(660, 600);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(117, 19);
            this.label21.TabIndex = 107;
            this.label21.Text = "Total con letra:";
            // 
            // label38
            // 
            this.label38.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.Color.AliceBlue;
            this.label38.Location = new System.Drawing.Point(704, 626);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(28, 16);
            this.label38.TabIndex = 108;
            this.label38.Text = "aaa";
            // 
            // RECIBO_TXT_DomicilioFiscal
            // 
            this.RECIBO_TXT_DomicilioFiscal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RECIBO_TXT_DomicilioFiscal.AutoSize = true;
            this.RECIBO_TXT_DomicilioFiscal.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RECIBO_TXT_DomicilioFiscal.ForeColor = System.Drawing.Color.AliceBlue;
            this.RECIBO_TXT_DomicilioFiscal.Location = new System.Drawing.Point(28, 161);
            this.RECIBO_TXT_DomicilioFiscal.Name = "RECIBO_TXT_DomicilioFiscal";
            this.RECIBO_TXT_DomicilioFiscal.Size = new System.Drawing.Size(28, 13);
            this.RECIBO_TXT_DomicilioFiscal.TabIndex = 109;
            this.RECIBO_TXT_DomicilioFiscal.Text = "nom";
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
            this.RECIBO_TXT_NoTel.Size = new System.Drawing.Size(106, 16);
            this.RECIBO_TXT_NoTel.TabIndex = 111;
            this.RECIBO_TXT_NoTel.Text = "ABC 680524 P-76";
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
            this.RECIBO_TXT_Email.Size = new System.Drawing.Size(106, 16);
            this.RECIBO_TXT_Email.TabIndex = 113;
            this.RECIBO_TXT_Email.Text = "ABC 680524 P-76";
            // 
            // FormReciboNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(965, 670);
            this.Controls.Add(this.RECIBO_TXT_Email);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.RECIBO_TXT_NoTel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RECIBO_TXT_DomicilioFiscal);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.RECIBO_TXT_RegistroPatronal);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.RECIBO_TXT_RFC);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
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
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RECIBO_TXT_RazonSocial);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.GREPORTE_DTP_date);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridView RECIBO_DGV_Deducciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker GREPORTE_DTP_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label RECIBO_TXT_RazonSocial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
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
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label RECIBO_TXT_RFC;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label RECIBO_TXT_RegistroPatronal;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label RECIBO_TXT_DomicilioFiscal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label RECIBO_TXT_NoTel;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label RECIBO_TXT_Email;
    }
}