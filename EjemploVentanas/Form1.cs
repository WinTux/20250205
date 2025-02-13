using EjemploVentanas.Models;
using Microsoft.Data.SqlClient;
using System.Globalization;

namespace EjemploVentanas
{
    public partial class Form1 : Form
    {
        string cadena = @"Server=192.168.1.254;DataBase=UniversidadX;User=sa;password=123456ABCxyz;Encrypt=False;TrustServerCertificate=True";//cadena de conexi�n

        public Form1()
        {
            InitializeComponent();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            lblSaludo.Text = $"Hola {txtNombre.Text}, buenas noches!!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int res = 0, res2 = 0;
            bool exito = int.TryParse(txtNum1.Text, out res) && int.TryParse(txtNum2.Text, out res2);
            if (exito)
            {
                lblResultado.Text = $"Resultado: {res + res2}";
                txtNum1.Text = txtNum2.Text = "";
            }
            else
            {
                txtNum1.Text = txtNum2.Text = "";
                lblResultado.Text = "INGRESE N�MEROS ENTEROS";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Estudiante estForm = new Estudiante();
            estForm.nombre = txtFormNombre.Text;
            estForm.apellido = txtFormApellido.Text;
            estForm.fechaNacimiento =
                datePckFormFechaNac.Value;
            estForm.pregrado = chckFormPregrado.Checked;
            float valor = 0f;
            bool exito = float.TryParse(txtFormPromedio.Text, out valor);
            estForm.promedio = exito ? valor : 0;
            lblEstudianteRegistrado.Text = "Se registr� exitosamente!";
            lblEstudianteRegistrado.Text = $"Se registr� al estudiante\n{estForm.nombre} {estForm.apellido}\nnacido en fecha {estForm.fechaNacimiento.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture)}\nque es estudiante de {(estForm.pregrado ? "pregrado" : "postgrado")}\ncon promedio {estForm.promedio.ToString("0.0")}.";
            registrarEnBaseDeDatos(estForm);
            lblEstudianteRegistrado.Text += "\nRegistrado en la Base de Datos";
        }

        private void registrarEnBaseDeDatos(Estudiante est)
        {
            using (SqlConnection con = new SqlConnection(cadena))
            {
                con.Open();
                // Armar una sentencia SQL INSERT
                string sql = "insert into Estudiante (nombre, apellido, fechaNacimiento, pregrado, promedio) values (@n,@a,@f,@pre,@pro)";
                // Enviarla como comando
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@n", est.nombre);
                    cmd.Parameters.AddWithValue("@a", est.apellido);
                    cmd.Parameters.AddWithValue("@f", est.fechaNacimiento);
                    cmd.Parameters.AddWithValue("@pre", est.pregrado);
                    cmd.Parameters.AddWithValue("@pro", est.promedio);
                    int n = cmd.ExecuteNonQuery();
                }
                con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            int id = 0;
            bool exito = int.TryParse(txtId.Text, out id);

            using (SqlConnection con = new SqlConnection(cadena))
            {
                con.Open();
                // Armar una sentencia SQL INSERT
                string sql = "delete from Estudiante where id = @id";
                // Enviarla como comando
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    if (exito)
                    {
                        // Si el usario ingresa un n�mero
                        cmd.Parameters.AddWithValue("@id", id);
                        lblMensajeEliminar.Text = cmd.ExecuteNonQuery() == 1 ? "Se elimin� exitosamente" : "El estudiante no existe (no se hizo nada)";
                    }
                }
                con.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int id = 0;
            bool exito = int.TryParse(txtModId.Text, out id);
            using (SqlConnection con = new SqlConnection(cadena))
            {
                con.Open();
                // Armar una sentencia SQL INSERT
                string sql = "update Estudiante set nombre = @n, apellido = @a, fechaNacimiento = @f, pregrado = @pre, promedio = @pro where id = @id";
                // Enviarla como comando
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    if (exito)
                    {
                        // Si el usario ingresa un n�mero
                        cmd.Parameters.AddWithValue("@n", txtModNombre.Text);
                        cmd.Parameters.AddWithValue("@a", txtModApellido.Text);
                        cmd.Parameters.AddWithValue("@f", tdPckrModFechaNac.Value);
                        cmd.Parameters.AddWithValue("@pre", chkModPregrado.Checked);
                        cmd.Parameters.AddWithValue("@pro", txtModPromedio.Text);
                        lblModMensaje.Text = cmd.ExecuteNonQuery() == 1 ? "Se modific� exitosamente" : "El estudiante no existe (no se hizo nada)";
                    }
                }
                con.Close();
            }
        }
    }

}
