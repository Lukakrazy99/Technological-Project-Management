using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
namespace PT
{
    public partial class Vendas_Anular : Form
    {
       
        private BindingSource bindingSource1 = new BindingSource();
        int Id_Veiculo;
        int N_Vender;

        int N_Funcionario;

        int nomeC;

        int id;

       

        int preço;

        public Vendas_Anular()
        {
            InitializeComponent();
        }
       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dateTimePicker1.Enabled = true;
            
            dateTimePicker1.Enabled = false;
        }
        DateTime data;
        bool dt = false;
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            int j = 0;

            //Error Provider Referência
            if (bunifuCustomTextbox5.Text.Trim().Length == 0)
            {

                errorProvider6.SetError(bunifuCustomTextbox5, "Escolha a venda que pretende editar");
            }
            else
            {
                j += 1;
                errorProvider6.SetError(Instrutor_Nome, null);
            }

          
            if (j == 1)
            {


               

                try
                {
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        if (dataGridView2.Rows[row.Index].Cells[0].Value == null)
                        {
                            break;
                        }
                        else
                        {
                            int w = BLL.Vender.updateVeiculos((int)dataGridView2.Rows[row.Index].Cells[1].Value, "Sim");

                        }

                    }
                    int x = BLL.Vender.removeVendas2(N_Vender);
                    int d = BLL.Vender.removeVendas(N_Vender);
                    MessageBox.Show("Venda anulada com sucesso", "Anular Venda", MessageBoxButtons.OK);
                    Globais.wtvr = 0;


                        Instrutor_Nome.Clear();
                    dataGridView2.DataSource = null;
                    dataGridView2.Refresh();
                        bunifuCustomTextbox3.Clear();
                       
                        dataGridView1.DataSource = BLL.Vender.Load();
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao inserir na Base de dados: " + ex);
                }
                
            }
        }

        private void Instrutor_Nome_Click(object sender, EventArgs e)
        {
        
        }

        private void bunifuCustomTextbox1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Funcionarios.Load();
           
        }

        private void bunifuCustomTextbox2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Vender.Loadvendased(Convert.ToInt32(label6.Text));
           
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Vender.Load();
           
        }

        private void Vendas_Editar_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = BLL.Vender.Load();
            bunifuCustomTextbox1.Text = Globais.Nomefuncionario;
            bunifuCustomTextbox1.Enabled = false;
           
            Globais.wtvr = 0;
        }

       
        bool mostrar = false;
        private void bunifuCustomTextbox5_Click(object sender, EventArgs e)
        {
           
            Globais.wtvr = 0;

            dataGridView1.DataSource = BLL.Vender.Load();
            
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            data = dateTimePicker1.Value;

            dt = true;



        }

       

       

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Id_Veiculo = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            if (Globais.wtvr == 0)
            {
                N_Funcionario = (int)dataGridView1.Rows[e.RowIndex].Cells["Id_Funcionario"].Value;

                nomeC = (int)dataGridView1.Rows[e.RowIndex].Cells["Id_Clientes"].Value;

                string kappa = (string)BLL.Vender.nome(nomeC);

                Instrutor_Nome.Text = kappa;

                preço = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Preco"].Value);

                bunifuCustomTextbox3.Text = preço.ToString();

                N_Vender = (int)dataGridView1.Rows[e.RowIndex].Cells["Id_Vendas"].Value;
                bunifuCustomTextbox5.Text = N_Vender.ToString();
               
                id = (int)BLL.Vender2.editarJogo1(N_Vender);


                dataGridView2.DataSource = BLL.Vender2.editarJogo2(N_Vender);
                
              
                dateTimePicker1.Value = (DateTime)dataGridView1.Rows[e.RowIndex].Cells["Data_Contrato"].Value;

           
            }
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Instrutor_Nome_TextChanged(object sender, EventArgs e)
        {
            mostrar = true;
            Instrutor_Nome.Enabled = true;
            
        }

      
    }
}


