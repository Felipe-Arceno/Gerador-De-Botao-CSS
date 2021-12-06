using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gerador_CSS.Class;
using Gerador_CSS.Models;

namespace Gerador_CSS.Class
{
    public class Button
    {
        public static List<ButtonModel> GetAllButtons()
        {
			string button_default_id = Class.Util.GetParam_Button_Default();
						
            string StrConn = ConfigurationManager.AppSettings.Get("SqlServerConn").ToString();

            List<ButtonModel> List_Buttons = new List<ButtonModel>();

            ConnectionSQLServer conexao = new ConnectionSQLServer(StrConn);

            #region SQL

            string sql = $@"SELECT	Button_Id,								
									Static_Border_Top_Width,
									Static_Border_Bottom_Width,
									Static_Border_Left_Width,
									Static_Border_Right_Width,
									Static_Border_Top_Style,
									Static_Border_Bottom_Style,
									Static_Border_Left_Style,
									Static_Border_Right_Style,
									Static_Border_Top_Color,
									Static_Border_Bottom_Color,
									Static_Border_Left_Color,
									Static_Border_Right_Color,
									Static_Top_Left_Radius,
									Static_Top_Right_Radius,
									Static_Bottom_Left_Radius,
									Static_Bottom_Right_Radius,
									Static_Padding_Top,
									Static_Padding_Bottom,
									Static_Padding_Left,
									Static_Padding_Right,
									Static_Font_Size,
									Static_Font_Style,
									Static_Font_Weight,									
									Static_Background_Color,
									Static_Color,												
									Static_Box_Shadow_Offset_X,
									Static_Box_Shadow_Offset_Y,
									Static_Box_Shadow_Blur_Radius,
									Static_Box_Shadow_Spread_Radius,
									Static_Box_Shadow_Color,
									Static_Box_Shadow_Inset_Offset_X,
									Static_Box_Shadow_Inset_Offset_Y,
									Static_Box_Shadow_Inset_Blur_Radius,
									Static_Box_Shadow_Inset_Spread_Radius,
									Static_Box_Shadow_Inset_Color,
									Static_Text_Shadow_Offset_X,
									Static_Text_Shadow_Offset_Y,
									Static_Text_Shadow_Blur_Radius,									
									Static_Text_Shadow_Color,
									Static_Animation,
									Static_Animation_Type,
									Hover_Border_Top_Width,
									Hover_Border_Bottom_Width,
									Hover_Border_Left_Width,
									Hover_Border_Right_Width,
									Hover_Border_Top_Style,
									Hover_Border_Bottom_Style,
									Hover_Border_Left_Style,
									Hover_Border_Right_Style,
									Hover_Border_Top_Color,
									Hover_Border_Bottom_Color,
									Hover_Border_Left_Color,
									Hover_Border_Right_Color,
									Hover_Top_Left_Radius,
									Hover_Top_Right_Radius,
									Hover_Bottom_Left_Radius,
									Hover_Bottom_Right_Radius,
									Hover_Padding_Top,
									Hover_Padding_Bottom,
									Hover_Padding_Left,
									Hover_Padding_Right,
									Hover_Font_Size,
									Hover_Font_Style,
									Hover_Font_Weight,
									Hover_Color,
									Hover_Text_Shadow_Offset_X,
									Hover_Text_Shadow_Offset_Y,
									Hover_Text_Shadow_Blur_Radius,									
									Hover_Text_Shadow_Color,
									Hover_Background_Color,
									Hover_Box_Shadow_Offset_X,
									Hover_Box_Shadow_Offset_Y,
									Hover_Box_Shadow_Blur_Radius,
									Hover_Box_Shadow_Spread_Radius,
									Hover_Box_Shadow_Color,
									Hover_Box_Shadow_Inset_Offset_X,
									Hover_Box_Shadow_Inset_Offset_Y,
									Hover_Box_Shadow_Inset_Blur_Radius,
									Hover_Box_Shadow_Inset_Spread_Radius,
									Hover_Box_Shadow_Inset_Color,
									Hover_Animation,
									Hover_Animation_Type
									FROM 
									dbo.Button_Properties";

				if (!string.IsNullOrEmpty(button_default_id))
				{
					sql += $@" WHERE Button_Id != '{button_default_id}'";
				}
            #endregion


            try
            {
				DataTable table = conexao.FillDataTable(sql);

				foreach (DataRow row in table.Rows)
				{
					ButtonModel Button = new ButtonModel();

					#region ------------------STATIC PARAMETERS-----------------

					Button.Button_id = Convert.ToInt32(row["Button_Id"]);
					Button.Static_Border_Top_Width = row["Static_Border_Top_Width"].ToString().ToLower();
					Button.Static_Border_Bottom_Width = row["Static_Border_Bottom_Width"].ToString().ToLower();
					Button.Static_Border_Left_Width = row["Static_Border_Left_Width"].ToString().ToLower();
					Button.Static_Border_Right_Width = row["Static_Border_Right_Width"].ToString().ToLower();
					Button.Static_Border_Top_Style = row["Static_Border_Top_Style"].ToString().ToLower();
					Button.Static_Border_Bottom_Style = row["Static_Border_Bottom_Style"].ToString().ToLower();
					Button.Static_Border_Left_Style = row["Static_Border_Left_Style"].ToString().ToLower();
					Button.Static_Border_Right_Style = row["Static_Border_Right_Style"].ToString().ToLower();
					Button.Static_Border_Top_Color = row["Static_Border_Top_Color"].ToString().ToLower();
					Button.Static_Border_Bottom_Color = row["Static_Border_Bottom_Color"].ToString().ToLower();
					Button.Static_Border_Left_Color = row["Static_Border_Left_Color"].ToString().ToLower();
					Button.Static_Border_Right_Color = row["Static_Border_Right_Color"].ToString().ToLower();
					Button.Static_Border_Top_Left_Radius = row["Static_Top_Left_Radius"].ToString().ToLower();
					Button.Static_Border_Top_Right_Radius = row["Static_Top_Right_Radius"].ToString().ToLower();
					Button.Static_Border_Bottom_Left_Radius = row["Static_Bottom_Left_Radius"].ToString().ToLower();
					Button.Static_Border_Bottom_Right_Radius = row["Static_Bottom_Right_Radius"].ToString().ToLower();
					Button.Static_Padding_Top = row["Static_Padding_Top"].ToString().ToLower();
					Button.Static_Padding_Bottom = row["Static_Padding_Bottom"].ToString().ToLower();
					Button.Static_Padding_Left = row["Static_Padding_Left"].ToString().ToLower();
					Button.Static_Padding_Right = row["Static_Padding_Right"].ToString().ToLower();
					Button.Static_Font_Size = row["Static_Font_Size"].ToString().ToLower();
					Button.Static_Font_Style = row["Static_Font_Style"].ToString().ToLower();
					Button.Static_Font_Weight = row["Static_Font_Weight"].ToString().ToLower();
					Button.Static_Background_Color = row["Static_Background_Color"].ToString().ToLower();
					Button.Static_Color = row["Static_Color"].ToString().ToLower();					
					Button.Static_Box_Shadow_Offset_X = row["Static_Box_Shadow_Offset_X"].ToString().ToLower();
					Button.Static_Box_Shadow_Offset_Y = row["Static_Box_Shadow_Offset_Y"].ToString().ToLower();
					Button.Static_Box_Shadow_Blur_Radius = row["Static_Box_Shadow_Blur_Radius"].ToString().ToLower();
					Button.Static_Box_Shadow_Spread_Radius = row["Static_Box_Shadow_Spread_Radius"].ToString().ToLower();
					Button.Static_Box_Shadow_Color = row["Static_Box_Shadow_Color"].ToString().ToLower();
					Button.Static_Box_Shadow_Inset_Offset_X = row["Static_Box_Shadow_Inset_Offset_X"].ToString().ToLower();
					Button.Static_Box_Shadow_Inset_Offset_Y = row["Static_Box_Shadow_Inset_Offset_Y"].ToString().ToLower();
					Button.Static_Box_Shadow_Inset_Blur_Radius = row["Static_Box_Shadow_Inset_Blur_Radius"].ToString().ToLower();
					Button.Static_Box_Shadow_Inset_Spread_Radius = row["Static_Box_Shadow_Inset_Spread_Radius"].ToString().ToLower();
					Button.Static_Box_Shadow_Inset_Color = row["Static_Box_Shadow_Inset_Color"].ToString().ToLower();
					Button.Static_Text_Shadow_Offset_X = row["Static_Text_Shadow_Offset_X"].ToString().ToLower();
					Button.Static_Text_Shadow_Offset_Y = row["Static_Text_Shadow_Offset_Y"].ToString().ToLower();
					Button.Static_Text_Shadow_Blur_Radius = row["Static_Text_Shadow_Blur_Radius"].ToString().ToLower();					
					Button.Static_Text_Shadow_Color = row["Static_Text_Shadow_Color"].ToString().ToLower();
					Button.Static_Animation = row["Static_Animation"].ToString().ToLower();
					Button.Static_Animation_Type = row["Static_Animation_Type"].ToString().ToLower();

					#endregion

					#region ------------------HOVER PARAMETERS------------------

					//HOVER
					Button.Hover_Border_Top_Width = row["Hover_Border_Top_Width"].ToString().ToLower();
					Button.Hover_Border_Bottom_Width = row["Hover_Border_Bottom_Width"].ToString().ToLower();
					Button.Hover_Border_Left_Width = row["Hover_Border_Left_Width"].ToString().ToLower();
					Button.Hover_Border_Right_Width = row["Hover_Border_Right_Width"].ToString().ToLower();
					Button.Hover_Border_Top_Style = row["Hover_Border_Top_Style"].ToString().ToLower();
					Button.Hover_Border_Bottom_Style = row["Hover_Border_Bottom_Style"].ToString().ToLower();
					Button.Hover_Border_Left_Style = row["Hover_Border_Left_Style"].ToString().ToLower();
					Button.Hover_Border_Right_Style = row["Hover_Border_Right_Style"].ToString().ToLower();
					Button.Hover_Border_Top_Color = row["Hover_Border_Top_Color"].ToString().ToLower();
					Button.Hover_Border_Bottom_Color = row["Hover_Border_Bottom_Color"].ToString().ToLower();
					Button.Hover_Border_Left_Color = row["Hover_Border_Left_Color"].ToString().ToLower();
					Button.Hover_Border_Right_Color = row["Hover_Border_Right_Color"].ToString().ToLower();
					Button.Hover_Border_Top_Left_Radius = row["Hover_Top_Left_Radius"].ToString().ToLower();
					Button.Hover_Border_Top_Right_Radius = row["Hover_Top_Right_Radius"].ToString().ToLower();
					Button.Hover_Border_Bottom_Left_Radius = row["Hover_Bottom_Left_Radius"].ToString().ToLower();
					Button.Hover_Border_Bottom_Right_Radius = row["Hover_Bottom_Right_Radius"].ToString().ToLower();
					Button.Hover_Padding_Top = row["Hover_Padding_Top"].ToString().ToLower();
					Button.Hover_Padding_Bottom = row["Hover_Padding_Bottom"].ToString().ToLower();
					Button.Hover_Padding_Left = row["Hover_Padding_Left"].ToString().ToLower();
					Button.Hover_Padding_Right = row["Hover_Padding_Right"].ToString().ToLower();
					Button.Hover_Font_Size = row["Hover_Font_Size"].ToString().ToLower();
					Button.Hover_Font_Style = row["Hover_Font_Style"].ToString().ToLower();
					Button.Hover_Font_Weight = row["Hover_Font_Weight"].ToString().ToLower();
					Button.Hover_Color = row["Hover_Color"].ToString().ToLower();
					Button.Hover_Background_Color = row["Hover_Background_Color"].ToString().ToLower();
					Button.Hover_Box_Shadow_Offset_X = row["Hover_Box_Shadow_Offset_X"].ToString().ToLower();
					Button.Hover_Box_Shadow_Offset_Y = row["Hover_Box_Shadow_Offset_Y"].ToString().ToLower();
					Button.Hover_Box_Shadow_Blur_Radius = row["Hover_Box_Shadow_Blur_Radius"].ToString().ToLower();
					Button.Hover_Box_Shadow_Spread_Radius = row["Hover_Box_Shadow_Spread_Radius"].ToString().ToLower();
					Button.Hover_Box_Shadow_Color = row["Hover_Box_Shadow_Color"].ToString().ToLower();
					Button.Hover_Box_Shadow_Inset_Offset_X = row["Hover_Box_Shadow_Inset_Offset_X"].ToString().ToLower();
					Button.Hover_Box_Shadow_Inset_Offset_Y = row["Hover_Box_Shadow_Inset_Offset_Y"].ToString().ToLower();
					Button.Hover_Box_Shadow_Inset_Blur_Radius = row["Hover_Box_Shadow_Inset_Blur_Radius"].ToString().ToLower();
					Button.Hover_Box_Shadow_Inset_Spread_Radius = row["Hover_Box_Shadow_Inset_Spread_Radius"].ToString().ToLower();
					Button.Hover_Box_Shadow_Inset_Color = row["Hover_Box_Shadow_Inset_Color"].ToString().ToLower();
					Button.Hover_Text_Shadow_Offset_X = row["Hover_Text_Shadow_Offset_X"].ToString().ToLower();
					Button.Hover_Text_Shadow_Offset_Y = row["Hover_Text_Shadow_Offset_Y"].ToString().ToLower();
					Button.Hover_Text_Shadow_Blur_Radius = row["Hover_Text_Shadow_Blur_Radius"].ToString().ToLower();
					Button.Hover_Text_Shadow_Color = row["Hover_Text_Shadow_Color"].ToString().ToLower();
					Button.Hover_Animation = row["Hover_Animation"].ToString().ToLower();
					Button.Hover_Animation_Type = row["Hover_Animation_Type"].ToString().ToLower();

					#endregion

					List_Buttons.Add(Button);
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}


            return List_Buttons;
        }

		public static Models.ButtonModel GetButtonById(string idButton)
		{
						
			string StrConn = ConfigurationManager.AppSettings.Get("SqlServerConn").ToString();

			ButtonModel Button = new ButtonModel();

			ConnectionSQLServer conexao = new ConnectionSQLServer(StrConn);

            #region SQL

            string sql = $@"SELECT	Button_Id,								
									Static_Border_Top_Width,
									Static_Border_Bottom_Width,
									Static_Border_Left_Width,
									Static_Border_Right_Width,
									Static_Border_Top_Style,
									Static_Border_Bottom_Style,
									Static_Border_Left_Style,
									Static_Border_Right_Style,
									Static_Border_Top_Color,
									Static_Border_Bottom_Color,
									Static_Border_Left_Color,
									Static_Border_Right_Color,
									Static_Top_Left_Radius,
									Static_Top_Right_Radius,
									Static_Bottom_Left_Radius,
									Static_Bottom_Right_Radius,
									Static_Padding_Top,
									Static_Padding_Bottom,
									Static_Padding_Left,
									Static_Padding_Right,
									Static_Font_Size,
									Static_Font_Style,
									Static_Font_Weight,									
									Static_Background_Color,
									Static_Color,												
									Static_Box_Shadow_Offset_X,
									Static_Box_Shadow_Offset_Y,
									Static_Box_Shadow_Blur_Radius,
									Static_Box_Shadow_Spread_Radius,
									Static_Box_Shadow_Color,
									Static_Box_Shadow_Inset_Offset_X,
									Static_Box_Shadow_Inset_Offset_Y,
									Static_Box_Shadow_Inset_Blur_Radius,
									Static_Box_Shadow_Inset_Spread_Radius,
									Static_Box_Shadow_Inset_Color,
									Static_Text_Shadow_Offset_X,
									Static_Text_Shadow_Offset_Y,
									Static_Text_Shadow_Blur_Radius,									
									Static_Text_Shadow_Color,
									Static_Animation,
									Static_Animation_Type,
									Hover_Border_Top_Width,
									Hover_Border_Bottom_Width,
									Hover_Border_Left_Width,
									Hover_Border_Right_Width,
									Hover_Border_Top_Style,
									Hover_Border_Bottom_Style,
									Hover_Border_Left_Style,
									Hover_Border_Right_Style,
									Hover_Border_Top_Color,
									Hover_Border_Bottom_Color,
									Hover_Border_Left_Color,
									Hover_Border_Right_Color,
									Hover_Top_Left_Radius,
									Hover_Top_Right_Radius,
									Hover_Bottom_Left_Radius,
									Hover_Bottom_Right_Radius,
									Hover_Padding_Top,
									Hover_Padding_Bottom,
									Hover_Padding_Left,
									Hover_Padding_Right,
									Hover_Font_Size,
									Hover_Font_Style,
									Hover_Font_Weight,
									Hover_Color,
									Hover_Text_Shadow_Offset_X,
									Hover_Text_Shadow_Offset_Y,
									Hover_Text_Shadow_Blur_Radius,									
									Hover_Text_Shadow_Color,
									Hover_Background_Color,
									Hover_Box_Shadow_Offset_X,
									Hover_Box_Shadow_Offset_Y,
									Hover_Box_Shadow_Blur_Radius,
									Hover_Box_Shadow_Spread_Radius,
									Hover_Box_Shadow_Color,
									Hover_Box_Shadow_Inset_Offset_X,
									Hover_Box_Shadow_Inset_Offset_Y,
									Hover_Box_Shadow_Inset_Blur_Radius,
									Hover_Box_Shadow_Inset_Spread_Radius,
									Hover_Box_Shadow_Inset_Color,
									Hover_Animation,
									Hover_Animation_Type
									FROM 
									dbo.Button_Properties
									
								WHERE 
									Button_Id = '{idButton}'";

            #endregion

            try
            {
				DataTable table = conexao.FillDataTable(sql);

				if(table.Rows.Count > 0)
                {

					#region ------------------STATIC PARAMETERS-----------------

					Button.Button_id = Convert.ToInt32(table.Rows[0]["Button_Id"]);
					Button.Static_Border_Top_Width = table.Rows[0]["Static_Border_Top_Width"].ToString().ToLower();
					Button.Static_Border_Bottom_Width = table.Rows[0]["Static_Border_Bottom_Width"].ToString().ToLower();
					Button.Static_Border_Left_Width = table.Rows[0]["Static_Border_Left_Width"].ToString().ToLower();
					Button.Static_Border_Right_Width = table.Rows[0]["Static_Border_Right_Width"].ToString().ToLower();
					Button.Static_Border_Top_Style = table.Rows[0]["Static_Border_Top_Style"].ToString().ToLower();
					Button.Static_Border_Bottom_Style = table.Rows[0]["Static_Border_Bottom_Style"].ToString().ToLower();
					Button.Static_Border_Left_Style = table.Rows[0]["Static_Border_Left_Style"].ToString().ToLower();
					Button.Static_Border_Right_Style = table.Rows[0]["Static_Border_Right_Style"].ToString().ToLower();
					Button.Static_Border_Top_Color = table.Rows[0]["Static_Border_Top_Color"].ToString().ToLower();
					Button.Static_Border_Bottom_Color = table.Rows[0]["Static_Border_Bottom_Color"].ToString().ToLower();
					Button.Static_Border_Left_Color = table.Rows[0]["Static_Border_Left_Color"].ToString().ToLower();
					Button.Static_Border_Right_Color = table.Rows[0]["Static_Border_Right_Color"].ToString().ToLower();
					Button.Static_Border_Top_Left_Radius = table.Rows[0]["Static_Top_Left_Radius"].ToString().ToLower();
					Button.Static_Border_Top_Right_Radius = table.Rows[0]["Static_Top_Right_Radius"].ToString().ToLower();
					Button.Static_Border_Bottom_Left_Radius = table.Rows[0]["Static_Bottom_Left_Radius"].ToString().ToLower();
					Button.Static_Border_Bottom_Right_Radius = table.Rows[0]["Static_Bottom_Right_Radius"].ToString().ToLower();
					Button.Static_Padding_Top = table.Rows[0]["Static_Padding_Top"].ToString().ToLower();
					Button.Static_Padding_Bottom = table.Rows[0]["Static_Padding_Bottom"].ToString().ToLower();
					Button.Static_Padding_Left = table.Rows[0]["Static_Padding_Left"].ToString().ToLower();
					Button.Static_Padding_Right = table.Rows[0]["Static_Padding_Right"].ToString().ToLower();
					Button.Static_Font_Size = table.Rows[0]["Static_Font_Size"].ToString().ToLower();
					Button.Static_Font_Style = table.Rows[0]["Static_Font_Style"].ToString().ToLower();
					Button.Static_Font_Weight = table.Rows[0]["Static_Font_Weight"].ToString().ToLower();
					Button.Static_Background_Color = table.Rows[0]["Static_Background_Color"].ToString().ToLower();
					Button.Static_Color = table.Rows[0]["Static_Color"].ToString().ToLower();
					Button.Static_Box_Shadow_Offset_X = table.Rows[0]["Static_Box_Shadow_Offset_X"].ToString().ToLower();
					Button.Static_Box_Shadow_Offset_Y = table.Rows[0]["Static_Box_Shadow_Offset_Y"].ToString().ToLower();
					Button.Static_Box_Shadow_Blur_Radius = table.Rows[0]["Static_Box_Shadow_Blur_Radius"].ToString().ToLower();
					Button.Static_Box_Shadow_Spread_Radius = table.Rows[0]["Static_Box_Shadow_Spread_Radius"].ToString().ToLower();
					Button.Static_Box_Shadow_Color = table.Rows[0]["Static_Box_Shadow_Color"].ToString().ToLower();					
					Button.Static_Box_Shadow_Inset_Offset_X = table.Rows[0]["Static_Box_Shadow_Inset_Offset_X"].ToString().ToLower();
					Button.Static_Box_Shadow_Inset_Offset_Y = table.Rows[0]["Static_Box_Shadow_Inset_Offset_Y"].ToString().ToLower();
					Button.Static_Box_Shadow_Inset_Blur_Radius = table.Rows[0]["Static_Box_Shadow_Inset_Blur_Radius"].ToString().ToLower();
					Button.Static_Box_Shadow_Inset_Spread_Radius = table.Rows[0]["Static_Box_Shadow_Inset_Spread_Radius"].ToString().ToLower();
					Button.Static_Box_Shadow_Inset_Color = table.Rows[0]["Static_Box_Shadow_Inset_Color"].ToString().ToLower();								
					Button.Static_Text_Shadow_Offset_X = table.Rows[0]["Static_Text_Shadow_Offset_X"].ToString().ToLower();
					Button.Static_Text_Shadow_Offset_Y = table.Rows[0]["Static_Text_Shadow_Offset_Y"].ToString().ToLower();
					Button.Static_Text_Shadow_Blur_Radius= table.Rows[0]["Static_Text_Shadow_Blur_Radius"].ToString().ToLower();
					Button.Static_Text_Shadow_Color = table.Rows[0]["Static_Text_Shadow_Color"].ToString().ToLower();
					Button.Static_Animation = table.Rows[0]["Static_Animation"].ToString().ToLower();
					Button.Static_Animation_Type = table.Rows[0]["Static_Animation_Type"].ToString().ToLower();

					#endregion

					#region ------------------HOVER PARAMETERS------------------
					//----------------------------------------- HOVER----------------------------------------------------
					Button.Hover_Border_Top_Width = table.Rows[0]["Hover_Border_Top_Width"].ToString().ToLower();
					Button.Hover_Border_Bottom_Width = table.Rows[0]["Hover_Border_Bottom_Width"].ToString().ToLower();
					Button.Hover_Border_Left_Width = table.Rows[0]["Hover_Border_Left_Width"].ToString().ToLower();
					Button.Hover_Border_Right_Width = table.Rows[0]["Hover_Border_Right_Width"].ToString().ToLower();
					Button.Hover_Border_Top_Style = table.Rows[0]["Hover_Border_Top_Style"].ToString().ToLower();
					Button.Hover_Border_Bottom_Style = table.Rows[0]["Hover_Border_Bottom_Style"].ToString().ToLower();
					Button.Hover_Border_Left_Style = table.Rows[0]["Hover_Border_Left_Style"].ToString().ToLower();
					Button.Hover_Border_Right_Style = table.Rows[0]["Hover_Border_Right_Style"].ToString().ToLower();
					Button.Hover_Border_Top_Color = table.Rows[0]["Hover_Border_Top_Color"].ToString().ToLower();
					Button.Hover_Border_Bottom_Color = table.Rows[0]["Hover_Border_Bottom_Color"].ToString().ToLower();
					Button.Hover_Border_Left_Color = table.Rows[0]["Hover_Border_Left_Color"].ToString().ToLower();
					Button.Hover_Border_Right_Color = table.Rows[0]["Hover_Border_Right_Color"].ToString().ToLower();
					Button.Hover_Border_Top_Left_Radius = table.Rows[0]["Hover_Top_Left_Radius"].ToString().ToLower();
					Button.Hover_Border_Top_Right_Radius = table.Rows[0]["Hover_Top_Right_Radius"].ToString().ToLower();
					Button.Hover_Border_Bottom_Left_Radius = table.Rows[0]["Hover_Bottom_Left_Radius"].ToString().ToLower();
					Button.Hover_Border_Bottom_Right_Radius = table.Rows[0]["Hover_Bottom_Right_Radius"].ToString().ToLower();
					Button.Hover_Padding_Top = table.Rows[0]["Hover_Padding_Top"].ToString().ToLower();
					Button.Hover_Padding_Bottom = table.Rows[0]["Hover_Padding_Bottom"].ToString().ToLower();
					Button.Hover_Padding_Left = table.Rows[0]["Hover_Padding_Left"].ToString().ToLower();
					Button.Hover_Padding_Right = table.Rows[0]["Hover_Padding_Right"].ToString().ToLower();
					Button.Hover_Font_Size = table.Rows[0]["Hover_Font_Size"].ToString().ToLower();
					Button.Hover_Font_Style = table.Rows[0]["Hover_Font_Style"].ToString().ToLower();
					Button.Hover_Font_Weight = table.Rows[0]["Hover_Font_Weight"].ToString().ToLower();
					Button.Hover_Color = table.Rows[0]["Hover_Color"].ToString().ToLower();
					Button.Hover_Background_Color = table.Rows[0]["Hover_Background_Color"].ToString().ToLower();					
					Button.Hover_Box_Shadow_Offset_X = table.Rows[0]["Hover_Box_Shadow_Offset_X"].ToString().ToLower();
					Button.Hover_Box_Shadow_Offset_Y = table.Rows[0]["Hover_Box_Shadow_Offset_Y"].ToString().ToLower();
					Button.Hover_Box_Shadow_Blur_Radius = table.Rows[0]["Hover_Box_Shadow_Blur_Radius"].ToString().ToLower();
					Button.Hover_Box_Shadow_Spread_Radius = table.Rows[0]["Hover_Box_Shadow_Spread_Radius"].ToString().ToLower();
					Button.Hover_Box_Shadow_Color = table.Rows[0]["Hover_Box_Shadow_Color"].ToString().ToLower();
					Button.Hover_Box_Shadow_Inset_Offset_X = table.Rows[0]["Hover_Box_Shadow_Inset_Offset_X"].ToString().ToLower();
					Button.Hover_Box_Shadow_Inset_Offset_Y = table.Rows[0]["Hover_Box_Shadow_Inset_Offset_Y"].ToString().ToLower();
					Button.Hover_Box_Shadow_Inset_Blur_Radius = table.Rows[0]["Hover_Box_Shadow_Inset_Blur_Radius"].ToString().ToLower();
					Button.Hover_Box_Shadow_Inset_Spread_Radius = table.Rows[0]["Hover_Box_Shadow_Inset_Spread_Radius"].ToString().ToLower();
					Button.Hover_Box_Shadow_Inset_Color = table.Rows[0]["Hover_Box_Shadow_Inset_Color"].ToString().ToLower();					
					Button.Hover_Text_Shadow_Offset_X = table.Rows[0]["Hover_Text_Shadow_Offset_X"].ToString().ToLower();
					Button.Hover_Text_Shadow_Offset_Y = table.Rows[0]["Hover_Text_Shadow_Offset_Y"].ToString().ToLower();
					Button.Hover_Text_Shadow_Blur_Radius = table.Rows[0]["Hover_Text_Shadow_Blur_Radius"].ToString().ToLower();
					Button.Hover_Text_Shadow_Color = table.Rows[0]["Hover_Text_Shadow_Color"].ToString().ToLower();
					Button.Hover_Animation = table.Rows[0]["Hover_Animation"].ToString().ToLower();
					Button.Hover_Animation_Type = table.Rows[0]["Hover_Animation_Type"].ToString().ToLower();

					#endregion

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

		public static void InsertButtonToSuggestionBox(ButtonModel button)
        {
			string StrConn = ConfigurationManager.AppSettings.Get("SqlServerConn").ToString();

			ConnectionSQLServer conexao = new ConnectionSQLServer(StrConn);

			conexao.BeginTransaction();

			try
            {

                #region SQL

                string sql = @"INSERT INTO dbo.Button_Properties	(							
									Static_Border_Top_Width,
									Static_Border_Bottom_Width,
									Static_Border_Left_Width,
									Static_Border_Right_Width,
									Static_Border_Top_Style,
									Static_Border_Bottom_Style,
									Static_Border_Left_Style,
									Static_Border_Right_Style,
									Static_Border_Top_Color,
									Static_Border_Bottom_Color,
									Static_Border_Left_Color,
									Static_Border_Right_Color,
									Static_Top_Left_Radius,
									Static_Top_Right_Radius,
									Static_Bottom_Left_Radius,
									Static_Bottom_Right_Radius,
									Static_Padding_Top,
									Static_Padding_Bottom,
									Static_Padding_Left,
									Static_Padding_Right,
									Static_Font_Size,
									Static_Font_Style,
									Static_Font_Weight,									
									Static_Background_Color,
									Static_Color,												
									Static_Box_Shadow_Offset_X,
									Static_Box_Shadow_Offset_Y,
									Static_Box_Shadow_Blur_Radius,
									Static_Box_Shadow_Spread_Radius,
									Static_Box_Shadow_Color,
									Static_Box_Shadow_Inset_Offset_X,
									Static_Box_Shadow_Inset_Offset_Y,
									Static_Box_Shadow_Inset_Blur_Radius,
									Static_Box_Shadow_Inset_Spread_Radius,
									Static_Box_Shadow_Inset_Color,
									Static_Text_Shadow_Offset_X,
									Static_Text_Shadow_Offset_Y,
									Static_Text_Shadow_Blur_Radius,									
									Static_Text_Shadow_Color,
									Static_Animation,
									Static_Animation_Type,
									Hover_Border_Top_Width,
									Hover_Border_Bottom_Width,
									Hover_Border_Left_Width,
									Hover_Border_Right_Width,
									Hover_Border_Top_Style,
									Hover_Border_Bottom_Style,
									Hover_Border_Left_Style,
									Hover_Border_Right_Style,
									Hover_Border_Top_Color,
									Hover_Border_Bottom_Color,
									Hover_Border_Left_Color,
									Hover_Border_Right_Color,
									Hover_Top_Left_Radius,
									Hover_Top_Right_Radius,
									Hover_Bottom_Left_Radius,
									Hover_Bottom_Right_Radius,
									Hover_Padding_Top,
									Hover_Padding_Bottom,
									Hover_Padding_Left,
									Hover_Padding_Right,
									Hover_Font_Size,
									Hover_Font_Style,
									Hover_Font_Weight,
									Hover_Color,
									Hover_Text_Shadow_Offset_X,
									Hover_Text_Shadow_Offset_Y,
									Hover_Text_Shadow_Blur_Radius,									
									Hover_Text_Shadow_Color,
									Hover_Background_Color,
									Hover_Box_Shadow_Offset_X,
									Hover_Box_Shadow_Offset_Y,
									Hover_Box_Shadow_Blur_Radius,
									Hover_Box_Shadow_Spread_Radius,
									Hover_Box_Shadow_Color,
									Hover_Box_Shadow_Inset_Offset_X,
									Hover_Box_Shadow_Inset_Offset_Y,
									Hover_Box_Shadow_Inset_Blur_Radius,
									Hover_Box_Shadow_Inset_Spread_Radius,
									Hover_Box_Shadow_Inset_Color,
									Hover_Animation,
									Hover_Animation_Type)
									VALUES(																	
									@Static_Border_Top_Width,
									@Static_Border_Bottom_Width,
									@Static_Border_Left_Width,
									@Static_Border_Right_Width,
									@Static_Border_Top_Style,
									@Static_Border_Bottom_Style,
									@Static_Border_Left_Style,
									@Static_Border_Right_Style,
									@Static_Border_Top_Color,
									@Static_Border_Bottom_Color,
									@Static_Border_Left_Color,
									@Static_Border_Right_Color,
									@Static_Top_Left_Radius,
									@Static_Top_Right_Radius,
									@Static_Bottom_Left_Radius,
									@Static_Bottom_Right_Radius,
									@Static_Padding_Top,
									@Static_Padding_Bottom,
									@Static_Padding_Left,
									@Static_Padding_Right,
									@Static_Font_Size,
									@Static_Font_Style,
									@Static_Font_Weight,									
									@Static_Background_Color,
									@Static_Color,												
									@Static_Box_Shadow_Offset_X,
									@Static_Box_Shadow_Offset_Y,
									@Static_Box_Shadow_Blur_Radius,
									@Static_Box_Shadow_Spread_Radius,
									@Static_Box_Shadow_Color,
									@Static_Box_Shadow_Inset_Offset_X,
									@Static_Box_Shadow_Inset_Offset_Y,
									@Static_Box_Shadow_Inset_Blur_Radius,
									@Static_Box_Shadow_Inset_Spread_Radius,
									@Static_Box_Shadow_Inset_Color,
									@Static_Text_Shadow_Offset_X,
									@Static_Text_Shadow_Offset_Y,
									@Static_Text_Shadow_Blur_Radius,									
									@Static_Text_Shadow_Color,
									@Static_Animation,
									@Static_Animation_Type,
									@Hover_Border_Top_Width,
									@Hover_Border_Bottom_Width,
									@Hover_Border_Left_Width,
									@Hover_Border_Right_Width,
									@Hover_Border_Top_Style,
									@Hover_Border_Bottom_Style,
									@Hover_Border_Left_Style,
									@Hover_Border_Right_Style,
									@Hover_Border_Top_Color,
									@Hover_Border_Bottom_Color,
									@Hover_Border_Left_Color,
									@Hover_Border_Right_Color,
									@Hover_Top_Left_Radius,
									@Hover_Top_Right_Radius,
									@Hover_Bottom_Left_Radius,
									@Hover_Bottom_Right_Radius,
									@Hover_Padding_Top,
									@Hover_Padding_Bottom,
									@Hover_Padding_Left,
									@Hover_Padding_Right,
									@Hover_Font_Size,
									@Hover_Font_Style,
									@Hover_Font_Weight,
									@Hover_Color,
									@Hover_Text_Shadow_Offset_X,
									@Hover_Text_Shadow_Offset_Y,
									@Hover_Text_Shadow_Blur_Radius,									
									@Hover_Text_Shadow_Color,
									@Hover_Background_Color,
									@Hover_Box_Shadow_Offset_X,
									@Hover_Box_Shadow_Offset_Y,
									@Hover_Box_Shadow_Blur_Radius,
									@Hover_Box_Shadow_Spread_Radius,
									@Hover_Box_Shadow_Color,
									@Hover_Box_Shadow_Inset_Offset_X,
									@Hover_Box_Shadow_Inset_Offset_Y,
									@Hover_Box_Shadow_Inset_Blur_Radius,
									@Hover_Box_Shadow_Inset_Spread_Radius,
									@Hover_Box_Shadow_Inset_Color,
									@Hover_Animation,
									@Hover_Animation_Type)";

                #endregion

                conexao.StartCommandTransaction(sql);

				#region ------------------STATIC PARAMETERS-----------------

				conexao.mCommand.Parameters.AddWithValue("Static_Border_Top_Width", button.Static_Border_Top_Width + "px");
				conexao.mCommand.Parameters.AddWithValue("Static_Border_Bottom_Width", button.Static_Border_Bottom_Width + "px");
				conexao.mCommand.Parameters.AddWithValue("Static_Border_Left_Width", button.Static_Border_Left_Width + "px");
				conexao.mCommand.Parameters.AddWithValue("Static_Border_Right_Width", button.Static_Border_Right_Width + "px");
				conexao.mCommand.Parameters.AddWithValue("Static_Border_Top_Style", button.Static_Border_Top_Style.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Static_Border_Bottom_Style", button.Static_Border_Bottom_Style.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Static_Border_Left_Style", button.Static_Border_Left_Style.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Static_Border_Right_Style", button.Static_Border_Right_Style.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Static_Border_Top_Color", button.Static_Border_Top_Color.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Static_Border_Bottom_Color", button.Static_Border_Bottom_Color.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Static_Border_Left_Color", button.Static_Border_Left_Color.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Static_Border_Right_Color", button.Static_Border_Right_Color.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Static_Top_Left_Radius", button.Static_Border_Top_Left_Radius + "px");
				conexao.mCommand.Parameters.AddWithValue("Static_Top_Right_Radius", button.Static_Border_Top_Right_Radius + "px");
				conexao.mCommand.Parameters.AddWithValue("Static_Bottom_Left_Radius", button.Static_Border_Bottom_Left_Radius + "px");
				conexao.mCommand.Parameters.AddWithValue("Static_Bottom_Right_Radius", button.Static_Border_Bottom_Right_Radius + "px");
				conexao.mCommand.Parameters.AddWithValue("Static_Padding_Top", button.Static_Padding_Top + "px");
				conexao.mCommand.Parameters.AddWithValue("Static_Padding_Bottom", button.Static_Padding_Bottom + "px");
				conexao.mCommand.Parameters.AddWithValue("Static_Padding_Left", button.Static_Padding_Left + "px");
				conexao.mCommand.Parameters.AddWithValue("Static_Padding_Right", button.Static_Padding_Right + "px");
				conexao.mCommand.Parameters.AddWithValue("Static_Font_Size", button.Static_Font_Size + "px");
				conexao.mCommand.Parameters.AddWithValue("Static_Font_Style", button.Static_Font_Style.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Static_Font_Weight", button.Static_Font_Weight);
				conexao.mCommand.Parameters.AddWithValue("Static_Background_Color", button.Static_Background_Color.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Static_Color", button.Static_Color.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Static_Box_Shadow_Offset_X", button.Static_Box_Shadow_Offset_X + "px");
				conexao.mCommand.Parameters.AddWithValue("Static_Box_Shadow_Offset_Y", button.Static_Box_Shadow_Offset_Y + "px");
				conexao.mCommand.Parameters.AddWithValue("Static_Box_Shadow_Blur_Radius", button.Static_Box_Shadow_Blur_Radius + "px");
				conexao.mCommand.Parameters.AddWithValue("Static_Box_Shadow_Spread_Radius", button.Static_Box_Shadow_Spread_Radius + "px");
				conexao.mCommand.Parameters.AddWithValue("Static_Box_Shadow_Color", button.Static_Box_Shadow_Color.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Static_Box_Shadow_Inset_Offset_X", button.Static_Box_Shadow_Inset_Offset_X + "px");
				conexao.mCommand.Parameters.AddWithValue("Static_Box_Shadow_Inset_Offset_Y", button.Static_Box_Shadow_Inset_Offset_Y + "px");
				conexao.mCommand.Parameters.AddWithValue("Static_Box_Shadow_Inset_Blur_Radius", button.Static_Box_Shadow_Inset_Blur_Radius + "px");
				conexao.mCommand.Parameters.AddWithValue("Static_Box_Shadow_Inset_Spread_Radius", button.Static_Box_Shadow_Inset_Spread_Radius + "px");
				conexao.mCommand.Parameters.AddWithValue("Static_Box_Shadow_Inset_Color", button.Static_Box_Shadow_Inset_Color.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Static_Text_Shadow_Offset_X", button.Static_Text_Shadow_Offset_X + "px");
				conexao.mCommand.Parameters.AddWithValue("Static_Text_Shadow_Offset_Y", button.Static_Text_Shadow_Offset_Y + "px");
				conexao.mCommand.Parameters.AddWithValue("Static_Text_Shadow_Blur_Radius", button.Static_Text_Shadow_Blur_Radius + "px");
				conexao.mCommand.Parameters.AddWithValue("Static_Text_Shadow_Color", button.Static_Text_Shadow_Color.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Static_Animation", button.Static_Animation.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Static_Animation_Type", button.Static_Animation_Type.ToLower());

				#endregion

				#region ------------------HOVER PARAMETERS------------------

				//-------------------------------HOVER-----------------------------
				conexao.mCommand.Parameters.AddWithValue("Hover_Border_Top_Width", button.Hover_Border_Top_Width + "px");
				conexao.mCommand.Parameters.AddWithValue("Hover_Border_Bottom_Width", button.Hover_Border_Bottom_Width + "px");
				conexao.mCommand.Parameters.AddWithValue("Hover_Border_Left_Width", button.Hover_Border_Left_Width + "px");
				conexao.mCommand.Parameters.AddWithValue("Hover_Border_Right_Width", button.Hover_Border_Right_Width + "px");
				conexao.mCommand.Parameters.AddWithValue("Hover_Border_Top_Style", button.Hover_Border_Top_Style.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Hover_Border_Bottom_Style", button.Hover_Border_Bottom_Style.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Hover_Border_Left_Style", button.Hover_Border_Left_Style.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Hover_Border_Right_Style", button.Hover_Border_Right_Style.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Hover_Border_Top_Color", button.Hover_Border_Top_Color.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Hover_Border_Bottom_Color", button.Hover_Border_Bottom_Color.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Hover_Border_Left_Color", button.Hover_Border_Left_Color.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Hover_Border_Right_Color", button.Hover_Border_Right_Color.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Hover_Top_Left_Radius", button.Hover_Border_Top_Left_Radius + "px");
				conexao.mCommand.Parameters.AddWithValue("Hover_Top_Right_Radius", button.Hover_Border_Top_Right_Radius + "px");
				conexao.mCommand.Parameters.AddWithValue("Hover_Bottom_Left_Radius", button.Hover_Border_Bottom_Left_Radius + "px");
				conexao.mCommand.Parameters.AddWithValue("Hover_Bottom_Right_Radius", button.Hover_Border_Bottom_Right_Radius + "px");
				conexao.mCommand.Parameters.AddWithValue("Hover_Padding_Top", button.Hover_Padding_Top + "px");
				conexao.mCommand.Parameters.AddWithValue("Hover_Padding_Bottom", button.Hover_Padding_Bottom + "px");
				conexao.mCommand.Parameters.AddWithValue("Hover_Padding_Left", button.Hover_Padding_Left + "px");
				conexao.mCommand.Parameters.AddWithValue("Hover_Padding_Right", button.Hover_Padding_Right + "px");
				conexao.mCommand.Parameters.AddWithValue("Hover_Font_Size", button.Hover_Font_Size + "px");
				conexao.mCommand.Parameters.AddWithValue("Hover_Font_Style", button.Hover_Font_Style.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Hover_Font_Weight", button.Hover_Font_Weight);
				conexao.mCommand.Parameters.AddWithValue("Hover_Color", button.Hover_Color.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Hover_Text_Shadow_Offset_X", button.Hover_Text_Shadow_Offset_X + "px");
				conexao.mCommand.Parameters.AddWithValue("Hover_Text_Shadow_Offset_Y", button.Hover_Text_Shadow_Offset_Y + "px");
				conexao.mCommand.Parameters.AddWithValue("Hover_Text_Shadow_Blur_Radius", button.Hover_Text_Shadow_Blur_Radius + "px");
				conexao.mCommand.Parameters.AddWithValue("Hover_Text_Shadow_Color", button.Hover_Text_Shadow_Color.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Hover_Background_Color", button.Hover_Background_Color.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Hover_Box_Shadow_Offset_X", button.Hover_Box_Shadow_Offset_X + "px");
				conexao.mCommand.Parameters.AddWithValue("Hover_Box_Shadow_Offset_Y", button.Hover_Box_Shadow_Offset_Y + "px");
				conexao.mCommand.Parameters.AddWithValue("Hover_Box_Shadow_Blur_Radius", button.Hover_Box_Shadow_Blur_Radius + "px");
				conexao.mCommand.Parameters.AddWithValue("Hover_Box_Shadow_Spread_Radius", button.Hover_Box_Shadow_Spread_Radius + "px");
				conexao.mCommand.Parameters.AddWithValue("Hover_Box_Shadow_Color", button.Hover_Box_Shadow_Color.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Hover_Box_Shadow_Inset_Offset_X", button.Hover_Box_Shadow_Inset_Offset_X + "px");
				conexao.mCommand.Parameters.AddWithValue("Hover_Box_Shadow_Inset_Offset_Y", button.Hover_Box_Shadow_Inset_Offset_Y + "px");
				conexao.mCommand.Parameters.AddWithValue("Hover_Box_Shadow_Inset_Blur_Radius", button.Hover_Box_Shadow_Inset_Blur_Radius + "px");
				conexao.mCommand.Parameters.AddWithValue("Hover_Box_Shadow_Inset_Spread_Radius", button.Hover_Box_Shadow_Inset_Spread_Radius + "px");
				conexao.mCommand.Parameters.AddWithValue("Hover_Box_Shadow_Inset_Color", button.Hover_Box_Shadow_Inset_Color.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Hover_Animation", button.Hover_Animation.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Hover_Animation_Type", button.Hover_Animation_Type.ToLower());

				#endregion

				conexao.ExecuteTransaction();
				conexao.CommitTransaction();

				Util.Log("INSERÇÃO DE BOTÃO");

			}
            catch (Exception ex)
            {
				conexao.RollbackTransaction();
				throw ex;
            }

		}

		public static void UpdateButton(ButtonModel button)
		{
			string StrConn = ConfigurationManager.AppSettings.Get("SqlServerConn").ToString();

			ConnectionSQLServer conexao = new ConnectionSQLServer(StrConn);

			conexao.BeginTransaction();

			try
			{

				#region SQL

				string sql = @"UPDATE dbo.Button_Properties SET								
									Static_Border_Top_Width = @Static_Border_Top_Width,
									Static_Border_Bottom_Width = @Static_Border_Bottom_Width,
									Static_Border_Left_Width = @Static_Border_Left_Width,
									Static_Border_Right_Width = @Static_Border_Right_Width,
									Static_Border_Top_Style = @Static_Border_Top_Style,
									Static_Border_Bottom_Style = @Static_Border_Bottom_Style,
									Static_Border_Left_Style = @Static_Border_Left_Style,
									Static_Border_Right_Style = @Static_Border_Right_Style,
									Static_Border_Top_Color = @Static_Border_Top_Color,
									Static_Border_Bottom_Color = @Static_Border_Bottom_Color,
									Static_Border_Left_Color = @Static_Border_Left_Color,
									Static_Border_Right_Color = @Static_Border_Right_Color,
									Static_Top_Left_Radius = @Static_Top_Left_Radius,
									Static_Top_Right_Radius = @Static_Top_Right_Radius,
									Static_Bottom_Left_Radius = @Static_Bottom_Left_Radius,
									Static_Bottom_Right_Radius = @Static_Bottom_Right_Radius,
									Static_Padding_Top = @Static_Padding_Top,
									Static_Padding_Bottom = @Static_Padding_Bottom,
									Static_Padding_Left = @Static_Padding_Left,
									Static_Padding_Right = @Static_Padding_Right,
									Static_Font_Size = @Static_Font_Size,
									Static_Font_Style = @Static_Font_Style,
									Static_Font_Weight = @Static_Font_Weight,									
									Static_Background_Color = @Static_Background_Color,
									Static_Color = @Static_Color,												
									Static_Box_Shadow_Offset_X = @Static_Box_Shadow_Offset_X,
									Static_Box_Shadow_Offset_Y = @Static_Box_Shadow_Offset_Y,
									Static_Box_Shadow_Blur_Radius = @Static_Box_Shadow_Blur_Radius,
									Static_Box_Shadow_Spread_Radius = @Static_Box_Shadow_Spread_Radius,
									Static_Box_Shadow_Color = @Static_Box_Shadow_Color,
									Static_Box_Shadow_Inset_Offset_X = @Static_Box_Shadow_Inset_Offset_X,
									Static_Box_Shadow_Inset_Offset_Y = @Static_Box_Shadow_Inset_Offset_Y,
									Static_Box_Shadow_Inset_Blur_Radius = @Static_Box_Shadow_Inset_Blur_Radius,
									Static_Box_Shadow_Inset_Spread_Radius = @Static_Box_Shadow_Inset_Spread_Radius,
									Static_Box_Shadow_Inset_Color = @Static_Box_Shadow_Inset_Color,
									Static_Text_Shadow_Offset_X = @Static_Text_Shadow_Offset_X,
									Static_Text_Shadow_Offset_Y = @Static_Text_Shadow_Offset_Y,
									Static_Text_Shadow_Blur_Radius = @Static_Text_Shadow_Blur_Radius,									
									Static_Text_Shadow_Color = @Static_Text_Shadow_Color,
									Static_Animation = @Static_Animation,
									Static_Animation_Type = @Static_Animation_Type,
									Hover_Border_Top_Width = @Hover_Border_Top_Width,
									Hover_Border_Bottom_Width = @Hover_Border_Bottom_Width,
									Hover_Border_Left_Width = @Hover_Border_Left_Width,
									Hover_Border_Right_Width = @Hover_Border_Right_Width,
									Hover_Border_Top_Style = @Hover_Border_Top_Style,
									Hover_Border_Bottom_Style = @Hover_Border_Bottom_Style,
									Hover_Border_Left_Style = @Hover_Border_Left_Style,
									Hover_Border_Right_Style = @Hover_Border_Right_Style,
									Hover_Border_Top_Color = @Hover_Border_Top_Color,
									Hover_Border_Bottom_Color = @Hover_Border_Bottom_Color,
									Hover_Border_Left_Color = @Hover_Border_Left_Color,
									Hover_Border_Right_Color = @Hover_Border_Right_Color,
									Hover_Top_Left_Radius = @Hover_Top_Left_Radius,
									Hover_Top_Right_Radius = @Hover_Top_Right_Radius,
									Hover_Bottom_Left_Radius = @Hover_Bottom_Left_Radius,
									Hover_Bottom_Right_Radius = @Hover_Bottom_Right_Radius,
									Hover_Padding_Top = @Hover_Padding_Top,
									Hover_Padding_Bottom = @Hover_Padding_Bottom,
									Hover_Padding_Left = @Hover_Padding_Left,
									Hover_Padding_Right = @Hover_Padding_Right,
									Hover_Font_Size = @Hover_Font_Size,
									Hover_Font_Style = @Hover_Font_Style,
									Hover_Font_Weight = @Hover_Font_Weight,
									Hover_Color = @Hover_Color,
									Hover_Text_Shadow_Offset_X = @Hover_Text_Shadow_Offset_X,
									Hover_Text_Shadow_Offset_Y = @Hover_Text_Shadow_Offset_Y,
									Hover_Text_Shadow_Blur_Radius = @Hover_Text_Shadow_Blur_Radius,									
									Hover_Text_Shadow_Color = @Hover_Text_Shadow_Color,
									Hover_Background_Color = @Hover_Background_Color,
									Hover_Box_Shadow_Offset_X = @Hover_Box_Shadow_Offset_X,
									Hover_Box_Shadow_Offset_Y = @Hover_Box_Shadow_Offset_Y,
									Hover_Box_Shadow_Blur_Radius = @Hover_Box_Shadow_Blur_Radius,
									Hover_Box_Shadow_Spread_Radius = @Hover_Box_Shadow_Spread_Radius,
									Hover_Box_Shadow_Color = @Hover_Box_Shadow_Color,
									Hover_Box_Shadow_Inset_Offset_X = @Hover_Box_Shadow_Inset_Offset_X,
									Hover_Box_Shadow_Inset_Offset_Y = @Hover_Box_Shadow_Inset_Offset_Y,
									Hover_Box_Shadow_Inset_Blur_Radius = @Hover_Box_Shadow_Inset_Blur_Radius,
									Hover_Box_Shadow_Inset_Spread_Radius = @Hover_Box_Shadow_Inset_Spread_Radius,
									Hover_Box_Shadow_Inset_Color = @Hover_Box_Shadow_Inset_Color,
									Hover_Animation = @Hover_Animation,
									Hover_Animation_Type = @Hover_Animation_Type
								WHERE
									Button_Id = @Button_Id";

				#endregion

				conexao.StartCommandTransaction(sql);

				conexao.mCommand.Parameters.AddWithValue("Button_Id", button.Button_id);

				#region ------------------STATIC PARAMETERS-----------------

				conexao.mCommand.Parameters.AddWithValue("Static_Border_Top_Width", button.Static_Border_Top_Width + "px");
				conexao.mCommand.Parameters.AddWithValue("Static_Border_Bottom_Width", button.Static_Border_Bottom_Width + "px");
				conexao.mCommand.Parameters.AddWithValue("Static_Border_Left_Width", button.Static_Border_Left_Width + "px");
				conexao.mCommand.Parameters.AddWithValue("Static_Border_Right_Width", button.Static_Border_Right_Width + "px");
				conexao.mCommand.Parameters.AddWithValue("Static_Border_Top_Style", button.Static_Border_Top_Style.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Static_Border_Bottom_Style", button.Static_Border_Bottom_Style.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Static_Border_Left_Style", button.Static_Border_Left_Style.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Static_Border_Right_Style", button.Static_Border_Right_Style.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Static_Border_Top_Color", button.Static_Border_Top_Color.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Static_Border_Bottom_Color", button.Static_Border_Bottom_Color.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Static_Border_Left_Color", button.Static_Border_Left_Color.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Static_Border_Right_Color", button.Static_Border_Right_Color.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Static_Top_Left_Radius", button.Static_Border_Top_Left_Radius + "px");
				conexao.mCommand.Parameters.AddWithValue("Static_Top_Right_Radius", button.Static_Border_Top_Right_Radius + "px");
				conexao.mCommand.Parameters.AddWithValue("Static_Bottom_Left_Radius", button.Static_Border_Bottom_Left_Radius + "px");
				conexao.mCommand.Parameters.AddWithValue("Static_Bottom_Right_Radius", button.Static_Border_Bottom_Right_Radius + "px");
				conexao.mCommand.Parameters.AddWithValue("Static_Padding_Top", button.Static_Padding_Top + "px");
				conexao.mCommand.Parameters.AddWithValue("Static_Padding_Bottom", button.Static_Padding_Bottom + "px");
				conexao.mCommand.Parameters.AddWithValue("Static_Padding_Left", button.Static_Padding_Left + "px");
				conexao.mCommand.Parameters.AddWithValue("Static_Padding_Right", button.Static_Padding_Right + "px");
				conexao.mCommand.Parameters.AddWithValue("Static_Font_Size", button.Static_Font_Size + "px");
				conexao.mCommand.Parameters.AddWithValue("Static_Font_Style", button.Static_Font_Style.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Static_Font_Weight", button.Static_Font_Weight);
				conexao.mCommand.Parameters.AddWithValue("Static_Background_Color", button.Static_Background_Color.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Static_Color", button.Static_Color.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Static_Box_Shadow_Offset_X", button.Static_Box_Shadow_Offset_X + "px");
				conexao.mCommand.Parameters.AddWithValue("Static_Box_Shadow_Offset_Y", button.Static_Box_Shadow_Offset_Y + "px");
				conexao.mCommand.Parameters.AddWithValue("Static_Box_Shadow_Blur_Radius", button.Static_Box_Shadow_Blur_Radius + "px");
				conexao.mCommand.Parameters.AddWithValue("Static_Box_Shadow_Spread_Radius", button.Static_Box_Shadow_Spread_Radius + "px");
				conexao.mCommand.Parameters.AddWithValue("Static_Box_Shadow_Color", button.Static_Box_Shadow_Color.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Static_Box_Shadow_Inset_Offset_X", button.Static_Box_Shadow_Inset_Offset_X + "px");
				conexao.mCommand.Parameters.AddWithValue("Static_Box_Shadow_Inset_Offset_Y", button.Static_Box_Shadow_Inset_Offset_Y + "px");
				conexao.mCommand.Parameters.AddWithValue("Static_Box_Shadow_Inset_Blur_Radius", button.Static_Box_Shadow_Inset_Blur_Radius + "px");
				conexao.mCommand.Parameters.AddWithValue("Static_Box_Shadow_Inset_Spread_Radius", button.Static_Box_Shadow_Inset_Spread_Radius + "px");
				conexao.mCommand.Parameters.AddWithValue("Static_Box_Shadow_Inset_Color", button.Static_Box_Shadow_Inset_Color.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Static_Text_Shadow_Offset_X", button.Static_Text_Shadow_Offset_X + "px");
				conexao.mCommand.Parameters.AddWithValue("Static_Text_Shadow_Offset_Y", button.Static_Text_Shadow_Offset_Y + "px");
				conexao.mCommand.Parameters.AddWithValue("Static_Text_Shadow_Blur_Radius", button.Static_Text_Shadow_Blur_Radius + "px");
				conexao.mCommand.Parameters.AddWithValue("Static_Text_Shadow_Color", button.Static_Text_Shadow_Color.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Static_Animation", button.Static_Animation.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Static_Animation_Type", button.Static_Animation_Type.ToLower());

				#endregion

				#region ------------------HOVER PARAMETERS------------------

				//-------------------------------HOVER-----------------------------
				conexao.mCommand.Parameters.AddWithValue("Hover_Border_Top_Width", button.Hover_Border_Top_Width + "px");
				conexao.mCommand.Parameters.AddWithValue("Hover_Border_Bottom_Width", button.Hover_Border_Bottom_Width + "px");
				conexao.mCommand.Parameters.AddWithValue("Hover_Border_Left_Width", button.Hover_Border_Left_Width + "px");
				conexao.mCommand.Parameters.AddWithValue("Hover_Border_Right_Width", button.Hover_Border_Right_Width + "px");
				conexao.mCommand.Parameters.AddWithValue("Hover_Border_Top_Style", button.Hover_Border_Top_Style.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Hover_Border_Bottom_Style", button.Hover_Border_Bottom_Style.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Hover_Border_Left_Style", button.Hover_Border_Left_Style.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Hover_Border_Right_Style", button.Hover_Border_Right_Style.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Hover_Border_Top_Color", button.Hover_Border_Top_Color.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Hover_Border_Bottom_Color", button.Hover_Border_Bottom_Color.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Hover_Border_Left_Color", button.Hover_Border_Left_Color.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Hover_Border_Right_Color", button.Hover_Border_Right_Color.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Hover_Top_Left_Radius", button.Hover_Border_Top_Left_Radius + "px");
				conexao.mCommand.Parameters.AddWithValue("Hover_Top_Right_Radius", button.Hover_Border_Top_Right_Radius + "px");
				conexao.mCommand.Parameters.AddWithValue("Hover_Bottom_Left_Radius", button.Hover_Border_Bottom_Left_Radius + "px");
				conexao.mCommand.Parameters.AddWithValue("Hover_Bottom_Right_Radius", button.Hover_Border_Bottom_Right_Radius + "px");
				conexao.mCommand.Parameters.AddWithValue("Hover_Padding_Top", button.Hover_Padding_Top + "px");
				conexao.mCommand.Parameters.AddWithValue("Hover_Padding_Bottom", button.Hover_Padding_Bottom + "px");
				conexao.mCommand.Parameters.AddWithValue("Hover_Padding_Left", button.Hover_Padding_Left + "px");
				conexao.mCommand.Parameters.AddWithValue("Hover_Padding_Right", button.Hover_Padding_Right + "px");
				conexao.mCommand.Parameters.AddWithValue("Hover_Font_Size", button.Hover_Font_Size + "px");
				conexao.mCommand.Parameters.AddWithValue("Hover_Font_Style", button.Hover_Font_Style.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Hover_Font_Weight", button.Hover_Font_Weight);
				conexao.mCommand.Parameters.AddWithValue("Hover_Color", button.Hover_Color.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Hover_Text_Shadow_Offset_X", button.Hover_Text_Shadow_Offset_X + "px");
				conexao.mCommand.Parameters.AddWithValue("Hover_Text_Shadow_Offset_Y", button.Hover_Text_Shadow_Offset_Y + "px");
				conexao.mCommand.Parameters.AddWithValue("Hover_Text_Shadow_Blur_Radius", button.Hover_Text_Shadow_Blur_Radius + "px");
				conexao.mCommand.Parameters.AddWithValue("Hover_Text_Shadow_Color", button.Hover_Text_Shadow_Color.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Hover_Background_Color", button.Hover_Background_Color.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Hover_Box_Shadow_Offset_X", button.Hover_Box_Shadow_Offset_X + "px");
				conexao.mCommand.Parameters.AddWithValue("Hover_Box_Shadow_Offset_Y", button.Hover_Box_Shadow_Offset_Y + "px");
				conexao.mCommand.Parameters.AddWithValue("Hover_Box_Shadow_Blur_Radius", button.Hover_Box_Shadow_Blur_Radius + "px");
				conexao.mCommand.Parameters.AddWithValue("Hover_Box_Shadow_Spread_Radius", button.Hover_Box_Shadow_Spread_Radius + "px");
				conexao.mCommand.Parameters.AddWithValue("Hover_Box_Shadow_Color", button.Hover_Box_Shadow_Color.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Hover_Box_Shadow_Inset_Offset_X", button.Hover_Box_Shadow_Inset_Offset_X + "px");
				conexao.mCommand.Parameters.AddWithValue("Hover_Box_Shadow_Inset_Offset_Y", button.Hover_Box_Shadow_Inset_Offset_Y + "px");
				conexao.mCommand.Parameters.AddWithValue("Hover_Box_Shadow_Inset_Blur_Radius", button.Hover_Box_Shadow_Inset_Blur_Radius + "px");
				conexao.mCommand.Parameters.AddWithValue("Hover_Box_Shadow_Inset_Spread_Radius", button.Hover_Box_Shadow_Inset_Spread_Radius + "px");
				conexao.mCommand.Parameters.AddWithValue("Hover_Box_Shadow_Inset_Color", button.Hover_Box_Shadow_Inset_Color.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Hover_Animation", button.Hover_Animation.ToLower());
				conexao.mCommand.Parameters.AddWithValue("Hover_Animation_Type", button.Hover_Animation_Type.ToLower());

				#endregion

				conexao.ExecuteTransaction();
				conexao.CommitTransaction();

				Util.Log("ATUALIZAÇÃO DE BOTÃO: " + button.Button_id);

			}
			catch (Exception ex)
			{
				conexao.RollbackTransaction();
				throw ex;
			}

		}
	}
}