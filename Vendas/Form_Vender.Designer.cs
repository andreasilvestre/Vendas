namespace Vendas
{
    partial class Form_Vender
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox_Cliente = new System.Windows.Forms.ComboBox();
            this.label_Cliente = new System.Windows.Forms.Label();
            this.label_Produto = new System.Windows.Forms.Label();
            this.comboBox_Produto = new System.Windows.Forms.ComboBox();
            this.listView_Produtos = new System.Windows.Forms.ListView();
            this.id_Produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValorUnitario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValorTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ValorTotal = new System.Windows.Forms.TextBox();
            this.textBox_DadosCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_DadosProduto = new System.Windows.Forms.TextBox();
            this.label_Quantidade = new System.Windows.Forms.Label();
            this.textBox_Quantidade = new System.Windows.Forms.TextBox();
            this.button_AdicionarProduto = new System.Windows.Forms.Button();
            this.button_ConfirmarVenda = new System.Windows.Forms.Button();
            this.button_LimparTela = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_Cliente
            // 
            this.comboBox_Cliente.FormattingEnabled = true;
            this.comboBox_Cliente.Location = new System.Drawing.Point(89, 37);
            this.comboBox_Cliente.Name = "comboBox_Cliente";
            this.comboBox_Cliente.Size = new System.Drawing.Size(249, 21);
            this.comboBox_Cliente.TabIndex = 0;
            this.comboBox_Cliente.SelectedIndexChanged += new System.EventHandler(this.comboBox_Cliente_SelectedIndexChanged);
            // 
            // label_Cliente
            // 
            this.label_Cliente.AutoSize = true;
            this.label_Cliente.Location = new System.Drawing.Point(28, 37);
            this.label_Cliente.Name = "label_Cliente";
            this.label_Cliente.Size = new System.Drawing.Size(42, 13);
            this.label_Cliente.TabIndex = 1;
            this.label_Cliente.Text = "Cliente:";
            // 
            // label_Produto
            // 
            this.label_Produto.AutoSize = true;
            this.label_Produto.Location = new System.Drawing.Point(115, 102);
            this.label_Produto.Name = "label_Produto";
            this.label_Produto.Size = new System.Drawing.Size(47, 13);
            this.label_Produto.TabIndex = 2;
            this.label_Produto.Text = "Produto:";
            // 
            // comboBox_Produto
            // 
            this.comboBox_Produto.FormattingEnabled = true;
            this.comboBox_Produto.Location = new System.Drawing.Point(176, 102);
            this.comboBox_Produto.Name = "comboBox_Produto";
            this.comboBox_Produto.Size = new System.Drawing.Size(145, 21);
            this.comboBox_Produto.TabIndex = 1;
            this.comboBox_Produto.SelectedIndexChanged += new System.EventHandler(this.comboBox_Produto_SelectedIndexChanged);
            // 
            // listView_Produtos
            // 
            this.listView_Produtos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id_Produto,
            this.Nome,
            this.Quantidade,
            this.ValorUnitario,
            this.ValorTotal});
            this.listView_Produtos.Enabled = false;
            this.listView_Produtos.HideSelection = false;
            this.listView_Produtos.Location = new System.Drawing.Point(31, 224);
            this.listView_Produtos.Name = "listView_Produtos";
            this.listView_Produtos.Size = new System.Drawing.Size(504, 185);
            this.listView_Produtos.TabIndex = 2;
            this.listView_Produtos.UseCompatibleStateImageBehavior = false;
            this.listView_Produtos.View = System.Windows.Forms.View.Details;
            // 
            // id_Produto
            // 
            this.id_Produto.Text = "Código";
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 100;
            // 
            // ValorUnitario
            // 
            this.ValorUnitario.Text = "Vlr. Unitário";
            this.ValorUnitario.Width = 70;
            // 
            // Quantidade
            // 
            this.Quantidade.Text = "Qtde";
            // 
            // ValorTotal
            // 
            this.ValorTotal.Text = "Vlr. Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valor Total:";
            // 
            // textBox_ValorTotal
            // 
            this.textBox_ValorTotal.Enabled = false;
            this.textBox_ValorTotal.Location = new System.Drawing.Point(439, 426);
            this.textBox_ValorTotal.Name = "textBox_ValorTotal";
            this.textBox_ValorTotal.Size = new System.Drawing.Size(100, 20);
            this.textBox_ValorTotal.TabIndex = 3;
            // 
            // textBox_DadosCliente
            // 
            this.textBox_DadosCliente.Enabled = false;
            this.textBox_DadosCliente.Location = new System.Drawing.Point(344, 22);
            this.textBox_DadosCliente.Multiline = true;
            this.textBox_DadosCliente.Name = "textBox_DadosCliente";
            this.textBox_DadosCliente.Size = new System.Drawing.Size(349, 71);
            this.textBox_DadosCliente.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 7;
            // 
            // textBox_DadosProduto
            // 
            this.textBox_DadosProduto.Enabled = false;
            this.textBox_DadosProduto.Location = new System.Drawing.Point(344, 99);
            this.textBox_DadosProduto.Multiline = true;
            this.textBox_DadosProduto.Name = "textBox_DadosProduto";
            this.textBox_DadosProduto.Size = new System.Drawing.Size(247, 94);
            this.textBox_DadosProduto.TabIndex = 8;
            // 
            // label_Quantidade
            // 
            this.label_Quantidade.AutoSize = true;
            this.label_Quantidade.Location = new System.Drawing.Point(97, 142);
            this.label_Quantidade.Name = "label_Quantidade";
            this.label_Quantidade.Size = new System.Drawing.Size(65, 13);
            this.label_Quantidade.TabIndex = 9;
            this.label_Quantidade.Text = "Quantidade:";
            // 
            // textBox_Quantidade
            // 
            this.textBox_Quantidade.Location = new System.Drawing.Point(176, 135);
            this.textBox_Quantidade.Name = "textBox_Quantidade";
            this.textBox_Quantidade.Size = new System.Drawing.Size(100, 20);
            this.textBox_Quantidade.TabIndex = 10;
            this.textBox_Quantidade.Text = "1";
            this.textBox_Quantidade.TextChanged += new System.EventHandler(this.textBox_Quantidade_TextChanged);
            this.textBox_Quantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Quantidade_KeyPress);
            this.textBox_Quantidade.MouseEnter += new System.EventHandler(this.textBox_Quantidade_MouseEnter);
            // 
            // button_AdicionarProduto
            // 
            this.button_AdicionarProduto.Location = new System.Drawing.Point(176, 185);
            this.button_AdicionarProduto.Name = "button_AdicionarProduto";
            this.button_AdicionarProduto.Size = new System.Drawing.Size(145, 33);
            this.button_AdicionarProduto.TabIndex = 11;
            this.button_AdicionarProduto.Text = "&Adicionar Produto";
            this.button_AdicionarProduto.UseVisualStyleBackColor = true;
            this.button_AdicionarProduto.Click += new System.EventHandler(this.button_AdicionarProduto_Click);
            // 
            // button_ConfirmarVenda
            // 
            this.button_ConfirmarVenda.Location = new System.Drawing.Point(565, 360);
            this.button_ConfirmarVenda.Name = "button_ConfirmarVenda";
            this.button_ConfirmarVenda.Size = new System.Drawing.Size(128, 49);
            this.button_ConfirmarVenda.TabIndex = 12;
            this.button_ConfirmarVenda.Text = "&Confirmar\r\nVenda";
            this.button_ConfirmarVenda.UseVisualStyleBackColor = true;
            this.button_ConfirmarVenda.Click += new System.EventHandler(this.button_ConfirmarVenda_Click);
            // 
            // button_LimparTela
            // 
            this.button_LimparTela.Location = new System.Drawing.Point(565, 305);
            this.button_LimparTela.Name = "button_LimparTela";
            this.button_LimparTela.Size = new System.Drawing.Size(128, 49);
            this.button_LimparTela.TabIndex = 14;
            this.button_LimparTela.Text = "&Limpar\r\nTela";
            this.button_LimparTela.UseVisualStyleBackColor = true;
            this.button_LimparTela.Click += new System.EventHandler(this.button_LimparTela_Click);
            // 
            // Form_Vender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 471);
            this.Controls.Add(this.button_LimparTela);
            this.Controls.Add(this.button_ConfirmarVenda);
            this.Controls.Add(this.button_AdicionarProduto);
            this.Controls.Add(this.textBox_Quantidade);
            this.Controls.Add(this.label_Quantidade);
            this.Controls.Add(this.textBox_DadosProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_DadosCliente);
            this.Controls.Add(this.textBox_ValorTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView_Produtos);
            this.Controls.Add(this.comboBox_Produto);
            this.Controls.Add(this.label_Produto);
            this.Controls.Add(this.label_Cliente);
            this.Controls.Add(this.comboBox_Cliente);
            this.Name = "Form_Vender";
            this.Text = "Realizar Vendas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Cliente;
        private System.Windows.Forms.Label label_Cliente;
        private System.Windows.Forms.Label label_Produto;
        private System.Windows.Forms.ComboBox comboBox_Produto;
        private System.Windows.Forms.ListView listView_Produtos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ValorTotal;
        private System.Windows.Forms.TextBox textBox_DadosCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_DadosProduto;
        private System.Windows.Forms.Label label_Quantidade;
        private System.Windows.Forms.TextBox textBox_Quantidade;
        private System.Windows.Forms.Button button_AdicionarProduto;
        private System.Windows.Forms.ColumnHeader id_Produto;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader ValorUnitario;
        private System.Windows.Forms.ColumnHeader Quantidade;
        private System.Windows.Forms.ColumnHeader ValorTotal;
        private System.Windows.Forms.Button button_ConfirmarVenda;
        private System.Windows.Forms.Button button_LimparTela;
    }
}