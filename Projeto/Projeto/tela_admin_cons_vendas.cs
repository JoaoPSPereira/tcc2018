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
    public partial class tela_admin_cons_vendas : Form
    {
        

        public tela_admin_cons_vendas()
        {
            InitializeComponent();
        }

        private void Refresh()
        {
            var _sql_refresh = "SELECT id_venda as 'ID Venda', nome_pessoa as 'Nome Pessoa', tag_pessoa as 'TAG Pessoa', DATE_FORMAT(data_retirada, '%d/%m/%Y %H:%i:%s') as 'Data da Retirada' FROM venda LIMIT 30";

            var db = new DataBase();

            dgv.DataSource = db.ExecutarSelect(_sql_refresh);

            db.Close();
        }

        private void tela_admin_cons_vendas_Load(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void btn_recarregar_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            var _busca = txt_busca.Text.Trim();

            var _sql1 = $"SELECT id_venda as 'ID Venda', nome_pessoa as 'Nome Pessoa', tag_pessoa as 'TAG Pessoa', DATE_FORMAT(data_retirada, '%d/%m/%Y %H:%i:%s') as 'Data da Retirada' FROM venda WHERE nome_pessoa like '%{_busca}%' ";
            var _sql2 = $"SELECT id_venda as 'ID Venda', nome_pessoa as 'Nome Pessoa', tag_pessoa as 'TAG Pessoa', DATE_FORMAT(data_retirada, '%d/%m/%Y %H:%i:%s') as 'Data da Retirada' FROM venda WHERE data_entrada or data_saida like '%{_busca}%' ";

            var db = new DataBase();

            if(rbt_pessoa.Checked == true)
            {
                dgv.DataSource = db.ExecutarSelect(_sql1);
            }
            else if (rbt_data.Checked == true)
            {
                dgv.DataSource = db.ExecutarSelect(_sql2);
            }

            db.Close();
        }

        private void ExibeItens()
        {
            var _linha = dgv.CurrentRow.Index; //Pega a linha selecionada da tabela
            var _id_venda = dgv[0, _linha].Value.ToString(); //Pega o id da venda na linha selecionada
            var _nome_pessoa = dgv[1, _linha].Value.ToString(); //Pega o nome da pessoa na linha selecionada
            var _tag_pessoa = dgv[2, _linha].Value.ToString();
            var _data_retirada = dgv[3, _linha].Value.ToString();

            var janela = new tela_admin_exibe_venda();

            janela.id_venda = _id_venda;
            janela.nome_pessoa = _nome_pessoa;
            janela.tag_pessoa = _tag_pessoa;
            janela.data_retirada = _data_retirada;

            janela.Show();
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ExibeItens();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ExibeItens();
        }
    }
}
