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

namespace Projeto
{
    

    public partial class tela_tag_confirmation : Form
    {
        private String form_procedente;
        private String tag_precedente;

        private String tag_pessoa;
        private String nome_pessoa;

        private String sql_entrada;


        private Arduino arduino = new Arduino();

        String _porta;

        //Métodos publicos

        public void SetNewForm(String form)
        {
            form_procedente = form;
        }

        public void SetTag(String tag)
        {
            tag_precedente = tag;
        }

        public void SetNome(String nome)
        {
            nome_pessoa = nome;
        }
        //

        public tela_tag_confirmation()
        {
            InitializeComponent();
        }

        private void tela_tag_confirmation_Load(object sender, EventArgs e)
        {
            _porta = "COM3"; //cbx_portas.Text;

            arduino.AbrirConexao(usb_arduino, _porta);
        }

        private void usb_arduino_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(ConfirmaTagArduino));
            
            
        }

        private void ConfirmaTagArduino(object sender, EventArgs e)
        {
            try
            {
                tag_precedente = arduino.ReturnTagArduino(usb_arduino);

                //Procedimento para a tela_painel_saida

                if (form_procedente == "tela_painel_saida")
                {
                    var _sql = $"SELECT tag_pessoa, nome_pessoa FROM pessoa WHERE tag_pessoa = '{tag_precedente}'";

                    var db = new DataBase();

                    var dataReader = db.ExecutarReader(_sql);

                    if (dataReader.Read())
                    {
                        tag_pessoa = dataReader.GetString("tag_pessoa").ToString();
                        nome_pessoa = dataReader.GetString("nome_pessoa").ToString();

                        var _dateTimeNow = DateTime.Now;

                        var _agora = _dateTimeNow.ToString("yyyy-MM-dd HH:mm:ss");

                        sql_entrada = $"INSERT INTO entrada(nome_pessoa, tag_pessoa, data_entrada) VALUES('{nome_pessoa}','{tag_pessoa}','{_agora}')";

                        lbl_negated.Visible = false;

                        lbl_texto.Visible = true;

                        lbl_ok.Visible = true;
                        lbl_ok.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("DataReader falhou!");
                        lbl_negated.Visible = true;
                    }

                    dataReader.Dispose();
                    dataReader.Close();
                    db.Close();

                    

                    

                   
                }


                //Procedimento para a tela_admin

                if (form_procedente == "tela_admin")
                {
                    var _sql = $"SELECT tag_pessoa FROM admin WHERE tag_pessoa = '{tag_precedente}'";

                    var db = new DataBase();

                    var dataReader = db.ExecutarReader(_sql);

                    if (dataReader.Read())
                    {
                        tag_pessoa = dataReader.GetString("tag_pessoa").ToString();

                        lbl_negated.Visible = false;

                        lbl_texto.Visible = true;

                        lbl_ok.Visible = true;
                        lbl_ok.Enabled = true;
                    }
                    else
                    {
                        lbl_negated.Visible = true;

                                    
                    }

                    dataReader.Dispose();
                    dataReader.Close();
                    db.Close();

                    
                }

                
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }



        private void lbl_ok_Click(object sender, EventArgs e)
        {
            if(form_procedente == "tela_admin")
            {
                var janela = new tela_admin();

                janela.tag_admin = tag_pessoa;

                janela.Show();
            }
            else if (form_procedente == "tela_painel_saida")
            {
                var db = new DataBase();

                db.ExecutarInsert(sql_entrada);

                db.Close();

                var janela = new tela_painel_saida();

                janela.tag_pessoa = tag_precedente;
                janela.nome_pessoa = nome_pessoa;

                janela.Show();
            }

            this.Close();
            
        }

        private void tela_tag_confirmation_FormClosing(object sender, FormClosingEventArgs e)
        {
            arduino.FecharConexao(usb_arduino);
        }
    }
}
