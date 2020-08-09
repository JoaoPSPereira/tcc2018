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

    public partial class tela_admin_cad_med : Form
    {
        public tela_admin_cad_med()
        {
            InitializeComponent();
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
    }
}
