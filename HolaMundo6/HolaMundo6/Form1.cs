using System.Text.RegularExpressions;

namespace HolaMundo6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContrasenados_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnValidar_Click(object sender, EventArgs e)
        {
            Regex validacion = new Regex("^(?=.*[A-Z])(?=.*[a-z])(?=.*\\d)(?=.*[\\W_]).*$");

            if (string.IsNullOrEmpty(txtContrasenauno.Text) &&
               string.IsNullOrEmpty(txtContrasenados.Text))
            {
                MessageBox.Show("Los campos estan vacios");
                return;
            }

            if (!txtContrasenauno.Text.Equals(txtContrasenados.Text))
            {
                MessageBox.Show("Las contrase�as no son iguales");
                return;
            }

            if (validacion.IsMatch(txtContrasenauno.Text))
            {
                MessageBox.Show("La contrase�a es valida");
                return;
            }
            else
            {
                MessageBox.Show("La contrase�a no es valida");
                return;
            }
        }
    }
}