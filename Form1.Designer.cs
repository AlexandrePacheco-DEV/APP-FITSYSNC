namespace APP_FITSYNC
{
    partial class tela_login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tela_login));
            txt_senha = new TextBox();
            txt_login = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btn_sair = new Button();
            btn_acessar = new Button();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            lbl_parc = new Label();
            btn_ajudaWhats = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(377, 305);
            txt_senha.Multiline = true;
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(582, 41);
            txt_senha.TabIndex = 12;
            // 
            // txt_login
            // 
            txt_login.Location = new Point(376, 238);
            txt_login.Multiline = true;
            txt_login.Name = "txt_login";
            txt_login.Size = new Size(583, 41);
            txt_login.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(376, 215);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 10;
            label1.Text = "USUÁRIO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(376, 282);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 9;
            label2.Text = "SENHA:";
            // 
            // btn_sair
            // 
            btn_sair.BackColor = Color.Red;
            btn_sair.Location = new Point(686, 399);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(234, 40);
            btn_sair.TabIndex = 8;
            btn_sair.Text = "SAIR";
            btn_sair.UseVisualStyleBackColor = false;
            btn_sair.Click += btn_sair_Click;
            // 
            // btn_acessar
            // 
            btn_acessar.BackColor = Color.Lime;
            btn_acessar.Location = new Point(437, 399);
            btn_acessar.Name = "btn_acessar";
            btn_acessar.Size = new Size(234, 40);
            btn_acessar.TabIndex = 7;
            btn_acessar.Text = "ACESSAR";
            btn_acessar.UseVisualStyleBackColor = false;
            btn_acessar.Click += btn_acessar_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Black;
            pictureBox3.Image = Properties.Resources.LOGO_ESCRITA_FITSYSNC;
            pictureBox3.Location = new Point(-29, -7);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1390, 162);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(64, 0, 0);
            pictureBox1.Image = Properties.Resources.logo_FITSYNC_x_MG_FITNESS_removebg_preview;
            pictureBox1.Location = new Point(448, 445);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(455, 184);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lbl_parc
            // 
            lbl_parc.AutoSize = true;
            lbl_parc.ForeColor = Color.White;
            lbl_parc.Location = new Point(593, 574);
            lbl_parc.Name = "lbl_parc";
            lbl_parc.Size = new Size(170, 20);
            lbl_parc.TabIndex = 17;
            lbl_parc.Text = "FITSYSNC X MG FITNESS";
            lbl_parc.Click += lbl_parc_Click;
            // 
            // btn_ajudaWhats
            // 
            btn_ajudaWhats.BackColor = Color.FromArgb(192, 0, 0);
            btn_ajudaWhats.Location = new Point(12, 570);
            btn_ajudaWhats.Name = "btn_ajudaWhats";
            btn_ajudaWhats.Size = new Size(94, 29);
            btn_ajudaWhats.TabIndex = 18;
            btn_ajudaWhats.Text = "AJUDA!";
            btn_ajudaWhats.UseVisualStyleBackColor = false;
            btn_ajudaWhats.Click += btn_ajudaWhats_Click;
            // 
            // tela_login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 0);
            ClientSize = new Size(1332, 603);
            Controls.Add(btn_ajudaWhats);
            Controls.Add(lbl_parc);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Controls.Add(txt_senha);
            Controls.Add(txt_login);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btn_sair);
            Controls.Add(btn_acessar);
            ForeColor = Color.FromArgb(64, 0, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "tela_login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FITSYSNC";
            Load += tela_login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_senha;
        private TextBox txt_login;
        private Label label1;
        private Label label2;
        private Button btn_sair;
        private Button btn_acessar;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Label lbl_parc;
        private Button btn_ajudaWhats;
    }
}
