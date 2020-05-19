namespace GridView
{
    partial class Form1
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
            this.text_Codigo = new System.Windows.Forms.TextBox();
            this.text_Nome = new System.Windows.Forms.TextBox();
            this.botao_Incluir = new System.Windows.Forms.Button();
            this.botao_Excluir = new System.Windows.Forms.Button();
            this.botao_Limpar = new System.Windows.Forms.Button();
            this.dataGridView_Dados = new System.Windows.Forms.DataGridView();
            this.comboBox_Dados = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Dados)).BeginInit();
            this.SuspendLayout();
            // 
            // text_Codigo
            // 
            this.text_Codigo.Location = new System.Drawing.Point(73, 34);
            this.text_Codigo.Name = "text_Codigo";
            this.text_Codigo.Size = new System.Drawing.Size(208, 20);
            this.text_Codigo.TabIndex = 0;
            // 
            // text_Nome
            // 
            this.text_Nome.Location = new System.Drawing.Point(363, 34);
            this.text_Nome.Name = "text_Nome";
            this.text_Nome.Size = new System.Drawing.Size(208, 20);
            this.text_Nome.TabIndex = 1;
            // 
            // botao_Incluir
            // 
            this.botao_Incluir.Location = new System.Drawing.Point(30, 88);
            this.botao_Incluir.Name = "botao_Incluir";
            this.botao_Incluir.Size = new System.Drawing.Size(94, 32);
            this.botao_Incluir.TabIndex = 2;
            this.botao_Incluir.Text = "Incluir";
            this.botao_Incluir.UseVisualStyleBackColor = true;
            this.botao_Incluir.Click += new System.EventHandler(this.botao_Incluir_Click);
            // 
            // botao_Excluir
            // 
            this.botao_Excluir.Location = new System.Drawing.Point(218, 88);
            this.botao_Excluir.Name = "botao_Excluir";
            this.botao_Excluir.Size = new System.Drawing.Size(94, 32);
            this.botao_Excluir.TabIndex = 3;
            this.botao_Excluir.Text = "Excluir";
            this.botao_Excluir.UseVisualStyleBackColor = true;
            this.botao_Excluir.Click += new System.EventHandler(this.botao_Excluir_Click);
            // 
            // botao_Limpar
            // 
            this.botao_Limpar.Location = new System.Drawing.Point(408, 88);
            this.botao_Limpar.Name = "botao_Limpar";
            this.botao_Limpar.Size = new System.Drawing.Size(94, 32);
            this.botao_Limpar.TabIndex = 4;
            this.botao_Limpar.Text = "Limpar";
            this.botao_Limpar.UseVisualStyleBackColor = true;
            this.botao_Limpar.Click += new System.EventHandler(this.botao_Limpar_Click);
            // 
            // dataGridView_Dados
            // 
            this.dataGridView_Dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Dados.Location = new System.Drawing.Point(26, 165);
            this.dataGridView_Dados.Name = "dataGridView_Dados";
            this.dataGridView_Dados.Size = new System.Drawing.Size(586, 209);
            this.dataGridView_Dados.TabIndex = 5;
            // 
            // comboBox_Dados
            // 
            this.comboBox_Dados.FormattingEnabled = true;
            this.comboBox_Dados.Location = new System.Drawing.Point(26, 390);
            this.comboBox_Dados.Name = "comboBox_Dados";
            this.comboBox_Dados.Size = new System.Drawing.Size(586, 21);
            this.comboBox_Dados.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Dados);
            this.Controls.Add(this.dataGridView_Dados);
            this.Controls.Add(this.botao_Limpar);
            this.Controls.Add(this.botao_Excluir);
            this.Controls.Add(this.botao_Incluir);
            this.Controls.Add(this.text_Nome);
            this.Controls.Add(this.text_Codigo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Dados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_Codigo;
        private System.Windows.Forms.TextBox text_Nome;
        private System.Windows.Forms.Button botao_Incluir;
        private System.Windows.Forms.Button botao_Excluir;
        private System.Windows.Forms.Button botao_Limpar;
        private System.Windows.Forms.DataGridView dataGridView_Dados;
        private System.Windows.Forms.ComboBox comboBox_Dados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

