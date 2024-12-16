using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT
{
    public partial class Veiculo_Editar : Form
    {
       

        public Veiculo_Editar()
        {
            InitializeComponent();
        }
        bool Ins = false;
        bool Rev = false;
        bool Seg = false;
        private void Veiculo_Editar_Load(object sender, EventArgs e)
        {
            int year = dateTimePicker1.Value.Year;
            int month = dateTimePicker1.Value.Month;
            int day = dateTimePicker1.Value.Day;

            dateTimePicker1.MinDate = new DateTime(year - 3, month, day);
            dateTimePicker1.MaxDate = new DateTime(year + 10, month, day);
            dateTimePicker2.MinDate = new DateTime(year - 3, month, day);
            dateTimePicker2.MaxDate = new DateTime(year + 10, month, day);
            dateTimePicker3.MinDate = new DateTime(year - 3, month, day);
            dateTimePicker3.MaxDate = new DateTime(year + 10, month, day);

            dataGridView1.DataSource = BLL.Veiculos.Load();
            this.SendToBack();
        }

        private void adicionar_aluno_Click(object sender, EventArgs e)
        {
            bool erro = false;
            int j = 0;

            //Error Provider Matricula
            if (Veiculo_Matricula.Text.Trim().Length == 6)
            {


                if ((BLL.Veiculos.queryValidaçaoMatriculaed(Veiculo_Matricula.Text, label16.Text)).Rows.Count > 0)
                {
                    erro = true;
                    errorProvider14.SetError(Veiculo_Matricula, "A matricula inserida já se encontra na base de dados");
                }
                else
                {
                    j += 1;
                    errorProvider14.SetError(Veiculo_Matricula, null);
                }


            }
            else
            {
                errorProvider14.SetError(Veiculo_Matricula, "Matricula incompleta");
            }

            //Error Provider Marca
            if (Veiculo_Marca.Text.Trim().Length == 0)
            {
                errorProvider2.SetError(Veiculo_Marca, "Escreva a marca do veiculo");
            }
            else
            {
                int s = 0;
                for (int i = 0; i < Veiculo_Marca.Text.Trim().Length; i++)
                {
                    if (Char.IsDigit(Veiculo_Marca.Text, i))

                    {
                        s += 1;
                    }


                }
                if (s > 0)
                {
                    errorProvider2.SetError(Veiculo_Marca, "Não é permitido números");
                }
                else
                {
                    j += 1;
                    errorProvider2.SetError(Veiculo_Marca, null);
                }
            }
            //Error Provider Marca
            if (Veiculo_Marca.Text.Trim().Length == 0)
            {
                errorProvider2.SetError(Veiculo_Marca, "Escreva a marca do veiculo");
            }
            else
            {
                j += 1;
                errorProvider2.SetError(Veiculo_Marca, null);
            }

            //Error Provider Modelo
            if (Veiculo_Modelo.Text.Trim().Length == 0)
            {
                errorProvider3.SetError(Veiculo_Modelo, "Escreva o modelo do veiculo");
            }
            else
            {
                j += 1;
                errorProvider3.SetError(Veiculo_Modelo, null);
            }

            //Error Provider Tipo de Veiculo
            if (Veiculo_TdC.Text.Trim().Length == 0)
            {
                errorProvider4.SetError(Veiculo_TdC, "Selecione o tipo de carro");
            }
            else
            {
                j += 1;
                errorProvider4.SetError(Veiculo_TdC, null);
            }

            //Error Provider Quilometros
            if (Veiculo_KM.Text.Trim().Length == 0)
            {
                errorProvider5.SetError(Veiculo_KM, "Indique quantos quilomtros que o carro tem");
            }
            else
            {
                int s = 0;
                for (int i = 0; i < Veiculo_KM.Text.Trim().Length; i++)
                {
                    if (Char.IsLetter(Veiculo_KM.Text, i))

                    {
                        s += 1;
                    }


                }
                if (s > 0)
                {
                    errorProvider5.SetError(Veiculo_KM, "Não é permitido letras");
                }
                else
                {
                    j += 1;
                    errorProvider5.SetError(Veiculo_KM, null);
                }
            }


            //Error Provider Combustivel
            if (Veiculo_Comb.Text.Trim().Length == 0)
            {
                errorProvider6.SetError(Veiculo_Comb, "Indique o combustivel do carro");
            }
            else
            {
                j += 1;
                errorProvider6.SetError(Veiculo_Comb, null);
            }

            //Error Provider Ano
            if (Veiculo_Ano.Text.Trim().Length == 0)
            {
                errorProvider7.SetError(Veiculo_Ano, "Indique de que ano é o veiculo");
            }
            else
            {
                j += 1;
                errorProvider7.SetError(Veiculo_Ano, null);
            }

            //Error Provider Cor
            if (Veiculo_Cor.Text.Trim().Length == 0)
            {
                errorProvider8.SetError(Veiculo_Cor, "Indique a cor do veiculo");
            }
            else
            {
                j += 1;
                errorProvider8.SetError(Veiculo_Cor, null);
            }

            //Error Provider Cilindrada
            if (Veiculo_Cilindrada.Text.Trim().Length == 0)
            {
                errorProvider9.SetError(Veiculo_Cilindrada, "Indique quantas cilindradas tem o veiculo");
            }
            else
            {
                int s = 0;
                for (int i = 0; i < Veiculo_Cilindrada.Text.Trim().Length; i++)
                {
                    if (Char.IsLetter(Veiculo_Cilindrada.Text, i))

                    {
                        s += 1;
                    }


                }
                if (s > 0)
                {
                    errorProvider9.SetError(Veiculo_Cilindrada, "Não é permitido letras");
                }
                else
                {
                    j += 1;
                    errorProvider9.SetError(Veiculo_Cilindrada, null);
                }
            }


            //Error Provider Potencia
            if (Veiculo_Potencia.Text.Trim().Length == 0)
            {
                errorProvider10.SetError(Veiculo_Potencia, "Indique a potencia do veiculo");
            }
            else
            {
                int s = 0;
                for (int i = 0; i < Veiculo_Potencia.Text.Trim().Length; i++)
                {
                    if (Char.IsLetter(Veiculo_Potencia.Text, i))

                    {
                        s += 1;
                    }


                }
                if (s > 0)
                {
                    errorProvider10.SetError(Veiculo_Potencia, "Não é permitido letras");
                }
                else
                {
                    j += 1;
                    errorProvider10.SetError(Veiculo_Potencia, null);
                }
            }
            //Error Provider Inspeção
            if (Ins == true)
            {

                j += 1;
                errorProvider11.SetError(dateTimePicker1, null);

            }
            else
            {

                errorProvider11.SetError(dateTimePicker1, "Indique a proxima inspeção");
            }

            //Error Provider Revisao
            if (Rev == true)
            {

                j += 1;
                errorProvider12.SetError(dateTimePicker2, null);

            }
            else
            {

                errorProvider12.SetError(dateTimePicker2, "Indique a proxima revisão");
            }

            //Error Provider Seguro
            if (Seg == true)
            {

                j += 1;
                errorProvider13.SetError(dateTimePicker3, null);

            }
            else
            {

                errorProvider13.SetError(dateTimePicker3, "Introduza o proximo pagamento do seguro");
            }
            //Error Provider Alugar e Vender
            if (checkBox1.Checked == true | checkBox2.Checked == true)
            {
                j += 1;
                errorProvider14.SetError(checkBox1, null);
                errorProvider15.SetError(checkBox2, null);
            }
            else
            {
                errorProvider14.SetError(checkBox1, "Escolha se pretende alugar ou vender");
                errorProvider15.SetError(checkBox2, "Escolha se pretende alugar ou vender");
            }
            string alugar;
            string vender;
            if (checkBox1.Checked == true)
            {
                alugar = "Sim";
            }
            else
            {
                alugar = "Nao";
            }
            if (checkBox2.Checked == true)
            {
                vender = "Sim";
            }
            else
            {
                vender = "Nao";
            }





            if (j == 15)


                if (erro == false)
                {

                    try
                    {
                        int x = BLL.Veiculos.updateVeiculos(Convert.ToInt32(label16.Text), Veiculo_Matricula.Text, Veiculo_Marca.Text, Veiculo_Modelo.Text, Veiculo_TdC.Text, Convert.ToInt32(Veiculo_KM.Text), Veiculo_Comb.Text, Convert.ToInt32(Veiculo_Ano.Text), Veiculo_Cor.Text, Convert.ToInt32(Veiculo_Cilindrada.Text), Convert.ToInt32(Veiculo_Potencia.Text), Inspecao, Revisao, Seguro, Ativo, alugar, vender, Convert.ToInt32(textBox1.Text));
                        MessageBox.Show("Veículo editado com sucesso", "Editar Veículo", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao inserir na Base de dados: " + ex);
                    }
                    Veiculo_Matricula.Clear();
                    Veiculo_Marca.Clear();
                    Veiculo_Modelo.Clear();               
                    Veiculo_KM.Clear();                   
                    Veiculo_Ano.Clear();
                    Veiculo_Cor.Clear();
                    Veiculo_Cilindrada.Clear();
                    Veiculo_Potencia.Clear();

                    dataGridView1.DataSource = BLL.Veiculos.Load();

                }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }
        DateTime Inspecao;
        DateTime Revisao;
        DateTime Seguro;
      
        string Ativo = "Não";
      

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label16.Text = dataGridView1.Rows[e.RowIndex].Cells["Id_Veiculo"].Value.ToString();
            Veiculo_Matricula.Text = dataGridView1.Rows[e.RowIndex].Cells["Matricula"].Value.ToString();
            Veiculo_Marca.Text = dataGridView1.Rows[e.RowIndex].Cells["Marca"].Value.ToString();
            Veiculo_Modelo.Text = dataGridView1.Rows[e.RowIndex].Cells["Modelo"].Value.ToString();
            Veiculo_TdC.Text = dataGridView1.Rows[e.RowIndex].Cells["Categoria"].Value.ToString();
            Veiculo_KM.Text = dataGridView1.Rows[e.RowIndex].Cells["Quilometros"].Value.ToString();
            Veiculo_Comb.Text = dataGridView1.Rows[e.RowIndex].Cells["Combustível"].Value.ToString();
            Veiculo_Ano.Text = dataGridView1.Rows[e.RowIndex].Cells["Ano"].Value.ToString();
            Veiculo_Cor.Text = dataGridView1.Rows[e.RowIndex].Cells["Cor"].Value.ToString();
            Veiculo_Cilindrada.Text = dataGridView1.Rows[e.RowIndex].Cells["Cilindrada"].Value.ToString();
            Veiculo_Potencia.Text = dataGridView1.Rows[e.RowIndex].Cells["Potencia"].Value.ToString();
            dateTimePicker1.Value = (DateTime)dataGridView1.Rows[e.RowIndex].Cells["Inspecao"].Value;
            dateTimePicker2.Value = (DateTime)dataGridView1.Rows[e.RowIndex].Cells["Revisao"].Value;
            dateTimePicker3.Value = (DateTime)dataGridView1.Rows[e.RowIndex].Cells["Seguro"].Value;
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["Preco"].Value.ToString();

            if (dataGridView1.Rows[e.RowIndex].Cells["Ativo"].Value.ToString() == "Sim")
            {
                Veiculo_Ativo.Checked = true;

            }
            else
            {
                Veiculo_Ativo.Checked = false;
            }
            if (dataGridView1.Rows[e.RowIndex].Cells["Alugar"].Value.ToString() == "Sim")
            {
                checkBox1.Checked = true;

            }
            else
            {
               checkBox1.Checked = false;
            }
            if (dataGridView1.Rows[e.RowIndex].Cells["Vender"].Value.ToString() == "Sim")
            {
                checkBox2.Checked = true;

            }
            else
            {
               checkBox2.Checked = false;
            }
            if (Veiculo_Ativo.Checked == true)
            {
                Ativo = "Sim";
            }
            else
            {
                Ativo = "Não";
            }
        }

      

        private void Veiculo_Ativo_OnChange(object sender, EventArgs e)
        {
            if (Veiculo_Ativo.Checked == true)
            {
                Ativo = "Sim";
            }
            else
            {
                Ativo = "Não";
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Inspecao = dateTimePicker1.Value;
            Ins = true;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            Revisao = dateTimePicker2.Value;
            Rev = true;
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            Seguro = dateTimePicker3.Value;
            Seg = true;
        }
    }
    }

