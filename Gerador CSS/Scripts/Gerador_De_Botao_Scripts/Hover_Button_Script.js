//----------------------------------------------------------------------------------------------------------------------------------------
//-------------------------------------------------- HOVER -------------------------------------------------------------------------------
//----------------------------------------------------------------------------------------------------------------------------------------



//-----------------------------------------------------------------------------------------------------------
//-----------------------------------------------------------------------------------------------------------

function OpenHoverButtonOptions(){
    let table = document.getElementById("hover_options");    
    let div_hover_options = document.getElementById('div_hover_options');    
    //FONT
    let div_hover_font_options = document.getElementById('div_hover_font_options');
    let table_font = document.getElementById("hover_font_options");
    //PADDING
    let div_hover_padding_options = document.getElementById('div_hover_padding_options');
    let table_padding = document.getElementById("hover_padding_options");
    //BORDER
    let div_hover_border_options = document.getElementById('div_hover_border_options');
    let table_border = document.getElementById("hover_border_options");
    //SHADOW
    let div_hover_shadow_options = document.getElementById('div_hover_shadow_options');
    let table_shadow = document.getElementById("hover_shadow_options");
    //SHADOW INSET
    let div_hover_shadow_inset_options = document.getElementById('div_hover_shadow_inset_options');
    let table_shadow_inset = document.getElementById("hover_shadow_inset_options");

    if(table.style.display == "none"){
        table.style.display = "block";
        div_hover_options.innerHTML = "<span >Mouse Sobre o Botão &#9662;</span>";
        div_hover_options.style.backgroundColor = "#6dc9e7";        
        div_hover_font_options.style.display = "block";
        div_hover_padding_options.style.display = "block";
        div_hover_border_options.style.display = "block";
        div_hover_shadow_options.style.display = "block";
        div_hover_shadow_inset_options.style.display = "block";
    }
    else{
        table.style.display = "none";
        div_hover_options.innerHTML = "<span>Mouse Sobre o Botão &#9652;</span>";        
        div_hover_options.style.backgroundColor = '#add8e6';         

        //CLOSE TABLE FONT HOVER TOO
        div_hover_font_options.style.display = 'none';  
        table_font.style.display = 'none';
        div_hover_font_options.innerHTML = "<span>Fonte &#9652;</span>";
        div_hover_font_options.style.backgroundColor = '#fafb90'; 

        //CLOSE TABLE PADDING HOVER TOO
        div_hover_padding_options.style.display = 'none';  
        table_padding.style.display = 'none';
        div_hover_padding_options.innerHTML = "<span>Preenchimento &#9652;</span>";
        div_hover_padding_options.style.backgroundColor = '#fafb90'; 

        //CLOSE TABLE BORDER HOVER TOO
        div_hover_border_options.style.display = 'none';  
        table_border.style.display = 'none';
        div_hover_border_options.innerHTML = "<span>Bordas &#9652;</span>";
        div_hover_border_options.style.backgroundColor = '#fafb90'; 

        //CLOSE TABLE SHADOW HOVER TOO
        div_hover_shadow_options.style.display = 'none';  
        table_shadow.style.display = 'none';
        div_hover_shadow_options.innerHTML = "<span>Sombra Externa &#9652;</span>";
        div_hover_shadow_options.style.backgroundColor = '#fafb90'; 

        //CLOSE TABLE SHADOW INSET HOVER TOO
        div_hover_shadow_inset_options.style.display = 'none';  
        table_shadow_inset.style.display = 'none';
        div_hover_shadow_inset_options.innerHTML = "<span>Sombra Externa &#9652;</span>";
        div_hover_shadow_inset_options.style.backgroundColor = '#fafb90'; 
    }        
}


function OpenHoverFontButtonOptions(){
    let table = document.getElementById("hover_font_options");
    let div_hover_font_options = document.getElementById('div_hover_font_options');
    if(table.style.display == "none"){
        table.style.display = "block";
        div_hover_font_options.innerHTML = "<span>Fonte &#9662;</span>";
        div_hover_font_options.style.backgroundColor = '#f0f300';        
    }
    else{
        table.style.display = "none";
        div_hover_font_options.innerHTML = "<span>Fonte &#9652;</span>";        
        div_hover_font_options.style.backgroundColor = '#fafb90'; 
    }
}

function OpenHoverPaddingButtonOptions(){
    let table = document.getElementById("hover_padding_options");
    let div_padding_options_hover = document.getElementById('div_hover_padding_options');
    if(table.style.display == "none"){
        table.style.display = "block";
        div_padding_options_hover.innerHTML = "<span>Preenchimento &#9662;</span>";
        div_padding_options_hover.style.backgroundColor = '#f0f300';        
    }
    else{
        table.style.display = "none";
        div_padding_options_hover.innerHTML = "<span>Preenchimento &#9652;</span>";        
        div_padding_options_hover.style.backgroundColor = '#fafb90'; 
    }
}

function OpenHoverBorderButtonOptions(){
    let table = document.getElementById("hover_border_options");
    let div_hover_border_options = document.getElementById('div_hover_border_options');
    if(table.style.display == "none"){
        table.style.display = "block";
        div_hover_border_options.innerHTML = "<span>Bordas &#9662;</span>";
        div_hover_border_options.style.backgroundColor = '#f0f300';        
    }
    else{
        table.style.display = "none";
        div_hover_border_options.innerHTML = "<span>Bordas &#9652;</span>";        
        div_hover_border_options.style.backgroundColor = '#fafb90'; 
    }
}

function OpenHoverShadowButtonOptions(){
    let table = document.getElementById("hover_shadow_options");
    let div_shadow_options_hover = document.getElementById('div_hover_shadow_options');
    if(table.style.display == "none"){
        table.style.display = "block";
        div_shadow_options_hover.innerHTML = "<span>Sombra Externa &#9662;</span>";
        div_shadow_options_hover.style.backgroundColor = '#f0f300';        
    }
    else{
        table.style.display = "none";
        div_shadow_options_hover.innerHTML = "<span>Sombra Externa &#9652;</span>";        
        div_shadow_options_hover.style.backgroundColor = '#fafb90'; 
    }
}


function OpenHoverShadowInsetButtonOptions(){
    let table = document.getElementById("hover_shadow_inset_options");
    let div_shadow_inset_options_hover = document.getElementById('div_hover_shadow_inset_options');
    if(table.style.display == "none"){
        table.style.display = "block";
        div_shadow_inset_options_hover.innerHTML = "<span>Sombra Interna &#9662;</span>";
        div_shadow_inset_options_hover.style.backgroundColor = '#f0f300';        
    }
    else{
        table.style.display = "none";
        div_shadow_inset_options_hover.innerHTML = "<span>Sombra Interna &#9652;</span>";        
        div_shadow_inset_options_hover.style.backgroundColor = '#fafb90'; 
    }
}








//CHANGE BUTTON BACKGROUND COLOR HOVER
function BackgroundColorSelectorHover(input){    
    let color = input.value;
    ChangeCSS("background_color_hover", color);
}

//--------------------------------------------------------------------
//----------------HOVER FONT OPTIONS----------------------------------
//--------------------------------------------------------------------

//CHANGE FONT SIZE HOVER
function FontSizeHover(input){    
    let span_font_size_hover = document.getElementById("font_size_number_hover"); 
    let size = input.value + "px";

    span_font_size_hover.innerText = size;
    ChangeCSS("font_size_hover", size);    

}

// CHANGE FONT COLOR HOVER
function ColorSelectorHover(input){        
    let color = input.value;
    ChangeCSS("color_hover", color);    
}

//CHANGE FONT WEIGHT HOVER
function FontWeightHover(input){
    let span_hover_font_weight = document.getElementById("hover_font_weight_number"); 
    let weight = input.value;

    span_hover_font_weight.innerText = weight;
    ChangeCSS("font_weight_hover", weight);
}

//CHANGE FONT STYLE HOVER
function FontStyleHover(input){
    let style = input.value;

    ChangeCSS("font_style_hover", style);     
}



//--------------------------------------------------------------------
//----------------HOVER BORDER OPTIONS----------------------------------
//--------------------------------------------------------------------




//CHANGE BORDER WIDTH HOVER
function BorderWidthHover(input){
  
    let span_border_width_hover = document.getElementById("border_width_number_hover"); 
    let width = input.value + "px";

    span_border_width_hover.innerText = width;
    ChangeCSS("border_top_width_hover", width); 
    ChangeCSS("border_bottom_width_hover", width);
    ChangeCSS("border_left_width_hover", width); 
    ChangeCSS("border_right_width_hover", width);   
    //RANGES 
    $("#border_top_width_range_hover").val(input.value);
    $("#border_bottom_width_range_hover").val(input.value);
    $("#border_left_width_range_hover").val(input.value);
    $("#border_right_width_range_hover").val(input.value);
    //SPANS
    $("#border_top_width_number_hover").text(width);
    $("#border_bottom_width_number_hover").text(width);
    $("#border_left_width_number_hover").text(width);
    $("#border_right_width_number_hover").text(width);
          
}

//CHANGE BORDER RADIUS HOVER
function BorderRadiusHover(input){   
 let span_border_radius_hover = document.getElementById("border_radius_number_hover"); 
 let radius = input.value + "%";

 span_border_radius_hover.innerText = radius;
 ChangeCSS("border_radius_hover", radius);     
}

//--------------------------------------------------------------------
//----------------HOVER FONT SHADOW OPTIONS-------------------------
//--------------------------------------------------------------------

//ENABLE FONT SHADOWS HOVER
function FontShadowEnableHover(){   
    let check = document.getElementById("checkbox_font_shadow_enable_hover").checked;
    
    
    if(check == true){
        $("#range_font_shadow_offset_x_hover").attr("disabled", false);
        $("#range_font_shadow_offset_y_hover").attr("disabled", false);
        $("#range_font_shadow_blur_radius_hover").attr("disabled", false);
        $("#font_shadow_color_selector_hover").attr("disabled", false);       
    }
    else{
        ChangeCSS("font_shadow_offset_x_hover", "0px"); 
        ChangeCSS("font_shadow_offset_y_hover", "0px");
        ChangeCSS("font_shadow_blur_radius_hover", "0px");         
        
        $("#range_font_shadow_offset_x_hover").attr("disabled", true);
        $("#range_font_shadow_offset_y_hover").attr("disabled", true);
        $("#range_font_shadow_blur_radius_hover").attr("disabled", true);
        $("#font_shadow_color_selector_hover").attr("disabled", true);  
        
        $("#range_font_shadow_offset_x_hover").val(0);
        $("#range_font_shadow_offset_y_hover").val(0);
        $("#range_font_shadow_blur_radius_hover").val(0);
        $("#font_shadow_color_selector_hover").val("black");

        $("#span_font_shadow_offset_x_hover").text("0px");
        $("#span_font_shadow_offset_y_hover").text("0px");
        $("#span_font_shadow_blur_radius_hover").text("0px");
    }
   
}

//CHANGE FONT SHADOW OFFSET X HOVER
function FontShadowOffsetXHover(input){
    let span_font_shadow_offset_x_hover = document.getElementById("span_font_shadow_offset_x_hover"); 
    let offset = input.value + "px";

    span_font_shadow_offset_x_hover.innerText = offset;
    ChangeCSS("font_shadow_offset_x_hover", offset); 
}

//CHANGE FONT SHADOW OFFSET Y HOVER
function FontShadowOffsetYHover(input){
    let span_font_shadow_offset_y_hover = document.getElementById("span_font_shadow_offset_y_hover"); 
    let offset = input.value + "px";
    
    span_font_shadow_offset_y_hover.innerText = offset;
    ChangeCSS("font_shadow_offset_y_hover", offset); 
}

// CHANGE FONT SHADOW BLUR RADIUS HOVER
function FontShadowBlurRadiusHover(input){
    let span_font_shadow_blur_radius_hover = document.getElementById("span_font_shadow_blur_radius_hover");
    let blur = input.value + "px";

    span_font_shadow_blur_radius_hover.innerText = blur;
    ChangeCSS("font_shadow_blur_radius_hover", blur); 
}


// CHANGE FONT SHADOW COLOR HOVER
function FontShadowColorSelectorHover(input){
    let color = input.value;

    ChangeCSS("font_shadow_color_hover", color);
}

//--------------------------------------------------------------------
//----------------HOVER PADDING OPTIONS------------------------------
//--------------------------------------------------------------------


//CHANGE PADDING TOP HOVER
function PaddingTopHover(input){
    let span_paddding_top_hover = document.getElementById("padding_top_number_hover"); 
    let width = input.value + "px";
   
    span_paddding_top_hover.innerText = width;
    ChangeCSS("padding_top_hover", width);      
   }
   
   //CHANGE PADDING BOTTOM HOVER
   function PaddingBottomHover(input){
       let span_paddding_bottom_hover = document.getElementById("padding_bottom_number_hover"); 
       let width = input.value + "px";
      
       span_paddding_bottom_hover.innerText = width;
       ChangeCSS("padding_bottom_hover", width);      
   }
   
   //CHANGE PADDING LEFT HOVER
   function PaddingLeftHover(input){
       let span_paddding_left_hover = document.getElementById("padding_left_number_hover"); 
       let width = input.value + "px";
      
       span_paddding_left_hover.innerText = width;
       ChangeCSS("padding_left_hover", width);      
   }
   
   //CHANGE PADDING RIGHT HOVER
   function PaddingRightHover(input){
       let span_paddding_right_hover = document.getElementById("padding_right_number_hover"); 
       let width = input.value + "px";
      
       span_paddding_right_hover.innerText = width;
       ChangeCSS("padding_right_hover", width);      
   }

//--------------------------------------------------------------------
//----------------HOVER BORDER OPTIONS-------------------------------
//--------------------------------------------------------------------


// CHANGE BORDER COLOR HOVER
function BorderColorSelectorHover(input){       
    let color = input.value;

    $("#border_top_color_selector_hover").val(color);
    $("#border_bottom_color_selector_hover").val(color);
    $("#border_left_color_selector_hover").val(color);
    $("#border_right_color_selector_hover").val(color);

    ChangeCSS("border_top_color_hover", color);
    ChangeCSS("border_bottom_color_hover", color);
    ChangeCSS("border_left_color_hover", color);
    ChangeCSS("border_right_color_hover", color);   

}

//CHANGE BORDER TOP COLOR HOVER
function BorderTopColorSelectorHover(input){
    let color = input.value;

    ChangeCSS("border_top_color_hover", color);
}

//CHANGE BORDER TOP WIDTH HOVER
function BorderTopWidthHover(input){
    let span_border_top_width_hover = document.getElementById("border_top_width_number_hover"); 
    let width = input.value + "px";

    span_border_top_width_hover.innerText = width;
    ChangeCSS("border_top_width_hover", width);      
}

//CHANGE BORDER TOP STYLE HOVER
function BorderTopStyleHover(input){
    let style = input.value;

    ChangeCSS("border_top_style_hover", style); 
}

//CHANGE BORDER TOP LEFT RADIUS HOVER
function BorderTopLeftRadiusWidthHover(input){
    let span_border_top_left_radius_hover = document.getElementById("border_top_left_radius_number_hover"); 
    let radius = input.value + "px";

    span_border_top_left_radius_hover.innerText = radius;
    ChangeCSS("border_top_left_radius_hover", radius)
}

//CHANGE BORDER TOP RIGHT RADIUS HOVER
function BorderTopRightRadiusWidthHover(input){
    let span_border_top_right_radius_hover = document.getElementById("border_top_right_radius_number_hover"); 
    let radius = input.value + "px";

    span_border_top_right_radius_hover.innerText = radius;
    ChangeCSS("border_top_right_radius_hover", radius)
}

//CHANGE BORDER BOTTOM COLOR HOVER
function BorderBottomColorSelectorHover(input){
    let color = input.value;

    ChangeCSS("border_bottom_color_hover", color);
}

//CHANGE BORDER BOTTOM WIDTH HOVER
function BorderBottomWidthHover(input){
    let span_border_bottom_width_hover = document.getElementById("border_bottom_width_number_hover"); 
    let width = input.value + "px";

    span_border_bottom_width_hover.innerText = width;
    ChangeCSS("border_bottom_width_hover", width);      
}

//CHANGE BORDER BOTTOM STYLE HOVER
function BorderBottomStyleHover(input){
    let style = input.value;

    ChangeCSS("border_bottom_style_hover", style); 
}

//CHANGE BORDER BOTTOM LEFT RADIUS HOVER
function BorderBottomLeftRadiusWidthHover(input){
    let span_border_bottom_left_radius_hover = document.getElementById("border_bottom_left_radius_number_hover"); 
    let radius = input.value + "px";

    span_border_bottom_left_radius_hover.innerText = radius;
    ChangeCSS("border_bottom_left_radius_hover", radius)
}

//CHANGE BORDER BOTTOM RIGHT RADIUS HOVER
function BorderBottomRightRadiusWidthHover(input){
    let span_border_bottom_right_radius_hover = document.getElementById("border_bottom_right_radius_number_hover"); 
    let radius = input.value + "px";

    span_border_bottom_right_radius_hover.innerText = radius;
    ChangeCSS("border_bottom_right_radius_hover", radius)
}

//CHANGE BORDER LEFT COLOR HOVER
function BorderLeftColorSelectorHover(input){
    let color = input.value;

    ChangeCSS("border_left_color_hover", color);
}

//CHANGE BORDER LEFT WIDTH HOVER
function BorderLeftWidthHover(input){
    let span_border_top_width_hover = document.getElementById("border_left_width_number_hover"); 
    let width = input.value + "px";

    span_border_top_width_hover.innerText = width;
    ChangeCSS("border_left_width_hover", width);      
}

//CHANGE BORDER LEFT STYLE HOVER
function BorderLeftStyleHover(input){
    let style = input.value;

    ChangeCSS("border_left_style_hover", style); 
}

//CHANGE BORDER RIGHT COLOR HOVER
function BorderRightColorSelectorHover(input){
    let color = input.value;

    ChangeCSS("border_right_color_hover", color);
}

//CHANGE BORDER RIGHT WIDTH HOVER
function BorderRightWidthHover(input){
    let span_border_right_width_hover = document.getElementById("border_right_width_number_hover"); 
    let width = input.value + "px";

    span_border_right_width_hover.innerText = width;
    ChangeCSS("border_right_width_hover", width);      
}

//CHANGE BORDER RIGHT STYLE HOVER
function BorderRightStyleHover(input){
    let style = input.value;

    ChangeCSS("border_right_style_hover", style); 
}

//CHANGE BORDER RADIUS
function BorderRadiusHover(input){   
    let span_border_radius_hover = document.getElementById("border_radius_number_hover"); 
    let radius = input.value + "px";

    span_border_radius_hover.innerText = radius;
    ChangeCSS("border_top_left_radius_hover", radius); 
    ChangeCSS("border_top_right_radius_hover", radius);
    ChangeCSS("border_bottom_left_radius_hover", radius);
    ChangeCSS("border_bottom_right_radius_hover", radius);   
    //RANGES 
    $("#border_top_left_radius_range_hover").val(input.value);
    $("#border_top_right_radius_range_hover").val(input.value);
    $("#border_bottom_left_radius_range_hover").val(input.value);
    $("#border_bottom_right_radius_range_hover").val(input.value);
    //SPANS
    $("#border_top_left_radius_number_hover").text(radius);
    $("#border_top_right_radius_number_hover").text(radius);
    $("#border_bottom_left_radius_number_hover").text(radius);
    $("#border_bottom_right_radius_number_hover").text(radius);
}


//--------------------------------------------------------------------
//----------------HOVER SHADOW OPTIONS--------------------------------
//--------------------------------------------------------------------

//ENABLE HOVER SHADOWS
function HoverShadowEnable(){   
    let check = document.getElementById("checkbox_hover_shadow_enable").checked;
    
    
    if(check == true){
        $("#range_box_shadow_offset_x_hover").attr("disabled", false);
        $("#range_box_shadow_offset_y_hover").attr("disabled", false);
        $("#range_box_shadow_blur_radius_hover").attr("disabled", false);
        $("#range_box_shadow_spread_radius_hover").attr("disabled", false); 
        $("#shadow_color_selector_hover").attr("disabled", false);       
    }
    else{
        ChangeCSS("box_shadow_offset_x_hover", "0px"); 
        ChangeCSS("box_shadow_offset_y_hover", "0px");
        ChangeCSS("box_shadow_blur_radius_hover", "0px"); 
        ChangeCSS("box_shadow_spread_radius_hover", "0px");         
        
        $("#range_box_shadow_offset_x_hover").attr("disabled", true);
        $("#range_box_shadow_offset_y_hover").attr("disabled", true);
        $("#range_box_shadow_blur_radius_hover").attr("disabled", true);
        $("#range_box_shadow_spread_radius_hover").attr("disabled", true); 
        $("#shadow_color_selector_hover").attr("disabled", true);   
        
        $("#range_box_shadow_offset_x_hover").val(0);
        $("#range_box_shadow_offset_y_hover").val(0);
        $("#range_box_shadow_blur_radius_hover").val(0);
        $("#range_box_shadow_spread_radius_hover").val(0);       
        $("#shadow_color_selector_hover").val("#525757");       


        $("#span_box_shadow_offset_x_hover").text("0px");
        $("#span_box_shadow_offset_y_hover").text("0px");
        $("#span_box_shadow_blur_radius_hover").text("0px");
        $("#span_box_shadow_spread_radius_hover").text("0px");
    
    }
   
}


//CHANGE BOX SHADOW OFFSET X HOVER
function BoxShadowOffsetXHover(input){
    let span_box_shadow_offset_x_hover = document.getElementById("span_box_shadow_offset_x_hover"); 
    let offset = input.value + "px";

    span_box_shadow_offset_x_hover.innerText = offset;
    ChangeCSS("box_shadow_offset_x_hover", offset); 
}

//CHANGE BOX SHADOW OFFSET Y HOVER
function BoxShadowOffsetYHover(input){
    let span_box_shadow_offset_y_hover = document.getElementById("span_box_shadow_offset_y_hover"); 
    let offset = input.value + "px";
    
    span_box_shadow_offset_y_hover.innerText = offset;
    ChangeCSS("box_shadow_offset_y_hover", offset); 
}

// CHANGE BOX SHADOW BLUR RADIUS HOVER
function BoxShadowBlurRadiusHover(input){
    let span_box_shadow_blur_radius_hover = document.getElementById("span_box_shadow_blur_radius_hover");
    let blur = input.value + "px";

    span_box_shadow_blur_radius_hover.innerText = blur;
    ChangeCSS("box_shadow_blur_radius_hover", blur); 
}


// CHANGE BOX SHADOW SPREAD RADIUS HOVER
function BoxShadowSpreadRadiusHover(input){
    let span_box_shadow_spread_radius_hover = document.getElementById("span_box_shadow_spread_radius_hover");
    let spread = input.value + "px";

    span_box_shadow_spread_radius_hover.innerText = spread;
    ChangeCSS("box_shadow_spread_radius_hover", spread); 
}

// CHANGE BOX SHADOW COLOR HOVER
function BoxShadowColorSelectorHover(input){
    let color = input.value;

    ChangeCSS("box_shadow_color_hover", color);
}



//--------------------------------------------------------------------
//----------------HOVER SHADOW INSET OPTIONS-------------------------
//--------------------------------------------------------------------

//ENABLE STATIC SHADOWS INSET HOVER
function HoverShadowInsetEnable(){   
    let check = document.getElementById("checkbox_hover_inset_shadow_enable").checked;
    
    
    if(check == true){
        $("#range_box_shadow_inset_offset_x_hover").attr("disabled", false);
        $("#range_box_shadow_inset_offset_y_hover").attr("disabled", false);
        $("#range_box_shadow_inset_blur_radius_hover").attr("disabled", false);
        $("#range_box_shadow_inset_spread_radius_hover").attr("disabled", false); 
        $("#shadow_inset_color_selector_hover").attr("disabled", false);       
    }
    else{
        ChangeCSS("box_shadow_inset_offset_x_hover", "0px"); 
        ChangeCSS("box_shadow_inset_offset_y_hover", "0px");
        ChangeCSS("box_shadow_inset_blur_radius_hover", "0px"); 
        ChangeCSS("box_shadow_inset_spread_radius_hover", "0px");         
        
        $("#range_box_shadow_inset_offset_x_hover").attr("disabled", true);
        $("#range_box_shadow_inset_offset_y_hover").attr("disabled", true);
        $("#range_box_shadow_inset_blur_radius_hover").attr("disabled", true);
        $("#range_box_shadow_inset_spread_radius_hover").attr("disabled", true); 
        $("#shadow_inset_color_selector_hover").attr("disabled", true);   
        
        $("#range_box_shadow_inset_offset_x_hover").val(0);
        $("#range_box_shadow_inset_offset_y_hover").val(0);
        $("#range_box_shadow_inset_blur_radius_hover").val(0);
        $("#range_box_shadow_inset_spread_radius_hover").val(0);       
        $("#shadow_inset_color_selector_hover").val("#525757");       

        $("#span_box_shadow_inset_offset_x_hover").text("0px");
        $("#span_box_shadow_inset_offset_y_hover").text("0px");
        $("#span_box_shadow_inset_blur_radius_hover").text("0px");
        $("#span_box_shadow_inset_spread_radius_hover").text("0px");
    
    }
   
}


//CHANGE BOX SHADOW INSET OFFSET X HOVER
function BoxShadowInsetOffsetXHover(input){
    let span_box_shadow_inset_offset_x_hover = document.getElementById("span_box_shadow_inset_offset_x_hover"); 
    let offset = input.value + "px";

    span_box_shadow_inset_offset_x_hover.innerText = offset;
    ChangeCSS("box_shadow_inset_offset_x_hover", offset); 
}

//CHANGE BOX SHADOW INSET OFFSET Y HOVER
function BoxShadowInsetOffsetYHover(input){
    let span_box_shadow_inset_offset_y_hover = document.getElementById("span_box_shadow_inset_offset_y_hover"); 
    let offset = input.value + "px";
    
    span_box_shadow_inset_offset_y_hover.innerText = offset;
    ChangeCSS("box_shadow_inset_offset_y_hover", offset); 
}

// CHANGE BOX SHADOW INSET BLUR RADIUS HOVER
function BoxShadowInsetBlurRadiusHover(input){
    let span_box_shadow_inset_blur_radius_hover = document.getElementById("span_box_shadow_inset_blur_radius_hover");
    let blur = input.value + "px";

    span_box_shadow_inset_blur_radius_hover.innerText = blur;
    ChangeCSS("box_shadow_inset_blur_radius_hover", blur); 
}


// CHANGE BOX SHADOW INSET SPREAD RADIUS HOVER
function BoxShadowInsetSpreadRadiusHover(input){
    let span_box_shadow_inset_spread_radius_hover = document.getElementById("span_box_shadow_inset_spread_radius_hover");
    let spread = input.value + "px";

    span_box_shadow_inset_spread_radius_hover.innerText = spread;
    ChangeCSS("box_shadow_inset_spread_radius_hover", spread); 
}

// CHANGE BOX SHADOW INSET COLOR HOVER
function BoxShadowInsetColorSelectorHover(input){
    let color = input.value;

    ChangeCSS("box_shadow_inset_color_hover", color);
}
