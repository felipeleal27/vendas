using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games
{
    internal class venda
    {
        private string item;
        private double valor;
        private string nGostei;
        private string financeiro;
        private string quebrado;
        private string novo;
        private string usado;
        private Bitmap img;
        private DateTime dt;

        public string Item { get => item; set => item = value; }
        public double Valor { get => valor; set => valor = value; }
        public string NGostei { get => nGostei; set => nGostei = value; }
        public string Financeiro { get => financeiro; set => financeiro = value; }
        public string Quebrado { get => quebrado; set => quebrado = value; }
        public Bitmap Img { get => img; set => img = value; }
        public DateTime Dt { get => dt; set => dt = value; }
        public string Novo { get => novo; set => novo = value; }
        public string Usado { get => usado; set => usado = value; }

        public string Mostra()
        {
            string aux = $"Item: {Item}\n\nSituação: {Novo}{Usado}\n\nValor: {Valor}\n\n" +
                $"Data da venda: {Dt.ToString("dd/MM/yyy - HH:mm")}" +
                $"\n\nMotivo da venda:\n  {NGostei}\n" +
                $"  {Financeiro}\n  {Quebrado}";
            return aux;
        }
    }
}
