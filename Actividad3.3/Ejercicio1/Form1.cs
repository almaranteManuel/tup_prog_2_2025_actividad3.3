using Ejercicio1.Models;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Estancia estancia;

        private void button1_Click(object sender, EventArgs e)
        {
            estancia = new Estancia("Pedro", "AB12", 1250.5);
            estancia.casco.Administrador = "Jorge";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            estancia.AgregarCampo("AB13", 3200.2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int n = 0; n < estancia.VerCantidadCampos(); n++)
            {
                Campo campo = estancia.VerCampo(n);
                comboBox1.Items.Add(campo);
            }
            
        }
    }
}
