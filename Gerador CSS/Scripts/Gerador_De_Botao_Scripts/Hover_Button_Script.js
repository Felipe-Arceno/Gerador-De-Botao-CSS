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
        div_hover_shadow_inset_options.innerHTML = "<span>Sombra Interna &#9652;</span>";
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
    let font_size_hover_number = document.getElementById("font_size_number_hover"); 
    let size = input.value + "px";

    font_size_hover_number.value = input.value;
    ChangeCSS("font_size_hover", size);  
}

function FontSizeHoverNumberChanged(input) {
    let font_size_hover_range = document.getElementById("font_size_hover_range");
    let size = input.value + "px";

    font_size_hover_range.value = input.value;
    ChangeCSS("font_size_hover", size);
}

// CHANGE FONT COLOR HOVER
function ColorSelectorHover(input){        
    let color = input.value;
    ChangeCSS("color_hover", color);    
}

//CHANGE FONT WEIGHT HOVER
function FontWeightHover(input){
    let hover_font_weight_number = document.getElementById("hover_font_weight_number"); 
    let weight = input.value;

    hover_font_weight_number.value = weight;
    ChangeCSS("font_weight_hover", weight);
}

function FontWeightHoverNumberChanged(input) {
    let font_weight_hover_range = document.getElementById("font_weight_hover_range");
    let weight = input.value;

    font_weight_hover_range.value = weight;
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
        $("#shadow_color_selector_hover").attr("disabled", false);

        $("#font_shadow_offset_x_hover_number").attr("disabled", false);
        $("#font_shadow_offset_y_hover_number").attr("disabled", false);
        $("#font_shadow_blur_radius_hover_number").attr("disabled", false);
    }
    else{
        ChangeCSS("font_shadow_offset_x_hover", "0px"); 
        ChangeCSS("font_shadow_offset_y_hover", "0px");
        ChangeCSS("font_shadow_blur_radius_hover", "0px");         
        
        $("#range_font_shadow_offset_x_hover").attr("disabled", true);
        $("#range_font_shadow_offset_y_hover").attr("disabled", true);
        $("#range_font_shadow_blur_radius_hover").attr("disabled", true);
        $("#shadow_color_selector_hover").attr("disabled", true);

        $("#font_shadow_offset_x_hover_number").attr("disabled", true);
        $("#font_shadow_offset_y_hover_number").attr("disabled", true);
        $("#font_shadow_blur_radius_hover_number").attr("disabled", true);
        
        $("#range_font_shadow_offset_x_hover").val(0);
        $("#range_font_shadow_offset_y_hover").val(0);
        $("#range_font_shadow_blur_radius_hover").val(0);
        $("#shadow_color_selector_hover").val("black");

        $("#font_shadow_offset_x_hover_number").val(0);
        $("#font_shadow_offset_y_hover_number").val(0);
        $("#font_shadow_blur_radius_hover_number").val(0);
    }
   
}

//CHANGE FONT SHADOW OFFSET X HOVER
function FontShadowOffsetXHover(input){
    let font_shadow_offset_x_hover_number = document.getElementById("font_shadow_offset_x_hover_number"); 
    let offset = input.value + "px";

    font_shadow_offset_x_hover_number.value = input.value;
    ChangeCSS("font_shadow_offset_x_hover", offset); 
}

function FontShadowOffsetXHoverNumberChanged(input) {
    let font_shadow_offset_x_hover_range = document.getElementById("range_font_shadow_offset_x_hover");
    let offset = input.value + "px";

    font_shadow_offset_x_hover_range.value = input.value;
    ChangeCSS("font_shadow_offset_x_hover", offset);
}

//CHANGE FONT SHADOW OFFSET Y HOVER
function FontShadowOffsetYHover(input){
    let font_shadow_offset_y_hover_number= document.getElementById("font_shadow_offset_y_hover_number"); 
    let offset = input.value + "px";
    
    font_shadow_offset_y_hover_number.value = input.value;
    ChangeCSS("font_shadow_offset_y_hover", offset); 
}

function FontShadowOffsetYHoverNumberChanged(input) {
    let font_shadow_offset_y_hover_range = document.getElementById("range_font_shadow_offset_y_hover");
    let offset = input.value + "px";

    font_shadow_offset_y_hover_range.value = input.value;
    ChangeCSS("font_shadow_offset_y_hover", offset);
}


// CHANGE FONT SHADOW BLUR RADIUS HOVER
function FontShadowBlurRadiusHover(input){
    let font_shadow_blur_radius_hover_number = document.getElementById("font_shadow_blur_radius_hover_number");
    let blur = input.value + "px";

    font_shadow_blur_radius_hover_number.value = input.value;
    ChangeCSS("font_shadow_blur_radius_hover", blur); 
}

function FontShadowBlurRadiusHoverNumberChanged(input) {
    let font_shadow_blur_radius_hover_range = document.getElementById("range_font_shadow_blur_radius_hover");
    let blur = input.value + "px";

    font_shadow_blur_radius_hover_range.value = input.value;
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
    let paddding_top_hover_number = document.getElementById("padding_top_number_hover_number"); 
    let width = input.value + "px";
   
    paddding_top_hover_number.value = input.value;
    ChangeCSS("padding_top_hover", width);      
}

function PaddingTopHoverNumberChanged(input) {
    let paddding_top_hover_range = document.getElementById("padding_top_hover_range");
    let width = input.value + "px";

    paddding_top_hover_range.value = input.value;
    ChangeCSS("padding_top_hover", width);
}
   
//CHANGE PADDING BOTTOM HOVER
function PaddingBottomHover(input){
    let paddding_bottom_hover_number = document.getElementById("padding_bottom_number_hover_number"); 
    let width = input.value + "px";

    paddding_bottom_hover_number.value = input.value;
    ChangeCSS("padding_bottom_hover", width);      
}

function PaddingBottomHoverNumberChanged(input) {
    let paddding_bottom_hover_range = document.getElementById("padding_bottom_hover_range");
    let width = input.value + "px";

    paddding_bottom_hover_range.value = input.value;
    ChangeCSS("padding_bottom_hover", width);
}
   
//CHANGE PADDING LEFT HOVER
function PaddingLeftHover(input){
    let paddding_left_hover_number = document.getElementById("padding_left_number_hover_number"); 
    let width = input.value + "px";

    paddding_left_hover_number.value = input.value;
    ChangeCSS("padding_left_hover", width);      
}


function PaddingLeftHoverNumberChanged(input) {
    let paddding_left_hover_range = document.getElementById("padding_left_hover_range");
    let width = input.value + "px";

    paddding_left_hover_range.value = input.value;
    ChangeCSS("padding_left_hover", width);
}
   
//CHANGE PADDING RIGHT HOVER
function PaddingRightHover(input){
    let paddding_right_hover_number = document.getElementById("padding_right_number_hover_number"); 
    let width = input.value + "px";
      
    paddding_right_hover_number.value = input.value;
    ChangeCSS("padding_right_hover", width);      
}


function PaddingRightHoverNumberChanged(input) {
    let paddding_right_hover_range = document.getElementById("padding_right_hover_range");
    let width = input.value + "px";

    paddding_right_hover_range.value = input.value;
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
    let border_top_width_hover_number = document.getElementById("border_top_width_number_hover"); 
    let width = input.value + "px";

    border_top_width_hover_number.value = input.value;
    ChangeCSS("border_top_width_hover", width);      
}

function BorderTopWidthHoverNumberChanged(input) {
    let border_top_width_hover_range = document.getElementById("border_top_width_range_hover");
    let width = input.value + "px";

    border_top_width_hover_range.value = input.value;
    ChangeCSS("border_top_width_hover", width);
}

//CHANGE BORDER TOP STYLE HOVER
function BorderTopStyleHover(input){
    let style = input.value;

    ChangeCSS("border_top_style_hover", style); 
}

//CHANGE BORDER TOP LEFT RADIUS HOVER
function BorderTopLeftRadiusWidthHover(input){
    let border_top_left_radius_hover_number = document.getElementById("border_top_left_radius_number_hover"); 
    let radius = input.value + "px";

    border_top_left_radius_hover_number.value = input.value;
    ChangeCSS("border_top_left_radius_hover", radius)
}

function BorderTopLeftRadiusHoverNumberChanged(input) {
    let border_top_left_radius_hover_range = document.getElementById("border_top_left_radius_range_hover");
    let radius = input.value + "px";

    border_top_left_radius_hover_range.value = input.value;
    ChangeCSS("border_top_left_radius_hover", radius);
}

//CHANGE BORDER TOP RIGHT RADIUS HOVER
function BorderTopRightRadiusWidthHover(input){
    let border_top_right_radius_hover_number = document.getElementById("border_top_right_radius_number_hover"); 
    let radius = input.value + "px";

    border_top_right_radius_hover_number.value = input.value;
    ChangeCSS("border_top_right_radius_hover", radius)
}

function BorderTopRightRadiusHoverNumberChanged(input) {
    let border_top_right_radius_hover_range = document.getElementById("border_top_right_radius_range_hover");
    let radius = input.value + "px";

    border_top_right_radius_hover_range.value = input.value;
    ChangeCSS("border_top_right_radius_hover", radius);
}

//CHANGE BORDER BOTTOM COLOR HOVER
function BorderBottomColorSelectorHover(input){
    let color = input.value;

    ChangeCSS("border_bottom_color_hover", color);
}

//CHANGE BORDER BOTTOM WIDTH HOVER
function BorderBottomWidthHover(input){
    let border_bottom_width_hover_number = document.getElementById("border_bottom_width_number_hover"); 
    let width = input.value + "px";

    border_bottom_width_hover_number.value = input.value;
    ChangeCSS("border_bottom_width_hover", width);      
}

function BorderBottomWidthHoverNumberChanged(input) {
    let border_bottom_width_hover_range = document.getElementById("border_bottom_width_range_hover");
    let width = input.value + "px";

    border_bottom_width_hover_range.value = input.value;
    ChangeCSS("border_bottom_width_hover", width);
}

//CHANGE BORDER BOTTOM STYLE HOVER
function BorderBottomStyleHover(input){
    let style = input.value;

    ChangeCSS("border_bottom_style_hover", style); 
}

//CHANGE BORDER BOTTOM LEFT RADIUS HOVER
function BorderBottomLeftRadiusWidthHover(input){
    let border_bottom_left_radius_hover_number = document.getElementById("border_bottom_left_radius_number_hover"); 
    let radius = input.value + "px";

    border_bottom_left_radius_hover_number.value = input.value;
    ChangeCSS("border_bottom_left_radius_hover", radius)
}

function BorderBottomLeftRadiusHoverNumberChanged(input) {
    let border_bottom_left_radius_hover_range = document.getElementById("border_bottom_left_radius_range_hover");
    let radius = input.value + "px";

    border_bottom_left_radius_hover_range.value = input.value;
    ChangeCSS("border_bottom_left_radius_hover", radius);
}

//CHANGE BORDER BOTTOM RIGHT RADIUS HOVER
function BorderBottomRightRadiusWidthHover(input){
    let border_bottom_right_radius_hover_number = document.getElementById("border_bottom_right_radius_number_hover"); 
    let radius = input.value + "px";

    border_bottom_right_radius_hover_number.value = input.value;
    ChangeCSS("border_bottom_right_radius_hover", radius)
}

function BorderBottomRightRadiusHoverNumberChanged(input) {
    let border_bottom_right_radius_hover_range = document.getElementById("border_bottom_right_radius_range_hover");
    let radius = input.value + "px";

    border_bottom_right_radius_hover_range.value = input.value;
    ChangeCSS("border_bottom_right_radius_hover", radius);
}

//CHANGE BORDER LEFT COLOR HOVER
function BorderLeftColorSelectorHover(input){
    let color = input.value;

    ChangeCSS("border_left_color_hover", color);
}

//CHANGE BORDER LEFT WIDTH HOVER
function BorderLeftWidthHover(input){
    let border_top_width_hover_number = document.getElementById("border_left_width_number_hover"); 
    let width = input.value + "px";

    border_top_width_hover_number.value = input.value;
    ChangeCSS("border_left_width_hover", width);      
}

function BorderLeftWidthHoverNumberChanged(input) {
    let border_left_width_hover_range = document.getElementById("border_left_width_range_hover");
    let width = input.value + "px";

    border_left_width_hover_range.value = input.value;
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
    let border_right_width_hover_number = document.getElementById("border_right_width_number_hover"); 
    let width = input.value + "px";

    border_right_width_hover_number.value = input.value;
    ChangeCSS("border_right_width_hover", width);      
}

function BorderRightWidthHoverNumberChanged(input) {
    let border_right_width_hover_range = document.getElementById("border_right_width_range_hover");
    let width = input.value + "px";

    border_right_width_hover_range.value = input.value;
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

        $("#box_shadow_offset_x_hover_number").attr("disabled", false);
        $("#box_shadow_offset_y_hover_number").attr("disabled", false);
        $("#box_shadow_blur_radius_hover_number").attr("disabled", false);
        $("#box_shadow_spread_radius_hover_number").attr("disabled", false);
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

        $("#box_shadow_offset_x_hover_number").attr("disabled", true);
        $("#box_shadow_offset_y_hover_number").attr("disabled", true);
        $("#box_shadow_blur_radius_hover_number").attr("disabled", true);
        $("#box_shadow_spread_radius_hover_number").attr("disabled", true);

        $("#range_box_shadow_offset_x_hover").val(0);
        $("#range_box_shadow_offset_y_hover").val(0);
        $("#range_box_shadow_blur_radius_hover").val(0);
        $("#range_box_shadow_spread_radius_hover").val(0);       
        $("#shadow_color_selector_hover").val("#525757");       


        $("#box_shadow_offset_x_hover_number").val(0);
        $("#box_shadow_offset_y_hover_number").val(0);
        $("#box_shadow_blur_radius_hover_number").val(0);
        $("#box_shadow_spread_radius_hover_number").val(0);
    
    }
   
}


//CHANGE BOX SHADOW OFFSET X HOVER
function BoxShadowOffsetXHover(input){
    let box_shadow_offset_x_hover_number = document.getElementById("box_shadow_offset_x_hover_number"); 
    let offset = input.value + "px";

    box_shadow_offset_x_hover_number.value = input.value;
    ChangeCSS("box_shadow_offset_x_hover", offset); 
}

function BoxShadowOffsetXHoverNumberChanged(input) {
    let box_shadow_offset_x_hover_range = document.getElementById("range_box_shadow_offset_x_hover");
    let offset = input.value + "px";

    box_shadow_offset_x_hover_range.value = input.value;
    ChangeCSS("box_shadow_offset_x_hover", offset);
}

//CHANGE BOX SHADOW OFFSET Y HOVER
function BoxShadowOffsetYHover(input){
    let box_shadow_offset_y_hover_number = document.getElementById("box_shadow_offset_y_hover_number"); 
    let offset = input.value + "px";

    box_shadow_offset_y_hover_number.value = input.value;
    ChangeCSS("box_shadow_offset_y_hover", offset); 
}

function BoxShadowOffsetYHoverNumberChanged(input) {
    let box_shadow_offset_y_hover_range = document.getElementById("range_box_shadow_offset_y_hover");
    let offset = input.value + "px";

    box_shadow_offset_y_hover_range.value = input.value;
    ChangeCSS("box_shadow_offset_y_hover", offset);
}

// CHANGE BOX SHADOW BLUR RADIUS HOVER
function BoxShadowBlurRadiusHover(input){
    let box_shadow_blur_radius_hover_number = document.getElementById("box_shadow_blur_radius_hover_number");
    let blur = input.value + "px";

    box_shadow_blur_radius_hover_number.value = input.value;
    ChangeCSS("box_shadow_blur_radius_hover", blur); 
}

function BoxShadowBlurRadiusHoverNumberChanged(input) {
    let box_shadow_blur_radius_hover_range = document.getElementById("range_box_shadow_blur_radius_hover");
    let blur = input.value + "px";

    box_shadow_blur_radius_hover_range.value = input.value;
    ChangeCSS("box_shadow_blur_radius_hover", blur);
}


// CHANGE BOX SHADOW SPREAD RADIUS HOVER
function BoxShadowSpreadRadiusHover(input){
    let box_shadow_spread_radius_hover_number = document.getElementById("box_shadow_spread_radius_hover_number");
    let spread = input.value + "px";

    box_shadow_spread_radius_hover_number.value = input.value;
    ChangeCSS("box_shadow_spread_radius_hover", spread); 
}

function BoxShadowSpreadRadiusHoverNumberChanged(input) {
    let box_shadow_spread_radius_hover_range = document.getElementById("range_box_shadow_spread_radius_hover");
    let spread = input.value + "px";

    box_shadow_spread_radius_hover_range.value = input.value;
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

        $("#box_shadow_inset_offset_x_hover_number").attr("disabled", false);
        $("#box_shadow_inset_offset_y_hover_number").attr("disabled", false);
        $("#box_shadow_inset_blur_radius_hover_number").attr("disabled", false);
        $("#box_shadow_inset_spread_radius_hover_number").attr("disabled", false);
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

        $("#box_shadow_inset_offset_x_hover_number").attr("disabled", true);
        $("#box_shadow_inset_offset_y_hover_number").attr("disabled", true);
        $("#box_shadow_inset_blur_radius_hover_number").attr("disabled", true);
        $("#box_shadow_inset_spread_radius_hover_number").attr("disabled", true);
        
        $("#range_box_shadow_inset_offset_x_hover").val(0);
        $("#range_box_shadow_inset_offset_y_hover").val(0);
        $("#range_box_shadow_inset_blur_radius_hover").val(0);
        $("#range_box_shadow_inset_spread_radius_hover").val(0);       
        $("#shadow_inset_color_selector_hover").val("#525757");       

        $("#box_shadow_inset_offset_x_hover_number").val(0);
        $("#box_shadow_inset_offset_y_hover_number").val(0);
        $("#box_shadow_inset_blur_radius_hover_number").val(0);
        $("#box_shadow_inset_spread_radius_hover_number").val(0);
    
    }
   
}


//CHANGE BOX SHADOW INSET OFFSET X HOVER
function BoxShadowInsetOffsetXHover(input){
    let box_shadow_inset_offset_x_hover_number = document.getElementById("box_shadow_inset_offset_x_hover_number"); 
    let offset = input.value + "px";

    box_shadow_inset_offset_x_hover_number.value = input.value;
    ChangeCSS("box_shadow_inset_offset_x_hover", offset); 
}

function BoxShadowInsetOffsetXHoverNumberChanged(input) {
    let box_shadow_inset_offset_x_hover_range = document.getElementById("range_box_shadow_inset_offset_x_hover");
    let offset = input.value + "px";

    box_shadow_inset_offset_x_hover_range.value = input.value;
    ChangeCSS("box_shadow_inset_offset_x_hover", offset);
}

//CHANGE BOX SHADOW INSET OFFSET Y HOVER
function BoxShadowInsetOffsetYHover(input){
    let box_shadow_inset_offset_y_hover_number = document.getElementById("box_shadow_inset_offset_y_hover_number"); 
    let offset = input.value + "px";
    
    box_shadow_inset_offset_y_hover_number.value = input.value;
    ChangeCSS("box_shadow_inset_offset_y_hover", offset); 
}

function BoxShadowInsetOffsetYHoverNumberChanged(input) {
    let box_shadow_inset_offset_y_hover_range = document.getElementById("range_box_shadow_inset_offset_y_hover");
    let offset = input.value + "px";

    box_shadow_inset_offset_y_hover_range.value = input.value;
    ChangeCSS("box_shadow_inset_offset_y_hover", offset);
}

// CHANGE BOX SHADOW INSET BLUR RADIUS HOVER
function BoxShadowInsetBlurRadiusHover(input){
    let box_shadow_inset_blur_radius_hover_number = document.getElementById("box_shadow_inset_blur_radius_hover_number");
    let blur = input.value + "px";

    box_shadow_inset_blur_radius_hover_number.value = input.value;
    ChangeCSS("box_shadow_inset_blur_radius_hover", blur); 
}

function BoxShadowInsetBlurRadiusHoverNumberChanged(input) {
    let box_shadow_inset_blur_radius_hover_range = document.getElementById("range_box_shadow_inset_blur_radius_hover");
    let blur = input.value + "px";

    box_shadow_inset_blur_radius_hover_range.value = input.value;
    ChangeCSS("box_shadow_inset_blur_radius_hover", blur);
}


// CHANGE BOX SHADOW INSET SPREAD RADIUS HOVER
function BoxShadowInsetSpreadRadiusHover(input){
    let box_shadow_inset_spread_radius_hover_number = document.getElementById("box_shadow_inset_spread_radius_hover_number");
    let spread = input.value + "px";

    box_shadow_inset_spread_radius_hover_number.value = input.value;
    ChangeCSS("box_shadow_inset_spread_radius_hover", spread); 
}

function BoxShadowInsetSpreadRadiusHoverNumberChanged(input) {
    let box_shadow_inset_spread_radius_hover_range = document.getElementById("range_box_shadow_inset_spread_radius_hover");
    let spread = input.value + "px";

    box_shadow_inset_spread_radius_hover_range.value = input.value;
    ChangeCSS("box_shadow_inset_spread_radius_hover", spread);
}

// CHANGE BOX SHADOW INSET COLOR HOVER
function BoxShadowInsetColorSelectorHover(input){
    let color = input.value;

    ChangeCSS("box_shadow_inset_color_hover", color);
}
