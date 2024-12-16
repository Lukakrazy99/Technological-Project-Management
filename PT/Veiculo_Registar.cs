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
    public partial class Veiculo_Registar : Form
    {
        public Veiculo_Registar()
        {
            InitializeComponent();
            
        }

        private void Veiculo_Registar_Load(object sender, EventArgs e)
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
            DataTable fg = BLL.Marca_Modelo.marca();
            
            Veiculo_Marca.DataSource = fg;
            Veiculo_Marca.DisplayMember = "Marca";
       
            DataTable gf = BLL.Marca_Modelo.modelo(Veiculo_Marca.Text);
            Veiculo_Modelo.DataSource = gf;
            Veiculo_Modelo.DisplayMember = "Modelo";
            dataGridView1.DataSource = BLL.Veiculos.Load();
            this.SendToBack();
        }
        bool Ins = false;
        bool Rev = false;
        bool Seg = false;
        private void adicionar_veiculo_Click(object sender, EventArgs e)
        {
            bool erro = false;
            int j = 0;
            
            //Error Provider Matricula
            if (Veiculo_Matricula.Text.Trim().Length == 6)
            {

                if ((BLL.Veiculos.queryValidaçaoMatricula(Veiculo_Matricula.Text)).Rows.Count > 0)
                {
                    erro = true;
                    errorProvider1.SetError(Veiculo_Matricula, "A matricula inserida já se encontra na base de dados");
                }
                else
                {
                    j += 1;
                    errorProvider1.SetError(Veiculo_Matricula, null);
                }


            }
            else
            {
                errorProvider1.SetError(Veiculo_Matricula, "Matricula incompleta");
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
            if(checkBox1.Checked == true)
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

            if (j == 14)


                if (erro == false)
                {

                    try
                    {
                       
                            int x = BLL.Veiculos.insertVeiculos(Veiculo_Matricula.Text, Veiculo_Marca.Text, Veiculo_Modelo.Text, Veiculo_TdC.Text, Convert.ToInt32(Veiculo_KM.Text), Veiculo_Comb.Text, Convert.ToInt32(Veiculo_Ano.Text), Veiculo_Cor.Text, Convert.ToInt32(Veiculo_Cilindrada.Text), Convert.ToInt32(Veiculo_Potencia.Text), Inspecao, Revisao, Seguro, "Sim", alugar, vender, Convert.ToInt32(textBox1.Text));
                        MessageBox.Show("Veículo inserido com sucesso", "Inserir Veículo", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao inserir na Base de dados: " + ex);
                    }
                    Veiculo_Matricula.Clear();
                   
                    //Veiculo_TdC.Items.Clear();
                    Veiculo_KM.Clear();
                    //Veiculo_Comb.Items.Clear();
                    Veiculo_Ano.Clear();
                    Veiculo_Cor.Clear();
                    Veiculo_Cilindrada.Clear();
                    Veiculo_Potencia.Clear();
                   
                    dataGridView1.DataSource = BLL.Veiculos.Load();

                }
        }
        DateTime Inspecao;
        DateTime Revisao;
        DateTime Seguro;

       

        private void Veiculo_Registar_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void Veiculo_Registar_MouseMove_1(object sender, MouseEventArgs e)
        {

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

        private void Veiculo_Matricula_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //Error Provider Matricula
            if (Veiculo_Matricula.Text.Trim().Length == 6)
            {

                if ((BLL.Veiculos.queryValidaçaoMatricula(Veiculo_Matricula.Text)).Rows.Count > 0)
                {
                
                    errorProvider1.SetError(Veiculo_Matricula, "A matricula inserida já se encontra na base de dados");
                }
                else
                {
                    errorProvider1.SetError(Veiculo_Matricula, null);
                }


            }
            else
            {
                errorProvider1.SetError(Veiculo_Matricula, "Matricula incompleta");
            }
        }

        private void Veiculo_Marca_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Globais.marca = Veiculo_Marca.Text;
            Adicionar_carro f2 = new Adicionar_carro();
            f2.Show();

        }

        private void Veiculo_Marca_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Veiculo_Marca_Click(object sender, EventArgs e)
        {
            
        }

        private void Veiculo_Marca_TextChanged_1(object sender, EventArgs e)
        {
            errorProvider2.SetError(Veiculo_Marca, null);
            DataTable gf = BLL.Marca_Modelo.modelo(Veiculo_Marca.Text);
            Veiculo_Modelo.DataSource = gf;
            Veiculo_Modelo.DisplayMember = "Modelo";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Marca f3 = new Marca();
            f3.Show();
       

        }

        private void Veiculo_Marca_DropDown(object sender, EventArgs e)
        {
			DataTable fg = BLL.Marca_Modelo.marca();

			Veiculo_Marca.DataSource = fg;
			Veiculo_Marca.DisplayMember = "Marca";
		}

        private void Veiculo_Modelo_DropDown(object sender, EventArgs e)
        {
            errorProvider2.SetError(Veiculo_Marca, null);
            DataTable gf = BLL.Marca_Modelo.modelo(Veiculo_Marca.Text);
            Veiculo_Modelo.DataSource = gf;
            Veiculo_Modelo.DisplayMember = "Modelo";
        }

		private void Veiculo_Marca_SelectedIndexChanged_1(object sender, EventArgs e)
		{

		}
	}
}
