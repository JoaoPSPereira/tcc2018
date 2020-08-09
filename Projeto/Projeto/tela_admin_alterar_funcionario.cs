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
    public partial class tela_admin_alterar_funcionario : Form
    {
        public String _tag;
        public String _nome;
        public String _cpf;
        public String _rg;
        public String _cargo;
        public String _ativo;
        private String _senha;
        private String _login;

        public tela_admin_alterar_funcionario()
        {
            InitializeComponent();
        }

        private void gbx_endereco_Enter(object sender, EventArgs e)
        {

        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {

        }

        private void tela_admin_alterar_funcionario_Load(object sender, EventArgs e)
        {
            

            var db = new DataBase();
            MySqlDataReader dataReader;

            try
            {
                lbl_tag.Text = _tag;
                txt_nome.Text = _nome;
                txt_cpf.Text = _cpf;
                txt_rg.Text = _rg;

                if (_ativo == "S")
                {
                    rbt_sim.Checked = true;
                }
                else if (_ativo == "N")
                {
                    rbt_nao.Checked = true;
                }

                if (_cargo == "Admin")
                {
                    gbx_admin.Enabled = true;
                    lbl_login.Enabled = true;
                    txt_login.Enabled = true;
                    lbl_senhaAtual.Enabled = true;
                    txt_senhaAtual.Enabled = true;
                    lbl_novasenha.Enabled = true;
                    txt_novaSenha.Enabled = true;

                    var _sql = $"SELECT login_admin, senha_admin FROM admin WHERE tag_pessoa = '{_tag}' ";

                    dataReader = db.ExecutarReader(_sql);

                    if (dataReader.Read())
                    {
                        _login = dataReader.GetString("login_admin").ToString();
                        _senha = dataReader.GetString("senha_admin").ToString();

                        txt_login.Text = _login;

                    }

                    dataReader.Dispose();
                    dataReader.Close();
                }

                
                db.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void btn_confirma_Click(object sender, EventArgs e)
        {
            var _novaTag = lbl_tag.Text.Trim();
            var _novoNome = txt_nome.Text.Trim();
            var _novoCpf = txt_cpf.Text.Trim();
            var _novoRg = txt_rg.Text.Trim();
            String _novoAtivo;

            if (rbt_sim.Checked == true)
            {
                _novoAtivo = "S";
            }
            else
            {
                _novoAtivo = "N";
            }

            var _novoLogin = txt_login.Text.Trim();
            var _senhaAtual = txt_senhaAtual.Text.Trim();
            var _novaSenha = txt_novaSenha.Text.Trim();


            String _comandoAlteraPessoa = $"UPDATE pessoa SET tag_pessoa = '{_novaTag}', nome_pessoa = '{_novoNome}', cpf_pessoa = '{_novoCpf}', rg_pessoa = '{_novoRg}', ativo_pessoa = '{_novoAtivo}' WHERE tag_pessoa = '{_tag}'";

            try
            {
                var db = new DataBase();

                if (_cargo == "Admin")
                {
                    var _senhaDB = _senha;

                    if (_senhaAtual != "")
                    {
                        if (_senhaDB == _senhaAtual)
                        {
                            var _comandoAlteraAdmin = $"UPDATE admin SET login_admin = '{_novoLogin}', senha_admin = '{_novaSenha}' WHERE tag_pessoa = '{_tag}'";

                            db.ExecutarUpdate(_comandoAlteraAdmin);

                            db.ExecutarUpdate(_comandoAlteraPessoa);

                            MessageBox.Show("Alterado com sucesso!");

                            this.Dispose();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Senha atual incorreta");

                            txt_senhaAtual.Text = "";
                            txt_novaSenha.Text = "";
                        }
                    }
                    else if(_novoLogin != _login)
                    {
                        MessageBox.Show("Se dejesa alterar apenas o Login, por favor digite a senha atual");
                        txt_senhaAtual.Focus();
                    }
                }
                else
                {
                    db.ExecutarUpdate(_comandoAlteraPessoa);
                    MessageBox.Show("Alterado com sucesso!");

                    this.Dispose();
                    this.Close();
                }

                db.Close();                
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
