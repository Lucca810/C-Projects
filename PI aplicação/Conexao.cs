using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace PI_aplicação
{
    class Conexão
    {
        public MySqlConnection mConn;
        public MySqlDataAdapter mAdapter;
        public DataSet mDataSet;
        public string sql;
        public Conexão(string server, string db, string uid, string pwd = "")
        {
            this.mDataSet = new DataSet();
            this.mConn = new MySqlConnection("Persist Security Info=False; server=" + server + "; database=" + db + "; uid=" + uid + ";pwd=" + pwd + "");
            this.mConn.Open();
        }
    }
}