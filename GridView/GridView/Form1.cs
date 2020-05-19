using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridView
{
    public partial class Form1 : Form
    {

        class ClsCadastro
        {
            public string Codigo { get; set; }
            public string Nome { get; set; }

            public ClsCadastro()
            { }

        }

        List<ClsCadastro> Cadastro = new List<ClsCadastro>();


        public Form1()
        {
            InitializeComponent();
        }

        private void botao_Incluir_Click(object sender, EventArgs e)
        {
            Cadastro.Add(new ClsCadastro()
            {
                Codigo = text_Codigo.Text.Trim(),
                Nome = text_Nome.Text.Trim()

            });

            dataGridView_Dados.DataSource = null;
            dataGridView_Dados.DataSource = Cadastro;

            comboBox_Dados.DataSource = null;
            comboBox_Dados.ValueMember = "Codigo";
            comboBox_Dados.DisplayMember = "Nome";
            comboBox_Dados.DataSource = Cadastro;
            comboBox_Dados.Refresh();

            text_Codigo.Text = "";
            text_Nome.Text = "";

            text_Codigo.Focus();


        }

        private void botao_Excluir_Click(object sender, EventArgs e)
        {

            var itemtoRemove = Cadastro.SingleOrDefault(LST_Cadastro => LST_Cadastro.Codigo == text_Codigo.Text.ToString());
            if (itemtoRemove != null)
            { Cadastro.Remove(itemtoRemove); }

            dataGridView_Dados.DataSource = null;
            dataGridView_Dados.DataSource = Cadastro;

            comboBox_Dados.DataSource = null;
            comboBox_Dados.ValueMember = "Codigo";
            comboBox_Dados.DisplayMember = "Nome";
            comboBox_Dados.DataSource = Cadastro;
            comboBox_Dados.Refresh();

            text_Codigo.Text = "";
            text_Nome.Text = "";

            text_Codigo.Focus();

        }

        private void botao_Limpar_Click(object sender, EventArgs e)
        {

            dataGridView_Dados.DataSource = null;
            comboBox_Dados.DataSource = null;
            Cadastro = new List<ClsCadastro>();
            text_Codigo.Text = "";
            text_Codigo.Focus();

        }
    }
}
