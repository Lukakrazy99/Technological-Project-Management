using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace PT
{
    public partial class Clientes_Registar : PT.Properties.Form1
    {
        public Clientes_Registar()
        {
            InitializeComponent();
        }

        bool dn = false;

        
        private void Clientes_Registar_Load(object sender, EventArgs e)
        {
            int year = dateTimePicker1.Value.Year;
            int month = dateTimePicker1.Value.Month;
            int day = dateTimePicker1.Value.Day;
          
            dateTimePicker1.MinDate = new DateTime(year-100, month, day) ;
            dateTimePicker1.MaxDate =  new DateTime(year-18, month, day);

            dataGridView1.DataSource = BLL.Clientes.Load();
            this.SendToBack();

        }


        private void Adicionar_Cliente_Click(object sender, EventArgs e)
        {
            bool erro = false;
            int j = 0;
            {

                //Error Provider Nome
                if (Cliente_Nome.Text.Trim().Length == 0)
                {
                    errorProvider1.SetError(Cliente_Nome, "Escreva um nome");
                }
                else
                {
                    int n = 0;
                    for (int i = 0; i < Cliente_Nome.Text.Trim().Length; i++)
                    {
                        if (Char.IsDigit(Cliente_Nome.Text, i))

                        {
                            n += 1;
                        }
                      

                    }
                    if (n > 0)
                    {



                        errorProvider1.SetError(Cliente_Nome, "Não é permitido números");
                    }


                    else
                    {
                        j += 1;
                        errorProvider1.SetError(Cliente_Nome, null);
                    }
                }

                        //Error Provider CC
                        int cc = 0;
                        for (int ccn = 0; ccn < Cliente_CC.Text.Trim().Length; ccn++)
                        {
                            if (Char.IsDigit(Cliente_CC.Text, ccn))

                            {
                                cc += 1;

                            }

                        }
                        if (cc == 10)
                        {
                            if (Char.IsLetter(Cliente_CC.Text, 9))
                            {

                                if (Char.IsLetter(Cliente_CC.Text, 10))
                                {
                                    if (BLL.Clientes.queryValidaçaoCC(Cliente_CC.Text).Rows.Count > 0)

                                    {
                                        erro = true;
                                        errorProvider2.SetError(Cliente_CC, "Este CC já se encontra na base de dados");
                                    }
                                    else
                                    {
                                        j += 1;
                                        errorProvider2.SetError(Cliente_CC, null);
                                    }
                                }
                                else
                                {
                                    errorProvider2.SetError(Cliente_CC, "O CC está incorreto");
                                }
                            }
                            else
                            {
                                errorProvider2.SetError(Cliente_CC, "O CC está incorreto");
                            }
                        }

                        else

                        {
                            errorProvider2.SetError(Cliente_CC, "O CC está incorreto");
                        }

                //Error Provider NIF

                if (Cliente_NIF.Text.Trim().Length == 9)
                {
                    if (BLL.Clientes.queryValidaçaoNIF(Convert.ToInt32(Cliente_NIF.Text)).Rows.Count > 0)
                    {
                        erro = true;
                        errorProvider3.SetError(Cliente_NIF, "Este NIF já se encontra na base de dados");
                    }
                    else
                    {
                        int nif = 0;
                        for (int nifn = 0; nifn < Cliente_NIF.Text.Trim().Length; nifn++)
                        {
                            if (Char.IsLetter(Cliente_NIF.Text, nifn))

                            {
                                nif += 1;
                            }


                        }
                        if (nif > 0)
                        {



                            errorProvider3.SetError(Cliente_NIF, "Não é permitido letras");
                        }
                        else
                        {
                            j += 1;
                            errorProvider3.SetError(Cliente_NIF, null);
                        }
                    }
                }


                else
                {

                    errorProvider3.SetError(Cliente_NIF, "O NIF está incorreto");
                }
                        //Error Provider Telemovel
                        if (Cliente_Telemovel.Text.Trim().Length == 9)
                        {
                            if (BLL.Clientes.queryValidaçaoTelemovel(Convert.ToInt32(Cliente_Telemovel.Text)).Rows.Count > 0)

                            {
                                erro = true;
                                errorProvider4.SetError(Cliente_Telemovel, "Este telemovel já se encontra na base de dados");
                            }
                            else
                            {
                                int tel = 0;
                                for (int teln = 0; teln < Cliente_NIF.Text.Trim().Length; teln++)
                                {
                                    if (Char.IsLetter(Cliente_NIF.Text, teln))

                                    {
                                        tel += 1;
                                    }
                                  

                                }
                        if (tel > 0)
                        {



                            errorProvider4.SetError(Cliente_Telemovel, "Não é permitido letras");
                        }
                        else
                        {
                               j += 1;
                               errorProvider4.SetError(Cliente_Telemovel, null);
                        }

                            }
                        }
                        else
                        {

                            errorProvider4.SetError(Cliente_Telemovel, "O numero está incorreto");
                        }
                        //Error Provider Morada
                        if (Cliente_Morada.Text.Trim().Length == 0)
                        {

                            errorProvider5.SetError(Cliente_Morada, "Escreva uma morada");
                        }
                        else
                        {
                            j += 1;
                            errorProvider5.SetError(Cliente_Morada, null);
                        }
                        //Error Provider Codigo Postal
                        if (Cliente_Cod_Postal.Text.Trim().Length == 8)
                        {
                            int tel = 0;
                            for (int teln = 0; teln < Cliente_Cod_Postal.Text.Trim().Length; teln++)
                            {
                                if (Char.IsLetter(Cliente_Cod_Postal.Text, teln))

                                {
                                    tel += 1;
                                }
                               

                            }
                    if (tel > 0)
                    {



                        errorProvider6.SetError(Cliente_Cod_Postal, "Não é permitido letras");
                    }
                    else
                    {
                        j += 1;
                        errorProvider6.SetError(Cliente_Cod_Postal, null);
                    }
                }
                        else
                        {

                            errorProvider6.SetError(Cliente_Cod_Postal, "Escreva o Codigo Postal");
                        }
                //Error Provider Email
                if (Cliente_Email.Text.Contains("@") && Cliente_Email.Text.Contains("."))
                {
                    errorProvider7.SetError(Cliente_Email, null);
                    j += 1;
                }
                else
                {
                  
                    errorProvider7.SetError(Cliente_Email, "Email incorreto!");

                }

                //Error Provider Data de Nascimento

                if (dn == true)
                        {

                            j += 1;
                            errorProvider8.SetError(dateTimePicker1, null);

                        }
                        else
                        {

                            errorProvider8.SetError(dateTimePicker1, "Introduza a Data de Nascimento");
                        }


                        if (j == 8)
                        {
                            if (erro == false)
                            {

                                try
                                {
                                    int x = BLL.Clientes.insertClientes(Cliente_Nome.Text, Cliente_CC.Text, Convert.ToInt32(Cliente_NIF.Text), Cliente_Morada.Text, Convert.ToInt32(Cliente_Telemovel.Text), Cliente_Email.Text, Cliente_Cod_Postal.Text, datanasc, "Sim");
                                    MessageBox.Show("Cliente inserido com sucesso", "Inserir Cliente", MessageBoxButtons.OK);
                        }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Erro ao inserir na Base de dados: " + ex);
                                }
                                Cliente_Nome.Clear();
                                Cliente_CC.Clear();
                                Cliente_NIF.Clear();
                                Cliente_Telemovel.Clear();
                                Cliente_Email.Clear();
                                Cliente_Morada.Clear();
                                Cliente_Cod_Postal.Clear();
                                dataGridView1.DataSource = BLL.Clientes.Load();
                               
                            }

                        }

                    }
                }
            
        
        DateTime datanasc;
       

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            datanasc = dateTimePicker1.Value;
            if ((DateTime.Now.Year - datanasc.Year) >= 18)
            {
                dn = true;
                errorProvider8.SetError(dateTimePicker1, null);
            }
            else
            {
                errorProvider8.SetError(dateTimePicker1, "Introduza uma data de nascimento superior a 17 anos");
            }
        }

        private void Cliente_Nome_TextChanged(object sender, EventArgs e)
        {
            //Error Provider Nome
            if (Cliente_Nome.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(Cliente_Nome, "Escreva um nome");
            }
            else
            {
                int n = 0;
                for (int i = 0; i < Cliente_Nome.Text.Trim().Length; i++)
                {
                    if (Char.IsDigit(Cliente_Nome.Text, i))

                    {
                        n += 1;
                    }


                }
                if (n > 0)
                {



                    errorProvider1.SetError(Cliente_Nome, "Não é permitido números");
                }


                else
                {
                  
                    errorProvider1.SetError(Cliente_Nome, null);
                }
            }
        }

        private void Cliente_CC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //Error Provider CC
            int cc = 0;
            for (int ccn = 0; ccn < Cliente_CC.Text.Trim().Length; ccn++)
            {
                if (Char.IsDigit(Cliente_CC.Text, ccn))

                {
                    cc += 1;

                }

            }
            if (cc == 10)
            {
                if (Char.IsLetter(Cliente_CC.Text, 9))
                {

                    if (Char.IsLetter(Cliente_CC.Text, 10))
                    {
                        if (BLL.Clientes.queryValidaçaoCC(Cliente_CC.Text).Rows.Count > 0)

                        {
                           
                            errorProvider2.SetError(Cliente_CC, "Este CC já se encontra na base de dados");
                        }
                        else
                        {
                          
                            errorProvider2.SetError(Cliente_CC, null);
                        }
                    }
                    else
                    {
                        errorProvider2.SetError(Cliente_CC, "O CC está incorreto");
                    }
                }
                else
                {
                    errorProvider2.SetError(Cliente_CC, "O CC está incorreto");
                }
            }

            else

            {
                errorProvider2.SetError(Cliente_CC, "O CC está incorreto");
            }
        }

        private void Cliente_NIF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //Error Provider NIF

            if (Cliente_NIF.Text.Trim().Length == 9)
            {
                if (BLL.Clientes.queryValidaçaoNIF(Convert.ToInt32(Cliente_NIF.Text)).Rows.Count > 0)
                {
                   
                    errorProvider3.SetError(Cliente_NIF, "Este NIF já se encontra na base de dados");
                }
                else
                {
                    int nif = 0;
                    for (int nifn = 0; nifn < Cliente_NIF.Text.Trim().Length; nifn++)
                    {
                        if (Char.IsLetter(Cliente_NIF.Text, nifn))

                        {
                            nif += 1;
                        }


                    }
                    if (nif > 0)
                    {



                        errorProvider3.SetError(Cliente_NIF, "Não é permitido letras");
                    }
                    else
                    {
                   
                        errorProvider3.SetError(Cliente_NIF, null);
                    }
                }
            }
        }

        private void Cliente_Telemovel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //Error Provider Telemovel
            if (Cliente_Telemovel.Text.Trim().Length == 9)
            {
                if (BLL.Clientes.queryValidaçaoTelemovel(Convert.ToInt32(Cliente_Telemovel.Text)).Rows.Count > 0)

                {
                   
                    errorProvider4.SetError(Cliente_Telemovel, "Este telemovel já se encontra na base de dados");
                }
                else
                {
                    int tel = 0;
                    for (int teln = 0; teln < Cliente_NIF.Text.Trim().Length; teln++)
                    {
                        if (Char.IsLetter(Cliente_NIF.Text, teln))

                        {
                            tel += 1;
                        }


                    }
                    if (tel > 0)
                    {



                        errorProvider4.SetError(Cliente_Telemovel, "Não é permitido letras");
                    }
                    else
                    {
                       
                        errorProvider4.SetError(Cliente_Telemovel, null);
                    }

                }
            }
            else
            {

                errorProvider4.SetError(Cliente_Telemovel, "O numero está incorreto");
            }
        }

        private void Cliente_Morada_TextChanged(object sender, EventArgs e)
        {
            //Error Provider Morada
            if (Cliente_Morada.Text.Trim().Length == 0)
            {

                errorProvider5.SetError(Cliente_Morada, "Escreva uma morada");
            }
            else
            {
                
                errorProvider5.SetError(Cliente_Morada, null);
            }
          
        }

        private void Cliente_Cod_Postal_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //Error Provider Codigo Postal
            if (Cliente_Cod_Postal.Text.Trim().Length == 8)
            {

                errorProvider6.SetError(Cliente_Cod_Postal, null);
            }
            else
            {

                errorProvider6.SetError(Cliente_Cod_Postal, "Escreva o Codigo Postal");
            }
        }

        private void Cliente_Email_TextChanged(object sender, EventArgs e)
        {
            //Error Provider Email
            if (Cliente_Email.Text.Contains("@") && Cliente_Email.Text.Contains("."))
            {
                errorProvider7.SetError(Cliente_Email, null);
            }
            else
            {
                errorProvider7.SetError(Cliente_Email, "Email incorreto!");
                
            }
        }
    }
}
