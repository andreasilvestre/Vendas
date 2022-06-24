namespace Vendas
{
    partial class Form_Cliente
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
            this.label_CPF = new System.Windows.Forms.Label();
            this.label_Telefone = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.maskedTextBox_CPF = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.button_Cadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Nome
            // 
            this.label_Nome.AutoSize = true;
            this.label_Nome.Location = new System.Drawing.Point(21, 19);
            this.label_Nome.Name = "label_Nome";
            this.label_Nome.Size = new System.Drawing.Size(38, 13);
            this.label_Nome.TabIndex = 0;
            this.label_Nome.Text = "Nome:";
            // 
            // label_CPF
            // 
            this.label_CPF.AutoSize = true;
            this.label_CPF.Location = new System.Drawing.Point(29, 61);
            this.label_CPF.Name = "label_CPF";
            this.label_CPF.Size = new System.Drawing.Size(30, 13);
            this.label_CPF.TabIndex = 1;
            this.label_CPF.Text = "CPF:";
            // 
            // label_Telefone
            // 
            this.label_Telefone.AutoSize = true;
            this.label_Telefone.Location = new System.Drawing.Point(12, 99);
            this.label_Telefone.Name = "label_Telefone";
            this.label_Telefone.Size = new System.Drawing.Size(52, 13);
            this.label_Telefone.TabIndex = 2;
            this.label_Telefone.Text = "Telefone:";
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(21, 138);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(38, 13);
            this.label_Email.TabIndex = 3;
            this.label_Email.Text = "E-mail:";
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_Nome.Location = new System.Drawing.Point(78, 19);
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(301, 20);
            this.textBox_Nome.TabIndex = 0;
            // 
            // textBox_Email
            // 
            this.textBox_Email.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBox_Email.Location = new System.Drawing.Point(78, 131);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(301, 20);
            this.textBox_Email.TabIndex = 3;
            // 
            // maskedTextBox_CPF
            // 
            this.maskedTextBox_CPF.Location = new System.Drawing.Point(78, 54);
            this.maskedTextBox_CPF.Mask = "000,000,000/00";
            this.maskedTextBox_CPF.Name = "maskedTextBox_CPF";
            this.maskedTextBox_CPF.Size = new System.Drawing.Size(139, 20);
            this.maskedTextBox_CPF.TabIndex = 1;
            // 
            // maskedTextBox_Telefone
            // 
            this.maskedTextBox_Telefone.Location = new System.Drawing.Point(78, 92);
            this.maskedTextBox_Telefone.Mask = "(00) 00000-0000";
            this.maskedTextBox_Telefone.Name = "maskedTextBox_Telefone";
            this.maskedTextBox_Telefone.Size = new System.Drawing.Size(192, 20);
            this.maskedTextBox_Telefone.TabIndex = 2;
            // 
            // button_Cadastrar
            // 
            this.button_Cadastrar.Location = new System.Drawing.Point(265, 185);
            this.button_Cadastrar.Name = "button_Cadastrar";
            this.button_Cadastrar.Size = new System.Drawing.Size(114, 34);
            this.button_Cadastrar.TabIndex = 11;
            this.button_Cadastrar.Text = "&Cadastrar";
            this.button_Cadastrar.UseVisualStyleBackColor = true;
            this.button_Cadastrar.Click += new System.EventHandler(this.button_Cadastrar_Click);
            // 
            // Form_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 282);
            this.Controls.Add(this.button_Cadastrar);
            this.Controls.Add(this.maskedTextBox_Telefone);
            this.Controls.Add(this.maskedTextBox_CPF);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textBox_Nome);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.label_Telefone);
            this.Controls.Add(this.label_CPF);
            this.Controls.Add(this.label_Nome);
            this.Name = "Form_Cliente";
            this.Text = "Cadastrar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Nome;
        private System.Windows.Forms.Label label_CPF;
        private System.Windows.Forms.Label label_Telefone;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.TextBox textBox_Nome;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_CPF;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Telefone;
        private System.Windows.Forms.Button button_Cadastrar;
    }
}