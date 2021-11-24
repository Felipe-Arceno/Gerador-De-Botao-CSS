
// STATIC
var border_radius = "10%";
var border_color = "#37e9f6";
var padding = "10px";
var background_color = "#04c3fd";
var margin = "5px";
//// STATIC > FONT
var font_size = "16px";
var color= "#ffffff";
var font_style = "normal";
var font_weight = "0";
//// STATIC > BORDERS    
    var border_top_width = "2px";
    var border_bottom_width = "2px";
    var border_left_width = "2px";
    var border_right_width = "2px";
    var border_top_style = "solid";
    var border_bottom_style = "solid";
    var border_left_style = "solid";    
    var border_right_style = "solid";
    var border_top_color = "#37e9f6";
    var border_bottom_color = "#37e9f6";
    var border_left_color = "#37e9f6";
    var border_right_color = "#37e9f6";
    var border_top_left_radius = "8px";
    var border_top_right_radius = "8px";
    var border_bottom_left_radius = "8px";
    var border_bottom_right_radius = "8px";
//// STATIC > PADDING
    var padding_top = "15px";
    var padding_bottom = "15px";
    var padding_left = "20px";
    var padding_right = "20px";
//// STATIC > SHADOW
    var box_shadow_offset_x = "0px";
    var box_shadow_offset_y = "0px";
    var box_shadow_blur_radius = "0px";
    var box_shadow_spread_radius = "0px";
    var box_shadow_color = "#525757";
//// STATIC > SHADOW INSET
    var box_shadow_inset_offset_x = "2px";
    var box_shadow_inset_offset_y = "3px";
    var box_shadow_inset_blur_radius = "9px";
    var box_shadow_inset_spread_radius = "0px";
    var box_shadow_inset_color = "#525757";    
//// STATIC > FONT SHADOW
    var font_shadow_offset_x = "0px";
    var font_shadow_offset_y = "0px";
    var font_shadow_blur_radius = "0px";    
    var font_shadow_color = "#525757";    

//-----------------------------------------//    

//// :HOVER
var background_color_hover = "#4ee7e9";
var border_color_hover = "#37e9f6";
var border_radius_hover = "10%";
var border_width_hover = "1px";
//// :HOVER > FONT
    var font_size_hover = "18px";
    var color_hover = "#ffffff";
    var font_weight_hover = "0";
    var font_style_hover = "normal";
//// :HOVER > FONT SHADOW
    var font_shadow_offset_x_hover = "0px";
    var font_shadow_offset_y_hover = "0px";
    var font_shadow_blur_radius_hover = "0px";    
    var font_shadow_color_hover = "#525757";    
//// :HOVER > PADDING
    var padding_top_hover = "15px";
    var padding_bottom_hover = "15px";
    var padding_left_hover = "20px";
    var padding_right_hover = "20px";
//// :HOVER > BORDERS    
    var border_top_width_hover = "2px";
    var border_bottom_width_hover = "2px";
    var border_left_width_hover = "2px";
    var border_right_width_hover = "2px";
    var border_top_style_hover = "solid";
    var border_bottom_style_hover = "solid";
    var border_left_style_hover = "solid";    
    var border_right_style_hover = "solid";
    var border_top_color_hover = "#37e9f6";
    var border_bottom_color_hover = "#37e9f6";
    var border_left_color_hover = "#37e9f6";
    var border_right_color_hover = "#37e9f6";
    var border_top_left_radius_hover = "8px";
    var border_top_right_radius_hover = "8px";
    var border_bottom_left_radius_hover = "8px";
    var border_bottom_right_radius_hover = "8px";
//// :HOVER > SHADOW
    var box_shadow_offset_x_hover = "0px";
    var box_shadow_offset_y_hover = "0px";
    var box_shadow_blur_radius_hover = "0px";
    var box_shadow_spread_radius_hover = "0px";
    var box_shadow_color_hover = "#525757";
//// :HOVER > SHADOW INSET
    var box_shadow_inset_offset_x_hover = "2px";
    var box_shadow_inset_offset_y_hover = "3px";
    var box_shadow_inset_blur_radius_hover = "9px";
    var box_shadow_inset_spread_radius_hover = "0px";
    var box_shadow_inset_color_hover = "#525757";





$(window).on("load", function(){
    //STATIC
    $("#background_color_selector").val(background_color);
    $("#color_selector").val(color);      
    $("#border_color_selector").val(border_color);
    $("#shadow_color_selector").val(box_shadow_color); 
    $("#shadow_inset_color_selector").val(box_shadow_inset_color); 
    //STATIC > BORDERS
    $("#select_border_top_style").val(border_top_style);
    $("#select_border_bottom_style").val(border_bottom_style);
    $("#select_border_left_style").val(border_left_style);
    $("#select_border_right_style").val(border_right_style);
    $("#border_top_color_selector").val(border_top_color);
    $("#border_bottom_color_selector").val(border_bottom_color);
    $("#border_left_color_selector").val(border_left_color);
    $("#border_right_color_selector").val(border_right_color);
    //STATIC > FONT SHADOW
    FontShadowEnable();
    //STATIC > SHADOW
    StaticShadowEnable();
    //-------------------------------------------------------------//
    //:HOVER
    $("#border_color_selector_hover").val(border_color_hover);  
    $("#background_color_selector_hover").val(background_color_hover);    
    $("#color_selector_hover").val(color_hover);
    //:HOVER > FONT SHADOW
    FontShadowEnableHover();
    //:HOVER > BORDERS
    $("#select_border_top_style_hover").val(border_top_style_hover);
    $("#select_border_bottom_style_hover").val(border_bottom_style_hover);
    $("#select_border_left_style_hover").val(border_left_style_hover);
    $("#select_border_right_style_hover").val(border_right_style_hover);
    $("#border_top_color_selector_hover").val(border_top_color_hover);
    $("#border_bottom_color_selector_hover").val(border_bottom_color_hover);
    $("#border_left_color_selector_hover").val(border_left_color_hover);
    $("#border_right_color_selector_hover").val(border_right_color_hover);
    //:HOVER > SHADOW
    HoverShadowEnable();

    
    
   ChangeCSS();   
});


function ChangeCSS(param, value){
    
    //STATIC
    border_radius                              = param == "border_radius"                              ? value : border_radius;    
    border_color                               = param == "border_color"                               ? value : border_color;
    padding                                    = param == "padding"                                    ? value : padding;    
    background_color                           = param == "background_color"                           ? value : background_color    
    margin                                     = param == "margin"                                     ? value : margin;  
    //STATIC > FONT
    font_size                                  = param == "font_size"                                  ? value : font_size;
    color                                      = param == "color"                                      ? value : color;
    font_style                                 = param == "font_style"                                 ? value : font_style;
    font_weight                                = param == "font_weight"                                ? value : font_weight;
    //STATIC > BORDERS
    border_top_width                           = param == "border_top_width"                           ? value : border_top_width      
    border_bottom_width                        = param == "border_bottom_width"                        ? value : border_bottom_width
    border_left_width                          = param == "border_left_width"                          ? value : border_left_width
    border_right_width                         = param == "border_right_width"                         ? value : border_right_width
    border_top_style                           = param == "border_top_style"                           ? value : border_top_style
    border_bottom_style                        = param == "border_bottom_style"                        ? value : border_bottom_style
    border_left_style                          = param == "border_left_style"                          ? value : border_left_style
    border_right_style                         = param == "border_right_style"                         ? value : border_right_style
    border_top_color                           = param == "border_top_color"                           ? value : border_top_color
    border_bottom_color                        = param == "border_bottom_color"                        ? value : border_bottom_color
    border_left_color                          = param == "border_left_color"                          ? value : border_left_color
    border_right_color                         = param == "border_right_color"                         ? value : border_right_color
    border_top_left_radius                     = param == "border_top_left_radius"                     ? value : border_top_left_radius
    border_top_right_radius                    = param == "border_top_right_radius"                    ? value : border_top_right_radius
    border_bottom_left_radius                  = param == "border_bottom_left_radius"                  ? value : border_bottom_left_radius
    border_bottom_right_radius                 = param == "border_bottom_right_radius"                 ? value : border_bottom_right_radius
    //STATIC > PADDING
    padding_top                                = param == "padding_top"                                ? value : padding_top;     
    padding_bottom                             = param == "padding_bottom"                             ? value : padding_bottom;      
    padding_left                               = param == "padding_left"                               ? value : padding_left;      
    padding_right                              = param == "padding_right"                              ? value : padding_right;      
    //STATIC > SHADOW
    box_shadow_offset_x                        = param == "box_shadow_offset_x"                        ? value : box_shadow_offset_x;
    box_shadow_offset_y                        = param == "box_shadow_offset_y"                        ? value : box_shadow_offset_y;
    box_shadow_blur_radius                     = param == "box_shadow_blur_radius"                     ? value : box_shadow_blur_radius;
    box_shadow_spread_radius                   = param == "box_shadow_spread_radius"                   ? value : box_shadow_spread_radius;
    box_shadow_color                           = param == "box_shadow_color"                           ? value : box_shadow_color;
    //STATIC > SHADOW INSET 
    box_shadow_inset_offset_x                  = param == "box_shadow_inset_offset_x"                  ? value : box_shadow_inset_offset_x;
    box_shadow_inset_offset_y                  = param == "box_shadow_inset_offset_y"                  ? value : box_shadow_inset_offset_y;
    box_shadow_inset_blur_radius               = param == "box_shadow_inset_blur_radius"               ? value : box_shadow_inset_blur_radius;
    box_shadow_inset_spread_radius             = param == "box_shadow_inset_spread_radius"             ? value : box_shadow_inset_spread_radius;
    box_shadow_inset_color                     = param == "box_shadow_inset_color"                     ? value : box_shadow_inset_color;
    //STATIC > FONT SHADOW
    font_shadow_offset_x                       = param == "font_shadow_offset_x"                       ? value : font_shadow_offset_x;
    font_shadow_offset_y                       = param == "font_shadow_offset_y"                       ? value : font_shadow_offset_y;
    font_shadow_blur_radius                    = param == "font_shadow_blur_radius"                    ? value : font_shadow_blur_radius;   
    font_shadow_color                          = param == "font_shadow_color"                          ? value : font_shadow_color;  
    //:HOVER
    background_color_hover                     = param == "background_color_hover"                     ? value : background_color_hover;    
    border_color_hover                         = param == "border_color_hover"                         ? value : border_color_hover;
    border_radius_hover                        = param == "border_radius_hover"                        ? value : border_radius_hover;
    border_width_hover                         = param == "border_width_hover"                         ? value : border_width_hover;
    //:HOVER > FONT
    font_size_hover                            = param == "font_size_hover"                            ? value : font_size_hover;
    color_hover                                = param == "color_hover"                                ? value : color_hover;
    font_weight_hover                          = param == "font_weight_hover"                          ? value : font_weight_hover;
    font_style_hover                           = param == "font_style_hover"                           ? value : font_style_hover;
    //:HOVER> FONT SHADOW
    font_shadow_offset_x_hover                 = param == "font_shadow_offset_x_hover"                 ? value : font_shadow_offset_x_hover;
    font_shadow_offset_y_hover                 = param == "font_shadow_offset_y_hover"                 ? value : font_shadow_offset_y_hover;
    font_shadow_blur_radius_hover              = param == "font_shadow_blur_radius_hover"              ? value : font_shadow_blur_radius_hover;   
    font_shadow_color_hover                    = param == "font_shadow_color_hover"                    ? value : font_shadow_color_hover;  
    //:HOVER> PADDING
    padding_top_hover                          = param == "padding_top_hover"                          ? value : padding_top_hover;     
    padding_bottom_hover                       = param == "padding_bottom_hover"                       ? value : padding_bottom_hover;      
    padding_left_hover                         = param == "padding_left_hover"                         ? value : padding_left_hover;      
    padding_right_hover                        = param == "padding_right_hover"                        ? value : padding_right_hover;      
    //:HOVER > BORDERS
    border_top_width_hover                     = param == "border_top_width_hover"                     ? value : border_top_width_hover      
    border_bottom_width_hover                  = param == "border_bottom_width_hover"                  ? value : border_bottom_width_hover
    border_left_width_hover                    = param == "border_left_width_hover"                    ? value : border_left_width_hover
    border_right_width_hover                   = param == "border_right_width_hover"                   ? value : border_right_width_hover
    border_top_style_hover                     = param == "border_top_style_hover"                     ? value : border_top_style_hover
    border_bottom_style_hover                  = param == "border_bottom_style_hover"                  ? value : border_bottom_style_hover
    border_left_style_hover                    = param == "border_left_style_hover"                    ? value : border_left_style_hover
    border_right_style_hover                   = param == "border_right_style_hover"                   ? value : border_right_style_hover
    border_top_color_hover                     = param == "border_top_color_hover"                     ? value : border_top_color_hover
    border_bottom_color_hover                  = param == "border_bottom_color_hover"                  ? value : border_bottom_color_hover
    border_left_color_hover                    = param == "border_left_color_hover"                    ? value : border_left_color_hover
    border_right_color_hover                   = param == "border_right_color_hover"                   ? value : border_right_color_hover
    border_top_left_radius_hover               = param == "border_top_left_radius_hover"               ? value : border_top_left_radius_hover
    border_top_right_radius_hover              = param == "border_top_right_radius_hover"              ? value : border_top_right_radius_hover
    border_bottom_left_radius_hover            = param == "border_bottom_left_radius_hover"            ? value : border_bottom_left_radius_hover
    border_bottom_right_radius_hover           = param == "border_bottom_right_radius_hover"           ? value : border_bottom_right_radius_hover
    //:HOVER > SHADOW
    box_shadow_offset_x_hover                  = param == "box_shadow_offset_x_hover"                  ? value : box_shadow_offset_x_hover;
    box_shadow_offset_y_hover                  = param == "box_shadow_offset_y_hover"                  ? value : box_shadow_offset_y_hover;
    box_shadow_blur_radius_hover               = param == "box_shadow_blur_radius_hover"               ? value : box_shadow_blur_radius_hover;
    box_shadow_spread_radius_hover             = param == "box_shadow_spread_radius_hover"             ? value : box_shadow_spread_radius_hover;
    box_shadow_color_hover                     = param == "box_shadow_color_hover"                     ? value : box_shadow_color_hover;
    //:HOVER > SHADOW INSET 
    box_shadow_inset_offset_x_hover            = param == "box_shadow_inset_offset_x_hover"            ? value : box_shadow_inset_offset_x_hover;
    box_shadow_inset_offset_y_hover            = param == "box_shadow_inset_offset_y_hover"            ? value : box_shadow_inset_offset_y_hover;
    box_shadow_inset_blur_radius_hover         = param == "box_shadow_inset_blur_radius_hover"         ? value : box_shadow_inset_blur_radius_hover;
    box_shadow_inset_spread_radius_hover       = param == "box_shadow_inset_spread_radius_hover"       ? value : box_shadow_inset_spread_radius_hover;
    box_shadow_inset_color_hover               = param == "box_shadow_inset_color_hover"               ? value : box_shadow_inset_color_hover;



    let css = ".mybtn{\n"+    
    "border-top-width: "+border_top_width+";\n"+
    "border-bottom-width: "+border_bottom_width+";\n"+
    "border-left-width: "+border_left_width+";\n"+
    "border-right-width: "+border_right_width+";\n"+
    "border-top-style: "+border_top_style+";\n"+
    "border-bottom-style: "+border_bottom_style+";\n"+
    "border-left-style: "+border_left_style+";\n"+
    "border-right-style: "+border_right_style+";\n"+
    "border-top-color: "+border_top_color+";\n"+
    "border-bottom-color: "+border_bottom_color+";\n"+
    "border-left-color: "+border_left_color+";\n"+
    "border-right-color: "+border_right_color+";\n"+   
    "border-top-left-radius: "+border_top_left_radius+";\n"+ 
    "border-top-right-radius: "+border_top_right_radius+";\n"+ 
    "border-bottom-right-radius: "+border_bottom_right_radius+";\n"+  
    "border-bottom-left-radius: "+border_bottom_left_radius+";\n"+ 
    "padding-top: "+padding_top+";\n"+
    "padding-bottom: "+padding_bottom+";\n"+
    "padding-left: "+padding_left+";\n"+
    "padding-right: "+padding_right+";\n"+
    "font-size: "+font_size+";\n"+
    "font-style: "+font_style+";\n"+
    "font-weight: "+font_weight+";\n"+
    "background-color: "+background_color+";\n"+
    "color: "+color+";\n"+
    "margin: "+margin+";\n"+
    "box-shadow: "+box_shadow_offset_x+" "+box_shadow_offset_y+" "+box_shadow_blur_radius+" "+box_shadow_spread_radius+" "+box_shadow_color+", inset "+box_shadow_inset_offset_x+" "+box_shadow_inset_offset_y+" "+box_shadow_inset_blur_radius+" "+box_shadow_inset_spread_radius+" "+box_shadow_inset_color+";\n"+
    "text-shadow: "+font_shadow_offset_x+" "+font_shadow_offset_y+" "+font_shadow_blur_radius+" "+font_shadow_color+";\n"+

    "}\n"+
    ".mybtn:hover{\n"+
    "background-color: "+background_color_hover+";\n"+
    "font-size: "+font_size_hover+";\n"+
    "color: "+color_hover+";\n"+
    "font-weight: "+font_weight_hover+";\n"+
    "font-style: "+font_style_hover+";\n"+
    "text-shadow: "+font_shadow_offset_x_hover+" "+font_shadow_offset_y_hover+" "+font_shadow_blur_radius_hover+" "+font_shadow_color_hover+";\n"+
    "padding-top: "+padding_top_hover+";\n"+
    "padding-bottom: "+padding_bottom_hover+";\n"+
    "padding-left: "+padding_left_hover+";\n"+
    "padding-right: "+padding_right_hover+";\n"+
    "border-top-width: "+border_top_width_hover+";\n"+
    "border-bottom-width: "+border_bottom_width_hover+";\n"+
    "border-left-width: "+border_left_width_hover+";\n"+
    "border-right-width: "+border_right_width_hover+";\n"+
    "border-top-style: "+border_top_style_hover+";\n"+
    "border-bottom-style: "+border_bottom_style_hover+";\n"+
    "border-left-style: "+border_left_style_hover+";\n"+
    "border-right-style: "+border_right_style_hover+";\n"+
    "border-top-color: "+border_top_color_hover+";\n"+
    "border-bottom-color: "+border_bottom_color_hover+";\n"+
    "border-left-color: "+border_left_color_hover+";\n"+
    "border-right-color: "+border_right_color_hover+";\n"+   
    "border-top-left-radius: "+border_top_left_radius_hover+";\n"+ 
    "border-top-right-radius: "+border_top_right_radius_hover+";\n"+ 
    "border-bottom-right-radius: "+border_bottom_right_radius_hover+";\n"+  
    "border-bottom-left-radius: "+border_bottom_left_radius_hover+";\n"+ 
    "box-shadow: "+box_shadow_offset_x_hover+" "+box_shadow_offset_y_hover+" "+box_shadow_blur_radius_hover+" "+box_shadow_spread_radius_hover+" "+box_shadow_color_hover+", inset "+box_shadow_inset_offset_x_hover+" "+box_shadow_inset_offset_y_hover+" "+box_shadow_inset_blur_radius_hover+" "+box_shadow_inset_spread_radius_hover+" "+box_shadow_inset_color_hover+";\n"+
        "/* Thanks for using my generator! \n by Felipe Arceno */" +
    "}\n"
    


    let style = document.getElementById('hover');                    
    
    $("#css_code").text(css);
   if (style != undefined)
   {
     style.innerHTML = css;
   } 
   else
   {
     style.appendChild(document.createTextNode(css));
   }
}

// COPY CSS TO CLIPBOARD
function CopyToClipboardCSS(){
    let CSS = document.getElementById('css_code');    
    CSS.select();
    CSS.setSelectionRange(0, 99999);
    document.execCommand('copy');
}


