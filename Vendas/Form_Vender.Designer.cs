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
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ValorTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox_Cliente
            // 
            this.comboBox_Cliente.FormattingEnabled = true;
            this.comboBox_Cliente.Location = new System.Drawing.Point(89, 37);
            this.comboBox_Cliente.Name = "comboBox_Cliente";
            this.comboBox_Cliente.Size = new System.Drawing.Size(212, 21);
            this.comboBox_Cliente.TabIndex = 0;
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
            this.label_Produto.Location = new System.Drawing.Point(28, 123);
            this.label_Produto.Name = "label_Produto";
            this.label_Produto.Size = new System.Drawing.Size(47, 13);
            this.label_Produto.TabIndex = 2;
            this.label_Produto.Text = "Produto:";
            // 
            // comboBox_Produto
            // 
            this.comboBox_Produto.FormattingEnabled = true;
            this.comboBox_Produto.Location = new System.Drawing.Point(89, 123);
            this.comboBox_Produto.Name = "comboBox_Produto";
            this.comboBox_Produto.Size = new System.Drawing.Size(145, 21);
            this.comboBox_Produto.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(68, 174);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(504, 163);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valor Total:";
            // 
            // textBox_ValorTotal
            // 
            this.textBox_ValorTotal.Location = new System.Drawing.Point(476, 351);
            this.textBox_ValorTotal.Name = "textBox_ValorTotal";
            this.textBox_ValorTotal.Size = new System.Drawing.Size(100, 20);
            this.textBox_ValorTotal.TabIndex = 3;
            // 
            // Form_Vender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 425);
            this.Controls.Add(this.textBox_ValorTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ValorTotal;
    }
}