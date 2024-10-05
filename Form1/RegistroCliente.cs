using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace Venta_de_Cartas
{
    public partial class RegistroCliente : Form
    {
        public RegistroCliente()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Mostrar registros de la tabla usuario
            CN_Usuario objetoCapaNegocioUsuario = new CN_Usuario();
            dataGridView1.DataSource = objetoCapaNegocioUsuario.ConsultarUsuario;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSi.Checked)
            {
                // Activar campos
                txtNombre.Enabled = true;
                txtApellido.Enabled = true;
                txtRUT.Enabled = true;
                txtTelefono.Enabled = true;
                txtDireccion.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNo.Checked)
            {
                // Desactivar campos
                txtNombre.Enabled = false;
                txtApellido.Enabled = false;
                txtRUT.Enabled = false;
                txtTelefono.Enabled = false;
                txtDireccion.Enabled = false;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
