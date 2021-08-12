namespace PI_aplicação
{
    partial class frm_relat
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
            this.dtg_itens = new System.Windows.Forms.DataGridView();
            this.cod_prd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtd_atual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtd_min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_itens)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_cabeçalho
            // 
            this.lbl_cabeçalho.AutoSize = true;
            this.lbl_cabeçalho.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cabeçalho.Location = new System.Drawing.Point(12, 9);
            this.lbl_cabeçalho.Name = "lbl_cabeçalho";
            this.lbl_cabeçalho.Size = new System.Drawing.Size(389, 25);
            this.lbl_cabeçalho.TabIndex = 14;
            this.lbl_cabeçalho.Text = "Relatório de itens abaixo do mínimo";
            // 
            // dtg_itens
            // 
            this.dtg_itens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_itens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_prd,
            this.desc_prod,
            this.cnpj,
            this.fornecedor,
            this.qtd_atual,
            this.qtd_min});
            this.dtg_itens.Location = new System.Drawing.Point(17, 51);
            this.dtg_itens.Name = "dtg_itens";
            this.dtg_itens.Size = new System.Drawing.Size(645, 387);
            this.dtg_itens.TabIndex = 15;
            // 
            // cod_prd
            // 
            this.cod_prd.DataPropertyName = "cod_Produto";
            this.cod_prd.HeaderText = "Código do produto";
            this.cod_prd.Name = "cod_prd";
            this.cod_prd.ReadOnly = true;
            // 
            // desc_prod
            // 
            this.desc_prod.DataPropertyName = "desc_Produto";
            this.desc_prod.HeaderText = "Descrição do produto";
            this.desc_prod.Name = "desc_prod";
            this.desc_prod.ReadOnly = true;
            // 
            // cnpj
            // 
            this.cnpj.DataPropertyName = "cnpj_fornecedor";
            this.cnpj.HeaderText = "CNPJ do fornecedor";
            this.cnpj.Name = "cnpj";
            this.cnpj.ReadOnly = true;
            // 
            // fornecedor
            // 
            this.fornecedor.DataPropertyName = "nome_Fornecedor";
            this.fornecedor.HeaderText = "Fornecedor";
            this.fornecedor.Name = "fornecedor";
            this.fornecedor.ReadOnly = true;
            // 
            // qtd_atual
            // 
            this.qtd_atual.DataPropertyName = "qtd_Produto";
            this.qtd_atual.HeaderText = "Quantidade atual";
            this.qtd_atual.Name = "qtd_atual";
            this.qtd_atual.ReadOnly = true;
            // 
            // qtd_min
            // 
            this.qtd_min.DataPropertyName = "qtd_Produto_Min";
            this.qtd_min.HeaderText = "Quantidade mínima";
            this.qtd_min.Name = "qtd_min";
            this.qtd_min.ReadOnly = true;
            // 
            // frm_relat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 450);
            this.Controls.Add(this.dtg_itens);
            this.Controls.Add(this.lbl_cabeçalho);
            this.MaximumSize = new System.Drawing.Size(705, 489);
            this.MinimumSize = new System.Drawing.Size(705, 489);
            this.Name = "frm_relat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório";
            this.Load += new System.EventHandler(this.frm_relat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_itens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cabeçalho;
        private System.Windows.Forms.DataGridView dtg_itens;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_prd;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtd_atual;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtd_min;
    }
}