namespace Projeto
{
    partial class tela_admin_exibe_venda
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_id_venda = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_nome_pessoa = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_tag_pessoa = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_data_retirada = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_id_entrada = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_data_entrada = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_data_saida = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
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
            this.dgv.Location = new System.Drawing.Point(26, 216);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(729, 482);
            this.dgv.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Itens da venda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "Exibindo venda Nº";
            // 
            // lbl_id_venda
            // 
            this.lbl_id_venda.AutoSize = true;
            this.lbl_id_venda.Location = new System.Drawing.Point(192, 20);
            this.lbl_id_venda.Name = "lbl_id_venda";
            this.lbl_id_venda.Size = new System.Drawing.Size(131, 24);
            this.lbl_id_venda.TabIndex = 29;
            this.lbl_id_venda.Text = "00000000000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "Responsável: ";
            // 
            // lbl_nome_pessoa
            // 
            this.lbl_nome_pessoa.AutoSize = true;
            this.lbl_nome_pessoa.Location = new System.Drawing.Point(157, 58);
            this.lbl_nome_pessoa.Name = "lbl_nome_pessoa";
            this.lbl_nome_pessoa.Size = new System.Drawing.Size(123, 24);
            this.lbl_nome_pessoa.TabIndex = 31;
            this.lbl_nome_pessoa.Text = "Nome Pessoa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 24);
            this.label4.TabIndex = 32;
            this.label4.Text = "TAG:";
            // 
            // lbl_tag_pessoa
            // 
            this.lbl_tag_pessoa.AutoSize = true;
            this.lbl_tag_pessoa.Location = new System.Drawing.Point(157, 82);
            this.lbl_tag_pessoa.Name = "lbl_tag_pessoa";
            this.lbl_tag_pessoa.Size = new System.Drawing.Size(113, 24);
            this.lbl_tag_pessoa.TabIndex = 33;
            this.lbl_tag_pessoa.Text = "XX.XX.XX.XX";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 24);
            this.label5.TabIndex = 34;
            this.label5.Text = "Data da Retirada:";
            // 
            // lbl_data_retirada
            // 
            this.lbl_data_retirada.AutoSize = true;
            this.lbl_data_retirada.Location = new System.Drawing.Point(550, 20);
            this.lbl_data_retirada.Name = "lbl_data_retirada";
            this.lbl_data_retirada.Size = new System.Drawing.Size(175, 24);
            this.lbl_data_retirada.TabIndex = 35;
            this.lbl_data_retirada.Text = "00/00/00 00:00:00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 24);
            this.label7.TabIndex = 36;
            this.label7.Text = "Registro de entrada:";
            // 
            // lbl_id_entrada
            // 
            this.lbl_id_entrada.AutoSize = true;
            this.lbl_id_entrada.Location = new System.Drawing.Point(212, 123);
            this.lbl_id_entrada.Name = "lbl_id_entrada";
            this.lbl_id_entrada.Size = new System.Drawing.Size(131, 24);
            this.lbl_id_entrada.TabIndex = 37;
            this.lbl_id_entrada.Text = "00000000000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(402, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 24);
            this.label9.TabIndex = 38;
            this.label9.Text = "Data da Entrada:";
            // 
            // lbl_data_entrada
            // 
            this.lbl_data_entrada.AutoSize = true;
            this.lbl_data_entrada.Location = new System.Drawing.Point(543, 123);
            this.lbl_data_entrada.Name = "lbl_data_entrada";
            this.lbl_data_entrada.Size = new System.Drawing.Size(175, 24);
            this.lbl_data_entrada.TabIndex = 39;
            this.lbl_data_entrada.Text = "00/00/00 00:00:00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(418, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 24);
            this.label11.TabIndex = 40;
            this.label11.Text = "Data de Saída:";
            // 
            // lbl_data_saida
            // 
            this.lbl_data_saida.AutoSize = true;
            this.lbl_data_saida.Location = new System.Drawing.Point(543, 147);
            this.lbl_data_saida.Name = "lbl_data_saida";
            this.lbl_data_saida.Size = new System.Drawing.Size(175, 24);
            this.lbl_data_saida.TabIndex = 41;
            this.lbl_data_saida.Text = "00/00/00 00:00:00";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.IndianRed;
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(12, 713);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(147, 52);
            this.btn_cancelar.TabIndex = 42;
            this.btn_cancelar.Text = "Voltar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // tela_admin_exibe_venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 778);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.lbl_data_saida);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbl_data_entrada);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_id_entrada);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_data_retirada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_tag_pessoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_nome_pessoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_id_venda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "tela_admin_exibe_venda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tela_admin_exibe_venda";
            this.Load += new System.EventHandler(this.tela_admin_exibe_venda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_id_venda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_nome_pessoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_tag_pessoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_data_retirada;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_id_entrada;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_data_entrada;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_data_saida;
        private System.Windows.Forms.Button btn_cancelar;
    }
}