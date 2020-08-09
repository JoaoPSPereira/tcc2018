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
    public partial class tela_painel_saida : Form
    {
        public String tag_pessoa;
        public String nome_pessoa;
        public String id_entrada;

        private String[] vetor_id = new String[10];
        private String[] vetor_nome = new String[10];
        private String[] vetor_descricao = new String[10];
        private String[] vetor_tipo = new String[10];
        private String[] vetor_qnt_caixa = new String[10];
        private String[] vetor_conteudo = new String[10];
        private String[] vetor_medida = new String[10];
        private String[] vetor_qnt_selecionada = new String[10];
        private String[] vetor_qnt_estoque = new String[10];

        int indice;

        public tela_painel_saida()
        {
            InitializeComponent();
        }

        private void Refresh()
        {
            try
            {
                var db = new DataBase(); //Abre conexão com o BD

                //Comando sql
                String _sql = "SELECT id_medicamento AS ID, nome_medicamento AS Nome, descricao_medicamento AS Descricao, tipo_medicamento AS Tipo, quantidade_caixa AS 'Qnt. Caixa', conteudo_liquido AS 'Conteudo(mg/ml)', medida_conteudo AS Medida, qnt_em_estoque AS 'Qnt. Estoque' FROM medicamento WHERE ativo_medicamento = 'S' LIMIT 30";

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

        private void btn_add_Click(object sender, EventArgs e)
        {
            painel.Visible = true;      
        }

        private void tela_painel_saida_Load(object sender, EventArgs e)
        {
            indice = 0;

            this.Refresh();

            lbl_nome.Text = nome_pessoa;

            var _sqlSelectEntrada = $"SELECT MAX(id_entrada) as id_entrada FROM entrada";

            var db = new DataBase();

            var dataReader = db.ExecutarReader(_sqlSelectEntrada);

            if (dataReader.Read())
            {
                id_entrada = dataReader.GetString("id_entrada").ToString();
            }
            else
            {
                MessageBox.Show("Reader Falhou");
            }

            dataReader.Close();
            db.Close();
        }

        private void btn_compra_Click(object sender, EventArgs e)
        {
            var janela = new tela_compra();
            int cont;

            for(cont = 0; cont <= indice; cont++ )
            {           
                janela.vetor_id[cont] = vetor_id[cont];
                janela.vetor_nome[cont] = vetor_nome[cont];
                janela.vetor_descricao[cont] = vetor_descricao[cont];
                janela.vetor_tipo[cont] = vetor_tipo[cont];
                janela.vetor_qnt_caixa[cont] = vetor_qnt_caixa[cont];
                janela.vetor_conteudo[cont] = vetor_conteudo[cont];
                janela.vetor_medida[cont] = vetor_medida[cont];
                janela.vetor_qnt_selecionada[cont] = vetor_qnt_selecionada[cont];
                janela.vetor_qnt_estoque[cont] = vetor_qnt_estoque[cont];

            }

            janela.indice = indice;

            janela.tag_pessoa = tag_pessoa;
            janela.nome_pessoa = nome_pessoa;
            janela.id_entrada = id_entrada;

            janela.Show();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            String _texto_busca = txt_busca.Text.Trim(); //Pega o texto da txt_busca

            //Comandos SQL
            String _sql1 = $"SELECT id_medicamento AS ID, nome_medicamento AS Nome, descricao_medicamento AS Descricao, tipo_medicamento AS Tipo, quantidade_caixa AS 'Qnt. p/ Unidade', conteudo_liquido AS 'Conteudo(mg/ml)', medida_conteudo AS Medida, qnt_em_estoque AS 'Qnt. Estoque' FROM medicamento WHERE nome_medicamento like '%{_texto_busca}%' and ativo_medicamento = 'S'";
            String _sql2 = $"SELECT id_medicamento AS ID, nome_medicamento AS Nome, descricao_medicamento AS Descricao, tipo_medicamento AS Tipo, quantidade_caixa AS 'Qnt. p/ Unidade', conteudo_liquido AS 'Conteudo(mg/ml)', medida_conteudo AS Medida, qnt_em_estoque AS 'Qnt. Estoque' FROM medicamento WHERE descricao_medicamento like '%{_texto_busca}%' and ativo_medicamento = 'S'";


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

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            var _linha = dgv.CurrentRow.Index; //Pega a linha selecionada da tabela
            var _id = dgv[0, _linha].Value.ToString(); //Pega o id do medicamento na linha selecionada
            var _nome = dgv[1, _linha].Value.ToString(); //Pega o nome da pessoa na linha selecionada
            var _descricao = dgv[2, _linha].Value.ToString();
            var _tipo = dgv[3, _linha].Value.ToString();
            var _qnt_caixa = dgv[4, _linha].Value.ToString();
            var _conteudo = dgv[5, _linha].Value.ToString();
            var _medida = dgv[6, _linha].Value.ToString();

            var _qnt_selecionada = txt_quantidade.Text.Trim();

            var _qnt_estoque = dgv[7, _linha].Value.ToString();

            //Se a quantidade digitada for maior que a do estoque, todas as unidades no estoque seram adicionadas
            if(Int32.Parse(_qnt_selecionada) > Int32.Parse(_qnt_estoque))
            {
                _qnt_selecionada = _qnt_estoque;
                MessageBox.Show("Quantidade excedente ao estoque, todas as unidades em estoque foram adicionadas");
            }

            //Adimite o limite de 10 itens distintos pro compra
            if (indice >= 10)
            {
                MessageBox.Show("Limite da compra atingido!");
            }
            else
            {
                //estrutura de comparação para que não se possa haver itens distintos repetidos
                if (indice == 0)
                {
                    vetor_id[indice] = _id;
                    vetor_nome[indice] = _nome;
                    vetor_descricao[indice] = _descricao;
                    vetor_tipo[indice] = _tipo;
                    vetor_qnt_caixa[indice] = _qnt_caixa;
                    vetor_conteudo[indice] = _conteudo;
                    vetor_medida[indice] = _medida;
                    vetor_qnt_selecionada[indice] = _qnt_selecionada;
                    vetor_qnt_estoque[indice] = _qnt_estoque;

                    indice++;
                }
                else
                {
                    if (vetor_id[(indice - 1)] != _id)
                    {
                        vetor_id[indice] = _id;
                        vetor_nome[indice] = _nome;
                        vetor_descricao[indice] = _descricao;
                        vetor_tipo[indice] = _tipo;
                        vetor_qnt_caixa[indice] = _qnt_caixa;
                        vetor_conteudo[indice] = _conteudo;
                        vetor_medida[indice] = _medida;
                        vetor_qnt_selecionada[indice] = _qnt_selecionada;
                        vetor_qnt_estoque[indice] = _qnt_estoque;

                        indice++;
                    }
                }

            }

            btn_compra.Text = "Compra (" + indice.ToString() + ")";

            txt_quantidade.Text = "";
            painel.Visible = false;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_quantidade.Text = "";
            painel.Visible = false;
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            painel.Visible = true;
        }
    }
}
