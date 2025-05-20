namespace APP_FITSYNC
{
    partial class tela_cadastroaluno
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tela_cadastroaluno));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btn_cadastrar = new Button();
            pictureBox3 = new PictureBox();
            label17 = new Label();
            mtbNascimento = new MaskedTextBox();
            txtCEP = new TextBox();
            mtbContato = new MaskedTextBox();
            pictureBox1 = new PictureBox();
            label15 = new Label();
            label14 = new Label();
            txtEndereco = new TextBox();
            label13 = new Label();
            txtBairro = new TextBox();
            label3 = new Label();
            txtCidade = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label1 = new Label();
            label12 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            label11 = new Label();
            mtbRegistro = new MaskedTextBox();
            label10 = new Label();
            cmbStatus = new ComboBox();
            label9 = new Label();
            txtGenero = new TextBox();
            label8 = new Label();
            txtRG = new TextBox();
            label7 = new Label();
            txtCPF = new TextBox();
            btn_voltarLogin = new Button();
            txtPeso = new TextBox();
            label6 = new Label();
            txtTelefone = new MaskedTextBox();
            label5 = new Label();
            txtNome = new TextBox();
            label4 = new Label();
            label16 = new Label();
            tabPage2 = new TabPage();
            btn_adicionarnalista = new Button();
            enviar_whatsapp = new Button();
            label19 = new Label();
            label18 = new Label();
            cmbDias = new ComboBox();
            pictureBox2 = new PictureBox();
            lbRepet = new Label();
            txtRepet = new TextBox();
            lbSeries = new Label();
            txtSeries = new TextBox();
            lbExercicio = new Label();
            txtExercicio = new TextBox();
            cmbTreino = new ComboBox();
            dgv_tabela = new DataGridView();
            dias = new DataGridViewTextBoxColumn();
            colunaAparelho = new DataGridViewTextBoxColumn();
            colunaSerie = new DataGridViewTextBoxColumn();
            colunaRep = new DataGridViewTextBoxColumn();
            imageList1 = new ImageList(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_tabela).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(-2, -2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1084, 430);
            tabControl1.TabIndex = 50;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(64, 0, 0);
            tabPage1.Controls.Add(btn_cadastrar);
            tabPage1.Controls.Add(pictureBox3);
            tabPage1.Controls.Add(label17);
            tabPage1.Controls.Add(mtbNascimento);
            tabPage1.Controls.Add(txtCEP);
            tabPage1.Controls.Add(mtbContato);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(txtEndereco);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(txtBairro);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txtCidade);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtEmail);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(maskedTextBox2);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(mtbRegistro);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(cmbStatus);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(txtGenero);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(txtRG);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(txtCPF);
            tabPage1.Controls.Add(btn_voltarLogin);
            tabPage1.Controls.Add(txtPeso);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(txtTelefone);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(txtNome);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label16);
            tabPage1.ForeColor = SystemColors.ActiveCaptionText;
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1076, 402);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "ALUNO";
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.Location = new Point(942, 347);
            btn_cadastrar.Margin = new Padding(3, 2, 3, 2);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(91, 22);
            btn_cadastrar.TabIndex = 92;
            btn_cadastrar.Text = "CADASTRAR";
            btn_cadastrar.UseVisualStyleBackColor = true;
            btn_cadastrar.Click += btn_cadastrar_Click_1;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Black;
            pictureBox3.Image = Properties.Resources.LOGO_ESCRITA_FITSYSNC;
            pictureBox3.Location = new Point(-60, 0);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1164, 94);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 87;
            pictureBox3.TabStop = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = SystemColors.ButtonHighlight;
            label17.Location = new Point(206, 272);
            label17.Name = "label17";
            label17.Size = new Size(114, 15);
            label17.TabIndex = 85;
            label17.Text = "DATA NASCIMENTO";
            // 
            // mtbNascimento
            // 
            mtbNascimento.Location = new Point(207, 290);
            mtbNascimento.Mask = "00/00/0000";
            mtbNascimento.Name = "mtbNascimento";
            mtbNascimento.Size = new Size(71, 23);
            mtbNascimento.TabIndex = 84;
            mtbNascimento.ValidatingType = typeof(DateTime);
            // 
            // txtCEP
            // 
            txtCEP.Location = new Point(15, 230);
            txtCEP.Margin = new Padding(3, 2, 3, 2);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(123, 23);
            txtCEP.TabIndex = 83;
            // 
            // mtbContato
            // 
            mtbContato.Location = new Point(15, 290);
            mtbContato.Margin = new Padding(3, 2, 3, 2);
            mtbContato.Mask = "(00) 99999-9999";
            mtbContato.Name = "mtbContato";
            mtbContato.Size = new Size(92, 23);
            mtbContato.TabIndex = 82;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(910, 118);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 152);
            pictureBox1.TabIndex = 81;
            pictureBox1.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = SystemColors.Control;
            label15.Location = new Point(11, 272);
            label15.Name = "label15";
            label15.Size = new Size(153, 15);
            label15.TabIndex = 80;
            label15.Text = "CONTATO DE EMERGÊNCIA";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = SystemColors.Control;
            label14.Location = new Point(463, 214);
            label14.Name = "label14";
            label14.Size = new Size(66, 15);
            label14.TabIndex = 78;
            label14.Text = "ENDEREÇO";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(459, 228);
            txtEndereco.Margin = new Padding(3, 2, 3, 2);
            txtEndereco.Multiline = true;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(421, 23);
            txtEndereco.TabIndex = 77;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = SystemColors.Control;
            label13.Location = new Point(315, 214);
            label13.Name = "label13";
            label13.Size = new Size(48, 15);
            label13.TabIndex = 76;
            label13.Text = "BAIRRO";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(315, 228);
            txtBairro.Margin = new Padding(3, 2, 3, 2);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(123, 23);
            txtBairro.TabIndex = 75;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(164, 214);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 74;
            label3.Text = "CIDADE - UF";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(164, 228);
            txtCidade.Margin = new Padding(3, 2, 3, 2);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(123, 23);
            txtCidade.TabIndex = 73;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(759, 159);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 72;
            label2.Text = "E-MAIL";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(757, 173);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(123, 23);
            txtEmail.TabIndex = 71;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(10, 230);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 70;
            label1.Text = "CEP";
            label1.Click += label1_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(614, 103);
            label12.Name = "label12";
            label12.Size = new Size(62, 15);
            label12.TabIndex = 68;
            label12.Text = "TELEFONE";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(613, 118);
            maskedTextBox2.Mask = "(99) 00000-0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(121, 23);
            maskedTextBox2.TabIndex = 67;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(758, 100);
            label11.Name = "label11";
            label11.Size = new Size(109, 15);
            label11.TabIndex = 66;
            label11.Text = "DATA DE REGISTRO";
            // 
            // mtbRegistro
            // 
            mtbRegistro.Location = new Point(759, 118);
            mtbRegistro.Mask = "00/00/0000";
            mtbRegistro.Name = "mtbRegistro";
            mtbRegistro.Size = new Size(71, 23);
            mtbRegistro.TabIndex = 65;
            mtbRegistro.ValidatingType = typeof(DateTime);
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(463, 102);
            label10.Name = "label10";
            label10.Size = new Size(47, 15);
            label10.TabIndex = 64;
            label10.Text = "STATUS";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Ativo", "Inativo" });
            cmbStatus.Location = new Point(459, 116);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(121, 23);
            cmbStatus.TabIndex = 63;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(613, 159);
            label9.Name = "label9";
            label9.Size = new Size(52, 15);
            label9.TabIndex = 62;
            label9.Text = "GENERO";
            // 
            // txtGenero
            // 
            txtGenero.Location = new Point(611, 173);
            txtGenero.Margin = new Padding(3, 2, 3, 2);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(123, 23);
            txtGenero.TabIndex = 61;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(469, 159);
            label8.Name = "label8";
            label8.Size = new Size(22, 15);
            label8.TabIndex = 60;
            label8.Text = "RG";
            // 
            // txtRG
            // 
            txtRG.Location = new Point(459, 173);
            txtRG.Margin = new Padding(3, 2, 3, 2);
            txtRG.Name = "txtRG";
            txtRG.Size = new Size(123, 23);
            txtRG.TabIndex = 59;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(318, 159);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 58;
            label7.Text = "CPF";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(315, 173);
            txtCPF.Margin = new Padding(3, 2, 3, 2);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(123, 23);
            txtCPF.TabIndex = 57;
            // 
            // btn_voltarLogin
            // 
            btn_voltarLogin.Location = new Point(15, 347);
            btn_voltarLogin.Margin = new Padding(3, 2, 3, 2);
            btn_voltarLogin.Name = "btn_voltarLogin";
            btn_voltarLogin.Size = new Size(91, 22);
            btn_voltarLogin.TabIndex = 56;
            btn_voltarLogin.Text = "VOLTAR";
            btn_voltarLogin.UseVisualStyleBackColor = true;
            btn_voltarLogin.Click += btn_voltarLogin_Click_1;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(164, 173);
            txtPeso.Margin = new Padding(3, 2, 3, 2);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(123, 23);
            txtPeso.TabIndex = 54;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(166, 159);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 53;
            label6.Text = "PESO ALUNO";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(11, 173);
            txtTelefone.Margin = new Padding(3, 2, 3, 2);
            txtTelefone.Mask = "+55 (00) 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(118, 23);
            txtTelefone.TabIndex = 52;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(15, 159);
            label5.Name = "label5";
            label5.Size = new Size(105, 15);
            label5.TabIndex = 51;
            label5.Text = "TELEFONE ALUNO";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(9, 116);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Multiline = true;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(429, 23);
            txtNome.TabIndex = 50;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(11, 102);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 49;
            label4.Text = "NOME DO ALUNO";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = SystemColors.ButtonHighlight;
            label16.Location = new Point(913, 101);
            label16.Name = "label16";
            label16.Size = new Size(36, 15);
            label16.TabIndex = 48;
            label16.Text = "FOTO";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(64, 0, 0);
            tabPage2.Controls.Add(btn_adicionarnalista);
            tabPage2.Controls.Add(enviar_whatsapp);
            tabPage2.Controls.Add(label19);
            tabPage2.Controls.Add(label18);
            tabPage2.Controls.Add(cmbDias);
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Controls.Add(lbRepet);
            tabPage2.Controls.Add(txtRepet);
            tabPage2.Controls.Add(lbSeries);
            tabPage2.Controls.Add(txtSeries);
            tabPage2.Controls.Add(lbExercicio);
            tabPage2.Controls.Add(txtExercicio);
            tabPage2.Controls.Add(cmbTreino);
            tabPage2.Controls.Add(dgv_tabela);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1076, 402);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "TREINO";
            // 
            // btn_adicionarnalista
            // 
            btn_adicionarnalista.Location = new Point(52, 319);
            btn_adicionarnalista.Margin = new Padding(3, 2, 3, 2);
            btn_adicionarnalista.Name = "btn_adicionarnalista";
            btn_adicionarnalista.Size = new Size(103, 22);
            btn_adicionarnalista.TabIndex = 93;
            btn_adicionarnalista.Text = "ADICIONAR";
            btn_adicionarnalista.UseVisualStyleBackColor = true;
            btn_adicionarnalista.Click += btn_adicionarnalista_Click;
            // 
            // enviar_whatsapp
            // 
            enviar_whatsapp.BackColor = Color.FromArgb(0, 192, 0);
            enviar_whatsapp.Location = new Point(932, 347);
            enviar_whatsapp.Margin = new Padding(3, 2, 3, 2);
            enviar_whatsapp.Name = "enviar_whatsapp";
            enviar_whatsapp.Size = new Size(91, 22);
            enviar_whatsapp.TabIndex = 92;
            enviar_whatsapp.Text = "WHATSAPP";
            enviar_whatsapp.UseVisualStyleBackColor = false;
            enviar_whatsapp.Click += enviar_whatsapp_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = SystemColors.ButtonHighlight;
            label19.Location = new Point(240, 74);
            label19.Name = "label19";
            label19.Size = new Size(93, 15);
            label19.TabIndex = 90;
            label19.Text = "DIAS DE TREINO";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = SystemColors.ButtonHighlight;
            label18.Location = new Point(52, 74);
            label18.Name = "label18";
            label18.Size = new Size(94, 15);
            label18.TabIndex = 89;
            label18.Text = "TIPO DE TREINO";
            // 
            // cmbDias
            // 
            cmbDias.FormattingEnabled = true;
            cmbDias.Items.AddRange(new object[] { "SEGUNDA-FEIRA", "TERÇA-FEIRA", "QUARTA-FEIRA", "QUINTA-FEIRA", "SEXTA-FEIRA", "SÁBADO" });
            cmbDias.Location = new Point(240, 90);
            cmbDias.Name = "cmbDias";
            cmbDias.Size = new Size(121, 23);
            cmbDias.TabIndex = 88;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.TEXTO_REGISTRO_TREINO_FITSYNC;
            pictureBox2.Location = new Point(345, -38);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(448, 88);
            pictureBox2.TabIndex = 87;
            pictureBox2.TabStop = false;
            // 
            // lbRepet
            // 
            lbRepet.AutoSize = true;
            lbRepet.ForeColor = SystemColors.ButtonHighlight;
            lbRepet.Location = new Point(52, 220);
            lbRepet.Name = "lbRepet";
            lbRepet.Size = new Size(72, 15);
            lbRepet.TabIndex = 9;
            lbRepet.Text = "REPETIÇÕES";
            // 
            // txtRepet
            // 
            txtRepet.Location = new Point(52, 238);
            txtRepet.Name = "txtRepet";
            txtRepet.Size = new Size(309, 23);
            txtRepet.TabIndex = 8;
            // 
            // lbSeries
            // 
            lbSeries.AutoSize = true;
            lbSeries.ForeColor = SystemColors.ButtonFace;
            lbSeries.Location = new Point(52, 172);
            lbSeries.Name = "lbSeries";
            lbSeries.Size = new Size(41, 15);
            lbSeries.TabIndex = 7;
            lbSeries.Text = "SÉRIES";
            // 
            // txtSeries
            // 
            txtSeries.Location = new Point(52, 190);
            txtSeries.Name = "txtSeries";
            txtSeries.Size = new Size(309, 23);
            txtSeries.TabIndex = 6;
            // 
            // lbExercicio
            // 
            lbExercicio.AutoSize = true;
            lbExercicio.ForeColor = SystemColors.ButtonHighlight;
            lbExercicio.Location = new Point(52, 120);
            lbExercicio.Name = "lbExercicio";
            lbExercicio.Size = new Size(64, 15);
            lbExercicio.TabIndex = 5;
            lbExercicio.Text = "EXERCÍCIO";
            // 
            // txtExercicio
            // 
            txtExercicio.Location = new Point(52, 138);
            txtExercicio.Name = "txtExercicio";
            txtExercicio.Size = new Size(309, 23);
            txtExercicio.TabIndex = 4;
            // 
            // cmbTreino
            // 
            cmbTreino.FormattingEnabled = true;
            cmbTreino.Items.AddRange(new object[] { "HIPERTROFÍA", "INICIANTE", "INTENSO", "PERCA DE PESO" });
            cmbTreino.Location = new Point(52, 90);
            cmbTreino.Name = "cmbTreino";
            cmbTreino.Size = new Size(121, 23);
            cmbTreino.TabIndex = 3;
            // 
            // dgv_tabela
            // 
            dgv_tabela.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_tabela.Columns.AddRange(new DataGridViewColumn[] { dias, colunaAparelho, colunaSerie, colunaRep });
            dgv_tabela.Location = new Point(520, 56);
            dgv_tabela.Name = "dgv_tabela";
            dgv_tabela.RowHeadersWidth = 51;
            dgv_tabela.Size = new Size(480, 251);
            dgv_tabela.TabIndex = 0;
            // 
            // dias
            // 
            dias.HeaderText = "Dias";
            dias.MinimumWidth = 6;
            dias.Name = "dias";
            dias.Width = 125;
            // 
            // colunaAparelho
            // 
            colunaAparelho.HeaderText = "Exercício";
            colunaAparelho.MinimumWidth = 6;
            colunaAparelho.Name = "colunaAparelho";
            colunaAparelho.Width = 125;
            // 
            // colunaSerie
            // 
            colunaSerie.HeaderText = "Séries";
            colunaSerie.MinimumWidth = 6;
            colunaSerie.Name = "colunaSerie";
            colunaSerie.Width = 125;
            // 
            // colunaRep
            // 
            colunaRep.HeaderText = "Repetições";
            colunaRep.MinimumWidth = 6;
            colunaRep.Name = "colunaRep";
            colunaRep.Width = 125;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "TEXTO REGISTRO TREINO FITSYNC.png");
            // 
            // tela_cadastroaluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 0);
            ClientSize = new Size(1058, 398);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "tela_cadastroaluno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CADASTRO ALUNO";
            Load += Form2_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_tabela).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private PictureBox pictureBox1;
        private Label label15;
        private Label label14;
        private TextBox txtEndereco;
        private Label label13;
        private TextBox txtBairro;
        private Label label3;
        private TextBox txtCidade;
        private Label label2;
        private TextBox txtEmail;
        private Label label1;
        private Label label12;
        private MaskedTextBox maskedTextBox2;
        private Label label11;
        private MaskedTextBox mtbRegistro;
        private Label label10;
        private ComboBox cmbStatus;
        private Label label9;
        private TextBox txtGenero;
        private Label label8;
        private TextBox txtRG;
        private Label label7;
        private TextBox txtCPF;
        private Button btn_voltarLogin;
        private TextBox txtPeso;
        private Label label6;
        private MaskedTextBox txtTelefone;
        private Label label5;
        private TextBox txtNome;
        private Label label4;
        private Label label16;
        private TabPage tabPage2;
        private Label lbRepet;
        private TextBox txtRepet;
        private Label lbSeries;
        private TextBox txtSeries;
        private Label lbExercicio;
        private TextBox txtExercicio;
        private ComboBox cmbTreino;
        private DataGridView dgv_tabela;
        private MaskedTextBox mtbContato;
        private TextBox txtCEP;
        private Label label17;
        private MaskedTextBox mtbNascimento;
        private ImageList imageList1;
        private PictureBox pictureBox3;
        private Label label19;
        private Label label18;
        private ComboBox cmbDias;
        private PictureBox pictureBox2;
        private DataGridViewTextBoxColumn dias;
        private DataGridViewTextBoxColumn colunaAparelho;
        private DataGridViewTextBoxColumn colunaSerie;
        private DataGridViewTextBoxColumn colunaRep;
        private Button enviar_whatsapp;
        private Button btn_cadastrar;
        private Button btn_adicionarnalista;
    }
}