var SOL = window.SOL || {};


SOL.Cliente = {
    nombre: $("#txt-nombre"),
    app: $("#txt-app"),
    apm: $("#txt-apm"),
    fechaNacimiento: $("txt-fechaNacimiento"),
    rfc: $("txt-rfc"),
    lstSexo: $("#lst-sexo"),
    lstEdoCivil: $("lst-edoCivil"),
    celLada: $("txt-ladaCel"),
    celNumero: $("#txt-celular"),
    telLada: $("#txt-ladaTel"),
    correo: $("#email"),
    calle: $("#txt-calle"),
    manzana: $("#txt-manzana"),
    lote: $("#txt-lote"),
    ext: $("#txt-Ext"),
    edificio: $("#txt-Edificio"),
    tiempoResidencia: $("#txt-tiempoResidencia"),
    cruzamientos: $("#txt-cruzamientos"),
    cp: $("#txt-CodigoPostal"),
    lstEstado: $("#lst-Estado"),
    lstCiudad: $("#lstCiudad")
}

SOL.Cliente.Empleo = {
    nombreEmpresa: $("#txt-nombreEmpleo"),
    calleEmpleo: $("#txt-calleEmpleo"),
    coloniaEmpleo: $("#txt-coloniaEmpleo"),
    cruzamientosEmpleo: $("#txt-cruzamientoEmpleo"),
    manzanaEmpleo: $("#txt-manzana"),
    loteEmpleo: $("#txt-lote")
}

$(document).ready(function () {

    //IniciaMascaraTexboxFecha();
    
    //alertify.alert("Se trata de un diálogo de alerta");
    $("#btn_GuardaSolicitud").click(function () {

        alert(SOL.Cliente.nombre.val());
        alert(SOL.Cliente.app.val());
       
    });
});