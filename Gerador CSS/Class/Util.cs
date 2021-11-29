using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Web;

namespace Gerador_CSS.Class
{
    public class Util
    {
        public static string GetParam_Button_Default()
        {

            try
            {
                return ConfigurationManager.AppSettings.Get("Button_Default").ToString();
            }
            catch
            {
            }

            return "";
        }

        public static void Log(string info)
        {
			string StrConn = ConfigurationManager.AppSettings.Get("SqlServerConn").ToString();

			ConnectionSQLServer conexao = new ConnectionSQLServer(StrConn);

			conexao.BeginTransaction();

			try
			{


				string sql = @"INSERT INTO dbo.Log_Dados	
										(
											Dh_Log, 
											Info, 
											User_Ip	
										)
										VALUES
										(
											@Dh_Log, 
											@Info, 
											@User_Ip	
										)";


				conexao.StartCommandTransaction(sql);

				conexao.mCommand.Parameters.AddWithValue("Dh_Log", TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time")));
				conexao.mCommand.Parameters.AddWithValue("Info", info);
				conexao.mCommand.Parameters.AddWithValue("User_Ip", Dns.GetHostAddresses(Dns.GetHostName())[2].ToString());



				conexao.ExecuteTransaction();
				conexao.CommitTransaction();
			}
			catch (Exception ex)
			{
				conexao.RollbackTransaction();
				throw ex;
			}
		}

    }
}