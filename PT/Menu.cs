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

namespace PT
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            this.WindowState = FormWindowState.Normal;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            label1.Text = Globais.Nomefuncionario;
            label2.Text = Globais.perfil;
            AbrirFormnoPanel(new Inicio());
            if(Globais.perfil == "Funcionário")
            {
                button2.Enabled = false;
            }

         
        }

       

        private void Panel_Funcionarios_MouseLeave(object sender, EventArgs e)
        {
            Panel_Clientes.Visible = false;
            Panel_Funcionarios.Visible = false;
            Panel_Veiculos.Visible = false;
        }

        private void Panel_Clientes_MouseLeave(object sender, EventArgs e)
        {
            Panel_Clientes.Visible = false;
            Panel_Funcionarios.Visible = false;
            Panel_Veiculos.Visible = false;
        }

        private void Panel_Veiculos_MouseLeave(object sender, EventArgs e)
        {
            Panel_Clientes.Visible = false;
            Panel_Funcionarios.Visible = false;
            Panel_Veiculos.Visible = false;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
           
            Panel_Clientes.Visible = false;
            Panel_Funcionarios.Visible = true;
            Panel_Veiculos.Visible = false;
            Panel_Alugar.Visible = false;
            Panel_Vender.Visible = false;
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
          
            Panel_Clientes.Visible = true;
            Panel_Funcionarios.Visible = false;
            Panel_Veiculos.Visible = false;
            Panel_Alugar.Visible = false;
            Panel_Vender.Visible = false;
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
           
            Panel_Clientes.Visible = false;
            Panel_Funcionarios.Visible = false;
            Panel_Veiculos.Visible = true;
            Panel_Alugar.Visible = false;
            Panel_Vender.Visible = false;
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            //Panel_Clientes.Visible = false;
            //Panel_Funcionarios.Visible = false;
            //Panel_Veiculos.Visible = false;
            //Panel_Alugar.Visible = false;
            //Panel_Vender.Visible = false;
        }

        private void panel_form_MouseMove(object sender, MouseEventArgs e)
        {
            Panel_Clientes.Visible = false;
            Panel_Funcionarios.Visible = false;
            Panel_Veiculos.Visible = false;
        }
        public void AbrirFormnoPanel(object Formf)
        {
            if (this.panel_form.Controls.Count > 0)
                this.panel_form.Controls.RemoveAt(5);
            Form ff = Formf as Form;
            ff.TopLevel = false;
            ff.Dock = DockStyle.Fill;
            this.panel_form.Controls.Add(ff);
            this.panel_form.Tag = ff;
            ff.Show();
        }
        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
            AbrirFormnoPanel(new Clientes_Registar());
            Panel_Clientes.Visible = false;
            Panel_Funcionarios.Visible = false;
            Panel_Veiculos.Visible = false;
        }

        private void bunifuFlatButton17_Click(object sender, EventArgs e)
        {
            AbrirFormnoPanel(new Funcionarios_Registar());
            Panel_Clientes.Visible = false;
            Panel_Funcionarios.Visible = false;
            Panel_Veiculos.Visible = false;
        }

        private void bunifuFlatButton16_Click(object sender, EventArgs e)
        {
            AbrirFormnoPanel(new Funcionarios_Editar());
            Panel_Clientes.Visible = false;
            Panel_Funcionarios.Visible = false;
            Panel_Veiculos.Visible = false;

        }

        private void bunifuFlatButton15_Click(object sender, EventArgs e)
        {
            AbrirFormnoPanel(new Funcionarios_Visualizar());
            Panel_Clientes.Visible = false;
            Panel_Funcionarios.Visible = false;
            Panel_Veiculos.Visible = false;
        }

        private void Panel_Funcionarios_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            Panel_Clientes.Visible = false;
            Panel_Funcionarios.Visible = false;
            Panel_Veiculos.Visible = false;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Panel_Clientes.Visible = false;
            Panel_Funcionarios.Visible = false;
            Panel_Veiculos.Visible = false;
            Panel_Alugar.Visible = false;
            Panel_Vender.Visible = false;
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            Panel_Clientes.Visible = false;
            Panel_Funcionarios.Visible = false;
            Panel_Veiculos.Visible = false;
            Panel_Alugar.Visible = false;
            Panel_Vender.Visible = true;
            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top;
        }

        private void bunifuFlatButton13_Click_2(object sender, EventArgs e)
        {
            AbrirFormnoPanel(new Clientes_Editar());
            Panel_Clientes.Visible = false;
            Panel_Funcionarios.Visible = false;
            Panel_Veiculos.Visible = false;
        }

        private void bunifuFlatButton12_Click_2(object sender, EventArgs e)
        {
            AbrirFormnoPanel(new Clientes_Visualizar());
            Panel_Clientes.Visible = false;
            Panel_Funcionarios.Visible = false;
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            AbrirFormnoPanel(new Veiculo_Registar());
            Panel_Clientes.Visible = false;
            Panel_Funcionarios.Visible = false;
            Panel_Veiculos.Visible = false;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            AbrirFormnoPanel(new Veiculo_Editar());
            Panel_Clientes.Visible = false;
            Panel_Funcionarios.Visible = false;
            Panel_Veiculos.Visible = false;
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            AbrirFormnoPanel(new Veiculo_Visualizar());
            Panel_Clientes.Visible = false;
            Panel_Funcionarios.Visible = false;
            Panel_Veiculos.Visible = false;
            
        }
        
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            b_restaurar.Visible = true;
            b_maximizar.Visible = false;

        }


        private void b_apagar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void b_restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            b_restaurar.Visible = false;
            b_maximizar.Visible = true;
        }

        private void b_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void b_minimizar_MouseMove(object sender, MouseEventArgs e)
        {
            b_minimizar.BackColor = SystemColors.ActiveBorder; 

        }

        private void b_minimizar_MouseLeave(object sender, EventArgs e)
        {
            b_minimizar.BackColor = Color.Transparent;
        }

        private void b_restaurar_MouseMove(object sender, MouseEventArgs e)
        {
            b_restaurar.BackColor = SystemColors.ActiveBorder;
        }

        private void b_restaurar_MouseLeave(object sender, EventArgs e)
        {
            b_restaurar.BackColor = Color.Transparent;
        }

        private void b_apagar_MouseMove(object sender, MouseEventArgs e)
        {
            b_apagar.BackColor = SystemColors.ActiveBorder;
        }

        private void b_apagar_MouseLeave(object sender, EventArgs e)
        {
            b_apagar.BackColor = Color.Transparent;
        }

        private void b_maximizar_MouseLeave(object sender, EventArgs e)
        {
            b_maximizar.BackColor = Color.Transparent;
        }

        private void b_maximizar_MouseMove(object sender, MouseEventArgs e)
        {
            b_maximizar.BackColor = SystemColors.ActiveBorder;
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }

        private void button6_MouseMove(object sender, MouseEventArgs e)
        {
            Panel_Clientes.Visible = false;
            Panel_Funcionarios.Visible = false;
            Panel_Veiculos.Visible = false;
            Panel_Alugar.Visible = true;
            Panel_Vender.Visible = false;
            SidePanel.Height = button6.Height;
            SidePanel.Top = button6.Top;
        }

        private void Panel_Vender_MouseLeave(object sender, EventArgs e)
        {
            Panel_Clientes.Visible = false;
            Panel_Funcionarios.Visible = false;
            Panel_Veiculos.Visible = false;
            Panel_Alugar.Visible = false;
            Panel_Vender.Visible = false;
        }

        private void Panel_Alugar_MouseLeave(object sender, EventArgs e)
        {
            Panel_Clientes.Visible = false;
            Panel_Funcionarios.Visible = false;
            Panel_Veiculos.Visible = false;
            Panel_Alugar.Visible = false;
            Panel_Vender.Visible = false;
        }

       

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button7_MouseMove_1(object sender, MouseEventArgs e)
        {
            Panel_Clientes.Visible = false;
            Panel_Funcionarios.Visible = false;
            Panel_Veiculos.Visible = false;
            Panel_Alugar.Visible = false;
            Panel_Vender.Visible = false;
        }

        private void bunifuFlatButton6_Click_1(object sender, EventArgs e)
        {
            AbrirFormnoPanel(new Vendas_Registar());
            Panel_Vender.Visible = false;
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            AbrirFormnoPanel(new Vendas_Anular());
            Panel_Vender.Visible = false;
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            AbrirFormnoPanel(new Alugar_Registar());
            Panel_Alugar.Visible = false;
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            AbrirFormnoPanel(new Alugar_Anular());
            Panel_Alugar.Visible = false;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void panel_definiçoes_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormnoPanel(new Inicio());
        }

       

        private void bunifuFlatButton7_Click_1(object sender, EventArgs e)
        {
            AbrirFormnoPanel(new Vendas_Procurar());
        }

        private void bunifuFlatButton4_Click_1(object sender, EventArgs e)
        {
            AbrirFormnoPanel(new Alugar_Procurar());
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            Panel_Clientes.Visible = false;
            Panel_Funcionarios.Visible = false;
            Panel_Veiculos.Visible = false;
            Panel_Alugar.Visible = false;
            Panel_Vender.Visible = false;
        }
    

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            Mudar_Pass f2 = new Mudar_Pass();

            f2.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void panel2_MouseMove_1(object sender, MouseEventArgs e)
        {
            Panel_Clientes.Visible = false;
            Panel_Funcionarios.Visible = false;
            Panel_Veiculos.Visible = false;
            Panel_Alugar.Visible = false;
            Panel_Vender.Visible = false;
        }
    }
}
