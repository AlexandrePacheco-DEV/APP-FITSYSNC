namespace APP_FITSYNC
{
    partial class tela_buscaaluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tela_buscaaluno));
            btn_voltarBusca = new Button();
            btn_desativarAluno = new Button();
            dgvLista = new DataGridView();
            Nome = new DataGridViewTextBoxColumn();
            CPF = new DataGridViewTextBoxColumn();
            Telefone = new DataGridViewTextBoxColumn();
            txtBuscar = new TextBox();
            btAdicionar = new Button();
            pictureBox1 = new PictureBox();
            btn_editaraluno = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLista).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_voltarBusca
            // 
            btn_voltarBusca.Location = new Point(24, 482);
            btn_voltarBusca.Name = "btn_voltarBusca";
            btn_voltarBusca.Size = new Size(96, 29);
            btn_voltarBusca.TabIndex = 0;
            btn_voltarBusca.Text = "VOLTAR";
            btn_voltarBusca.UseVisualStyleBackColor = true;
            btn_voltarBusca.Click += btn_voltarBusca_Click;
            // 
            // btn_desativarAluno
            // 
            btn_desativarAluno.BackColor = Color.Red;
            btn_desativarAluno.Location = new Point(199, 423);
            btn_desativarAluno.Name = "btn_desativarAluno";
            btn_desativarAluno.Size = new Size(94, 29);
            btn_desativarAluno.TabIndex = 2;
            btn_desativarAluno.Text = "EXCLUIR";
            btn_desativarAluno.UseVisualStyleBackColor = false;
            btn_desativarAluno.Click += btn_desativarAluno_Click;
            // 
            // dgvLista
            // 
            dgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLista.Columns.AddRange(new DataGridViewColumn[] { Nome, CPF, Telefone });
            dgvLista.Location = new Point(199, 167);
            dgvLista.Margin = new Padding(3, 4, 3, 4);
            dgvLista.Name = "dgvLista";
            dgvLista.RowHeadersWidth = 51;
            dgvLista.Size = new Size(429, 200);
            dgvLista.TabIndex = 3;
            dgvLista.CellContentClick += dgvLista_CellContentClick;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.Width = 125;
            // 
            // CPF
            // 
            CPF.HeaderText = "CPF";
            CPF.MinimumWidth = 6;
            CPF.Name = "CPF";
            CPF.Width = 125;
            // 
            // Telefone
            // 
            Telefone.HeaderText = "Telefone";
            Telefone.MinimumWidth = 6;
            Telefone.Name = "Telefone";
            Telefone.Width = 125;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(199, 132);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(429, 27);
            txtBuscar.TabIndex = 4;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // btAdicionar
            // 
            btAdicionar.BackColor = Color.FromArgb(0, 192, 0);
            btAdicionar.Location = new Point(416, 421);
            btAdicionar.Margin = new Padding(3, 4, 3, 4);
            btAdicionar.Name = "btAdicionar";
            btAdicionar.Size = new Size(100, 31);
            btAdicionar.TabIndex = 5;
            btAdicionar.Text = "NOVO ";
            btAdicionar.UseVisualStyleBackColor = false;
            btAdicionar.Click += btAdicionar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.busca_de_aluno_FITSYSNC;
            pictureBox1.Location = new Point(149, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btn_editaraluno
            // 
            btn_editaraluno.BackColor = Color.FromArgb(255, 255, 128);
            btn_editaraluno.Location = new Point(528, 421);
            btn_editaraluno.Margin = new Padding(3, 4, 3, 4);
            btn_editaraluno.Name = "btn_editaraluno";
            btn_editaraluno.Size = new Size(100, 31);
            btn_editaraluno.TabIndex = 7;
            btn_editaraluno.Text = "EDITAR";
            btn_editaraluno.UseVisualStyleBackColor = false;
            btn_editaraluno.Click += btn_editaraluno_Click;
            // 
            // tela_buscaaluno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 0);
            ClientSize = new Size(837, 523);
            Controls.Add(btn_editaraluno);
            Controls.Add(pictureBox1);
            Controls.Add(btAdicionar);
            Controls.Add(txtBuscar);
            Controls.Add(dgvLista);
            Controls.Add(btn_desativarAluno);
            Controls.Add(btn_voltarBusca);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "tela_buscaaluno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BUSCA ALUNO";
            Load += tela_buscaaluno_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLista).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_voltarBusca;
        private Button btn_desativarAluno;
        public DataGridView dgvLista;
        private TextBox txtBuscar;
        private Button btAdicionar;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn CPF;
        private DataGridViewTextBoxColumn Telefone;
        private PictureBox pictureBox1;
        private Button btn_editaraluno;
    }
}