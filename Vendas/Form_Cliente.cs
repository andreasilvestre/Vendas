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
    public partial class Form_Cliente : Form
    {
        public Form_Cliente()
        {
            InitializeComponent();
        }

        private void Limpar()
        {
            textBox_Nome.Text = "";
            maskedTextBox_CPF.Text = "";
            maskedTextBox_Telefone.Text = "";
            textBox_Email.Text = "";
        }

        private void button_Cadastrar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(textBox_Nome.Text,maskedTextBox_CPF.Text, maskedTextBox_Telefone.Text,textBox_Email.Text);
            //MessageBox.Show("Nome: " + cliente.Nome + "\nTelefone: " + cliente.Telefone);
            if (cliente.gravarCliente())
            {
                MessageBox.Show("Cliente cadastrado com sucesso.");
            }

        }

        private void button_Limpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
