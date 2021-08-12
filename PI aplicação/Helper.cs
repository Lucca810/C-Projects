using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PI_aplicação
{
    public class Helper
    {
        public static int inserirItemBase(int codigo, string desc)
        {
            try
            {
                Conexão a = new Conexão("localhost", "PI 3 sem", "root");
                a.sql = String.Format("INSERT INTO produto (cod_Produto,desc_Produto) values({0},'{1}')", codigo, desc);
                MySqlCommand command = new MySqlCommand(a.sql, a.mConn);
                command.ExecuteNonQuery();
                //caso de certo
                return 1;
            }
            catch (Exception ex)
            {
                //caso falhe
                return 0;
            }
        }

        public static int updateItemBase(int codigo, string desc)
        {
            try
            {
                Conexão a = new Conexão("localhost", "PI 3 sem", "root");
                a.sql = String.Format("UPDATE produto SET desc_Produto = '{0}' WHERE cod_Produto = {1}", desc, codigo);
                MySqlCommand command = new MySqlCommand(a.sql, a.mConn);
                command.ExecuteNonQuery();
                //caso de certo
                return 1;
            }
            catch (Exception e)
            {
                //caso falhe
                return 0;
            }
        }

        public static int excluirItemBase(int codigo)
        {
            try
            {
                Conexão a = new Conexão("localhost", "PI 3 sem", "root");
                a.sql = String.Format("DELETE FROM produto WHERE cod_Produto = {0} ", codigo);
                MySqlCommand command = new MySqlCommand(a.sql, a.mConn);
                command.ExecuteNonQuery();
                //caso de certo
                return 1;
            }
            catch (Exception ex)
            {
                //caso falhe
                return 0;
            }
        }
    }
}
