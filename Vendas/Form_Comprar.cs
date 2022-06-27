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
    public partial class Form_Comprar : Form
    {
        public Form_Comprar()
        {
            InitializeComponent();
            exibirProdutos();
        }
        List<Produto> listaProdutos = new List<Produto>();
        int id_ProdutoSelecionado;

        private void exibirProdutos()
        {

            listaProdutos = Produto.gerarListaProdutosCadastrados();
            comboBox_Produto.Items.Clear();
            foreach (Produto i in listaProdutos)
            {
                comboBox_Produto.Items.Add(i.Nome);
            }

        }

        private void exibirDadosProduto(string nomeSelecionado)
        {

            foreach (Produto i in listaProdutos)
            {

                //MessageBox.Show(comboBox_Cliente.Items[indice].ToString());
                if (i.Nome.Equals(nomeSelecionado))
                {

                    //falta o id_Produto
                    textBox_DadosProduto.Text = "";
                    textBox_DadosProduto.AppendText("Id Produto: " + i.Id_Produto + Environment.NewLine);
                    textBox_DadosProduto.AppendText("Nome: " + i.Nome + Environment.NewLine);
                    textBox_DadosProduto.AppendText("CodEAN: " + i.CodEAN + Environment.NewLine);
                    textBox_DadosProduto.AppendText("Preço: " + i.Preco + Environment.NewLine);
                    textBox_DadosProduto.AppendText("Disponível: " + i.Estoque + Environment.NewLine);

                    id_ProdutoSelecionado = i.Id_Produto;
                   
                    //textBox_Quantidade.Text = "";
                    //textBox_Quantidade.Text = "1";

                }
            }

        }

        private void comboBox_Produto_SelectedIndexChanged(object sender, EventArgs e)
        {
            exibirDadosProduto(comboBox_Produto.Items[comboBox_Produto.SelectedIndex].ToString());

        }

        private void button_ConfirmarCompra_Click(object sender, EventArgs e)
        {
            Comprar comprar = new Comprar();
            if (comprar.alterarEstoque(id_ProdutoSelecionado, int.Parse(textBox_Quantidade.Text)))
            {
                exibirProdutos(); //recarrega produtos após atualização do estoque

                textBox_Quantidade.Text = "";
                textBox_DadosProduto.Text = "";

                MessageBox.Show("Compra cadastrada com sucesso.\nEstoque atualizado.", "Compras");
            }
        }
    }
}
