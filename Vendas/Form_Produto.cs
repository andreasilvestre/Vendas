using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vendas
{
    public partial class Form_Produto : Form
    {
        public Form_Produto()
        {
            InitializeComponent();
        }

        private void Limpar()
        {
            textBox_Nome.Text = "";
            textBox_CodEAN.Text = "";
            textBox_Preco.Text = "";
            textBox_Estoque.Text = "";
        }
        private void button_Cadastrar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto(textBox_Nome.Text, int.Parse(textBox_CodEAN.Text), float.Parse(textBox_Preco.Text), int.Parse(textBox_Estoque.Text));
            //MessageBox.Show("Nome: " + produto.Nome + "\nPreço: " + produto.Preco);
            if (produto.gravarProduto())
            {
                MessageBox.Show("Produto cadastrado com sucesso.");
            }

        }

        private void button_Limpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
