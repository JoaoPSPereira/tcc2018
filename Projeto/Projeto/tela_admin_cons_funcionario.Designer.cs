namespace Projeto
{
    partial class tela_admin_cons_funcionario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txt_busca = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.rbt_nome = new System.Windows.Forms.RadioButton();
            this.gbx_radios = new System.Windows.Forms.GroupBox();
            this.rbt_cpf = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_busca = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_recarregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.gbx_radios.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 152);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(960, 397);
            this.dgv.TabIndex = 0;
            // 
            // txt_busca
            // 
            this.txt_busca.Font = new System.Drawing.Font("Franklin Gothic Medium", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_busca.Location = new System.Drawing.Point(26, 24);
            this.txt_busca.MaxLength = 50;
            this.txt_busca.Name = "txt_busca";
            this.txt_busca.Size = new System.Drawing.Size(811, 40);
            this.txt_busca.TabIndex = 1;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_buscar.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(843, 24);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(115, 40);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.BackColor = System.Drawing.Color.Khaki;
            this.btn_alterar.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterar.Location = new System.Drawing.Point(722, 88);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(115, 46);
            this.btn_alterar.TabIndex = 3;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = false;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.Maroon;
            this.btn_excluir.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.ForeColor = System.Drawing.Color.White;
            this.btn_excluir.Location = new System.Drawing.Point(843, 88);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(115, 46);
            this.btn_excluir.TabIndex = 4;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // rbt_nome
            // 
            this.rbt_nome.AutoSize = true;
            this.rbt_nome.Checked = true;
            this.rbt_nome.Location = new System.Drawing.Point(39, 28);
            this.rbt_nome.Name = "rbt_nome";
            this.rbt_nome.Size = new System.Drawing.Size(77, 28);
            this.rbt_nome.TabIndex = 5;
            this.rbt_nome.TabStop = true;
            this.rbt_nome.Text = "Nome";
            this.rbt_nome.UseVisualStyleBackColor = true;
            this.rbt_nome.Click += new System.EventHandler(this.rbt_nome_Click);
            // 
            // gbx_radios
            // 
            this.gbx_radios.Controls.Add(this.rbt_cpf);
            this.gbx_radios.Controls.Add(this.rbt_nome);
            this.gbx_radios.Location = new System.Drawing.Point(26, 70);
            this.gbx_radios.Name = "gbx_radios";
            this.gbx_radios.Size = new System.Drawing.Size(267, 66);
            this.gbx_radios.TabIndex = 6;
            this.gbx_radios.TabStop = false;
            this.gbx_radios.Text = "Pesquisar por:";
            // 
            // rbt_cpf
            // 
            this.rbt_cpf.AutoSize = true;
            this.rbt_cpf.Location = new System.Drawing.Point(147, 28);
            this.rbt_cpf.Name = "rbt_cpf";
            this.rbt_cpf.Size = new System.Drawing.Size(60, 28);
            this.rbt_cpf.TabIndex = 6;
            this.rbt_cpf.Text = "CPF";
            this.rbt_cpf.UseVisualStyleBackColor = true;
            this.rbt_cpf.Click += new System.EventHandler(this.rbt_cpf_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Exibindo resultados da busca por:";
            // 
            // lbl_busca
            // 
            this.lbl_busca.AutoSize = true;
            this.lbl_busca.Location = new System.Drawing.Point(381, 112);
            this.lbl_busca.Name = "lbl_busca";
            this.lbl_busca.Size = new System.Drawing.Size(196, 24);
            this.lbl_busca.TabIndex = 8;
            this.lbl_busca.Text = "Últimos 30 registrados";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.IndianRed;
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(12, 555);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(147, 52);
            this.btn_cancelar.TabIndex = 21;
            this.btn_cancelar.Text = "Fechar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_recarregar
            // 
            this.btn_recarregar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_recarregar.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recarregar.ForeColor = System.Drawing.Color.White;
            this.btn_recarregar.Location = new System.Drawing.Point(165, 554);
            this.btn_recarregar.Name = "btn_recarregar";
            this.btn_recarregar.Size = new System.Drawing.Size(147, 52);
            this.btn_recarregar.TabIndex = 24;
            this.btn_recarregar.Text = "Recarregar";
            this.btn_recarregar.UseVisualStyleBackColor = false;
            this.btn_recarregar.Click += new System.EventHandler(this.btn_recarregar_Click);
            // 
            // tela_admin_cons_funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 613);
            this.Controls.Add(this.btn_recarregar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.lbl_busca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbx_radios);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_busca);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "tela_admin_cons_funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tela_admin_cons_funcionario";
            this.Load += new System.EventHandler(this.tela_admin_cons_funcionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.gbx_radios.ResumeLayout(false);
            this.gbx_radios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txt_busca;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.RadioButton rbt_nome;
        private System.Windows.Forms.GroupBox gbx_radios;
        private System.Windows.Forms.RadioButton rbt_cpf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_busca;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_recarregar;
    }
}