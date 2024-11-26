

// JScript File

// function that selects a begining field
function InitialSelect(objID)
{
    document.getElementById(objID).select();
}

//var newWin=null;
//function popUP(URL,W,H)
//{
//	if (newWin && newWin.open && !newWin.closed)
//	{
//        newWin.location.href=URL;	
//        newWin.focus();
//	}
//	else
//	{			 
//	    L=(screen.width/2)-(W/2);
//	    T=(screen.height/2)-(H/2);			 				 
//        newWin=window.open(URL, 'newWin1', "resizable=yes,scrollbars=yes,width="+W+",height="+H+",top="+T+",left="+L);	
//        newWin.focus();
//	}
//}
//function PopUp1(url, width, height)
//    {
//        if (newWin && newWin.open && !newWin.closed)
//            newWin.location.href = url;
//        else
//        {
//            var left = (screen.width / 2) - (width / 2);
//            var top = (screen.height / 2) - (height / 2);
//            newWin = window.open(url, "newWin", "resizable=1, width=" + width + ", height=" + height + ", top=" + top + ", left=" + left);
//        }

//        newWin.focus();
//        }

function Mayusculas()
{
var tt = document.getElementById('ctl00_ContentPlaceHolder1_TextBoxNombreGrupo').value.toUpperCase();
document.getElementById('ctl00_ContentPlaceHolder1_TextBoxNombreGrupo').value = tt;
return false;
}

function MayusculasLogin()
{
var tt = document.getElementById('ctl00_ContentPlaceHolder1_TextBoxUsuario').value.toUpperCase();
document.getElementById('ctl00_ContentPlaceHolder1_TextBoxUsuario').value = tt;
return false;
}

function select()
{
alert(" !No hay registro seleccionado...!");
return false;
}

function Complete()
{
alert("Se ha guardado la pregunta correctamente.");
return false;
}
function comit() {
    alert("Se ha guardado correctamente.");
    return false;
}
function CompleteNot() {
    alert("Error no se guardó la pregunta correctamente intente de nuevo.");
    return false;
}

function Realizado()
{
alert(" !Imposible borrar examen ya fué contestado¡");
return false;
}
function ExisteUser()
{
alert(" !Este usuario ya exíste¡");
return false;
}

function regresar()
{
window.history.back(-2);
}

function seguro(URL){
    if(confirm("Esta seguro que desea borrar?")){
    location=URL;
    }
}

function sure(){
    if(confirm("¿Está seguro que desea borrar los registros marcados?"))
    return true; 
    else 
    return false;   
    
}

function horror(){
    if(confirm("¿No se ha podido realizar los cambios comuniquese a la UNITEL de C4 a la Extención:10014?"))
    return true; 
    else 
    return false;   
    
}

function horrores() {
    if (confirm("¿Se ha envíado el error para analizarlo y resolverse ó comuniquese a UNITEL de C4 a la Extención:10014"))
        return true;
    else
        return false;

}
function Guardado() {
    if (confirm("¿Se ha guardado correctamente el registro"))
        return true;
    else
        return false;

}
function testing(d)
{
var g=d;
alert(g);
return 0;

}

function repetido()
{

alert("La oportunidad ya fué registrada seleccione otra por favor. ");
return 0;

}






//function Continuar(){
//    if(confirm("¿Está seguro que desea realizar la accion marcada?"))
//    return true; 
//    else 
//    return false;       
//}

//function OnlyNumbers(evento)
//{
//    var charCode = (evento.which) ? evento.which : event.keyCode;

//    // numeros 0 al 9 punto punto backspace supr numeros 0 al 9 flechas tab
//    if (!(((charCode >= 48) && (charCode <= 57)) || (charCode == 190) || (charCode == 110) || (charCode == 8) || (charCode == 46) || ((charCode >= 96) && (charCode <= 105)) || ((charCode >= 37) && (charCode <= 40)) || (charCode == 9)))
//    event.returnValue = false;
//}

//function OnlyTab(evento)
//{
//    var charCode = (evento.which) ? evento.which : event.keyCode;

//    if(!(charCode == 9))
//    event.returnValue = false;
//}



