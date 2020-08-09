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
    public partial class tela_admin_cons_entradas : Form
    {
        public tela_admin_cons_entradas()
        {
            InitializeComponent();
        }

        private void Refresh()
        {
            var _sql_refresh = "SELECT id_entrada as 'ID Entrada', nome_pessoa as 'Nome Pessoa', DATE_FORMAT(data_entrada, '%d/%m/%Y %H:%i:%s') as 'Entrada', DATE_FORMAT(data_saida, '%d/%m/%Y %H:%i:%s') as 'Saida', id_venda as 'ID Venda' FROM entrada LIMIT 30";

            var db = new DataBase();

            dgv.DataSource = db.ExecutarSelect(_sql_refresh);

            db.Close();
        }

        private void tela_admin_cons_entradas_Load(object sender, EventArgs e)
        {
            this.Refresh();


        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            var _busca = txt_busca.Text.Trim();

            var _sql1 = $"SELECT id_entrada as 'ID Entrada', nome_pessoa as 'Nome Pessoa', DATE_FORMAT(data_entrada, '%d/%m/%Y %H:%i:%s') as 'Entrada', DATE_FORMAT(data_saida, '%d/%m/%Y %H:%i:%s') as 'Saida', id_venda as 'ID Venda' FROM entrada WHERE nome_pessoa like '%{_busca}%'";
            var _sql2 = $"SELECT id_entrada as 'ID Entrada', nome_pessoa as 'Nome Pessoa', DATE_FORMAT(data_entrada, '%d/%m/%Y %H:%i:%s') as 'Entrada', DATE_FORMAT(data_saida, '%d/%m/%Y %H:%i:%s') as 'Saida', id_venda as 'ID Venda' FROM entrada WHERE data_entrada like '%{_busca}%'";

            var db = new DataBase();

            if (rbt_pessoa.Checked == true)
            {
                dgv.DataSource = db.ExecutarSelect(_sql1);
            }
            else if (rbt_data.Checked == true)
            {
                dgv.DataSource = db.ExecutarSelect(_sql2);
            }

            db.Close();

        }

        private void btn_recarregar_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
