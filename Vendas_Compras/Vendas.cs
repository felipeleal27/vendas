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
    public partial class Vendas : Form
    {
        public Vendas()
        {
            InitializeComponent();
        }

        private Bitmap img;
        private DateTime date;

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnImagem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                img = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = img;
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            date = dateP1.Value;
            string nGostei;
            string financeiro;
            string quebrado;

            string novo, usado;
            if (rdNovo.Checked) novo = "Novo"; else novo = "";
            if (rdUsado.Checked) usado = "Usado"; else usado = "";

            if (chkNgostei.Checked) nGostei = chkNgostei.Text;
            else nGostei = "";
            if (chkFinanceiro.Checked) financeiro = chkFinanceiro.Text;
            else financeiro = "";
            if (chkquebrado.Checked) quebrado = chkquebrado.Text;
            else quebrado = "";

            venda vendas = null;
            vendas = new venda();
            vendas.Dt = date;
            vendas.Novo = novo;
            vendas.Usado = usado;
            vendas.Img = img;
            vendas.Item = txtItem.Text;
            vendas.NGostei = nGostei;
            vendas.Financeiro = financeiro;
            vendas.Quebrado = quebrado;
            vendas.Valor = double.Parse(textBox2.Text);
            Program.listaVenda.Add(vendas);
            Program.listaItems.Add(txtItem.Text);
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
            
        }
    }
}
