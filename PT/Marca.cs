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
    public partial class Marca : Form
    {
        public Marca()
        {
            InitializeComponent();
        }

        private void b_apagar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void label2_Click(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable fr = BLL.Marca_Modelo.marca1(bunifuMaterialTextbox2.Text);
            if (fr.Rows.Count == 0)
            {
                int x = BLL.Marca_Modelo.insertmarca(bunifuMaterialTextbox2.Text);
                errorProvider1.SetError(bunifuMaterialTextbox2, null);
                bunifuMaterialTextbox2.Text = "";
            }
            else
            {
                errorProvider1.SetError(bunifuMaterialTextbox2, "Esta marca já se encontra registada.");
            }
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

           
               
                errorProvider1.SetError(bunifuMaterialTextbox2, null);

            
            
        }
    }
}
