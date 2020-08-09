using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Projeto
{
    public partial class tela_admin : Form
    {
        public String tag_admin;
        private String nome_admin;
        

        public tela_admin()
        {
            InitializeComponent();
        }

        private void menuitem_sair_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();

        }

        private void menuitem_cadastrar_funcionario_Click(object sender, EventArgs e)
        {
            var janela = new tela_admin_cad_funcionario();
            janela.Show();
        }

        private void tela_admin_Load(object sender, EventArgs e)
        {
            var db = new DataBase();

            var comando = $"select * from pessoa where tag_pessoa={tag_admin}";

            var dataReader = db.ExecutarReader(comando);

            if (dataReader.Read())
            {
                String[] vetor = new String[6];
                vetor[0] = dataReader.GetString("tag_pessoa").ToString();
                nome_admin = vetor[1] = dataReader.GetString("nome_pessoa").ToString();
                vetor[2] = dataReader.GetString("cpf_pessoa").ToString();
                vetor[3] = dataReader.GetString("rg_pessoa").ToString();
                

                lbl_nome.Text = nome_admin;

            }
            else
            {
                MessageBox.Show("DataReader Falhou");
            }

            dataReader.Dispose();
            dataReader.Close();

            db.Close();

        }

        private void tela_admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();

        }

        private void menuitem_consultar_funcionario_Click(object sender, EventArgs e)
        {
            var janela = new tela_admin_cons_funcionario();
            janela.Show();
        }

        private void menuitem_cadastrar_medicamento_Click(object sender, EventArgs e)
        {
            var janela = new tela_admin_cad_med();
            janela.Show();
        }

        private void menuitem_consultar_medicamento_Click(object sender, EventArgs e)
        {
            var janela = new tela_admin_cons_med();

            janela.Show();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var janela = new tela_admin_cons_vendas();

            janela.Show();
        }

        private void entradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var janela = new tela_admin_cons_entradas();

            janela.Show();
        }
    }
}
