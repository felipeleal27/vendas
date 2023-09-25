using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Games
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        

        private void btnVender_Click(object sender, EventArgs e)
        {
            Vendas vendas = new Vendas();
            this.Hide();
            vendas.ShowDialog();
            this.Close();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            Compras compras = new Compras();
            this.Hide();
            compras.ShowDialog();
            this.Close();
        }

        private void venderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void venderToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Vendas vendas = new Vendas();
            this.Hide();
            vendas.ShowDialog();
            this.Close();
        }

        private void comprarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Program.listaItems.Count == 0)
            {
                MessageBox.Show("Não há items na loja.");
            }
            else
            {
                Compras compras = new Compras();
                this.Hide();
                compras.ShowDialog();
                this.Close();
            }
            
        }
    }
}
