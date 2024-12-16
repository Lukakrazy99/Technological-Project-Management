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
    public partial class Alugar_Registar : Form
    {
        public int Id_Veiculo;
        int a;
        DateTime data;
        DateTime data1;
        string dd;
        string dd1;
        bool dt = false;
        bool dt1 = false;
        int b;
        int total;
        int c;

        public Alugar_Registar()
        {
            InitializeComponent();
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
            dataGridView1.DataSource = BLL.Alugar.Loadalugar();

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Alugar.Load();
            Globais.wtvr = 0;

        }

        private void Alugar_Registar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Alugar.Load();
            bunifuCustomTextbox1.Text = Globais.Nomefuncionario;
            bunifuCustomTextbox1.Enabled = false;
            int year = dateTimePicker1.Value.Year;
            int month = dateTimePicker1.Value.Month;
            int day = dateTimePicker1.Value.Day;
            Globais.wtvr = 0;
            dateTimePicker1.MinDate = new DateTime(year, month - 1, day);
            dateTimePicker1.MaxDate = new DateTime(year + 1, month + 1, day);
            dateTimePicker2.MinDate = new DateTime(year, month - 1, day);
            dateTimePicker2.MaxDate = new DateTime(year, month + 1, day);

        }
       
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
            if (dataGridView2.Rows.Count != 0)
            {
                if (j == 6)
                {



                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        if (dataGridView2.Rows[row.Index].Cells[0].Value == null)
                        {
                            break;
                        }
                        else
                        {
                            int w = BLL.Alugar.updateVeiculos((int)dataGridView2.Rows[row.Index].Cells[0].Value, "Não");

                        }

                    }

                    try
                    {
                        int x = BLL.Alugar.insertAlugar(Convert.ToInt32(label8.Text), Globais.NumeroFuncionario, data, data1, Convert.ToInt32(bunifuCustomTextbox3.Text));

                        Globais.wtvr = 0;

                        int ola1 = (int)BLL.Alugar.queryMaxid();

                        DataTable dt = BLL.Alugar.procurar(ola1);

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
                                    int k = BLL.Alugar2.InsertAlugar2(ola1, (int)dataGridView2.Rows[row.Index].Cells[0].Value, Convert.ToInt32(label8.Text));
                                }
                            }
                        }

                        MessageBox.Show("Aluguer inserido com sucesso", "Inserir Venda", MessageBoxButtons.OK);


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao inserir na Base de dados: " + ex);
                    }

                    Instrutor_Nome.Clear();
                    dataGridView2.Rows.Clear();
                    dataGridView2.Refresh();
                    bunifuCustomTextbox3.Text = "0";
                    dataGridView1.DataSource = BLL.Alugar.Load();


                }
            }
            else
            {
                MessageBox.Show("Introduza veículos ao aluguer", "Erro", MessageBoxButtons.OK);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Enabled = true;
            data = dateTimePicker1.Value;

            dt = true;
            int year = dateTimePicker1.Value.Year;
            int month = dateTimePicker1.Value.Month;
            int day = dateTimePicker1.Value.Day;
            dateTimePicker2.MinDate = new DateTime(year, month, day);
            dateTimePicker2.MaxDate = new DateTime(year + 1, month, day);

            DateTime compareTo1 = dateTimePicker1.Value;
            DateTime now1 = dateTimePicker2.Value;
             int r = 0;
            r = Convert.ToInt32((now1 - compareTo1).TotalDays);

             total = 0;



            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (dataGridView2.Rows[row.Index].Cells[17].Value == null)
                {
                    break;
                }
                else
                {


                    total += (int)dataGridView2.Rows[row.Index].Cells[17].Value;
                }
            }
            total /= 1250;

            c = (total * r);
            bunifuCustomTextbox3.Text = c.ToString();



        }

        
       
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dt1 = true;

            data1 = dateTimePicker2.Value;
            DateTime compareTo1 = dateTimePicker1.Value;
            DateTime now1 = dateTimePicker2.Value;
            int r = 0;
            r = Convert.ToInt32((now1 - compareTo1).TotalDays);

             total = 0;



            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (dataGridView2.Rows[row.Index].Cells[17].Value == null)
                {
                    break;
                }
                else
                {


                    total += (int)dataGridView2.Rows[row.Index].Cells[17].Value;
                }
            }
            total /= 1250;
            
             c = (total * r);
            bunifuCustomTextbox3.Text = c.ToString();


            
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            ////DataTable dt = BLL.Alugar.datas();
            //dataGridView1.DataSource = BLL.Alugar.Loadalugar();
            dataGridView1.DataSource = BLL.Alugar.veiculos(data, data1);
          





            Globais.wtvr = 1;

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (Globais.wtvr == 1)
            {
                Id_Veiculo = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;

                if ( dataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString() == "Sim")
                {
                    if (dataGridView2.ColumnCount >= 1)
                    {

                        foreach (DataGridViewRow row in dataGridView2.Rows)
                        {

                            if (row.Cells["Column1"].Value == null)
                            {

                                dataGridView2.Rows.Add(dataGridView1.Rows[e.RowIndex].Cells[0].Value, dataGridView1.Rows[e.RowIndex].Cells[1].Value, dataGridView1.Rows[e.RowIndex].Cells[2].Value, dataGridView1.Rows[e.RowIndex].Cells[3].Value, dataGridView1.Rows[e.RowIndex].Cells[4].Value, dataGridView1.Rows[e.RowIndex].Cells[5].Value, dataGridView1.Rows[e.RowIndex].Cells[6].Value, dataGridView1.Rows[e.RowIndex].Cells[7].Value, dataGridView1.Rows[e.RowIndex].Cells[8].Value, dataGridView1.Rows[e.RowIndex].Cells[9].Value, dataGridView1.Rows[e.RowIndex].Cells[10].Value, dataGridView1.Rows[e.RowIndex].Cells[11].Value, dataGridView1.Rows[e.RowIndex].Cells[12].Value, dataGridView1.Rows[e.RowIndex].Cells[13].Value, dataGridView1.Rows[e.RowIndex].Cells[14].Value, dataGridView1.Rows[e.RowIndex].Cells[15].Value, dataGridView1.Rows[e.RowIndex].Cells[16].Value, dataGridView1.Rows[e.RowIndex].Cells[17].Value);

                                

                                a = Convert.ToInt32(bunifuCustomTextbox3.Text);

                                string s = dataGridView1.Rows[e.RowIndex].Cells[17].Value.ToString();

                                int total = int.Parse(s);
                                DateTime compareTo1 = dateTimePicker1.Value;
                                DateTime now1 = dateTimePicker2.Value;
                                b = 0;

                                b = Convert.ToInt32((now1 - compareTo1).TotalDays);
                                total /= 1250;
                                c = total * b;


                                (bunifuCustomTextbox3.Text) = Convert.ToString(a + c);

                                break;
                            }
                            else if (Id_Veiculo == (int)row.Cells["Column1"].Value)
                            {
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

            }
        }
        
        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView2.SelectedRows)
            {
             
                Id_Veiculo = (int)dataGridView2.Rows[r.Index].Cells[0].Value;
                total = (int)dataGridView2.Rows[r.Index].Cells[17].Value;
                if (!r.IsNewRow)
                {
                    int a;

                    a = Convert.ToInt32(bunifuCustomTextbox3.Text);
                                   

                    dataGridView2.Rows.RemoveAt(r.Index);
                    DateTime compareTo1 = dateTimePicker1.Value;
                    DateTime now1 = dateTimePicker2.Value;
                    b = 0;
                   
                    b = Convert.ToInt32((now1 - compareTo1).TotalDays);
                    total /= 1250;
                    c = total * b;


                    (bunifuCustomTextbox3.Text) = Convert.ToString(a - c);


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
    }
}
