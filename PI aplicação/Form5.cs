using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PI_aplicação
{
    public partial class frm_relat : Form
    {
        Conexão a = new Conexão("localhost", "PI 3 sem", "root");
        public frm_relat()
        {
            InitializeComponent();
        }

        private void frm_relat_Load(object sender, EventArgs e)
        {
            try
            {
                carregarGrids();
            }
            catch (Exception)
            {
                MessageBox.Show("Não existem itens abaixo do estoque minimo necessário");
            }
            
        }
        public void carregarGrids()
        {
            //Mostrar itens de produto_fornecedor
            dtg_itens.DataSource = SourceItens();
        }
        public DataTable SourceItens()
        {
            string comandoSql = "";

            //Mostrar informações no grid de produtos
            comandoSql = "SELECT a.cod_Produto, b.desc_Produto, a.cnpj_Fornecedor, c.nome_Fornecedor, a.qtd_Produto, a.qtd_Produto_Min FROM produto_fornecedor AS a INNER JOIN produto AS b ";
            comandoSql += "on a.cod_Produto = b.cod_Produto INNER JOIN fornecedor AS c ON a.cnpj_Fornecedor = c.cnpj_Fornecedor WHERE a.qtd_Produto_Min > a.qtd_Produto";
            MySqlCommand sqlCommand = new MySqlCommand(comandoSql, a.mConn);
            a.mAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            ds.Clear();
            a.mAdapter.Fill(ds);
            dt = ds.Tables[0];
            return dt;
        }
    }
}
