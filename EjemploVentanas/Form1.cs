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
            int res = 0, res2=0;
            bool exito = int.TryParse(txtNum1.Text,out res) && int.TryParse(txtNum2.Text, out res2);
            if (exito)
            {
                lblResultado.Text = $"Resultado: {res + res2}";
                txtNum1.Text = txtNum2.Text = "";
            }
            else {
                txtNum1.Text = txtNum2.Text = "";
                lblResultado.Text = "INGRESE NÚMEROS ENTEROS";
            }
            
        }
    }

}
