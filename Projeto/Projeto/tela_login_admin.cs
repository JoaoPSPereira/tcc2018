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
    public partial class tela_login_admin : Form
    {
        public tela_login_admin()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
  
        }

        private void btn_entrar_Click_1(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            var login = txt_login.Text;
            var senha = txt_senha.Text;
            String comando = $"select * from admin where login_admin='{login}'";
            var dataReader = db.ExecutarReader(comando);

            try
            {
         
                if (dataReader.Read())
                {
                    String[] vetor = new String[5];
                    vetor[0] = dataReader.GetString("id_admin").ToString();
                    vetor[1] = dataReader.GetString("tag_pessoa").ToString();
                    vetor[2] = dataReader.GetString("login_admin").ToString();
                    vetor[3] = dataReader.GetString("senha_admin").ToString();

                  
                    if (vetor[3].Equals(senha)) /*Se a senha digitada for igual a senha do DB
                                                referente ao login digitado*/
                    {
                        var janela = new tela_tag_confirmation();

                        janela.SetTag(vetor[1]);
                        janela.SetNewForm("tela_admin");
                                
                        janela.Show();

                        this.Dispose();
                        this.Close();
              
                    }
                    else //Se a senha não bater com a do DB
                    {
                        txt_login.Text = "";
                        txt_senha.Text = "";
                        MessageBox.Show("Senha incorreta");
                    }

                }
                else //Se o leitor falhar
                {
                    txt_login.Text = "";
                    txt_senha.Text = "";
                    MessageBox.Show("Login não encontrado");
                }

                dataReader.Dispose();
                dataReader.Close();
                db.Close(); //fecha conexao com banco de dados

            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.ToString());
            }
        }

        private void tela_login_admin_Load(object sender, EventArgs e)
        {

        }

        private void tela_login_admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();

            
            
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
