using Gerador_CSS.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

namespace Gerador_CSS.Class
{
    public class Account
    {

        public static bool VerifyAccess(User user)
        {

            if(!string.IsNullOrEmpty(user.Email) && !string.IsNullOrEmpty(user.Password))
            {
                bool Existe = false;

                string StrConn = ConfigurationManager.AppSettings.Get("SqlServerConn").ToString();

                ConnectionSQLServer conexao = new ConnectionSQLServer(StrConn);

                string sql = $"SELECT COUNT(*) AS Existe FROM dbo.Accounts WHERE Email = '{user.Email}' AND Password = '{user.Password}' AND Blocked = 'N'";

                try
                {
                    DataTable table = conexao.FillDataTable(sql);

                    if(table.Rows.Count > 0)
                    {
                        Existe = table.Rows[0]["Existe"].ToString() == "1" ? true : false;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                return Existe;
            }

            return false;
        }

    }
}