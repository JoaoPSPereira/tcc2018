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
    public partial class tela_admin_cons_med : Form
    {
        public tela_admin_cons_med()
        {
            InitializeComponent();
        }

        private void Refresh()
        {
            try
            {
                var db = new DataBase(); //Abre conexão com o BD

                //Comando sql
                String _sql = "SELECT id_medicamento AS ID, nome_medicamento AS Nome, descricao_medicamento AS Descricao, tipo_medicamento AS Tipo, quantidade_caixa AS 'Qnt. p/ Unidade', conteudo_liquido AS 'Conteudo(mg/ml)', medida_conteudo AS Medida FROM medicamento WHERE ativo_medicamento = 'S' LIMIT 30";

                //Define os dados que serão mostrados na tabela
                //O método ExecutarSelect retorna um objeto do tipo DataTable 
                dgv.DataSource = db.ExecutarSelect(_sql);

                lbl_busca.Text = "Últimos 30 registrados";

                db.Close(); //Fecha conexão com BD
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void tela_admin_cons_med_Load(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            String _texto_busca = txt_busca.Text.Trim(); //Pega o texto da txt_busca

            //Comandos SQL
            String _sql1 = $"SELECT id_medicamento AS ID, nome_medicamento AS Nome, descricao_medicamento AS Descricao, tipo_medicamento AS Tipo, quantidade_caixa AS 'Qnt. p/ Unidade', conteudo_liquido AS 'Conteudo(mg/ml)', medida_conteudo AS Medida FROM medicamento WHERE nome_medicamento like '%{_texto_busca}%' and ativo_medicamento = 'S'";
            String _sql2 = $"SELECT id_medicamento AS ID, nome_medicamento AS Nome, descricao_medicamento AS Descricao, tipo_medicamento AS Tipo, quantidade_caixa AS 'Qnt. p/ Unidade', conteudo_liquido AS 'Conteudo(mg/ml)', medida_conteudo AS Medida FROM medicamento WHERE descricao_medicamento like '%{_texto_busca}%' and ativo_medicamento = 'S'";


            try
            {
                if (_texto_busca != "")
                {
                    var db = new DataBase(); //Abre conexão com o BD

                    if (rbt_nome.Checked == true) //Se o radio button rbt_nome estiver marcado
                    {
                        dgv.DataSource = db.ExecutarSelect(_sql1);
                    }

                    if (rbt_descricao.Checked == true) //Se o radio button rbt_cpf estiver marcado
                    {
                        dgv.DataSource = db.ExecutarSelect(_sql2);
                    }

                    lbl_busca.Text = _texto_busca; //Mostra o parametro da pesquisa na label lbl_busca

                    db.Close(); //Fecha conexão com BD
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            var _linha = dgv.CurrentRow.Index; //Pega a linha selecionada da tabela
            var _id = dgv[0, _linha].Value.ToString(); //Pega a tag da pessoa na linha selecionada
            var _nome = dgv[1, _linha].Value.ToString(); //Pega o nome da pessoa na linha selecionada

            var _sql = $"UPDATE medicamento SET ativo_medicamento = 'N' WHERE id_medicamento = '{_id}'";


            var db = new DataBase();

            var dialogo = MessageBox.Show($"Você tem certeza de que quer excluir {_nome}? ID = {_id}", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            try
            {
                if (dialogo == DialogResult.Yes)
                {
                    db.ExecutarDelete(_sql);

                    dgv.Rows.RemoveAt(_linha);
                    MessageBox.Show("Excluido com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                db.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            var _linha = dgv.CurrentRow.Index; //Pega a linha selecionada da tabela
            var _id = dgv[0, _linha].Value.ToString(); //Pega a tag da pessoa na linha selecionada
            var _nome = dgv[1, _linha].Value.ToString(); //Pega o nome da pessoa na linha selecionada
            var _descricao = dgv[2, _linha].Value.ToString();
            var _tipo = dgv[3, _linha].Value.ToString();
            var _qnt_caixa = dgv[4, _linha].Value.ToString();
            var _conteudo = dgv[5, _linha].Value.ToString();
            var _medida = dgv[6, _linha].Value.ToString();

            try
            {
                var janela = new tela_admin_alterar_med();

                janela._id = _id;
                janela._nome = _nome;
                janela._descricao = _descricao;
                janela._tipo = _tipo;
                janela._qnt_caixa = _qnt_caixa;
                janela._conteudo = _conteudo;
                janela._medida = _medida;

                janela.Show();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btn_recarregar_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
