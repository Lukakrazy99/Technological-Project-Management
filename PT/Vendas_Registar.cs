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
        public int Id_Veiculo;

        public Vendas_Registar()
        {
            InitializeComponent();
        }
      
        private void Vendas_Registar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Vender.Load();
            
            bunifuCustomTextbox1.Text = Globais.Nomefuncionario;
            bunifuCustomTextbox1.Enabled = false;
         
           
        }
      
        private void Instrutor_Nome_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Clientes.Load();
          
            Globais.wtvr = 2;
        }

        private void bunifuCustomTextbox1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Funcionarios.Load();
           
        }

        private void bunifuCustomTextbox2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Vender.Loadvendas();
           
        }   

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Vender.Load();
            Globais.wtvr = 0;

        }
        DateTime data;
        bool dtf = false;
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            int j = 0;



            int a = Convert.ToInt32(bunifuCustomTextbox3.Text);

            int b = Convert.ToInt32(bunifuCustomTextbox3.Text);




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
            if (bunifuCustomTextbox1.Text.Trim().Length == 0)
            {

                errorProvider2.SetError(bunifuCustomTextbox1, "Escolha o funcionario");
            }
            else
            {
                j += 1;
                errorProvider2.SetError(bunifuCustomTextbox1, null);
            }

            //Error Provider Preço
            if (bunifuCustomTextbox3.Text.Trim().Length == 0)
            {

                errorProvider4.SetError(bunifuCustomTextbox3, "Escolha o preço");
            }
            else
            {
                int s = 0;
                for (int i = 0; i < bunifuCustomTextbox3.Text.Trim().Length; i++)
                {
                    if (Char.IsLetter(bunifuCustomTextbox3.Text, i))

                    {
                        s += 1;
                    }


                }
                if (s > 0)
                {
                    errorProvider4.SetError(bunifuCustomTextbox3, "Não é permitido letras");
                }
                else
                {
                    j += 1;
                    errorProvider4.SetError(bunifuCustomTextbox3, null);
                }

            }

            //Error Provider Data de Inicio

            if (dtf == true)
            {

                j += 1;
                errorProvider5.SetError(dateTimePicker1, null);

            }
            else
            {

                errorProvider5.SetError(dateTimePicker1, "Introduza a Data do Contrato");
            }
            //Error Provider Veiculo

            if (Id_Veiculo == 0)
            {
                errorProvider7.SetError(bunifuThinButton24, "Introduza o carro que pretende alugar ");
            }
            else
            {
                j += 1;
                errorProvider7.SetError(bunifuThinButton24, null);
            }
            if (dataGridView2.Rows.Count == 0)
            {
                errorProvider7.SetError(bunifuThinButton24, "Introduza o carro que pretende alugar ");
            }
            else
            {

               
                    if (j == 5)
                    {

                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        if (dataGridView2.Rows[row.Index].Cells[0].Value == null)
                        {
                            break;
                        }
                        else
                        {
                            int w = BLL.Vender.updateVeiculos((int)dataGridView2.Rows[row.Index].Cells[0].Value, "Não");

                        }

                    }

                    try
                    {
                        int x = BLL.Vender.insertVendas(Globais.NumeroFuncionario, data, Convert.ToInt32(bunifuCustomTextbox3.Text), Convert.ToInt32(label8.Text));

                            int ola1 = (int)BLL.Vender.queryMaxid();

                            DataTable dt = BLL.Vender.procurar(ola1);

                            Globais.wtvr = 0;
                            int ola;

                            ola = int.Parse(dt.Rows[0][0].ToString());



                            if (ola > 0)
                            {
                                foreach (DataGridViewRow row in dataGridView2.Rows)
                            {
                               
                                if (dataGridView2.Rows[row.Index].Cells[0].Value == null)
                                {
                                    break;
                                }
                                else
                                {
                                        int k = BLL.Vender2.InsertVender2(ola1, (int)dataGridView2.Rows[row.Index].Cells[0].Value, Convert.ToInt32(label8.Text));
                                    }
                                }
                            }
                            MessageBox.Show("Venda inserida com sucesso", "Inserir Venda", MessageBoxButtons.OK);
                            dataGridView2.Rows.Clear();
                            dataGridView2.Refresh();
                            Instrutor_Nome.Clear();

                            bunifuCustomTextbox3.Text = "0";

                            dataGridView1.DataSource = BLL.Vender.Load();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao inserir na Base de dados: " + ex);
                    }
                        




                
                    }
                
            }
        
            
        
        }
        string id_venda;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Globais.wtvr == 1)
            {
                Id_Veiculo = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;

                if (dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString() != "Não")
                {
                    if (dataGridView2.ColumnCount >= 1)
                    {

                        foreach (DataGridViewRow row in dataGridView2.Rows)
                        {

                            if (row.Cells["Column1"].Value == null)
                            {

                                dataGridView2.Rows.Add(dataGridView1.Rows[e.RowIndex].Cells[0].Value, dataGridView1.Rows[e.RowIndex].Cells[1].Value, dataGridView1.Rows[e.RowIndex].Cells[2].Value, dataGridView1.Rows[e.RowIndex].Cells[3].Value, dataGridView1.Rows[e.RowIndex].Cells[4].Value, dataGridView1.Rows[e.RowIndex].Cells[5].Value, dataGridView1.Rows[e.RowIndex].Cells[6].Value, dataGridView1.Rows[e.RowIndex].Cells[7].Value, dataGridView1.Rows[e.RowIndex].Cells[8].Value, dataGridView1.Rows[e.RowIndex].Cells[9].Value, dataGridView1.Rows[e.RowIndex].Cells[10].Value, dataGridView1.Rows[e.RowIndex].Cells[11].Value, dataGridView1.Rows[e.RowIndex].Cells[12].Value, dataGridView1.Rows[e.RowIndex].Cells[13].Value, dataGridView1.Rows[e.RowIndex].Cells[14].Value, dataGridView1.Rows[e.RowIndex].Cells[15].Value, dataGridView1.Rows[e.RowIndex].Cells[16].Value, dataGridView1.Rows[e.RowIndex].Cells[17].Value);

                                int a;

                                a = Convert.ToInt32(bunifuCustomTextbox3.Text);

                                string s = dataGridView1.Rows[e.RowIndex].Cells[17].Value.ToString();

                                decimal b = decimal.Parse(s);

                                (bunifuCustomTextbox3.Text) = Convert.ToString(a + b);


                                break;
                            }
                            else if (Id_Veiculo == (int)row.Cells["Column1"].Value)
                            {

                               

                                int a;

                                a = Convert.ToInt32(bunifuCustomTextbox3.Text);

                                string s = dataGridView1.Rows[e.RowIndex].Cells[17].Value.ToString();

                                decimal b = decimal.Parse(s);

                                (bunifuCustomTextbox3.Text) = Convert.ToString(a + b);
                                break;
                            }
                        }
                    }
                    
                   dataGridView1.Rows[e.RowIndex].Cells[14].Value = "Não";
                }
            
            }
            else if(Globais.wtvr == 2)
            {
                Instrutor_Nome.Text = dataGridView1.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                label8.Text = dataGridView1.Rows[e.RowIndex].Cells["Id_Clientes"].Value.ToString();
            }          
            
            else
            {
                id_venda = dataGridView1.Rows[e.RowIndex].Cells["Id_Vendas"].Value.ToString();
            }



         
        }

        private void bunifuCustomTextbox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
           
        }

        

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

                data = dateTimePicker1.Value;
           
                dtf = true;
                                                 
        }

        private void bunifuThinButton23_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView2.SelectedRows)
            {
                Id_Veiculo = (int)dataGridView2.Rows[r.Index].Cells[0].Value;

                if (!r.IsNewRow)
                {
                    int a;

                    a = Convert.ToInt32(bunifuCustomTextbox3.Text);

                    string s = dataGridView2.Rows[r.Index].Cells[17].Value.ToString();

                    int b = int.Parse(s);

                    (bunifuCustomTextbox3.Text) = Convert.ToString(a - b);

                    
                                  dataGridView2.Rows.RemoveAt(r.Index);
                   
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (Id_Veiculo == (int)row.Cells["Id_Veiculo"].Value)
                        {
                            dataGridView1.Rows[row.Index].Cells[14].Value = "Sim";
                            break;
                        }
                    }
                }
                       
            }
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Vender.Loadvendas();
            errorProvider7.SetError(bunifuThinButton24, null);
            Globais.wtvr = 1;
        }

        private void Instrutor_Nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {

            try
            {
                int x = BLL.Vender.removeVendas(Convert.ToInt32(id_venda));

               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir na Base de dados: " + ex);
            }
        }
    }
}

