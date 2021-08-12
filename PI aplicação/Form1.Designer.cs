namespace PI_aplicação
{
    partial class frm_inicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_alt = new System.Windows.Forms.Button();
            this.txt_consulta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_itens = new System.Windows.Forms.TabPage();
            this.dtg_itens = new System.Windows.Forms.DataGridView();
            this.cod_prd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtd_atual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtd_min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tb_dtgds = new System.Windows.Forms.TabControl();
            this.tb_itensB = new System.Windows.Forms.TabPage();
            this.dtg_itensG = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tb_fornecedores = new System.Windows.Forms.TabPage();
            this.dtg_forn = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tb_entradas = new System.Windows.Forms.TabPage();
            this.dtg_entra = new System.Windows.Forms.DataGridView();
            this.cod_alt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpj_forn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_forn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtd_alt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tb_saidas = new System.Windows.Forms.TabPage();
            this.dtg_saidas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_cad_itm = new System.Windows.Forms.Button();
            this.btn_cad_forn = new System.Windows.Forms.Button();
            this.lbl_cabeçalho = new System.Windows.Forms.Label();
            this.btn_cad_prodB = new System.Windows.Forms.Button();
            this.cmb_filtro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_relat = new System.Windows.Forms.Button();
            this.tb_itens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_itens)).BeginInit();
            this.tb_dtgds.SuspendLayout();
            this.tb_itensB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_itensG)).BeginInit();
            this.tb_fornecedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_forn)).BeginInit();
            this.tb_entradas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_entra)).BeginInit();
            this.tb_saidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_saidas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_alt
            // 
            this.btn_alt.Location = new System.Drawing.Point(554, 470);
            this.btn_alt.Name = "btn_alt";
            this.btn_alt.Size = new System.Drawing.Size(168, 23);
            this.btn_alt.TabIndex = 6;
            this.btn_alt.Text = "Fazer alteração";
            this.btn_alt.UseVisualStyleBackColor = true;
            this.btn_alt.Click += new System.EventHandler(this.btn_alt_Click);
            // 
            // txt_consulta
            // 
            this.txt_consulta.Enabled = false;
            this.txt_consulta.Location = new System.Drawing.Point(32, 81);
            this.txt_consulta.Name = "txt_consulta";
            this.txt_consulta.Size = new System.Drawing.Size(424, 20);
            this.txt_consulta.TabIndex = 1;
            this.txt_consulta.TextChanged += new System.EventHandler(this.txt_consulta_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pesquisar item / fornecedir / entrada / saida";
            // 
            // tb_itens
            // 
            this.tb_itens.Controls.Add(this.dtg_itens);
            this.tb_itens.Location = new System.Drawing.Point(4, 22);
            this.tb_itens.Name = "tb_itens";
            this.tb_itens.Padding = new System.Windows.Forms.Padding(3);
            this.tb_itens.Size = new System.Drawing.Size(955, 331);
            this.tb_itens.TabIndex = 0;
            this.tb_itens.Text = "Produtos";
            this.tb_itens.UseVisualStyleBackColor = true;
            // 
            // dtg_itens
            // 
            this.dtg_itens.AllowUserToAddRows = false;
            this.dtg_itens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_itens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_prd,
            this.desc_prod,
            this.cnpj,
            this.fornecedor,
            this.qtd_atual,
            this.qtd_min,
            this.editar,
            this.excluir});
            this.dtg_itens.Location = new System.Drawing.Point(5, 9);
            this.dtg_itens.Name = "dtg_itens";
            this.dtg_itens.Size = new System.Drawing.Size(944, 316);
            this.dtg_itens.TabIndex = 9;
            this.dtg_itens.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_itens_CellContentClick);
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
            this.fornecedor.Width = 200;
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
            // editar
            // 
            this.editar.HeaderText = "Editar";
            this.editar.Name = "editar";
            // 
            // excluir
            // 
            this.excluir.HeaderText = "Excluir";
            this.excluir.Name = "excluir";
            // 
            // tb_dtgds
            // 
            this.tb_dtgds.Controls.Add(this.tb_itens);
            this.tb_dtgds.Controls.Add(this.tb_itensB);
            this.tb_dtgds.Controls.Add(this.tb_fornecedores);
            this.tb_dtgds.Controls.Add(this.tb_entradas);
            this.tb_dtgds.Controls.Add(this.tb_saidas);
            this.tb_dtgds.Location = new System.Drawing.Point(32, 107);
            this.tb_dtgds.Name = "tb_dtgds";
            this.tb_dtgds.SelectedIndex = 0;
            this.tb_dtgds.Size = new System.Drawing.Size(963, 357);
            this.tb_dtgds.TabIndex = 8;
            this.tb_dtgds.Tag = "";
            this.tb_dtgds.SelectedIndexChanged += new System.EventHandler(this.tb_dtgds_SelectedIndexChanged);
            // 
            // tb_itensB
            // 
            this.tb_itensB.Controls.Add(this.dtg_itensG);
            this.tb_itensB.Location = new System.Drawing.Point(4, 22);
            this.tb_itensB.Name = "tb_itensB";
            this.tb_itensB.Size = new System.Drawing.Size(955, 331);
            this.tb_itensB.TabIndex = 4;
            this.tb_itensB.Text = "Produtos Base";
            this.tb_itensB.UseVisualStyleBackColor = true;
            // 
            // dtg_itensG
            // 
            this.dtg_itensG.AllowUserToAddRows = false;
            this.dtg_itensG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_itensG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewButtonColumn5,
            this.dataGridViewButtonColumn6});
            this.dtg_itensG.Location = new System.Drawing.Point(5, 9);
            this.dtg_itensG.Name = "dtg_itensG";
            this.dtg_itensG.Size = new System.Drawing.Size(944, 316);
            this.dtg_itensG.TabIndex = 1;
            this.dtg_itensG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_itensG_CellContentClick);
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "cod_Produto";
            this.dataGridViewTextBoxColumn11.HeaderText = "Código do produto";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "desc_Produto";
            this.dataGridViewTextBoxColumn12.HeaderText = "Descrição do produto";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewButtonColumn5
            // 
            this.dataGridViewButtonColumn5.HeaderText = "Editar";
            this.dataGridViewButtonColumn5.Name = "dataGridViewButtonColumn5";
            // 
            // dataGridViewButtonColumn6
            // 
            this.dataGridViewButtonColumn6.HeaderText = "Excluir";
            this.dataGridViewButtonColumn6.Name = "dataGridViewButtonColumn6";
            // 
            // tb_fornecedores
            // 
            this.tb_fornecedores.Controls.Add(this.dtg_forn);
            this.tb_fornecedores.Location = new System.Drawing.Point(4, 22);
            this.tb_fornecedores.Name = "tb_fornecedores";
            this.tb_fornecedores.Padding = new System.Windows.Forms.Padding(3);
            this.tb_fornecedores.Size = new System.Drawing.Size(955, 331);
            this.tb_fornecedores.TabIndex = 1;
            this.tb_fornecedores.Text = "Fornecedores";
            this.tb_fornecedores.UseVisualStyleBackColor = true;
            // 
            // dtg_forn
            // 
            this.dtg_forn.AllowUserToAddRows = false;
            this.dtg_forn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_forn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.numero,
            this.complemento,
            this.dataGridViewButtonColumn1,
            this.dataGridViewButtonColumn2});
            this.dtg_forn.Location = new System.Drawing.Point(5, 9);
            this.dtg_forn.Name = "dtg_forn";
            this.dtg_forn.Size = new System.Drawing.Size(944, 316);
            this.dtg_forn.TabIndex = 1;
            this.dtg_forn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_forn_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cnpj_Fornecedor";
            this.dataGridViewTextBoxColumn1.HeaderText = "CNPJ do fornecedor";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome_Fornecedor";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome do fornecedor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "logradouro_Fornecedor";
            this.dataGridViewTextBoxColumn3.HeaderText = "Logradouro do fornecedor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // numero
            // 
            this.numero.DataPropertyName = "numero_Fornecedor";
            this.numero.HeaderText = "Número do fornecedor";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            // 
            // complemento
            // 
            this.complemento.DataPropertyName = "complemento_Fornecedor";
            this.complemento.HeaderText = "Complemento do fornecedor";
            this.complemento.Name = "complemento";
            this.complemento.ReadOnly = true;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Editar";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.HeaderText = "Excluir";
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            // 
            // tb_entradas
            // 
            this.tb_entradas.Controls.Add(this.dtg_entra);
            this.tb_entradas.Location = new System.Drawing.Point(4, 22);
            this.tb_entradas.Name = "tb_entradas";
            this.tb_entradas.Padding = new System.Windows.Forms.Padding(3);
            this.tb_entradas.Size = new System.Drawing.Size(955, 331);
            this.tb_entradas.TabIndex = 2;
            this.tb_entradas.Text = "Entradas";
            this.tb_entradas.UseVisualStyleBackColor = true;
            // 
            // dtg_entra
            // 
            this.dtg_entra.AllowUserToAddRows = false;
            this.dtg_entra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_entra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_alt,
            this.cod_prod,
            this.nom_prod,
            this.cnpj_forn,
            this.nom_forn,
            this.qtd_alt,
            this.tipo,
            this.btn_editar,
            this.btn_excluir});
            this.dtg_entra.Location = new System.Drawing.Point(5, 9);
            this.dtg_entra.Name = "dtg_entra";
            this.dtg_entra.Size = new System.Drawing.Size(943, 316);
            this.dtg_entra.TabIndex = 2;
            this.dtg_entra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_entra_CellContentClick);
            // 
            // cod_alt
            // 
            this.cod_alt.DataPropertyName = "cod_Log";
            this.cod_alt.HeaderText = "Código da alteração";
            this.cod_alt.Name = "cod_alt";
            this.cod_alt.ReadOnly = true;
            // 
            // cod_prod
            // 
            this.cod_prod.DataPropertyName = "cod_Produto";
            this.cod_prod.HeaderText = "Código do produto alterado";
            this.cod_prod.Name = "cod_prod";
            this.cod_prod.ReadOnly = true;
            // 
            // nom_prod
            // 
            this.nom_prod.DataPropertyName = "desc_Produto";
            this.nom_prod.HeaderText = "Produto alterado";
            this.nom_prod.Name = "nom_prod";
            this.nom_prod.ReadOnly = true;
            // 
            // cnpj_forn
            // 
            this.cnpj_forn.DataPropertyName = "CNPJ_Fornecedor";
            this.cnpj_forn.HeaderText = "CNPJ do fornecedor";
            this.cnpj_forn.Name = "cnpj_forn";
            this.cnpj_forn.ReadOnly = true;
            // 
            // nom_forn
            // 
            this.nom_forn.DataPropertyName = "nome_Fornecedor";
            this.nom_forn.HeaderText = "Fornecedor do produto";
            this.nom_forn.Name = "nom_forn";
            this.nom_forn.ReadOnly = true;
            // 
            // qtd_alt
            // 
            this.qtd_alt.DataPropertyName = "qtd_Alterada";
            this.qtd_alt.HeaderText = "Quantidade alterada";
            this.qtd_alt.Name = "qtd_alt";
            this.qtd_alt.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.DataPropertyName = "tipo_Log";
            this.tipo.HeaderText = "Tipo da alteração";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // btn_editar
            // 
            this.btn_editar.HeaderText = "Editar";
            this.btn_editar.Name = "btn_editar";
            // 
            // btn_excluir
            // 
            this.btn_excluir.HeaderText = "Excluir";
            this.btn_excluir.Name = "btn_excluir";
            // 
            // tb_saidas
            // 
            this.tb_saidas.Controls.Add(this.dtg_saidas);
            this.tb_saidas.Location = new System.Drawing.Point(4, 22);
            this.tb_saidas.Name = "tb_saidas";
            this.tb_saidas.Padding = new System.Windows.Forms.Padding(3);
            this.tb_saidas.Size = new System.Drawing.Size(955, 331);
            this.tb_saidas.TabIndex = 3;
            this.tb_saidas.Text = "Saidas";
            this.tb_saidas.UseVisualStyleBackColor = true;
            // 
            // dtg_saidas
            // 
            this.dtg_saidas.AllowUserToAddRows = false;
            this.dtg_saidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_saidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewButtonColumn3,
            this.dataGridViewButtonColumn4});
            this.dtg_saidas.Location = new System.Drawing.Point(5, 9);
            this.dtg_saidas.Name = "dtg_saidas";
            this.dtg_saidas.Size = new System.Drawing.Size(943, 316);
            this.dtg_saidas.TabIndex = 3;
            this.dtg_saidas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_saidas_CellContentClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cod_Log";
            this.dataGridViewTextBoxColumn4.HeaderText = "Código da alteração";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "cod_Produto";
            this.dataGridViewTextBoxColumn5.HeaderText = "Código do produto alterado";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "desc_Produto";
            this.dataGridViewTextBoxColumn6.HeaderText = "Produto alterado";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CNPJ_Fornecedor";
            this.dataGridViewTextBoxColumn7.HeaderText = "CNPJ do fornecedor";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "nome_Fornecedor";
            this.dataGridViewTextBoxColumn8.HeaderText = "Fornecedor do produto";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "qtd_Alterada";
            this.dataGridViewTextBoxColumn9.HeaderText = "Quantidade alterada";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "tipo_Log";
            this.dataGridViewTextBoxColumn10.HeaderText = "Tipo da alteração";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewButtonColumn3
            // 
            this.dataGridViewButtonColumn3.HeaderText = "Editar";
            this.dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
            // 
            // dataGridViewButtonColumn4
            // 
            this.dataGridViewButtonColumn4.HeaderText = "Excluir";
            this.dataGridViewButtonColumn4.Name = "dataGridViewButtonColumn4";
            // 
            // btn_cad_itm
            // 
            this.btn_cad_itm.Location = new System.Drawing.Point(380, 470);
            this.btn_cad_itm.Name = "btn_cad_itm";
            this.btn_cad_itm.Size = new System.Drawing.Size(168, 23);
            this.btn_cad_itm.TabIndex = 5;
            this.btn_cad_itm.Text = "Cadastrar produto";
            this.btn_cad_itm.UseVisualStyleBackColor = true;
            this.btn_cad_itm.Click += new System.EventHandler(this.btn_cad_itm_Click);
            // 
            // btn_cad_forn
            // 
            this.btn_cad_forn.Location = new System.Drawing.Point(206, 470);
            this.btn_cad_forn.Name = "btn_cad_forn";
            this.btn_cad_forn.Size = new System.Drawing.Size(168, 23);
            this.btn_cad_forn.TabIndex = 4;
            this.btn_cad_forn.Text = "Cadastrar fornecedor";
            this.btn_cad_forn.UseVisualStyleBackColor = true;
            this.btn_cad_forn.Click += new System.EventHandler(this.btn_cad_forn_Click);
            // 
            // lbl_cabeçalho
            // 
            this.lbl_cabeçalho.AutoSize = true;
            this.lbl_cabeçalho.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cabeçalho.Location = new System.Drawing.Point(12, 9);
            this.lbl_cabeçalho.Name = "lbl_cabeçalho";
            this.lbl_cabeçalho.Size = new System.Drawing.Size(154, 25);
            this.lbl_cabeçalho.TabIndex = 13;
            this.lbl_cabeçalho.Text = "Página inicial";
            // 
            // btn_cad_prodB
            // 
            this.btn_cad_prodB.Location = new System.Drawing.Point(32, 470);
            this.btn_cad_prodB.Name = "btn_cad_prodB";
            this.btn_cad_prodB.Size = new System.Drawing.Size(168, 23);
            this.btn_cad_prodB.TabIndex = 3;
            this.btn_cad_prodB.Text = "Cadastrar produto base";
            this.btn_cad_prodB.UseVisualStyleBackColor = true;
            this.btn_cad_prodB.Click += new System.EventHandler(this.btn_cad_prodB_Click);
            // 
            // cmb_filtro
            // 
            this.cmb_filtro.FormattingEnabled = true;
            this.cmb_filtro.Items.AddRange(new object[] {
            "Código do item",
            "CNPJ",
            "Código da alteração",
            "Nome do produto",
            "Nome do fornecedor",
            "Quantidade atual",
            "Quantidade mínima",
            "Quantidade alterada"});
            this.cmb_filtro.Location = new System.Drawing.Point(522, 80);
            this.cmb_filtro.Name = "cmb_filtro";
            this.cmb_filtro.Size = new System.Drawing.Size(272, 21);
            this.cmb_filtro.TabIndex = 2;
            this.cmb_filtro.SelectedIndexChanged += new System.EventHandler(this.cmb_filtro_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(463, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Filtrar por:";
            // 
            // btn_relat
            // 
            this.btn_relat.Location = new System.Drawing.Point(728, 470);
            this.btn_relat.Name = "btn_relat";
            this.btn_relat.Size = new System.Drawing.Size(263, 23);
            this.btn_relat.TabIndex = 7;
            this.btn_relat.Text = "Gerar relatório de itens abaixo do estoque minimo";
            this.btn_relat.UseVisualStyleBackColor = true;
            this.btn_relat.Click += new System.EventHandler(this.btn_relat_Click);
            // 
            // frm_inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 517);
            this.Controls.Add(this.btn_relat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_filtro);
            this.Controls.Add(this.btn_cad_prodB);
            this.Controls.Add(this.lbl_cabeçalho);
            this.Controls.Add(this.btn_cad_forn);
            this.Controls.Add(this.btn_cad_itm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_consulta);
            this.Controls.Add(this.btn_alt);
            this.Controls.Add(this.tb_dtgds);
            this.MaximumSize = new System.Drawing.Size(1069, 556);
            this.MinimumSize = new System.Drawing.Size(1069, 556);
            this.Name = "frm_inicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Página inicial";
            this.Load += new System.EventHandler(this.frm_inicial_Load);
            this.tb_itens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_itens)).EndInit();
            this.tb_dtgds.ResumeLayout(false);
            this.tb_itensB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_itensG)).EndInit();
            this.tb_fornecedores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_forn)).EndInit();
            this.tb_entradas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_entra)).EndInit();
            this.tb_saidas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_saidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_alt;
        private System.Windows.Forms.TextBox txt_consulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tb_itens;
        private System.Windows.Forms.DataGridView dtg_itens;
        private System.Windows.Forms.TabControl tb_dtgds;
        private System.Windows.Forms.TabPage tb_fornecedores;
        private System.Windows.Forms.DataGridView dtg_forn;
        private System.Windows.Forms.TabPage tb_entradas;
        private System.Windows.Forms.DataGridView dtg_entra;
        private System.Windows.Forms.TabPage tb_saidas;
        private System.Windows.Forms.Button btn_cad_itm;
        private System.Windows.Forms.Button btn_cad_forn;
        private System.Windows.Forms.Label lbl_cabeçalho;
        private System.Windows.Forms.DataGridView dtg_saidas;
        private System.Windows.Forms.Button btn_cad_prodB;
        private System.Windows.Forms.TabPage tb_itensB;
        private System.Windows.Forms.DataGridView dtg_itensG;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn5;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_alt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpj_forn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_forn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtd_alt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewButtonColumn btn_editar;
        private System.Windows.Forms.DataGridViewButtonColumn btn_excluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn4;
        private System.Windows.Forms.ComboBox cmb_filtro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_relat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_prd;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtd_atual;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtd_min;
        private System.Windows.Forms.DataGridViewButtonColumn editar;
        private System.Windows.Forms.DataGridViewButtonColumn excluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn complemento;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
    }
}

