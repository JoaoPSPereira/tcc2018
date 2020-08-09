using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Projeto
{
    public partial class tela_admin_cad_funcionario : Form
    {
        private String _tag;
        private String _nome;
        private String _rg;
        private String _cpf;
        private String _ativo;
        private String _comandoCadPessoa;
        private String _porta;

        private Arduino arduino = new Arduino();

        private DataBase db;

        public tela_admin_cad_funcionario()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            _tag = lbl_tag.Text.Trim();
            _nome = txt_nome.Text.Trim();
            _cpf = txt_cpf.Text.Trim();
            _rg = txt_rg.Text.Trim();

            if (rbt_sim.Checked == true)
            {
                _ativo = "S";
            }
            else
            {
                _ativo = "N";
            }

            if (_tag != "XX.XX.XX.XX")
            {
                try
                {
                    db = new DataBase();

                    _comandoCadPessoa = $"insert into pessoa values('{_tag}','{_nome}','{_cpf}','{_rg}', 'Funcionário','{_ativo}')";


                    db.ExecutarInsert(_comandoCadPessoa);
                    MessageBox.Show("Cadastrado com sucesso!");

                }

                catch (Exception erro)
                {
                    MessageBox.Show("Erro: " + erro.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor passe o cartão no leitor");
            }
        }

        private void tela_admin_cad_pessoa_Load(object sender, EventArgs e)
        {
            //Pega as portas disponíveis
            string[] _portas = SerialPort.GetPortNames();

            //Adiciona a lista no comboBox
            cbx_portas.DataSource = _portas;
            _porta = "COM3"; //cbx_portas.Text;

            arduino.AbrirConexao(usb_arduino, _porta);
            
            btn_conectar.Text = "Desconectar";

        }

        private void usb_arduino_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(MostraTagArduino));
        }

        private void MostraTagArduino(object sender, EventArgs e)
        {
            var TAG = arduino.ReturnTagArduino(usb_arduino);

            lbl_tag.Text = TAG;
        }

        private void tela_admin_cad_pessoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            arduino.FecharConexao(usb_arduino);
        }

        private void btn_conectar_Click(object sender, EventArgs e)
        {
            _porta = cbx_portas.Text;

            try
            {

                if (btn_conectar.Text == "Conectar")
                {
                    arduino.AbrirConexao(usb_arduino, _porta);
                    btn_conectar.Text = "Desconectar";
                    MessageBox.Show("Conexão efetuada com o Arduino!");
                }
                else if(btn_conectar.Text == "Desconectar")
                {
                    arduino.FecharConexao(usb_arduino);
                    btn_conectar.Text = "Conectar";
                    MessageBox.Show("Desconectado com sucesso!");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro: " + erro.Message);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
