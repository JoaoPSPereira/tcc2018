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
    public partial class tela_compra : Form
    {
        //Dados do medicamento
        public String[] vetor_id = new String[10];
        public String[] vetor_nome = new String[10];
        public String[] vetor_descricao = new String[10];
        public String[] vetor_tipo = new String[10];
        public String[] vetor_qnt_caixa = new String[10];
        public String[] vetor_conteudo = new String[10];
        public String[] vetor_medida = new String[10];
        public String[] vetor_qnt_selecionada = new String[10];
        public String[] vetor_qnt_estoque = new String[10];

        //Dados do usuário
        public String tag_pessoa;
        public String nome_pessoa;
        public String id_entrada;

        public int indice;

        private DataTable table = new DataTable();

        public tela_compra()
        {
            InitializeComponent();
        }

        private void tela_compra_Load(object sender, EventArgs e)
        {
            table.Columns.Add("ID", typeof(String));
            table.Columns.Add("Nome", typeof(String));
            table.Columns.Add("Descrição", typeof(String));
            table.Columns.Add("Tipo", typeof(String));
            table.Columns.Add("Qnt. Caixa", typeof(String));
            table.Columns.Add("Conteudo(ml/mg)", typeof(String));
            table.Columns.Add("Medida", typeof(String));
            table.Columns.Add("Qnt. Selecionada", typeof(String));
            table.Columns.Add("Qnt. Estoque", typeof(String));
           
            for (int cont = 0; cont < indice; cont++)
            {
                table.Rows.Add(
                    vetor_id[cont], 
                    vetor_nome[cont],
                    vetor_descricao[cont],
                    vetor_tipo[cont],
                    vetor_qnt_caixa[cont],
                    vetor_conteudo[cont],
                    vetor_medida[cont],
                    vetor_qnt_selecionada[cont],
                    vetor_qnt_estoque[cont]
                );
            }

            dgv_compra.DataSource = table;

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            var _linha = dgv_compra.CurrentRow.Index; //Pega a linha selecionada da tabela

            dgv_compra.Rows.RemoveAt(_linha);

            indice -= 1;

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            

            
        }

        private void btn_alterar_qnt_Click(object sender, EventArgs e)
        {
            var _linha = dgv_compra.CurrentRow.Index;
            txt_quantidade.Text = dgv_compra[7, _linha].Value.ToString();

            painel.Visible = true;
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            var _nova_quantidade = txt_quantidade.Text;

            var _linha = dgv_compra.CurrentRow.Index;
            dgv_compra[7, _linha].Value = _nova_quantidade;

            painel.Visible = false;
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            var db = new DataBase();

            var _dateTimeNow = DateTime.Now;

            var _agora = _dateTimeNow.ToString("yyyy-MM-dd HH:mm:ss");

            var _sqlInsertVenda = $"INSERT INTO venda VALUES('','{nome_pessoa}','{tag_pessoa}','{_agora}')";

            db.ExecutarInsert(_sqlInsertVenda);

            var _sqlSelectVenda = $"SELECT MAX(id_venda) as id_venda FROM venda";

            var dataReader = db.ExecutarReader(_sqlSelectVenda);

            if (dataReader.Read())
            {
                var _idVenda = dataReader.GetString("id_venda").ToString();

                dataReader.Close();

                for (int cont = 0; cont < indice; cont++)
                {
                    var _linha = dgv_compra.Rows[cont].Index;
                    var _idMed = dgv_compra[0, _linha].Value.ToString();
                    var _nomeMed = dgv_compra[1, _linha].Value.ToString();

                    var _qnt_selecionada = Int32.Parse(dgv_compra[7, _linha].Value.ToString().Trim());
                    var _qnt_estoque = Int32.Parse(dgv_compra[8, _linha].Value.ToString().Trim());

                    var _novo_estoque = (_qnt_estoque - _qnt_selecionada);

                    var _sqlUpdateEstoque = $"UPDATE medicamento SET qnt_em_estoque = {_novo_estoque} WHERE id_medicamento = '{_idMed}'";
                    var _sqlInsertRetirada = $"INSERT INTO retirada values('','{_nomeMed}','{_idMed}','{_qnt_selecionada}','{_novo_estoque}','{nome_pessoa}','{tag_pessoa}','{_agora}','{_idVenda}')";
                    var _sqlUpdateEntrada = $"UPDATE entrada SET data_saida = '{_agora}', id_venda = '{_idVenda}' WHERE id_entrada = '{id_entrada}'";

                    db.ExecutarUpdate(_sqlUpdateEstoque);
                    db.ExecutarInsert(_sqlInsertRetirada);
                    db.ExecutarUpdate(_sqlUpdateEntrada);

                }

                MessageBox.Show("Compra finalizada, por favor dirija-se à saída.");

                Application.Exit();
            }
            else
            {
                MessageBox.Show("DataReader falhou!");
            }
           
            db.Close();
  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_quantidade.Text = "";
            painel.Visible = false;
        }
    }
}
