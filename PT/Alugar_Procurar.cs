using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
namespace PT
{
    public partial class Alugar_Procurar : Form
    {
        public Alugar_Procurar()
        {
            InitializeComponent();
        }
      

        private void Alugar_Procurar_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Cliente";
            dataGridView1.DataSource = BLL.Clientes.queryClientes_Like(Instrutor_Procurar.Text);
            dataGridView2.DataSource = BLL.ProcurarAlugar.vendasprocurarclientes_Like(Instrutor_Procurar.Text);
            this.SendToBack();
        }

        private void Instrutor_Procurar_TextChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Cliente")
            {
                dataGridView1.DataSource = BLL.Clientes.queryClientes_Like(Instrutor_Procurar.Text);
                dataGridView2.DataSource = BLL.ProcurarAlugar.vendasprocurarclientes_Like(Instrutor_Procurar.Text);
            }
            else if (comboBox1.Text == "Funcionário")
            {
                dataGridView1.DataSource = BLL.ProcurarAlugar.queryFuncionario_Like(Instrutor_Procurar.Text);
                dataGridView2.DataSource = BLL.ProcurarAlugar.vendasprocurarfuncionario_Like(Instrutor_Procurar.Text);
            }
            else if (comboBox1.Text == "Veículo")
            {
                dataGridView1.DataSource = BLL.ProcurarAlugar.vendasprocurarveiculo_Like(Instrutor_Procurar.Text);
                dataGridView1.DataSource = BLL.Veiculos.queryVeiculo_Like(Instrutor_Procurar.Text);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Cliente")
            {
                dataGridView1.DataSource = BLL.Clientes.queryClientes_Like(Instrutor_Procurar.Text);
                dataGridView2.DataSource = BLL.ProcurarAlugar.vendasprocurarclientes_Like(Instrutor_Procurar.Text);
            }
            else if (comboBox1.Text == "Funcionário")
            {
                dataGridView1.DataSource = BLL.ProcurarAlugar.queryFuncionario_Like(Instrutor_Procurar.Text);
                dataGridView2.DataSource = BLL.ProcurarAlugar.vendasprocurarfuncionario_Like(Instrutor_Procurar.Text);
            }
            else if (comboBox1.Text == "Veículo")
            {
                dataGridView1.DataSource = BLL.ProcurarAlugar.vendasprocurarveiculo_Like(Instrutor_Procurar.Text);
                dataGridView1.DataSource = BLL.Veiculos.queryVeiculo_Like(Instrutor_Procurar.Text);
            }
        }
    }
}
