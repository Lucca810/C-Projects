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
    public partial class frm_alt : Form
    {
        Conexão a = new Conexão("localhost","PI 3 sem","root");
        public string cnpj = "";
        public string cod_Ori = "", qtd_Ori = "", op = "";
        public frm_alt(string cod_alt = "",string cod_item = "",string desc = "", string cnpj = "",string forn = "", string qtd = "", string tipo = "")
        {
            InitializeComponent();
            lbl_cabeçalho.Text = Globais.op + " " + lbl_cabeçalho.Text;
            if (Globais.op == "Alterar")
            {
                txt_cod_itm.Enabled = false;
                txt_cnpj.Enabled = false;

                txt_cod_itm.Text = cod_item;
                txt_nom_itm.Text = desc;
                txt_cnpj.Text = cnpj;
                txt_nom_forn.Text = forn;
                txt_qtd_alt.Text = qtd;

                cod_Ori = cod_alt;
                qtd_Ori = qtd;                

                if(tipo == "Entrada")
                {
                    cmb_alt.SelectedIndex = 0;
                }else if(tipo == "Saida")
                {
                    cmb_alt.SelectedIndex = 1;
                }
            }
        }

        private void frm_alt_Load(object sender, EventArgs e)
        {
            
        }

        private void cmb_alt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_alt.SelectedIndex == 0 || cmb_alt.Text == "Entrada")
            {
                op = "Entrada";
            }
            else if (cmb_alt.SelectedIndex == 1 || cmb_alt.Text == "Saida")
            {
                op = "Saida";
            }
        }

        private void txt_cod_itm_Leave(object sender, EventArgs e)
        {
            string armazenar;
            armazenar = txt_cod_itm.Text;
            armazenar = armazenar.ToLower();
            if (armazenar.Contains("a") || armazenar.Contains("b") || armazenar.Contains("c") || armazenar.Contains("d") || armazenar.Contains("e") || armazenar.Contains("f") || armazenar.Contains("g") || armazenar.Contains("h") || armazenar.Contains("i") || armazenar.Contains("j") || armazenar.Contains("k") || armazenar.Contains("l") || armazenar.Contains("m") || armazenar.Contains("n") || armazenar.Contains("o") || armazenar.Contains("p") || armazenar.Contains("q") || armazenar.Contains("r") || armazenar.Contains("s") || armazenar.Contains("t") || armazenar.Contains("u") || armazenar.Contains("v") || armazenar.Contains("w") || armazenar.Contains("x") || armazenar.Contains("y") || armazenar.Contains("z") || armazenar.Contains("~") || armazenar.Contains("^") || armazenar.Contains(" "))
            {
                MessageBox.Show("Caracter inválido para o código");
                txt_cod_itm.Focus();
            }
            else {
                if (Globais.op == "Nova" && txt_cod_itm.Text != "")
                {
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand("SELECT * FROM produto WHERE cod_Produto = " + txt_cod_itm.Text, a.mConn);
                        a.mAdapter = new MySqlDataAdapter(cmd);
                        DataSet ds1 = new DataSet();
                        a.mAdapter.Fill(ds1);
                        int i = ds1.Tables[0].Rows.Count;
                        if (i > 0)
                        {
                            txt_nom_itm.Text = ds1.Tables[0].Rows[0][1].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Código não existe, favor inserir um código válido");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possível localizar o código");
                    }
                }
            }    
        }

        private void txt_cnpj_Leave(object sender, EventArgs e)
        {
            desfazerMascaraCNPJ();

            if (Globais.op == "Nova" && cnpj != "")
            {
                try
                {                 
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM fornecedor WHERE cnpj_Fornecedor = " + cnpj, a.mConn);
                    a.mAdapter = new MySqlDataAdapter(cmd);
                    DataSet ds1 = new DataSet();
                    a.mAdapter.Fill(ds1);
                    int i = ds1.Tables[0].Rows.Count;
                    if (i > 0)
                    {
                        txt_nom_forn.Text = ds1.Tables[0].Rows[0][1].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Fornecedor não existe");
                        txt_cnpj.Text = "";
                        txt_cnpj.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível localizar o fornecedor");
                }
            }
        }

        private string desfazerMascaraCNPJ()
        {
            txt_cnpj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            cnpj = txt_cnpj.Text;

            return cnpj;
        }

        private void btn_limp_Click(object sender, EventArgs e)
        {
            if(Globais.op == "Alterar")
            {
                txt_qtd_alt.Text = "";
                txt_qtd_alt.Focus();

            }else if (Globais.op == "Nova")
            {
                txt_cnpj.Text = "";
                txt_cod_itm.Text = "";
                txt_nom_forn.Text = "";
                txt_nom_itm.Text = "";
                txt_qtd_alt.Text = "";                

                cmb_alt.SelectedIndex = 0;

                txt_cod_itm.Focus();
            }
        }

        private void btn_guard_Click(object sender, EventArgs e)
        {
            if (Globais.op == "Nova")
            {       
                novaAlt();
            }
            else if (Globais.op == "Alterar")
            {
                alterarAlt();
            }
        }

        public void novaAlt()
        {
            Globais.op2 = op;

            try
            {
                a.sql = String.Format("INSERT INTO Log_Produto_Fornecedor (cod_Produto, cnpj_Fornecedor, qtd_Alterada, tipo_Log) values({0},'{1}',{2},'{3}')", txt_cod_itm.Text, desfazerMascaraCNPJ(), txt_qtd_alt.Text, cmb_alt.Text);
                MySqlCommand command = new MySqlCommand(a.sql, a.mConn);
                command.ExecuteNonQuery();
                if (Globais.op2 == "Entrada")
                {
                    a.sql = String.Format("UPDATE produto_fornecedor SET qtd_Produto = qtd_Produto + {0} WHERE cod_Produto = {1} AND cnpj_Fornecedor = {2}", txt_qtd_alt.Text, txt_cod_itm.Text, desfazerMascaraCNPJ());
                    MySqlCommand command2 = new MySqlCommand(a.sql, a.mConn);
                    command2.ExecuteNonQuery();
                }
                else if (Globais.op2 == "Saida")
                {
                    a.sql = String.Format("UPDATE produto_fornecedor SET qtd_Produto = qtd_Produto - {0} WHERE cod_Produto = {1} AND cnpj_Fornecedor = {2}", txt_qtd_alt.Text, txt_cod_itm.Text, desfazerMascaraCNPJ());
                    MySqlCommand command2 = new MySqlCommand(a.sql, a.mConn);
                    command2.ExecuteNonQuery();
                }
                MessageBox.Show("Operação realizada com sucesso");
                att();
                this.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show("Essa combinação de item e fornecedor não existe");
            }
            
        }

        public void alterarAlt()
        {
            try
            {
                a.sql = String.Format("UPDATE Log_Produto_Fornecedor SET qtd_Alterada = {0}, tipo_Log = '{1}' WHERE cod_Log = {2}", txt_qtd_alt.Text, cmb_alt.Text, cod_Ori);
                MySqlCommand command = new MySqlCommand(a.sql, a.mConn);
                command.ExecuteNonQuery();
                if (op == "Entrada" && op != Globais.op2)
                {                    
                    a.sql = String.Format("UPDATE produto_fornecedor SET qtd_Produto = qtd_Produto + {0} + {1} WHERE cod_Produto = {2} AND cnpj_Fornecedor = {3}",qtd_Ori, txt_qtd_alt.Text, txt_cod_itm.Text, desfazerMascaraCNPJ());
                    MySqlCommand command2 = new MySqlCommand(a.sql, a.mConn);
                    command2.ExecuteNonQuery();
                }
                else if(op == "Saida" && op != Globais.op2)
                {
                    a.sql = String.Format("UPDATE produto_fornecedor SET qtd_Produto = qtd_Produto - {0} - {1} WHERE cod_Produto = {2} AND cnpj_Fornecedor = {3}", qtd_Ori, txt_qtd_alt.Text, txt_cod_itm.Text, desfazerMascaraCNPJ());
                    MySqlCommand command2 = new MySqlCommand(a.sql, a.mConn);
                    command2.ExecuteNonQuery();
                }else if (op == "Entrada")
                {
                    a.sql = String.Format("UPDATE produto_fornecedor SET qtd_Produto = qtd_Produto - {0} + {1} WHERE cod_Produto = {2} AND cnpj_Fornecedor = {3}", qtd_Ori, txt_qtd_alt.Text, txt_cod_itm.Text, desfazerMascaraCNPJ());
                    MySqlCommand command2 = new MySqlCommand(a.sql, a.mConn);
                    command2.ExecuteNonQuery();
                }
                else if (op == "Saida")
                {
                    a.sql = String.Format("UPDATE produto_fornecedor SET qtd_Produto = qtd_Produto + {0} - {1} WHERE cod_Produto = {2} AND cnpj_Fornecedor = {3}", qtd_Ori, txt_qtd_alt.Text, txt_cod_itm.Text, desfazerMascaraCNPJ());
                    MySqlCommand command2 = new MySqlCommand(a.sql, a.mConn);
                    command2.ExecuteNonQuery();
                }
                MessageBox.Show("Operação realizada com sucesso");
                att();
                this.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show("Não foi possível realizar a operação");
            }
            
        }

        //Funções para atualizar os grids
        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandlerEntra;
        public event UpdateDelegate UpdateEventHandlerSai;
        public event UpdateDelegate UpdateEventHandlerItens;

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        private void txt_cod_itm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_qtd_alt_Leave(object sender, EventArgs e)
        {
            string armazenar;
            armazenar = txt_qtd_alt.Text;
            armazenar = armazenar.ToLower();
            if (armazenar.Contains("a") || armazenar.Contains("b") || armazenar.Contains("c") || armazenar.Contains("d") || armazenar.Contains("e") || armazenar.Contains("f") || armazenar.Contains("g") || armazenar.Contains("h") || armazenar.Contains("i") || armazenar.Contains("j") || armazenar.Contains("k") || armazenar.Contains("l") || armazenar.Contains("m") || armazenar.Contains("n") || armazenar.Contains("o") || armazenar.Contains("p") || armazenar.Contains("q") || armazenar.Contains("r") || armazenar.Contains("s") || armazenar.Contains("t") || armazenar.Contains("u") || armazenar.Contains("v") || armazenar.Contains("w") || armazenar.Contains("x") || armazenar.Contains("y") || armazenar.Contains("z") || armazenar.Contains("~") || armazenar.Contains("^") || armazenar.Contains(" "))
            {
                MessageBox.Show("Caracter inválido para o código");
                txt_qtd_alt.Focus();
            }
        }

        protected void att()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            if (Globais.op == "Alterar" && op != Globais.op2)
            {
                UpdateEventHandlerEntra.Invoke(this, args);
                UpdateEventHandlerSai.Invoke(this, args);
            }
            else if(Globais.op2 == "Saida")
            {
                UpdateEventHandlerSai.Invoke(this, args);
            }
            else if (Globais.op2 == "Entrada")
            {
                UpdateEventHandlerEntra.Invoke(this, args);
            }
            UpdateEventHandlerItens.Invoke(this,args);
        }        
    }
}
