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
    public partial class frm_forn : Form
    {
        Conexão a = new Conexão("localhost", "PI 3 sem", "root");
        string cnpj = "";
        public frm_forn(string cnpj = "", string nome = "", string logradouro = "",string numero = "", string complemento = "")
        {
            InitializeComponent();
            if (Globais.op == "Alterar")
            {
                txt_cnpj.Enabled = false;

                txt_cnpj.Text = cnpj;
                txt_nome.Text = nome;
                txt_log.Text = logradouro;
                txt_numero.Text = numero;
                txt_comp.Text = complemento;
            }

            lbl_cabeçalho.Text = Globais.op + " " + lbl_cabeçalho.Text;
        }


        private void txt_cnpj_Leave(object sender, EventArgs e)
        {
            desfazerMascaraCNPJ();

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
                        MessageBox.Show("Fornecedor já existe, insira um novo código");
                        txt_cnpj.Text = "";
                        txt_cnpj.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void txt_numero_Leave(object sender, EventArgs e)
        {
            string armazenar;
            armazenar = txt_numero.Text;
            armazenar = armazenar.ToLower();
            if (armazenar.Contains("a") || armazenar.Contains("b") || armazenar.Contains("c") || armazenar.Contains("d") || armazenar.Contains("e") || armazenar.Contains("f") || armazenar.Contains("g") || armazenar.Contains("h") || armazenar.Contains("i") || armazenar.Contains("j") || armazenar.Contains("k") || armazenar.Contains("l") || armazenar.Contains("m") || armazenar.Contains("n") || armazenar.Contains("o") || armazenar.Contains("p") || armazenar.Contains("q") || armazenar.Contains("r") || armazenar.Contains("s") || armazenar.Contains("t") || armazenar.Contains("u") || armazenar.Contains("v") || armazenar.Contains("w") || armazenar.Contains("x") || armazenar.Contains("y") || armazenar.Contains("z") || armazenar.Contains("~") || armazenar.Contains("^") || armazenar.Contains(" "))
            {
                MessageBox.Show("Caracter inválido para o campo");
                txt_numero.Focus();
            }
        }

        private void btn_limp_Click(object sender, EventArgs e)
        {
            if (Globais.op == "Inserir")
            {
                txt_cnpj.Text = "";
                txt_log.Text = "";
                txt_nome.Text = "";
                txt_numero.Text = "";
                txt_comp.Text = "";

                txt_cnpj.Focus();
            }
            else if (Globais.op == "Alterar")
            {
                txt_log.Text = "";
                txt_nome.Text = "";
                txt_numero.Text = "";
                txt_comp.Text = "";

                txt_nome.Focus();
            }
        }

        private void btn_guard_Click(object sender, EventArgs e)
        {
            if (txt_cnpj.Text == "" || txt_nome.Text == "" || txt_log.Text == "")
            {
                MessageBox.Show("Preencha todos os campos com dados válidos");
            }
            else
            {
                if (Globais.op == "Inserir")
                {
                    inserir();                    
                }
                else if (Globais.op == "Alterar")
                {
                    atualizar();
                }
                this.Close();
            }
        }

        private void inserir()
        {
            try
            {
                a.sql = String.Format("INSERT INTO Fornecedor (cnpj_Fornecedor,nome_Fornecedor,logradouro_Fornecedor,numero_fornecedor,complemento_Fornecedor) values('{0}','{1}','{2}','{3}','{4}')", desfazerMascaraCNPJ(), txt_nome.Text,txt_log.Text,txt_numero.Text,txt_comp.Text);
                MySqlCommand command = new MySqlCommand(a.sql, a.mConn);
                command.ExecuteNonQuery();
                MessageBox.Show("Dados incluidos com sucesso");
                att();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível inserir os dados na tabela" + "\n" + "\n" + ex);
            }
        }

        private void atualizar()
        {
            try
            {
                a.sql = String.Format("UPDATE Fornecedor SET nome_Fornecedor = '{0}', logradouro_Fornecedor = '{1}', numero_Fornecedor = '{2}', complemento_Fornecedor = '{3}' WHERE cnpj_Fornecedor = {4}", txt_nome.Text, txt_log.Text,txt_numero.Text,txt_comp.Text,desfazerMascaraCNPJ());
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

        

        private string desfazerMascaraCNPJ()
        {
            txt_cnpj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            cnpj = txt_cnpj.Text;

            return cnpj;
        }

        //Funções para atualizar o grid

        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandlerItens;
        public event UpdateDelegate UpdateEventHandlerForn;

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }
        protected void att()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            if (Globais.op == "Alterar")
            {
                UpdateEventHandlerItens.Invoke(this, args);
                UpdateEventHandlerForn.Invoke(this, args);
            }
            else if (Globais.op == "Inserir")
            {
                UpdateEventHandlerForn.Invoke(this, args);
            }
        }

        
    }
}
