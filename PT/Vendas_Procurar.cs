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
    public partial class Vendas_Procurar : Form
    {
        public Vendas_Procurar()
        {
            InitializeComponent();
        }

        private void Instrutor_Procurar_TextChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Cliente")
            {
                dataGridView1.DataSource = BLL.Clientes.queryClientes_Like(Instrutor_Procurar.Text);
                dataGridView2.DataSource = BLL.ProcurarVender.vendasprocurarclientes_Like(Instrutor_Procurar.Text);
            }
            else if  (comboBox1.Text == "Funcionário")
            {
                dataGridView1.DataSource = BLL.ProcurarVender.queryFuncionario_Like(Instrutor_Procurar.Text);
                dataGridView2.DataSource = BLL.ProcurarVender.vendasprocurarfuncionario_Like(Instrutor_Procurar.Text);
            }
            else if(comboBox1.Text == "Veículo")
            {
                dataGridView1.DataSource = BLL.ProcurarVender.vendasprocurarveiculo_Like(Instrutor_Procurar.Text);
                dataGridView1.DataSource = BLL.Veiculos.queryVeiculo_Like(Instrutor_Procurar.Text);
            }



            
        }

        private void Vendas_Procurar_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Cliente";
            dataGridView1.DataSource = BLL.Clientes.queryClientes_Like(Instrutor_Procurar.Text);
            dataGridView2.DataSource = BLL.ProcurarVender.vendasprocurarclientes_Like(Instrutor_Procurar.Text);
            this.SendToBack();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Cliente")
            {
                dataGridView1.DataSource = BLL.Clientes.queryClientes_Like(Instrutor_Procurar.Text);
                dataGridView2.DataSource = BLL.ProcurarVender.vendasprocurarclientes_Like(Instrutor_Procurar.Text);
            }
            else if (comboBox1.Text == "Funcionário")
            {
                dataGridView1.DataSource = BLL.ProcurarVender.queryFuncionario_Like(Instrutor_Procurar.Text);
                dataGridView2.DataSource = BLL.ProcurarVender.vendasprocurarfuncionario_Like(Instrutor_Procurar.Text);
            }
            else if (comboBox1.Text == "Veículo")
            {
                dataGridView1.DataSource = BLL.ProcurarVender.vendasprocurarveiculo_Like(Instrutor_Procurar.Text);
                dataGridView1.DataSource = BLL.Veiculos.queryVeiculo_Like(Instrutor_Procurar.Text);
            }
        }
    }
}
