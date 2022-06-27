namespace Vendas
{
    partial class Form_Comprar
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
            this.comboBox_Produto = new System.Windows.Forms.ComboBox();
            this.textBox_Quantidade = new System.Windows.Forms.TextBox();
            this.label_Produto = new System.Windows.Forms.Label();
            this.label_Quantidade = new System.Windows.Forms.Label();
            this.textBox_DadosProduto = new System.Windows.Forms.TextBox();
            this.button_ConfirmarCompra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_Produto
            // 
            this.comboBox_Produto.FormattingEnabled = true;
            this.comboBox_Produto.Location = new System.Drawing.Point(84, 21);
            this.comboBox_Produto.Name = "comboBox_Produto";
            this.comboBox_Produto.Size = new System.Drawing.Size(145, 21);
            this.comboBox_Produto.TabIndex = 2;
            this.comboBox_Produto.SelectedIndexChanged += new System.EventHandler(this.comboBox_Produto_SelectedIndexChanged);
            // 
            // textBox_Quantidade
            // 
            this.textBox_Quantidade.Location = new System.Drawing.Point(84, 59);
            this.textBox_Quantidade.Name = "textBox_Quantidade";
            this.textBox_Quantidade.Size = new System.Drawing.Size(100, 20);
            this.textBox_Quantidade.TabIndex = 11;
            // 
            // label_Produto
            // 
            this.label_Produto.AutoSize = true;
            this.label_Produto.Location = new System.Drawing.Point(31, 21);
            this.label_Produto.Name = "label_Produto";
            this.label_Produto.Size = new System.Drawing.Size(47, 13);
            this.label_Produto.TabIndex = 12;
            this.label_Produto.Text = "Produto:";
            // 
            // label_Quantidade
            // 
            this.label_Quantidade.AutoSize = true;
            this.label_Quantidade.Location = new System.Drawing.Point(12, 59);
            this.label_Quantidade.Name = "label_Quantidade";
            this.label_Quantidade.Size = new System.Drawing.Size(65, 13);
            this.label_Quantidade.TabIndex = 13;
            this.label_Quantidade.Text = "Quantidade:";
            // 
            // textBox_DadosProduto
            // 
            this.textBox_DadosProduto.Enabled = false;
            this.textBox_DadosProduto.Location = new System.Drawing.Point(235, 18);
            this.textBox_DadosProduto.Multiline = true;
            this.textBox_DadosProduto.Name = "textBox_DadosProduto";
            this.textBox_DadosProduto.Size = new System.Drawing.Size(247, 94);
            this.textBox_DadosProduto.TabIndex = 14;
            // 
            // button_ConfirmarCompra
            // 
            this.button_ConfirmarCompra.Location = new System.Drawing.Point(152, 146);
            this.button_ConfirmarCompra.Name = "button_ConfirmarCompra";
            this.button_ConfirmarCompra.Size = new System.Drawing.Size(128, 49);
            this.button_ConfirmarCompra.TabIndex = 15;
            this.button_ConfirmarCompra.Text = "&Confirmar\r\nCompra";
            this.button_ConfirmarCompra.UseVisualStyleBackColor = true;
            this.button_ConfirmarCompra.Click += new System.EventHandler(this.button_ConfirmarCompra_Click);
            // 
            // Form_Comprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 312);
            this.Controls.Add(this.button_ConfirmarCompra);
            this.Controls.Add(this.textBox_DadosProduto);
            this.Controls.Add(this.label_Quantidade);
            this.Controls.Add(this.label_Produto);
            this.Controls.Add(this.textBox_Quantidade);
            this.Controls.Add(this.comboBox_Produto);
            this.Name = "Form_Comprar";
            this.Text = "Realizar Compras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Produto;
        private System.Windows.Forms.TextBox textBox_Quantidade;
        private System.Windows.Forms.Label label_Produto;
        private System.Windows.Forms.Label label_Quantidade;
        private System.Windows.Forms.TextBox textBox_DadosProduto;
        private System.Windows.Forms.Button button_ConfirmarCompra;
    }
}