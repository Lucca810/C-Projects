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
    public partial class frm_item : Form
    {
        Conexão a = new Conexão("localhost", "PI 3 sem", "root");
        public string cnpj = "";
        public frm_item(string cod_itm = "", string desc = "", string cnpj = "", string forn = "", string qtd_at = "", string qtd_min = "")
        {
            InitializeComponent();

            lbl_cabeçalho.Text = Globais.op + " " + lbl_cabeçalho.Text;

            if (Globais.op == "Alterar" && Globais.op2 == "Base")
            {
                lbl_cabeçalho.Text = lbl_cabeçalho.Text + " " + Globais.op2;

                txt_cod.Enabled = false;
                txt_cnpj.Enabled = false;
                txt_forn.Enabled = false;
                txt_qtd_At.Enabled = false;
                txt_qtd_Min.Enabled = false;


                txt_cod.Text = cod_itm;
                txt_desc.Text = desc;

            }else if (Globais.op == "Alterar" && Globais.op2 == "")
            {
                txt_cod.Enabled = false;
                txt_cnpj.Enabled = false;
                txt_desc.Enabled = false;
                txt_forn.Enabled = false;

                txt_cod.Text = cod_itm;
                txt_cnpj.Text = cnpj;
                txt_desc.Text = desc;
                txt_forn.Text = forn;
                txt_qtd_At.Text = qtd_at;
                txt_qtd_Min.Text = qtd_min;

            }

            if (Globais.op == "Inserir" && Globais.op2 == "Base")
            {
                lbl_cabeçalho.Text = lbl_cabeçalho.Text + " " + Globais.op2;

                txt_cnpj.Enabled = false;
                txt_forn.Enabled = false;
                txt_qtd_At.Enabled = false;
                txt_qtd_Min.Enabled = false;                
            }else if (Globais.op == "Inserir" && Globais.op2 == "")
            {
                txt_desc.Enabled = false;
                txt_forn.Enabled = false;
            }

            
        }

        //Validações ao sair da textbox
        private void txt_cod_Leave(object sender, EventArgs e)
        {
            string armazenar;
            armazenar = txt_cod.Text;
            armazenar = armazenar.ToLower();
            if (armazenar.Contains("a") || armazenar.Contains("b") || armazenar.Contains("c") || armazenar.Contains("d") || armazenar.Contains("e") || armazenar.Contains("f") || armazenar.Contains("g") || armazenar.Contains("h") || armazenar.Contains("i") || armazenar.Contains("j") || armazenar.Contains("k") || armazenar.Contains("l") || armazenar.Contains("m") || armazenar.Contains("n") || armazenar.Contains("o") || armazenar.Contains("p") || armazenar.Contains("q") || armazenar.Contains("r") || armazenar.Contains("s") || armazenar.Contains("t") || armazenar.Contains("u") || armazenar.Contains("v") || armazenar.Contains("w") || armazenar.Contains("x") || armazenar.Contains("y") || armazenar.Contains("z") || armazenar.Contains("~") || armazenar.Contains("^") || armazenar.Contains(" "))
            {
                MessageBox.Show("Caracter inválido para o código");
                txt_cod.Focus();
            }
            else
            {
                if (Globais.op == "Inserir" && txt_cod.Text != "")
                {
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand("SELECT * FROM produto WHERE cod_Produto = " + txt_cod.Text, a.mConn);
                        a.mAdapter = new MySqlDataAdapter(cmd);
                        DataSet ds1 = new DataSet();
                        a.mAdapter.Fill(ds1);
                        int i = ds1.Tables[0].Rows.Count;
                        if (i > 0)
                        {
                            if (Globais.op2 == "")
                            {
                                txt_desc.Text = ds1.Tables[0].Rows[0][1].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Código já existe, favor inserir outro código");
                                txt_cod.Text = "";
                                txt_cod.Focus();
                            }
                        }
                        else if(i == 0 && Globais.op2 == "")
                        {
                            MessageBox.Show("Código não existe, favor inserir um código válido");
                            txt_cod.Text = "";
                            txt_cod.Focus();
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
            txt_cnpj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            cnpj = txt_cnpj.Text;

            if (Globais.op == "Inserir" && cnpj != "")
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
                        txt_forn.Text = ds1.Tables[0].Rows[0][1].ToString();
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
                    MessageBox.Show("Não foi possível encontrar o fornecedor");
                }
            }
        }

        private void btn_limp_Click(object sender, EventArgs e)
        {
            if(Globais.op == "Inserir")
            {
                if(Globais.op2 == "")
                {
                    txt_cnpj.Text = "";
                    txt_cod.Text = "";
                    txt_desc.Text = "";
                    txt_cnpj.Text = "";
                    txt_qtd_At.Text = "";
                    txt_qtd_Min.Text = "";

                    txt_cod.Focus();
                }
                else
                {
                    txt_cod.Text = "";
                    txt_desc.Text = "";
                    txt_cod.Focus();
                }
                
            }else if (Globais.op == "Alterar")
            {
                if (Globais.op2 == "")
                {
                    txt_qtd_At.Text = "";
                    txt_qtd_Min.Text = "";

                    txt_qtd_At.Focus();
                }
                else
                {
                    txt_desc.Text = "";
                    txt_desc.Focus();
                }
            }
        }

        private void btn_guard_Click(object sender, EventArgs e)
        {

            if (Globais.op == "Inserir")
            {

                //fazer o insert variando entre produto base e produto completo
                if (Globais.op2 == "Base")
                {
                    inserirItemBase();
                }
                else
                {
                    inserirItemComp();
                }
                this.Close();                  
            }
            else if (Globais.op == "Alterar")
            {
                //fazer o update variando entre produto base e produto completo
                if (Globais.op2 == "Base")
                {
                    updateItemB();                    
                    }
                else
                {
                    updateItem();
                }
                this.Close();
            }            
        }

        //Funções gerais
        public void inserirItemComp()
        {
            try
            {
                a.sql = String.Format("INSERT INTO produto_fornecedor (cod_Produto, cnpj_Fornecedor, qtd_Produto, qtd_Produto_Min) values({0},'{1}',{2},{3})", txt_cod.Text, cnpj, txt_qtd_At.Text, txt_qtd_Min.Text);
                MySqlCommand command = new MySqlCommand(a.sql, a.mConn);
                command.ExecuteNonQuery();
                MessageBox.Show("Dados incluidos com sucesso");
                att();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Esse item já existe no banco");
            }
        }

        public void inserirItemBase()
        {
            try
            {
                a.sql = String.Format("INSERT INTO produto (cod_Produto,desc_Produto) values({0},'{1}')", txt_cod.Text, txt_desc.Text);
                MySqlCommand command = new MySqlCommand(a.sql, a.mConn);
                command.ExecuteNonQuery();
                MessageBox.Show("Dados incluidos com sucesso");
                att();                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar essa operação");
            }
        }

        public void updateItem()
        {
            txt_cnpj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            cnpj = txt_cnpj.Text;

            try
            {
                a.sql = String.Format("UPDATE produto_fornecedor SET qtd_Produto = {0}, qtd_Produto_Min = {1} WHERE cod_Produto = {2} AND cnpj_Fornecedor = {3}", txt_qtd_At.Text, txt_qtd_Min.Text, txt_cod.Text, cnpj);
                MySqlCommand command = new MySqlCommand(a.sql, a.mConn);
                command.ExecuteNonQuery();
                MessageBox.Show("Dados alterados com sucesso");
                att();
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível realizar a operação" + "\n" + "\n" + e);
            }
        }

        public void updateItemB()
        {
            try
            {
                a.sql = String.Format("UPDATE produto SET desc_Produto = '{0}' WHERE cod_Produto = {1}", txt_desc.Text,txt_cod.Text);
                MySqlCommand command = new MySqlCommand(a.sql, a.mConn);
                command.ExecuteNonQuery();
                MessageBox.Show("Dados alterados com sucesso");
                att();
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível realizar a operação" + "\n" + "\n" + e);
            }
        }

        //Funções para atualizar o grid

        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandlerItens;
        public event UpdateDelegate UpdateEventHandlerItensB;

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }
        protected void att()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            if (Globais.op == "Alterar")
            {
                if (Globais.op2 == "")
                {
                    UpdateEventHandlerItens.Invoke(this, args);
                }
                else if (Globais.op2 == "Base")
                {
                    UpdateEventHandlerItens.Invoke(this, args);
                    UpdateEventHandlerItensB.Invoke(this, args);
                }                
            }else if(Globais.op == "Inserir")
            {
                if (Globais.op2 == "")
                {
                    UpdateEventHandlerItens.Invoke(this, args);
                }
                else if (Globais.op2 == "Base")
                {
                    UpdateEventHandlerItensB.Invoke(this, args);
                }
            }
            
        }

        private void txt_cod_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_qtd_At_TextChanged(object sender, EventArgs e)
        {

        }
        private void txt_qtd_At_Leave(object sender, EventArgs e)
        {
            string armazenar;
            armazenar = txt_qtd_At.Text;
            armazenar = armazenar.ToLower();
            if (armazenar.Contains("a") || armazenar.Contains("b") || armazenar.Contains("c") || armazenar.Contains("d") || armazenar.Contains("e") || armazenar.Contains("f") || armazenar.Contains("g") || armazenar.Contains("h") || armazenar.Contains("i") || armazenar.Contains("j") || armazenar.Contains("k") || armazenar.Contains("l") || armazenar.Contains("m") || armazenar.Contains("n") || armazenar.Contains("o") || armazenar.Contains("p") || armazenar.Contains("q") || armazenar.Contains("r") || armazenar.Contains("s") || armazenar.Contains("t") || armazenar.Contains("u") || armazenar.Contains("v") || armazenar.Contains("w") || armazenar.Contains("x") || armazenar.Contains("y") || armazenar.Contains("z") || armazenar.Contains("~") || armazenar.Contains("^") || armazenar.Contains(" "))
            {
                MessageBox.Show("Caracter inválido para o código");
                txt_qtd_At.Focus();
            }
        }

        private void txt_qtd_Min_TextChanged(object sender, EventArgs e)
        {

        }
        private void txt_qtd_Min_Leave(object sender, EventArgs e)
        {
            string armazenar;
            armazenar = txt_qtd_Min.Text;
            armazenar = armazenar.ToLower();
            if (armazenar.Contains("a") || armazenar.Contains("b") || armazenar.Contains("c") || armazenar.Contains("d") || armazenar.Contains("e") || armazenar.Contains("f") || armazenar.Contains("g") || armazenar.Contains("h") || armazenar.Contains("i") || armazenar.Contains("j") || armazenar.Contains("k") || armazenar.Contains("l") || armazenar.Contains("m") || armazenar.Contains("n") || armazenar.Contains("o") || armazenar.Contains("p") || armazenar.Contains("q") || armazenar.Contains("r") || armazenar.Contains("s") || armazenar.Contains("t") || armazenar.Contains("u") || armazenar.Contains("v") || armazenar.Contains("w") || armazenar.Contains("x") || armazenar.Contains("y") || armazenar.Contains("z") || armazenar.Contains("~") || armazenar.Contains("^") || armazenar.Contains(" "))
            {
                MessageBox.Show("Caracter inválido para o código");
                txt_qtd_Min.Focus();
            }
        }
    }
}
