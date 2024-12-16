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
    public partial class Vendas_Registar : Form
    {
        public Vendas_Registar()
        {
            InitializeComponent();
        }
        int teste ;
        private void Vendas_Registar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Vender.Load();
             teste = 0;
        }
      
        private void Instrutor_Nome_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Clientes.Load();
            teste = 1;
        }

        private void bunifuCustomTextbox1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Funcionarios.Load();
            teste = 2;
        }

        private void bunifuCustomTextbox2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Vender.Loadvendas();
            teste = 3;
        }   

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Vender.Load();
            teste = 0;
        }
        DateTime data;
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            int j = 0;
    
            data = DateTime.Now.Date;
            
            //Error Provider Clientes
            if (Instrutor_Nome.Text.Trim().Length == 0)
            {

                errorProvider1.SetError(Instrutor_Nome, "Escolha o cliente");
            }
            else
            {
                j += 1;
                errorProvider1.SetError(Instrutor_Nome, null);
            }
            //Error Provider Funcionario
            if (Instrutor_Nome.Text.Trim().Length == 0)
            {

                errorProvider2.SetError(bunifuCustomTextbox1, "Escolha o funcionario");
            }
            else
            {
                j += 1;
                errorProvider2.SetError(bunifuCustomTextbox1, null);
            }
            //Error Provider Veiculo
            if (Instrutor_Nome.Text.Trim().Length == 0)
            {

                errorProvider3.SetError(bunifuCustomTextbox2, "Escolha o veiculo");
            }
            else
            {
                j += 1;
                errorProvider3.SetError(bunifuCustomTextbox2, null);
            }
            //Error Provider Preço
            if (Instrutor_Nome.Text.Trim().Length == 0)
            {

                errorProvider4.SetError(bunifuCustomTextbox3, "Escolha o preço");
            }
            else
            {
                j += 1;
                errorProvider4.SetError(bunifuCustomTextbox3, null);
            }
            if (j == 4)
            {

                

                    try
                    {
                        int x = BLL.Vender.insertVendas(Convert.ToInt32(Instrutor_Nome.Text), Convert.ToInt32(bunifuCustomTextbox1.Text), Convert.ToInt32(bunifuCustomTextbox2.Text), data , Convert.ToInt32(bunifuCustomTextbox3.Text));

                    try
                    {
                        int w = BLL.Vender.updateVeiculos(Convert.ToInt32(label6.Text), label7.Text);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao inserir na Base de dados: " + ex);
                    }
                }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao inserir na Base de dados: " + ex);
                    }

                Instrutor_Nome.Clear();
                    bunifuCustomTextbox1.Clear();
                    bunifuCustomTextbox2.Clear();
                    bunifuCustomTextbox3.Clear();
                    teste = 0;
                    dataGridView1.DataSource = BLL.Vender.Load();

                

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(teste==1)
            {
                Instrutor_Nome.Text = dataGridView1.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                label5.Text = dataGridView1.Rows[e.RowIndex].Cells["Id_Clientes"].Value.ToString();

            }
            if (teste == 2)
            {
                bunifuCustomTextbox1.Text = dataGridView1.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                label5.Text = dataGridView1.Rows[e.RowIndex].Cells["Id_Funcionario"].Value.ToString();
            }
            if (teste == 3)
            {
                bunifuCustomTextbox2.Text = dataGridView1.Rows[e.RowIndex].Cells["Matricula"].Value.ToString();
                label6.Text = dataGridView1.Rows[e.RowIndex].Cells["Id_Veiculo"].Value.ToString();
                label7.Text = dataGridView1.Rows[e.RowIndex].Cells["Ativo"].Value.ToString();
            }
           if(teste==0)
            {

            }
        }

        private void bunifuCustomTextbox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
