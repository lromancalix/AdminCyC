function IniciaMascaraTexboxFecha() {
    CyC.app.InitDateFormat();
}

$(document).ready(function () {

    IniciaMascaraTexboxFecha();
    
    alertify.alert("Se trata de un diálogo de alerta");
});