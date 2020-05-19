namespace Banco
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
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textValor = new System.Windows.Forms.TextBox();
            this.Valor = new System.Windows.Forms.Label();
            this.botaoDeposito = new System.Windows.Forms.Button();
            this.botaoSaque = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(142, 199);
            this.textoSaldo.Multiline = true;
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.Size = new System.Drawing.Size(211, 39);
            this.textoSaldo.TabIndex = 2;
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(142, 48);
            this.textoTitular.Multiline = true;
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(211, 39);
            this.textoTitular.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Titular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Saldo";
            // 
            // textValor
            // 
            this.textValor.Location = new System.Drawing.Point(142, 271);
            this.textValor.Multiline = true;
            this.textValor.Name = "textValor";
            this.textValor.Size = new System.Drawing.Size(211, 39);
            this.textValor.TabIndex = 8;
            // 
            // Valor
            // 
            this.Valor.AutoSize = true;
            this.Valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valor.Location = new System.Drawing.Point(51, 293);
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(41, 17);
            this.Valor.TabIndex = 9;
            this.Valor.Text = "Valor";
            // 
            // botaoDeposito
            // 
            this.botaoDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoDeposito.Location = new System.Drawing.Point(86, 346);
            this.botaoDeposito.Name = "botaoDeposito";
            this.botaoDeposito.Size = new System.Drawing.Size(113, 48);
            this.botaoDeposito.TabIndex = 10;
            this.botaoDeposito.Text = "Depósito";
            this.botaoDeposito.UseVisualStyleBackColor = true;
            this.botaoDeposito.Click += new System.EventHandler(this.button1_Click);
            // 
            // botaoSaque
            // 
            this.botaoSaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoSaque.Location = new System.Drawing.Point(240, 346);
            this.botaoSaque.Name = "botaoSaque";
            this.botaoSaque.Size = new System.Drawing.Size(113, 48);
            this.botaoSaque.TabIndex = 11;
            this.botaoSaque.Text = "Saque";
            this.botaoSaque.UseVisualStyleBackColor = true;
            this.botaoSaque.Click += new System.EventHandler(this.botaoSaque_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.botaoDeposito);
            this.groupBox1.Controls.Add(this.botaoSaque);
            this.groupBox1.Controls.Add(this.textoSaldo);
            this.groupBox1.Controls.Add(this.textoTitular);
            this.groupBox1.Controls.Add(this.Valor);
            this.groupBox1.Controls.Add(this.textoNumero);
            this.groupBox1.Controls.Add(this.textValor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 440);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conta";
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(142, 124);
            this.textoNumero.Multiline = true;
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(211, 39);
            this.textoNumero.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 465);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textValor;
        private System.Windows.Forms.Label Valor;
        private System.Windows.Forms.Button botaoDeposito;
        private System.Windows.Forms.Button botaoSaque;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textoNumero;
    }
}

