using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using BusinessLogicLayer;
namespace PT
{
    public partial class Adicionar_carro : Form
    {
      
        
        public Adicionar_carro()

        {
            InitializeComponent();
           
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void b_apagar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable fr = BLL.Marca_Modelo.modelo1(comboBox1.Text, bunifuMaterialTextbox2.Text);
            if (fr.Rows.Count == 0)
            {
                int x = BLL.Marca_Modelo.insertmodelo(comboBox1.Text, bunifuMaterialTextbox2.Text);
                errorProvider1.SetError(bunifuMaterialTextbox2, null);
                bunifuMaterialTextbox2.Text = "";
            }
            else
            {
                errorProvider1.SetError(bunifuMaterialTextbox2, "Este modelo já se encontra registado.");
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        
           
         
        }

        private void Adicionar_carro_Load(object sender, EventArgs e)
        {
          
            DataTable fg = BLL.Marca_Modelo.marca();

            comboBox1.DataSource = fg;
            comboBox1.DisplayMember = "Marca";
            comboBox1.Text = Globais.marca;
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
           
        }
    }
}
