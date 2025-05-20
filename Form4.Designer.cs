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
            btn_voltarBusca = new Button();
            btn_desativarAluno = new Button();
            dgvLista = new DataGridView();
            txtBuscar = new TextBox();
            btAdicionar = new Button();
            Nome = new DataGridViewTextBoxColumn();
            CPF = new DataGridViewTextBoxColumn();
            Telefone = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvLista).BeginInit();
            SuspendLayout();
            // 
            // btn_voltarBusca
            // 
            btn_voltarBusca.Location = new Point(220, 264);
            btn_voltarBusca.Margin = new Padding(3, 2, 3, 2);
            btn_voltarBusca.Name = "btn_voltarBusca";
            btn_voltarBusca.Size = new Size(82, 22);
            btn_voltarBusca.TabIndex = 0;
            btn_voltarBusca.Text = "VOLTAR";
            btn_voltarBusca.UseVisualStyleBackColor = true;
            btn_voltarBusca.Click += btn_voltarBusca_Click;
            // 
            // btn_desativarAluno
            // 
            btn_desativarAluno.Location = new Point(132, 264);
            btn_desativarAluno.Margin = new Padding(3, 2, 3, 2);
            btn_desativarAluno.Name = "btn_desativarAluno";
            btn_desativarAluno.Size = new Size(82, 22);
            btn_desativarAluno.TabIndex = 2;
            btn_desativarAluno.Text = "DESATIVAR";
            btn_desativarAluno.UseVisualStyleBackColor = true;
            // 
            // dgvLista
            // 
            dgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLista.Columns.AddRange(new DataGridViewColumn[] { Nome, CPF, Telefone });
            dgvLista.Location = new Point(143, 70);
            dgvLista.Name = "dgvLista";
            dgvLista.Size = new Size(360, 150);
            dgvLista.TabIndex = 3;
            dgvLista.CellContentClick += dgvLista_CellContentClick;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(145, 47);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(100, 23);
            txtBuscar.TabIndex = 4;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // btAdicionar
            // 
            btAdicionar.Location = new Point(324, 264);
            btAdicionar.Name = "btAdicionar";
            btAdicionar.Size = new Size(75, 23);
            btAdicionar.TabIndex = 5;
            btAdicionar.Text = "Adicionar";
            btAdicionar.UseVisualStyleBackColor = true;
            btAdicionar.Click += btAdicionar_Click;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            // 
            // CPF
            // 
            CPF.HeaderText = "CPF";
            CPF.Name = "CPF";
            // 
            // Telefone
            // 
            Telefone.HeaderText = "Telefone";
            Telefone.Name = "Telefone";
            // 
            // tela_buscaaluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 0);
            ClientSize = new Size(648, 392);
            Controls.Add(btAdicionar);
            Controls.Add(txtBuscar);
            Controls.Add(dgvLista);
            Controls.Add(btn_desativarAluno);
            Controls.Add(btn_voltarBusca);
            Margin = new Padding(3, 2, 3, 2);
            Name = "tela_buscaaluno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BUSCA ALUNO";
            ((System.ComponentModel.ISupportInitialize)dgvLista).EndInit();
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
    }
}