namespace PT
{
    partial class Funcionarios_Registar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Funcionarios_Registar));
            this.Instrutor_CC = new System.Windows.Forms.MaskedTextBox();
            this.Instrutor_Certificacao = new System.Windows.Forms.ComboBox();
            this.Instrutor_Telemovel = new System.Windows.Forms.MaskedTextBox();
            this.Instrutor_NIF = new System.Windows.Forms.MaskedTextBox();
            this.Instrutor_Cod_Postal = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Instrutor_Senha = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Instrutor_Morada = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label18 = new System.Windows.Forms.Label();
            this.Instrutor_Email = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Instrutor_Nome = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider7 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider8 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider9 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider10 = new System.Windows.Forms.ErrorProvider(this.components);
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.errorProvider11 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider12 = new System.Windows.Forms.ErrorProvider(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider12)).BeginInit();
            this.SuspendLayout();
            // 
            // Instrutor_CC
            // 
            this.Instrutor_CC.Location = new System.Drawing.Point(290, 146);
            this.Instrutor_CC.Mask = "000000000LL0";
            this.Instrutor_CC.Name = "Instrutor_CC";
            this.Instrutor_CC.Size = new System.Drawing.Size(63, 20);
            this.Instrutor_CC.TabIndex = 112;
            this.Instrutor_CC.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.Instrutor_CC.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Instrutor_CC_MaskInputRejected);
            // 
            // Instrutor_Certificacao
            // 
            this.Instrutor_Certificacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Instrutor_Certificacao.FormattingEnabled = true;
            this.Instrutor_Certificacao.Items.AddRange(new object[] {
            "9º Ano",
            "12º Ano",
            "Licenciatura",
            "Mestrado",
            "Doutoramento"});
            this.Instrutor_Certificacao.Location = new System.Drawing.Point(846, 146);
            this.Instrutor_Certificacao.Name = "Instrutor_Certificacao";
            this.Instrutor_Certificacao.Size = new System.Drawing.Size(131, 21);
            this.Instrutor_Certificacao.TabIndex = 111;
            this.Instrutor_Certificacao.SelectedIndexChanged += new System.EventHandler(this.Instrutor_Certificacao_SelectedIndexChanged);
            // 
            // Instrutor_Telemovel
            // 
            this.Instrutor_Telemovel.Location = new System.Drawing.Point(628, 146);
            this.Instrutor_Telemovel.Mask = "000000000";
            this.Instrutor_Telemovel.Name = "Instrutor_Telemovel";
            this.Instrutor_Telemovel.Size = new System.Drawing.Size(62, 20);
            this.Instrutor_Telemovel.TabIndex = 110;
            this.Instrutor_Telemovel.ValidatingType = typeof(int);
            this.Instrutor_Telemovel.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Instrutor_Telemovel_MaskInputRejected);
            // 
            // Instrutor_NIF
            // 
            this.Instrutor_NIF.Location = new System.Drawing.Point(539, 146);
            this.Instrutor_NIF.Mask = "000000000";
            this.Instrutor_NIF.Name = "Instrutor_NIF";
            this.Instrutor_NIF.Size = new System.Drawing.Size(63, 20);
            this.Instrutor_NIF.TabIndex = 109;
            this.Instrutor_NIF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.Instrutor_NIF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Instrutor_NIF_MaskInputRejected);
            // 
            // Instrutor_Cod_Postal
            // 
            this.Instrutor_Cod_Postal.Location = new System.Drawing.Point(272, 224);
            this.Instrutor_Cod_Postal.Mask = "0000-999";
            this.Instrutor_Cod_Postal.Name = "Instrutor_Cod_Postal";
            this.Instrutor_Cod_Postal.Size = new System.Drawing.Size(54, 20);
            this.Instrutor_Cod_Postal.TabIndex = 108;
            this.Instrutor_Cod_Postal.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Instrutor_Cod_Postal_MaskInputRejected);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(738, 290);
            this.dataGridView1.TabIndex = 107;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 26);
            this.label2.TabIndex = 106;
            this.label2.Text = "Registar Funcionários";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(715, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 105;
            this.label1.Text = "Senha";
            // 
            // Instrutor_Senha
            // 
            this.Instrutor_Senha.BorderColor = System.Drawing.Color.SeaGreen;
            this.Instrutor_Senha.Location = new System.Drawing.Point(718, 146);
            this.Instrutor_Senha.Name = "Instrutor_Senha";
            this.Instrutor_Senha.Size = new System.Drawing.Size(100, 20);
            this.Instrutor_Senha.TabIndex = 104;
            this.Instrutor_Senha.TextChanged += new System.EventHandler(this.Instrutor_Senha_TextChanged);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Adicionar";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.Location = new System.Drawing.Point(823, 528);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(134, 41);
            this.bunifuThinButton21.TabIndex = 90;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(269, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 15);
            this.label10.TabIndex = 103;
            this.label10.Text = "Cod. Postal";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(32, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 15);
            this.label11.TabIndex = 91;
            this.label11.Text = "Nome";
            // 
            // Instrutor_Morada
            // 
            this.Instrutor_Morada.BorderColor = System.Drawing.Color.SeaGreen;
            this.Instrutor_Morada.Location = new System.Drawing.Point(35, 224);
            this.Instrutor_Morada.Name = "Instrutor_Morada";
            this.Instrutor_Morada.Size = new System.Drawing.Size(212, 20);
            this.Instrutor_Morada.TabIndex = 102;
            this.Instrutor_Morada.TextChanged += new System.EventHandler(this.Instrutor_Morada_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(625, 116);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 15);
            this.label18.TabIndex = 95;
            this.label18.Text = "Telemóvel";
            // 
            // Instrutor_Email
            // 
            this.Instrutor_Email.BorderColor = System.Drawing.Color.SeaGreen;
            this.Instrutor_Email.Location = new System.Drawing.Point(375, 224);
            this.Instrutor_Email.Name = "Instrutor_Email";
            this.Instrutor_Email.Size = new System.Drawing.Size(225, 20);
            this.Instrutor_Email.TabIndex = 101;
            this.Instrutor_Email.TextChanged += new System.EventHandler(this.Instrutor_Email_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(32, 194);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 15);
            this.label17.TabIndex = 94;
            this.label17.Text = "Morada";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(372, 194);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 15);
            this.label16.TabIndex = 96;
            this.label16.Text = "Email";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(536, 116);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 15);
            this.label15.TabIndex = 93;
            this.label15.Text = "NIF";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(287, 116);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 15);
            this.label14.TabIndex = 97;
            this.label14.Text = "CC";
            // 
            // Instrutor_Nome
            // 
            this.Instrutor_Nome.BorderColor = System.Drawing.Color.SeaGreen;
            this.Instrutor_Nome.Location = new System.Drawing.Point(35, 146);
            this.Instrutor_Nome.Name = "Instrutor_Nome";
            this.Instrutor_Nome.Size = new System.Drawing.Size(240, 20);
            this.Instrutor_Nome.TabIndex = 100;
            this.Instrutor_Nome.TextChanged += new System.EventHandler(this.Instrutor_Nome_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(639, 194);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 15);
            this.label13.TabIndex = 92;
            this.label13.Text = "Data de nascimento";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(843, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 15);
            this.label12.TabIndex = 98;
            this.label12.Text = "Certificação";
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
            // errorProvider9
            // 
            this.errorProvider9.ContainerControl = this;
            // 
            // errorProvider10
            // 
            this.errorProvider10.ContainerControl = this;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(375, 146);
            this.maskedTextBox1.Mask = "0000 0000 00000000000 00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(146, 20);
            this.maskedTextBox1.TabIndex = 114;
            this.maskedTextBox1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(372, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 15);
            this.label3.TabIndex = 113;
            this.label3.Text = "NIB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(858, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 116;
            this.label4.Text = "Cargo";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Funcionário",
            "Administrador"});
            this.comboBox1.Location = new System.Drawing.Point(861, 224);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(88, 21);
            this.comboBox1.TabIndex = 117;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // errorProvider11
            // 
            this.errorProvider11.ContainerControl = this;
            // 
            // errorProvider12
            // 
            this.errorProvider12.ContainerControl = this;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(642, 225);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(176, 20);
            this.dateTimePicker1.TabIndex = 133;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Funcionarios_Registar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(989, 588);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Instrutor_CC);
            this.Controls.Add(this.Instrutor_Certificacao);
            this.Controls.Add(this.Instrutor_Telemovel);
            this.Controls.Add(this.Instrutor_NIF);
            this.Controls.Add(this.Instrutor_Cod_Postal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Instrutor_Senha);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Instrutor_Morada);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.Instrutor_Email);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Instrutor_Nome);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Funcionarios_Registar";
            this.Text = "Funcionarios";
            this.Load += new System.EventHandler(this.Funcionarios_Registar_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Funcionarios_Registar_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox Instrutor_CC;
        private System.Windows.Forms.ComboBox Instrutor_Certificacao;
        private System.Windows.Forms.MaskedTextBox Instrutor_Telemovel;
        private System.Windows.Forms.MaskedTextBox Instrutor_NIF;
        private System.Windows.Forms.MaskedTextBox Instrutor_Cod_Postal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox Instrutor_Senha;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox Instrutor_Morada;
        private System.Windows.Forms.Label label18;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox Instrutor_Email;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox Instrutor_Nome;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.ErrorProvider errorProvider7;
        private System.Windows.Forms.ErrorProvider errorProvider8;
        private System.Windows.Forms.ErrorProvider errorProvider9;
        private System.Windows.Forms.ErrorProvider errorProvider10;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider11;
        private System.Windows.Forms.ErrorProvider errorProvider12;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}