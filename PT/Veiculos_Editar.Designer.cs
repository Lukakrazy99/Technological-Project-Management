namespace PT
{
    partial class Veiculos_Editar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Veiculos_Editar));
            this.Label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.Veiculo_Ativo = new Bunifu.Framework.UI.BunifuCheckbox();
            this.Veiculo_Matricula = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Veiculo_Modelo = new System.Windows.Forms.TextBox();
            this.Veiculo_Seguro = new Bunifu.Framework.UI.BunifuDatepicker();
            this.Veiculo_Revisao = new Bunifu.Framework.UI.BunifuDatepicker();
            this.Veiculo_Inspecao = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Veiculo_Potencia = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Veiculo_Cilindrada = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Veiculo_Cor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Veiculo_Ano = new System.Windows.Forms.TextBox();
            this.Veiculo_Comb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Veiculo_Marca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Veiculo_TdC = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Veiculo_KM = new System.Windows.Forms.TextBox();
            this.adicionar_aluno = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(28, 21);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(137, 26);
            this.Label3.TabIndex = 141;
            this.Label3.Text = "Editar Veículos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 298);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(935, 322);
            this.dataGridView1.TabIndex = 139;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(718, 244);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 15);
            this.label15.TabIndex = 198;
            this.label15.Text = "Ativo: ";
            // 
            // Veiculo_Ativo
            // 
            this.Veiculo_Ativo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Veiculo_Ativo.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Veiculo_Ativo.Checked = false;
            this.Veiculo_Ativo.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.Veiculo_Ativo.ForeColor = System.Drawing.Color.White;
            this.Veiculo_Ativo.Location = new System.Drawing.Point(766, 244);
            this.Veiculo_Ativo.Name = "Veiculo_Ativo";
            this.Veiculo_Ativo.Size = new System.Drawing.Size(20, 20);
            this.Veiculo_Ativo.TabIndex = 197;
            // 
            // Veiculo_Matricula
            // 
            this.Veiculo_Matricula.Location = new System.Drawing.Point(33, 123);
            this.Veiculo_Matricula.Mask = ">AA-AA-AA";
            this.Veiculo_Matricula.Name = "Veiculo_Matricula";
            this.Veiculo_Matricula.Size = new System.Drawing.Size(54, 20);
            this.Veiculo_Matricula.TabIndex = 196;
            this.Veiculo_Matricula.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(289, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 194;
            this.label4.Text = "Modelo";
            // 
            // Veiculo_Modelo
            // 
            this.Veiculo_Modelo.Location = new System.Drawing.Point(292, 123);
            this.Veiculo_Modelo.Name = "Veiculo_Modelo";
            this.Veiculo_Modelo.Size = new System.Drawing.Size(77, 20);
            this.Veiculo_Modelo.TabIndex = 195;
            // 
            // Veiculo_Seguro
            // 
            this.Veiculo_Seguro.BackColor = System.Drawing.SystemColors.Window;
            this.Veiculo_Seguro.BorderRadius = 0;
            this.Veiculo_Seguro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Veiculo_Seguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Veiculo_Seguro.ForeColor = System.Drawing.Color.Black;
            this.Veiculo_Seguro.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Veiculo_Seguro.FormatCustom = null;
            this.Veiculo_Seguro.Location = new System.Drawing.Point(494, 233);
            this.Veiculo_Seguro.Margin = new System.Windows.Forms.Padding(2);
            this.Veiculo_Seguro.Name = "Veiculo_Seguro";
            this.Veiculo_Seguro.Size = new System.Drawing.Size(207, 37);
            this.Veiculo_Seguro.TabIndex = 193;
            this.Veiculo_Seguro.Value = new System.DateTime(2019, 12, 12, 9, 33, 25, 212);
            // 
            // Veiculo_Revisao
            // 
            this.Veiculo_Revisao.BackColor = System.Drawing.SystemColors.Window;
            this.Veiculo_Revisao.BorderRadius = 0;
            this.Veiculo_Revisao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Veiculo_Revisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Veiculo_Revisao.ForeColor = System.Drawing.Color.Black;
            this.Veiculo_Revisao.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Veiculo_Revisao.FormatCustom = null;
            this.Veiculo_Revisao.Location = new System.Drawing.Point(263, 233);
            this.Veiculo_Revisao.Margin = new System.Windows.Forms.Padding(2);
            this.Veiculo_Revisao.Name = "Veiculo_Revisao";
            this.Veiculo_Revisao.Size = new System.Drawing.Size(194, 37);
            this.Veiculo_Revisao.TabIndex = 192;
            this.Veiculo_Revisao.Value = new System.DateTime(2019, 12, 12, 9, 33, 25, 212);
            // 
            // Veiculo_Inspecao
            // 
            this.Veiculo_Inspecao.BackColor = System.Drawing.SystemColors.Window;
            this.Veiculo_Inspecao.BorderRadius = 0;
            this.Veiculo_Inspecao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Veiculo_Inspecao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Veiculo_Inspecao.ForeColor = System.Drawing.Color.Black;
            this.Veiculo_Inspecao.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Veiculo_Inspecao.FormatCustom = null;
            this.Veiculo_Inspecao.Location = new System.Drawing.Point(33, 233);
            this.Veiculo_Inspecao.Margin = new System.Windows.Forms.Padding(2);
            this.Veiculo_Inspecao.Name = "Veiculo_Inspecao";
            this.Veiculo_Inspecao.Size = new System.Drawing.Size(194, 37);
            this.Veiculo_Inspecao.TabIndex = 191;
            this.Veiculo_Inspecao.Value = new System.DateTime(2019, 12, 12, 9, 33, 25, 212);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(496, 211);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 15);
            this.label14.TabIndex = 190;
            this.label14.Text = "Seguro";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(260, 211);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 15);
            this.label13.TabIndex = 189;
            this.label13.Text = "Revisão";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(30, 211);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 15);
            this.label12.TabIndex = 188;
            this.label12.Text = "Inspeção";
            // 
            // Veiculo_Potencia
            // 
            this.Veiculo_Potencia.Location = new System.Drawing.Point(175, 181);
            this.Veiculo_Potencia.Name = "Veiculo_Potencia";
            this.Veiculo_Potencia.Size = new System.Drawing.Size(52, 20);
            this.Veiculo_Potencia.TabIndex = 187;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(172, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 15);
            this.label11.TabIndex = 186;
            this.label11.Text = "Potência";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(30, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 171;
            this.label1.Text = "Matricula";
            // 
            // Veiculo_Cilindrada
            // 
            this.Veiculo_Cilindrada.Location = new System.Drawing.Point(33, 181);
            this.Veiculo_Cilindrada.Name = "Veiculo_Cilindrada";
            this.Veiculo_Cilindrada.Size = new System.Drawing.Size(100, 20);
            this.Veiculo_Cilindrada.TabIndex = 185;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(402, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 15);
            this.label7.TabIndex = 177;
            this.label7.Text = "Cor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(422, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 15);
            this.label6.TabIndex = 176;
            this.label6.Text = "Tipo de carro";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(30, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 15);
            this.label10.TabIndex = 184;
            this.label10.Text = "Cilindrada";
            // 
            // Veiculo_Cor
            // 
            this.Veiculo_Cor.Location = new System.Drawing.Point(403, 181);
            this.Veiculo_Cor.Name = "Veiculo_Cor";
            this.Veiculo_Cor.Size = new System.Drawing.Size(65, 20);
            this.Veiculo_Cor.TabIndex = 178;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(151, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 172;
            this.label2.Text = "Marca";
            // 
            // Veiculo_Ano
            // 
            this.Veiculo_Ano.Location = new System.Drawing.Point(510, 181);
            this.Veiculo_Ano.Name = "Veiculo_Ano";
            this.Veiculo_Ano.Size = new System.Drawing.Size(50, 20);
            this.Veiculo_Ano.TabIndex = 175;
            // 
            // Veiculo_Comb
            // 
            this.Veiculo_Comb.FormattingEnabled = true;
            this.Veiculo_Comb.Items.AddRange(new object[] {
            "Diesel",
            "Gasolina",
            "Híbrido ( Gasolina )",
            "Híbrido ( Diesel )",
            "Elétrico",
            "GPL"});
            this.Veiculo_Comb.Location = new System.Drawing.Point(263, 180);
            this.Veiculo_Comb.Name = "Veiculo_Comb";
            this.Veiculo_Comb.Size = new System.Drawing.Size(100, 21);
            this.Veiculo_Comb.TabIndex = 183;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(559, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 15);
            this.label8.TabIndex = 179;
            this.label8.Text = "Quilometros";
            // 
            // Veiculo_Marca
            // 
            this.Veiculo_Marca.Location = new System.Drawing.Point(154, 123);
            this.Veiculo_Marca.Name = "Veiculo_Marca";
            this.Veiculo_Marca.Size = new System.Drawing.Size(78, 20);
            this.Veiculo_Marca.TabIndex = 173;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(507, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 174;
            this.label5.Text = "Ano";
            // 
            // Veiculo_TdC
            // 
            this.Veiculo_TdC.FormattingEnabled = true;
            this.Veiculo_TdC.Items.AddRange(new object[] {
            "Motociclos",
            "Veiculos Ligeiros",
            "Veiculos Pesados"});
            this.Veiculo_TdC.Location = new System.Drawing.Point(424, 122);
            this.Veiculo_TdC.Name = "Veiculo_TdC";
            this.Veiculo_TdC.Size = new System.Drawing.Size(114, 21);
            this.Veiculo_TdC.TabIndex = 182;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(260, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 15);
            this.label9.TabIndex = 180;
            this.label9.Text = "Combustivel";
            // 
            // Veiculo_KM
            // 
            this.Veiculo_KM.Location = new System.Drawing.Point(562, 123);
            this.Veiculo_KM.Name = "Veiculo_KM";
            this.Veiculo_KM.Size = new System.Drawing.Size(100, 20);
            this.Veiculo_KM.TabIndex = 181;
            // 
            // adicionar_aluno
            // 
            this.adicionar_aluno.ActiveBorderThickness = 1;
            this.adicionar_aluno.ActiveCornerRadius = 20;
            this.adicionar_aluno.ActiveFillColor = System.Drawing.Color.Black;
            this.adicionar_aluno.ActiveForecolor = System.Drawing.Color.White;
            this.adicionar_aluno.ActiveLineColor = System.Drawing.Color.Black;
            this.adicionar_aluno.BackColor = System.Drawing.SystemColors.Control;
            this.adicionar_aluno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("adicionar_aluno.BackgroundImage")));
            this.adicionar_aluno.ButtonText = "Editar";
            this.adicionar_aluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adicionar_aluno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adicionar_aluno.ForeColor = System.Drawing.Color.Black;
            this.adicionar_aluno.IdleBorderThickness = 1;
            this.adicionar_aluno.IdleCornerRadius = 20;
            this.adicionar_aluno.IdleFillColor = System.Drawing.Color.White;
            this.adicionar_aluno.IdleForecolor = System.Drawing.Color.Black;
            this.adicionar_aluno.IdleLineColor = System.Drawing.Color.Black;
            this.adicionar_aluno.Location = new System.Drawing.Point(827, 233);
            this.adicionar_aluno.Margin = new System.Windows.Forms.Padding(5);
            this.adicionar_aluno.Name = "adicionar_aluno";
            this.adicionar_aluno.Size = new System.Drawing.Size(133, 41);
            this.adicionar_aluno.TabIndex = 170;
            this.adicionar_aluno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Veiculos_Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 632);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Veiculo_Ativo);
            this.Controls.Add(this.Veiculo_Matricula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Veiculo_Modelo);
            this.Controls.Add(this.Veiculo_Seguro);
            this.Controls.Add(this.Veiculo_Revisao);
            this.Controls.Add(this.Veiculo_Inspecao);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Veiculo_Potencia);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Veiculo_Cilindrada);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Veiculo_Cor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Veiculo_Ano);
            this.Controls.Add(this.Veiculo_Comb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Veiculo_Marca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Veiculo_TdC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Veiculo_KM);
            this.Controls.Add(this.adicionar_aluno);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Veiculos_Editar";
            this.Text = "Veiculos_Editar";
            this.Load += new System.EventHandler(this.Veiculos_Editar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label Label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label15;
        private Bunifu.Framework.UI.BunifuCheckbox Veiculo_Ativo;
        private System.Windows.Forms.MaskedTextBox Veiculo_Matricula;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Veiculo_Modelo;
        private Bunifu.Framework.UI.BunifuDatepicker Veiculo_Seguro;
        private Bunifu.Framework.UI.BunifuDatepicker Veiculo_Revisao;
        private Bunifu.Framework.UI.BunifuDatepicker Veiculo_Inspecao;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Veiculo_Potencia;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Veiculo_Cilindrada;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Veiculo_Cor;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Veiculo_Ano;
        private System.Windows.Forms.ComboBox Veiculo_Comb;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Veiculo_Marca;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Veiculo_TdC;
        internal System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Veiculo_KM;
        private Bunifu.Framework.UI.BunifuThinButton2 adicionar_aluno;
    }
}