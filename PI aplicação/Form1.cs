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
using System.Configuration;

namespace PI_aplicação
{
    public partial class frm_inicial : Form
    {        
        Conexão a = new Conexão("localhost","PI 3 sem","root");
        string filtro = "";
        public frm_inicial()
        {
            InitializeComponent();
        }

        //Consulta das tabelas
        private void cmb_filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_filtro.SelectedIndex == 0)
            {
                filtro = "cod_Produto";
            }
            else if (cmb_filtro.SelectedIndex == 1)
            {
                filtro = "cnpj_Fornecedor";
            }
            else if (cmb_filtro.SelectedIndex == 2)
            {
                filtro = "cod_Log";
            }
            else if (cmb_filtro.SelectedIndex == 3)
            {
                filtro = "desc_Produto";
            }
            else if (cmb_filtro.SelectedIndex == 4)
            {
                filtro = "nome_Fornecedor";
            }
            else if (cmb_filtro.SelectedIndex == 5)
            {
                filtro = "qtd_Produto";
            }
            else if (cmb_filtro.SelectedIndex == 6)
            {
                filtro = "qtd_Produto_Min";
            }
            else if (cmb_filtro.SelectedIndex == 7)
            {
                filtro = "qtd_Alterada";
            }
            txt_consulta.Enabled = true;
        }

        private void txt_consulta_TextChanged(object sender, EventArgs e)
        {
            if(filtro == "")
            {
                MessageBox.Show("Defina um filtro antes de efetuar a pesquisa");
            }
            else
            {
                if(tb_dtgds.SelectedIndex == 0)
                {
                    try
                    {
                        dtg_itens.DataSource = fazerPesquisaItem(filtro, txt_consulta.Text);
                    }
                    catch (Exception)
                    {        
                        if(txt_consulta.Text != "")
                        {
                            txt_consulta.Text = "";
                            txt_consulta.Enabled = false;
                            MessageBox.Show("Filtro selecionado inválido, favor selecionar um filtro válido e digitar a consulta novamente");
                        }                        
                    }                    
                }
                else if (tb_dtgds.SelectedIndex == 1)
                {
                    try
                    {                    
                        dtg_itensG.DataSource = fazerPesquisaItemB(filtro, txt_consulta.Text);
                    }
                    catch (Exception)
                    {
                        if (txt_consulta.Text != "")
                        {
                            txt_consulta.Text = "";
                            txt_consulta.Enabled = false;
                            MessageBox.Show("Filtro selecionado inválido, favor selecionar um filtro válido e digitar a consulta novamente");
                        }
                    }
                }
                else if (tb_dtgds.SelectedIndex == 2)
                {
                    try
                    {                        
                        dtg_forn.DataSource = fazerPesquisaForn(filtro, txt_consulta.Text);
                    }
                    catch (Exception)
                    {
                        if (txt_consulta.Text != "")
                        {
                            txt_consulta.Text = "";
                            txt_consulta.Enabled = false;
                            MessageBox.Show("Filtro selecionado inválido, favor selecionar um filtro válido e digitar a consulta novamente");
                        }
                    }
                }
                else if (tb_dtgds.SelectedIndex == 3)
                {
                    try
                    {                    
                        dtg_entra.DataSource = fazerPesquisaEntrada(filtro, txt_consulta.Text);
                    }
                    catch (Exception)
                    {
                        if (txt_consulta.Text != "")
                        {
                            txt_consulta.Text = "";
                            txt_consulta.Enabled = false;
                            MessageBox.Show("Filtro selecionado inválido, favor selecionar um filtro válido e digitar a consulta novamente");
                        }
                    }
                }
                else if (tb_dtgds.SelectedIndex == 4)
                {
                    try
                    {                    
                        dtg_saidas.DataSource = fazerPesquisaSaida(filtro, txt_consulta.Text);
                    }
                    catch (Exception)
                    {
                        if (txt_consulta.Text != "")
                        {
                            txt_consulta.Text = "";
                            txt_consulta.Enabled = false;
                            MessageBox.Show("Filtro selecionado inválido, favor selecionar um filtro válido e digitar a consulta novamente");
                        }
                    }
                }
            }
        }

        private void tb_dtgds_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_consulta.Clear();
            carregarGrids();
        }

        private DataTable fazerPesquisaItem(string filtro, string pesquisa)
        {
            string comandoSql = "";
            string tabela = "";

            if (filtro == "cnpj_Fornecedor")
            {
                tabela = "c.";
            }else if (filtro == "desc_Produto")
            {
                tabela = "b.";
            }
            else
            {
                tabela = "a.";
            }

            //Mostrar informações no grid de produtos
            comandoSql = "SELECT a.cod_Produto, b.desc_Produto, a.cnpj_Fornecedor, c.nome_Fornecedor, a.qtd_Produto, a.qtd_Produto_Min FROM produto_fornecedor AS a INNER JOIN produto AS b ";
            comandoSql += "on a.cod_Produto = b.cod_Produto INNER JOIN fornecedor AS c ON a.cnpj_Fornecedor = c.cnpj_Fornecedor where " + tabela + filtro + " like '%" + pesquisa + "%'";
            MySqlCommand sqlCommand = new MySqlCommand(comandoSql, a.mConn);
            a.mAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            ds.Clear();
            a.mAdapter.Fill(ds);
            dt = ds.Tables[0];
            return dt;
        }
        private DataTable fazerPesquisaItemB(string filtro, string pesquisa)
        {
            string comandoSql = "";

            //Mostrar informações no grid de produtos
            comandoSql = "SELECT * FROM produto where " + filtro + " like '%" + pesquisa + "%'";
            MySqlCommand sqlCommand = new MySqlCommand(comandoSql, a.mConn);
            a.mAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            ds.Clear();
            a.mAdapter.Fill(ds);
            dt = ds.Tables[0];
            return dt;
        }
        private DataTable fazerPesquisaForn(string filtro, string pesquisa)
        {
            string comandoSql = "";

            //Mostrar informações no grid de produtos
            comandoSql = "SELECT * FROM Fornecedor where " + filtro + " like '%" + pesquisa + "%'";
            MySqlCommand sqlCommand = new MySqlCommand(comandoSql, a.mConn);
            a.mAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            ds.Clear();
            a.mAdapter.Fill(ds);
            dt = ds.Tables[0];
            return dt;
        }
        private DataTable fazerPesquisaEntrada(string filtro, string pesquisa)
        {
            string comandoSql = "";
            string tabela = "";

            if (filtro == "cnpj_Fornecedor")
            {
                tabela = "c.";
            }
            else if (filtro == "desc_Produto")
            {
                tabela = "b.";
            }
            else
            {
                tabela = "a.";
            }

            //Mostrar informações no grid de entradas
            comandoSql = "SELECT a.cod_Log, a.cod_Produto, b.desc_Produto, a.cnpj_Fornecedor, c.nome_Fornecedor, a.qtd_Alterada, a.tipo_Log FROM Log_Produto_Fornecedor AS a INNER JOIN produto AS b ";
            comandoSql += "on a.cod_Produto = b.cod_Produto INNER JOIN fornecedor AS c ON a.cnpj_Fornecedor = c.cnpj_Fornecedor WHERE a.tipo_Log <> 'Saida' and " + tabela + filtro + " like '%" + pesquisa + "%'";
            MySqlCommand sqlCommand = new MySqlCommand(comandoSql, a.mConn);
            a.mAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            ds.Clear();
            a.mAdapter.Fill(ds);
            dt = ds.Tables[0];
            return dt;
        }
        private DataTable fazerPesquisaSaida(string filtro, string pesquisa)
        {
            string comandoSql = "";
            string tabela = "";

            if (filtro == "cnpj_Fornecedor")
            {
                tabela = "c.";
            }
            else if (filtro == "desc_Produto")
            {
                tabela = "b.";
            }
            else
            {
                tabela = "a.";
            }

            //Mostrar informações no grid de entradas
            comandoSql = "SELECT a.cod_Log, a.cod_Produto, b.desc_Produto, a.cnpj_Fornecedor, c.nome_Fornecedor, a.qtd_Alterada, a.tipo_Log FROM Log_Produto_Fornecedor AS a INNER JOIN produto AS b ";
            comandoSql += "on a.cod_Produto = b.cod_Produto INNER JOIN fornecedor AS c ON a.cnpj_Fornecedor = c.cnpj_Fornecedor WHERE a.tipo_Log <> 'Entrada' and " + tabela + filtro + " like '%" + pesquisa + "%'";
            MySqlCommand sqlCommand = new MySqlCommand(comandoSql, a.mConn);
            a.mAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            ds.Clear();
            a.mAdapter.Fill(ds);
            dt = ds.Tables[0];
            return dt;
        }

        //Botões para cadastro
        private void btn_cad_itm_Click(object sender, EventArgs e)
        {
            //Mostrar o form de cadastro de produto e definir operação
            Globais.op = "Inserir";
            Globais.op2 = "";
            frm_item item = new frm_item();
            item.UpdateEventHandlerItens += Frm_Item_UpdateEventHandler;
            item.ShowDialog();
        }

        private void btn_cad_prodB_Click(object sender, EventArgs e)
        {
            //Mostrar o form de cadastro de produto base e definir operação
            Globais.op = "Inserir";
            Globais.op2 = "Base";
            frm_item item = new frm_item();
            item.UpdateEventHandlerItensB += Frm_ItemB_UpdateEventHandler;
            item.ShowDialog();
        }

        private void btn_cad_forn_Click(object sender, EventArgs e)
        {
            //Mostrar o form de cadastro de fornecedor e definir operação
            Globais.op = "Inserir";
            frm_forn forn = new frm_forn();
            forn.UpdateEventHandlerForn += Frm_Forn_UpdateEventHandler;
            forn.ShowDialog();
        }

        private void btn_alt_Click(object sender, EventArgs e)
        {
            //Mostrar o form de cadastro de alteração e definir operação
            Globais.op = "Nova";
            frm_alt alt = new frm_alt();
            alt.UpdateEventHandlerEntra += Frm_Entrada_UpdateEventHandler;
            alt.UpdateEventHandlerSai += Frm_Saida_UpdateEventHandler;
            alt.UpdateEventHandlerItens += Frm_Item_Alt_UpdateEventHandler;
            alt.ShowDialog();
        }

        //Operações de grid
        private void btn_relat_Click(object sender, EventArgs e)
        {
            frm_relat relat = new frm_relat();
            relat.ShowDialog();
        }

        private void frm_inicial_Load(object sender, EventArgs e)
        {
            carregarGrids();
            //lbl_cabeçalho.Text = dtg_itens.Columns["desc_prod"].Index.ToString();

        }
        
        public void carregarGrids()
        {
            //Mostrar itens de produto_fornecedor
            dtg_itens.DataSource = SourceItens();
            //Mostrar itens de produto
            dtg_itensG.DataSource = SourceItensB();
            //Mostrar itens de fornecedor
            dtg_forn.DataSource = SourceForn();
            //Mostrar itens de alteração com apenas entradas
            dtg_entra.DataSource = SourceEntrada();
            //Mostrar itens de alteração com apenas saidas
            dtg_saidas.DataSource = SourceSaida();
        }

        //Definição de souces para viabilizar a atualização do dtgd de outro form
        public DataTable SourceItens() 
        {            
            string comandoSql = "";

            //Mostrar informações no grid de produtos
            comandoSql = "SELECT a.cod_Produto, b.desc_Produto, a.cnpj_Fornecedor, c.nome_Fornecedor, a.qtd_Produto, a.qtd_Produto_Min FROM produto_fornecedor AS a INNER JOIN produto AS b ";
            comandoSql += "on a.cod_Produto = b.cod_Produto INNER JOIN fornecedor AS c ON a.cnpj_Fornecedor = c.cnpj_Fornecedor";
            MySqlCommand sqlCommand = new MySqlCommand(comandoSql, a.mConn);
            a.mAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            ds.Clear();
            a.mAdapter.Fill(ds);
            dt = ds.Tables[0];
            return dt;
        }

        public DataTable SourceItensB()
        {
            string comandoSql = "";

            //Mostrar informações no grid de produtos
            comandoSql = "SELECT * FROM produto";
            MySqlCommand sqlCommand = new MySqlCommand(comandoSql, a.mConn);
            a.mAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            ds.Clear();
            a.mAdapter.Fill(ds);
            dt = ds.Tables[0];
            return dt;
        }

        public DataTable SourceForn()
        {
            string comandoSql = "";

            //Mostrar informações no grid de produtos
            comandoSql = "SELECT * FROM Fornecedor";
            MySqlCommand sqlCommand = new MySqlCommand(comandoSql, a.mConn);
            a.mAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            ds.Clear();
            a.mAdapter.Fill(ds);
            dt = ds.Tables[0];
            return dt;
        }

        public DataTable SourceEntrada()
        {
            string comandoSql = "";

            //Mostrar informações no grid de entradas
            comandoSql = "SELECT a.cod_Log, a.cod_Produto, b.desc_Produto, a.cnpj_Fornecedor, c.nome_Fornecedor, a.qtd_Alterada, a.tipo_Log FROM Log_Produto_Fornecedor AS a INNER JOIN produto AS b ";
            comandoSql += "on a.cod_Produto = b.cod_Produto INNER JOIN fornecedor AS c ON a.cnpj_Fornecedor = c.cnpj_Fornecedor WHERE a.tipo_Log <> 'Saida'";
            MySqlCommand sqlCommand = new MySqlCommand(comandoSql, a.mConn);
            a.mAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            ds.Clear();
            a.mAdapter.Fill(ds);
            dt = ds.Tables[0];
            return dt;
        }

        public DataTable SourceSaida()
        {
            string comandoSql = "";

            //Mostrar informações no grid de entradas
            comandoSql = "SELECT a.cod_Log, a.cod_Produto, b.desc_Produto, a.cnpj_Fornecedor, c.nome_Fornecedor, a.qtd_Alterada, a.tipo_Log FROM Log_Produto_Fornecedor AS a INNER JOIN produto AS b ";
            comandoSql += "on a.cod_Produto = b.cod_Produto INNER JOIN fornecedor AS c ON a.cnpj_Fornecedor = c.cnpj_Fornecedor WHERE a.tipo_Log <> 'Entrada'";
            MySqlCommand sqlCommand = new MySqlCommand(comandoSql, a.mConn);
            a.mAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            ds.Clear();
            a.mAdapter.Fill(ds);
            dt = ds.Tables[0];
            return dt;
        }

        //Definindo as sources dos dtgds após ter alguma alteração de qualquer form
        private void Frm_Item_UpdateEventHandler(object sender, frm_item.UpdateEventArgs args)
        {
            dtg_itens.DataSource = SourceItens();
        }
        private void Frm_Item_Forn_UpdateEventHandler(object sender, frm_forn.UpdateEventArgs args)
        {
            dtg_itens.DataSource = SourceItens();
        }
        private void Frm_Item_Alt_UpdateEventHandler(object sender, frm_alt.UpdateEventArgs args)
        {
            dtg_itens.DataSource = SourceItens();
        }
        private void Frm_ItemB_UpdateEventHandler(object sender, frm_item.UpdateEventArgs args)
        {
            dtg_itensG.DataSource = SourceItensB();
        }        
        private void Frm_Forn_UpdateEventHandler(object sender, frm_forn.UpdateEventArgs args)
        {
            dtg_forn.DataSource = SourceForn();
        }        
        private void Frm_Entrada_UpdateEventHandler(object sender, frm_alt.UpdateEventArgs args)
        {
            dtg_entra.DataSource = SourceEntrada();
        }
        private void Frm_Saida_UpdateEventHandler(object sender, frm_alt.UpdateEventArgs args)
        {
            dtg_saidas.DataSource = SourceSaida();
        }
        

        //Definir funções dos botões dos data grids
        private void dtg_itens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 0)
            {
                //Mostrar o form de cadastro de item e definir operação
                Globais.op = "Alterar";
                Globais.op2 = "";
                frm_item item = new frm_item(dtg_itens.CurrentRow.Cells[2].Value.ToString(),
                                             dtg_itens.CurrentRow.Cells[3].Value.ToString(),
                                             dtg_itens.CurrentRow.Cells[4].Value.ToString(),
                                             dtg_itens.CurrentRow.Cells[5].Value.ToString(),
                                             dtg_itens.CurrentRow.Cells[6].Value.ToString(),
                                             dtg_itens.CurrentRow.Cells[7].Value.ToString());
                item.UpdateEventHandlerItens += Frm_Item_UpdateEventHandler;
                item.ShowDialog();
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 1)
            {
                try
                {
                    a.sql = String.Format("DELETE FROM Produto_Fornecedor WHERE cod_Produto = {0} AND cnpj_Fornecedor = {1}", dtg_itens.CurrentRow.Cells[2].Value, dtg_itens.CurrentRow.Cells[4].Value);
                    MySqlCommand command = new MySqlCommand(a.sql, a.mConn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Dados deletados com sucesso");
                    carregarGrids();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível deletar os dados, delete tudo referente a esse item das outras tabelas antes de realizar essa ação");
                }
            }
        }

        private void dtg_itensG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 0)
            {
                //Mostrar o form de cadastro de item e definir operação sendo que vai ser a alteração do item base
                Globais.op = "Alterar";
                Globais.op2 = "Base";
                frm_item item = new frm_item(dtg_itensG.CurrentRow.Cells[2].Value.ToString(),
                                             dtg_itensG.CurrentRow.Cells[3].Value.ToString());
                item.UpdateEventHandlerItensB += Frm_ItemB_UpdateEventHandler;
                item.UpdateEventHandlerItens += Frm_Item_UpdateEventHandler;
                item.ShowDialog();
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 1)
            {
                try
                {
                    a.sql = String.Format("DELETE FROM Produto WHERE cod_Produto = {0} ", dtg_itensG.CurrentRow.Cells[2].Value);
                    MySqlCommand command = new MySqlCommand(a.sql, a.mConn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Dados deletados com sucesso");
                    carregarGrids();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível deletar os dados, delete tudo referente a esse item das outras tabelas antes de realizar essa ação");
                }
            }
        }

        private void dtg_forn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 0)
            {
                //Mostrar o form de cadastro de item e definir operação sendo que vai ser a alteração do item base
                Globais.op = "Alterar";
                frm_forn forn = new frm_forn(dtg_forn.CurrentRow.Cells[2].Value.ToString(),
                                             dtg_forn.CurrentRow.Cells[3].Value.ToString(),
                                             dtg_forn.CurrentRow.Cells[4].Value.ToString(),
                                             dtg_forn.CurrentRow.Cells[5].Value.ToString(),
                                             dtg_forn.CurrentRow.Cells[6].Value.ToString());
                forn.UpdateEventHandlerForn += Frm_Forn_UpdateEventHandler;
                forn.UpdateEventHandlerItens += Frm_Item_Forn_UpdateEventHandler;
                forn.ShowDialog();
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 1)
            {
                try
                {
                    a.sql = String.Format("DELETE FROM Fornecedor WHERE cnpj_Fornecedor = '{0}'", dtg_forn.CurrentRow.Cells[2].Value);
                    MySqlCommand command = new MySqlCommand(a.sql, a.mConn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Dados deletados com sucesso");
                    carregarGrids();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível deletar os dados, delete tudo referente a esse item das outras tabelas antes de realizar essa ação");
                }
            }
        }

        private void dtg_entra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 0)
            {
                Globais.op = "Alterar";
                Globais.op2 = "Entrada";
                frm_alt alt = new frm_alt(dtg_entra.CurrentRow.Cells[2].Value.ToString(),
                                          dtg_entra.CurrentRow.Cells[3].Value.ToString(),
                                          dtg_entra.CurrentRow.Cells[4].Value.ToString(),
                                          dtg_entra.CurrentRow.Cells[5].Value.ToString(),
                                          dtg_entra.CurrentRow.Cells[6].Value.ToString(),
                                          dtg_entra.CurrentRow.Cells[7].Value.ToString(),
                                          dtg_entra.CurrentRow.Cells[8].Value.ToString());
                alt.UpdateEventHandlerEntra += Frm_Entrada_UpdateEventHandler;
                alt.UpdateEventHandlerSai += Frm_Saida_UpdateEventHandler;
                alt.UpdateEventHandlerItens += Frm_Item_Alt_UpdateEventHandler;
                alt.ShowDialog();
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 1)
            {
                try
                {
                    //Deletar os dados da entrada
                    a.sql = String.Format("DELETE FROM Log_Produto_Fornecedor WHERE cod_Log = {0} ", dtg_entra.CurrentRow.Cells[2].Value);
                    MySqlCommand command = new MySqlCommand(a.sql, a.mConn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Dados deletados com sucesso");
                    //balancear o´valor dos itens após deletar
                    a.sql = String.Format("UPDATE Produto_Fornecedor SET qtd_Produto = qtd_Produto - {0} WHERE cod_Produto = {1} AND cnpj_Fornecedor = {2}", dtg_entra.CurrentRow.Cells[7].Value.ToString(), dtg_entra.CurrentRow.Cells[3].Value.ToString(), dtg_entra.CurrentRow.Cells[5].Value.ToString());
                    MySqlCommand command2 = new MySqlCommand(a.sql, a.mConn);
                    command2.ExecuteNonQuery();
                    carregarGrids();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível deletar os dados do banco" + "\n" + "\n" + ex);
                }
            }
        }

        private void dtg_saidas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 0)
            {
                Globais.op = "Alterar";
                Globais.op2 = "Saida";
                frm_alt alt = new frm_alt(dtg_saidas.CurrentRow.Cells[2].Value.ToString(),
                                          dtg_saidas.CurrentRow.Cells[3].Value.ToString(),
                                          dtg_saidas.CurrentRow.Cells[4].Value.ToString(),
                                          dtg_saidas.CurrentRow.Cells[5].Value.ToString(),
                                          dtg_saidas.CurrentRow.Cells[6].Value.ToString(),
                                          dtg_saidas.CurrentRow.Cells[7].Value.ToString(),
                                          dtg_saidas.CurrentRow.Cells[8].Value.ToString());
                alt.UpdateEventHandlerSai += Frm_Saida_UpdateEventHandler;
                alt.UpdateEventHandlerEntra += Frm_Entrada_UpdateEventHandler;
                alt.UpdateEventHandlerItens += Frm_Item_Alt_UpdateEventHandler;
                alt.ShowDialog();
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 1)
            {
                try
                {
                    //Deletar os dados da saída
                    a.sql = String.Format("DELETE FROM Log_Produto_Fornecedor WHERE cod_Log = {0} ", dtg_saidas.CurrentRow.Cells[2].Value);
                    MySqlCommand command = new MySqlCommand(a.sql, a.mConn);
                    command.ExecuteNonQuery();
                    //balancear o´valor dos itens após deletar
                    a.sql = String.Format("UPDATE Produto_Fornecedor SET qtd_Produto = qtd_Produto + {0} WHERE cod_Produto = {1} AND cnpj_Fornecedor = {2}", dtg_saidas.CurrentRow.Cells[7].Value.ToString(), dtg_saidas.CurrentRow.Cells[3].Value.ToString(), dtg_saidas.CurrentRow.Cells[5].Value.ToString());
                    MySqlCommand command2 = new MySqlCommand(a.sql, a.mConn);
                    command2.ExecuteNonQuery();

                    MessageBox.Show("Dados deletados com sucesso");
                    carregarGrids();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível deletar os dados do banco" + "\n" + "\n" + ex);
                }
            }
        }

        
    }
}
