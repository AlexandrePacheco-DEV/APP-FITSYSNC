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
                dgvLista.Rows.Add(aluno.Nome, aluno.Telefone, aluno.Status);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            var filtro = txtBuscar.Text.Trim().ToLower();
            var dgv = this.Controls.Find("dgvLista", true).FirstOrDefault() as DataGridView;
            if (dgv == null) return;

            dgv.Rows.Clear();
            foreach (var aluno in tela_cadastroaluno.ListaAlunos)
            {
                // Filtra por nome, telefone ou status
                if (aluno.Nome.ToLower().Contains(filtro) ||
                    aluno.Telefone.ToLower().Contains(filtro) ||
                    (aluno.Status ?? "").ToLower().Contains(filtro))
                {
                    dgv.Rows.Add(aluno.Nome, aluno.Telefone, aluno.Status);
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
            string caminhoCsv = "dadosFitsync.csv";

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
                             .GroupBy(d => d[2]) // Agrupar por CPF (evitar repetir treinos)
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

    }
}
