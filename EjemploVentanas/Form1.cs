using EjemploVentanas.Models;
using Microsoft.Data.SqlClient;
using System.Globalization;
using System.Text.Json;

namespace EjemploVentanas
{
    public partial class Form1 : Form
    {
        string cadena = @"Server=192.168.1.254;DataBase=UniversidadX;User=sa;password=123456ABCxyz;Encrypt=False;TrustServerCertificate=True";//cadena de conexión

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
                lblResultado.Text = "INGRESE NÚMEROS ENTEROS";
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
            lblEstudianteRegistrado.Text = "Se registró exitosamente!";
            lblEstudianteRegistrado.Text = $"Se registró al estudiante\n{estForm.nombre} {estForm.apellido}\nnacido en fecha {estForm.fechaNacimiento.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture)}\nque es estudiante de {(estForm.pregrado ? "pregrado" : "postgrado")}\ncon promedio {estForm.promedio.ToString("0.0")}.";
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
                        // Si el usario ingresa un número
                        cmd.Parameters.AddWithValue("@id", id);
                        lblMensajeEliminar.Text = cmd.ExecuteNonQuery() == 1 ? "Se eliminó exitosamente" : "El estudiante no existe (no se hizo nada)";
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
                        // Si el usario ingresa un número
                        cmd.Parameters.AddWithValue("@n", txtModNombre.Text);
                        cmd.Parameters.AddWithValue("@a", txtModApellido.Text);
                        cmd.Parameters.AddWithValue("@f", tdPckrModFechaNac.Value);
                        cmd.Parameters.AddWithValue("@pre", chkModPregrado.Checked);
                        cmd.Parameters.AddWithValue("@pro", txtModPromedio.Text);
                        cmd.Parameters.AddWithValue("@id", id);
                        lblModMensaje.Text = cmd.ExecuteNonQuery() == 1 ? "Se modificó exitosamente" : "El estudiante no existe (no se hizo nada)";
                    }
                }
                con.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int id = 0;
            bool exito = int.TryParse(txtModId.Text, out id);
            if (exito)
            {
                // Es un número válido
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    // Armar una sentencia SQL INSERT
                    string sql = "select * from Estudiante where id = @id";
                    // Enviarla como comando
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        SqlDataReader reader;
                        reader = cmd.ExecuteReader();
                        bool flag = false;
                        while (reader.Read())
                        {
                            flag = true;
                            // Asignar los campos al formulario
                            txtModNombre.Text = reader.GetString(1); // index-0
                            txtModApellido.Text = reader.GetString(2);
                            tdPckrModFechaNac.Value = reader.GetDateTime(3);
                            chkModPregrado.Checked = reader.GetBoolean(4);
                            txtModPromedio.Text = reader.GetDecimal(5).ToString();

                        }
                        if (!flag)
                            lblModMensaje.Text = $"El estudiante con ID {id} no existe.";

                    }
                    con.Close();
                }
            }
            else
                lblModMensaje.Text = $"El estudiante con ID {txtModId.Text} no es válido";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cadena))
            {
                con.Open();
                // Armar una sentencia SQL INSERT
                string sql = "select * from Estudiante";
                // Enviarla como comando
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    SqlDataReader reader;
                    reader = cmd.ExecuteReader();
                    List<Estudiante> estudiantes = new List<Estudiante>();
                    while (reader.Read())
                    {
                        Estudiante estudiante = new Estudiante();
                        estudiante.id = reader.GetInt32(0);
                        estudiante.nombre = reader.GetString(1);
                        estudiante.apellido = reader.GetString(2);
                        estudiante.fechaNacimiento = reader.GetDateTime(3);
                        estudiante.pregrado = reader.GetBoolean(4);
                        estudiante.promedio = (float)reader.GetDecimal(5);

                        estudiantes.Add(estudiante);
                    }
                    tblEstudiantes.DataSource = estudiantes;
                    //tblEstudiantes.Columns["pre"].HeaderText = "PREGRADO";
                    //tblEstudiantes.Columns["id"].Width = 3;
                }
                con.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cadena))
            {
                con.Open();
                // Armar una sentencia SQL INSERT
                string sql = "select * from Estudiante where pregrado = 1";
                // Enviarla como comando
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    SqlDataReader reader;
                    reader = cmd.ExecuteReader();
                    List<Estudiante> estudiantes = new List<Estudiante>();
                    while (reader.Read())
                    {
                        Estudiante estudiante = new Estudiante();
                        estudiante.id = reader.GetInt32(0);
                        estudiante.nombre = reader.GetString(1);
                        estudiante.apellido = reader.GetString(2);
                        estudiante.fechaNacimiento = reader.GetDateTime(3);
                        estudiante.pregrado = reader.GetBoolean(4);
                        estudiante.promedio = (float)reader.GetDecimal(5);

                        estudiantes.Add(estudiante);
                    }
                    tblEstudiantes.DataSource = estudiantes;
                    //tblEstudiantes.Columns["pre"].HeaderText = "PREGRADO";
                    //tblEstudiantes.Columns["id"].Width = 3;
                }
                con.Close();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cadena))
            {
                con.Open();
                // Armar una sentencia SQL INSERT
                string sql = "select * from Estudiante where pregrado = 0";
                // Enviarla como comando
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    SqlDataReader reader;
                    reader = cmd.ExecuteReader();
                    List<Estudiante> estudiantes = new List<Estudiante>();
                    while (reader.Read())
                    {
                        Estudiante estudiante = new Estudiante();
                        estudiante.id = reader.GetInt32(0);
                        estudiante.nombre = reader.GetString(1);
                        estudiante.apellido = reader.GetString(2);
                        estudiante.fechaNacimiento = reader.GetDateTime(3);
                        estudiante.pregrado = reader.GetBoolean(4);
                        estudiante.promedio = (float)reader.GetDecimal(5);

                        estudiantes.Add(estudiante);
                    }
                    tblEstudiantes.DataSource = estudiantes;
                    //tblEstudiantes.Columns["pre"].HeaderText = "PREGRADO";
                    //tblEstudiantes.Columns["id"].Width = 3;

                }
                con.Close();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cadena))
            {
                con.Open();
                // Armar una sentencia SQL INSERT
                string sql = "get_mejores_est";
                // Enviarla como comando
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@min", System.Data.SqlDbType.Decimal));
                    cmd.Parameters["@min"].Value = 80;
                    SqlDataReader reader;
                    reader = cmd.ExecuteReader();
                    List<EstudianteSimple> estudiantes = new List<EstudianteSimple>();
                    while (reader.Read())
                    {
                        EstudianteSimple estudiante = new EstudianteSimple();
                        estudiante.id = reader.GetInt32(0);
                        estudiante.nombre = reader.GetString(1);
                        estudiante.apellido = reader.GetString(2);
                        estudiantes.Add(estudiante);
                    }
                    tblEstudiantes.DataSource = estudiantes;
                }
                con.Close();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // Lista de objetos a guardar
            List<Estudiante> ests = new List<Estudiante>();
            foreach (DataGridViewRow fila in tblEstudiantes.Rows) {
                if (!fila.IsNewRow) {
                    Estudiante est = new Estudiante { 
                        id = Convert.ToInt32(fila.Cells[0].Value),
                        nombre = Convert.ToString(fila.Cells[1].Value),
                        apellido = Convert.ToString(fila.Cells[2].Value),
                        pregrado = Convert.ToBoolean(fila.Cells[3].Value),
                        promedio = (float)Convert.ToDecimal(fila.Cells[4].Value),
                        fechaNacimiento = Convert.ToDateTime(fila.Cells[5].Value)
                    };
                    ests.Add(est);
                }
            }
            try {
                // Ruta donde guardar (datos.json)
                string ruta = "datos.json";
                // Serializar el objeto
                string jsonEstudiantes = JsonSerializer.Serialize(ests);
                // Guardar
                File.WriteAllText(ruta, jsonEstudiantes);
                lblMensajeGuardado.Text = "Exito!!";
            }
            catch (Exception ex) { 
                Console.WriteLine(ex.Message);
            }
        }
    }

}
