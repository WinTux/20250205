using EjemploVentanas.Models;
using System.Globalization;

namespace EjemploVentanas
{
    public partial class Form1 : Form
    {
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
            estForm.promedio = exito?valor:0;
            lblEstudianteRegistrado.Text = "Se registró exitosamente!";
            string pre = "pregrado", post = "postgrado";
            lblEstudianteRegistrado.Text = $"Se registró al estudiante\n{estForm.nombre} {estForm.apellido}\nnacido en fecha {estForm.fechaNacimiento.ToString("dd-MM-yyyy",CultureInfo.InvariantCulture)}\nque es estudiante de {estForm.pregrado} con promedio {estForm.promedio}.";
        }
    }

}
