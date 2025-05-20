using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace APP_FITSYNC
{
    public partial class tela_cadastroaluno : Form
    {
        public static List<Aluno> ListaAlunos = new List<Aluno>();
        public tela_cadastroaluno()
        {
            InitializeComponent();
          

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        // whatsApp para ajudar usuário
        private void eNTREEMCONTATOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string link = "https://wa.me/5517997878173?text=Ol%C3%A1%20Alexandre%2C%20gostaria%20de%20ajuda%20com%20o%20app%20fitsysnc\r\n";
            Process.Start(new ProcessStartInfo
            {
                FileName = link,
                UseShellExecute = true
            });
        }

        private void dt_tipotreino_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cb_mtreinos_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void lbl_aluno_TextChanged(object sender, EventArgs e)
        {

        }

        private void aLUNOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tela_buscaaluno interfaceForm = new tela_buscaaluno();
            interfaceForm.Show();
            this.Hide();
        }

        private void btn_cadastrarAluno_Click(object sender, EventArgs e)
        {
            tela_cadastroaluno interLoginForm = new tela_cadastroaluno();
            interLoginForm.Show();
            this.Hide();
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_voltarLogin_Click_1(object sender, EventArgs e)
        {
            //botão para voltar para o login
            tela_login interLoginForm = new tela_login();
            interLoginForm.Show();
            this.Hide();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            var aluno = new Aluno
            {
                Nome = txtNome.Text,
                Telefone = txtTelefone.Text,
                Status = cmbStatus.SelectedItem?.ToString() ?? ""
                // Preencha outros campos aqui, se existirem
                // Email = txtEmail.Text,
                // Endereco = txtEndereco.Text,
                // Observacoes = txtObservacoes.Text
            };

            tela_buscaaluno.ListaAlunos.Add(aluno);

            tela_buscaaluno formBusca = new tela_buscaaluno();
            formBusca.AtualizarListaAlunos();
            formBusca.Show();
            this.Hide();
        }

        private void enviar_whatsapp_Click(object sender, EventArgs e)
        {
            //BOTÃO DO WHATSAPP (TERMINO DE CODAR QUANDO O BOTÃO DE CADASTRAR O TREINO NO DATAVIEW ESTIVER PRONTO
            string nomeCliente = txtNome.Text.Trim();
            string numeroComMascara = txtTelefone.Text;

            // Remove tudo que não for número do telefone
            string numero = Regex.Replace(numeroComMascara, "[^0-9]", "");

            // Validação básica
            if (string.IsNullOrEmpty(nomeCliente))
            {
                MessageBox.Show("Preencha o nome do aluno.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(numero) || numero.Length < 10)
            {
                MessageBox.Show("Digite um número de telefone válido com DDD.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Começa a montar a mensagem
            StringBuilder mensagem = new StringBuilder();
            mensagem.AppendLine($"🏋️‍♂️ *Olá {nomeCliente}! Seu plano de treino semanal está pronto!* 💪\n");

            string ultimoDia = "";

            foreach (DataGridViewRow row in dgv_tabela.Rows)
            {
                if (row.IsNewRow) continue;

                string dia = row.Cells["coluna_dias"]?.Value?.ToString()?.Trim() ?? "";
                string aparelho = row.Cells["colunaAparelho"]?.Value?.ToString()?.Trim() ?? "";
                string serie = row.Cells["colunaSerie"]?.Value?.ToString()?.Trim() ?? "";
                string repeticao = row.Cells["colunaRep"]?.Value?.ToString()?.Trim() ?? "";

                // Adiciona o cabeçalho do dia quando muda
                if (!string.IsNullOrWhiteSpace(dia) && dia != ultimoDia)
                {
                    mensagem.AppendLine($"\n📅 *{dia}*");
                    ultimoDia = dia;
                }

                // Adiciona o exercício formatado
                mensagem.AppendLine($"• {aparelho} — {serie}x{repeticao}");
            }

            mensagem.AppendLine("\n🤝 Qualquer dúvida, me chama aqui mesmo!");

            // Codifica a mensagem para URL
            string mensagemFinal = Uri.EscapeDataString(mensagem.ToString());

            // Monta a URL do WhatsApp
            string url = $"https://wa.me/55{numero}?text={mensagemFinal}";

            // Abre no navegador padrão
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void btn_adicionarnalista_Click(object sender, EventArgs e)
        {
            // Adiciona uma nova linha na dgv_tabela com os valores dos TextBox
            dgv_tabela.Rows.Add(
                cmbDias.SelectedItem?.ToString() ?? "",
                txtExercicio.Text,
                txtSeries.Text,
                txtRepet.Text
                );
            // Limpa os campos após adicionar (opcional)
            txtExercicio.Clear();
            txtSeries.Clear();
            txtRepet.Clear();
        }

        private void btn_cadastrar_Click_1(object sender, EventArgs e)
        {

        }
        public void AtualizarListaAlunos()
        {
            // Procura o controle DataGridView chamado "dgvLista" no formulário atual
            var dgv = this.Controls.Find("dgvLista", true).FirstOrDefault() as DataGridView;
            if (dgv == null)
                return; // Não encontrou o controle, evita erro

            dgv.Rows.Clear();
            foreach (var aluno in ListaAlunos)
            {
                dgv.Rows.Add(aluno.Nome, aluno.Telefone, aluno.Status);
                // Adicione outros campos se necessário
            }
        }
        public tela_cadastroaluno(Aluno aluno)
        {
            InitializeComponent();

            // Preenche os campos com os dados do aluno
            txtNome.Text = aluno.Nome;
            txtTelefone.Text = aluno.Telefone;
            cmbStatus.SelectedItem = aluno.Status;
            txtCPF.Text = aluno.CPF;
            txtRG.Text = aluno.RG;
            txtEndereco.Text = aluno.Endereco;
            txtBairro.Text = aluno.Bairro;
            txtCidade.Text = aluno.Cidade;
            txtCEP.Text = aluno.CEP;
            txtPeso.Text = aluno.Peso;
            txtGenero.Text = aluno.Genero;
            mtbContato.Text = aluno.Contato;
            mtbNascimento.Text = aluno.Nascimento;
            mtbRegistro.Text = aluno.Registro;
            txtEmail.Text = aluno.Email;
            // Adicione outros campos conforme necessário, por exemplo:


            // Torna os campos não editáveis
            txtNome.ReadOnly = true;
            txtTelefone.ReadOnly = true;
            cmbStatus.Enabled = false;
            txtCPF.ReadOnly = true;
            txtRG.ReadOnly = true;
            txtEndereco.ReadOnly = true;
            mtbNascimento.ReadOnly = true;
            mtbRegistro.ReadOnly = true;
            txtPeso.ReadOnly = true;
            txtGenero.ReadOnly = true;
            txtCEP.ReadOnly = true;
            txtBairro.ReadOnly = true;
            txtCidade.ReadOnly = true;
            txtEndereco.ReadOnly = true;
            mtbContato.ReadOnly = true;
            txtEmail.ReadOnly = true;
            // Se houver outros campos, preencha e desabilite também
            // txtEmail.Text = aluno.Email;
            // txtEmail.ReadOnly = true;
        }
    }
    public class Aluno
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Status { get; set; }

        public string CPF { get; set; }
        public string RG { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
        public string Peso { get; set; }
        public string Genero { get; set; }
        public string Contato { get; set; }
        public DateTime DataRegistro { get; set; }
        public DateTime ProximaAtualizacao { get; set; }
        public string Nascimento { get; set; }
        public string Registro { get; set; }
        public string Email { get; set; }

        // Adicione outros campos conforme necessário, por exemplo:
        // public string Email { get; set; }
        // public string Endereco { get; set; }
        // public string Observacoes { get; set; }
    }
}

    

