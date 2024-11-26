using Cassandra.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MAD_AAVD_proyecto.Globals;
using CsvHelper;

namespace MAD_AAVD_proyecto
{
    public partial class FormConceptosAplicar : Form
    {
        bool aplicarEmp = false;
        bool aplicarDepto = false;
        bool CBCompleted = false;
        public List<Conceptos> listaConceptos;
        public FormConceptosAplicar()
        {
            InitializeComponent();
        }

        private void Reload()
        {
            if(DB_SQLServer)
            {
                var linkDB = new EnlaceDB();
                DataTable TablaDepartamentos = linkDB.GetDepto();
                CONCEPAPLICAR_CB_Departamentos.DataSource = TablaDepartamentos;
                CONCEPAPLICAR_CB_Departamentos.DisplayMember = "nombreDpto";  // dato
                CONCEPAPLICAR_CB_Departamentos.ValueMember = "noDepto";       // indice al que se relaciona el valor

                CONCEPAPLICAR_CB_EmpDepto.DataSource = TablaDepartamentos;
                CONCEPAPLICAR_CB_EmpDepto.DisplayMember = "nombreDpto";  // dato
                CONCEPAPLICAR_CB_EmpDepto.ValueMember = "noDepto";       // indice al que se relaciona el valor

                DataTable TablaPuestos = linkDB.GetPuesto();
                CONCEPAPLICAR_CB_EmpPuesto.DataSource = TablaPuestos;
                CONCEPAPLICAR_CB_EmpPuesto.DisplayMember = "nombrePuesto";
                CONCEPAPLICAR_CB_EmpPuesto.ValueMember = "noPuesto";

                DataTable TablaConceptos = linkDB.GetConceptos('f');
                CONCEPAPLICAR_CB_Conceptos.DataSource = TablaConceptos;
                CONCEPAPLICAR_CB_Conceptos.DisplayMember = "nombreConcepto";
                CONCEPAPLICAR_CB_Conceptos.ValueMember = "noConcepto";

                CBCompleted = true;
            }
            else if (DB_Cassandra)
            {
                var linkCassandra = new EnlaceCassandra();
                //EnlaceCassandra.conectar();
                //COMBOBOX CONCEPTOS
                listaConceptos = linkCassandra.GetConceptos(false);
                CONCEPAPLICAR_CB_Conceptos.DataSource = listaConceptos;
                CONCEPAPLICAR_CB_Conceptos.DisplayMember = "nombreConcepto";
                CONCEPAPLICAR_CB_Conceptos.ValueMember = "noConcepto";

                //COMBOBOX DEPARTAMENTOS
                string[] columnasDepto = { "noDepto", "nombreDpto" };
                List<Departamentos> listaDeptos = linkCassandra.Get_All<Departamentos>(columnasDepto, "DEPARTAMENTOS");
                CONCEPAPLICAR_CB_Departamentos.DataSource = listaDeptos;
                CONCEPAPLICAR_CB_Departamentos.DisplayMember = "nombreDpto";
                CONCEPAPLICAR_CB_Departamentos.ValueMember = "noDepto";

                CONCEPAPLICAR_CB_EmpDepto.DataSource = listaDeptos;
                CONCEPAPLICAR_CB_EmpDepto.DisplayMember = "nombreDpto";
                CONCEPAPLICAR_CB_EmpDepto.ValueMember = "noDepto";

                //COMBOBOX PUESTOS
                string[] columnasPuestos = { "noPuesto", "nombrePuesto" };
                List<Puestos> listaPuestos = linkCassandra.Get_All<Puestos>(columnasPuestos, "PUESTOS");
                CONCEPAPLICAR_CB_EmpPuesto.DataSource = listaPuestos;
                CONCEPAPLICAR_CB_EmpPuesto.DisplayMember = "nombrePuesto";
                CONCEPAPLICAR_CB_EmpPuesto.ValueMember = "noPuesto";
                //EnlaceCassandra.desconectar();
                CBCompleted = true;
            }

        }
        private void CONCEPAPLICAR_RB_Departamento_CheckedChanged(object sender, EventArgs e)
        {
            CONCEPAPLICAR_Panel_Departamento.Visible = true;
            CONCEPAPLICAR_Panel_Empleado.Visible = false;

            aplicarDepto = true;
        }

        private void CONCEPAPLICAR_RB_Empleado_CheckedChanged(object sender, EventArgs e)
        {
            CONCEPAPLICAR_Panel_Empleado.Visible = true;
            CONCEPAPLICAR_Panel_Departamento.Visible = false;

            aplicarEmp = true;
        }

        private void FormConceptosAplicar_Load(object sender, EventArgs e)
        {
            CONCEPAPLICAR_Panel_Empleado.Visible = false;
            CONCEPAPLICAR_Panel_Departamento.Visible = false;

            Reload();
        }

        private void ActualizarCBEmp()
        {
            CONCEPAPLICAR_CB_Emp.Text = "";

            if(DB_SQLServer)
            {
                var linkDB = new EnlaceDB();
                int departamento;
                int puesto;
                if (CONCEPAPLICAR_CB_EmpDepto.SelectedValue != null)
                    departamento = Convert.ToInt32(CONCEPAPLICAR_CB_EmpDepto.SelectedValue);
                else
                    departamento = -1;

                if (CONCEPAPLICAR_CB_EmpPuesto.SelectedValue != null)
                    puesto = Convert.ToInt32(CONCEPAPLICAR_CB_EmpPuesto.SelectedValue);
                else
                    puesto = -1;


                DataTable empleados = linkDB.GetEmpleados('H', departamento, puesto, CONCEPAPLICAR_DTP_EmpFecha.Value);
                CONCEPAPLICAR_CB_Emp.DataSource = empleados;
                CONCEPAPLICAR_CB_Emp.DisplayMember = "nombreEmpleado";
                CONCEPAPLICAR_CB_Emp.ValueMember = "noEmpleado";
            }
            else if(DB_Cassandra)
            {
                var linkCassandra = new EnlaceCassandra();

                List<Empleados> listaEmpleados = linkCassandra.FilterEmpleados(CONCEPAPLICAR_DTP_EmpFecha.Value, true, false, CONCEPAPLICAR_CB_EmpDepto.Text, CONCEPAPLICAR_CB_EmpPuesto.Text);
                CONCEPAPLICAR_CB_Emp.DataSource = listaEmpleados;
                CONCEPAPLICAR_CB_Emp.DisplayMember = "nombres";
                CONCEPAPLICAR_CB_Emp.ValueMember = "noEmpleado";

                CONCEPAPLICAR_CB_Emp.SelectedItem = 0;
            }
            
        }
        private void CONCEPAPLICAR_CB_EmpPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CBCompleted)
                ActualizarCBEmp();
        }

        private void CONCEPAPLICAR_CB_EmpDepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBCompleted)
                ActualizarCBEmp();
        }

        private void CONCEPAPLICAR_CB_Emp_SelectedItemChanged(object sender, EventArgs e)
        {
            //Escribir numero de empleado
            CONCEPAPLICAR_TB_NoEmp.Text = CONCEPAPLICAR_CB_Emp.SelectedValue.ToString();
        }

        private void CONCEPAPLICAR_BTN_Registrar_Click(object sender, EventArgs e)
        {
            string noEmp = CONCEPAPLICAR_TB_NoEmp.Text;
            
            if(DB_SQLServer)
            {
                var linkDB = new EnlaceDB();
                
                int concepto;
                if (CONCEPAPLICAR_CB_Conceptos.SelectedValue != null)
                    concepto = Convert.ToInt32(CONCEPAPLICAR_CB_Conceptos.SelectedValue);
                else
                    concepto = -1;

                int departamento;
                if (CONCEPAPLICAR_CB_Departamentos.SelectedValue != null)
                    departamento = Convert.ToInt32(CONCEPAPLICAR_CB_Departamentos.SelectedValue);
                else
                    departamento = -1;

                if (aplicarEmp)
                {
                    bool ok = linkDB.insertConcepto(false, concepto, CONCEPAPLICAR_DTP_Fecha.Value, int.Parse(noEmp));
                    if (ok)
                        MessageBox.Show("Se ha insertado correctamente");
                }
                else if (aplicarDepto)
                {
                    bool ok = linkDB.insertConcepto(true, concepto, CONCEPAPLICAR_DTP_Fecha.Value, 0, departamento);
                    if (ok)
                        MessageBox.Show("Se ha insertado correctamente");
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////
            else if (DB_Cassandra)
            {
                var linkCassandra = new EnlaceCassandra();

                if (aplicarEmp)
                {
                    if (noEmp != null || noEmp == "")
                    {
                        //EnlaceCassandra.conectar();
                        CONCEPAPLICAR_LBL_Loading.Visible = true;

                        //Validar la fecha del concepto
                        //Traer ultima nomina generada
                        // Obtener la lista de nóminas generadas
                        string[] primaryKey = { "year", "month" }; string[] columnas = primaryKey;
                        List<RegistroNominas> nominasGeneradas = linkCassandra.Get_All<RegistroNominas>(columnas, "REGISTRO_NOMINAS");

                        // Verificar si la lista contiene datos
                        if (nominasGeneradas != null && nominasGeneradas.Count > 0)
                        {
                            // Ordenar por año y mes en orden descendente
                            RegistroNominas ultimaNomina = nominasGeneradas
                                .OrderByDescending(n => n.year)
                                .ThenByDescending(n => n.month)
                                .FirstOrDefault();

                            if (ultimaNomina != null)
                            {
                                // Convertir el año y mes a un objeto DateTime
                                DateTime fechaUltimaNomina = new DateTime(ultimaNomina.year, ultimaNomina.month, 1);

                                // Comparar con la nueva fecha seleccionada
                                DateTime nuevaFecha = CONCEPAPLICAR_DTP_Fecha.Value;
                                DateTime primerDiaNuevoMes = new DateTime(nuevaFecha.Year, nuevaFecha.Month, 1);

                                // Verificar si la nueva fecha es el mes siguiente de la última nómina
                                DateTime mesSiguiente = fechaUltimaNomina.AddMonths(1);
                                if (primerDiaNuevoMes == mesSiguiente && nuevaFecha > iniCompany) //Es válido
                                {
                                    //1. Obtener Empleado en el puesto activo durante esa fecha
                                    string[] auxcolumnas = { "noEmpleado", "nombres", "apPaterno", "apMaterno", "curp", "rfc", "nss", "banco", "noCuenta", "salarioDiario", "departamento", "puesto", "fechaIngreso" };
                                    Empleados empleado = linkCassandra.LastPuesto2<Empleados>(auxcolumnas, noEmp, CONCEPAPLICAR_DTP_Fecha.Value);

                                    aplicarCpEmp(empleado, CONCEPAPLICAR_CB_Conceptos.SelectedValue.ToString(), CONCEPAPLICAR_DTP_Fecha.Value);
                                }
                                else
                                {
                                    MessageBox.Show("Fecha inválida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else if (CONCEPAPLICAR_DTP_Fecha.Value > iniCompany)//Es válida
                        {
                            //1. Obtener Empleado en el puesto activo durante esa fecha
                            string[] auxcolumnas = { "noEmpleado", "nombres", "apPaterno", "apMaterno", "curp", "rfc", "nss", "banco", "noCuenta", "salarioDiario", "departamento", "puesto", "fechaIngreso" };
                            Empleados empleado = linkCassandra.LastPuesto2<Empleados>(auxcolumnas, noEmp, CONCEPAPLICAR_DTP_Fecha.Value);

                            aplicarCpEmp(empleado, CONCEPAPLICAR_CB_Conceptos.SelectedValue.ToString(), CONCEPAPLICAR_DTP_Fecha.Value);
                        }
                        else//No es válida
                        {
                            MessageBox.Show("Fecha inválida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        CONCEPAPLICAR_LBL_Loading.Visible = false;
                        //EnlaceCassandra.desconectar();
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un empleado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (aplicarDepto)
                {
                    //EnlaceCassandra.conectar();
                    CONCEPAPLICAR_LBL_Loading.Visible = true;

                    string[] primaryKey = { "year", "month" }; string[] columnas = primaryKey;
                    List<RegistroNominas> nominasGeneradas = linkCassandra.Get_All<RegistroNominas>(columnas, "REGISTRO_NOMINAS");

                    // Verificar si la lista contiene datos
                    if (nominasGeneradas != null && nominasGeneradas.Count > 0)
                    {
                        // Ordenar por año y mes en orden descendente
                        RegistroNominas ultimaNomina = nominasGeneradas
                            .OrderByDescending(n => n.year)
                            .ThenByDescending(n => n.month)
                            .FirstOrDefault();

                        if (ultimaNomina != null)
                        {
                            // Convertir el año y mes a un objeto DateTime
                            DateTime fechaUltimaNomina = new DateTime(ultimaNomina.year, ultimaNomina.month, 1);

                            // Comparar con la nueva fecha seleccionada
                            DateTime nuevaFecha = CONCEPAPLICAR_DTP_Fecha.Value;
                            DateTime primerDiaNuevoMes = new DateTime(nuevaFecha.Year, nuevaFecha.Month, 1);

                            // Verificar si la nueva fecha es el mes siguiente de la última nómina
                            DateTime mesSiguiente = fechaUltimaNomina.AddMonths(1);
                            if (primerDiaNuevoMes == mesSiguiente && nuevaFecha > iniCompany) //Es válido
                            {
                                //Obtener empleados
                                //Por cada empleado llamar aplicarEmp
                                List<Empleados> empleadosDepto = linkCassandra.FilterEmpByDepto(CONCEPAPLICAR_DTP_Fecha.Value, CONCEPAPLICAR_CB_Departamentos.Text);
                                foreach (var empleado in empleadosDepto)
                                {
                                    aplicarCpEmp(empleado, CONCEPAPLICAR_CB_Conceptos.SelectedValue.ToString(), CONCEPAPLICAR_DTP_Fecha.Value);
                                }
                                CONCEPAPLICAR_LBL_Loading.Visible = false;
                            }
                            else
                            {
                                MessageBox.Show("Fecha inválida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else if (CONCEPAPLICAR_DTP_Fecha.Value > iniCompany)//Es válida
                    {
                        //Obtener empleados
                        //Por cada empleado llamar aplicarEmp
                        List<Empleados> empleadosDepto = linkCassandra.FilterEmpByDepto(CONCEPAPLICAR_DTP_Fecha.Value, CONCEPAPLICAR_CB_Departamentos.Text);
                        foreach (var empleado in empleadosDepto)
                        {
                            aplicarCpEmp(empleado, CONCEPAPLICAR_CB_Conceptos.SelectedValue.ToString(), CONCEPAPLICAR_DTP_Fecha.Value);
                        }
                        CONCEPAPLICAR_LBL_Loading.Visible = false;
                    }
                    else//No es válida
                    {
                        MessageBox.Show("Fecha inválida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    CONCEPAPLICAR_LBL_Loading.Visible = false;
                    //EnlaceCassandra.desconectar();
                }
                else
                {
                    MessageBox.Show("Seleccione un empleado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
        

        private void aplicarCpEmp(Empleados empleado, string noConcepto, DateTime fecha)
        {
            var linkCassandra = new EnlaceCassandra();

            if (empleado != null)
            {
                //2. Se trae el concepto a insertar de la lista que ya se trajo para hacer más rápido el proceso
                //Conceptos concepto = listaConceptos[int.Parse(noConcepto)-1]; //Índice del comboBox
                Conceptos concepto = listaConceptos.FirstOrDefault(c => c.noConcepto == int.Parse(noConcepto));

                //3. Insertar en recibo
                linkCassandra.InsertRecibo(empleado, concepto, fecha, true);
                MessageBox.Show("Insertado con éxito");
            }
            
        }

        private void CONCEPAPLICAR_CB_Conceptos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
