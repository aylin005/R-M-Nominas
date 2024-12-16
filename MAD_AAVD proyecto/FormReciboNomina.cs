using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cassandra.Data.Linq;
using iText.IO.Font;
using iText.IO.Font.Constants;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;


using static MAD_AAVD_proyecto.Globals;

namespace MAD_AAVD_proyecto
{
    public partial class FormReciboNomina : Form
    {
        public FormReciboNomina()
        {
            InitializeComponent();
        }

        private void RECIBO_DGV_Percepciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void FormReciboNomina_Load(object sender, EventArgs e)
        {
            //Carga datos de la empresa
            RECIBO_TXT_NombreEmpresa.Text = companyName;
            RECIBO_TXT_RegistroPatronal.Text = RP;
            RECIBO_TXT_RFC.Text = RFC;
            RECIBO_TXT_DomicilioFiscal.Text = DF;
            RECIBO_TXT_NoTel.Text = noTel;
            RECIBO_TXT_Email.Text = email;

            RECIBO_DGV_Percepciones.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            RECIBO_DGV_Percepciones.DefaultCellStyle.BackColor = System.Drawing.Color.Black;

            RECIBO_DGV_Deducciones.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            RECIBO_DGV_Deducciones.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            /////
            ///

        }

        private void getReciboC()
        {
            Clear();
            var linkCassandra = new EnlaceCassandra();

            //Obtener recibo
            string[] auxColumnas = { "idRecibo", "finPeriodo", "inicioPeriodo", "diasTrabajados",
                "totalPercepciones","totalDeducciones","total", "totalLetra" };
            Recibos recibo = linkCassandra.BuscarRecibo(auxColumnas, activeUser, RECIBO_DTP_Fecha.Value);

            if (recibo != null)
            {
                loadRecibo(recibo);

                ////////Carga datos del empleado activo///
                //Obtener empleado activo
                string[] columnas = {"nombres", "apPaterno", "apMaterno", "nss", "curp", "rfc", "noEmpleado", "puesto", "departamento",
                "salarioDiario", "fechaIngreso"};
                Empleados emp = linkCassandra.LastPuesto2<Empleados>(columnas, activeUser.ToString(), RECIBO_DTP_Fecha.Value);

                if (emp != null)
                {
                    loadEmp(emp);
                }

                //CARGAR CONCEPTOS
                List<Conceptos> conceptos = linkCassandra.getConceptosRecibo(activeUser, RECIBO_DTP_Fecha.Value);
                //Dividir la lista en dos
                List<Conceptos> percepciones = conceptos.Where(c => c.percepcion).ToList();
                List<Conceptos> deducciones = conceptos.Where(c => !c.percepcion).ToList();

                //////////////AÑADIR CONCEPTOS//////////////////
                //PERCEPCIONES
                foreach (var item in percepciones)
                {
                    RECIBO_DGV_Percepciones.Rows.Add(
                        item.noConcepto,
                        item.nombreConcepto,
                        item.cantConcepto
                    );
                }
                //Agregar total percepciones
                RECIBO_DGV_Percepciones.Rows.Add(null, "TOTAL", recibo.totalPercepciones);
                // Renglón total en negritas
                var lastRowIndex = RECIBO_DGV_Percepciones.Rows.Count - 1;
                RECIBO_DGV_Percepciones.Rows[lastRowIndex].DefaultCellStyle.Font = new Font(RECIBO_DGV_Percepciones.Font, FontStyle.Bold);

                //DEDUCCIONES
                foreach (var item in deducciones)
                {
                    RECIBO_DGV_Deducciones.Rows.Add(
                        item.noConcepto,
                        item.nombreConcepto,
                        item.cantConcepto
                    );
                }
                //Agregar total percepciones
                RECIBO_DGV_Deducciones.Rows.Add(null, "TOTAL", recibo.totalDeducciones);
                // Renglón total en negritas
                lastRowIndex = RECIBO_DGV_Deducciones.Rows.Count - 1;
                RECIBO_DGV_Deducciones.Rows[lastRowIndex].DefaultCellStyle.Font = new Font(RECIBO_DGV_Deducciones.Font, FontStyle.Bold);

                //Formato dinero
                RECIBO_DGV_Percepciones.Columns["pImporte"].DefaultCellStyle.Format = "C";
                RECIBO_DGV_Deducciones.Columns["dImporte"].DefaultCellStyle.Format = "C";
            }
            else if (recibo == null)
            {
                MessageBox.Show("El recibo no se ha generado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void getReciboSQL()
        {

            string projectPath = AppDomain.CurrentDomain.BaseDirectory;
            string folderPath = Path.Combine(projectPath, "Nóminas");

            // Crear la carpeta si no existe
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string filePath = Path.Combine(folderPath, $"Nómina_{RECIBO_DTP_Fecha.Value:yyyy-MM-dd}.pdf");

            using (PdfWriter writer = new PdfWriter(filePath))
            {
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    PdfFont calibri = PdfFontFactory.CreateFont(StandardFonts.TIMES_ROMAN); //se carga la fuente calibri
                    PdfFont u = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD); //se carga la fuente calibri
                    pdf.SetDefaultPageSize(iText.Kernel.Geom.PageSize.A4.Rotate());//lo establecemos como horiizontal :3
                    Document document = new Document(pdf);
                    document.Add(new Paragraph(companyName).SetFont(u).SetFontSize(30).SetTextAlignment(TextAlignment.JUSTIFIED));
                    document.Add(new Paragraph(RP + " | " + RFC + " | " + DF + " | No. Telefónico: " + noTel + " | Email: " + email).SetFont(calibri).SetFontSize(10).SetTextAlignment(TextAlignment.JUSTIFIED));
                    document.Add(new Paragraph("__________________________________________________________________________________________________________________").SetTextAlignment(TextAlignment.CENTER));
                    var linkDB = new EnlaceDB();
                    DataTable recibo = linkDB.GetRecibo('r', RECIBO_DTP_Fecha.Value, activeUser);
                    DataTable percepciones = linkDB.GetRecibo('p', RECIBO_DTP_Fecha.Value, activeUser);
                    DataTable deducciones = linkDB.GetRecibo('l', RECIBO_DTP_Fecha.Value, activeUser);

                    if (recibo.Rows.Count > 0)
                    {
                        //Asignar cada dato a variables
                        DataRow row = recibo.Rows[0];
                        Guid noRecibo = (Guid)(row["noRecibo"]);
                        DateTime fechaPago = Convert.ToDateTime(row["fechaPago"]);
                        DateTime inicioPeriodo = Convert.ToDateTime(row["inicioPeriodo"]);
                        document.Add(new Paragraph("No. Recibo:" + noRecibo + "                             Período de pago:" + inicioPeriodo.ToShortDateString() + " - " +  fechaPago.ToShortDateString()).SetFont(calibri).SetFontSize(12).SetTextAlignment(TextAlignment.JUSTIFIED_ALL));
                        document.Add(new Paragraph("__________________________________________________________________________________________________________________").SetTextAlignment(TextAlignment.CENTER));
                        string nombre = row["nombre"].ToString();//
                        string nss = row["nss"].ToString();//
                        string curp = row["curp"].ToString();//
                        string rfc = row["rfc"].ToString();//
                        int noEmpleado = Convert.ToInt32(row["noEmpleado"]); //
                        string nombrePuesto = row["nombrePuesto"].ToString();//
                        string nombreDpto = row["nombreDpto"].ToString();//
                        int diasTrabajados = Convert.ToInt32(row["diasTrabajados"]); //

                        decimal aux = Convert.ToDecimal(row["salarioDiario"]);
                        string salarioDiario = aux.ToString("C2", System.Globalization.CultureInfo.GetCultureInfo("es-MX"));//

                        DateTime fechaIngreso = Convert.ToDateTime(row["fechaIngreso"]);//

                        //aux = Convert.ToDecimal(row["sueldoBruto"]);
                        //string sueldoBruto = aux.ToString("C2", System.Globalization.CultureInfo.GetCultureInfo("es-MX"));//
                        decimal sueldoBruto = Convert.ToDecimal(row["sueldoBruto"]);
                        aux = Convert.ToDecimal(row["totalDeduc"]);
                        string totalDeduc = aux.ToString("C2", System.Globalization.CultureInfo.GetCultureInfo("es-MX"));//

                        aux = Convert.ToDecimal(row["totalPercp"]);
                        string totalPercp = aux.ToString("C2", System.Globalization.CultureInfo.GetCultureInfo("es-MX"));//


                        aux = Convert.ToDecimal(row["total"]);
                        string total = aux.ToString("C2", System.Globalization.CultureInfo.GetCultureInfo("es-MX"));//

                        string totalLetra = row["totalLetra"].ToString();
                        // Asignar al PDF
                        document.Add(new Paragraph(nombre + " | No. Empleado: " + noEmpleado + " | CURP: " + curp + " | RFC: " + rfc + " | NSS: " + rfc).SetFont(calibri).SetFontSize(12).SetTextAlignment(TextAlignment.JUSTIFIED_ALL));
                        document.Add(new Paragraph("Departamento: " + nombreDpto + "     |       Puesto: " + nombrePuesto + "     |      Fecha de ingreso: " + fechaIngreso.ToShortDateString()).SetFont(calibri).SetFontSize(12).SetTextAlignment(TextAlignment.CENTER));
                        document.Add(new Paragraph("Dias trabajados: " + diasTrabajados + " días        |        Salario Diario: " + salarioDiario).SetFont(calibri).SetFontSize(12).SetTextAlignment(TextAlignment.CENTER));
                        document.Add(new Paragraph("__________________________________________________________________________________________________________________").SetTextAlignment(TextAlignment.CENTER));
                        // Asignar a los labels
                        RECIBO_TB_IdRecibo.Text = noRecibo.ToString();
                        RECIBO_TB_NombreEmp.Text = nombre;
                        RECIBO_TB_Imss.Text = nss;
                        RECIBO_TB_Curp.Text = curp;
                        RECIBO_TB_Rfc.Text = rfc;
                        RECIBO_TB_NoEmp.Text = noEmpleado.ToString();
                        RECIBO_TB_Puesto.Text = nombrePuesto;
                        RECIBO_TB_Departamento.Text = nombreDpto;
                        RECIBO_TB_DiasTrabajados.Text = diasTrabajados.ToString();
                        RECIBO_TB_SalarioDiario.Text = salarioDiario;
                        RECIBO_TB_FechaAlta.Text = fechaIngreso.ToString("yyyy/MMM/dd", CultureInfo.InvariantCulture);
                        RECIBO_TB_FechaPago.Text = fechaPago.ToString("yyyy/MMM/dd", CultureInfo.InvariantCulture);
                        RECIBO_TB_PeriodoPago.Text = $"{inicioPeriodo.ToString("yyyy/MMM/dd", CultureInfo.InvariantCulture)} - " +
                            $"{fechaPago.ToString("yyyy/MMM/dd", CultureInfo.InvariantCulture)}";
                        RECIBO_TB_Total.Text = total;
                        RECIBO_TB_TotalLetra.Text = totalLetra;

                        Table helperTable = new Table(2).SetTextAlignment(TextAlignment.CENTER);
                        //Tablas de percepciones y deducciones
                        RECIBO_DGV_Percepciones.Rows.Clear();
                        RECIBO_DGV_Percepciones.Rows.Insert(0, 0, "SALARIO", sueldoBruto); //INSERTA SALARIO AL INICIO
                        document.Add(new Paragraph("PERCEPCIONES                                                DEDUCCIONES").SetFont(u).SetFontSize(18).SetTextAlignment(TextAlignment.CENTER));

                        //PERCEPCIONES
                        // Color gris claro
                        iText.Kernel.Colors.Color lightGray = ColorConstants.LIGHT_GRAY;

                        Table percep = new Table(3);

                        percep.AddCell(new Cell().Add(new Paragraph("Clave")).SetBackgroundColor(lightGray));
                        percep.AddCell(new Cell().Add(new Paragraph("Concepto")).SetBackgroundColor(lightGray));
                        percep.AddCell(new Cell().Add(new Paragraph("Importe")).SetBackgroundColor(lightGray));

                        foreach (DataRow item in percepciones.Rows)
                        {
                            // Crea una nueva fila en el DataGridView
                            int rowIndex = RECIBO_DGV_Percepciones.Rows.Add();

                            //Se especifica bien qué columna de la tabla SQL se asigna a qué columna de DGV
                            RECIBO_DGV_Percepciones.Rows[rowIndex].Cells["Clave"].Value = item["concepto"];
                            RECIBO_DGV_Percepciones.Rows[rowIndex].Cells["Concepto"].Value = item["nombreConcepto"];
                            RECIBO_DGV_Percepciones.Rows[rowIndex].Cells["Importe"].Value = item["cantidad"];
                        }

                        foreach (DataGridViewRow index in RECIBO_DGV_Percepciones.Rows)
                        {
                            if (!index.IsNewRow)  // para no agregar la fila en blanco
                            {
                                decimal aux3 = Convert.ToDecimal(index.Cells["Importe"].Value);
                                string importe = aux3.ToString("C2");

                                percep.AddCell(index.Cells["Clave"].Value.ToString()).SetFont(calibri).SetFontSize(10);
                                percep.AddCell(index.Cells["Concepto"].Value.ToString()).SetFont(calibri).SetFontSize(10);
                                percep.AddCell(importe).SetFont(calibri).SetFontSize(10);
                            }
                        }
                        percep.AddCell("");
                        percep.AddCell("");
                        percep.AddCell("Total: " + totalPercp).SetFontSize(12).SetFont(u).SetTextAlignment(TextAlignment.CENTER);
                        percep.SetWidth((765 / 2) - 10);
                        helperTable.AddCell(percep.SetTextAlignment(TextAlignment.CENTER).SetBorder(Border.NO_BORDER));
                        
                        //document.Add(percep);

                        //Inseta total al final
                        RECIBO_DGV_Percepciones.Rows.Insert(RECIBO_DGV_Percepciones.Rows.Count, "", "", totalPercp);
                        RECIBO_DGV_Percepciones.Rows[RECIBO_DGV_Percepciones.Rows.Count - 1].DefaultCellStyle.Font = new Font(RECIBO_DGV_Percepciones.Font, FontStyle.Bold);

                        ////////////////////////////DEDUCCIONES
                        Table deduc = new Table(3);

                        deduc.AddCell(new Cell().Add(new Paragraph("Clave")).SetBackgroundColor(lightGray));
                        deduc.AddCell(new Cell().Add(new Paragraph("Concepto")).SetBackgroundColor(lightGray));
                        deduc.AddCell(new Cell().Add(new Paragraph("Importe")).SetBackgroundColor(lightGray));

                        RECIBO_DGV_Deducciones.Rows.Clear();
                        // Añade cada fila del DataTable al DGV
                        foreach (DataRow item in deducciones.Rows)
                        {
                            // Crea una nueva fila en el DataGridView
                            int rowIndex = RECIBO_DGV_Deducciones.Rows.Add();

                            //Se especifica bien qué columna de la tabla SQL se asigna a qué columna de DGV
                            RECIBO_DGV_Deducciones.Rows[rowIndex].Cells["Clave2"].Value = item["concepto"];
                            RECIBO_DGV_Deducciones.Rows[rowIndex].Cells["Concepto2"].Value = item["nombreConcepto"];
                            RECIBO_DGV_Deducciones.Rows[rowIndex].Cells["Importe2"].Value = item["cantidad"];
                        }

                        foreach (DataGridViewRow index in RECIBO_DGV_Deducciones.Rows)
                        {
                            if (!index.IsNewRow)  // para no agregar la fila en blanco
                            {
                                decimal aux2 = Convert.ToDecimal(index.Cells["Importe2"].Value);
                                string importe = aux2.ToString("C2");
                                deduc.AddCell(index.Cells["Clave2"].Value.ToString()).SetFont(calibri).SetFontSize(10);
                                deduc.AddCell(index.Cells["Concepto2"].Value.ToString()).SetFont(calibri).SetFontSize(10);
                                deduc.AddCell(importe).SetFont(calibri).SetFontSize(10);
                            }
                        }
                        deduc.AddCell("");
                        deduc.AddCell("");
                        deduc.AddCell("Total: " + totalDeduc).SetFontSize(12).SetFont(u).SetTextAlignment(TextAlignment.CENTER);
                        deduc.SetWidth((765 / 2)-10);
                        helperTable.AddCell(deduc.SetTextAlignment(TextAlignment.CENTER).SetBorder(Border.NO_BORDER));
                        float pageWidth = 765; // Ancho de la hoja
                         // Asignar el ancho de las columnas
                        helperTable.SetWidth(pageWidth);

                        // eliminar bordes
                        foreach (IElement element in helperTable.GetChildren())
                        {
                            if (element is Cell cell)
                            {
                                cell.SetBorder(Border.NO_BORDER);
                            }
                        }

                        document.Add(helperTable);

                        //Inseta total al final
                        RECIBO_DGV_Deducciones.Rows.Insert(RECIBO_DGV_Deducciones.Rows.Count, "", "", totalDeduc);
                        RECIBO_DGV_Deducciones.Rows[RECIBO_DGV_Deducciones.Rows.Count - 1].DefaultCellStyle.Font = new Font(RECIBO_DGV_Deducciones.Font, FontStyle.Bold);
                        document.Add(new Paragraph("__________________________________________________________________________________________________________________").SetTextAlignment(TextAlignment.CENTER));
                        document.Add(new Paragraph("Total: " + total + "           Total con letra: " + totalLetra).SetFont(u).SetPaddingTop(2).SetFontSize(12).SetTextAlignment(TextAlignment.CENTER));
                    }

                    document.Close();
                }
            }
        }
        private void loadRecibo(Recibos recibo)
        {
            RECIBO_TB_IdRecibo.Text = recibo.idRecibo.ToString();
            RECIBO_TB_FechaPago.Text = recibo.finPeriodo.ToString();
            RECIBO_TB_PeriodoPago.Text = $"{recibo.inicioPeriodo} - {recibo.finPeriodo}";
            RECIBO_TB_DiasTrabajados.Text = recibo.diasTrabajados.ToString();
            RECIBO_TB_Total.Text = recibo.total.ToString("C");
            RECIBO_TB_TotalLetra.Text = recibo.totalLetra;
        }

        private void loadEmp(Empleados emp)
        {
            RECIBO_TB_NombreEmp.Text = $"{emp.nombres} {emp.apPaterno} {emp.apMaterno}";
            RECIBO_TB_Imss.Text = emp.nss;
            RECIBO_TB_Curp.Text = emp.curp;
            RECIBO_TB_Rfc.Text = emp.rfc;
            RECIBO_TB_NoEmp.Text = emp.noEmpleado.ToString();
            RECIBO_TB_Puesto.Text = emp.puesto;
            RECIBO_TB_Departamento.Text = emp.departamento;
            RECIBO_TB_SalarioDiario.Text = emp.salarioDiario.ToString("C");
            RECIBO_TB_FechaAlta.Text = emp.fechaIngreso.ToString();
        }
        private void GREPORTE_DTP_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void RECIBO_BTN_Aplicar_Click(object sender, EventArgs e)
        {
            if (DB_Cassandra)
                getReciboC();
            else if (DB_SQLServer)
                getReciboSQL();
        }

        private void Clear()
        {
            RECIBO_DGV_Percepciones.Rows.Clear();
            RECIBO_DGV_Deducciones.Rows.Clear();

            RECIBO_TB_IdRecibo.Text = "";
            RECIBO_TB_FechaPago.Text = "";
            RECIBO_TB_PeriodoPago.Text = "";
            RECIBO_TB_DiasTrabajados.Text = "";
            RECIBO_TB_Total.Text = "";
            RECIBO_TB_TotalLetra.Text = "";

            RECIBO_TB_NombreEmp.Text = "";
            RECIBO_TB_Imss.Text = "";
            RECIBO_TB_Curp.Text = "";
            RECIBO_TB_Rfc.Text = "";
            RECIBO_TB_NoEmp.Text = "";
            RECIBO_TB_Puesto.Text = "";
            RECIBO_TB_Departamento.Text = "";
            RECIBO_TB_SalarioDiario.Text = "";
            RECIBO_TB_FechaAlta.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }

}
