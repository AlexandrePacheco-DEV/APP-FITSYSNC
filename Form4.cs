using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace APP_FITSYNC
{
    public partial class tela_buscaaluno : Form
    {


        // Removed duplicate declaration of dgvLista

        public tela_buscaaluno()
        {
            InitializeComponent();
            AtualizarListaAlunos();
            CarregarAlunosSalvos();

        }
        private void CarregarAlunosSalvos()
        {
            string pastaCsv = @"C:\Users\Alexandre Pacheco\Documents\dadosFitsync";

            // Garante que a pasta existe
            Directory.CreateDirectory(pastaCsv);

            // Limpa a lista e o DataGridView
            tela_cadastroaluno.ListaAlunos.Clear();
            dgvLista.Rows.Clear();

            // Pega todos os arquivos CSV de alunos
            string[] arquivos = Directory.GetFiles(pastaCsv, "Aluno_*.csv");

            foreach (string arquivo in arquivos)
            {
                try
                {
                    string[] linhas = File.ReadAllLines(arquivo);

                    // Pula o cabeçalho e lê as linhas de dados
                    for (int i = 1; i < linhas.Length; i++)
                    {
                        string[] campos = linhas[i].Split(',');

                        if (campos.Length >= 14)
                        {
                            var aluno = new Aluno
                            {
                                Nome = campos[0],
                                Telefone = campos[1],
                                CPF = campos[2],
                                Status = campos[3],
                                RG = campos[4],
                                Endereco = campos[5],
                                Bairro = campos[6],
                                Cidade = campos[7],
                                CEP = campos[8],
                                Peso = campos[9],
                                Genero = campos[10],
                                Nascimento = campos[11],
                                Registro = campos[12],
                                Contato = campos[13],
                                Email = campos.Length > 14 ? campos[14] : ""
                            };

                            // Adiciona à lista em memória
                            tela_cadastroaluno.ListaAlunos.Add(aluno);

                            // Adiciona ao DataGridView
                            dgvLista.Rows.Add(aluno.Nome, aluno.Telefone, aluno.CPF, aluno.Status);
                            // ➡️ Ajuste para adicionar outras colunas conforme tiver no seu DataGridView
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar o arquivo {Path.GetFileName(arquivo)}: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string ObterCaminhoCsv()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "dadosFitsync", "dados.csv");
        }
        private void btn_voltarBusca_Click(object sender, EventArgs e)
        {
            tela_login interfaceForm = new tela_login();
            interfaceForm.Show();
            this.Hide();
        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // Add this method to the `tela_buscaaluno` class
        public void AtualizarListaAlunos()
        {
            dgvLista.Rows.Clear();
            foreach (var aluno in tela_cadastroaluno.ListaAlunos)
            {
                dgvLista.Rows.Add(aluno.Nome, aluno.CPF, aluno.Telefone);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim().ToLower();
            dgvLista.Rows.Clear();

            foreach (var aluno in tela_cadastroaluno.ListaAlunos)
            {
                if (aluno.Nome.ToLower().Contains(filtro) ||
                    aluno.CPF.ToLower().Contains(filtro) ||
                    (aluno.Telefone ?? "").ToLower().Contains(filtro))
                {
                    dgvLista.Rows.Add(aluno.Nome, aluno.CPF, aluno.Telefone);
                }
            }
            
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            Form tela_cadastroaluno = new tela_cadastroaluno();
            tela_cadastroaluno.Show();
        }

        private void btn_buscaAluno_Click(object sender, EventArgs e)
        {
            string termoBusca = txtBuscar.Text.Trim().ToLower();
            string caminhoCsv = ObterCaminhoCsv();

            if (!File.Exists(caminhoCsv))
            {
                MessageBox.Show("Aluno não encontrado.");
                return;
            }

            DataTable tabela = new DataTable();
            tabela.Columns.Add("Nome");
            tabela.Columns.Add("Telefone");
            tabela.Columns.Add("CPF");
            tabela.Columns.Add("Status");

            var linhas = File.ReadAllLines(caminhoCsv)
                             .Skip(1)
                             .Select(l => l.Split(','))
                             .Where(d => d.Length >= 4)
                             .GroupBy(d => d[2]) // Agrupa por CPF
                             .Select(g => g.First());

            foreach (var dados in linhas)
            {
                string nome = dados[0].ToLower();
                if (nome.Contains(termoBusca))
                {
                    tabela.Rows.Add(dados[0], dados[1], dados[2], dados[3]);
                }
            }

            dgvLista.DataSource = tabela;
        }

        private void btn_desativarAluno_Click(object sender, EventArgs e)

        {
            if (dgvLista.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecione um aluno para desativar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Supondo que o Nome está na coluna 0 e CPF na coluna 2 (ajuste conforme necessário)
            string nomeSelecionado = dgvLista.SelectedRows[0].Cells[0].Value.ToString();
            string cpfSelecionado = dgvLista.SelectedRows[0].Cells[2].Value.ToString();

            // Confirmação
            DialogResult result = MessageBox.Show($"Tem certeza que deseja desativar o aluno {nomeSelecionado}?",
                                                  "Confirmação",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;  // Cancelado
            }

            // Remove do DataGridView
            dgvLista.Rows.RemoveAt(dgvLista.SelectedRows[0].Index);

            // Remove da ListaAlunos
            var alunoRemover = tela_cadastroaluno.ListaAlunos.FirstOrDefault(a => a.CPF == cpfSelecionado);
            if (alunoRemover != null)
            {
                tela_cadastroaluno.ListaAlunos.Remove(alunoRemover);
            }

            try
            {
                // Monta o caminho do arquivo do aluno
                string pastaCsv = @"C:\Users\Alexandre Pacheco\Documents\dadosFitsync";
                string nomeArquivo = $"Aluno_{nomeSelecionado.Replace(" ", "_")}.csv";
                string caminhoArquivo = Path.Combine(pastaCsv, nomeArquivo);

                // Verifica se o arquivo existe e apaga
                if (File.Exists(caminhoArquivo))
                {
                    File.Delete(caminhoArquivo);
                }
                else
                {
                    MessageBox.Show("Arquivo do aluno não encontrado. Pode já ter sido removido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                MessageBox.Show("Aluno desativado e arquivo removido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Atualiza DataGridView
                AtualizarListaAlunos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir o arquivo do aluno: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
        
    

