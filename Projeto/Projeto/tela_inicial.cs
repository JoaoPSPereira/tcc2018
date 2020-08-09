using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class tela_inicial : Form
    {
        public tela_inicial()
        {
            InitializeComponent();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            var janela = new tela_login_admin();
            
            janela.Show();

    
        }

        private void tela_inicial_FormClosing(object sender, FormClosingEventArgs e)
        {


        }

        private void tela_inicial_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var janela = new tela_add_med_estoque();

            janela.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var janela = new tela_tag_confirmation();

            janela.SetNewForm("tela_painel_saida");

            janela.Show();
        }
    }
}
