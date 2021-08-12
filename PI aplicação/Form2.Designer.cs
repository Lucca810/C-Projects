namespace PI_aplicação
{
    partial class frm_item
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
            this.txt_cod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_qtd_At = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_qtd_Min = new System.Windows.Forms.TextBox();
            this.btn_guard = new System.Windows.Forms.Button();
            this.btn_limp = new System.Windows.Forms.Button();
            this.lbl_cabeçalho = new System.Windows.Forms.Label();
            this.txt_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_forn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_cod
            // 
            this.txt_cod.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.txt_cod.Location = new System.Drawing.Point(17, 72);
            this.txt_cod.MaxLength = 8;
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Size = new System.Drawing.Size(100, 20);
            this.txt_cod.TabIndex = 0;
            this.txt_cod.TextChanged += new System.EventHandler(this.txt_cod_TextChanged);
            this.txt_cod.Leave += new System.EventHandler(this.txt_cod_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código do item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CNPJ do fornecedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descrição do item";
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(17, 133);
            this.txt_desc.MaxLength = 45;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(222, 20);
            this.txt_desc.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantidade atual";
            // 
            // txt_qtd_At
            // 
            this.txt_qtd_At.Location = new System.Drawing.Point(17, 227);
            this.txt_qtd_At.MaxLength = 5;
            this.txt_qtd_At.Name = "txt_qtd_At";
            this.txt_qtd_At.Size = new System.Drawing.Size(100, 20);
            this.txt_qtd_At.TabIndex = 4;
            this.txt_qtd_At.TextChanged += new System.EventHandler(this.txt_qtd_At_TextChanged);
            this.txt_qtd_At.Leave += new System.EventHandler(this.txt_qtd_At_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quantidade mínima";
            // 
            // txt_qtd_Min
            // 
            this.txt_qtd_Min.Location = new System.Drawing.Point(133, 227);
            this.txt_qtd_Min.MaxLength = 5;
            this.txt_qtd_Min.Name = "txt_qtd_Min";
            this.txt_qtd_Min.Size = new System.Drawing.Size(106, 20);
            this.txt_qtd_Min.TabIndex = 5;
            this.txt_qtd_Min.TextChanged += new System.EventHandler(this.txt_qtd_Min_TextChanged);
            this.txt_qtd_Min.Leave += new System.EventHandler(this.txt_qtd_Min_Leave);
            // 
            // btn_guard
            // 
            this.btn_guard.Location = new System.Drawing.Point(16, 264);
            this.btn_guard.Name = "btn_guard";
            this.btn_guard.Size = new System.Drawing.Size(101, 23);
            this.btn_guard.TabIndex = 10;
            this.btn_guard.Text = "Guarda";
            this.btn_guard.UseVisualStyleBackColor = true;
            this.btn_guard.Click += new System.EventHandler(this.btn_guard_Click);
            // 
            // btn_limp
            // 
            this.btn_limp.Location = new System.Drawing.Point(133, 264);
            this.btn_limp.Name = "btn_limp";
            this.btn_limp.Size = new System.Drawing.Size(100, 23);
            this.btn_limp.TabIndex = 11;
            this.btn_limp.Text = "Limpar";
            this.btn_limp.UseVisualStyleBackColor = true;
            this.btn_limp.Click += new System.EventHandler(this.btn_limp_Click);
            // 
            // lbl_cabeçalho
            // 
            this.lbl_cabeçalho.AutoSize = true;
            this.lbl_cabeçalho.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cabeçalho.Location = new System.Drawing.Point(12, 9);
            this.lbl_cabeçalho.Name = "lbl_cabeçalho";
            this.lbl_cabeçalho.Size = new System.Drawing.Size(94, 25);
            this.lbl_cabeçalho.TabIndex = 12;
            this.lbl_cabeçalho.Text = "Produto";
            // 
            // txt_cnpj
            // 
            this.txt_cnpj.Location = new System.Drawing.Point(133, 72);
            this.txt_cnpj.Mask = "00.000.000/0000-00";
            this.txt_cnpj.Name = "txt_cnpj";
            this.txt_cnpj.Size = new System.Drawing.Size(106, 20);
            this.txt_cnpj.TabIndex = 2;
            this.txt_cnpj.Leave += new System.EventHandler(this.txt_cnpj_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Fornecedor";
            // 
            // txt_forn
            // 
            this.txt_forn.Location = new System.Drawing.Point(17, 177);
            this.txt_forn.MaxLength = 45;
            this.txt_forn.Name = "txt_forn";
            this.txt_forn.Size = new System.Drawing.Size(222, 20);
            this.txt_forn.TabIndex = 13;
            // 
            // frm_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 299);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_forn);
            this.Controls.Add(this.txt_cnpj);
            this.Controls.Add(this.lbl_cabeçalho);
            this.Controls.Add(this.btn_limp);
            this.Controls.Add(this.btn_guard);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_qtd_Min);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_qtd_At);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cod);
            this.MaximumSize = new System.Drawing.Size(278, 338);
            this.MinimumSize = new System.Drawing.Size(278, 338);
            this.Name = "frm_item";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_cod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_qtd_At;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_qtd_Min;
        private System.Windows.Forms.Button btn_guard;
        private System.Windows.Forms.Button btn_limp;
        private System.Windows.Forms.Label lbl_cabeçalho;
        private System.Windows.Forms.MaskedTextBox txt_cnpj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_forn;
    }
}