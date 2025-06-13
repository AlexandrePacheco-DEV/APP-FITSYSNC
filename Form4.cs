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
using static APP_FITSYNC.Class1;

namespace APP_FITSYNC
{
    public partial class tela_buscaaluno : Form
    {
        private List<string[]> listaTreino;

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

                    // cabeçalho 
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

                           
                            tela_cadastroaluno.ListaAlunos.Add(aluno);

                            // Adiciona ao DataGridView
                            dgvLista.Rows.Add(aluno.Nome, aluno.CPF, aluno.Telefone);
                            
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


        private void btn_desativarAluno_Click(object sender, EventArgs e)

        {
            if (dgvLista.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecione um aluno para desativar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nomeSelecionado = dgvLista.SelectedRows[0].Cells[0].Value.ToString(); // Nome
            string cpfSelecionado = dgvLista.SelectedRows[0].Cells[1].Value.ToString();  // CPF

            DialogResult result = MessageBox.Show($"Tem certeza que deseja desativar o aluno {nomeSelecionado}?",
                                                  "Confirmação",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            dgvLista.Rows.RemoveAt(dgvLista.SelectedRows[0].Index);

            var alunoRemover = tela_cadastroaluno.ListaAlunos.FirstOrDefault(a => a.CPF == cpfSelecionado);
            if (alunoRemover != null)
            {
                tela_cadastroaluno.ListaAlunos.Remove(alunoRemover);
            }

            try
            {
                string pastaCsv = @"C:\Users\Alexandre Pacheco\Documents\dadosFitsync";
                string nomeArquivo = $"Aluno_{nomeSelecionado}---{cpfSelecionado}.csv"; // Corrigido
                string caminhoCsv = Path.Combine(pastaCsv, nomeArquivo);

                if (File.Exists(caminhoCsv))
                {
                    File.Delete(caminhoCsv);
                    MessageBox.Show("Aluno desativado e arquivo removido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                AtualizarListaAlunos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir o arquivo do aluno: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tela_buscaaluno_Load(object sender, EventArgs e)
        {

        }

        private void btn_editaraluno_Click(object sender, EventArgs e)
        {
            if (dgvLista.SelectedRows.Count == 0)
    {
        MessageBox.Show("Por favor, selecione um aluno para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    }
            // Pasta onde os arquivos serão salvos
            string pastaCsv = @"C:\Users\Alexandre Pacheco\Documents\dadosFitsync";
            Directory.CreateDirectory(pastaCsv);
            // Pega nome e CPF selecionados
            string nomeSelecionado = dgvLista.SelectedRows[0].Cells[0].Value.ToString();
            string cpfSelecionado = dgvLista.SelectedRows[0].Cells[1].Value.ToString();

            // caminho do arquivo
            string nomeArquivo = $"Aluno_{nomeSelecionado}---{cpfSelecionado}.csv";
            string caminhoArquivo = Path.Combine(pastaCsv, nomeArquivo);

            if (!File.Exists(caminhoArquivo))
    {
        MessageBox.Show("Arquivo do aluno não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
    }

    try
    {
        string[] linhas = File.ReadAllLines(caminhoArquivo);

        if (linhas.Length < 2)
        {
            MessageBox.Show("Arquivo de aluno inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // dados do aluno
        string[] camposAluno = linhas[1].Split(',');

        var aluno = new Aluno
        {
            Nome = camposAluno[0],
            Telefone = camposAluno[1],
            CPF = camposAluno[2],
            Status = camposAluno[3],
            RG = camposAluno[4],
            Endereco = camposAluno[5],
            Bairro = camposAluno[6],
            Cidade = camposAluno[7],
            CEP = camposAluno[8],
            Peso = camposAluno[9],
            Genero = camposAluno[10],
            Nascimento = camposAluno[11],
            Registro = camposAluno[12],
            Contato = camposAluno[13],
            Email = camposAluno.Length > 14 ? camposAluno[14] : ""
        };

                tela_cadastroaluno formCadastro = new tela_cadastroaluno(aluno, listaTreino);
                formCadastro.ShowDialog();

                DataGridView dgvTabela = formCadastro.Controls.Find("dgv_tabela", true).FirstOrDefault() as DataGridView;
        if (dgvTabela != null)
        {
            dgvTabela.Rows.Clear();

            bool lendoTreino = false;

            for (int i = 2; i < linhas.Length; i++)
            {
                string linha = linhas[i].Trim();

                // Detecta cabeçalho do treino
                if (linha.StartsWith("Dia,Exercicio"))
                {
                    lendoTreino = true;
                    continue;
                }

                if (lendoTreino && !string.IsNullOrWhiteSpace(linha))
                {
                    string[] partes = linha.Split(',');

                    if (partes.Length >= 4)
                    {
                        string dia = partes[0];
                        string exercicio = partes[1];
                        string serie = partes[2];
                        string repeticao = partes[3];

                        dgvTabela.Rows.Add(dia, exercicio, serie, repeticao);
                    }
                }
            }
        }

        // Mostra a tela de edição
        formCadastro.Show();
        this.Hide();
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Erro ao editar aluno: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
    }
}
        
    

