namespace Projeto
{
    partial class tela_admin_alterar_funcionario
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
            this.btn_conectar = new System.Windows.Forms.Button();
            this.cbx_portas = new System.Windows.Forms.ComboBox();
            this.gbx_dados = new System.Windows.Forms.GroupBox();
            this.rbt_nao = new System.Windows.Forms.RadioButton();
            this.rbt_sim = new System.Windows.Forms.RadioButton();
            this.lbl_tag = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.txt_rg = new System.Windows.Forms.MaskedTextBox();
            this.gbx_admin = new System.Windows.Forms.GroupBox();
            this.lbl_senhaAtual = new System.Windows.Forms.Label();
            this.txt_senhaAtual = new System.Windows.Forms.TextBox();
            this.txt_novaSenha = new System.Windows.Forms.TextBox();
            this.lbl_novasenha = new System.Windows.Forms.Label();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.lbl_login = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_confirma = new System.Windows.Forms.Button();
            this.gbx_dados.SuspendLayout();
            this.gbx_admin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_conectar
            // 
            this.btn_conectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_conectar.Location = new System.Drawing.Point(702, 18);
            this.btn_conectar.Name = "btn_conectar";
            this.btn_conectar.Size = new System.Drawing.Size(105, 28);
            this.btn_conectar.TabIndex = 41;
            this.btn_conectar.UseVisualStyleBackColor = true;
            this.btn_conectar.Visible = false;
            // 
            // cbx_portas
            // 
            this.cbx_portas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_portas.FormattingEnabled = true;
            this.cbx_portas.Location = new System.Drawing.Point(603, 19);
            this.cbx_portas.Name = "cbx_portas";
            this.cbx_portas.Size = new System.Drawing.Size(93, 28);
            this.cbx_portas.TabIndex = 40;
            this.cbx_portas.Visible = false;
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
            this.gbx_dados.Location = new System.Drawing.Point(12, 53);
            this.gbx_dados.Name = "gbx_dados";
            this.gbx_dados.Size = new System.Drawing.Size(421, 247);
            this.gbx_dados.TabIndex = 37;
            this.gbx_dados.TabStop = false;
            this.gbx_dados.Text = "Dados";
            // 
            // rbt_nao
            // 
            this.rbt_nao.AutoSize = true;
            this.rbt_nao.Location = new System.Drawing.Point(159, 192);
            this.rbt_nao.Name = "rbt_nao";
            this.rbt_nao.Size = new System.Drawing.Size(60, 28);
            this.rbt_nao.TabIndex = 5;
            this.rbt_nao.Text = "Não";
            this.rbt_nao.UseVisualStyleBackColor = true;
            // 
            // rbt_sim
            // 
            this.rbt_sim.AutoSize = true;
            this.rbt_sim.Checked = true;
            this.rbt_sim.Location = new System.Drawing.Point(92, 192);
            this.rbt_sim.Name = "rbt_sim";
            this.rbt_sim.Size = new System.Drawing.Size(61, 28);
            this.rbt_sim.TabIndex = 4;
            this.rbt_sim.TabStop = true;
            this.rbt_sim.Text = "Sim";
            this.rbt_sim.UseVisualStyleBackColor = true;
            // 
            // lbl_tag
            // 
            this.lbl_tag.AutoSize = true;
            this.lbl_tag.Location = new System.Drawing.Point(76, 40);
            this.lbl_tag.Name = "lbl_tag";
            this.lbl_tag.Size = new System.Drawing.Size(113, 24);
            this.lbl_tag.TabIndex = 0;
            this.lbl_tag.Text = "XX.XX.XX.XX";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ativo:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(76, 79);
            this.txt_nome.MaxLength = 50;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(329, 29);
            this.txt_nome.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 24);
            this.label8.TabIndex = 3;
            this.label8.Text = "RG:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 24);
            this.label10.TabIndex = 7;
            this.label10.Text = "TAG:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 24);
            this.label9.TabIndex = 4;
            this.label9.Text = "CPF:";
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(76, 114);
            this.txt_cpf.Mask = "999,999,999-99";
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(329, 29);
            this.txt_cpf.TabIndex = 2;
            // 
            // txt_rg
            // 
            this.txt_rg.Location = new System.Drawing.Point(76, 149);
            this.txt_rg.Mask = "99,999,999-9";
            this.txt_rg.Name = "txt_rg";
            this.txt_rg.Size = new System.Drawing.Size(329, 29);
            this.txt_rg.TabIndex = 3;
            // 
            // gbx_admin
            // 
            this.gbx_admin.Controls.Add(this.lbl_senhaAtual);
            this.gbx_admin.Controls.Add(this.txt_senhaAtual);
            this.gbx_admin.Controls.Add(this.txt_novaSenha);
            this.gbx_admin.Controls.Add(this.lbl_novasenha);
            this.gbx_admin.Controls.Add(this.txt_login);
            this.gbx_admin.Controls.Add(this.lbl_login);
            this.gbx_admin.Enabled = false;
            this.gbx_admin.Location = new System.Drawing.Point(450, 53);
            this.gbx_admin.Name = "gbx_admin";
            this.gbx_admin.Size = new System.Drawing.Size(392, 180);
            this.gbx_admin.TabIndex = 12;
            this.gbx_admin.TabStop = false;
            this.gbx_admin.Text = "Admin";
            // 
            // lbl_senhaAtual
            // 
            this.lbl_senhaAtual.AutoSize = true;
            this.lbl_senhaAtual.Enabled = false;
            this.lbl_senhaAtual.Location = new System.Drawing.Point(9, 83);
            this.lbl_senhaAtual.Name = "lbl_senhaAtual";
            this.lbl_senhaAtual.Size = new System.Drawing.Size(113, 24);
            this.lbl_senhaAtual.TabIndex = 19;
            this.lbl_senhaAtual.Text = "Senha Atual:";
            // 
            // txt_senhaAtual
            // 
            this.txt_senhaAtual.Enabled = false;
            this.txt_senhaAtual.Location = new System.Drawing.Point(138, 80);
            this.txt_senhaAtual.Name = "txt_senhaAtual";
            this.txt_senhaAtual.Size = new System.Drawing.Size(232, 29);
            this.txt_senhaAtual.TabIndex = 7;
            // 
            // txt_novaSenha
            // 
            this.txt_novaSenha.Enabled = false;
            this.txt_novaSenha.Location = new System.Drawing.Point(137, 115);
            this.txt_novaSenha.Name = "txt_novaSenha";
            this.txt_novaSenha.Size = new System.Drawing.Size(232, 29);
            this.txt_novaSenha.TabIndex = 8;
            // 
            // lbl_novasenha
            // 
            this.lbl_novasenha.AutoSize = true;
            this.lbl_novasenha.Enabled = false;
            this.lbl_novasenha.Location = new System.Drawing.Point(21, 118);
            this.lbl_novasenha.Name = "lbl_novasenha";
            this.lbl_novasenha.Size = new System.Drawing.Size(111, 24);
            this.lbl_novasenha.TabIndex = 4;
            this.lbl_novasenha.Text = "Nova Senha:";
            // 
            // txt_login
            // 
            this.txt_login.Enabled = false;
            this.txt_login.Location = new System.Drawing.Point(137, 45);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(233, 29);
            this.txt_login.TabIndex = 6;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Enabled = false;
            this.lbl_login.Location = new System.Drawing.Point(72, 45);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(59, 24);
            this.lbl_login.TabIndex = 2;
            this.lbl_login.Text = "Login:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(54, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(210, 30);
            this.label18.TabIndex = 42;
            this.label18.Text = "Alterar Funcionário";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.IndianRed;
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(517, 256);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(107, 44);
            this.btn_cancelar.TabIndex = 10;
            this.btn_cancelar.Text = "Fechar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_confirma
            // 
            this.btn_confirma.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_confirma.ForeColor = System.Drawing.Color.White;
            this.btn_confirma.Location = new System.Drawing.Point(630, 257);
            this.btn_confirma.Name = "btn_confirma";
            this.btn_confirma.Size = new System.Drawing.Size(153, 44);
            this.btn_confirma.TabIndex = 9;
            this.btn_confirma.Text = "Confirma";
            this.btn_confirma.UseVisualStyleBackColor = false;
            this.btn_confirma.Click += new System.EventHandler(this.btn_confirma_Click);
            // 
            // tela_admin_alterar_funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 320);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_confirma);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.gbx_admin);
            this.Controls.Add(this.btn_conectar);
            this.Controls.Add(this.cbx_portas);
            this.Controls.Add(this.gbx_dados);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "tela_admin_alterar_funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário de Alteração";
            this.Load += new System.EventHandler(this.tela_admin_alterar_funcionario_Load);
            this.gbx_dados.ResumeLayout(false);
            this.gbx_dados.PerformLayout();
            this.gbx_admin.ResumeLayout(false);
            this.gbx_admin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_conectar;
        private System.Windows.Forms.ComboBox cbx_portas;
        private System.Windows.Forms.GroupBox gbx_dados;
        private System.Windows.Forms.RadioButton rbt_nao;
        private System.Windows.Forms.RadioButton rbt_sim;
        private System.Windows.Forms.Label lbl_tag;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txt_cpf;
        private System.Windows.Forms.MaskedTextBox txt_rg;
        private System.Windows.Forms.GroupBox gbx_admin;
        private System.Windows.Forms.TextBox txt_novaSenha;
        private System.Windows.Forms.Label lbl_novasenha;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_confirma;
        private System.Windows.Forms.Label lbl_senhaAtual;
        private System.Windows.Forms.TextBox txt_senhaAtual;
    }
}