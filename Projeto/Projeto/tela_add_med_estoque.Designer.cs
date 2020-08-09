namespace Projeto
{
    partial class tela_add_med_estoque
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_busca = new System.Windows.Forms.TextBox();
            this.gbx_radios = new System.Windows.Forms.GroupBox();
            this.rbt_descricao = new System.Windows.Forms.RadioButton();
            this.rbt_nome = new System.Windows.Forms.RadioButton();
            this.btn_add = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_recarregar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.painel_detalhes = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.lbl_qntEstoque = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lbl_conteudo = new System.Windows.Forms.Label();
            this.lbl_qntCaixa = new System.Windows.Forms.Label();
            this.lbl_descricao = new System.Windows.Forms.Label();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.painel = new System.Windows.Forms.Panel();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbx_medida = new System.Windows.Forms.ComboBox();
            this.txt_conteudo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_qnt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_tipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_descricao = new System.Windows.Forms.RichTextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.gbx_radios.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.painel_detalhes.SuspendLayout();
            this.painel.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(19, 167);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(933, 523);
            this.dgv.TabIndex = 17;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_buscar.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_buscar.Location = new System.Drawing.Point(827, 24);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(115, 40);
            this.btn_buscar.TabIndex = 19;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_busca
            // 
            this.txt_busca.Font = new System.Drawing.Font("Franklin Gothic Medium", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_busca.Location = new System.Drawing.Point(35, 24);
            this.txt_busca.MaxLength = 50;
            this.txt_busca.Name = "txt_busca";
            this.txt_busca.Size = new System.Drawing.Size(786, 40);
            this.txt_busca.TabIndex = 18;
            // 
            // gbx_radios
            // 
            this.gbx_radios.Controls.Add(this.rbt_descricao);
            this.gbx_radios.Controls.Add(this.rbt_nome);
            this.gbx_radios.Location = new System.Drawing.Point(21, 73);
            this.gbx_radios.Name = "gbx_radios";
            this.gbx_radios.Size = new System.Drawing.Size(286, 73);
            this.gbx_radios.TabIndex = 20;
            this.gbx_radios.TabStop = false;
            this.gbx_radios.Text = "Pesquisar por:";
            // 
            // rbt_descricao
            // 
            this.rbt_descricao.AutoSize = true;
            this.rbt_descricao.Location = new System.Drawing.Point(140, 28);
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
            this.rbt_nome.Location = new System.Drawing.Point(38, 28);
            this.rbt_nome.Name = "rbt_nome";
            this.rbt_nome.Size = new System.Drawing.Size(77, 28);
            this.rbt_nome.TabIndex = 5;
            this.rbt_nome.TabStop = true;
            this.rbt_nome.Text = "Nome";
            this.rbt_nome.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_add.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(746, 101);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(206, 43);
            this.btn_add.TabIndex = 21;
            this.btn_add.Text = "Adicionar Unidades";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(981, 756);
            this.tabControl1.TabIndex = 22;
            this.tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_recarregar);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.painel_detalhes);
            this.tabPage1.Controls.Add(this.painel);
            this.tabPage1.Controls.Add(this.txt_busca);
            this.tabPage1.Controls.Add(this.btn_add);
            this.tabPage1.Controls.Add(this.dgv);
            this.tabPage1.Controls.Add(this.gbx_radios);
            this.tabPage1.Controls.Add(this.btn_buscar);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(973, 719);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Adicionar Unidades";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_recarregar
            // 
            this.btn_recarregar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_recarregar.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recarregar.ForeColor = System.Drawing.Color.White;
            this.btn_recarregar.Location = new System.Drawing.Point(423, 101);
            this.btn_recarregar.Name = "btn_recarregar";
            this.btn_recarregar.Size = new System.Drawing.Size(140, 47);
            this.btn_recarregar.TabIndex = 25;
            this.btn_recarregar.Text = "Recarregar";
            this.btn_recarregar.UseVisualStyleBackColor = false;
            this.btn_recarregar.Click += new System.EventHandler(this.btn_recarregar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Khaki;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(569, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 45);
            this.button1.TabIndex = 24;
            this.button1.Text = "Exibir Detalhes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // painel_detalhes
            // 
            this.painel_detalhes.BackColor = System.Drawing.SystemColors.Control;
            this.painel_detalhes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painel_detalhes.Controls.Add(this.btn_fechar);
            this.painel_detalhes.Controls.Add(this.lbl_qntEstoque);
            this.painel_detalhes.Controls.Add(this.label15);
            this.painel_detalhes.Controls.Add(this.lbl_id);
            this.painel_detalhes.Controls.Add(this.label21);
            this.painel_detalhes.Controls.Add(this.lbl_conteudo);
            this.painel_detalhes.Controls.Add(this.lbl_qntCaixa);
            this.painel_detalhes.Controls.Add(this.lbl_descricao);
            this.painel_detalhes.Controls.Add(this.lbl_tipo);
            this.painel_detalhes.Controls.Add(this.label16);
            this.painel_detalhes.Controls.Add(this.lbl_nome);
            this.painel_detalhes.Controls.Add(this.label14);
            this.painel_detalhes.Controls.Add(this.label13);
            this.painel_detalhes.Controls.Add(this.label12);
            this.painel_detalhes.Controls.Add(this.label11);
            this.painel_detalhes.Controls.Add(this.label10);
            this.painel_detalhes.Controls.Add(this.label9);
            this.painel_detalhes.Location = new System.Drawing.Point(193, 203);
            this.painel_detalhes.Name = "painel_detalhes";
            this.painel_detalhes.Size = new System.Drawing.Size(628, 396);
            this.painel_detalhes.TabIndex = 23;
            this.painel_detalhes.Visible = false;
            this.painel_detalhes.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackColor = System.Drawing.Color.DarkRed;
            this.btn_fechar.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fechar.ForeColor = System.Drawing.Color.White;
            this.btn_fechar.Location = new System.Drawing.Point(581, 3);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(42, 35);
            this.btn_fechar.TabIndex = 25;
            this.btn_fechar.Text = "X";
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // lbl_qntEstoque
            // 
            this.lbl_qntEstoque.AutoSize = true;
            this.lbl_qntEstoque.Location = new System.Drawing.Point(448, 339);
            this.lbl_qntEstoque.Name = "lbl_qntEstoque";
            this.lbl_qntEstoque.Size = new System.Drawing.Size(131, 24);
            this.lbl_qntEstoque.TabIndex = 15;
            this.lbl_qntEstoque.Text = "lbl_qntEstoque";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(276, 339);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(166, 24);
            this.label15.TabIndex = 14;
            this.label15.Text = "Qnt. em Estoque:";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(59, 62);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(55, 24);
            this.lbl_id.TabIndex = 13;
            this.lbl_id.Text = "lbl_id";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(18, 62);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 24);
            this.label21.TabIndex = 12;
            this.label21.Text = "ID:";
            // 
            // lbl_conteudo
            // 
            this.lbl_conteudo.AutoSize = true;
            this.lbl_conteudo.Location = new System.Drawing.Point(125, 339);
            this.lbl_conteudo.Name = "lbl_conteudo";
            this.lbl_conteudo.Size = new System.Drawing.Size(115, 24);
            this.lbl_conteudo.TabIndex = 11;
            this.lbl_conteudo.Text = "lbl_conteudo";
            // 
            // lbl_qntCaixa
            // 
            this.lbl_qntCaixa.AutoSize = true;
            this.lbl_qntCaixa.Location = new System.Drawing.Point(402, 292);
            this.lbl_qntCaixa.Name = "lbl_qntCaixa";
            this.lbl_qntCaixa.Size = new System.Drawing.Size(110, 24);
            this.lbl_qntCaixa.TabIndex = 10;
            this.lbl_qntCaixa.Text = "lbl_qntCaixa";
            // 
            // lbl_descricao
            // 
            this.lbl_descricao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_descricao.Location = new System.Drawing.Point(18, 170);
            this.lbl_descricao.Name = "lbl_descricao";
            this.lbl_descricao.Size = new System.Drawing.Size(549, 110);
            this.lbl_descricao.TabIndex = 9;
            this.lbl_descricao.Text = "lbl_descricao\r\n";
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Location = new System.Drawing.Point(78, 292);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(71, 24);
            this.lbl_tipo.TabIndex = 8;
            this.lbl_tipo.Text = "lbl_tipo";
            // 
            // label16
            // 
            this.label16.AutoEllipsis = true;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 170);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(10, 72);
            this.label16.TabIndex = 7;
            this.label16.Text = "\r\n\r\n\r\n";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(93, 101);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(87, 24);
            this.lbl_nome.TabIndex = 6;
            this.lbl_nome.Text = "lbl_nome";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(18, 339);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 24);
            this.label14.TabIndex = 5;
            this.label14.Text = "Conteúdo:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(261, 292);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 24);
            this.label13.TabIndex = 4;
            this.label13.Text = "Qnt. p/ Caixa:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 292);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 24);
            this.label12.TabIndex = 3;
            this.label12.Text = "Tipo:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 24);
            this.label11.TabIndex = 2;
            this.label11.Text = "Descrição:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 24);
            this.label10.TabIndex = 1;
            this.label10.Text = "Nome:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(272, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 30);
            this.label9.TabIndex = 0;
            this.label9.Text = "Datalhes";
            // 
            // painel
            // 
            this.painel.BackColor = System.Drawing.SystemColors.Control;
            this.painel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painel.Controls.Add(this.button2);
            this.painel.Controls.Add(this.btn_confirmar);
            this.painel.Controls.Add(this.label7);
            this.painel.Controls.Add(this.txt_quantidade);
            this.painel.Location = new System.Drawing.Point(290, 212);
            this.painel.Name = "painel";
            this.painel.Size = new System.Drawing.Size(396, 180);
            this.painel.TabIndex = 22;
            this.painel.Visible = false;
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_confirmar.ForeColor = System.Drawing.Color.White;
            this.btn_confirmar.Location = new System.Drawing.Point(219, 117);
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_cancelar);
            this.tabPage2.Controls.Add(this.btn_cadastrar);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.cbx_medida);
            this.tabPage2.Controls.Add(this.txt_conteudo);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txt_qnt);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cbx_tipo);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txt_descricao);
            this.tabPage2.Controls.Add(this.txt_nome);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(973, 719);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cadastrar Item";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.IndianRed;
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(252, 438);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(107, 44);
            this.btn_cancelar.TabIndex = 33;
            this.btn_cancelar.Text = "Fechar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_cadastrar.ForeColor = System.Drawing.Color.White;
            this.btn_cadastrar.Location = new System.Drawing.Point(523, 438);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(153, 44);
            this.btn_cadastrar.TabIndex = 32;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(500, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 21);
            this.label8.TabIndex = 31;
            this.label8.Text = "*Campos Obrigatórios";
            // 
            // cbx_medida
            // 
            this.cbx_medida.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_medida.FormattingEnabled = true;
            this.cbx_medida.Items.AddRange(new object[] {
            "mg",
            "ml"});
            this.cbx_medida.Location = new System.Drawing.Point(513, 383);
            this.cbx_medida.Name = "cbx_medida";
            this.cbx_medida.Size = new System.Drawing.Size(56, 29);
            this.cbx_medida.TabIndex = 30;
            // 
            // txt_conteudo
            // 
            this.txt_conteudo.Location = new System.Drawing.Point(427, 383);
            this.txt_conteudo.MaxLength = 40;
            this.txt_conteudo.Name = "txt_conteudo";
            this.txt_conteudo.Size = new System.Drawing.Size(80, 29);
            this.txt_conteudo.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 24);
            this.label6.TabIndex = 28;
            this.label6.Text = "*Conteúdo(mg/ml):";
            // 
            // txt_qnt
            // 
            this.txt_qnt.Location = new System.Drawing.Point(407, 343);
            this.txt_qnt.MaxLength = 40;
            this.txt_qnt.Name = "txt_qnt";
            this.txt_qnt.Size = new System.Drawing.Size(69, 29);
            this.txt_qnt.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "*Qnt. p/ unidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(361, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 26);
            this.label4.TabIndex = 25;
            this.label4.Text = "Cadastrar Medicamento";
            // 
            // cbx_tipo
            // 
            this.cbx_tipo.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_tipo.FormattingEnabled = true;
            this.cbx_tipo.Items.AddRange(new object[] {
            "Sólido Oral",
            "Líquido Oral",
            "Líquido Intravenoso",
            "Outro"});
            this.cbx_tipo.Location = new System.Drawing.Point(314, 301);
            this.cbx_tipo.Name = "cbx_tipo";
            this.cbx_tipo.Size = new System.Drawing.Size(162, 29);
            this.cbx_tipo.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "*Tipo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Descrição:";
            // 
            // txt_descricao
            // 
            this.txt_descricao.Location = new System.Drawing.Point(252, 169);
            this.txt_descricao.MaxLength = 255;
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txt_descricao.Size = new System.Drawing.Size(424, 115);
            this.txt_descricao.TabIndex = 21;
            this.txt_descricao.Text = "";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(252, 99);
            this.txt_nome.MaxLength = 40;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(424, 29);
            this.txt_nome.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "*Nome:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(48, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 44);
            this.button2.TabIndex = 23;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tela_add_med_estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "tela_add_med_estoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada de Medicamentos em Estoque";
            this.Load += new System.EventHandler(this.tela_add_med_estoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.gbx_radios.ResumeLayout(false);
            this.gbx_radios.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.painel_detalhes.ResumeLayout(false);
            this.painel_detalhes.PerformLayout();
            this.painel.ResumeLayout(false);
            this.painel.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_busca;
        private System.Windows.Forms.GroupBox gbx_radios;
        private System.Windows.Forms.RadioButton rbt_descricao;
        private System.Windows.Forms.RadioButton rbt_nome;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbx_medida;
        private System.Windows.Forms.TextBox txt_conteudo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_qnt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_tipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txt_descricao;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel painel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Panel painel_detalhes;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_descricao;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_conteudo;
        private System.Windows.Forms.Label lbl_qntCaixa;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lbl_qntEstoque;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_recarregar;
        private System.Windows.Forms.Button button2;
    }
}