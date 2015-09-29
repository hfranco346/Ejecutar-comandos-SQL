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
    public partial class CommandText : Form
    {
        public CommandText()
        {
            InitializeComponent();
        }

        private void CommandText_Load(object sender, EventArgs e)
        {
            // Crear conexión
            SqlConnection conn = new SqlConnection(@"server = .\sqlexpress;
                    integrated security = true; database = AdventureWorks2014");

            // Crear el comando
            SqlCommand cmd = new SqlCommand();

            try
            {
                // Establecer la conexión
                conn.Open();

                txtCommandText.AppendText("Conexión establecida\n");
                txtCommandText.AppendText("Comando creado.\n");

                // Dando el valor al SqlCommand
                cmd.CommandText = @"select Name, ProductNumber from Production.Product";

                txtCommandText.AppendText("Listo para ejecutar el comando SQL: \n\t\t\t" + cmd.CommandText);

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Detalles de la excepción");
            }
            finally
            {
                conn.Close();
                txtCommandText.AppendText("\nConexión cerrada.");
            }
        }
    }
}
