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
    public partial class Clientes_Visualizar : PT.Properties.Form1
    {
        public Clientes_Visualizar()
        {
            InitializeComponent();
        }

        private void Instrutor_Procurar_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Clientes.queryClientes_Like(Cliente_Procurar.Text);
        }

        private void Clientes_Visualizar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Clientes.Load();
            this.SendToBack();
        }

        private void Clientes_Visualizar_MouseMove(object sender, MouseEventArgs e)
        {
            //Panel_Clientes.Visible = false;
            //Panel_Funcionarios.Visible = false;
            //Panel_Veiculos.Visible = false;
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
