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
    public partial class Funcionarios_Visualizar : Form
    {
        public Funcionarios_Visualizar()
        {
            InitializeComponent();
        }

        private void Visualizar_Funcionarios_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Funcionarios.Load();
            this.SendToBack();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Instrutor_Procurar_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Funcionarios.queryFuncionario_Like(Instrutor_Procurar.Text);
        }

        private void Funcionarios_Visualizar_MouseMove(object sender, MouseEventArgs e)
        {
            //Panel_Clientes.Visible = false;
            //Panel_Funcionarios.Visible = false;
            //Panel_Veiculos.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
