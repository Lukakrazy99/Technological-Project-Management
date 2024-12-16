namespace PT
{
    partial class Clientes_Registar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes_Registar));
            this.Adicionar_Cliente = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cliente_CC = new System.Windows.Forms.MaskedTextBox();
            this.Cliente_Telemovel = new System.Windows.Forms.MaskedTextBox();
            this.Cliente_NIF = new System.Windows.Forms.MaskedTextBox();
            this.Cliente_Cod_Postal = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Cliente_Morada = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label18 = new System.Windows.Forms.Label();
            this.Cliente_Email = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Cliente_Nome = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider7 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider8 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider8)).BeginInit();
            this.SuspendLayout();
            // 
            // Adicionar_Cliente
            // 
            this.Adicionar_Cliente.ActiveBorderThickness = 1;
            this.Adicionar_Cliente.ActiveCornerRadius = 20;
            this.Adicionar_Cliente.ActiveFillColor = System.Drawing.Color.Black;
            this.Adicionar_Cliente.ActiveForecolor = System.Drawing.Color.White;
            this.Adicionar_Cliente.ActiveLineColor = System.Drawing.Color.Black;
            this.Adicionar_Cliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Adicionar_Cliente.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Adicionar_Cliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Adicionar_Cliente.BackgroundImage")));
            this.Adicionar_Cliente.ButtonText = "Adicionar";
            this.Adicionar_Cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Adicionar_Cliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adicionar_Cliente.ForeColor = System.Drawing.Color.Black;
            this.Adicionar_Cliente.IdleBorderThickness = 1;
            this.Adicionar_Cliente.IdleCornerRadius = 20;
            this.Adicionar_Cliente.IdleFillColor = System.Drawing.Color.White;
            this.Adicionar_Cliente.IdleForecolor = System.Drawing.Color.Black;
            this.Adicionar_Cliente.IdleLineColor = System.Drawing.Color.Black;
            this.Adicionar_Cliente.Location = new System.Drawing.Point(857, 569);
            this.Adicionar_Cliente.Margin = new System.Windows.Forms.Padding(5);
            this.Adicionar_Cliente.Name = "Adicionar_Cliente";
            this.Adicionar_Cliente.Size = new System.Drawing.Size(134, 41);
            this.Adicionar_Cliente.TabIndex = 130;
            this.Adicionar_Cliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Adicionar_Cliente.Click += new System.EventHandler(this.Adicionar_Cliente_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 285);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(812, 325);
            this.dataGridView1.TabIndex = 129;
            // 
            // Cliente_CC
            // 
            this.Cliente_CC.Location = new System.Drawing.Point(361, 153);
            this.Cliente_CC.Mask = "000000000LL0";
            this.Cliente_CC.Name = "Cliente_CC";
            this.Cliente_CC.Size = new System.Drawing.Size(63, 20);
            this.Cliente_CC.TabIndex = 128;
            this.Cliente_CC.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.Cliente_CC.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Cliente_CC_MaskInputRejected);
            // 
            // Cliente_Telemovel
            // 
            this.Cliente_Telemovel.Location = new System.Drawing.Point(675, 153);
            this.Cliente_Telemovel.Mask = "000000000";
            this.Cliente_Telemovel.Name = "Cliente_Telemovel";
            this.Cliente_Telemovel.Size = new System.Drawing.Size(62, 20);
            this.Cliente_Telemovel.TabIndex = 127;
            this.Cliente_Telemovel.ValidatingType = typeof(int);
            this.Cliente_Telemovel.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Cliente_Telemovel_MaskInputRejected);
            // 
            // Cliente_NIF
            // 
            this.Cliente_NIF.Location = new System.Drawing.Point(524, 153);
            this.Cliente_NIF.Mask = "000000000";
            this.Cliente_NIF.Name = "Cliente_NIF";
            this.Cliente_NIF.Size = new System.Drawing.Size(63, 20);
            this.Cliente_NIF.TabIndex = 126;
            this.Cliente_NIF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.Cliente_NIF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Cliente_NIF_MaskInputRejected);
            // 
            // Cliente_Cod_Postal
            // 
            this.Cliente_Cod_Postal.Location = new System.Drawing.Point(312, 226);
            this.Cliente_Cod_Postal.Mask = "0000-999";
            this.Cliente_Cod_Postal.Name = "Cliente_Cod_Postal";
            this.Cliente_Cod_Postal.Size = new System.Drawing.Size(54, 20);
            this.Cliente_Cod_Postal.TabIndex = 125;
            this.Cliente_Cod_Postal.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Cliente_Cod_Postal_MaskInputRejected);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(309, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 15);
            this.label10.TabIndex = 122;
            this.label10.Text = "Cod. Postal";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(34, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 15);
            this.label11.TabIndex = 111;
            this.label11.Text = "Nome";
            // 
            // Cliente_Morada
            // 
            this.Cliente_Morada.BorderColor = System.Drawing.Color.SeaGreen;
            this.Cliente_Morada.Location = new System.Drawing.Point(36, 226);
            this.Cliente_Morada.Name = "Cliente_Morada";
            this.Cliente_Morada.Size = new System.Drawing.Size(212, 20);
            this.Cliente_Morada.TabIndex = 121;
            this.Cliente_Morada.TextChanged += new System.EventHandler(this.Cliente_Morada_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(672, 123);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 15);
            this.label18.TabIndex = 115;
            this.label18.Text = "Telemóvel";
            // 
            // Cliente_Email
            // 
            this.Cliente_Email.BorderColor = System.Drawing.Color.SeaGreen;
            this.Cliente_Email.Location = new System.Drawing.Point(467, 226);
            this.Cliente_Email.Name = "Cliente_Email";
            this.Cliente_Email.Size = new System.Drawing.Size(225, 20);
            this.Cliente_Email.TabIndex = 120;
            this.Cliente_Email.TextChanged += new System.EventHandler(this.Cliente_Email_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(33, 196);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 15);
            this.label17.TabIndex = 114;
            this.label17.Text = "Morada";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(464, 196);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 15);
            this.label16.TabIndex = 116;
            this.label16.Text = "Email";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(521, 123);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 15);
            this.label15.TabIndex = 113;
            this.label15.Text = "NIF";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(358, 123);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 15);
            this.label14.TabIndex = 117;
            this.label14.Text = "CC";
            // 
            // Cliente_Nome
            // 
            this.Cliente_Nome.BorderColor = System.Drawing.Color.SeaGreen;
            this.Cliente_Nome.Location = new System.Drawing.Point(37, 153);
            this.Cliente_Nome.Name = "Cliente_Nome";
            this.Cliente_Nome.Size = new System.Drawing.Size(240, 20);
            this.Cliente_Nome.TabIndex = 119;
            this.Cliente_Nome.TextChanged += new System.EventHandler(this.Cliente_Nome_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(731, 196);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 15);
            this.label13.TabIndex = 112;
            this.label13.Text = "Data de nascimento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 26);
            this.label1.TabIndex = 110;
            this.label1.Text = "Registar Clientes";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // errorProvider7
            // 
            this.errorProvider7.ContainerControl = this;
            // 
            // errorProvider8
            // 
            this.errorProvider8.ContainerControl = this;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(734, 226);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(176, 20);
            this.dateTimePicker1.TabIndex = 132;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Clientes_Registar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1005, 632);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Adicionar_Cliente);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Cliente_CC);
            this.Controls.Add(this.Cliente_Telemovel);
            this.Controls.Add(this.Cliente_NIF);
            this.Controls.Add(this.Cliente_Cod_Postal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Cliente_Morada);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.Cliente_Email);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Cliente_Nome);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clientes_Registar";
            this.Load += new System.EventHandler(this.Clientes_Registar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 Adicionar_Cliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox Cliente_CC;
        private System.Windows.Forms.MaskedTextBox Cliente_Telemovel;
        private System.Windows.Forms.MaskedTextBox Cliente_NIF;
        private System.Windows.Forms.MaskedTextBox Cliente_Cod_Postal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox Cliente_Morada;
        private System.Windows.Forms.Label label18;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox Cliente_Email;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox Cliente_Nome;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.ErrorProvider errorProvider7;
        private System.Windows.Forms.ErrorProvider errorProvider8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
