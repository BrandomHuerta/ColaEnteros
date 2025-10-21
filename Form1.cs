using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColaEnteros
{
    public partial class Form1 : Form
    {
        private Cola cola;

        public Form1()
        {
            InitializeComponent();
            cola = new Cola(5);
        }

        private void btnEncolar_Click(object sender, EventArgs e)
        {
            try
            {
                int valor = int.Parse(txtValor.Text);
                cola.Encolar(valor);
                ActualizarLista();
                txtValor.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDesencolar_Click(object sender, EventArgs e)
        {
            try
            {
                int eliminado = cola.Desencolar();
                MessageBox.Show($"Elemento eliminado: {eliminado}");
                ActualizarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ActualizarLista()
        {
            lstCola.Items.Clear();
            foreach (int n in cola.ObtenerElementos())
            {
                lstCola.Items.Add(n);
            }
        }
    }
}

