namespace CalculoDeSalario
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
            this.components = new System.ComponentModel.Container();
            this.textBox_SalarioMinimo = new System.Windows.Forms.TextBox();
            this.textBox_HorasTrabalhadas = new System.Windows.Forms.TextBox();
            this.txtSalarioMinimo = new System.Windows.Forms.Label();
            this.txtTrabalhadas = new System.Windows.Forms.Label();
            this.gbxCategoria = new System.Windows.Forms.GroupBox();
            this.radioCalouro = new System.Windows.Forms.RadioButton();
            this.radioVeterano = new System.Windows.Forms.RadioButton();
            this.gbxTurno = new System.Windows.Forms.GroupBox();
            this.radioMatutino = new System.Windows.Forms.RadioButton();
            this.radioVespertino = new System.Windows.Forms.RadioButton();
            this.radioNoturno = new System.Windows.Forms.RadioButton();
            this.textBoxAmarelo = new System.Windows.Forms.TextBox();
            this.botao_Calcular = new System.Windows.Forms.Button();
            this.IbxResumo = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbxCategoria.SuspendLayout();
            this.gbxTurno.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_SalarioMinimo
            // 
            this.textBox_SalarioMinimo.Location = new System.Drawing.Point(146, 14);
            this.textBox_SalarioMinimo.Multiline = true;
            this.textBox_SalarioMinimo.Name = "textBox_SalarioMinimo";
            this.textBox_SalarioMinimo.Size = new System.Drawing.Size(146, 31);
            this.textBox_SalarioMinimo.TabIndex = 0;
            this.toolTip1.SetToolTip(this.textBox_SalarioMinimo, "Informe o valor do salário mínimo");
            // 
            // textBox_HorasTrabalhadas
            // 
            this.textBox_HorasTrabalhadas.Location = new System.Drawing.Point(146, 51);
            this.textBox_HorasTrabalhadas.Multiline = true;
            this.textBox_HorasTrabalhadas.Name = "textBox_HorasTrabalhadas";
            this.textBox_HorasTrabalhadas.Size = new System.Drawing.Size(146, 31);
            this.textBox_HorasTrabalhadas.TabIndex = 1;
            // 
            // txtSalarioMinimo
            // 
            this.txtSalarioMinimo.AutoSize = true;
            this.txtSalarioMinimo.Font = new System.Drawing.Font("Miriam Mono CLM", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioMinimo.Location = new System.Drawing.Point(12, 29);
            this.txtSalarioMinimo.Name = "txtSalarioMinimo";
            this.txtSalarioMinimo.Size = new System.Drawing.Size(105, 16);
            this.txtSalarioMinimo.TabIndex = 2;
            this.txtSalarioMinimo.Text = "Salário Mínimo:";
            // 
            // txtTrabalhadas
            // 
            this.txtTrabalhadas.AutoSize = true;
            this.txtTrabalhadas.Font = new System.Drawing.Font("Miriam Mono CLM", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrabalhadas.Location = new System.Drawing.Point(12, 66);
            this.txtTrabalhadas.Name = "txtTrabalhadas";
            this.txtTrabalhadas.Size = new System.Drawing.Size(132, 16);
            this.txtTrabalhadas.TabIndex = 3;
            this.txtTrabalhadas.Text = "Horas Trabalhadas:";
            // 
            // gbxCategoria
            // 
            this.gbxCategoria.Controls.Add(this.radioVeterano);
            this.gbxCategoria.Controls.Add(this.radioCalouro);
            this.gbxCategoria.Font = new System.Drawing.Font("Miriam Mono CLM", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCategoria.Location = new System.Drawing.Point(16, 98);
            this.gbxCategoria.Name = "gbxCategoria";
            this.gbxCategoria.Size = new System.Drawing.Size(278, 52);
            this.gbxCategoria.TabIndex = 4;
            this.gbxCategoria.TabStop = false;
            this.gbxCategoria.Text = "Categoria";
            // 
            // radioCalouro
            // 
            this.radioCalouro.AutoSize = true;
            this.radioCalouro.Location = new System.Drawing.Point(25, 23);
            this.radioCalouro.Name = "radioCalouro";
            this.radioCalouro.Size = new System.Drawing.Size(76, 20);
            this.radioCalouro.TabIndex = 0;
            this.radioCalouro.TabStop = true;
            this.radioCalouro.Text = "Calouro";
            this.radioCalouro.UseVisualStyleBackColor = true;
            // 
            // radioVeterano
            // 
            this.radioVeterano.AutoSize = true;
            this.radioVeterano.Location = new System.Drawing.Point(159, 23);
            this.radioVeterano.Name = "radioVeterano";
            this.radioVeterano.Size = new System.Drawing.Size(83, 20);
            this.radioVeterano.TabIndex = 1;
            this.radioVeterano.TabStop = true;
            this.radioVeterano.Text = "Veterano";
            this.radioVeterano.UseVisualStyleBackColor = true;
            // 
            // gbxTurno
            // 
            this.gbxTurno.Controls.Add(this.radioNoturno);
            this.gbxTurno.Controls.Add(this.radioVespertino);
            this.gbxTurno.Controls.Add(this.radioMatutino);
            this.gbxTurno.Font = new System.Drawing.Font("Miriam Mono CLM", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTurno.Location = new System.Drawing.Point(314, 14);
            this.gbxTurno.Name = "gbxTurno";
            this.gbxTurno.Size = new System.Drawing.Size(151, 135);
            this.gbxTurno.TabIndex = 5;
            this.gbxTurno.TabStop = false;
            this.gbxTurno.Text = "Turno";
            // 
            // radioMatutino
            // 
            this.radioMatutino.AutoSize = true;
            this.radioMatutino.Location = new System.Drawing.Point(19, 23);
            this.radioMatutino.Name = "radioMatutino";
            this.radioMatutino.Size = new System.Drawing.Size(80, 20);
            this.radioMatutino.TabIndex = 2;
            this.radioMatutino.TabStop = true;
            this.radioMatutino.Text = "Matutino";
            this.radioMatutino.UseVisualStyleBackColor = true;
            // 
            // radioVespertino
            // 
            this.radioVespertino.AutoSize = true;
            this.radioVespertino.Location = new System.Drawing.Point(19, 63);
            this.radioVespertino.Name = "radioVespertino";
            this.radioVespertino.Size = new System.Drawing.Size(93, 20);
            this.radioVespertino.TabIndex = 3;
            this.radioVespertino.TabStop = true;
            this.radioVespertino.Text = "Vespertino";
            this.radioVespertino.UseVisualStyleBackColor = true;
            // 
            // radioNoturno
            // 
            this.radioNoturno.AutoSize = true;
            this.radioNoturno.Location = new System.Drawing.Point(19, 107);
            this.radioNoturno.Name = "radioNoturno";
            this.radioNoturno.Size = new System.Drawing.Size(76, 20);
            this.radioNoturno.TabIndex = 4;
            this.radioNoturno.TabStop = true;
            this.radioNoturno.Text = "Noturno";
            this.radioNoturno.UseVisualStyleBackColor = true;
            // 
            // textBoxAmarelo
            // 
            this.textBoxAmarelo.BackColor = System.Drawing.Color.Yellow;
            this.textBoxAmarelo.Location = new System.Drawing.Point(16, 309);
            this.textBoxAmarelo.Multiline = true;
            this.textBoxAmarelo.Name = "textBoxAmarelo";
            this.textBoxAmarelo.Size = new System.Drawing.Size(325, 31);
            this.textBoxAmarelo.TabIndex = 7;
            // 
            // botao_Calcular
            // 
            this.botao_Calcular.Font = new System.Drawing.Font("Miriam Mono CLM", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_Calcular.Location = new System.Drawing.Point(359, 309);
            this.botao_Calcular.Name = "botao_Calcular";
            this.botao_Calcular.Size = new System.Drawing.Size(104, 30);
            this.botao_Calcular.TabIndex = 8;
            this.botao_Calcular.Text = "Calcular";
            this.botao_Calcular.UseVisualStyleBackColor = true;
            this.botao_Calcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // IbxResumo
            // 
            this.IbxResumo.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IbxResumo.FormattingEnabled = true;
            this.IbxResumo.ItemHeight = 16;
            this.IbxResumo.Location = new System.Drawing.Point(16, 165);
            this.IbxResumo.Name = "IbxResumo";
            this.IbxResumo.Size = new System.Drawing.Size(446, 116);
            this.IbxResumo.TabIndex = 9;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipTitle = "Ajuda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 354);
            this.Controls.Add(this.IbxResumo);
            this.Controls.Add(this.botao_Calcular);
            this.Controls.Add(this.textBoxAmarelo);
            this.Controls.Add(this.gbxTurno);
            this.Controls.Add(this.gbxCategoria);
            this.Controls.Add(this.txtTrabalhadas);
            this.Controls.Add(this.txtSalarioMinimo);
            this.Controls.Add(this.textBox_HorasTrabalhadas);
            this.Controls.Add(this.textBox_SalarioMinimo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxCategoria.ResumeLayout(false);
            this.gbxCategoria.PerformLayout();
            this.gbxTurno.ResumeLayout(false);
            this.gbxTurno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_SalarioMinimo;
        private System.Windows.Forms.TextBox textBox_HorasTrabalhadas;
        private System.Windows.Forms.Label txtSalarioMinimo;
        private System.Windows.Forms.Label txtTrabalhadas;
        private System.Windows.Forms.GroupBox gbxCategoria;
        private System.Windows.Forms.RadioButton radioVeterano;
        private System.Windows.Forms.RadioButton radioCalouro;
        private System.Windows.Forms.GroupBox gbxTurno;
        private System.Windows.Forms.RadioButton radioNoturno;
        private System.Windows.Forms.RadioButton radioVespertino;
        private System.Windows.Forms.RadioButton radioMatutino;
        private System.Windows.Forms.TextBox textBoxAmarelo;
        private System.Windows.Forms.Button botao_Calcular;
        private System.Windows.Forms.ListBox IbxResumo;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

