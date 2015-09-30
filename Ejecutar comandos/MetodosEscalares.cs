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
    public partial class MetodosEscalares : Form
    {
        public MetodosEscalares()
        {
            InitializeComponent();
        }

        private void btnTotalFilas_Click(object sender, EventArgs e)
        {
            // Crear la conexión
            SqlConnection conn = new SqlConnection(@"server = .\sqlexpress; 
                    integrated security = true; database = AdventureWorks2014");

            // Crear el query Scalar
            string sql = @"select count(*) from Production.Product";

            // Crear el comando
            SqlCommand cmd = new SqlCommand(sql, conn);
            txtEscalar.AppendText("Comando y conexión creada.\n");

            try
            {
                // Establecer la conexión
                conn.Open();

                txtEscalar.AppendText("El número de productos es: ");

                // Ejecutar el query Scalar con el método ExecuteScalar
                txtEscalar.AppendText(cmd.ExecuteScalar().ToString());
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
                txtEscalar.AppendText("\nConexión cerrada.");
            }
        }
    }
}
