using System.Diagnostics;

namespace APP_FITSYNC
{
    public partial class tela_login : Form
    {
        public tela_login()
        {
            InitializeComponent();
            this.AcceptButton = btn_acessar;
        }
        //senha e usuário de entrada para acesso a interface//
        private void btn_acessar_Click(object sender, EventArgs e)
        {
            
            string usuario_correta = "1";
            string senha_correta = "1";

            string usuario = txt_login.Text;
            string senha = txt_senha.Text;

            if (usuario == usuario_correta && senha == senha_correta)
            {
                tela_cadastroaluno interfaceForm = new tela_cadastroaluno();
                interfaceForm.Show();
                this.Hide();
               
            }
            else
            {
                MessageBox.Show("Usuário ou senha errados: Verifique e os corrija");
            }
        }
        // botão para fechar app//
        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // alinhamento de objetos quando tela maximizada
        private void tela_login_Load(object sender, EventArgs e)
        {
            int spacing = 10; // Espaço entre os botões

            // Calcula a largura total dos dois botões + espaço
            int totalWidth = btn_acessar.Width + btn_sair.Width + spacing;

            // Calcula a posição inicial para o primeiro botão (Acessar)
            int startX = (this.ClientSize.Width - totalWidth) / 2;

            // Define as posições
            btn_acessar.Left = startX;
            btn_sair.Left = btn_acessar.Right + spacing;

            // (Opcional) Alinha os dois na mesma altura
            btn_sair.Top = btn_acessar.Top;

            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ajudaWhats_Click(object sender, EventArgs e)
        {
            string link = "https://wa.me/5517997878173?text=Ol%C3%A1%20Alexandre%2C%20gostaria%20de%20ajuda%20com%20o%20app%20fitsysnc\r\n";
            Process.Start(new ProcessStartInfo
            {
                FileName = link,
                UseShellExecute = true
            });
        }

        private void lbl_parc_Click(object sender, EventArgs e)
        {

        }
    }
}
