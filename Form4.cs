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
            tela_cadastroaluno interfaceForm = new tela_cadastroaluno();
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
    }
}