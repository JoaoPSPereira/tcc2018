namespace Projeto
{
    partial class tela_tag_confirmation
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ok = new System.Windows.Forms.Label();
            this.lbl_negated = new System.Windows.Forms.Label();
            this.usb_arduino = new System.IO.Ports.SerialPort(this.components);
            this.lbl_texto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Passe sua credêncial";
            // 
            // lbl_ok
            // 
            this.lbl_ok.AutoSize = true;
            this.lbl_ok.Enabled = false;
            this.lbl_ok.Font = new System.Drawing.Font("Franklin Gothic Medium", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ok.ForeColor = System.Drawing.Color.SpringGreen;
            this.lbl_ok.Location = new System.Drawing.Point(453, 289);
            this.lbl_ok.Name = "lbl_ok";
            this.lbl_ok.Size = new System.Drawing.Size(54, 37);
            this.lbl_ok.TabIndex = 1;
            this.lbl_ok.Text = "OK";
            this.lbl_ok.Visible = false;
            this.lbl_ok.Click += new System.EventHandler(this.lbl_ok_Click);
            // 
            // lbl_negated
            // 
            this.lbl_negated.AutoSize = true;
            this.lbl_negated.Font = new System.Drawing.Font("Franklin Gothic Medium", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_negated.ForeColor = System.Drawing.Color.Red;
            this.lbl_negated.Location = new System.Drawing.Point(271, 210);
            this.lbl_negated.Name = "lbl_negated";
            this.lbl_negated.Size = new System.Drawing.Size(236, 37);
            this.lbl_negated.TabIndex = 2;
            this.lbl_negated.Text = "ACESSO NEGADO";
            this.lbl_negated.Visible = false;
            // 
            // usb_arduino
            // 
            this.usb_arduino.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.usb_arduino_DataReceived);
            // 
            // lbl_texto
            // 
            this.lbl_texto.AutoSize = true;
            this.lbl_texto.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_texto.Location = new System.Drawing.Point(123, 291);
            this.lbl_texto.Name = "lbl_texto";
            this.lbl_texto.Size = new System.Drawing.Size(324, 34);
            this.lbl_texto.TabIndex = 3;
            this.lbl_texto.Text = "Clique para continuar >>>";
            this.lbl_texto.Visible = false;
            // 
            // tela_tag_confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lbl_texto);
            this.Controls.Add(this.lbl_negated);
            this.Controls.Add(this.lbl_ok);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "tela_tag_confirmation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tela_tag_confirmation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.tela_tag_confirmation_FormClosing);
            this.Load += new System.EventHandler(this.tela_tag_confirmation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_ok;
        private System.Windows.Forms.Label lbl_negated;
        private System.IO.Ports.SerialPort usb_arduino;
        private System.Windows.Forms.Label lbl_texto;
    }
}