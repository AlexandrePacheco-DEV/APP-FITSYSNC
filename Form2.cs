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
using static System.Windows.Forms.LinkLabel;

namespace APP_FITSYNC
{

    public partial class tela_cadastroaluno : Form
    {
        private string caminhoCsv = "C:\\Users\\Alexandre Pacheco\\Documents\\dadosFitsysnc";
        

        public static List<Aluno> ListaAlunos = new List<Aluno>();
        private Aluno aluno;

        public tela_cadastroaluno()
        {
            InitializeComponent();
            // Define caminho seguro no "Meus Documentos"
            caminhoCsv = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "dadosFitsync");
            

            // Garante que a pasta existe
            if (!Directory.Exists(caminhoCsv))
            {
                Directory.CreateDirectory(caminhoCsv);

            }

            
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

        private void aLUNOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //tela_buscaaluno interfaceForm = new tela_buscaaluno();
            //interfaceForm.Show();
            //this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_adicionarnalista_Click(object sender, EventArgs e)
        {
            // Adiciona informações na tabela
            dgv_tabela.Rows.Add(
                cmbDias.SelectedItem?.ToString() ?? "",
                txtExercicio.Text,
                txtSeries.Text,
                txtRepet.Text
                );
            // Limpa os campos após adicionar
            txtExercicio.Clear();
            txtSeries.Clear();
            txtRepet.Clear();
        }

        private void btn_cadastrar_Click_1(object sender, EventArgs e)
        {
            var camposObrigatorios = new Dictionary<string, Control>
    {
        { "Nome", txtNome },
        { "Telefone", txtTelefone },
        { "CPF", txtCPF },
        { "RG", txtRG },
        { "Status", cmbStatus },
        { "Peso", txtPeso },
        { "Gênero", txtGenero }
    };

            // Validação dos campos obrigatórios
            foreach (var campo in camposObrigatorios)
            {
                if (campo.Value is ComboBox cb)
                {
                    if (cb.SelectedItem == null)
                    {
                        MessageBox.Show($"Por favor, selecione o campo {campo.Key}.", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cb.Focus();
                        return;
                    }
                }
                else if (string.IsNullOrWhiteSpace(campo.Value.Text))
                {
                    MessageBox.Show($"Por favor, preencha o campo {campo.Key}.", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    campo.Value.Focus();
                    return;
                }
            }

            // Criação do objeto aluno
            var aluno = new Aluno
            {
                Nome = txtNome.Text.Trim(),
                Telefone = txtTelefone.Text.Trim(),
                CPF = txtCPF.Text.Trim(),
                RG = txtRG.Text.Trim(),
                Status = cmbStatus.SelectedItem?.ToString() ?? "",
                Endereco = txtEndereco.Text.Trim(),
                Bairro = txtBairro.Text.Trim(),
                Cidade = txtCidade.Text.Trim(),
                CEP = txtCEP.Text.Trim(),
                Peso = txtPeso.Text.Trim(),
                Genero = txtGenero.Text.Trim(),
                Nascimento = mtbNascimento.Text.Trim(),
                Registro = mtbRegistro.Text.Trim(),
                Contato = mtbContato.Text.Trim(),
                Email = txtEmail.Text.Trim()
            };

            // Adiciona à lista em memória
            ListaAlunos.Add(aluno);

            // Pasta onde os arquivos serão salvos
            string pastaCsv = @"C:\Users\Alexandre Pacheco\Documents\dadosFitsync";

            // Garante que a pasta existe
            Directory.CreateDirectory(pastaCsv);

            // Caminho do arquivo com nome do aluno
            string nomeArquivo = $"Aluno_{aluno.Nome}---{aluno.CPF}.csv";
            string caminhoCsv = Path.Combine(pastaCsv, nomeArquivo);

            try
            {
                // Começa a montar as linhas do CSV em uma lista
                List<string> linhasCsv = new List<string>();

                // Cabeçalho dos dados do aluno
                linhasCsv.Add("Nome,Telefone,CPF,Status,RG,Endereco,Bairro,Cidade,CEP,Peso,Genero,Nascimento,Registro,Contato,Email");

                // Linha com os dados do aluno
                linhasCsv.Add(string.Join(",", new string[]
                {
            aluno.Nome,
            aluno.Telefone,
            aluno.CPF,
            aluno.Status,
            aluno.RG,
            aluno.Endereco,
            aluno.Bairro,
            aluno.Cidade,
            aluno.CEP,
            aluno.Peso,
            aluno.Genero,
            aluno.Nascimento,
            aluno.Registro,
            aluno.Contato,
            aluno.Email
                }));

                // Linha em branco para separar dados do aluno da lista de treino
                linhasCsv.Add("Dia,Exercicio,Series,Repeticoes");

                // Agora, salva cada linha da grid corretamente como tabela
                foreach (DataGridViewRow row in dgv_tabela.Rows)
                {
                    if (row.IsNewRow) continue; // Ignora a linha vazia final

                    string diaTreino = row.Cells[0].Value?.ToString() ?? "";
                    string exercicio = row.Cells[1].Value?.ToString() ?? "";
                    string series = row.Cells[2].Value?.ToString() ?? "";
                    string repeticoes = row.Cells[3].Value?.ToString() ?? "";

                    linhasCsv.Add($"{diaTreino},{exercicio},{series},{repeticoes}");
                }

                // Escreve tudo no arquivo (sobrescreve se já existir)
                File.WriteAllLines(caminhoCsv, linhasCsv);

                MessageBox.Show("Aluno cadastrado e salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar no arquivo CSV:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Abre a tela de busca de alunos
            tela_buscaaluno formBusca = new tela_buscaaluno();
            formBusca.Show();
            this.Hide();
        }

        public void AtualizarListaAlunos()
        {

            var dgv = this.Controls.Find("dgvLista", true).FirstOrDefault() as DataGridView;
            if (dgv == null)
                return; // Não encontrou o controle, evita erro

            dgv.Rows.Clear();
            foreach (var aluno in tela_cadastroaluno.ListaAlunos)
            {
                dgv.Rows.Add(aluno.Nome, aluno.CPF, aluno.Status);

            }
        }
        public tela_cadastroaluno(Aluno aluno, List<string[]> listaTreino)
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
            DataTable dtTreino = new DataTable();

            InitializeComponent();

            this.aluno = aluno;

            if (listaTreino == null)
                listaTreino = new List<string[]>();

           

            // carrega a lista treino no grid
            dgv_tabela.Rows.Clear();
            foreach (var linha in listaTreino)
            {
                dgv_tabela.Rows.Add(linha);
            }


        }

        public tela_cadastroaluno(Aluno aluno)
        {
            this.aluno = aluno;
        }

        private void voltarpara_busca_Click(object sender, EventArgs e)
        {
            //botão para voltar para o 
            tela_buscaaluno interLoginForm = new tela_buscaaluno();
            interLoginForm.Show();
            this.Hide();
        }

        private void btn_enviartreinoWhat_Click(object sender, EventArgs e)
        {
             //BOTÃO DO WHATSAPP 

            string nomeCliente = txtNome.Text.Trim();
            string numeroComMascara = txtTelefone.Text;

            // vai tirar tudo que não for numero de telefone
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

            //  mensagem whatsapp
            StringBuilder mensagem = new StringBuilder();
            mensagem.AppendLine($"🏋️‍♂️ *Olá {nomeCliente}! Seu plano de treino semanal está pronto, confira!* 💪");

            string ultimoDia = "";

            foreach (DataGridViewRow row in dgv_tabela.Rows)
            {
                if (row.IsNewRow) continue;

                // Usa índice das colunas
                string dia = row.Cells[0]?.Value?.ToString()?.Trim() ?? "";
                string aparelho = row.Cells[1]?.Value?.ToString()?.Trim() ?? "";
                string serie = row.Cells[2]?.Value?.ToString()?.Trim() ?? "";
                string repeticao = row.Cells[3]?.Value?.ToString()?.Trim() ?? "";

                // Adiciona o cabeçalho do dia quando muda
                if (!string.IsNullOrWhiteSpace(dia) && dia != ultimoDia)
                {
                    mensagem.AppendLine($"\n📅 *{dia}*");
                    ultimoDia = dia;
                }

                // Adiciona o exercício formatado
                mensagem.AppendLine($"• {aparelho} — {serie}x{repeticao}");
            }

            mensagem.AppendLine("\n🤝 Em caso de dúvidas, consulte os professores disponíveis!.");

            // Codifica a mensagem para URL
            string mensagemFinal = Uri.EscapeDataString(mensagem.ToString());

            // Monta a URL do WhatsApp
            string url = $"https://wa.me/55{numero}?text={mensagemFinal}";

            // Abre no navegador padrão
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }
    }
    public class Aluno
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Status { get; set; }

        public string CPF { get; set; }
        public string RG { get; set;}
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

     
    }

}

    

