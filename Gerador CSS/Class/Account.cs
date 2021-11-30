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
                bool Email_Valido = false;
                bool Email_Blocked = false;
                bool Existe = false;
                int Tentativas_Atual = 0;
                int Tentativas = 0;
                string sql_update = "";

                string StrConn = ConfigurationManager.AppSettings.Get("SqlServerConn").ToString();

                ConnectionSQLServer conexao = new ConnectionSQLServer(StrConn);

                string sql1 = $@"SELECT Email, Tentativas, Blocked FROM dbo.Accounts WHERE Email = '{user.Email}'";

                try
                {
                    DataTable table = conexao.FillDataTable(sql1);

                    if (table.Rows.Count > 0)
                    {
                        Email_Valido = true;

                        Tentativas_Atual = Convert.ToInt32(table.Rows[0]["Tentativas"]);

                        Email_Blocked = table.Rows[0]["Blocked"].ToString() == "S" ? true : false;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                if (!Email_Blocked)
                {
                    if (Email_Valido)
                    {
                        string sql2 = $"SELECT COUNT(*) AS Existe FROM dbo.Accounts WHERE Email = '{user.Email}' AND Password = '{user.Password}' AND Blocked = 'N'";

                        try
                        {
                            DataTable table2 = conexao.FillDataTable(sql2);

                            if (table2.Rows.Count > 0)
                            {
                                conexao.BeginTransaction();

                                Existe = table2.Rows[0]["Existe"].ToString() == "1" ? true : false;

                                if (!Existe)
                                {
                                    //Atualiza Número de Tentativas de Login

                                    Tentativas = Tentativas_Atual + 1;
                                   

                                    if (Tentativas == 5)
                                    {
                                        //Inicia o Bloqueio de Acesso para o Email Atual
                                        sql_update = $@"UPDATE dbo.Accounts SET Tentativas = '{Tentativas}', Blocked = 'S' WHERE Email = '{user.Email}'";

                                        Util.Log("BLOQUEIO DE CONTA: " + user.Email);
                                    }
                                    else
                                    {
                                        sql_update = $@"UPDATE dbo.Accounts SET Tentativas = '{Tentativas}' WHERE Email = '{user.Email}'";

                                        Util.Log("TENTATIVA DE LOGIN: " + user.Email + " N°: " + Tentativas);
                                    }
                                                                      
                                    conexao.StartCommandTransaction(sql_update);                                   
                                }
                                else
                                {
                                    sql_update = $@"UPDATE dbo.Accounts SET Tentativas = '0', Blocked = 'N' WHERE Email = '{user.Email}'";

                                    conexao.StartCommandTransaction(sql_update);
                                }

                                conexao.ExecuteTransaction();

                                conexao.CommitTransaction();
                            }
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }
                }
                else
                {
                    Util.Log("TENTATIVA DE ACESSO A EMAIL BLOQUEADO: " + user.Email);
                }
                return Existe;
            }

            return false;
        }

    }
}