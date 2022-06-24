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
    public partial class Form_Principal : Form
    {
        public Form_Principal()
        {
            InitializeComponent();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Produto produto = new Form_Produto();  
            produto.ShowDialog();   
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Cliente cliente = new Form_Cliente();
            cliente.ShowDialog();
        }

        private void venderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Vender vender = new Form_Vender(); 
            vender.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
