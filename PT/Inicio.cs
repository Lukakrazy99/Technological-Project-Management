using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
namespace PT
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            label2.Text = BLL.Inicio.contarclientes().ToString();
            label5.Text = BLL.Inicio.contarfuncionarios().ToString();
            label7.Text = BLL.Inicio.contarVeiculos().ToString();
            label9.Text = BLL.Inicio.contarVeiculosv2().ToString();
            label11.Text = BLL.Inicio.contarVender().ToString();
            label13.Text = BLL.Inicio.contarAlugar().ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("HH:mm");
            lblFecha.Text = DateTime.Now.ToString(@"dddd, d MMMM \de yyyy", new CultureInfo("PT-pt"));

           

        }
    }
}
