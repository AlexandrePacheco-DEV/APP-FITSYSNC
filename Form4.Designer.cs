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
            btn_editarTreinoAluno = new Button();
            btn_excluirAluno = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_voltarBusca
            // 
            btn_voltarBusca.Location = new Point(151, 317);
            btn_voltarBusca.Name = "btn_voltarBusca";
            btn_voltarBusca.Size = new Size(94, 29);
            btn_voltarBusca.TabIndex = 0;
            btn_voltarBusca.Text = "VOLTAR";
            btn_voltarBusca.UseVisualStyleBackColor = true;
            btn_voltarBusca.Click += btn_voltarBusca_Click;
            // 
            // btn_editarTreinoAluno
            // 
            btn_editarTreinoAluno.Location = new Point(528, 317);
            btn_editarTreinoAluno.Name = "btn_editarTreinoAluno";
            btn_editarTreinoAluno.Size = new Size(94, 29);
            btn_editarTreinoAluno.TabIndex = 1;
            btn_editarTreinoAluno.Text = "EDITAR";
            btn_editarTreinoAluno.UseVisualStyleBackColor = true;
            // 
            // btn_excluirAluno
            // 
            btn_excluirAluno.Location = new Point(419, 317);
            btn_excluirAluno.Name = "btn_excluirAluno";
            btn_excluirAluno.Size = new Size(94, 29);
            btn_excluirAluno.TabIndex = 2;
            btn_excluirAluno.Text = "EXCLUIR";
            btn_excluirAluno.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(160, 117);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(462, 44);
            listBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(160, 94);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 4;
            label1.Text = "PESQUISAR";
            // 
            // tela_buscaaluno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 0);
            ClientSize = new Size(740, 523);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(btn_excluirAluno);
            Controls.Add(btn_editarTreinoAluno);
            Controls.Add(btn_voltarBusca);
            Name = "tela_buscaaluno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BUSCA ALUNO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_voltarBusca;
        private Button btn_editarTreinoAluno;
        private Button btn_excluirAluno;
        private ListBox listBox1;
        private Label label1;
    }
}