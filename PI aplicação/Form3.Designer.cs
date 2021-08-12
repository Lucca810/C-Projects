namespace PI_aplicação
{
    partial class frm_forn
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_log = new System.Windows.Forms.TextBox();
            this.btn_limp = new System.Windows.Forms.Button();
            this.btn_guard = new System.Windows.Forms.Button();
            this.lbl_cabeçalho = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_comp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CNPJ do fornecedor";
            // 
            // txt_cnpj
            // 
            this.txt_cnpj.Location = new System.Drawing.Point(17, 72);
            this.txt_cnpj.Mask = "00.000.000/0000-00";
            this.txt_cnpj.Name = "txt_cnpj";
            this.txt_cnpj.Size = new System.Drawing.Size(106, 20);
            this.txt_cnpj.TabIndex = 1;
            this.txt_cnpj.Leave += new System.EventHandler(this.txt_cnpj_Leave);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(17, 119);
            this.txt_nome.MaxLength = 45;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(217, 20);
            this.txt_nome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome do fornecedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Logradouro do fornecedor";
            // 
            // txt_log
            // 
            this.txt_log.Location = new System.Drawing.Point(17, 169);
            this.txt_log.MaxLength = 100;
            this.txt_log.Name = "txt_log";
            this.txt_log.Size = new System.Drawing.Size(217, 20);
            this.txt_log.TabIndex = 4;
            // 
            // btn_limp
            // 
            this.btn_limp.Location = new System.Drawing.Point(128, 293);
            this.btn_limp.Name = "btn_limp";
            this.btn_limp.Size = new System.Drawing.Size(106, 23);
            this.btn_limp.TabIndex = 8;
            this.btn_limp.Text = "Limpar";
            this.btn_limp.UseVisualStyleBackColor = true;
            this.btn_limp.Click += new System.EventHandler(this.btn_limp_Click);
            // 
            // btn_guard
            // 
            this.btn_guard.Location = new System.Drawing.Point(15, 293);
            this.btn_guard.Name = "btn_guard";
            this.btn_guard.Size = new System.Drawing.Size(108, 23);
            this.btn_guard.TabIndex = 7;
            this.btn_guard.Text = "Guarda";
            this.btn_guard.UseVisualStyleBackColor = true;
            this.btn_guard.Click += new System.EventHandler(this.btn_guard_Click);
            // 
            // lbl_cabeçalho
            // 
            this.lbl_cabeçalho.AutoSize = true;
            this.lbl_cabeçalho.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cabeçalho.Location = new System.Drawing.Point(12, 9);
            this.lbl_cabeçalho.Name = "lbl_cabeçalho";
            this.lbl_cabeçalho.Size = new System.Drawing.Size(125, 25);
            this.lbl_cabeçalho.TabIndex = 14;
            this.lbl_cabeçalho.Text = "fornecedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Número do fornecedor";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(17, 211);
            this.txt_numero.MaxLength = 5;
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(217, 20);
            this.txt_numero.TabIndex = 5;
            this.txt_numero.Leave += new System.EventHandler(this.txt_numero_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Complemento do fornecedor";
            // 
            // txt_comp
            // 
            this.txt_comp.Location = new System.Drawing.Point(17, 253);
            this.txt_comp.MaxLength = 100;
            this.txt_comp.Name = "txt_comp";
            this.txt_comp.Size = new System.Drawing.Size(217, 20);
            this.txt_comp.TabIndex = 6;
            // 
            // frm_forn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 335);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_comp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.lbl_cabeçalho);
            this.Controls.Add(this.btn_limp);
            this.Controls.Add(this.btn_guard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_log);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_cnpj);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(275, 374);
            this.MinimumSize = new System.Drawing.Size(275, 374);
            this.Name = "frm_forn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fornecedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txt_cnpj;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_log;
        private System.Windows.Forms.Button btn_limp;
        private System.Windows.Forms.Button btn_guard;
        private System.Windows.Forms.Label lbl_cabeçalho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_comp;
    }
}