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
            // codgido para verificar se as informações estão completas e se não estão (NÃO ALTERAR)
            var camposInvalidos = new List<string>();

            // Verificação do campo obrigatório
            if (string.IsNullOrWhiteSpace(lbl_aluno.Text))
                camposInvalidos.Add("Verifique se todas as informações necessárias estão preenchidas.");

            // Se houver erros, exibe alerta e encerra
            if (camposInvalidos.Any())
            {
                string mensagem = "ALERTA:\n- " + string.Join("\n- ", camposInvalidos);
                MessageBox.Show(mensagem, "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Se passou na validação, exibe mensagem de sucesso
            MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Aqui você pode seguir com a lógica de cadastro (abrir tela, salvar no banco, etc.)
            tela_cadastroaluno interfaceForm = new tela_cadastroaluno();
            interfaceForm.Show();
            this.Hide();
        }

        private void enviar_whatsapp_Click(object sender, EventArgs e)
        {
            //BOTÃO DO WHATSAPP (TERMINO DE CODAR QUANDO O BOTÃO DE CADASTRAR O TREINO NO DATAVIEW ESTIVER PRONTO
            string nomeCliente = lbl_aluno.Text.Trim();
            string numeroComMascara = tele_aluno.Text;

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

            foreach (DataGridViewRow row in dtv_visualizartreino.Rows)
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

        }
    }
}

    

