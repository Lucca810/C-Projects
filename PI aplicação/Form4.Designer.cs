namespace PI_aplicação
{
    partial class frm_alt
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
            this.lbl_cabeçalho = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cod_itm = new System.Windows.Forms.TextBox();
            this.txt_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nom_itm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nom_forn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_qtd_alt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_alt = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_limp = new System.Windows.Forms.Button();
            this.btn_guard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_cabeçalho
            // 
            this.lbl_cabeçalho.AutoSize = true;
            this.lbl_cabeçalho.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cabeçalho.Location = new System.Drawing.Point(12, 9);
            this.lbl_cabeçalho.Name = "lbl_cabeçalho";
            this.lbl_cabeçalho.Size = new System.Drawing.Size(110, 25);
            this.lbl_cabeçalho.TabIndex = 15;
            this.lbl_cabeçalho.Text = "alteração";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Código do item";
            // 
            // txt_cod_itm
            // 
            this.txt_cod_itm.Location = new System.Drawing.Point(17, 71);
            this.txt_cod_itm.MaxLength = 8;
            this.txt_cod_itm.Name = "txt_cod_itm";
            this.txt_cod_itm.Size = new System.Drawing.Size(120, 20);
            this.txt_cod_itm.TabIndex = 17;
            this.txt_cod_itm.TextChanged += new System.EventHandler(this.txt_cod_itm_TextChanged);
            this.txt_cod_itm.Leave += new System.EventHandler(this.txt_cod_itm_Leave);
            // 
            // txt_cnpj
            // 
            this.txt_cnpj.Location = new System.Drawing.Point(143, 71);
            this.txt_cnpj.Mask = "00.000.000/0000-00";
            this.txt_cnpj.Name = "txt_cnpj";
            this.txt_cnpj.Size = new System.Drawing.Size(106, 20);
            this.txt_cnpj.TabIndex = 19;
            this.txt_cnpj.Leave += new System.EventHandler(this.txt_cnpj_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "CNPJ do fornecedor";
            // 
            // txt_nom_itm
            // 
            this.txt_nom_itm.Enabled = false;
            this.txt_nom_itm.Location = new System.Drawing.Point(17, 126);
            this.txt_nom_itm.MaxLength = 45;
            this.txt_nom_itm.Name = "txt_nom_itm";
            this.txt_nom_itm.Size = new System.Drawing.Size(232, 20);
            this.txt_nom_itm.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nome do item";
            // 
            // txt_nom_forn
            // 
            this.txt_nom_forn.Enabled = false;
            this.txt_nom_forn.Location = new System.Drawing.Point(17, 182);
            this.txt_nom_forn.MaxLength = 45;
            this.txt_nom_forn.Name = "txt_nom_forn";
            this.txt_nom_forn.Size = new System.Drawing.Size(232, 20);
            this.txt_nom_forn.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Nome do fornecedor";
            // 
            // txt_qtd_alt
            // 
            this.txt_qtd_alt.Location = new System.Drawing.Point(17, 237);
            this.txt_qtd_alt.MaxLength = 5;
            this.txt_qtd_alt.Name = "txt_qtd_alt";
            this.txt_qtd_alt.Size = new System.Drawing.Size(105, 20);
            this.txt_qtd_alt.TabIndex = 25;
            this.txt_qtd_alt.Leave += new System.EventHandler(this.txt_qtd_alt_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Quantidade alterada";
            // 
            // cmb_alt
            // 
            this.cmb_alt.FormattingEnabled = true;
            this.cmb_alt.Items.AddRange(new object[] {
            "Entrada",
            "Saida"});
            this.cmb_alt.Location = new System.Drawing.Point(128, 236);
            this.cmb_alt.Name = "cmb_alt";
            this.cmb_alt.Size = new System.Drawing.Size(121, 21);
            this.cmb_alt.TabIndex = 26;
            this.cmb_alt.SelectedIndexChanged += new System.EventHandler(this.cmb_alt_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Tipo de alteração";
            // 
            // btn_limp
            // 
            this.btn_limp.Location = new System.Drawing.Point(143, 291);
            this.btn_limp.Name = "btn_limp";
            this.btn_limp.Size = new System.Drawing.Size(106, 23);
            this.btn_limp.TabIndex = 29;
            this.btn_limp.Text = "Limpar";
            this.btn_limp.UseVisualStyleBackColor = true;
            this.btn_limp.Click += new System.EventHandler(this.btn_limp_Click);
            // 
            // btn_guard
            // 
            this.btn_guard.Location = new System.Drawing.Point(17, 291);
            this.btn_guard.Name = "btn_guard";
            this.btn_guard.Size = new System.Drawing.Size(105, 23);
            this.btn_guard.TabIndex = 28;
            this.btn_guard.Text = "Guarda";
            this.btn_guard.UseVisualStyleBackColor = true;
            this.btn_guard.Click += new System.EventHandler(this.btn_guard_Click);
            // 
            // frm_alt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 349);
            this.Controls.Add(this.btn_limp);
            this.Controls.Add(this.btn_guard);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_alt);
            this.Controls.Add(this.txt_qtd_alt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_nom_forn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_nom_itm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_cnpj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cod_itm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_cabeçalho);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(297, 388);
            this.MinimumSize = new System.Drawing.Size(297, 388);
            this.Name = "frm_alt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alteração";
            this.Load += new System.EventHandler(this.frm_alt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cabeçalho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cod_itm;
        private System.Windows.Forms.MaskedTextBox txt_cnpj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nom_itm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nom_forn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_qtd_alt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_alt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_limp;
        private System.Windows.Forms.Button btn_guard;
    }
}