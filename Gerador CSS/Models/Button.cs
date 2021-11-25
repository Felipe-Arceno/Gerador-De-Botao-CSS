using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gerador_CSS.Models
{
    public class Button
    {
        public int Button_id { get; set; }

        //BORDER WIDTH
        public string Static_Border_Top_Width { get; set; }
        public string Static_Border_Bottom_Width { get; set; }
        public string Static_Border_Left_Width { get; set; }
        public string Static_Border_Right_Width { get; set; }
        //BORDER STYLE
        public string Static_Border_Top_Style { get; set; }
        public string Static_Border_Bottom_Style { get; set; }
        public string Static_Border_Left_Style { get; set; }
        public string Static_Border_Right_Style { get; set; }
        //BORDER COLOR
        public string Static_Border_Top_Color { get; set; }
        public string Static_Border_Bottom_Color { get; set; }
        public string Static_Border_Left_Color { get; set; }
        public string Static_Border_Right_Color { get; set; }
        //BORDER RADIUS
        public string Static_Border_Top_Left_Radius { get; set; }
        public string Static_Border_Top_Right_Radius { get; set; }
        public string Static_Border_Bottom_Left_Radius { get; set; }
        public string Static_Border_Bottom_Right_Radius { get; set; }
        //PADDING
        public string Static_Padding_Top { get; set; }
        public string Static_Padding_Bottom { get; set; }
        public string Static_Padding_Left { get; set; }
        public string Static_Padding_Right { get; set; }
        //FONT       
        public string Static_Font_Size { get; set; }
        public string Static_Font_Style { get; set; }
        public string Static_Font_Weight { get; set; }
        public string Static_Color { get; set; }
        //BACKGROUND
        public string Static_Background_Color { get; set; }
        //SHADOW
        public bool Static_Box_Shadow_Enable { get; set; }
        public bool Static_Box_Shadow_Inset_Enable { get; set; }
        public string Static_Box_Shadow_Offset_X { get; set; }
        public string Static_Box_Shadow_Offset_Y { get; set; }
        public string Static_Box_Shadow_Blur_Radius { get; set; }
        public string Static_Box_Shadow_Spread_Radius { get; set; }
        public string Static_Box_Shadow_Color { get; set; }
        public string Static_Box_Shadow_Inset_Offset_X { get; set; }
        public string Static_Box_Shadow_Inset_Offset_Y { get; set; }
        public string Static_Box_Shadow_Inset_Blur_Radius { get; set; }
        public string Static_Box_Shadow_Inset_Spread_Radius { get; set; }
        public string Static_Box_Shadow_Inset_Color { get; set; }              
        public string Static_Box_Shadow { get; set; }
        //TEXT SHADOW
        public bool Static_Text_Shadow_Enable { get; set; }
        public string Static_Text_Shadow { get; set; }
        public string Static_Text_Shadow_Offset_X { get; set; }
        public string Static_Text_Shadow_Offset_Y { get; set; }
        public string Static_Text_Shadow_Blur_Radius { get; set; }
        public string Static_Text_Shadow_Color { get; set; }

        //HOVER

        //BORDER WIDTH
        public string Hover_Border_Top_Width { get; set; }
        public string Hover_Border_Bottom_Width { get; set; }
        public string Hover_Border_Left_Width { get; set; }
        public string Hover_Border_Right_Width { get; set; }
        //BORDER STYLE
        public string Hover_Border_Top_Style { get; set; }
        public string Hover_Border_Bottom_Style { get; set; }
        public string Hover_Border_Left_Style { get; set; }
        public string Hover_Border_Right_Style { get; set; }
        //BORDER COLOR
        public string Hover_Border_Top_Color { get; set; }
        public string Hover_Border_Bottom_Color { get; set; }
        public string Hover_Border_Left_Color { get; set; }
        public string Hover_Border_Right_Color { get; set; }
        //BORDER RADIUS
        public string Hover_Border_Top_Left_Radius { get; set; }
        public string Hover_Border_Top_Right_Radius { get; set; }
        public string Hover_Border_Bottom_Left_Radius { get; set; }
        public string Hover_Border_Bottom_Right_Radius { get; set; }
        //PADDING
        public string Hover_Padding_Top { get; set; }
        public string Hover_Padding_Bottom { get; set; }
        public string Hover_Padding_Left { get; set; }
        public string Hover_Padding_Right { get; set; }
        //FONT
        public string Hover_Font_Size { get; set; }
        public string Hover_Font_Style { get; set; }
        public string Hover_Font_Weight { get; set; }
        public string Hover_Color { get; set; }
        //BACKGROUND
        public string Hover_Background_Color { get; set; }
        //SHADOW
        public bool Hover_Box_Shadow_Enable { get; set; }
        public bool Hover_Box_Shadow_Inset_Enable { get; set; }
        public string Hover_Box_Shadow_Offset_X { get; set; }
        public string Hover_Box_Shadow_Offset_Y { get; set; }
        public string Hover_Box_Shadow_Blur_Radius { get; set; }
        public string Hover_Box_Shadow_Spread_Radius { get; set; }
        public string Hover_Box_Shadow_Color { get; set; }
        public string Hover_Box_Shadow_Inset_Offset_X { get; set; }
        public string Hover_Box_Shadow_Inset_Offset_Y { get; set; }
        public string Hover_Box_Shadow_Inset_Blur_Radius { get; set; }
        public string Hover_Box_Shadow_Inset_Spread_Radius { get; set; }
        public string Hover_Box_Shadow_Inset_Color { get; set; }
        public string Hover_Box_Shadow { get; set; }

        //TEXT SHADOW
        public bool Hover_Text_Shadow_Enable { get; set; }
        public string Hover_Text_Shadow { get; set; }
        public string Hover_Text_Shadow_Offset_X { get; set; }
        public string Hover_Text_Shadow_Offset_Y { get; set; }
        public string Hover_Text_Shadow_Blur_Radius { get; set; }
        public string Hover_Text_Shadow_Color { get; set; }
    }

}