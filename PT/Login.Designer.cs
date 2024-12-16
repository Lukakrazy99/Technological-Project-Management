namespace PT
{
    partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.bunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
			this.b_apagar = new Bunifu.Framework.UI.BunifuImageButton();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.b_apagar)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(81, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(252, 144);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// bunifuMaterialTextbox1
			// 
			this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Arial", 9.75F);
			this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
			this.bunifuMaterialTextbox1.HintText = "";
			this.bunifuMaterialTextbox1.isPassword = false;
			this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Black;
			this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.bunifuMaterialTextbox1.LineThickness = 2;
			this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(140, 175);
			this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
			this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
			this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(183, 33);
			this.bunifuMaterialTextbox1.TabIndex = 9;
			this.bunifuMaterialTextbox1.Text = "NIF";
			this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.bunifuMaterialTextbox1.Enter += new System.EventHandler(this.BunifuMaterialTextbox1_Enter);
			this.bunifuMaterialTextbox1.Leave += new System.EventHandler(this.bunifuMaterialTextbox1_Leave);
			// 
			// bunifuMaterialTextbox2
			// 
			this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Arial", 9.75F);
			this.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Empty;
			this.bunifuMaterialTextbox2.HintText = "Password";
			this.bunifuMaterialTextbox2.isPassword = true;
			this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.Black;
			this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.Black;
			this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.bunifuMaterialTextbox2.LineThickness = 2;
			this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(138, 230);
			this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(4);
			this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
			this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(183, 33);
			this.bunifuMaterialTextbox2.TabIndex = 19;
			this.bunifuMaterialTextbox2.Text = "password";
			this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.bunifuMaterialTextbox2.Enter += new System.EventHandler(this.bunifuMaterialTextbox2_Enter);
			this.bunifuMaterialTextbox2.Leave += new System.EventHandler(this.bunifuMaterialTextbox2_Leave);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(96)))), ((int)(((byte)(131)))));
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(81, 290);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(252, 35);
			this.button1.TabIndex = 20;
			this.button1.Text = "LOGIN";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(81, 162);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(50, 50);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 21;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(81, 220);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(50, 50);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 22;
			this.pictureBox3.TabStop = false;
			// 
			// bunifuImageButton1
			// 
			this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
			this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
			this.bunifuImageButton1.ImageActive = null;
			this.bunifuImageButton1.Location = new System.Drawing.Point(328, 230);
			this.bunifuImageButton1.Name = "bunifuImageButton1";
			this.bunifuImageButton1.Size = new System.Drawing.Size(25, 25);
			this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton1.TabIndex = 25;
			this.bunifuImageButton1.TabStop = false;
			this.bunifuImageButton1.Zoom = 10;
			this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
			this.bunifuImageButton1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bunifuImageButton1_MouseDown);
			this.bunifuImageButton1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bunifuImageButton1_MouseUp);
			// 
			// b_apagar
			// 
			this.b_apagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.b_apagar.BackColor = System.Drawing.Color.Transparent;
			this.b_apagar.Image = ((System.Drawing.Image)(resources.GetObject("b_apagar.Image")));
			this.b_apagar.ImageActive = null;
			this.b_apagar.Location = new System.Drawing.Point(364, 12);
			this.b_apagar.Name = "b_apagar";
			this.b_apagar.Size = new System.Drawing.Size(20, 20);
			this.b_apagar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.b_apagar.TabIndex = 107;
			this.b_apagar.TabStop = false;
			this.b_apagar.Zoom = 0;
			this.b_apagar.Click += new System.EventHandler(this.b_apagar_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.b_apagar);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(409, 33);
			this.panel1.TabIndex = 108;
			this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(409, 380);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.bunifuMaterialTextbox2);
			this.Controls.Add(this.bunifuMaterialTextbox1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.bunifuImageButton1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = ".";
			this.Load += new System.EventHandler(this.Login_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.b_apagar)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton b_apagar;
        private System.Windows.Forms.Panel panel1;
    }
}

