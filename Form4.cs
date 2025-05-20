using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_FITSYNC
{
    public partial class tela_buscaaluno : Form
    {
        public tela_buscaaluno()
        {
            InitializeComponent();
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
        public void AdicionarAlunoNaLista(string nome, string telefone, string status)
        {
            dgvLista.Rows.Add(nome, telefone, status);
        }
    }
}
