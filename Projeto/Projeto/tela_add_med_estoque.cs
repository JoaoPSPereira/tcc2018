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
    public partial class tela_add_med_estoque : Form
    {
        public tela_add_med_estoque()
        {
            InitializeComponent();
        }

        private void Refresh()
        {
            try
            {
                var db = new DataBase(); //Abre conexão com o BD

                //Comando sql
                String _sql = "SELECT id_medicamento AS ID, nome_medicamento AS Nome, descricao_medicamento AS Descricao, tipo_medicamento AS Tipo, qnt_em_estoque AS 'Em estoque' FROM medicamento LIMIT 30";

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

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            String _texto_busca = txt_busca.Text.Trim(); //Pega o texto da txt_busca

            //Comandos SQL
            String _sql1 = $"SELECT id_medicamento AS ID, nome_medicamento AS Nome, descricao_medicamento AS Descricao, tipo_medicamento AS Tipo, qnt_em_estoque AS 'Em estoque' FROM medicamento WHERE nome_medicamento like '%{_texto_busca}%' and ativo_medicamento = 'S'";
            String _sql2 = $"SELECT id_medicamento AS ID, nome_medicamento AS Nome, descricao_medicamento AS Descricao, tipo_medicamento AS Tipo, qnt_em_estoque AS 'Em estoque' FROM medicamento WHERE descricao_medicamento like '%{_texto_busca}%' and ativo_medicamento = 'S'";

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

                    db.Close(); //Fecha conexão com BD
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            var _nome = txt_nome.Text.Trim();
            var _descricao = txt_descricao.Text.Trim();
            var _tipo = cbx_tipo.Text.Trim();
            var _qnt = txt_qnt.Text.Trim();
            var _conteudo = txt_conteudo.Text.Trim();
            var _medida = cbx_medida.Text.Trim();

            try
            {
                var db = new DataBase();

                var _sql = $"insert into medicamento values('','{_nome}','{_descricao}','{_tipo}',{_qnt}, {_conteudo},'{_medida}','S',0)";

                db.ExecutarInsert(_sql);

                db.Close();

                MessageBox.Show("Cadastrado com sucesso!");

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            painel.Visible = true;
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            var _linha = dgv.CurrentRow.Index; //Pega a linha selecionada da tabela
            var _id = dgv[0, _linha].Value.ToString(); //Pega o id do medicamento na linha selecionada
            var _qntEmEstoque = Int32.Parse(dgv[4, _linha].Value.ToString());
            var _qntDigitada = Int32.Parse(txt_quantidade.Text);

            var _novoEstoque = _qntEmEstoque + _qntDigitada;

            var _sql = $"UPDATE medicamento SET qnt_em_estoque = {_novoEstoque} WHERE id_medicamento = {_id}";

            try
            {
                var db = new DataBase();

                db.ExecutarUpdate(_sql);

                db.Close();
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

            txt_quantidade.Text = "";
            painel.Visible = false;
            this.Refresh();
        }

        private void tela_add_med_estoque_Load(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var _linha = dgv.CurrentRow.Index; //Pega a linha selecionada da tabela
            var _id = dgv[0, _linha].Value.ToString(); //Pega a tag da pessoa na linha selecionada
            var _sql = $"SELECT * FROM medicamento WHERE id_medicamento = {_id}";

            try
            {
                var db = new DataBase();

                var dataReader = db.ExecutarReader(_sql);

                String[] vetor = new String[9];

                if (dataReader.Read())
                {
                    vetor[0] = dataReader.GetString("id_medicamento").ToString();
                    vetor[1] = dataReader.GetString("nome_medicamento").ToString();
                    vetor[2] = dataReader.GetString("descricao_medicamento").ToString();
                    vetor[3] = dataReader.GetString("tipo_medicamento").ToString();
                    vetor[4] = dataReader.GetString("quantidade_caixa").ToString();
                    vetor[5] = dataReader.GetString("conteudo_liquido").ToString();
                    vetor[6] = dataReader.GetString("medida_conteudo").ToString();
                    vetor[7] = dataReader.GetString("ativo_medicamento").ToString();
                    vetor[8] = dataReader.GetString("qnt_em_estoque").ToString();

                    lbl_id.Text = vetor[0];
                    lbl_nome.Text = vetor[1];
                    lbl_descricao.Text = vetor[2];
                    lbl_tipo.Text = vetor[3];
                    lbl_qntCaixa.Text = vetor[4];
                    lbl_conteudo.Text = vetor[5] + " " + vetor[6];
                    lbl_qntEstoque.Text = vetor[8];

                }

                dataReader.Dispose();
                dataReader.Close();

                db.Close();

            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

            painel_detalhes.Visible = true;
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            painel_detalhes.Visible = false;
            
            lbl_id.Text = " lbl_id";
            lbl_nome.Text = " lbl_nome";
            lbl_descricao.Text = " lbl_descricao";
            lbl_tipo.Text = " lbl_tipo";
            lbl_qntCaixa.Text = " lbl_qntCaixa";
            lbl_conteudo.Text = " lbl_conteudo";
            lbl_qntEstoque.Text = " lbl_qntEstoque";

        }

        private void btn_recarregar_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_quantidade.Text = "";
            painel.Visible = false;
        }
    }
}
