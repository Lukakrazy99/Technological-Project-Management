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
    public partial class Funcionarios_Editar : Form
    {
        public Funcionarios_Editar()
        {
            InitializeComponent();
        }

        private void Funcionarios_Editar_Load(object sender, EventArgs e)
        {
            int year = dateTimePicker1.Value.Year;
            int month = dateTimePicker1.Value.Month;
            int day = dateTimePicker1.Value.Day;

            dateTimePicker1.MinDate = new DateTime(year - 100, month, day);
            dateTimePicker1.MaxDate = new DateTime(year - 18, month, day);

            dataGridView1.DataSource = BLL.Funcionarios.Load();
            this.SendToBack();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        bool dn = false;
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            bool erro = false;
            int j = 0;
            //Error Provider Nome
            if (Instrutor_Nome.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(Instrutor_Nome, "Escreva um nome");
            }
            else
            {
                int s = 0;
                for (int i = 0; i < Instrutor_Nome.Text.Trim().Length; i++)
                {
                    if (Char.IsDigit(Instrutor_Nome.Text, i))

                    {
                        s += 1;
                    }
                    

                }
                if (s > 0)
                {
                    errorProvider1.SetError(Instrutor_Nome, "Não é permitido números");
                }
                else
                {
                    j += 1;
                    errorProvider1.SetError(Instrutor_Nome, null);
                }
            }
            //Error Provider CC
            int n = 0;
            for (int i = 0; i < Instrutor_CC.Text.Trim().Length; i++)
            {
                if (Char.IsDigit(Instrutor_CC.Text, i))

                {
                    n += 1;

                }

            }
            if (n == 10)
            {
                if (Char.IsLetter(Instrutor_CC.Text, 9))
                {

                    if (Char.IsLetter(Instrutor_CC.Text, 10))
                    {
                        if (BLL.Funcionarios.queryValidaçaoCCed(Convert.ToInt32(label5.Text), Instrutor_CC.Text).Rows.Count > 0)

                        {
                            erro = true;
                            errorProvider2.SetError(Instrutor_CC, "Este CC já se encontra na base de dados");
                        }
                        else
                        {
                            j += 1;
                            errorProvider2.SetError(Instrutor_CC, null);
                        }
                    }
                    else
                    {
                        errorProvider2.SetError(Instrutor_CC, "O CC está incorreto");
                    }
                }
                else
                {
                    errorProvider2.SetError(Instrutor_CC, "O CC está incorreto");
                }
            }

            else

            {
                errorProvider2.SetError(Instrutor_CC, "O CC está incorreto");
            }

            //Error Provider NIF
            n = 0;
            if (Instrutor_NIF.Text.Trim().Length == 9)
            {
                if (BLL.Funcionarios.queryValidaçaoNIFed(Convert.ToInt32(label5.Text), Convert.ToInt32(Instrutor_NIF.Text)).Rows.Count > 0)
                {
                    erro = true;
                    errorProvider3.SetError(Instrutor_NIF, "Este NIF já se encontra na base de dados");
                }
                else
                {
                    j += 1;
                    errorProvider3.SetError(Instrutor_NIF, null);
                }
            }
            else
            {

                errorProvider3.SetError(Instrutor_NIF, "O NIF está incorreto");
            }
            //Error Provider Telemovel
            if (Instrutor_Telemovel.Text.Trim().Length == 9)
            {
                if (BLL.Funcionarios.queryValidaçaoTelemoveled(Convert.ToInt32(label5.Text), Convert.ToInt32(Instrutor_Telemovel.Text)).Rows.Count > 0)

                {
                    erro = true;
                    errorProvider4.SetError(Instrutor_Telemovel, "Este telemovel já se encontra na base de dados");
                }
                else
                {
                    j += 1;
                    errorProvider4.SetError(Instrutor_Telemovel, null);
                }
            }
            else
            {

                errorProvider4.SetError(Instrutor_Telemovel, "O numero está incorreto");
            }
            //Error Provider Certificaçao
            if (Instrutor_Certificacao.Text.Trim().Length == 0)
            {

                errorProvider5.SetError(Instrutor_Certificacao, "Escolha um Certificação");
            }
            else
            {

                j += 1;
                errorProvider5.SetError(Instrutor_Certificacao, null);
            }

            //Error Provider Morada
            if (Instrutor_Morada.Text.Trim().Length == 0)
            {

                errorProvider6.SetError(Instrutor_Morada, "Escreva uma morada");
            }
            else
            {
                j += 1;
                errorProvider6.SetError(Instrutor_Morada, null);
            }
            //Error Provider Codigo Postal
            if (Instrutor_Cod_Postal.Text.Trim().Length == 8)
            {
                j += 1;
                errorProvider7.SetError(Instrutor_Cod_Postal, null);
            }
            else
            {

                errorProvider7.SetError(Instrutor_Cod_Postal, "Escreva o Codigo Postal");
            }
            //Error Provider Email
            if (Instrutor_Email.Text.Contains("@") && Instrutor_Email.Text.Contains("."))
            {
                errorProvider8.SetError(Instrutor_Email, null);
                j += 1;
            }
            else
            {
                errorProvider8.SetError(Instrutor_Email, "Escreva o seu Email");
                
               
            }
            //Error Provider Senha
            if (Instrutor_Senha.Text.Trim().Length == 0)
            {

                errorProvider9.SetError(Instrutor_Senha, "Escreva uma senha");
            }
            else
            {
                j += 1;
                errorProvider9.SetError(Instrutor_Senha, null);
            }
            //Error Provider Data de Nascimento

            if (dn == true)
            {

                j += 1;
                errorProvider10.SetError(dateTimePicker1, null);

            }
            else
            {

                errorProvider10.SetError(dateTimePicker1, "Introduza a Data de Nascimento");
            }

            //Error Provider NIB
            if (maskedTextBox1.Text.Trim().Length == 21)
            {
                if (BLL.Funcionarios.queryValidaçaoNIBed(Convert.ToInt32(label5.Text),maskedTextBox1.Text).Rows.Count > 0)

                {
                    erro = true;
                    errorProvider4.SetError(maskedTextBox1, "Este NIB já se encontra na base de dados");
                }
                else
                {
                    j += 1;
                    errorProvider11.SetError(maskedTextBox1, null);
                }
               
            }
            else
            {
                errorProvider11.SetError(maskedTextBox1, "NIB incorreto");
            }
            //Error Provider Cargo
            if (comboBox1.Text.Trim().Length == 0)
            {

                errorProvider12.SetError(comboBox1, "Escolha um Cargo");
            }
            else
            {

                j += 1;
                errorProvider12.SetError(comboBox1, null);
            }




            if (j == 12)
            {

                if (erro == false)
                {

                    try
                    {

                        int x = BLL.Funcionarios.updateFuncionario(label5.Text, Instrutor_Nome.Text, Instrutor_CC.Text,maskedTextBox1.Text, Convert.ToInt32(Instrutor_NIF.Text), Convert.ToInt32(Instrutor_Telemovel.Text), Instrutor_Email.Text, Instrutor_Morada.Text, Instrutor_Cod_Postal.Text, datanasc, Instrutor_Certificacao.Text,comboBox1.Text, Instrutor_Senha.Text, Ativo);
                        MessageBox.Show("Funcionário editado com sucesso", "Editar Funcionário", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao inserir na Base de dados: " + ex);
                    }

                    Instrutor_Nome.Clear();
                    Instrutor_CC.Clear();
                    maskedTextBox1.Clear();
                    Instrutor_NIF.Clear();
                    Instrutor_Telemovel.Clear();
                    Instrutor_Email.Clear();
                    Instrutor_Morada.Clear();
                    Instrutor_Cod_Postal.Clear();
                    comboBox1.Text = "";
                    Instrutor_Certificacao.Text = "";
                    Instrutor_Senha.Clear();
                    dataGridView1.DataSource = BLL.Funcionarios.Load();
                
                }

            }


        }
        DateTime datanasc;
        private void Instrutor_data_nasc_onValueChanged(object sender, EventArgs e)
        {
            datanasc = dateTimePicker1.Value;
            dn = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label5.Text = dataGridView1.Rows[e.RowIndex].Cells["Id_Funcionario"].Value.ToString();
            Instrutor_Nome.Text = dataGridView1.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
            Instrutor_CC.Text = dataGridView1.Rows[e.RowIndex].Cells["CC"].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["NIB"].Value.ToString();
            Instrutor_NIF.Text = dataGridView1.Rows[e.RowIndex].Cells["NIF"].Value.ToString();
            Instrutor_Telemovel.Text = dataGridView1.Rows[e.RowIndex].Cells["Telemovel"].Value.ToString();
            Instrutor_Email.Text = dataGridView1.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            Instrutor_Morada.Text = dataGridView1.Rows[e.RowIndex].Cells["Morada"].Value.ToString();
            Instrutor_Cod_Postal.Text = dataGridView1.Rows[e.RowIndex].Cells["Cod_Postal"].Value.ToString();
            dateTimePicker1.Value = (DateTime)dataGridView1.Rows[e.RowIndex].Cells["Data_de_Nascimento"].Value;
            Instrutor_Certificacao.Text = dataGridView1.Rows[e.RowIndex].Cells["Certificacao"].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["Cargo"].Value.ToString();
            Instrutor_Senha.Text = dataGridView1.Rows[e.RowIndex].Cells["Senha"].Value.ToString();
            datanasc = dateTimePicker1.Value;
            if (dataGridView1.Rows[e.RowIndex].Cells["Ativo"].Value.ToString() == "Sim")
            {
                Instrutor_Ativo.Checked = true;

            }
            else
            {
                Instrutor_Ativo.Checked = false;
            }
            if (Instrutor_Ativo.Checked)
            {
                Ativo = "Sim";
            }
            else
            {
                Ativo = "Não";
            }
        }
        string Ativo;
        private void Instrutor_Ativo_OnChange(object sender, EventArgs e)
        {
            if (Instrutor_Ativo.Checked)
            {
                Ativo = "Sim";
            }
            else
            {
                Ativo = "Não";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Funcionarios_Editar_MouseMove(object sender, MouseEventArgs e)
        {
            //Panel_Clientes.Visible = false;
            //Panel_Funcionarios.Visible = false;
            //Panel_Veiculos.Visible = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            datanasc = dateTimePicker1.Value;
            dn = true;
        }

        private void Instrutor_Nome_TextChanged(object sender, EventArgs e)
        {
            //Error Provider Nome
            if (Instrutor_Nome.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(Instrutor_Nome, "Escreva um nome");
            }
            else
            {
                int s = 0;
                for (int i = 0; i < Instrutor_Nome.Text.Trim().Length; i++)
                {
                    if (Char.IsDigit(Instrutor_Nome.Text, i))

                    {
                        s += 1;
                    }

                }
                if (s > 0)
                {
                    errorProvider1.SetError(Instrutor_Nome, "Não é permitido números");
                }
                else
                {

                    errorProvider1.SetError(Instrutor_Nome, null);
                }

            }
        }

        private void Instrutor_CC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //Error Provider CC
            int n = 0;
            for (int i = 0; i < Instrutor_CC.Text.Trim().Length; i++)
            {
                if (Char.IsDigit(Instrutor_CC.Text, i))

                {
                    n += 1;

                }

            }
            if (n == 10)
            {
                if (Char.IsLetter(Instrutor_CC.Text, 9))
                {

                    if (Char.IsLetter(Instrutor_CC.Text, 10))
                    {
                        if (BLL.Funcionarios.queryValidaçaoCC(Instrutor_CC.Text).Rows.Count > 0)

                        {
                           
                            errorProvider2.SetError(Instrutor_CC, "Este CC já se encontra na base de dados");
                        }
                        else
                        {

                            errorProvider2.SetError(Instrutor_CC, null);
                        }
                    }
                    else
                    {
                        errorProvider2.SetError(Instrutor_CC, "O CC está incorreto");
                    }
                }
                else
                {
                    errorProvider2.SetError(Instrutor_CC, "O CC está incorreto");
                }
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //Error Provider NIB
            if (maskedTextBox1.Text.Trim().Length == 21)
            {
                if (BLL.Funcionarios.queryValidaçaoNIB(maskedTextBox1.Text).Rows.Count > 0)

                {

                    errorProvider4.SetError(maskedTextBox1, "Este NIB já se encontra na base de dados");
                }
                else
                {

                    errorProvider11.SetError(maskedTextBox1, null);
                }

            }
        }

        private void Instrutor_NIF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //Error Provider NIF

            if (Instrutor_NIF.Text.Trim().Length == 9)
            {
                if (BLL.Funcionarios.queryValidaçaoNIF(Convert.ToInt32(Instrutor_NIF.Text)).Rows.Count > 0)
                {

                    errorProvider3.SetError(Instrutor_NIF, "Este NIF já se encontra na base de dados");
                }
                else
                {

                    errorProvider3.SetError(Instrutor_NIF, null);
                }
            }
            else
            {

                errorProvider3.SetError(Instrutor_NIF, "O NIF está incorreto");
            }
        }

        private void Instrutor_Telemovel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //Error Provider Telemovel
            if (Instrutor_Telemovel.Text.Trim().Length == 9)
            {
                if (BLL.Funcionarios.queryValidaçaoTelemovel(Convert.ToInt32(Instrutor_Telemovel.Text)).Rows.Count > 0)

                {
                  
                    errorProvider4.SetError(Instrutor_Telemovel, "Este telemovel já se encontra na base de dados");
                }
                else
                {

                    errorProvider4.SetError(Instrutor_Telemovel, null);
                }
            }
            else
            {

                errorProvider4.SetError(Instrutor_Telemovel, "O numero está incorreto");
            }
        }

        private void Instrutor_Senha_TextChanged(object sender, EventArgs e)
        {
            //Error Provider Senha
            if (Instrutor_Senha.Text.Trim().Length == 0)
            {

                errorProvider9.SetError(Instrutor_Senha, "Escreva uma senha");
            }
            else
            {

                errorProvider9.SetError(Instrutor_Senha, null);
            }
        }

        private void Instrutor_Certificacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Error Provider Certificaçao
            if (Instrutor_Certificacao.Text.Trim().Length == 0)
            {

                errorProvider5.SetError(Instrutor_Certificacao, "Escolha um Certificação");
            }
            else
            {


                errorProvider5.SetError(Instrutor_Certificacao, null);
            }
        }

        private void Instrutor_Morada_TextChanged(object sender, EventArgs e)
        {
            //Error Provider Morada
            if (Instrutor_Morada.Text.Trim().Length == 0)
            {

                errorProvider6.SetError(Instrutor_Morada, "Escreva uma morada");
            }
            else
            {

                errorProvider6.SetError(Instrutor_Morada, null);
            }
        }

        private void Instrutor_Cod_Postal_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //Error Provider Codigo Postal
            if (Instrutor_Cod_Postal.Text.Trim().Length == 8)
            {

                errorProvider7.SetError(Instrutor_Cod_Postal, null);
            }
            else
            {

                errorProvider7.SetError(Instrutor_Cod_Postal, "Escreva o Codigo Postal");
            }
        }

        private void Instrutor_Email_TextChanged(object sender, EventArgs e)
        {
            //Error Provider Email
            if (Instrutor_Email.Text.Contains("@") && Instrutor_Email.Text.Contains("."))
            {

                errorProvider8.SetError(Instrutor_Email, null);
            }
            else
            {
                errorProvider8.SetError(Instrutor_Email, "Escreva o seu Email");
               
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Error Provider Cargo
            if (comboBox1.Text.Trim().Length == 0)
            {

                errorProvider12.SetError(comboBox1, "Escolha um Cargo");
            }
            else
            {


                errorProvider12.SetError(comboBox1, null);
            }
        }
    }
}
