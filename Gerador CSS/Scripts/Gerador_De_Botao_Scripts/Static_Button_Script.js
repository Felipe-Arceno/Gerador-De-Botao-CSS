
//CHANGE BUTTON BACKGROUND COLOR
function BackgroundDivColorSelector(input){     
    let color = input.value;           
    document.getElementById('div-button').style.backgroundColor = color;
}


function OpenStaticButtonOptions(){
    let table = document.getElementById("static_options");
    let div_static_options = document.getElementById('div_static_options');
    //SHADOW
    let div_shadow_options = document.getElementById('div_static_shadow_options');
    let table_shadows = document.getElementById("static_shadow_options");
    //SHADOW INSET
    let div_shadow_inset_options = document.getElementById('div_static_shadow_inset_options');
    let table_shadow_inset = document.getElementById("static_shadow_inset_options");
    //PADDING
    let div_padding_options = document.getElementById('div_static_padding_options');
    let table_padding = document.getElementById("static_padding_options");
    //BORDERS
    let div_static_border_options = document.getElementById('div_static_border_options');
    let table_borders = document.getElementById("static_border_options");
    //FONT
    let div_static_font_options = document.getElementById('div_static_font_options');
    let table_font = document.getElementById("static_font_options");



    if(table.style.display == "none"){
        table.style.display = "block";
        div_static_options.innerHTML = "<span>Botão Estático &#9662;</span>";
        div_shadow_options.style.display = 'block';
        div_static_options.style.backgroundColor = '#6dc9e7';       
        div_shadow_inset_options.style.display = 'block';        
        div_padding_options.style.display = "block";
        div_static_border_options.style.display = "block";
        div_static_font_options.style.display = "block";
    }
    else{
        table.style.display = "none";
        div_static_options.innerHTML = "<span>Botão Estático &#9652;</span>";               
        div_static_options.style.backgroundColor = '#add8e6'; 

        //CLOSE TABLE SHADOW TOO
        div_shadow_options.style.display = 'none';
        table_shadows.style.display = "none";
        div_shadow_options.innerHTML = "<span>Sombra Externa &#9652;</span>";        
        div_shadow_options.style.backgroundColor = '#fafb90'; 

        //CLOSE TABLE SHADOW INSET TOO
        div_shadow_inset_options.style.display = 'none';  
        table_shadow_inset.style.display = 'none';
        div_shadow_inset_options.innerHTML = "<span>Sombra Interna &#9652;</span>";
        div_shadow_inset_options.style.backgroundColor = '#fafb90'; 

        //CLOSE TABLE PADDING TOO
        div_padding_options.style.display = 'none';  
        table_padding.style.display = 'none';
        div_padding_options.innerHTML = "<span>Preenchimento &#9652;</span>";
        div_padding_options.style.backgroundColor = '#fafb90'; 

        //CLOSE TABLE BORDERS TOO
        div_static_border_options.style.display = 'none';  
        table_borders.style.display = 'none';
        div_static_border_options.innerHTML = "<span>Bordas &#9652;</span>";
        div_static_border_options.style.backgroundColor = '#fafb90'; 

        //CLOSE TABLE FONT TOO
        div_static_font_options.style.display = 'none';  
        table_font.style.display = 'none';
        div_static_font_options.innerHTML = "<span>Fonte &#9652;</span>";
        div_static_font_options.style.backgroundColor = '#fafb90'; 
    }        
}


function OpenStaticShadowButtonOptions(){
    let table = document.getElementById("static_shadow_options");
    let div_shadow_options = document.getElementById('div_static_shadow_options');
    if(table.style.display == "none"){
        table.style.display = "block";
        div_shadow_options.innerHTML = "<span>Sombra Externa &#9662;</span>";
        div_shadow_options.style.backgroundColor = '#f0f300';        
    }
    else{
        table.style.display = "none";
        div_shadow_options.innerHTML = "<span>Sombra Externa &#9652;</span>";        
        div_shadow_options.style.backgroundColor = '#fafb90'; 
    }
}

function OpenStaticShadowInsetButtonOptions(){
    let table = document.getElementById("static_shadow_inset_options");
    let div_shadow_inset_options = document.getElementById('div_static_shadow_inset_options');
    if(table.style.display == "none"){
        table.style.display = "block";
        div_shadow_inset_options.innerHTML = "<span>Sombra Interna &#9662;</span>";
        div_shadow_inset_options.style.backgroundColor = '#f0f300';        
    }
    else{
        table.style.display = "none";
        div_shadow_inset_options.innerHTML = "<span>Sombra Interna &#9652;</span>";        
        div_shadow_inset_options.style.backgroundColor = '#fafb90'; 
    }
}

function OpenStaticPaddingButtonOptions(){
    let table = document.getElementById("static_padding_options");
    let div_padding_options = document.getElementById('div_static_padding_options');
    if(table.style.display == "none"){
        table.style.display = "block";
        div_padding_options.innerHTML = "<span>Preenchimento &#9662;</span>";
        div_padding_options.style.backgroundColor = '#f0f300';        
    }
    else{
        table.style.display = "none";
        div_padding_options.innerHTML = "<span>Preenchimento &#9652;</span>";        
        div_padding_options.style.backgroundColor = '#fafb90'; 
    }
}

function OpenStaticBorderButtonOptions(){
    let table = document.getElementById("static_border_options");
    let div_static_border_options = document.getElementById('div_static_border_options');
    if(table.style.display == "none"){
        table.style.display = "block";
        div_static_border_options.innerHTML = "<span>Bordas &#9662;</span>";
        div_static_border_options.style.backgroundColor = '#f0f300';        
    }
    else{
        table.style.display = "none";
        div_static_border_options.innerHTML = "<span>Bordas &#9652;</span>";        
        div_static_border_options.style.backgroundColor = '#fafb90'; 
    }
}


function OpenStaticFontButtonOptions(){
    let table = document.getElementById("static_font_options");
    let div_static_font_options = document.getElementById('div_static_font_options');
    if(table.style.display == "none"){
        table.style.display = "block";
        div_static_font_options.innerHTML = "<span>Fonte &#9662;</span>";
        div_static_font_options.style.backgroundColor = '#f0f300';        
    }
    else{
        table.style.display = "none";
        div_static_font_options.innerHTML = "<span>Fonte &#9652;</span>";        
        div_static_font_options.style.backgroundColor = '#fafb90'; 
    }
}


//CHANGE BUTTON BACKGROUND COLOR
function BackgroundColorSelector(input){     
    let color = input.value;           
    ChangeCSS("background_color", color);
}


//CHANGE BUTTON INNER TEXT
function ChangeButtonInnerText(input){
    let text = input.value;
    let my_button = document.getElementById("mybtn");

    my_button.innerText = text;
}


//--------------------------------------------------------------------
//----------------STATIC FONT OPTIONS---------------------------------
//--------------------------------------------------------------------


// CHANGE FONT COLOR
function ColorSelector(input){        
    let color = input.value;
    ChangeCSS("color", color);    
}

//CHANGE FONT SIZE
function FontSize(input){    
    let span_font_size = document.getElementById("font_size_number"); 
    let size = input.value + "px";

    span_font_size.value = input.value;
    ChangeCSS("font_size", size);    

}

function FontSizeNumberChanged(input){    
    let font_size_range = document.getElementById("static_font_size_range"); 
    let size = input.value + "px";

    font_size_range.value = input.value;
    ChangeCSS("font_size", size);    

}

//CHANGE FONT WEIGHT
function FontWeight(input){    
    let input_weight_size = document.getElementById("font_weight_number"); 
    let weight = input.value;
     
    input_weight_size.value = weight;
    ChangeCSS("font_weight", weight);    

}

function FontWeightNumberChanged(input){    
    let input_weight_size_range = document.getElementById("static_font_weight_range"); 
    let weight = input.value;
     
    input_weight_size_range.value = weight;
    ChangeCSS("font_weight", weight);    

}

//CHANGE FONT STYLE
function FontStyle(input){
    let style = input.value;

    ChangeCSS("font_style", style);     
}


//--------------------------------------------------------------------
//----------------STATIC FONT SHADOW OPTIONS-------------------------
//--------------------------------------------------------------------

//ENABLE FONT SHADOWS
function FontShadowEnable(){   
    let check = document.getElementById("checkbox_font_shadow_enable").checked;
    
    
    if(check == true){
        $("#range_font_shadow_offset_x").attr("disabled", false);
        $("#range_font_shadow_offset_y").attr("disabled", false);
        $("#range_font_shadow_blur_radius").attr("disabled", false);
        $("#font_shadow_color_selector").attr("disabled", false);       
        $("#font_shadow_offset_x_number").attr("disabled", false);
        $("#font_shadow_offset_y_number").attr("disabled", false);
        $("#font_shadow_blur_radius_number").attr("disabled", false);
    }
    else{
        ChangeCSS("font_shadow_offset_x", "0px"); 
        ChangeCSS("font_shadow_offset_y", "0px");
        ChangeCSS("font_shadow_blur_radius", "0px");         
        
        $("#range_font_shadow_offset_x").attr("disabled", true);
        $("#range_font_shadow_offset_y").attr("disabled", true);
        $("#range_font_shadow_blur_radius").attr("disabled", true);
        $("#font_shadow_color_selector").attr("disabled", true);  
        $("#font_shadow_offset_x_number").attr("disabled", true);
        $("#font_shadow_offset_y_number").attr("disabled", true);
        $("#font_shadow_blur_radius_number").attr("disabled", true);
        
        $("#range_font_shadow_offset_x").val(0);
        $("#range_font_shadow_offset_y").val(0);
        $("#range_font_shadow_blur_radius").val(0);
        $("#font_shadow_color_selector").val("black");

        $("#font_shadow_offset_x_number").val(0);
        $("#font_shadow_offset_y_number").val(0);
        $("#font_shadow_blur_radius_number").val(0);
    }
   
}

//CHANGE FONT SHADOW OFFSET X
function FontShadowOffsetX(input){
    let font_shadow_offset_x = document.getElementById("font_shadow_offset_x_number"); 
    let offset = input.value + "px";

    font_shadow_offset_x.value = input.value;
    ChangeCSS("font_shadow_offset_x", offset); 
}

function FontShadowOffsetXNumberChanged(input){
    let font_shadow_offset_x_range = document.getElementById('range_font_shadow_offset_x');
    let offset = input.value + "px";

    font_shadow_offset_x_range.value = input.value;
    ChangeCSS("font_shadow_offset_x", offset); 
}


//CHANGE FONT SHADOW OFFSET Y
function FontShadowOffsetY(input){
    let font_shadow_offset_y = document.getElementById("font_shadow_offset_y_number"); 
    let offset = input.value + "px";
    
    font_shadow_offset_y.value = input.value;
    ChangeCSS("font_shadow_offset_y", offset); 
}

function FontShadowOffsetYNumberChanged(input){
    let font_shadow_offset_y_range = document.getElementById('range_font_shadow_offset_y');
    let offset = input.value + "px";
    
    font_shadow_offset_y_range.value = input.value;
    ChangeCSS("font_shadow_offset_y", offset); 
}


// CHANGE FONT SHADOW BLUR RADIUS
function FontShadowBlurRadius(input){
    let font_shadow_blur_radius = document.getElementById("font_shadow_blur_radius_number");
    let blur = input.value + "px";

    font_shadow_blur_radius.value = input.value;
    ChangeCSS("font_shadow_blur_radius", blur); 
}

function FontShadowBlurRadiusNumberChanged(input){
    let font_shadow_blur_radius_range = document.getElementById('range_font_shadow_blur_radius');
    let offset = input.value + "px";
    
    font_shadow_blur_radius_range.value = input.value;
    ChangeCSS("font_shadow_blur_radius", offset); 
}


// CHANGE FONT SHADOW COLOR
function FontShadowColorSelector(input){
    let color = input.value;

    ChangeCSS("font_shadow_color", color);
}





//--------------------------------------------------------------------
//----------------STATIC BORDER OPTIONS-------------------------------
//--------------------------------------------------------------------


// CHANGE BORDER COLOR
function BorderColorSelector(input){       
    let color = input.value;

    $("#border_top_color_selector").val(color);
    $("#border_bottom_color_selector").val(color);
    $("#border_left_color_selector").val(color);
    $("#border_right_color_selector").val(color);

    ChangeCSS("border_top_color", color);
    ChangeCSS("border_bottom_color", color);
    ChangeCSS("border_left_color", color);
    ChangeCSS("border_right_color", color);   

}

//CHANGE BORDER TOP COLOR
function BorderTopColorSelector(input){
    let color = input.value;

    ChangeCSS("border_top_color", color);
}

//CHANGE BORDER TOP WIDTH
function BorderTopWidth(input){
    let border_top_width_number = document.getElementById("border_top_width_number"); 
    let width = input.value + "px";

    border_top_width_number.value = input.value;
    ChangeCSS("border_top_width", width);      
}

function BorderTopWidthNumberChanged(input) {
    let border_top_width_range = document.getElementById("border_top_width_range");
    let width = input.value + "px";

    border_top_width_range.value = input.value;
    ChangeCSS("border_top_width", width);
}

//CHANGE BORDER TOP STYLE
function BorderTopStyle(input){
    let style = input.value;

    ChangeCSS("border_top_style", style); 
}

//CHANGE BORDER TOP LEFT RADIUS
function BorderTopLeftRadiusWidth(input){
    let border_top_left_radius_number = document.getElementById("border_top_left_radius_number"); 
    let radius = input.value + "px";

    border_top_left_radius_number.value = input.value;
    ChangeCSS("border_top_left_radius", radius)
}

function BorderTopLeftRadiusWidthNumberChanged(input) {
    let border_top_left_range = document.getElementById("border_top_left_radius_range");
    let radius = input.value + "px";

    border_top_left_range.value = input.value;
    ChangeCSS("border_top_left_radius", radius);
}

//CHANGE BORDER TOP RIGHT RADIUS
function BorderTopRightRadiusWidth(input){
    let border_top_right_radius_number = document.getElementById("border_top_right_radius_number"); 
    let radius = input.value + "px";

    border_top_right_radius_number.value = input.value;
    ChangeCSS("border_top_right_radius", radius)
}

function BorderTopRightRadiusWidthNumberChanged(input) {
    let border_top_right_range = document.getElementById("border_top_right_radius_range");
    let radius = input.value + "px";

    border_top_right_range.value = input.value;
    ChangeCSS("border_top_right_radius", radius);
}

//CHANGE BORDER BOTTOM COLOR
function BorderBottomColorSelector(input){
    let color = input.value;

    ChangeCSS("border_bottom_color", color);
}

//CHANGE BORDER BOTTOM WIDTH
function BorderBottomWidth(input){
    let border_bottom_width_number = document.getElementById("border_bottom_width_number"); 
    let width = input.value + "px";

    border_bottom_width_number.value = input.value ;
    ChangeCSS("border_bottom_width", width);      
}

function BorderBottomWidthNumberChanged(input) {
    let border_bottom_width_range = document.getElementById("border_bottom_width_range");
    let width = input.value + "px";

    border_bottom_width_range.value = input.value;
    ChangeCSS("border_bottom_width", width);
}

//CHANGE BORDER BOTTOM STYLE
function BorderBottomStyle(input){
    let style = input.value;

    ChangeCSS("border_bottom_style", style); 
}

//CHANGE BORDER BOTTOM LEFT RADIUS
function BorderBottomLeftRadiusWidth(input){
    let border_bottom_left_radius_number = document.getElementById("border_bottom_left_radius_number"); 
    let radius = input.value + "px";

    border_bottom_left_radius_number.value = input.value;
    ChangeCSS("border_bottom_left_radius", radius)
}

function BorderBottomLeftRadiusWidthNumberChanged(input) {
    let border_bottom_left_range = document.getElementById("border_bottom_left_radius_range");
    let radius = input.value + "px";

    border_bottom_left_range.value = input.value;
    ChangeCSS("border_bottom_left_radius", radius);
}

//CHANGE BORDER BOTTOM RIGHT RADIUS
function BorderBottomRightRadiusWidth(input){
    let border_bottom_right_radius_number = document.getElementById("border_bottom_right_radius_number"); 
    let radius = input.value + "px";

    border_bottom_right_radius_number.value = input.value;
    ChangeCSS("border_bottom_right_radius", radius)
}

function BorderBottomRightRadiusWidthNumberChanged(input) {
    let border_bottom_right_range = document.getElementById("border_bottom_right_radius_range");
    let radius = input.value + "px";

    border_bottom_right_range.value = input.value;
    ChangeCSS("border_bottom_right_radius", radius);
}

//CHANGE BORDER LEFT COLOR
function BorderLeftColorSelector(input){
    let color = input.value;

    ChangeCSS("border_left_color", color);
}

//CHANGE BORDER LEFT WIDTH
function BorderLeftWidth(input){
    let border_top_width_number = document.getElementById("border_left_width_number"); 
    let width = input.value + "px";

    border_top_width_number.value = input.value;
    ChangeCSS("border_left_width", width);      
}

function BorderLeftWidthNumberChanged(input) {
    let border_left_width_range = document.getElementById("border_left_width_range");
    let width = input.value + "px";

    border_left_width_range.value = input.value;
    ChangeCSS("border_left_width", width);
}

//CHANGE BORDER LEFT STYLE
function BorderLeftStyle(input){
    let style = input.value;

    ChangeCSS("border_left_style", style); 
}

//CHANGE BORDER RIGHT COLOR
function BorderRightColorSelector(input){
    let color = input.value;

    ChangeCSS("border_right_color", color);
}

//CHANGE BORDER RIGHT WIDTH
function BorderRightWidth(input){
    let border_right_width_number = document.getElementById("border_right_width_number"); 
    let width = input.value + "px";

    border_right_width_number.value = input.value;
    ChangeCSS("border_right_width", width);      
}

function BorderRightWidthNumberChanged(input) {
    let border_right_width_range = document.getElementById("border_right_width_range");
    let width = input.value + "px";

    border_right_width_range.value = input.value;
    ChangeCSS("border_right_width", width);
}

//CHANGE BORDER RIGHT STYLE
function BorderRightStyle(input){
    let style = input.value;

    ChangeCSS("border_right_style", style); 
}

//CHANGE BORDER RADIUS
function BorderRadius(input){   
    let span_border_radius = document.getElementById("border_radius_number"); 
    let radius = input.value + "px";

    span_border_radius.innerText = radius;
    ChangeCSS("border_top_left_radius", radius); 
    ChangeCSS("border_top_right_radius", radius);
    ChangeCSS("border_bottom_left_radius", radius);
    ChangeCSS("border_bottom_right_radius", radius);   
    //RANGES 
    $("#border_top_left_radius_range").val(input.value);
    $("#border_top_right_radius_range").val(input.value);
    $("#border_bottom_left_radius_range").val(input.value);
    $("#border_bottom_right_radius_range").val(input.value);
    //SPANS
    $("#border_top_left_radius_number").text(radius);
    $("#border_top_right_radius_number").text(radius);
    $("#border_bottom_left_radius_number").text(radius);
    $("#border_bottom_right_radius_number").text(radius);
}


//CHANGE BORDER RADIUS
function BorderWidth(input){   
    let span_border_width = document.getElementById("border_width_number"); 
    let width = input.value + "px";

    span_border_width.innerText = width;
    ChangeCSS("border_top_width", width); 
    ChangeCSS("border_bottom_width", width);
    ChangeCSS("border_left_width", width); 
    ChangeCSS("border_right_width", width);   
    //RANGES 
    $("#border_top_width_range").val(input.value);
    $("#border_bottom_width_range").val(input.value);
    $("#border_left_width_range").val(input.value);
    $("#border_right_width_range").val(input.value);
    //SPANS
    $("#border_top_width_number").text(width);
    $("#border_bottom_width_number").text(width);
    $("#border_left_width_number").text(width);
    $("#border_right_width_number").text(width);
}

//--------------------------------------------------------------------
//----------------STATIC PADDING OPTIONS------------------------------
//--------------------------------------------------------------------


//CHANGE PADDING TOP
function PaddingTop(input){
     let padding_top_number = document.getElementById("padding_top_number"); 
     let width = input.value + "px";

    padding_top_number.value = input.value;
     ChangeCSS("padding_top", width);      
}

function PaddingTopNumberChanged(input) {
    let padding_top_range = document.getElementById("static_padding_top_range")
    let width = input.value + "px";

    padding_top_range.value = input.value;
    ChangeCSS("padding_top", width);
}


//CHANGE PADDING BOTTOM
function PaddingBottom(input){
    let padding_bottom_number = document.getElementById("padding_bottom_number"); 
    let width = input.value + "px";
   
    padding_bottom_number.value = input.value;
    ChangeCSS("padding_bottom", width);      
}

function PaddingBottomNumberChanged(input) {
    let padding_bottom_range = document.getElementById("static_padding_bottom_range")
    let width = input.value + "px";

    padding_bottom_range.value = input.value;
    ChangeCSS("padding_bottom", width);
}

//CHANGE PADDING LEFT
function PaddingLeft(input){
    let padding_left_number = document.getElementById("padding_left_number"); 
    let width = input.value + "px";
   
    padding_left_number.value = input.value;
    ChangeCSS("padding_left", width);      
}

function PaddingLeftNumberChanged(input) {
    let padding_left_range = document.getElementById("static_padding_left_range")
    let width = input.value + "px";

    padding_left_range.value = input.value;
    ChangeCSS("padding_left", width);
}

//CHANGE PADDING RIGHT
function PaddingRight(input){
    let padding_right_number = document.getElementById("padding_right_number"); 
    let width = input.value + "px";
   
    padding_right_number.value = input.value;
    ChangeCSS("padding_right", width);      
}

function PaddingRightNumberChanged(input) {
    let padding_right_range = document.getElementById("static_padding_right_range")
    let width = input.value + "px";

    padding_right_range.value = input.value;
    ChangeCSS("padding_right", width);
}


//--------------------------------------------------------------------
//----------------STATIC SHADOW OPTIONS-------------------------------
//--------------------------------------------------------------------

//ENABLE STATIC SHADOWS
function StaticShadowEnable(){   
    let check = document.getElementById("checkbox_static_shadow_enable").checked;
    
    
    if(check == true){
        $("#range_box_shadow_offset_x").attr("disabled", false);
        $("#range_box_shadow_offset_y").attr("disabled", false);
        $("#range_box_shadow_blur_radius").attr("disabled", false);
        $("#range_box_shadow_spread_radius").attr("disabled", false); 
        $("#shadow_color_selector").attr("disabled", false);

        $("#box_shadow_offset_x_number").attr("disabled", false);
        $("#box_shadow_offset_y_number").attr("disabled", false);
        $("#box_shadow_blur_radius_number").attr("disabled", false);
        $("#box_shadow_spread_radius_number").attr("disabled", false);
    }
    else{
        ChangeCSS("box_shadow_offset_x", "0px"); 
        ChangeCSS("box_shadow_offset_y", "0px");
        ChangeCSS("box_shadow_blur_radius", "0px"); 
        ChangeCSS("box_shadow_spread_radius", "0px");         
        
        $("#range_box_shadow_offset_x").attr("disabled", true);
        $("#range_box_shadow_offset_y").attr("disabled", true);
        $("#range_box_shadow_blur_radius").attr("disabled", true);
        $("#range_box_shadow_spread_radius").attr("disabled", true); 
        $("#shadow_color_selector").attr("disabled", true);   

        $("#box_shadow_offset_x_number").attr("disabled", true);
        $("#box_shadow_offset_y_number").attr("disabled", true);
        $("#box_shadow_blur_radius_number").attr("disabled", true);
        $("#box_shadow_spread_radius_number").attr("disabled", true);

        $("#range_box_shadow_offset_x").val(0);
        $("#range_box_shadow_offset_y").val(0);
        $("#range_box_shadow_blur_radius").val(0);
        $("#range_box_shadow_spread_radius").val(0);       
        $("#shadow_color_selector").val("#525757");       


        $("#box_shadow_offset_x_number").val(0);
        $("#box_shadow_offset_y_number").val(0);
        $("#box_shadow_blur_radius_number").val(0);
        $("#box_shadow_spread_radius_number").val(0);
    
    }
   
}


//CHANGE BOX SHADOW OFFSET X
function BoxShadowOffsetX(input){
    let box_shadow_offset_x_number = document.getElementById("box_shadow_offset_x_number"); 
    let offset = input.value + "px";

    box_shadow_offset_x_number.value = input.value;
    ChangeCSS("box_shadow_offset_x", offset); 
}

function BoxShadowOffsetXNumberChanged(input){
    let box_shadow_offset_x_range = document.getElementById("range_box_shadow_offset_x");
    let offset = input.value + "px";

    box_shadow_offset_x_range.value = input.value;
    ChangeCSS("box_shadow_offset_x", offset);
}

//CHANGE BOX SHADOW OFFSET Y
function BoxShadowOffsetY(input){
    let box_shadow_offset_y_number = document.getElementById("box_shadow_offset_y_number"); 
    let offset = input.value + "px";
    
    box_shadow_offset_y_number.value = input.value;
    ChangeCSS("box_shadow_offset_y", offset); 
}

function BoxShadowOffsetYNumberChanged(input){
    let box_shadow_offset_y_range = document.getElementById("range_box_shadow_offset_y");
    let offset = input.value + "px";

    box_shadow_offset_y_range.value = input.value;
    ChangeCSS("box_shadow_offset_y", offset);
}

// CHANGE BOX SHADOW BLUR RADIUS
function BoxShadowBlurRadius(input){
    let box_shadow_blur_radius_number = document.getElementById("box_shadow_blur_radius_number");
    let blur = input.value + "px";

    box_shadow_blur_radius_number.value = input.value;
    ChangeCSS("box_shadow_blur_radius", blur); 
}

function BoxShadowBlurRadiusNumberChanged(input){
    let box_shadow_blur_radius_range = document.getElementById("range_box_shadow_blur_radius");
    let offset = input.value + "px";

    box_shadow_blur_radius_range.value = input.value;
    ChangeCSS("box_shadow_blur_radius", offset);
}


// CHANGE BOX SHADOW SPREAD RADIUS
function BoxShadowSpreadRadius(input){
    let box_shadow_spread_radius_number = document.getElementById("box_shadow_spread_radius_number");
    let spread = input.value + "px";

    box_shadow_spread_radius_number.value = input.value;
    ChangeCSS("box_shadow_spread_radius", spread); 
}

function BoxShadowSpreadRadiusNumberChanged(input){
    let box_shadow_spread_radius_range = document.getElementById("range_box_shadow_spread_radius");
    let offset = input.value + "px";

    box_shadow_spread_radius_range.value = input.value;
    ChangeCSS("box_shadow_spread_radius", offset);
}

// CHANGE BOX SHADOW COLOR
function BoxShadowColorSelector(input){
    let color = input.value;

    ChangeCSS("box_shadow_color", color);
}


//--------------------------------------------------------------------
//----------------STATIC SHADOW INSET OPTIONS-------------------------
//--------------------------------------------------------------------

//ENABLE STATIC SHADOWS INSET
function StaticShadowInsetEnable(){   
    let check = document.getElementById("checkbox_static_inset_shadow_enable").checked;
    
    
    if(check == true){
        $("#range_box_shadow_inset_offset_x").attr("disabled", false);
        $("#range_box_shadow_inset_offset_y").attr("disabled", false);
        $("#range_box_shadow_inset_blur_radius").attr("disabled", false);
        $("#range_box_shadow_inset_spread_radius").attr("disabled", false); 
        $("#shadow_inset_color_selector").attr("disabled", false);

        $("#box_shadow_inset_offset_x_number").attr("disabled", false);
        $("#box_shadow_inset_offset_y_number").attr("disabled", false);
        $("#box_shadow_inset_blur_radius_number").attr("disabled", false);
        $("#box_shadow_inset_spread_radius_number").attr("disabled", false);
    }
    else{
        ChangeCSS("box_shadow_inset_offset_x", "0px"); 
        ChangeCSS("box_shadow_inset_offset_y", "0px");
        ChangeCSS("box_shadow_inset_blur_radius", "0px"); 
        ChangeCSS("box_shadow_inset_spread_radius", "0px");         
        
        $("#range_box_shadow_inset_offset_x").attr("disabled", true);
        $("#range_box_shadow_inset_offset_y").attr("disabled", true);
        $("#range_box_shadow_inset_blur_radius").attr("disabled", true);
        $("#range_box_shadow_inset_spread_radius").attr("disabled", true); 
        $("#shadow_inset_color_selector").attr("disabled", true);

        $("#box_shadow_inset_offset_x_number").attr("disabled", true);
        $("#box_shadow_inset_offset_y_number").attr("disabled", true);
        $("#box_shadow_inset_blur_radius_number").attr("disabled", true);
        $("#box_shadow_inset_spread_radius_number").attr("disabled", true);
        
        $("#range_box_shadow_inset_offset_x").val(0);
        $("#range_box_shadow_inset_offset_y").val(0);
        $("#range_box_shadow_inset_blur_radius").val(0);
        $("#range_box_shadow_inset_spread_radius").val(0);       
        $("#shadow_inset_color_selector").val("#525757");       

        $("#box_shadow_inset_offset_x_number").val(0);
        $("#box_shadow_inset_offset_y_number").val(0);
        $("#box_shadow_inset_blur_radius_number").val(0);
        $("#box_shadow_inset_spread_radius_number").val(0);
    
    }
   
}


//CHANGE BOX SHADOW INSET OFFSET X
function BoxShadowInsetOffsetX(input){
    let box_shadow_inset_offset_x_number = document.getElementById("box_shadow_inset_offset_x_number"); 
    let offset = input.value + "px";

    box_shadow_inset_offset_x_number.value = input.value;
    ChangeCSS("box_shadow_inset_offset_x", offset); 
}

function BoxShadowInsetOffsetXNumberChanged(input) {
    let range_box_shadow_inset_offset_x = document.getElementById("range_box_shadow_inset_offset_x");
    let offset = input.value + "px";

    range_box_shadow_inset_offset_x.value = input.value;
    ChangeCSS("box_shadow_inset_offset_x", offset);
}

//CHANGE BOX SHADOW INSET OFFSET Y
function BoxShadowInsetOffsetY(input){
    let box_shadow_inset_offset_y_number = document.getElementById("box_shadow_inset_offset_y_number"); 
    let offset = input.value + "px";
    
    box_shadow_inset_offset_y_number.value = input.value;
    ChangeCSS("box_shadow_inset_offset_y", offset); 
}

function BoxShadowInsetOffsetYNumberChanged(input) {
    let range_box_shadow_inset_offset_y = document.getElementById("range_box_shadow_inset_offset_y");
    let offset = input.value + "px";

    range_box_shadow_inset_offset_y.value = input.value;
    ChangeCSS("box_shadow_inset_offset_y", offset);
}

// CHANGE BOX SHADOW INSET BLUR RADIUS
function BoxShadowInsetBlurRadius(input){
    let box_shadow_inset_blur_radius_number = document.getElementById("box_shadow_inset_blur_radius_number");
    let blur = input.value + "px";

    box_shadow_inset_blur_radius_number.value = input.value;
    ChangeCSS("box_shadow_inset_blur_radius", blur); 
}

function BoxShadowInsetBlurRadiusNumberChanged(input) {
    let range_box_shadow_inset_blur_radius = document.getElementById("range_box_shadow_inset_blur_radius");
    let offset = input.value + "px";

    range_box_shadow_inset_blur_radius.value = input.value;
    ChangeCSS("box_shadow_inset_blur_radius", offset);
}


// CHANGE BOX SHADOW INSET SPREAD RADIUS
function BoxShadowInsetSpreadRadius(input){
    let box_shadow_inset_spread_radius_number = document.getElementById("box_shadow_inset_spread_radius_number");
    let spread = input.value + "px";

    box_shadow_inset_spread_radius_number.value = input.value;
    ChangeCSS("box_shadow_inset_spread_radius", spread); 
}

function BoxShadowInsetSpreadRadiusNumberChanged(input) {
    let range_box_shadow_inset_spread_radius = document.getElementById("range_box_shadow_inset_spread_radius");
    let offset = input.value + "px";

    range_box_shadow_inset_spread_radius.value = input.value;
    ChangeCSS("box_shadow_inset_spread_radius", offset);
}

// CHANGE BOX SHADOW INSET COLOR
function BoxShadowInsetColorSelector(input){
    let color = input.value;

    ChangeCSS("box_shadow_inset_color", color);
}

