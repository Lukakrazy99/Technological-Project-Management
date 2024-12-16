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
    public partial class Veiculo_Visualizar : Form
    {
        public Veiculo_Visualizar()
        {
            InitializeComponent();
        }

        private void Veiculo_Visualizar_Load(object sender, EventArgs e)
        {
           dataGridView1.DataSource = BLL.Veiculos.Load();
            this.SendToBack();
        }

        private void Instrutor_Procurar_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Veiculos.queryVeiculo_Like(Instrutor_Procurar.Text);
        }
    }
}
