using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Ejecutar_comandos
{
    public partial class DML_Insertar : Form
    {
        public DML_Insertar()
        {
            InitializeComponent();
        }

        private void btnInsertarMoneda_Click(object sender, EventArgs e)
        {
            // Crear la conexión
            SqlConnection conn = new SqlConnection(@"server = .\sqlexpress; 
                    integrated security = true; database = AdventureWorks2014");

            // DML de inserción
            string sqlIns = "Insert into Sales.Currency(CurrencyCode, Name, ModifiedDate)" +
                "Values(" + "'" + txtCodigoMoneda.Text + "','" + txtNombreMoneda.Text + "','" +
                dtpFechaModificacion.Value.ToString() + "')";

            // Crear el comando
            SqlCommand cmd = new SqlCommand(sqlIns, conn);

            try
            {
                // Establecer la conexión
                conn.Open();

                txtEstado.Text = sqlIns;

                cmd.ExecuteNonQuery();

                lblEstadoInsercion.Text = "¡Nueva moneda agregada satisfactoriamente!";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Detalles de la excepción");
            }
            finally
            {
                // Cerrar la conexión
                conn.Close();
            }
        }
    }
}
