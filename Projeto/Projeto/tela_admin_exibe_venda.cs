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
    public partial class tela_admin_exibe_venda : Form
    {
        public String id_venda; 
        public String data_retirada;

        public String nome_pessoa;
        public String tag_pessoa;

        public String id_entrada;
        public String data_entrada;
        public String data_saida;

        

        public tela_admin_exibe_venda()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Refresh()
        {
            var _sql_refresh = $"SELECT id_medicamento as 'ID Medicamento', nome_medicamento as 'Medicamento', qnt_retirada as 'Qnt.', saldo as 'Saldo', id_retirada as 'ID Retirada' FROM retirada WHERE id_venda = '{id_venda}'";

            var db = new DataBase();

            dgv.DataSource = db.ExecutarSelect(_sql_refresh);

            db.Close();
        }

        private void tela_admin_exibe_venda_Load(object sender, EventArgs e)
        {
            this.Refresh();

            lbl_id_venda.Text = id_venda;
            lbl_data_retirada.Text = data_retirada;
            lbl_nome_pessoa.Text = nome_pessoa;
            lbl_tag_pessoa.Text = tag_pessoa;

            var db = new DataBase();

            var _sql = $"SELECT id_entrada, DATE_FORMAT(data_entrada, '%d/%m/%Y %H:%i:%s') as data_entrada , DATE_FORMAT(data_saida, '%d/%m/%Y %H:%i:%s') as data_saida FROM entrada WHERE id_venda = {id_venda}";

            var dataReader = db.ExecutarReader(_sql);

            if (dataReader.Read())
            {
                id_entrada = dataReader.GetString("id_entrada").ToString();
                data_entrada = dataReader.GetString("data_entrada").ToString();
                data_saida = dataReader.GetString("data_saida").ToString();

                lbl_id_entrada.Text = id_entrada;
                lbl_data_entrada.Text = data_entrada;
                lbl_data_saida.Text = data_saida;
            }

            dataReader.Close();
            db.Close();
        }
    }
}
