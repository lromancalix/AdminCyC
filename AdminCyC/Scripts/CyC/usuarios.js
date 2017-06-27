function UpdateCreateUser() {
    if (CyC.app.IsContentValid("div-datosUsuario")) {
        var path = CyC.app.GetAppURLHost() + "Usuarios/UpdateCreateUser"
       
        CyC.app.GetJsonObject(path, GetUserData(), function (response) { ResponseAjaxUser(response);  });
    }
}

function GetUserData() {
    var usuario = {
        idUsuario: "0",
        usuario: $("#txt-usuario").val().toString(),
        contrasena: $("#txt-contrasena").val().toString(),
        nombre: $("#txt-nombre").val().toString(),
        apellidoPaterno: $("#txt-app").val().toString(),
        apellidoMaterno: $("#txt-apm").val().toString(),
        fechaCreacion: "",
        idRol: ""
    };
    var cadenaJson = JSON.stringify(usuario);
    var datos = { usuario: cadenaJson };
    return datos;
}

function ResponseAjaxUser(response) {

}


$(document).ready(function () {

    CyC.app.InitModal("myModal");

    /*botones*/
    $("#btn-nuevoUsuario").click(function () {
        $("#div-datosUsuario").validationEngine("hide");
        CyC.app.ShowModal("myModal");
    });

    $("#btn-eliminarUsuario").click(function () {
        alert("Click eliminar");
    });

    $("#btn-guardarUsuario").click(function (e) {
        e.preventDefault(); // <------------------ stop default behaviour of button
        UpdateCreateUser();
    });



});