namespace Projeto
{
    partial class tela_admin_cad_funcionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_rg = new System.Windows.Forms.MaskedTextBox();
            this.txt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_tag = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbx_dados = new System.Windows.Forms.GroupBox();
            this.rbt_nao = new System.Windows.Forms.RadioButton();
            this.rbt_sim = new System.Windows.Forms.RadioButton();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.usb_arduino = new System.IO.Ports.SerialPort(this.components);
            this.cbx_portas = new System.Windows.Forms.ComboBox();
            this.btn_conectar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.gbx_dados.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(265, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cadastro de Funcionário";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nome:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(76, 79);
            this.txt_nome.MaxLength = 50;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(359, 29);
            this.txt_nome.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(248, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 24);
            this.label8.TabIndex = 3;
            this.label8.Text = "RG:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 24);
            this.label9.TabIndex = 4;
            this.label9.Text = "CPF:";
            // 
            // txt_rg
            // 
            this.txt_rg.Location = new System.Drawing.Point(293, 119);
            this.txt_rg.Mask = "99,999,999-9";
            this.txt_rg.Name = "txt_rg";
            this.txt_rg.Size = new System.Drawing.Size(142, 29);
            this.txt_rg.TabIndex = 3;
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(76, 119);
            this.txt_cpf.Mask = "999,999,999-99";
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(142, 29);
            this.txt_cpf.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 24);
            this.label10.TabIndex = 7;
            this.label10.Text = "TAG:";
            // 
            // lbl_tag
            // 
            this.lbl_tag.AutoSize = true;
            this.lbl_tag.Location = new System.Drawing.Point(76, 44);
            this.lbl_tag.Name = "lbl_tag";
            this.lbl_tag.Size = new System.Drawing.Size(113, 24);
            this.lbl_tag.TabIndex = 0;
            this.lbl_tag.Text = "XX.XX.XX.XX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ativo:";
            // 
            // gbx_dados
            // 
            this.gbx_dados.Controls.Add(this.rbt_nao);
            this.gbx_dados.Controls.Add(this.rbt_sim);
            this.gbx_dados.Controls.Add(this.lbl_tag);
            this.gbx_dados.Controls.Add(this.label7);
            this.gbx_dados.Controls.Add(this.label1);
            this.gbx_dados.Controls.Add(this.txt_nome);
            this.gbx_dados.Controls.Add(this.label8);
            this.gbx_dados.Controls.Add(this.label10);
            this.gbx_dados.Controls.Add(this.label9);
            this.gbx_dados.Controls.Add(this.txt_cpf);
            this.gbx_dados.Controls.Add(this.txt_rg);
            this.gbx_dados.Location = new System.Drawing.Point(22, 64);
            this.gbx_dados.Name = "gbx_dados";
            this.gbx_dados.Size = new System.Drawing.Size(460, 219);
            this.gbx_dados.TabIndex = 11;
            this.gbx_dados.TabStop = false;
            this.gbx_dados.Text = "Dados";
            // 
            // rbt_nao
            // 
            this.rbt_nao.AutoSize = true;
            this.rbt_nao.Location = new System.Drawing.Point(151, 161);
            this.rbt_nao.Name = "rbt_nao";
            this.rbt_nao.Size = new System.Drawing.Size(60, 28);
            this.rbt_nao.TabIndex = 11;
            this.rbt_nao.Text = "Não";
            this.rbt_nao.UseVisualStyleBackColor = true;
            // 
            // rbt_sim
            // 
            this.rbt_sim.AutoSize = true;
            this.rbt_sim.Checked = true;
            this.rbt_sim.Location = new System.Drawing.Point(84, 161);
            this.rbt_sim.Name = "rbt_sim";
            this.rbt_sim.Size = new System.Drawing.Size(61, 28);
            this.rbt_sim.TabIndex = 10;
            this.rbt_sim.TabStop = true;
            this.rbt_sim.Text = "Sim";
            this.rbt_sim.UseVisualStyleBackColor = true;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_cadastrar.ForeColor = System.Drawing.Color.White;
            this.btn_cadastrar.Location = new System.Drawing.Point(330, 291);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(153, 44);
            this.btn_cadastrar.TabIndex = 15;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // usb_arduino
            // 
            this.usb_arduino.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.usb_arduino_DataReceived);
            // 
            // cbx_portas
            // 
            this.cbx_portas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_portas.FormattingEnabled = true;
            this.cbx_portas.Location = new System.Drawing.Point(295, 20);
            this.cbx_portas.Name = "cbx_portas";
            this.cbx_portas.Size = new System.Drawing.Size(93, 28);
            this.cbx_portas.TabIndex = 35;
            this.cbx_portas.Visible = false;
            // 
            // btn_conectar
            // 
            this.btn_conectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_conectar.Location = new System.Drawing.Point(394, 20);
            this.btn_conectar.Name = "btn_conectar";
            this.btn_conectar.Size = new System.Drawing.Size(89, 28);
            this.btn_conectar.TabIndex = 36;
            this.btn_conectar.UseVisualStyleBackColor = true;
            this.btn_conectar.Visible = false;
            this.btn_conectar.Click += new System.EventHandler(this.btn_conectar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.IndianRed;
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(217, 291);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(107, 44);
            this.btn_cancelar.TabIndex = 16;
            this.btn_cancelar.Text = "Fechar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // tela_admin_cad_funcionario
            // 
            this.ClientSize = new System.Drawing.Size(508, 347);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_conectar);
            this.Controls.Add(this.cbx_portas);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.gbx_dados);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "tela_admin_cad_funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário de Cadastro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.tela_admin_cad_pessoa_FormClosing);
            this.Load += new System.EventHandler(this.tela_admin_cad_pessoa_Load);
            this.gbx_dados.ResumeLayout(false);
            this.gbx_dados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txt_rg;
        private System.Windows.Forms.MaskedTextBox txt_cpf;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_tag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbx_dados;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.IO.Ports.SerialPort usb_arduino;
        private System.Windows.Forms.ComboBox cbx_portas;
        private System.Windows.Forms.Button btn_conectar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.RadioButton rbt_nao;
        private System.Windows.Forms.RadioButton rbt_sim;
    }
}