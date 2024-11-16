namespace MAD_AAVD_proyecto
{
    partial class FormConceptosAplicar
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
            this.label2 = new System.Windows.Forms.Label();
            this.CONCEPAPLICAR_RB_Departamento = new System.Windows.Forms.RadioButton();
            this.CONCEPAPLICAR_RB_Empleado = new System.Windows.Forms.RadioButton();
            this.CONCEPAPLICAR_CB_Conceptos = new System.Windows.Forms.ComboBox();
            this.CONCEPAPLICAR_DTP_Fecha = new System.Windows.Forms.DateTimePicker();
            this.CONCEPAPLICAR_Panel_Departamento = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.CONCEPAPLICAR_CB_Departamentos = new System.Windows.Forms.ComboBox();
            this.CONCEPAPLICAR_Panel_Empleado = new System.Windows.Forms.Panel();
            this.CONCEPAPLICAR_CB_Emp = new System.Windows.Forms.ComboBox();
            this.CONCEPAPLICAR_CB_EmpPuesto = new System.Windows.Forms.ComboBox();
            this.CONCEPAPLICAR_CB_EmpDepto = new System.Windows.Forms.ComboBox();
            this.CONCEPAPLICAR_DTP_EmpFecha = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CONCEPAPLICAR_TB_NoEmp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CONCEPAPLICAR_BTN_Registrar = new System.Windows.Forms.Button();
            this.CONCEPAPLICAR_LBL_Loading = new System.Windows.Forms.Label();
            this.CONCEPAPLICAR_Panel_Departamento.SuspendLayout();
            this.CONCEPAPLICAR_Panel_Empleado.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(345, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Aplicar conceptos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(300, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Concepto a aplicar:";
            // 
            // CONCEPAPLICAR_RB_Departamento
            // 
            this.CONCEPAPLICAR_RB_Departamento.AutoSize = true;
            this.CONCEPAPLICAR_RB_Departamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.CONCEPAPLICAR_RB_Departamento.Location = new System.Drawing.Point(345, 217);
            this.CONCEPAPLICAR_RB_Departamento.Name = "CONCEPAPLICAR_RB_Departamento";
            this.CONCEPAPLICAR_RB_Departamento.Size = new System.Drawing.Size(142, 24);
            this.CONCEPAPLICAR_RB_Departamento.TabIndex = 48;
            this.CONCEPAPLICAR_RB_Departamento.TabStop = true;
            this.CONCEPAPLICAR_RB_Departamento.Text = "Departamento";
            this.CONCEPAPLICAR_RB_Departamento.UseVisualStyleBackColor = true;
            this.CONCEPAPLICAR_RB_Departamento.CheckedChanged += new System.EventHandler(this.CONCEPAPLICAR_RB_Departamento_CheckedChanged);
            // 
            // CONCEPAPLICAR_RB_Empleado
            // 
            this.CONCEPAPLICAR_RB_Empleado.AutoSize = true;
            this.CONCEPAPLICAR_RB_Empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.CONCEPAPLICAR_RB_Empleado.Location = new System.Drawing.Point(519, 217);
            this.CONCEPAPLICAR_RB_Empleado.Name = "CONCEPAPLICAR_RB_Empleado";
            this.CONCEPAPLICAR_RB_Empleado.Size = new System.Drawing.Size(107, 24);
            this.CONCEPAPLICAR_RB_Empleado.TabIndex = 49;
            this.CONCEPAPLICAR_RB_Empleado.TabStop = true;
            this.CONCEPAPLICAR_RB_Empleado.Text = "Empleado";
            this.CONCEPAPLICAR_RB_Empleado.UseVisualStyleBackColor = true;
            this.CONCEPAPLICAR_RB_Empleado.CheckedChanged += new System.EventHandler(this.CONCEPAPLICAR_RB_Empleado_CheckedChanged);
            // 
            // CONCEPAPLICAR_CB_Conceptos
            // 
            this.CONCEPAPLICAR_CB_Conceptos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CONCEPAPLICAR_CB_Conceptos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.CONCEPAPLICAR_CB_Conceptos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CONCEPAPLICAR_CB_Conceptos.ForeColor = System.Drawing.SystemColors.Window;
            this.CONCEPAPLICAR_CB_Conceptos.FormattingEnabled = true;
            this.CONCEPAPLICAR_CB_Conceptos.Items.AddRange(new object[] {
            "Percepción",
            "Deducción"});
            this.CONCEPAPLICAR_CB_Conceptos.Location = new System.Drawing.Point(486, 171);
            this.CONCEPAPLICAR_CB_Conceptos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CONCEPAPLICAR_CB_Conceptos.Name = "CONCEPAPLICAR_CB_Conceptos";
            this.CONCEPAPLICAR_CB_Conceptos.Size = new System.Drawing.Size(192, 21);
            this.CONCEPAPLICAR_CB_Conceptos.TabIndex = 57;
            this.CONCEPAPLICAR_CB_Conceptos.SelectedIndexChanged += new System.EventHandler(this.CONCEPAPLICAR_CB_Conceptos_SelectedIndexChanged);
            // 
            // CONCEPAPLICAR_DTP_Fecha
            // 
            this.CONCEPAPLICAR_DTP_Fecha.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.CONCEPAPLICAR_DTP_Fecha.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.CONCEPAPLICAR_DTP_Fecha.CustomFormat = "dd/MMM/yyyy";
            this.CONCEPAPLICAR_DTP_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CONCEPAPLICAR_DTP_Fecha.Location = new System.Drawing.Point(473, 484);
            this.CONCEPAPLICAR_DTP_Fecha.Name = "CONCEPAPLICAR_DTP_Fecha";
            this.CONCEPAPLICAR_DTP_Fecha.Size = new System.Drawing.Size(102, 20);
            this.CONCEPAPLICAR_DTP_Fecha.TabIndex = 62;
            // 
            // CONCEPAPLICAR_Panel_Departamento
            // 
            this.CONCEPAPLICAR_Panel_Departamento.BackColor = System.Drawing.Color.Black;
            this.CONCEPAPLICAR_Panel_Departamento.Controls.Add(this.label10);
            this.CONCEPAPLICAR_Panel_Departamento.Controls.Add(this.CONCEPAPLICAR_CB_Departamentos);
            this.CONCEPAPLICAR_Panel_Departamento.Location = new System.Drawing.Point(276, 265);
            this.CONCEPAPLICAR_Panel_Departamento.Name = "CONCEPAPLICAR_Panel_Departamento";
            this.CONCEPAPLICAR_Panel_Departamento.Size = new System.Drawing.Size(209, 122);
            this.CONCEPAPLICAR_Panel_Departamento.TabIndex = 63;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.LightBlue;
            this.label10.Location = new System.Drawing.Point(79, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Aplicar a:";
            // 
            // CONCEPAPLICAR_CB_Departamentos
            // 
            this.CONCEPAPLICAR_CB_Departamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.CONCEPAPLICAR_CB_Departamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CONCEPAPLICAR_CB_Departamentos.ForeColor = System.Drawing.Color.AliceBlue;
            this.CONCEPAPLICAR_CB_Departamentos.FormattingEnabled = true;
            this.CONCEPAPLICAR_CB_Departamentos.Location = new System.Drawing.Point(50, 55);
            this.CONCEPAPLICAR_CB_Departamentos.Name = "CONCEPAPLICAR_CB_Departamentos";
            this.CONCEPAPLICAR_CB_Departamentos.Size = new System.Drawing.Size(121, 21);
            this.CONCEPAPLICAR_CB_Departamentos.TabIndex = 0;
            // 
            // CONCEPAPLICAR_Panel_Empleado
            // 
            this.CONCEPAPLICAR_Panel_Empleado.BackColor = System.Drawing.Color.Black;
            this.CONCEPAPLICAR_Panel_Empleado.Controls.Add(this.CONCEPAPLICAR_CB_Emp);
            this.CONCEPAPLICAR_Panel_Empleado.Controls.Add(this.CONCEPAPLICAR_CB_EmpPuesto);
            this.CONCEPAPLICAR_Panel_Empleado.Controls.Add(this.CONCEPAPLICAR_CB_EmpDepto);
            this.CONCEPAPLICAR_Panel_Empleado.Controls.Add(this.CONCEPAPLICAR_DTP_EmpFecha);
            this.CONCEPAPLICAR_Panel_Empleado.Controls.Add(this.label9);
            this.CONCEPAPLICAR_Panel_Empleado.Controls.Add(this.label8);
            this.CONCEPAPLICAR_Panel_Empleado.Controls.Add(this.label7);
            this.CONCEPAPLICAR_Panel_Empleado.Controls.Add(this.label6);
            this.CONCEPAPLICAR_Panel_Empleado.Controls.Add(this.label5);
            this.CONCEPAPLICAR_Panel_Empleado.Controls.Add(this.label4);
            this.CONCEPAPLICAR_Panel_Empleado.Controls.Add(this.CONCEPAPLICAR_TB_NoEmp);
            this.CONCEPAPLICAR_Panel_Empleado.Location = new System.Drawing.Point(487, 265);
            this.CONCEPAPLICAR_Panel_Empleado.Name = "CONCEPAPLICAR_Panel_Empleado";
            this.CONCEPAPLICAR_Panel_Empleado.Size = new System.Drawing.Size(276, 192);
            this.CONCEPAPLICAR_Panel_Empleado.TabIndex = 64;
            // 
            // CONCEPAPLICAR_CB_Emp
            // 
            this.CONCEPAPLICAR_CB_Emp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.CONCEPAPLICAR_CB_Emp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CONCEPAPLICAR_CB_Emp.ForeColor = System.Drawing.Color.AliceBlue;
            this.CONCEPAPLICAR_CB_Emp.FormattingEnabled = true;
            this.CONCEPAPLICAR_CB_Emp.Location = new System.Drawing.Point(113, 154);
            this.CONCEPAPLICAR_CB_Emp.Name = "CONCEPAPLICAR_CB_Emp";
            this.CONCEPAPLICAR_CB_Emp.Size = new System.Drawing.Size(151, 21);
            this.CONCEPAPLICAR_CB_Emp.TabIndex = 10;
            this.CONCEPAPLICAR_CB_Emp.SelectedIndexChanged += new System.EventHandler(this.CONCEPAPLICAR_CB_Emp_SelectedItemChanged);
            // 
            // CONCEPAPLICAR_CB_EmpPuesto
            // 
            this.CONCEPAPLICAR_CB_EmpPuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.CONCEPAPLICAR_CB_EmpPuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CONCEPAPLICAR_CB_EmpPuesto.ForeColor = System.Drawing.Color.AliceBlue;
            this.CONCEPAPLICAR_CB_EmpPuesto.FormattingEnabled = true;
            this.CONCEPAPLICAR_CB_EmpPuesto.Location = new System.Drawing.Point(113, 94);
            this.CONCEPAPLICAR_CB_EmpPuesto.Name = "CONCEPAPLICAR_CB_EmpPuesto";
            this.CONCEPAPLICAR_CB_EmpPuesto.Size = new System.Drawing.Size(151, 21);
            this.CONCEPAPLICAR_CB_EmpPuesto.TabIndex = 9;
            this.CONCEPAPLICAR_CB_EmpPuesto.SelectedIndexChanged += new System.EventHandler(this.CONCEPAPLICAR_CB_EmpPuesto_SelectedIndexChanged);
            // 
            // CONCEPAPLICAR_CB_EmpDepto
            // 
            this.CONCEPAPLICAR_CB_EmpDepto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.CONCEPAPLICAR_CB_EmpDepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CONCEPAPLICAR_CB_EmpDepto.ForeColor = System.Drawing.Color.AliceBlue;
            this.CONCEPAPLICAR_CB_EmpDepto.FormattingEnabled = true;
            this.CONCEPAPLICAR_CB_EmpDepto.Location = new System.Drawing.Point(113, 65);
            this.CONCEPAPLICAR_CB_EmpDepto.Name = "CONCEPAPLICAR_CB_EmpDepto";
            this.CONCEPAPLICAR_CB_EmpDepto.Size = new System.Drawing.Size(151, 21);
            this.CONCEPAPLICAR_CB_EmpDepto.TabIndex = 8;
            this.CONCEPAPLICAR_CB_EmpDepto.SelectedIndexChanged += new System.EventHandler(this.CONCEPAPLICAR_CB_EmpDepto_SelectedIndexChanged);
            // 
            // CONCEPAPLICAR_DTP_EmpFecha
            // 
            this.CONCEPAPLICAR_DTP_EmpFecha.CustomFormat = "dd/MMM/yyyy";
            this.CONCEPAPLICAR_DTP_EmpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CONCEPAPLICAR_DTP_EmpFecha.Location = new System.Drawing.Point(113, 124);
            this.CONCEPAPLICAR_DTP_EmpFecha.Name = "CONCEPAPLICAR_DTP_EmpFecha";
            this.CONCEPAPLICAR_DTP_EmpFecha.Size = new System.Drawing.Size(93, 20);
            this.CONCEPAPLICAR_DTP_EmpFecha.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightBlue;
            this.label9.Location = new System.Drawing.Point(21, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Empleado:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightBlue;
            this.label8.Location = new System.Drawing.Point(21, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Fecha activo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightBlue;
            this.label7.Location = new System.Drawing.Point(21, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Puesto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightBlue;
            this.label6.Location = new System.Drawing.Point(21, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Departamento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightBlue;
            this.label5.Location = new System.Drawing.Point(99, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "ó";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightBlue;
            this.label4.Location = new System.Drawing.Point(21, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "No. de empleado:";
            // 
            // CONCEPAPLICAR_TB_NoEmp
            // 
            this.CONCEPAPLICAR_TB_NoEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.CONCEPAPLICAR_TB_NoEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CONCEPAPLICAR_TB_NoEmp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CONCEPAPLICAR_TB_NoEmp.Location = new System.Drawing.Point(131, 16);
            this.CONCEPAPLICAR_TB_NoEmp.Name = "CONCEPAPLICAR_TB_NoEmp";
            this.CONCEPAPLICAR_TB_NoEmp.Size = new System.Drawing.Size(41, 20);
            this.CONCEPAPLICAR_TB_NoEmp.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(394, 484);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 65;
            this.label3.Text = "Fecha:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(0, 116);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(983, 3);
            this.panel2.TabIndex = 66;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Location = new System.Drawing.Point(0, 278);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 3);
            this.panel1.TabIndex = 40;
            // 
            // CONCEPAPLICAR_BTN_Registrar
            // 
            this.CONCEPAPLICAR_BTN_Registrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CONCEPAPLICAR_BTN_Registrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.CONCEPAPLICAR_BTN_Registrar.FlatAppearance.BorderSize = 0;
            this.CONCEPAPLICAR_BTN_Registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CONCEPAPLICAR_BTN_Registrar.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONCEPAPLICAR_BTN_Registrar.Location = new System.Drawing.Point(429, 544);
            this.CONCEPAPLICAR_BTN_Registrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CONCEPAPLICAR_BTN_Registrar.Name = "CONCEPAPLICAR_BTN_Registrar";
            this.CONCEPAPLICAR_BTN_Registrar.Size = new System.Drawing.Size(124, 35);
            this.CONCEPAPLICAR_BTN_Registrar.TabIndex = 67;
            this.CONCEPAPLICAR_BTN_Registrar.Text = "Registrar";
            this.CONCEPAPLICAR_BTN_Registrar.UseVisualStyleBackColor = false;
            this.CONCEPAPLICAR_BTN_Registrar.Click += new System.EventHandler(this.CONCEPAPLICAR_BTN_Registrar_Click);
            // 
            // CONCEPAPLICAR_LBL_Loading
            // 
            this.CONCEPAPLICAR_LBL_Loading.AutoSize = true;
            this.CONCEPAPLICAR_LBL_Loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONCEPAPLICAR_LBL_Loading.ForeColor = System.Drawing.Color.SkyBlue;
            this.CONCEPAPLICAR_LBL_Loading.Location = new System.Drawing.Point(460, 84);
            this.CONCEPAPLICAR_LBL_Loading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CONCEPAPLICAR_LBL_Loading.Name = "CONCEPAPLICAR_LBL_Loading";
            this.CONCEPAPLICAR_LBL_Loading.Size = new System.Drawing.Size(71, 15);
            this.CONCEPAPLICAR_LBL_Loading.TabIndex = 109;
            this.CONCEPAPLICAR_LBL_Loading.Text = "Loading...";
            this.CONCEPAPLICAR_LBL_Loading.Visible = false;
            // 
            // FormConceptosAplicar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(980, 640);
            this.Controls.Add(this.CONCEPAPLICAR_LBL_Loading);
            this.Controls.Add(this.CONCEPAPLICAR_BTN_Registrar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CONCEPAPLICAR_Panel_Empleado);
            this.Controls.Add(this.CONCEPAPLICAR_Panel_Departamento);
            this.Controls.Add(this.CONCEPAPLICAR_DTP_Fecha);
            this.Controls.Add(this.CONCEPAPLICAR_CB_Conceptos);
            this.Controls.Add(this.CONCEPAPLICAR_RB_Empleado);
            this.Controls.Add(this.CONCEPAPLICAR_RB_Departamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConceptosAplicar";
            this.Text = "FormConceptosAplicar";
            this.Load += new System.EventHandler(this.FormConceptosAplicar_Load);
            this.CONCEPAPLICAR_Panel_Departamento.ResumeLayout(false);
            this.CONCEPAPLICAR_Panel_Departamento.PerformLayout();
            this.CONCEPAPLICAR_Panel_Empleado.ResumeLayout(false);
            this.CONCEPAPLICAR_Panel_Empleado.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton CONCEPAPLICAR_RB_Departamento;
        private System.Windows.Forms.RadioButton CONCEPAPLICAR_RB_Empleado;
        private System.Windows.Forms.ComboBox CONCEPAPLICAR_CB_Conceptos;
        private System.Windows.Forms.DateTimePicker CONCEPAPLICAR_DTP_Fecha;
        private System.Windows.Forms.Panel CONCEPAPLICAR_Panel_Departamento;
        private System.Windows.Forms.Panel CONCEPAPLICAR_Panel_Empleado;
        private System.Windows.Forms.TextBox CONCEPAPLICAR_TB_NoEmp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CONCEPAPLICAR_CB_Departamentos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker CONCEPAPLICAR_DTP_EmpFecha;
        private System.Windows.Forms.ComboBox CONCEPAPLICAR_CB_Emp;
        private System.Windows.Forms.ComboBox CONCEPAPLICAR_CB_EmpPuesto;
        private System.Windows.Forms.ComboBox CONCEPAPLICAR_CB_EmpDepto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CONCEPAPLICAR_BTN_Registrar;
        private System.Windows.Forms.Label CONCEPAPLICAR_LBL_Loading;
    }
}