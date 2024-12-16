namespace PT
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Instrutor_CC = new System.Windows.Forms.MaskedTextBox();
            this.Instrutor_Telemovel = new System.Windows.Forms.MaskedTextBox();
            this.Instrutor_NIF = new System.Windows.Forms.MaskedTextBox();
            this.Instrutor_Cod_Postal = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Instrutor_Senha = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Instrutor_Morada = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label18 = new System.Windows.Forms.Label();
            this.Instrutor_Email = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Instrutor_Nome = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label13 = new System.Windows.Forms.Label();
            this.Instrutor_data_nasc = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(-48, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 15);
            this.label11.TabIndex = 109;
            this.label11.Text = "Nome";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(-48, 265);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 15);
            this.label17.TabIndex = 112;
            this.label17.Text = "Morada";
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
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
            this.bunifuThinButton21.Location = new System.Drawing.Point(860, 567);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(134, 41);
            this.bunifuThinButton21.TabIndex = 133;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 283);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(812, 325);
            this.dataGridView1.TabIndex = 132;
            // 
            // Instrutor_CC
            // 
            this.Instrutor_CC.Location = new System.Drawing.Point(368, 143);
            this.Instrutor_CC.Mask = "000000000LL0";
            this.Instrutor_CC.Name = "Instrutor_CC";
            this.Instrutor_CC.Size = new System.Drawing.Size(63, 20);
            this.Instrutor_CC.TabIndex = 131;
            this.Instrutor_CC.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // Instrutor_Telemovel
            // 
            this.Instrutor_Telemovel.Location = new System.Drawing.Point(682, 143);
            this.Instrutor_Telemovel.Mask = "000000000";
            this.Instrutor_Telemovel.Name = "Instrutor_Telemovel";
            this.Instrutor_Telemovel.Size = new System.Drawing.Size(62, 20);
            this.Instrutor_Telemovel.TabIndex = 130;
            this.Instrutor_Telemovel.ValidatingType = typeof(int);
            // 
            // Instrutor_NIF
            // 
            this.Instrutor_NIF.Location = new System.Drawing.Point(531, 143);
            this.Instrutor_NIF.Mask = "000000000";
            this.Instrutor_NIF.Name = "Instrutor_NIF";
            this.Instrutor_NIF.Size = new System.Drawing.Size(63, 20);
            this.Instrutor_NIF.TabIndex = 129;
            this.Instrutor_NIF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // Instrutor_Cod_Postal
            // 
            this.Instrutor_Cod_Postal.Location = new System.Drawing.Point(320, 221);
            this.Instrutor_Cod_Postal.Mask = "0000-999";
            this.Instrutor_Cod_Postal.Name = "Instrutor_Cod_Postal";
            this.Instrutor_Cod_Postal.Size = new System.Drawing.Size(54, 20);
            this.Instrutor_Cod_Postal.TabIndex = 128;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(827, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 127;
            this.label2.Text = "Senha";
            // 
            // Instrutor_Senha
            // 
            this.Instrutor_Senha.BorderColor = System.Drawing.Color.SeaGreen;
            this.Instrutor_Senha.Location = new System.Drawing.Point(830, 143);
            this.Instrutor_Senha.Name = "Instrutor_Senha";
            this.Instrutor_Senha.Size = new System.Drawing.Size(100, 20);
            this.Instrutor_Senha.TabIndex = 126;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(317, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 15);
            this.label10.TabIndex = 125;
            this.label10.Text = "Cod. Postal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 114;
            this.label1.Text = "Nome";
            // 
            // Instrutor_Morada
            // 
            this.Instrutor_Morada.BorderColor = System.Drawing.Color.SeaGreen;
            this.Instrutor_Morada.Location = new System.Drawing.Point(44, 221);
            this.Instrutor_Morada.Name = "Instrutor_Morada";
            this.Instrutor_Morada.Size = new System.Drawing.Size(212, 20);
            this.Instrutor_Morada.TabIndex = 124;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(679, 113);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 15);
            this.label18.TabIndex = 118;
            this.label18.Text = "Telemóvel";
            // 
            // Instrutor_Email
            // 
            this.Instrutor_Email.BorderColor = System.Drawing.Color.SeaGreen;
            this.Instrutor_Email.Location = new System.Drawing.Point(475, 221);
            this.Instrutor_Email.Name = "Instrutor_Email";
            this.Instrutor_Email.Size = new System.Drawing.Size(225, 20);
            this.Instrutor_Email.TabIndex = 123;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 117;
            this.label3.Text = "Morada";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(472, 191);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 15);
            this.label16.TabIndex = 119;
            this.label16.Text = "Email";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(528, 113);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 15);
            this.label15.TabIndex = 116;
            this.label15.Text = "NIF";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(365, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 15);
            this.label14.TabIndex = 120;
            this.label14.Text = "CC";
            // 
            // Instrutor_Nome
            // 
            this.Instrutor_Nome.BorderColor = System.Drawing.Color.SeaGreen;
            this.Instrutor_Nome.Location = new System.Drawing.Point(44, 143);
            this.Instrutor_Nome.Name = "Instrutor_Nome";
            this.Instrutor_Nome.Size = new System.Drawing.Size(240, 20);
            this.Instrutor_Nome.TabIndex = 122;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(739, 191);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 15);
            this.label13.TabIndex = 115;
            this.label13.Text = "Data de nascimento";
            // 
            // Instrutor_data_nasc
            // 
            this.Instrutor_data_nasc.BackColor = System.Drawing.SystemColors.Window;
            this.Instrutor_data_nasc.BorderRadius = 0;
            this.Instrutor_data_nasc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Instrutor_data_nasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instrutor_data_nasc.ForeColor = System.Drawing.Color.Black;
            this.Instrutor_data_nasc.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Instrutor_data_nasc.FormatCustom = null;
            this.Instrutor_data_nasc.Location = new System.Drawing.Point(742, 217);
            this.Instrutor_data_nasc.Margin = new System.Windows.Forms.Padding(2);
            this.Instrutor_data_nasc.Name = "Instrutor_data_nasc";
            this.Instrutor_data_nasc.Size = new System.Drawing.Size(196, 32);
            this.Instrutor_data_nasc.TabIndex = 121;
            this.Instrutor_data_nasc.Value = new System.DateTime(2019, 12, 12, 9, 33, 25, 212);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 18F);
            this.label4.Location = new System.Drawing.Point(50, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 29);
            this.label4.TabIndex = 113;
            this.label4.Text = "Registar Clientes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1005, 632);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Instrutor_CC);
            this.Controls.Add(this.Instrutor_Telemovel);
            this.Controls.Add(this.Instrutor_NIF);
            this.Controls.Add(this.Instrutor_Cod_Postal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Instrutor_Senha);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Instrutor_Morada);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.Instrutor_Email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Instrutor_Nome);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Instrutor_data_nasc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label17);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox Instrutor_CC;
        private System.Windows.Forms.MaskedTextBox Instrutor_Telemovel;
        private System.Windows.Forms.MaskedTextBox Instrutor_NIF;
        private System.Windows.Forms.MaskedTextBox Instrutor_Cod_Postal;
        private System.Windows.Forms.Label label2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox Instrutor_Senha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox Instrutor_Morada;
        private System.Windows.Forms.Label label18;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox Instrutor_Email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox Instrutor_Nome;
        private System.Windows.Forms.Label label13;
        private Bunifu.Framework.UI.BunifuDatepicker Instrutor_data_nasc;
        private System.Windows.Forms.Label label4;
    }
}
