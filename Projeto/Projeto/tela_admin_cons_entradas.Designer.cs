namespace Projeto
{
    partial class tela_admin_cons_entradas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_recarregar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lbl_busca = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbx_radios = new System.Windows.Forms.GroupBox();
            this.rbt_data = new System.Windows.Forms.RadioButton();
            this.rbt_pessoa = new System.Windows.Forms.RadioButton();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_busca = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.gbx_radios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_recarregar
            // 
            this.btn_recarregar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_recarregar.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recarregar.ForeColor = System.Drawing.Color.White;
            this.btn_recarregar.Location = new System.Drawing.Point(168, 556);
            this.btn_recarregar.Name = "btn_recarregar";
            this.btn_recarregar.Size = new System.Drawing.Size(147, 52);
            this.btn_recarregar.TabIndex = 42;
            this.btn_recarregar.Text = "Recarregar";
            this.btn_recarregar.UseVisualStyleBackColor = false;
            this.btn_recarregar.Click += new System.EventHandler(this.btn_recarregar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.IndianRed;
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(15, 557);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(147, 52);
            this.btn_cancelar.TabIndex = 41;
            this.btn_cancelar.Text = "Fechar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lbl_busca
            // 
            this.lbl_busca.AutoSize = true;
            this.lbl_busca.Location = new System.Drawing.Point(386, 114);
            this.lbl_busca.Name = "lbl_busca";
            this.lbl_busca.Size = new System.Drawing.Size(196, 24);
            this.lbl_busca.TabIndex = 40;
            this.lbl_busca.Text = "Últimos 30 registrados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(386, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 24);
            this.label1.TabIndex = 39;
            this.label1.Text = "Exibindo resultados da busca por:";
            // 
            // gbx_radios
            // 
            this.gbx_radios.Controls.Add(this.rbt_data);
            this.gbx_radios.Controls.Add(this.rbt_pessoa);
            this.gbx_radios.Location = new System.Drawing.Point(31, 72);
            this.gbx_radios.Name = "gbx_radios";
            this.gbx_radios.Size = new System.Drawing.Size(267, 66);
            this.gbx_radios.TabIndex = 38;
            this.gbx_radios.TabStop = false;
            this.gbx_radios.Text = "Pesquisar por:";
            // 
            // rbt_data
            // 
            this.rbt_data.AutoSize = true;
            this.rbt_data.Location = new System.Drawing.Point(147, 28);
            this.rbt_data.Name = "rbt_data";
            this.rbt_data.Size = new System.Drawing.Size(66, 28);
            this.rbt_data.TabIndex = 6;
            this.rbt_data.Text = "Data";
            this.rbt_data.UseVisualStyleBackColor = true;
            // 
            // rbt_pessoa
            // 
            this.rbt_pessoa.AutoSize = true;
            this.rbt_pessoa.Checked = true;
            this.rbt_pessoa.Location = new System.Drawing.Point(39, 28);
            this.rbt_pessoa.Name = "rbt_pessoa";
            this.rbt_pessoa.Size = new System.Drawing.Size(87, 28);
            this.rbt_pessoa.TabIndex = 5;
            this.rbt_pessoa.TabStop = true;
            this.rbt_pessoa.Text = "Pessoa";
            this.rbt_pessoa.UseVisualStyleBackColor = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_buscar.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(848, 26);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(115, 40);
            this.btn_buscar.TabIndex = 37;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_busca
            // 
            this.txt_busca.Font = new System.Drawing.Font("Franklin Gothic Medium", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_busca.Location = new System.Drawing.Point(31, 26);
            this.txt_busca.MaxLength = 50;
            this.txt_busca.Name = "txt_busca";
            this.txt_busca.Size = new System.Drawing.Size(811, 40);
            this.txt_busca.TabIndex = 36;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(17, 154);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(960, 397);
            this.dgv.TabIndex = 35;
            // 
            // tela_admin_cons_entradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 619);
            this.Controls.Add(this.btn_recarregar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.lbl_busca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbx_radios);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_busca);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "tela_admin_cons_entradas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tela_admin_cons_entradas";
            this.Load += new System.EventHandler(this.tela_admin_cons_entradas_Load);
            this.gbx_radios.ResumeLayout(false);
            this.gbx_radios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_recarregar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lbl_busca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbx_radios;
        private System.Windows.Forms.RadioButton rbt_data;
        private System.Windows.Forms.RadioButton rbt_pessoa;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_busca;
        private System.Windows.Forms.DataGridView dgv;
    }
}