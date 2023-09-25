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
    public partial class Compras : Form
    {
        public Compras()
        {
            InitializeComponent();
            foreach(var item in Program.listaItems)
            {
                cbmPesquisa.Items.Add(item);
            }
        }

        private void cbmPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            label2.Visible = true;
            foreach (var item in Program.listaVenda)
            {
                if (item.Item == cbmPesquisa.SelectedItem.ToString())
                {
                    pctCompra.Image = item.Img;
                    label2.Text = item.Mostra();
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.listaItems.Remove(cbmPesquisa.SelectedItem.ToString());
            Form1 form1 = new Form1();
            MessageBox.Show("Compra efetuada com sucesso!");
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }
    }
}
