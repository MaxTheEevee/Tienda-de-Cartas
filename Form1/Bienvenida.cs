using Form1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Venta_de_Cartas
{
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();
        }

        private void btnRegistrarMarca_Click(object sender, EventArgs e)
        {
            RegistroMarcas registroMarcas = new RegistroMarcas();
            registroMarcas.Show();
            this.Hide();
        }

        private void btnRegistrarInventario_Click(object sender, EventArgs e)
        {
            RegistroProd registroProd = new RegistroProd();
            registroProd.Show();
            this.Hide();
        }

        private void btnVentaCartas_Click(object sender, EventArgs e)
        {
            RegistroCliente registroCliente = new RegistroCliente();
            registroCliente.Show();
            this.Hide();
        }

        private void Bienvenida_Load(object sender, EventArgs e)
        {

        }
    }
}
