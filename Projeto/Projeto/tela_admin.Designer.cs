namespace Projeto
{
    partial class tela_admin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuitem_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitem_cadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitem_cadastrar_medicamento = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitem_cadastrar_funcionario = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitem_consultar_medicamento = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitem_consultar_funcionario = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitem_sair = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitem_menu,
            this.menuitem_cadastrar,
            this.consultarToolStripMenuItem,
            this.consultarToolStripMenuItem1,
            this.menuitem_sair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuitem_menu
            // 
            this.menuitem_menu.Name = "menuitem_menu";
            this.menuitem_menu.Size = new System.Drawing.Size(73, 29);
            this.menuitem_menu.Text = "Menu";
            // 
            // menuitem_cadastrar
            // 
            this.menuitem_cadastrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitem_cadastrar_medicamento,
            this.menuitem_cadastrar_funcionario});
            this.menuitem_cadastrar.Name = "menuitem_cadastrar";
            this.menuitem_cadastrar.Size = new System.Drawing.Size(105, 29);
            this.menuitem_cadastrar.Text = "Cadastrar";
            // 
            // menuitem_cadastrar_medicamento
            // 
            this.menuitem_cadastrar_medicamento.Name = "menuitem_cadastrar_medicamento";
            this.menuitem_cadastrar_medicamento.Size = new System.Drawing.Size(204, 30);
            this.menuitem_cadastrar_medicamento.Text = "Medicamento";
            this.menuitem_cadastrar_medicamento.Click += new System.EventHandler(this.menuitem_cadastrar_medicamento_Click);
            // 
            // menuitem_cadastrar_funcionario
            // 
            this.menuitem_cadastrar_funcionario.Name = "menuitem_cadastrar_funcionario";
            this.menuitem_cadastrar_funcionario.Size = new System.Drawing.Size(204, 30);
            this.menuitem_cadastrar_funcionario.Text = "Funcionário";
            this.menuitem_cadastrar_funcionario.Click += new System.EventHandler(this.menuitem_cadastrar_funcionario_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitem_consultar_medicamento,
            this.menuitem_consultar_funcionario});
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(144, 29);
            this.consultarToolStripMenuItem.Text = "Alterar/Excluir";
            // 
            // menuitem_consultar_medicamento
            // 
            this.menuitem_consultar_medicamento.Name = "menuitem_consultar_medicamento";
            this.menuitem_consultar_medicamento.Size = new System.Drawing.Size(204, 30);
            this.menuitem_consultar_medicamento.Text = "Medicamento";
            this.menuitem_consultar_medicamento.Click += new System.EventHandler(this.menuitem_consultar_medicamento_Click);
            // 
            // menuitem_consultar_funcionario
            // 
            this.menuitem_consultar_funcionario.Name = "menuitem_consultar_funcionario";
            this.menuitem_consultar_funcionario.Size = new System.Drawing.Size(204, 30);
            this.menuitem_consultar_funcionario.Text = "Funcionário";
            this.menuitem_consultar_funcionario.Click += new System.EventHandler(this.menuitem_consultar_funcionario_Click);
            // 
            // consultarToolStripMenuItem1
            // 
            this.consultarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasToolStripMenuItem,
            this.entradasToolStripMenuItem});
            this.consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
            this.consultarToolStripMenuItem1.Size = new System.Drawing.Size(105, 29);
            this.consultarToolStripMenuItem1.Text = "Consultar";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.vendasToolStripMenuItem.Text = "Vendas";
            this.vendasToolStripMenuItem.Click += new System.EventHandler(this.vendasToolStripMenuItem_Click);
            // 
            // entradasToolStripMenuItem
            // 
            this.entradasToolStripMenuItem.Name = "entradasToolStripMenuItem";
            this.entradasToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.entradasToolStripMenuItem.Text = "Entradas";
            this.entradasToolStripMenuItem.Click += new System.EventHandler(this.entradasToolStripMenuItem_Click);
            // 
            // menuitem_sair
            // 
            this.menuitem_sair.Name = "menuitem_sair";
            this.menuitem_sair.Size = new System.Drawing.Size(56, 29);
            this.menuitem_sair.Text = "Sair";
            this.menuitem_sair.Click += new System.EventHandler(this.menuitem_sair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bem vindo,";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(685, 111);
            this.label2.TabIndex = 2;
            this.label2.Text = "Aqui você pode cadastrar, consultar, alterar e excluir: \r\n    - medicamentos;\r\n  " +
    "  - pessoas.";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Franklin Gothic Medium", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(295, 137);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(396, 47);
            this.lbl_nome.TabIndex = 4;
            this.lbl_nome.Text = "nome do funcionário";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(727, 41);
            this.label5.TabIndex = 5;
            this.label5.Text = "Esta é a interface de administração do sistema";
            // 
            // tela_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "tela_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tela_admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.tela_admin_FormClosing);
            this.Load += new System.EventHandler(this.tela_admin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuitem_menu;
        private System.Windows.Forms.ToolStripMenuItem menuitem_cadastrar;
        private System.Windows.Forms.ToolStripMenuItem menuitem_cadastrar_funcionario;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuitem_sair;
        private System.Windows.Forms.ToolStripMenuItem menuitem_cadastrar_medicamento;
        private System.Windows.Forms.ToolStripMenuItem menuitem_consultar_medicamento;
        private System.Windows.Forms.ToolStripMenuItem menuitem_consultar_funcionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradasToolStripMenuItem;
    }
}