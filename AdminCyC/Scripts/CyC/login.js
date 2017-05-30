function _ValidaUsuario() {
    if (CyC.app.IsContentValid('loginForm'))
    {
        var usuario = $('#txtUsuario').val();
        var contrasena = $('#txtContrasena').val();
        var userDataLogin = {
            usuario: usuario,
            contrasena: contrasena
        }
        

        var token = _GetToken();

        var cadenaJson = JSON.stringify(userDataLogin);
        var datos = {
            __RequestVerificationToken: token,
            userDataLogin: cadenaJson
        };

        var path = CyC.app.GetAppURLHost() + 'Login/LoginUser';
        CyC.app.GetJsonObject(path, datos, function (response)
        {
            _MostrarRespuesta(response);
        });

     
    }
}

function _MostrarRespuesta( response )
{
    var cadenaJson = JSON.stringify(response, null, 2);
    var respuestaJson = JSON.parse(cadenaJson);

    if (respuestaJson.tipoRespuesta == 1) {
        window.location.href = CyC.app.GetAppURLHost() +'Home/Index';
    }
}

function _GetToken() {
    var token = $('input[name = "__RequestVerificationToken"]');
    return $(token).val();
}


$(document).ready(function () {
    $('#btnLogin').click(function () {
        _ValidaUsuario();
    });

    $('#txtUsuario').focus();
    $('#txtUsuario').keydown(function (e) {
        if (CyC.app.IsKeyPressEnter(e)) {
            $('#txtContrasena').focus();
        }
    });

    $('#txtContrasena').keydown(function (e)
    {
        if (CyC.app.IsKeyPressEnter(e))
        {
            $('#btnLogin').trigger('click');
        }
    });

});