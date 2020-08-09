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
    public partial class tela_admin_alterar_med : Form
    {
        public String _id;
        public String _nome;
        public String _descricao;
        public String _tipo;
        public String _qnt_caixa;
        public String _conteudo;
        public String _medida;

        public tela_admin_alterar_med()
        {
            InitializeComponent();
        }



        private void tela_admin_alterar_med_Load(object sender, EventArgs e)
        {
            
            try
            {
              
                txt_nome.Text = _nome;
                txt_descricao.Text = _descricao;
                cbx_tipo.Text = _tipo;
                txt_qnt.Text = _qnt_caixa;
                txt_conteudo.Text = _conteudo;
                cbx_medida.Text = _medida;

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            var _novoNome = txt_nome.Text.Trim();
            var _novaDescricao = txt_descricao.Text.Trim();
            var _novoTipo = cbx_tipo.Text.Trim();
            var _novaQnt = txt_qnt.Text.Trim();
            var _novoConteudo = txt_conteudo.Text.Trim();
            var _novaMedida = cbx_medida.Text.Trim();

            var _sql = $"UPDATE medicamento SET nome_medicamento = '{_novoNome}', descricao_medicamento = '{_novaDescricao}', tipo_medicamento = '{_novoTipo}', quantidade_caixa = {_novaQnt}, conteudo_liquido = {_novoConteudo}, medida_conteudo = '{_novaMedida}' WHERE id_medicamento = {_id}";

            MessageBox.Show(_sql);

            try
            {
                var db = new DataBase();

                db.ExecutarUpdate(_sql);

                db.Close();

                MessageBox.Show("Alterado com Sucesso!");

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
