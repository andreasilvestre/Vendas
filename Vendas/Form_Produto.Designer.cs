namespace Vendas
{
    partial class Form_Produto
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
            this.label_Nome = new System.Windows.Forms.Label();
            this.label_CodEAN = new System.Windows.Forms.Label();
            this.label_Preco = new System.Windows.Forms.Label();
            this.label_Estoque = new System.Windows.Forms.Label();
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.textBox_CodEAN = new System.Windows.Forms.TextBox();
            this.textBox_Preco = new System.Windows.Forms.TextBox();
            this.textBox_Estoque = new System.Windows.Forms.TextBox();
            this.button_Cadastrar = new System.Windows.Forms.Button();
            this.button_Limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Nome
            // 
            this.label_Nome.AutoSize = true;
            this.label_Nome.Location = new System.Drawing.Point(37, 43);
            this.label_Nome.Name = "label_Nome";
            this.label_Nome.Size = new System.Drawing.Size(38, 13);
            this.label_Nome.TabIndex = 0;
            this.label_Nome.Text = "Nome:";
            // 
            // label_CodEAN
            // 
            this.label_CodEAN.AutoSize = true;
            this.label_CodEAN.Location = new System.Drawing.Point(24, 83);
            this.label_CodEAN.Name = "label_CodEAN";
            this.label_CodEAN.Size = new System.Drawing.Size(51, 13);
            this.label_CodEAN.TabIndex = 1;
            this.label_CodEAN.Text = "CodEAN:";
            // 
            // label_Preco
            // 
            this.label_Preco.AutoSize = true;
            this.label_Preco.Location = new System.Drawing.Point(37, 121);
            this.label_Preco.Name = "label_Preco";
            this.label_Preco.Size = new System.Drawing.Size(38, 13);
            this.label_Preco.TabIndex = 2;
            this.label_Preco.Text = "Preço:";
            // 
            // label_Estoque
            // 
            this.label_Estoque.AutoSize = true;
            this.label_Estoque.Location = new System.Drawing.Point(26, 161);
            this.label_Estoque.Name = "label_Estoque";
            this.label_Estoque.Size = new System.Drawing.Size(49, 13);
            this.label_Estoque.TabIndex = 3;
            this.label_Estoque.Text = "Estoque:";
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_Nome.Location = new System.Drawing.Point(81, 43);
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(187, 20);
            this.textBox_Nome.TabIndex = 4;
            // 
            // textBox_CodEAN
            // 
            this.textBox_CodEAN.Location = new System.Drawing.Point(81, 80);
            this.textBox_CodEAN.Name = "textBox_CodEAN";
            this.textBox_CodEAN.Size = new System.Drawing.Size(119, 20);
            this.textBox_CodEAN.TabIndex = 5;
            // 
            // textBox_Preco
            // 
            this.textBox_Preco.Location = new System.Drawing.Point(81, 121);
            this.textBox_Preco.Name = "textBox_Preco";
            this.textBox_Preco.Size = new System.Drawing.Size(100, 20);
            this.textBox_Preco.TabIndex = 6;
            // 
            // textBox_Estoque
            // 
            this.textBox_Estoque.Location = new System.Drawing.Point(81, 161);
            this.textBox_Estoque.Name = "textBox_Estoque";
            this.textBox_Estoque.Size = new System.Drawing.Size(100, 20);
            this.textBox_Estoque.TabIndex = 7;
            // 
            // button_Cadastrar
            // 
            this.button_Cadastrar.Location = new System.Drawing.Point(147, 214);
            this.button_Cadastrar.Name = "button_Cadastrar";
            this.button_Cadastrar.Size = new System.Drawing.Size(85, 35);
            this.button_Cadastrar.TabIndex = 8;
            this.button_Cadastrar.Text = "&Cadastrar";
            this.button_Cadastrar.UseVisualStyleBackColor = true;
            this.button_Cadastrar.Click += new System.EventHandler(this.button_Cadastrar_Click);
            // 
            // button_Limpar
            // 
            this.button_Limpar.Location = new System.Drawing.Point(238, 214);
            this.button_Limpar.Name = "button_Limpar";
            this.button_Limpar.Size = new System.Drawing.Size(85, 35);
            this.button_Limpar.TabIndex = 9;
            this.button_Limpar.Text = "&Limpar";
            this.button_Limpar.UseVisualStyleBackColor = true;
            this.button_Limpar.Click += new System.EventHandler(this.button_Limpar_Click);
            // 
            // Form_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 277);
            this.Controls.Add(this.button_Limpar);
            this.Controls.Add(this.button_Cadastrar);
            this.Controls.Add(this.textBox_Estoque);
            this.Controls.Add(this.textBox_Preco);
            this.Controls.Add(this.textBox_CodEAN);
            this.Controls.Add(this.textBox_Nome);
            this.Controls.Add(this.label_Estoque);
            this.Controls.Add(this.label_Preco);
            this.Controls.Add(this.label_CodEAN);
            this.Controls.Add(this.label_Nome);
            this.Name = "Form_Produto";
            this.Text = "Cadastrar Produto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Nome;
        private System.Windows.Forms.Label label_CodEAN;
        private System.Windows.Forms.Label label_Preco;
        private System.Windows.Forms.Label label_Estoque;
        private System.Windows.Forms.TextBox textBox_Nome;
        private System.Windows.Forms.TextBox textBox_CodEAN;
        private System.Windows.Forms.TextBox textBox_Preco;
        private System.Windows.Forms.TextBox textBox_Estoque;
        private System.Windows.Forms.Button button_Cadastrar;
        private System.Windows.Forms.Button button_Limpar;
    }
}