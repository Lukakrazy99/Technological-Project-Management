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
using System.Runtime.InteropServices;
namespace PT
{
    public partial class Mudar_Pass : Form
    {
        public Mudar_Pass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = BLL.Login.Entrar1(Globais.NumeroFuncionario, bunifuMaterialTextbox1.Text);

            if (dt.Rows.Count == 1)
            {
                errorProvider1.SetError(bunifuMaterialTextbox1, null);

                if (bunifuMaterialTextbox2.Text.Trim().Length != 0)
                {

                    bunifuMaterialTextbox3.Enabled = true;

                    if (bunifuMaterialTextbox2.Text == bunifuMaterialTextbox3.Text)
                    {

                        errorProvider2.SetError(bunifuMaterialTextbox2, null);

                        int x = BLL.Login.updateLogin(Globais.NumeroFuncionario, bunifuMaterialTextbox3.Text);
                        MessageBox.Show("Senha trocada");
                        this.Close();
                    }
                    else
                    {

                        errorProvider2.SetError(bunifuMaterialTextbox2, "Senha nova não coincidem");

                        bunifuMaterialTextbox3.Enabled = false; 

                    }
                }
            }
            else
            {
                
                    errorProvider1.SetError(bunifuMaterialTextbox1, "Senha incorreta");
               
            }
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {
            bunifuMaterialTextbox3.Enabled = true;
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

        private void Mudar_Pass_Load(object sender, EventArgs e)
        {

        }
    }
}
