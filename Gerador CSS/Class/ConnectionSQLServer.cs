using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Gerador_CSS.Class
{
    public class ConnectionSQLServer
    {
        SqlConnection mConn;
        SqlTransaction transaction = null;
        public SqlCommand mCommand;

        public ConnectionSQLServer(string strConn)
        {
            mConn = new SqlConnection(strConn);
        }

        public void OpenConnection()
        {
            //Abre a conexao
            mConn.Open();
        }

        public void CloseConnection()
        {
            //Fecha a conexao
            mConn.Close();
        }

        public DataTable FillDataTable(String sql)
        {
            OpenConnection();

            DataTable table = new DataTable();

            //verifica se a conexão esta aberta
            if (mConn.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand(sql, mConn);
                //cria um adapter usando a instrução SQL para acessar a tabela
                SqlDataAdapter mAdapter = new SqlDataAdapter(cmd);

                try
                {
                    //preenche o DataTable via adapter
                    mAdapter.Fill(table);
                    CloseConnection();
                }
                catch
                {
                    if (mConn.State == ConnectionState.Open)
                    {
                        CloseConnection();
                    }
                }
            }

            return table;
        }

        public void ExecuteQuery(string sql)
        {
            OpenConnection();

            using (SqlCommand com = new SqlCommand(sql, mConn))
            {
                com.ExecuteNonQuery();
            }

            CloseConnection();
        }

        #region Transaction
        public void ExecuteTransaction()
        {
            foreach (SqlParameter p in mCommand.Parameters)
            {
                if (p.Value == null)
                    p.Value = DBNull.Value;
                else if (p.SqlDbType == SqlDbType.VarChar || p.SqlDbType == SqlDbType.NVarChar)
                    p.Value = Convert.ToString(p.Value).ToUpper();
            }

            mCommand.Connection = mConn;
            mCommand.Transaction = transaction;
            mCommand.ExecuteNonQuery();
        }

        public void ExecuteTransaction(bool toUpper)
        {
            foreach (SqlParameter p in mCommand.Parameters)
            {
                if (p.Value == null)
                    p.Value = DBNull.Value;
                else if (toUpper)
                {
                    if (p.SqlDbType == SqlDbType.VarChar || p.SqlDbType == SqlDbType.NVarChar)
                        p.Value = Convert.ToString(p.Value).ToUpper();
                }
            }

            mCommand.Connection = mConn;
            mCommand.Transaction = transaction;
            mCommand.ExecuteNonQuery();
        }

        public DataTable FillDataTableTransaction(String sql)
        {
            DataTable table = new DataTable();

            using (SqlCommand com = new SqlCommand(sql, mConn))
            {
                // Set the Connection to the new OdbcConnection.
                com.Connection = mConn;

                // Open the connection and execute the transaction.

                // Assign transaction object for a pending local transaction.
                com.Connection = mConn;
                com.Transaction = transaction;
                com.CommandText = sql;

                SqlDataAdapter mAdapter = new SqlDataAdapter(com);
                //preenche o DataTable via adapter
                mAdapter.Fill(table);
            }

            return table;
        }

        public string GetIdentityTransaction()
        {
            String sql = "SELECT @@IDENTITY";

            DataTable table = new DataTable();

            using (SqlCommand com = new SqlCommand(sql, mConn))
            {
                // Set the Connection to the new OdbcConnection.
                com.Connection = mConn;

                // Open the connection and execute the transaction.

                // Assign transaction object for a pending local transaction.
                com.Connection = mConn;
                com.Transaction = transaction;
                com.CommandText = sql;

                SqlDataAdapter mAdapter = new SqlDataAdapter(com);
                //preenche o DataTable via adapter
                mAdapter.Fill(table);
            }

            if (table.Rows.Count > 0)
            {
                return table.Rows[0][0].ToString();
            }

            return "";
        }

        public void BeginTransaction()
        {
            OpenConnection();

            // Start a local transaction
            transaction = mConn.BeginTransaction();
            mCommand = new SqlCommand();
        }

        public void CommitTransaction()
        {
            // Commit the transaction.
            transaction.Commit();

            CloseConnection();
        }

        public void RollbackTransaction()
        {
            if (mConn.State.Equals(ConnectionState.Open))
            {
                // Attempt to roll back the transaction.
                transaction.Rollback();

                CloseConnection();
            }
        }

        public void StartCommandTransaction(string sql)
        {
            mCommand = new SqlCommand(sql);
        }
        #endregion
    }
}