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
    public partial class Form_Vender : Form
    {
        public Form_Vender()
        {
            InitializeComponent();
            exibirClientes();
            exibirProdutos();
        }

        /// <summary>
        /// guarda todos os clientes cadastrados no sistema
        /// </summary>
        List<Cliente> listaClientes = new List<Cliente>();

        /// <summary>
        /// guarda todos os produtos cadastrados no sistema
        /// </summary>
        List<Produto> listaProdutos = new List<Produto>();

        List<Vender> listaItensVenda = new List<Vender>();


        /// <summary>
        /// guarda o id do cliente que foi selecionado
        /// </summary>
        int id_ClienteSelecionado;

        /// <summary>
        /// variáveis que irão guardar os dados do produto selecionado
        /// </summary>
        int id_ProdutoSelecionado;
        string NomeProdutoSelecionado;
        float PrecoProdutoSelecionado;
        //a quantidade pega o que está digitado na tela

        /// <summary>
        /// guarda o valor total da venda a realizar
        /// </summary>
        float ValorVenda = 0;

        /// <summary>
        /// guarda a quantidade disponível do produto - Estoque
        /// </summary>
        int EstoqueProdutoSelecionado;

        /// <summary>
        /// guarda a quantidade de itens(produtos) que estão no pedido de vendas
        /// </summary>
        int contaProdutos = 0;



        //carrega o combobox com o nome dos clientes
        private void exibirClientes()
        {

            listaClientes = Cliente.gerarListaClientes();
            comboBox_Cliente.Items.Clear();
            foreach (Cliente i in listaClientes)
            {
                comboBox_Cliente.Items.Add(i.Nome);
            }

        }

        //carrega o combobox de produtos atualizados
        private void exibirProdutos()
        {

            listaProdutos = Produto.gerarListaProdutos();
            comboBox_Produto.Items.Clear();
            foreach (Produto i in listaProdutos)
            {
                comboBox_Produto.Items.Add(i.Nome);
            }

        }
        private void exibirDadosCliente(string nomeSelecionado)
        {
          
            foreach (Cliente i in listaClientes)
            {
                
                //MessageBox.Show(comboBox_Cliente.Items[indice].ToString());
                if (i.Nome.Equals(nomeSelecionado)) 
                {
                    
                    id_ClienteSelecionado = i.Id_Cliente;

                    textBox_DadosCliente.Text = "";
                    textBox_DadosCliente.AppendText("Nome: " + i.Nome + Environment.NewLine);
                    textBox_DadosCliente.AppendText("CPF: " + i.Cpf + Environment.NewLine);
                    textBox_DadosCliente.AppendText("Telefone: " + i.Telefone + Environment.NewLine);
                    textBox_DadosCliente.AppendText("Email: " + i.Email + Environment.NewLine);
                }
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
                    textBox_DadosProduto.AppendText("Nome: " + i.Nome + Environment.NewLine);
                    textBox_DadosProduto.AppendText("CodEAN: " + i.CodEAN + Environment.NewLine);
                    textBox_DadosProduto.AppendText("Preço: " + i.Preco + Environment.NewLine);
                    textBox_DadosProduto.AppendText("Disponível: " + i.Estoque + Environment.NewLine);


                    // Vou guardar todos os valores do Produto selecionado
                    // para não ter necessidade de percorrer toda a lista novamente.
                    id_ProdutoSelecionado = i.Id_Produto; // fazer pendencia fila
                    NomeProdutoSelecionado = i.Nome;
                    PrecoProdutoSelecionado = i.Preco;
                    EstoqueProdutoSelecionado = i.Estoque;

                    textBox_Quantidade.Text = "";
                    textBox_Quantidade.Text = "1";

                }
            }

        }

        private void limparTela()
        {
            //limpa dados cliente
            comboBox_Cliente.Items.Clear();
            textBox_DadosCliente.Text = "";
            foreach (Cliente i in listaClientes)
            {
                comboBox_Cliente.Items.Add(i.Nome);
            }

            //limpa dados produto
            comboBox_Produto.Items.Clear();
            textBox_DadosProduto.Text = "";
            foreach (Produto i in listaProdutos)
            {
                comboBox_Produto.Items.Add(i.Nome);
            }

            //itens de venda e quantidade
            listView_Produtos.Items.Clear();
            textBox_Quantidade.Text = "1";
            contaProdutos = 0;
            ValorVenda = 0;
            EstoqueProdutoSelecionado = 0;
        }


        /// <summary>
        /// adiciona o produto selecionado na tela - componente ListView
        /// </summary>
        private void adicionarProduto()
        {

            int Quantidade = int.Parse(textBox_Quantidade.Text);
            float ValorTotalItem = Quantidade * PrecoProdutoSelecionado;
            ValorVenda = ValorVenda + ValorTotalItem;

            //adiciona os itens do carrinho na lista para posterior gravação da Venda.
            listaItensVenda.Add(new Vender(id_ClienteSelecionado, ValorVenda, id_ProdutoSelecionado, PrecoProdutoSelecionado, Quantidade, ValorTotalItem));
            

            listView_Produtos.Items.Add(id_ProdutoSelecionado.ToString());
            listView_Produtos.Items[contaProdutos].SubItems.Add(NomeProdutoSelecionado.ToString());
            listView_Produtos.Items[contaProdutos].SubItems.Add(Quantidade.ToString());
            listView_Produtos.Items[contaProdutos].SubItems.Add(PrecoProdutoSelecionado.ToString());
            listView_Produtos.Items[contaProdutos].SubItems.Add(ValorTotalItem.ToString());

            textBox_ValorTotal.Text = ValorVenda.ToString();

            // conta os produtos adicionados
            contaProdutos++;

        }

        private void comboBox_Cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            //pega apenas o indice do combo: comboBox_Cliente.SelectedIndex
            //pega apenas o nome do cliente selecionado:
            //comboBox_Cliente.Items[comboBox_Cliente.SelectedIndex].ToString()

            exibirDadosCliente(comboBox_Cliente.Items[comboBox_Cliente.SelectedIndex].ToString());

        }

        private void comboBox_Produto_SelectedIndexChanged(object sender, EventArgs e)
        {
            exibirDadosProduto(comboBox_Produto.Items[comboBox_Produto.SelectedIndex].ToString());
            
        }

        private void textBox_Quantidade_TextChanged(object sender, EventArgs e)
        {
            //if (textBox_Quantidade.Text != "")
            //{
            //    if (int.Parse(textBox_Quantidade.Text) > Estoque)
            //    {
            //        MessageBox.Show("Só temos " + Estoque + " unidades disponíveis no estoque. \nFavor rever a quantidade solicitada.", "Quantidade Excedida");
            //    }
            //}

        }

        private void button_AdicionarProduto_Click(object sender, EventArgs e)
        {

            //validações iniciais
            if ((textBox_Quantidade.Text == "") || (textBox_Quantidade.Text == null))
            {
                MessageBox.Show("Quantidade não informada - Escolha de 1 a " + EstoqueProdutoSelecionado, "Alerta de Estoque");
                return;
            }
            if (int.Parse(textBox_Quantidade.Text) == 0)
            {
                MessageBox.Show("Quantidade inválida - Escolha de 1 a " + EstoqueProdutoSelecionado, "Alerta de Estoque");
                return;
            }
            if (int.Parse(textBox_Quantidade.Text) > EstoqueProdutoSelecionado)
            {
                MessageBox.Show("Só temos " + EstoqueProdutoSelecionado + " unidades disponíveis no estoque. \nFavor rever a quantidade solicitada.", "Quantidade Excedida");
                return;
            }

            if ((textBox_Quantidade.Text == "") || (textBox_Quantidade.Text == null))
            {
                MessageBox.Show("Favor informar quantidade que deseja comprar.", "Quantidade de produto");
                return;            
            }
            if (int.Parse(textBox_Quantidade.Text) > EstoqueProdutoSelecionado)
            {
                MessageBox.Show("Só temos " + EstoqueProdutoSelecionado + " unidades disponíveis no estoque. \nFavor rever a quantidade solicitada.", "Quantidade Excedida");
                return;
            }

            //entrar somente produto novo - não permitir a repetição
            //if (id_ProdutoSelecionado já existe?)
            //{
            // melhoria
            //}

            adicionarProduto();
        }

        private void textBox_Quantidade_MouseEnter(object sender, EventArgs e)
        {

        }

        private void textBox_Quantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                //&& (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Baixar estoque pendencia urgente
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_ConfirmarVenda_Click(object sender, EventArgs e)
        {

            Vender vender = new Vender();

            if (vender.gravarVenda(id_ClienteSelecionado, ValorVenda))
            {
                vender.buscarIdVenda();

                if(vender.gravarItensVenda(listaItensVenda))
                {
                    limparTela();
                    exibirProdutos(); //recarrega produtos após atualização do estoque
                    MessageBox.Show("Venda cadastrada com sucesso.");
                }
            }

        }

        private void button_LimparTela_Click(object sender, EventArgs e)
        {

            limparTela();

        }
    }
}
