namespace MAD_AAVD_proyecto
{
    partial class FormNominaGenerar
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.GREPORTE_DTP_date = new System.Windows.Forms.DateTimePicker();
            this.GREPORTE_BTN_generate = new System.Windows.Forms.Button();
            this.GREPORTE_DGV_table = new System.Windows.Forms.DataGridView();
            this.numEmploy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameEmploy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GREPORTE_DGV_table)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(275, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 57);
            this.label1.TabIndex = 5;
            this.label1.Text = "Generación de nómina";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(-1, 124);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(999, 3);
            this.panel2.TabIndex = 67;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Location = new System.Drawing.Point(0, 278);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(999, 3);
            this.panel1.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(124, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 25);
            this.label2.TabIndex = 68;
            this.label2.Text = "Ingrese el mes y año a calcular:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // GREPORTE_DTP_date
            // 
            this.GREPORTE_DTP_date.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.GREPORTE_DTP_date.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.GREPORTE_DTP_date.CustomFormat = "MM/yyyy";
            this.GREPORTE_DTP_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.GREPORTE_DTP_date.Location = new System.Drawing.Point(208, 185);
            this.GREPORTE_DTP_date.Name = "GREPORTE_DTP_date";
            this.GREPORTE_DTP_date.Size = new System.Drawing.Size(117, 26);
            this.GREPORTE_DTP_date.TabIndex = 69;
            this.GREPORTE_DTP_date.ValueChanged += new System.EventHandler(this.GREPORTE_DTP_date_ValueChanged);
            // 
            // GREPORTE_BTN_generate
            // 
            this.GREPORTE_BTN_generate.BackColor = System.Drawing.Color.DodgerBlue;
            this.GREPORTE_BTN_generate.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.GREPORTE_BTN_generate.FlatAppearance.BorderSize = 0;
            this.GREPORTE_BTN_generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GREPORTE_BTN_generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GREPORTE_BTN_generate.Location = new System.Drawing.Point(605, 166);
            this.GREPORTE_BTN_generate.Name = "GREPORTE_BTN_generate";
            this.GREPORTE_BTN_generate.Size = new System.Drawing.Size(230, 37);
            this.GREPORTE_BTN_generate.TabIndex = 70;
            this.GREPORTE_BTN_generate.Text = "Generar";
            this.GREPORTE_BTN_generate.UseVisualStyleBackColor = false;
            this.GREPORTE_BTN_generate.Click += new System.EventHandler(this.GREPORTE_BTN_generate_Click);
            // 
            // GREPORTE_DGV_table
            // 
            this.GREPORTE_DGV_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.GREPORTE_DGV_table.BackgroundColor = System.Drawing.Color.Black;
            this.GREPORTE_DGV_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GREPORTE_DGV_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numEmploy,
            this.nameEmploy,
            this.date,
            this.salaryResult,
            this.bank,
            this.accountNum});
            this.GREPORTE_DGV_table.GridColor = System.Drawing.Color.DodgerBlue;
            this.GREPORTE_DGV_table.Location = new System.Drawing.Point(36, 244);
            this.GREPORTE_DGV_table.Name = "GREPORTE_DGV_table";
            this.GREPORTE_DGV_table.ReadOnly = true;
            this.GREPORTE_DGV_table.RowHeadersWidth = 51;
            this.GREPORTE_DGV_table.Size = new System.Drawing.Size(890, 427);
            this.GREPORTE_DGV_table.TabIndex = 72;
            // 
            // numEmploy
            // 
            this.numEmploy.HeaderText = "No. Empleado";
            this.numEmploy.MinimumWidth = 6;
            this.numEmploy.Name = "numEmploy";
            this.numEmploy.ReadOnly = true;
            this.numEmploy.Width = 130;
            // 
            // nameEmploy
            // 
            this.nameEmploy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameEmploy.HeaderText = "Nombre ";
            this.nameEmploy.MinimumWidth = 6;
            this.nameEmploy.Name = "nameEmploy";
            this.nameEmploy.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "Fecha";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 84;
            // 
            // salaryResult
            // 
            this.salaryResult.HeaderText = "Cantidad a depositar";
            this.salaryResult.MinimumWidth = 6;
            this.salaryResult.Name = "salaryResult";
            this.salaryResult.ReadOnly = true;
            this.salaryResult.Width = 175;
            // 
            // bank
            // 
            this.bank.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bank.HeaderText = "Banco";
            this.bank.MinimumWidth = 6;
            this.bank.Name = "bank";
            this.bank.ReadOnly = true;
            // 
            // accountNum
            // 
            this.accountNum.HeaderText = "No. Cuenta";
            this.accountNum.MinimumWidth = 6;
            this.accountNum.Name = "accountNum";
            this.accountNum.ReadOnly = true;
            this.accountNum.Width = 111;
            // 
            // FormNominaGenerar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(980, 710);
            this.Controls.Add(this.GREPORTE_DGV_table);
            this.Controls.Add(this.GREPORTE_BTN_generate);
            this.Controls.Add(this.GREPORTE_DTP_date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormNominaGenerar";
            this.Text = "FormNominaGenerar";
            this.Load += new System.EventHandler(this.FormNominaGenerar_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GREPORTE_DGV_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker GREPORTE_DTP_date;
        private System.Windows.Forms.Button GREPORTE_BTN_generate;
        private System.Windows.Forms.DataGridView GREPORTE_DGV_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn numEmploy;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameEmploy;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn bank;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNum;
    }
}