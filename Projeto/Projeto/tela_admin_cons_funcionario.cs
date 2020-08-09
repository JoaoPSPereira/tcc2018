using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Projeto
{
    public partial class tela_admin_cons_funcionario : Form
    {
        public tela_admin_cons_funcionario()
        {
            InitializeComponent();
        }

        private void Refresh()
        {
            try
            {
                var db = new DataBase(); //Abre conexão com o BD

                //Comando sql
                String _sql = "SELECT tag_pessoa AS TAG, nome_pessoa AS Nome, cpf_pessoa AS CPF, rg_pessoa AS RG, cargo_pessoa as Cargo, ativo_pessoa as Ativo FROM pessoa WHERE ativo_pessoa = 'S' LIMIT 30";

                //Define os dados que serão mostrados na tabela
                //O método ExecutarSelect retorna um objeto do tipo DataTable 
                dgv.DataSource = db.ExecutarSelect(_sql);

                db.Close(); //Fecha conexão com BD
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void tela_admin_cons_funcionario_Load(object sender, EventArgs e)
        {
            /* 
            Quando carregar a tela, a tabela de dados será preenchida 
            com os últimos 30 funcionários cadastrados. 
            */
            this.Refresh();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            String _texto_busca = txt_busca.Text.Trim(); //Pega o texto da txt_busca

            //Comandos SQL
            String _sql1 = $"SELECT tag_pessoa AS TAG, nome_pessoa AS Nome, cpf_pessoa AS CPF, rg_pessoa AS RG, cargo_pessoa as Cargo, ativo_pessoa as Ativo FROM pessoa WHERE nome_pessoa like '%{_texto_busca}%' and ativo_pessoa = 'S'";
            String _sql2 = $"SELECT tag_pessoa AS TAG, nome_pessoa AS Nome, cpf_pessoa AS CPF, rg_pessoa AS RG, cargo_pessoa as Cargo, ativo_pessoa as Ativo FROM pessoa WHERE cpf_pessoa like '%{_texto_busca}%' and ativo_pessoa = 'S'";

            
            try
            {
                if (_texto_busca != "")
                {
                    var db = new DataBase(); //Abre conexão com o BD

                    if (rbt_nome.Checked == true) //Se o radio button rbt_nome estiver marcado
                    {
                        dgv.DataSource = db.ExecutarSelect(_sql1);
                    }

                    if (rbt_cpf.Checked == true) //Se o radio button rbt_cpf estiver marcado
                    {
                        dgv.DataSource = db.ExecutarSelect(_sql2);
                    }

                    lbl_busca.Text = _texto_busca; //Mostra o parametro da pesquisa na label lbl_busca

                    db.Close(); //Fecha conexão com BD
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
                
        }

        private void rbt_nome_Click(object sender, EventArgs e)
        {
            txt_busca.MaxLength = 50;
        }

        private void rbt_cpf_Click(object sender, EventArgs e)
        {
            txt_busca.MaxLength = 14;
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            var _linha = dgv.CurrentRow.Index; //Pega a linha selecionada da tabela
            var _tag = dgv[0, _linha].Value.ToString(); //Pega a tag da pessoa na linha selecionada
            var _nome = dgv[1, _linha].Value.ToString(); //Pega o nome da pessoa na linha selecionada
           
            var _sqlPessoa = $"UPDATE pessoa SET ativo_pessoa = 'N' WHERE tag_pessoa = '{_tag}'";
            

            var db = new DataBase();

            var dialogo = MessageBox.Show($"Você tem certeza de que quer excluir {_nome}? TAG {_tag}", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            try
            {
                if (dialogo == DialogResult.Yes)
                {
                    db.ExecutarDelete(_sqlPessoa);

                    dgv.Rows.RemoveAt(_linha);
                    MessageBox.Show("Excluido com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                db.Close();
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            var _linha = dgv.CurrentRow.Index; //Pega a linha selecionada da tabela
            var _tag = dgv[0, _linha].Value.ToString(); //Pega a tag da pessoa na linha selecionada
            var _nome = dgv[1, _linha].Value.ToString(); //Pega o nome da pessoa na linha selecionada
            var _cpf = dgv[2, _linha].Value.ToString();
            var _rg = dgv[3, _linha].Value.ToString();
            var _cargo = dgv[4, _linha].Value.ToString();
            var _ativo = dgv[5, _linha].Value.ToString();

            try
            {
                var janela = new tela_admin_alterar_funcionario();
                
                janela._tag = _tag;
                janela._nome = _nome;
                janela._cpf = _cpf;
                janela._rg = _rg;
                janela._cargo = _cargo;
                janela._ativo = _ativo;

                janela.Show();
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();

        }

        private void btn_recarregar_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
