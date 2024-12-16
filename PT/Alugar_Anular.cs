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
    public partial class Alugar_Anular : Form
    {
        public Alugar_Anular()
        {
            InitializeComponent();
        }
        int Id_Veiculo;

        int N_Vender;

        int N_Funcionario;

        int nomeC;

        int id;
       
        int preço;
        int b;
        int total;
        int st;
        int a;
        bool ativar;
        DateTime data;
        DateTime data1;
        bool dt = false;
        bool dt1 = false;
        private void Alugar_Editar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Alugar.Load();
            bunifuCustomTextbox1.Text = Globais.Nomefuncionario;
            bunifuCustomTextbox1.Enabled = false;
            int year = dateTimePicker1.Value.Year;
            int month = dateTimePicker1.Value.Month;
            int day = dateTimePicker1.Value.Day;
            Globais.wtvr = 0;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            
           
        }
       
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            int j = 0;
           
          
            //Error Provider Referencia
            if (bunifuCustomTextbox5.Text.Trim().Length == 0)
            {

                errorProvider7.SetError(bunifuCustomTextbox5, "Escolha o aluguer que pretende editar");
            }
            else
            {
                j += 1;
                errorProvider7.SetError(bunifuCustomTextbox5, null);
            }
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

            if (dt == true)
            {

                j += 1;
                errorProvider5.SetError(dateTimePicker1, null);

            }
            else
            {

                errorProvider5.SetError(dateTimePicker1, "Introduza a Data do Contrato");
            }
            //Error Provider Data de Fim

            if (dt1 == true)
            {

                j += 1;
                errorProvider6.SetError(dateTimePicker2, null);

            }
            else
            {

                errorProvider6.SetError(dateTimePicker2, "Introduza a Data do Contrato ");
            }
          
            if (j == 6)
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
                            int w = BLL.Alugar.updateVeiculos((int)dataGridView2.Rows[row.Index].Cells[0].Value, "Sim");

                        }

                    }
                    int x = BLL.Alugar.removeAlugar(Convert.ToInt32(bunifuCustomTextbox5.Text));
                    MessageBox.Show("Aluguer anulado com sucesso", "Editar Aluguer", MessageBoxButtons.OK);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao inserir na Base de dados: " + ex);
                }
               
               
                Instrutor_Nome.Clear();
                dataGridView2.DataSource = null;
                dataGridView2.Refresh();


                bunifuCustomTextbox3.Clear();
                Globais.wtvr = 0;
                dataGridView1.DataSource = BLL.Alugar.Load();




            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
        
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }


       
        int c;
       

        private void bunifuCustomTextbox5_Click(object sender, EventArgs e)
        {
            Globais.wtvr = 0;
            dataGridView1.DataSource = BLL.Alugar.Load();
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false; 

        }

        private void Instrutor_Nome_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuCustomTextbox2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Alugar.Loadvendased(Convert.ToInt32(label6.Text));
            
        }
        bool mostrar = false;
        private void Instrutor_Nome_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            if (mostrar == true)
            {
               
                dataGridView1.DataSource = BLL.Veiculos.Load();

                Globais.wtvr = 2;
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;


            }
            else
            {
                MessageBox.Show("Para utilizar esta função escolha, escolha primeiro a venda que pretende editar.", "Alerta", MessageBoxButtons.OK);
            }
        }
        
        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            
            if (Globais.wtvr == 2)
            {
                
                foreach (DataGridViewRow r in dataGridView2.SelectedRows)
                {
                    Id_Veiculo = (int)dataGridView2.Rows[r.Index].Cells[1].Value;
                    
                    if (!r.IsNewRow)
                    {
                       
                        int q = (int)BLL.Vender.Id(Id_Veiculo);
                       

                                           
                       
                        foreach (DataGridViewRow row in dataGridView2.Rows)
                        {
                            if (Id_Veiculo == (int)row.Cells["Id_Veiculo"].Value)
                            {
                                total = (int)dataGridView1.Rows[Id_Veiculo-1].Cells["Preco"].Value;
                                int f = BLL.Vender.updateVeiculos((int)row.Cells["Id_Veiculo"].Value, "Sim");
                                dataGridView1.DataSource = BLL.Veiculos.Load();
                                break;
                            }
                        }
                        DateTime compareTo1 = dateTimePicker1.Value;
                        DateTime now1 = dateTimePicker2.Value;
                        st = 0;
                        
                        st = Convert.ToInt32((now1 - compareTo1).TotalDays);

                        a = Convert.ToInt32(bunifuCustomTextbox3.Text);
                       

                      
                        total /= 1250;
                        c = total * st;

                        (bunifuCustomTextbox3.Text) = Convert.ToString(a - c);
                        try
                        {
                            int w = BLL.Alugar2.removeAlugar2(Id_Veiculo);

                            dataGridView2.DataSource = BLL.Alugar2.editarJogo2(N_Vender);
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao inserir na Base de dados: " + ex);
                        }




                    }
                }

            }
            else
            {
                MessageBox.Show("Só pode usar esta função, se no display em cima estiver apresentado os veículos.", "Alerta", MessageBoxButtons.OK);
            }
        }
       
        
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Id_Veiculo = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            if (Globais.wtvr == 0)
            {
                ativar = true;
                N_Funcionario = (int)dataGridView1.Rows[e.RowIndex].Cells["Id_Funcionario"].Value;

                nomeC = (int)dataGridView1.Rows[e.RowIndex].Cells["Id_Clientes"].Value;

                string kappa = (string)BLL.Vender.nome(nomeC);

                Instrutor_Nome.Text = kappa;

                preço = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Preco"].Value);

                bunifuCustomTextbox3.Text = preço.ToString();

                N_Vender = (int)dataGridView1.Rows[e.RowIndex].Cells["Id_Alugueres"].Value;
                bunifuCustomTextbox5.Text = N_Vender.ToString();
                id = (int)BLL.Alugar2.editarJogo1(N_Vender);


                dataGridView2.DataSource = BLL.Alugar2.editarJogo2(N_Vender);


                dateTimePicker1.Value = (DateTime)dataGridView1.Rows[e.RowIndex].Cells["Data_Aluguer_Inicio"].Value;
                dateTimePicker2.Value = (DateTime)dataGridView1.Rows[e.RowIndex].Cells["Data_Aluguer_Fim"].Value;

               total = Convert.ToInt32(bunifuCustomTextbox3.Text);



            }
            else if (Globais.wtvr == 1)
            {
                Instrutor_Nome.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                nomeC = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;

                int z = BLL.Alugar2.updateAlugar2_1(nomeC, N_Vender);



                dataGridView2.DataSource = BLL.Alugar2.editarJogo2(N_Vender);

            }
            else
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString() == "Sim" & dataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString() == "Sim")
                {

                    if (dataGridView2.ColumnCount >= 1)
                    {

                        foreach (DataGridViewRow row in dataGridView2.Rows)
                        {

                            if (row.Cells["Id_Veiculo"].Value == null)
                            {


                                BLL.Alugar2.InsertAlugar2(N_Vender, Id_Veiculo, nomeC);
                                int w = BLL.Vender.updateVeiculos(Id_Veiculo, "Não");
                                dataGridView1.DataSource = BLL.Veiculos.Load();

                                dataGridView2.DataSource = BLL.Alugar2.editarJogo2(N_Vender);




                                DateTime compareTo1 = dateTimePicker1.Value;
                                DateTime now1 = dateTimePicker2.Value;
                                st = 0;
                                
                                st = Convert.ToInt32((now1 - compareTo1).TotalDays);

                                a = Convert.ToInt32(bunifuCustomTextbox3.Text);
                               

                                total = (int)dataGridView1.Rows[e.RowIndex].Cells["Preco"].Value;

                                       


                                total /= 1250;
                                c = total * st;

                                (bunifuCustomTextbox3.Text) = Convert.ToString(a + c);
                                break;
                            }
                           

                        }
                    }




                }

            }
        }
        
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            dt = true;
            data = dateTimePicker1.Value;
            //if (ativar == false)
            //{


            //    if (Globais.wtvr == 2)
            //    {
            //        int year = dateTimePicker1.Value.Year;
            //        int month = dateTimePicker1.Value.Month;
            //        int day = dateTimePicker1.Value.Day;

            //        DateTime compareTo1 = dateTimePicker1.Value;
            //        DateTime now1 = dateTimePicker2.Value;
            //        st = 0;
            //        total = 0;
            //        st = Convert.ToInt32((now1 - compareTo1).TotalDays);


            //        foreach (DataGridViewRow row in dataGridView2.Rows)
            //        {
            //            foreach (DataGridViewRow r in dataGridView1.Rows)
            //            {
            //                if (r.Cells["Id_Veiculo"].Value == null || row.Cells["Id_Veiculo"].Value == null)
            //                {


            //                    break;
            //                }
            //                else if ((int)r.Cells["Id_Veiculo"].Value == (int)row.Cells["Id_Veiculo"].Value)
            //                {

            //                    total += (int)dataGridView1.Rows[row.Index].Cells["Preco"].Value;
            //                    break;
            //                }
            //            }
            //        }
            //        total /= 1250;

            //        c = total * st;

            //        bunifuCustomTextbox3.Text = c.ToString();

            //    }
            //    else
            //    {
            //        MessageBox.Show("Só pode usar esta função, se no display em cima estiver apresentado os veículos.", "Alerta", MessageBoxButtons.OK);
            //    }
            //}


        }
        
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dt1 = true;
            data1 = dateTimePicker2.Value;
            //if (ativar == false)
            //{


            //    if (Globais.wtvr == 2)
            //    {
            //        DateTime compareTo1 = dateTimePicker1.Value;
            //        DateTime now1 = dateTimePicker2.Value;
            //        st = 0;
            //        total = 0;
            //        st = Convert.ToInt32((now1 - compareTo1).TotalDays);


            //        foreach (DataGridViewRow row in dataGridView2.Rows)
            //        {
            //            foreach (DataGridViewRow r in dataGridView1.Rows)
            //            {
            //                if (r.Cells["Id_Veiculo"].Value == null || row.Cells["Id_Veiculo"].Value == null)
            //                {


            //                    break;
            //                }
            //                else if ((int)r.Cells["Id_Veiculo"].Value == (int)row.Cells["Id_Veiculo"].Value)
            //                {

            //                    total += (int)dataGridView1.Rows[row.Index].Cells["Preco"].Value;
            //                    break;
            //                }


            //            }
            //        }
            //        total /= 1250;

            //        c = total * st;

            //        bunifuCustomTextbox3.Text = c.ToString();

            //    }
            //    else
            //    {
            //        MessageBox.Show("Só pode usar esta função, se no display em cima estiver apresentado os veículos.", "Alerta", MessageBoxButtons.OK);
            //    }

            //}
            //ativar = false;
        }

        private void dataGridView1_CellBorderStyleChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            dataGridView1.DataSource = BLL.Alugar.Load();
            Globais.wtvr = 0;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
    }
}
