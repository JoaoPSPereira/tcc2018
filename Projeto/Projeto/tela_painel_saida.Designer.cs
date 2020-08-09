namespace Projeto
{
    partial class tela_painel_saida
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
            this.gbx_radios = new System.Windows.Forms.GroupBox();
            this.rbt_descricao = new System.Windows.Forms.RadioButton();
            this.rbt_nome = new System.Windows.Forms.RadioButton();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_busca = new System.Windows.Forms.TextBox();
            this.btn_compra = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.painel = new System.Windows.Forms.Panel();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.gbx_radios.SuspendLayout();
            this.painel.SuspendLayout();
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
            this.dgv.Location = new System.Drawing.Point(12, 225);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(960, 424);
            this.dgv.TabIndex = 24;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // gbx_radios
            // 
            this.gbx_radios.Controls.Add(this.rbt_descricao);
            this.gbx_radios.Controls.Add(this.rbt_nome);
            this.gbx_radios.Location = new System.Drawing.Point(25, 146);
            this.gbx_radios.Name = "gbx_radios";
            this.gbx_radios.Size = new System.Drawing.Size(228, 73);
            this.gbx_radios.TabIndex = 21;
            this.gbx_radios.TabStop = false;
            this.gbx_radios.Text = "Pesquisar por:";
            // 
            // rbt_descricao
            // 
            this.rbt_descricao.AutoSize = true;
            this.rbt_descricao.Location = new System.Drawing.Point(103, 28);
            this.rbt_descricao.Name = "rbt_descricao";
            this.rbt_descricao.Size = new System.Drawing.Size(108, 28);
            this.rbt_descricao.TabIndex = 6;
            this.rbt_descricao.Text = "Descrição";
            this.rbt_descricao.UseVisualStyleBackColor = true;
            // 
            // rbt_nome
            // 
            this.rbt_nome.AutoSize = true;
            this.rbt_nome.Checked = true;
            this.rbt_nome.Location = new System.Drawing.Point(20, 28);
            this.rbt_nome.Name = "rbt_nome";
            this.rbt_nome.Size = new System.Drawing.Size(77, 28);
            this.rbt_nome.TabIndex = 5;
            this.rbt_nome.TabStop = true;
            this.rbt_nome.Text = "Nome";
            this.rbt_nome.UseVisualStyleBackColor = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_buscar.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(831, 88);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(115, 40);
            this.btn_buscar.TabIndex = 18;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_busca
            // 
            this.txt_busca.Font = new System.Drawing.Font("Franklin Gothic Medium", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_busca.Location = new System.Drawing.Point(25, 88);
            this.txt_busca.MaxLength = 50;
            this.txt_busca.Name = "txt_busca";
            this.txt_busca.Size = new System.Drawing.Size(800, 40);
            this.txt_busca.TabIndex = 17;
            // 
            // btn_compra
            // 
            this.btn_compra.BackColor = System.Drawing.Color.Gold;
            this.btn_compra.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_compra.Location = new System.Drawing.Point(820, 12);
            this.btn_compra.Name = "btn_compra";
            this.btn_compra.Size = new System.Drawing.Size(141, 46);
            this.btn_compra.TabIndex = 25;
            this.btn_compra.Text = "Compra (0)";
            this.btn_compra.UseVisualStyleBackColor = false;
            this.btn_compra.Click += new System.EventHandler(this.btn_compra_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_add.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(755, 166);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(206, 43);
            this.btn_add.TabIndex = 26;
            this.btn_add.Text = "Adicionar à compra";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 34);
            this.label1.TabIndex = 27;
            this.label1.Text = "Painel de Retirada";
            // 
            // painel
            // 
            this.painel.BackColor = System.Drawing.SystemColors.Control;
            this.painel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painel.Controls.Add(this.btn_cancelar);
            this.painel.Controls.Add(this.btn_confirmar);
            this.painel.Controls.Add(this.label7);
            this.painel.Controls.Add(this.txt_quantidade);
            this.painel.Location = new System.Drawing.Point(294, 240);
            this.painel.Name = "painel";
            this.painel.Size = new System.Drawing.Size(396, 180);
            this.painel.TabIndex = 28;
            this.painel.Visible = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.IndianRed;
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(48, 117);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(132, 44);
            this.btn_cancelar.TabIndex = 22;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_confirmar.ForeColor = System.Drawing.Color.White;
            this.btn_confirmar.Location = new System.Drawing.Point(215, 117);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(132, 44);
            this.btn_confirmar.TabIndex = 21;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = false;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(109, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 26);
            this.label7.TabIndex = 20;
            this.label7.Text = "Digite a quantidade";
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantidade.Location = new System.Drawing.Point(148, 62);
            this.txt_quantidade.MaxLength = 50;
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(100, 38);
            this.txt_quantidade.TabIndex = 19;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(308, 30);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(63, 26);
            this.lbl_nome.TabIndex = 29;
            this.lbl_nome.Text = "nome";
            // 
            // tela_painel_saida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.painel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_compra);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.gbx_radios);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_busca);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "tela_painel_saida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tela_painel_saida";
            this.Load += new System.EventHandler(this.tela_painel_saida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.gbx_radios.ResumeLayout(false);
            this.gbx_radios.PerformLayout();
            this.painel.ResumeLayout(false);
            this.painel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox gbx_radios;
        private System.Windows.Forms.RadioButton rbt_descricao;
        private System.Windows.Forms.RadioButton rbt_nome;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_busca;
        private System.Windows.Forms.Button btn_compra;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel painel;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Button btn_cancelar;
    }
}