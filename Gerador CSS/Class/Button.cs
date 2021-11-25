using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gerador_CSS.Class;
namespace Gerador_CSS.Class
{
    public class Button
    {
        public static List<Models.Button> GetAllButtons()
        {
			string button_default_id = Class.Util.GetParam_Button_Default();

			string SystemPath = ConfigurationManager.AppSettings.Get("SystemPath").ToString();
            string StrConn = ConfigurationManager.AppSettings.Get("SqlServerConn").ToString();

            List<Models.Button> List_Buttons = new List<Models.Button>();

            ConnectionSQLServer conexao = new ConnectionSQLServer(StrConn);

			string sql = $@"SELECT	BT.Button_Id,								
									BTS.Static_Border_Top_Width,
									BTS.Static_Border_Bottom_Width,
									BTS.Static_Border_Left_Width,
									BTS.Static_Border_Right_Width,
									BTS.Static_Border_Top_Style,
									BTS.Static_Border_Bottom_Style,
									BTS.Static_Border_Left_Style,
									BTS.Static_Border_Right_Style,
									BTS.Static_Border_Top_Color,
									BTS.Static_Border_Bottom_Color,
									BTS.Static_Border_Left_Color,
									BTS.Static_Border_Right_Color,
									BTS.Static_Top_Left_Radius,
									BTS.Static_Top_Right_Radius,
									BTS.Static_Bottom_Left_Radius,
									BTS.Static_Bottom_Right_Radius,
									BTS.Static_Padding_Top,
									BTS.Static_Padding_Bottom,
									BTS.Static_Padding_Left,
									BTS.Static_Padding_Right,
									BTS.Static_Font_Size,
									BTS.Static_Font_Style,
									BTS.Static_Font_Weight,									
									BTS.Static_Background_Color,
									BTS.Static_Color,
									BTS.Static_Box_Shadow,
									BTS.Static_Text_Shadow,			
									BTS.Static_Box_Shadow_Offset_X,
									BTS.Static_Box_Shadow_Offset_Y,
									BTS.Static_Box_Shadow_Blur_Radius,
									BTS.Static_Box_Shadow_Spread_Radius,
									BTS.Static_Box_Shadow_Color,
									BTS.Static_Box_Shadow_Inset_Offset_X,
									BTS.Static_Box_Shadow_Inset_Offset_Y,
									BTS.Static_Box_Shadow_Inset_Blur_Radius,
									BTS.Static_Box_Shadow_Inset_Spread_Radius,
									BTS.Static_Box_Shadow_Inset_Color,
									BTH.Hover_Border_Top_Width,
									BTH.Hover_Border_Bottom_Width,
									BTH.Hover_Border_Left_Width,
									BTH.Hover_Border_Right_Width,
									BTH.Hover_Border_Top_Style,
									BTH.Hover_Border_Bottom_Style,
									BTH.Hover_Border_Left_Style,
									BTH.Hover_Border_Right_Style,
									BTH.Hover_Border_Top_Color,
									BTH.Hover_Border_Bottom_Color,
									BTH.Hover_Border_Left_Color,
									BTH.Hover_Border_Right_Color,
									BTH.Hover_Top_Left_Radius,
									BTH.Hover_Top_Right_Radius,
									BTH.Hover_Bottom_Left_Radius,
									BTH.Hover_Bottom_Right_Radius,
									BTH.Hover_Padding_Top,
									BTH.Hover_Padding_Bottom,
									BTH.Hover_Padding_Left,
									BTH.Hover_Padding_Right,
									BTH.Hover_Font_Size,
									BTH.Hover_Font_Style,
									BTH.Hover_Font_Weight,
									BTH.Hover_Color,
									BTH.Hover_Background_Color,
									BTH.Hover_Box_Shadow,
									BTH.Hover_Text_Shadow
									FROM 
									dbo.Button AS BT 
									JOIN dbo.Button_Static_Properties AS BTS 
									ON(BT.Button_Static_Id = BTS.Static_Button_Id) 
									JOIN dbo.Button_Hover_Properties AS BTH 
									ON(BT.Button_Hover_Id = BTH.Hover_Button_Id)";

				if (!string.IsNullOrEmpty(button_default_id))
				{
					sql += $@"WHERE BT.Button_Id != '{button_default_id}'";
				}

			try
			{
				DataTable table = conexao.FillDataTable(sql);

				foreach (DataRow row in table.Rows)
				{
					Models.Button Button = new Models.Button();

					Button.Button_id = Convert.ToInt32(row["Button_Id"]);
					Button.Static_Border_Top_Width = row["Static_Border_Top_Width"].ToString();
					Button.Static_Border_Bottom_Width = row["Static_Border_Bottom_Width"].ToString();
					Button.Static_Border_Left_Width = row["Static_Border_Left_Width"].ToString();
					Button.Static_Border_Right_Width = row["Static_Border_Right_Width"].ToString();
					Button.Static_Border_Top_Style = row["Static_Border_Top_Style"].ToString();
					Button.Static_Border_Bottom_Style = row["Static_Border_Bottom_Style"].ToString();
					Button.Static_Border_Left_Style = row["Static_Border_Left_Style"].ToString();
					Button.Static_Border_Right_Style = row["Static_Border_Right_Style"].ToString();
					Button.Static_Border_Top_Color = row["Static_Border_Top_Color"].ToString();
					Button.Static_Border_Bottom_Color = row["Static_Border_Bottom_Color"].ToString();
					Button.Static_Border_Left_Color = row["Static_Border_Left_Color"].ToString();
					Button.Static_Border_Right_Color = row["Static_Border_Right_Color"].ToString();
					Button.Static_Border_Top_Left_Radius = row["Static_Top_Left_Radius"].ToString();
					Button.Static_Border_Top_Right_Radius = row["Static_Top_Right_Radius"].ToString();
					Button.Static_Border_Bottom_Left_Radius = row["Static_Bottom_Left_Radius"].ToString();
					Button.Static_Border_Bottom_Right_Radius = row["Static_Bottom_Right_Radius"].ToString();
					Button.Static_Padding_Top = row["Static_Padding_Top"].ToString();
					Button.Static_Padding_Bottom = row["Static_Padding_Bottom"].ToString();
					Button.Static_Padding_Left = row["Static_Padding_Left"].ToString();
					Button.Static_Padding_Right = row["Static_Padding_Right"].ToString();
					Button.Static_Font_Size = row["Static_Font_Size"].ToString();
					Button.Static_Font_Style = row["Static_Font_Style"].ToString();
					Button.Static_Font_Weight = row["Static_Font_Weight"].ToString();
					Button.Static_Background_Color = row["Static_Background_Color"].ToString();
					Button.Static_Color = row["Static_Color"].ToString();
					Button.Static_Box_Shadow = row["Static_Box_Shadow"].ToString();
					Button.Static_Text_Shadow = row["Static_Text_Shadow"].ToString();
					Button.Static_Box_Shadow_Offset_X = row["Static_Box_Shadow_Offset_X"].ToString();
					Button.Static_Box_Shadow_Offset_Y = row["Static_Box_Shadow_Offset_Y"].ToString();
					Button.Static_Box_Shadow_Blur_Radius = row["Static_Box_Shadow_Blur_Radius"].ToString();
					Button.Static_Box_Shadow_Spread_Radius = row["Static_Box_Shadow_Spread_Radius"].ToString();
					Button.Static_Box_Shadow_Color = row["Static_Box_Shadow_Color"].ToString();
					Button.Static_Box_Shadow_Inset_Offset_X = row["Static_Box_Shadow_Inset_Offset_X"].ToString();
					Button.Static_Box_Shadow_Inset_Offset_Y = row["Static_Box_Shadow_Inset_Offset_Y"].ToString();
					Button.Static_Box_Shadow_Inset_Blur_Radius = row["Static_Box_Shadow_Inset_Blur_Radius"].ToString();
					Button.Static_Box_Shadow_Inset_Spread_Radius = row["Static_Box_Shadow_Inset_Spread_Radius"].ToString();
					Button.Static_Box_Shadow_Inset_Color = row["Static_Box_Shadow_Inset_Color"].ToString();

					//HOVER
					Button.Hover_Border_Top_Width = row["Hover_Border_Top_Width"].ToString();
					Button.Hover_Border_Bottom_Width = row["Hover_Border_Bottom_Width"].ToString();
					Button.Hover_Border_Left_Width = row["Hover_Border_Left_Width"].ToString();
					Button.Hover_Border_Right_Width = row["Hover_Border_Right_Width"].ToString();
					Button.Hover_Border_Top_Style = row["Hover_Border_Top_Style"].ToString();
					Button.Hover_Border_Bottom_Style = row["Hover_Border_Bottom_Style"].ToString();
					Button.Hover_Border_Left_Style = row["Hover_Border_Left_Style"].ToString();
					Button.Hover_Border_Right_Style = row["Hover_Border_Right_Style"].ToString();
					Button.Hover_Border_Top_Color = row["Hover_Border_Top_Color"].ToString();
					Button.Hover_Border_Bottom_Color = row["Hover_Border_Bottom_Color"].ToString();
					Button.Hover_Border_Left_Color = row["Hover_Border_Left_Color"].ToString();
					Button.Hover_Border_Right_Color = row["Hover_Border_Right_Color"].ToString();
					Button.Hover_Border_Top_Left_Radius = row["Hover_Top_Left_Radius"].ToString();
					Button.Hover_Border_Top_Right_Radius = row["Hover_Top_Right_Radius"].ToString();
					Button.Hover_Border_Bottom_Left_Radius = row["Hover_Bottom_Left_Radius"].ToString();
					Button.Hover_Border_Bottom_Right_Radius = row["Hover_Bottom_Right_Radius"].ToString();
					Button.Hover_Padding_Top = row["Hover_Padding_Top"].ToString();
					Button.Hover_Padding_Bottom = row["Hover_Padding_Bottom"].ToString();
					Button.Hover_Padding_Left = row["Hover_Padding_Left"].ToString();
					Button.Hover_Padding_Right = row["Hover_Padding_Right"].ToString();
					Button.Hover_Font_Size = row["Hover_Font_Size"].ToString();
					Button.Hover_Font_Style = row["Hover_Font_Style"].ToString();
					Button.Hover_Font_Weight = row["Hover_Font_Weight"].ToString();
					Button.Hover_Color = row["Hover_Color"].ToString();
					Button.Hover_Background_Color = row["Hover_Background_Color"].ToString();
					Button.Hover_Box_Shadow = row["Hover_Box_Shadow"].ToString();
					Button.Hover_Text_Shadow = row["Hover_Text_Shadow"].ToString();


					List_Buttons.Add(Button);
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}


            return List_Buttons;
        }

		public static Models.Button GetButtonById(string idButton)
		{

			string SystemPath = ConfigurationManager.AppSettings.Get("SystemPath").ToString();
			string StrConn = ConfigurationManager.AppSettings.Get("SqlServerConn").ToString();

			Models.Button Button = new Models.Button();

			ConnectionSQLServer conexao = new ConnectionSQLServer(StrConn);

			string sql = $@"SELECT	BT.Button_Id,								
									BTS.Static_Border_Top_Width,
									BTS.Static_Border_Bottom_Width,
									BTS.Static_Border_Left_Width,
									BTS.Static_Border_Right_Width,
									BTS.Static_Border_Top_Style,
									BTS.Static_Border_Bottom_Style,
									BTS.Static_Border_Left_Style,
									BTS.Static_Border_Right_Style,
									BTS.Static_Border_Top_Color,
									BTS.Static_Border_Bottom_Color,
									BTS.Static_Border_Left_Color,
									BTS.Static_Border_Right_Color,
									BTS.Static_Top_Left_Radius,
									BTS.Static_Top_Right_Radius,
									BTS.Static_Bottom_Left_Radius,
									BTS.Static_Bottom_Right_Radius,
									BTS.Static_Padding_Top,
									BTS.Static_Padding_Bottom,
									BTS.Static_Padding_Left,
									BTS.Static_Padding_Right,
									BTS.Static_Font_Size,
									BTS.Static_Font_Style,
									BTS.Static_Font_Weight,									
									BTS.Static_Background_Color,
									BTS.Static_Color,
									BTS.Static_Box_Shadow,
									BTS.Static_Text_Shadow,			
									BTS.Static_Box_Shadow_Offset_X,
									BTS.Static_Box_Shadow_Offset_Y,
									BTS.Static_Box_Shadow_Blur_Radius,
									BTS.Static_Box_Shadow_Spread_Radius,
									BTS.Static_Box_Shadow_Color,
									BTS.Static_Box_Shadow_Inset_Offset_X,
									BTS.Static_Box_Shadow_Inset_Offset_Y,
									BTS.Static_Box_Shadow_Inset_Blur_Radius,
									BTS.Static_Box_Shadow_Inset_Spread_Radius,
									BTS.Static_Box_Shadow_Inset_Color,
									BTS.Static_Text_Shadow_Offset_X,
									BTS.Static_Text_Shadow_Offset_Y,
									BTS.Static_Text_Shadow_Blur_Radius,
									BTS.Static_Text_Shadow_Color,
									BTH.Hover_Border_Top_Width,
									BTH.Hover_Border_Bottom_Width,
									BTH.Hover_Border_Left_Width,
									BTH.Hover_Border_Right_Width,
									BTH.Hover_Border_Top_Style,
									BTH.Hover_Border_Bottom_Style,
									BTH.Hover_Border_Left_Style,
									BTH.Hover_Border_Right_Style,
									BTH.Hover_Border_Top_Color,
									BTH.Hover_Border_Bottom_Color,
									BTH.Hover_Border_Left_Color,
									BTH.Hover_Border_Right_Color,
									BTH.Hover_Top_Left_Radius,
									BTH.Hover_Top_Right_Radius,
									BTH.Hover_Bottom_Left_Radius,
									BTH.Hover_Bottom_Right_Radius,
									BTH.Hover_Padding_Top,
									BTH.Hover_Padding_Bottom,
									BTH.Hover_Padding_Left,
									BTH.Hover_Padding_Right,
									BTH.Hover_Font_Size,
									BTH.Hover_Font_Style,
									BTH.Hover_Font_Weight,
									BTH.Hover_Color,
									BTH.Hover_Background_Color,
									BTH.Hover_Box_Shadow,
									BTH.Hover_Text_Shadow,
									BTH.Hover_Box_Shadow_Offset_X,
									BTH.Hover_Box_Shadow_Offset_Y,
									BTH.Hover_Box_Shadow_Blur_Radius,
									BTH.Hover_Box_Shadow_Spread_Radius,
									BTH.Hover_Box_Shadow_Color,
									BTH.Hover_Box_Shadow_Inset_Offset_X,
									BTH.Hover_Box_Shadow_Inset_Offset_Y,
									BTH.Hover_Box_Shadow_Inset_Blur_Radius,
									BTH.Hover_Box_Shadow_Inset_Spread_Radius,
									BTH.Hover_Box_Shadow_Inset_Color,
									BTH.Hover_Text_Shadow_Offset_X,
									BTH.Hover_Text_Shadow_Offset_Y,
									BTH.Hover_Text_Shadow_Blur_Radius,
									BTH.Hover_Text_Shadow_Color
									FROM 
									dbo.Button AS BT 
									JOIN dbo.Button_Static_Properties AS BTS 
									ON(BT.Button_Static_Id = BTS.Static_Button_Id) 
									JOIN dbo.Button_Hover_Properties AS BTH 
									ON(BT.Button_Hover_Id = BTH.Hover_Button_Id)
								WHERE 
									BT.Button_Id = '{idButton}'";


			try
			{
				DataTable table = conexao.FillDataTable(sql);

				if(table.Rows.Count > 0)
                {					

					Button.Button_id = Convert.ToInt32(table.Rows[0]["Button_Id"]);
					Button.Static_Border_Top_Width = table.Rows[0]["Static_Border_Top_Width"].ToString();
					Button.Static_Border_Bottom_Width = table.Rows[0]["Static_Border_Bottom_Width"].ToString();
					Button.Static_Border_Left_Width = table.Rows[0]["Static_Border_Left_Width"].ToString();
					Button.Static_Border_Right_Width = table.Rows[0]["Static_Border_Right_Width"].ToString();
					Button.Static_Border_Top_Style = table.Rows[0]["Static_Border_Top_Style"].ToString();
					Button.Static_Border_Bottom_Style = table.Rows[0]["Static_Border_Bottom_Style"].ToString();
					Button.Static_Border_Left_Style = table.Rows[0]["Static_Border_Left_Style"].ToString();
					Button.Static_Border_Right_Style = table.Rows[0]["Static_Border_Right_Style"].ToString();
					Button.Static_Border_Top_Color = table.Rows[0]["Static_Border_Top_Color"].ToString();
					Button.Static_Border_Bottom_Color = table.Rows[0]["Static_Border_Bottom_Color"].ToString();
					Button.Static_Border_Left_Color = table.Rows[0]["Static_Border_Left_Color"].ToString();
					Button.Static_Border_Right_Color = table.Rows[0]["Static_Border_Right_Color"].ToString();
					Button.Static_Border_Top_Left_Radius = table.Rows[0]["Static_Top_Left_Radius"].ToString();
					Button.Static_Border_Top_Right_Radius = table.Rows[0]["Static_Top_Right_Radius"].ToString();
					Button.Static_Border_Bottom_Left_Radius = table.Rows[0]["Static_Bottom_Left_Radius"].ToString();
					Button.Static_Border_Bottom_Right_Radius = table.Rows[0]["Static_Bottom_Right_Radius"].ToString();
					Button.Static_Padding_Top = table.Rows[0]["Static_Padding_Top"].ToString();
					Button.Static_Padding_Bottom = table.Rows[0]["Static_Padding_Bottom"].ToString();
					Button.Static_Padding_Left = table.Rows[0]["Static_Padding_Left"].ToString();
					Button.Static_Padding_Right = table.Rows[0]["Static_Padding_Right"].ToString();
					Button.Static_Font_Size = table.Rows[0]["Static_Font_Size"].ToString();
					Button.Static_Font_Style = table.Rows[0]["Static_Font_Style"].ToString();
					Button.Static_Font_Weight = table.Rows[0]["Static_Font_Weight"].ToString();
					Button.Static_Background_Color = table.Rows[0]["Static_Background_Color"].ToString();
					Button.Static_Color = table.Rows[0]["Static_Color"].ToString();
					Button.Static_Box_Shadow = table.Rows[0]["Static_Box_Shadow"].ToString();					
					Button.Static_Box_Shadow_Offset_X = table.Rows[0]["Static_Box_Shadow_Offset_X"].ToString();
					Button.Static_Box_Shadow_Offset_Y = table.Rows[0]["Static_Box_Shadow_Offset_Y"].ToString();
					Button.Static_Box_Shadow_Blur_Radius = table.Rows[0]["Static_Box_Shadow_Blur_Radius"].ToString();
					Button.Static_Box_Shadow_Spread_Radius = table.Rows[0]["Static_Box_Shadow_Spread_Radius"].ToString();
					Button.Static_Box_Shadow_Color = table.Rows[0]["Static_Box_Shadow_Color"].ToString();					
					Button.Static_Box_Shadow_Inset_Offset_X = table.Rows[0]["Static_Box_Shadow_Inset_Offset_X"].ToString();
					Button.Static_Box_Shadow_Inset_Offset_Y = table.Rows[0]["Static_Box_Shadow_Inset_Offset_Y"].ToString();
					Button.Static_Box_Shadow_Inset_Blur_Radius = table.Rows[0]["Static_Box_Shadow_Inset_Blur_Radius"].ToString();
					Button.Static_Box_Shadow_Inset_Spread_Radius = table.Rows[0]["Static_Box_Shadow_Inset_Spread_Radius"].ToString();
					Button.Static_Box_Shadow_Inset_Color = table.Rows[0]["Static_Box_Shadow_Inset_Color"].ToString();					
					Button.Static_Text_Shadow = table.Rows[0]["Static_Text_Shadow"].ToString();
					Button.Static_Text_Shadow_Offset_X = table.Rows[0]["Static_Text_Shadow_Offset_X"].ToString();
					Button.Static_Text_Shadow_Offset_Y = table.Rows[0]["Static_Text_Shadow_Offset_Y"].ToString();
					Button.Static_Text_Shadow_Blur_Radius= table.Rows[0]["Static_Text_Shadow_Blur_Radius"].ToString();
					Button.Static_Text_Shadow_Color = table.Rows[0]["Static_Text_Shadow_Color"].ToString();


					//----------------------------------------- HOVER----------------------------------------------------
					Button.Hover_Border_Top_Width = table.Rows[0]["Hover_Border_Top_Width"].ToString();
					Button.Hover_Border_Bottom_Width = table.Rows[0]["Hover_Border_Bottom_Width"].ToString();
					Button.Hover_Border_Left_Width = table.Rows[0]["Hover_Border_Left_Width"].ToString();
					Button.Hover_Border_Right_Width = table.Rows[0]["Hover_Border_Right_Width"].ToString();
					Button.Hover_Border_Top_Style = table.Rows[0]["Hover_Border_Top_Style"].ToString();
					Button.Hover_Border_Bottom_Style = table.Rows[0]["Hover_Border_Bottom_Style"].ToString();
					Button.Hover_Border_Left_Style = table.Rows[0]["Hover_Border_Left_Style"].ToString();
					Button.Hover_Border_Right_Style = table.Rows[0]["Hover_Border_Right_Style"].ToString();
					Button.Hover_Border_Top_Color = table.Rows[0]["Hover_Border_Top_Color"].ToString();
					Button.Hover_Border_Bottom_Color = table.Rows[0]["Hover_Border_Bottom_Color"].ToString();
					Button.Hover_Border_Left_Color = table.Rows[0]["Hover_Border_Left_Color"].ToString();
					Button.Hover_Border_Right_Color = table.Rows[0]["Hover_Border_Right_Color"].ToString();
					Button.Hover_Border_Top_Left_Radius = table.Rows[0]["Hover_Top_Left_Radius"].ToString();
					Button.Hover_Border_Top_Right_Radius = table.Rows[0]["Hover_Top_Right_Radius"].ToString();
					Button.Hover_Border_Bottom_Left_Radius = table.Rows[0]["Hover_Bottom_Left_Radius"].ToString();
					Button.Hover_Border_Bottom_Right_Radius = table.Rows[0]["Hover_Bottom_Right_Radius"].ToString();
					Button.Hover_Padding_Top = table.Rows[0]["Hover_Padding_Top"].ToString();
					Button.Hover_Padding_Bottom = table.Rows[0]["Hover_Padding_Bottom"].ToString();
					Button.Hover_Padding_Left = table.Rows[0]["Hover_Padding_Left"].ToString();
					Button.Hover_Padding_Right = table.Rows[0]["Hover_Padding_Right"].ToString();
					Button.Hover_Font_Size = table.Rows[0]["Hover_Font_Size"].ToString();
					Button.Hover_Font_Style = table.Rows[0]["Hover_Font_Style"].ToString();
					Button.Hover_Font_Weight = table.Rows[0]["Hover_Font_Weight"].ToString();
					Button.Hover_Color = table.Rows[0]["Hover_Color"].ToString();
					Button.Hover_Background_Color = table.Rows[0]["Hover_Background_Color"].ToString();
					Button.Hover_Box_Shadow = table.Rows[0]["Hover_Box_Shadow"].ToString();
					Button.Hover_Box_Shadow_Offset_X = table.Rows[0]["Hover_Box_Shadow_Offset_X"].ToString();
					Button.Hover_Box_Shadow_Offset_Y = table.Rows[0]["Hover_Box_Shadow_Offset_Y"].ToString();
					Button.Hover_Box_Shadow_Blur_Radius = table.Rows[0]["Hover_Box_Shadow_Blur_Radius"].ToString();
					Button.Hover_Box_Shadow_Spread_Radius = table.Rows[0]["Hover_Box_Shadow_Spread_Radius"].ToString();
					Button.Hover_Box_Shadow_Color = table.Rows[0]["Hover_Box_Shadow_Color"].ToString();
					Button.Hover_Box_Shadow_Inset_Offset_X = table.Rows[0]["Hover_Box_Shadow_Inset_Offset_X"].ToString();
					Button.Hover_Box_Shadow_Inset_Offset_Y = table.Rows[0]["Hover_Box_Shadow_Inset_Offset_Y"].ToString();
					Button.Hover_Box_Shadow_Inset_Blur_Radius = table.Rows[0]["Hover_Box_Shadow_Inset_Blur_Radius"].ToString();
					Button.Hover_Box_Shadow_Inset_Spread_Radius = table.Rows[0]["Hover_Box_Shadow_Inset_Spread_Radius"].ToString();
					Button.Hover_Box_Shadow_Inset_Color = table.Rows[0]["Hover_Box_Shadow_Inset_Color"].ToString();
					Button.Hover_Text_Shadow = table.Rows[0]["Hover_Text_Shadow"].ToString();
					Button.Hover_Text_Shadow_Offset_X = table.Rows[0]["Hover_Text_Shadow_Offset_X"].ToString();
					Button.Hover_Text_Shadow_Offset_Y = table.Rows[0]["Hover_Text_Shadow_Offset_Y"].ToString();
					Button.Hover_Text_Shadow_Blur_Radius = table.Rows[0]["Hover_Text_Shadow_Blur_Radius"].ToString();
					Button.Hover_Text_Shadow_Color = table.Rows[0]["Hover_Text_Shadow_Color"].ToString();

					int Static_Box_Shadow_Offset_X = Convert.ToInt32(Button.Static_Box_Shadow_Offset_X.Replace("px", string.Empty));
					int Static_Box_Shadow_Offset_Y = Convert.ToInt32(Button.Static_Box_Shadow_Offset_Y.Replace("px", string.Empty));
					int Static_Box_Shadow_Blur_Radius = Convert.ToInt32(Button.Static_Box_Shadow_Blur_Radius.Replace("px", string.Empty));
					int Static_Box_Shadow_Spread_Radius = Convert.ToInt32(Button.Static_Box_Shadow_Spread_Radius.Replace("px", string.Empty));

					if (Static_Box_Shadow_Offset_X > 0 || Static_Box_Shadow_Offset_Y > 0 || Static_Box_Shadow_Blur_Radius > 0 || Static_Box_Shadow_Spread_Radius > 0)
                    {
						Button.Static_Box_Shadow_Enable = true;
                    }
                    else
                    {
						Button.Static_Box_Shadow_Enable = false;
					}


					int Static_Box_Shadow_Inset_Offset_X = Convert.ToInt32(Button.Static_Box_Shadow_Inset_Offset_X.Replace("px", string.Empty));
					int Static_Box_Shadow_Inset_Offset_Y = Convert.ToInt32(Button.Static_Box_Shadow_Inset_Offset_Y.Replace("px", string.Empty));
					int Static_Box_Shadow_Inset_Blur_Radius = Convert.ToInt32(Button.Static_Box_Shadow_Inset_Blur_Radius.Replace("px", string.Empty));
					int Static_Box_Shadow_Inset_Spread_Radius = Convert.ToInt32(Button.Static_Box_Shadow_Inset_Spread_Radius.Replace("px", string.Empty));

					if (Static_Box_Shadow_Inset_Offset_X > 0 || Static_Box_Shadow_Inset_Offset_Y > 0 || Static_Box_Shadow_Inset_Blur_Radius > 0 || Static_Box_Shadow_Inset_Spread_Radius > 0)
					{
						Button.Static_Box_Shadow_Inset_Enable = true;
					}
					else
					{
						Button.Static_Box_Shadow_Inset_Enable = false;
					}


					int Static_Text_Shadow_Offset_X = Convert.ToInt32(Button.Static_Text_Shadow_Offset_X.Replace("px", string.Empty));
					int Static_Text_Shadow_Offset_Y = Convert.ToInt32(Button.Static_Text_Shadow_Offset_Y.Replace("px", string.Empty));
					int Static_Text_Shadow_Blur_Radius= Convert.ToInt32(Button.Static_Text_Shadow_Blur_Radius.Replace("px", string.Empty));					

					if (Static_Text_Shadow_Offset_X > 0 || Static_Text_Shadow_Offset_Y > 0 || Static_Text_Shadow_Blur_Radius > 0)
					{
						Button.Static_Text_Shadow_Enable = true;
					}
					else
					{
						Button.Static_Text_Shadow_Enable = false;
					}

					//------------------------------------------------------HOVER------------------------------------------------------------

					int Hover_Box_Shadow_Offset_X = Convert.ToInt32(Button.Hover_Box_Shadow_Offset_X.Replace("px", string.Empty));
					int Hover_Box_Shadow_Offset_Y = Convert.ToInt32(Button.Hover_Box_Shadow_Offset_Y.Replace("px", string.Empty));
					int Hover_Box_Shadow_Blur_Radius = Convert.ToInt32(Button.Hover_Box_Shadow_Blur_Radius.Replace("px", string.Empty));
					int Hover_Box_Shadow_Spread_Radius = Convert.ToInt32(Button.Hover_Box_Shadow_Spread_Radius.Replace("px", string.Empty));

					if (Hover_Box_Shadow_Offset_X > 0 || Hover_Box_Shadow_Offset_Y > 0 || Hover_Box_Shadow_Blur_Radius > 0 || Hover_Box_Shadow_Spread_Radius > 0)
					{
						Button.Hover_Box_Shadow_Enable = true;
					}
					else
					{
						Button.Hover_Box_Shadow_Enable = false;
					}


					int Hover_Box_Shadow_Inset_Offset_X = Convert.ToInt32(Button.Hover_Box_Shadow_Inset_Offset_X.Replace("px", string.Empty));
					int Hover_Box_Shadow_Inset_Offset_Y = Convert.ToInt32(Button.Hover_Box_Shadow_Inset_Offset_Y.Replace("px", string.Empty));
					int Hover_Box_Shadow_Inset_Blur_Radius = Convert.ToInt32(Button.Hover_Box_Shadow_Inset_Blur_Radius.Replace("px", string.Empty));
					int Hover_Box_Shadow_Inset_Spread_Radius = Convert.ToInt32(Button.Hover_Box_Shadow_Inset_Spread_Radius.Replace("px", string.Empty));

					if (Hover_Box_Shadow_Inset_Offset_X > 0 || Hover_Box_Shadow_Inset_Offset_Y > 0 || Hover_Box_Shadow_Inset_Blur_Radius > 0 || Hover_Box_Shadow_Inset_Spread_Radius > 0)
					{
						Button.Hover_Box_Shadow_Inset_Enable = true;
					}
					else
					{
						Button.Hover_Box_Shadow_Inset_Enable = false;
					}

					int Hover_Text_Shadow_Offset_X = Convert.ToInt32(Button.Hover_Text_Shadow_Offset_X.Replace("px", string.Empty));
					int Hover_Text_Shadow_Offset_Y = Convert.ToInt32(Button.Hover_Text_Shadow_Offset_Y.Replace("px", string.Empty));
					int Hover_Text_Shadow_Blur_Radius = Convert.ToInt32(Button.Hover_Text_Shadow_Blur_Radius.Replace("px", string.Empty));

					if (Hover_Text_Shadow_Offset_X > 0 || Hover_Text_Shadow_Offset_Y > 0 || Hover_Text_Shadow_Blur_Radius > 0)
					{
						Button.Hover_Text_Shadow_Enable = true;
					}
					else
					{
						Button.Hover_Text_Shadow_Enable = false;
					}

				}						
					
			}
			catch (Exception ex)
			{
				throw ex;
			}


			return Button;
		}
	}
}