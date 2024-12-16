using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using System.Runtime.InteropServices;
namespace PT
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

      

        private void BunifuMaterialTextbox1_Enter(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text == "NIF")
            {
                bunifuMaterialTextbox1.Text = "";

                bunifuMaterialTextbox1.ForeColor = Color.Black;

            }
        }

        private void bunifuMaterialTextbox1_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text == "")
            {
                bunifuMaterialTextbox1.Text = "NIF";

                bunifuMaterialTextbox1.ForeColor = Color.Silver;

            }
        }

        private void bunifuMaterialTextbox2_Enter(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox2.Text == "password")
            {
                bunifuMaterialTextbox2.Text = "";

                bunifuMaterialTextbox2.ForeColor = Color.Black;
            }
        }

        private void bunifuMaterialTextbox2_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox2.Text == "")
            {
                bunifuMaterialTextbox2.Text = "password";

                bunifuMaterialTextbox2.ForeColor = Color.Silver;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = BLL.Login.Entrar(bunifuMaterialTextbox1.Text, bunifuMaterialTextbox2.Text);
            
            if (dt.Rows.Count == 1)
            {
                
                Globais.perfil = dt.Rows[0]["Cargo"].ToString();

                Globais.Nomefuncionario = dt.Rows[0]["Nome"].ToString();

                Globais.NumeroFuncionario = (int)dt.Rows[0]["Id_Funcionario"];
                
                this.Hide();

                Menu f3 = new Menu();

                f3.Show();

            }
            else
            {
                MessageBox.Show("NIF ou Senha incorreto");
            }
           

        }

        private void bunifuImageButton1_MouseDown(object sender, MouseEventArgs e)
        {
            bunifuMaterialTextbox2.isPassword = false;
        }

        private void bunifuImageButton1_MouseUp(object sender, MouseEventArgs e)
        {
            bunifuMaterialTextbox2.isPassword = true;
        }

        private void b_apagar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
