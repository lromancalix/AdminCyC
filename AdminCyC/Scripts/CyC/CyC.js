var CyC = window.CyC || {};

CyC.app = (function ($, window, document, undefined) {
    Mostrar = function (texto) {
        alert(texto);
    }

    CallJson = function (metodo) {
        alert(metodo);
    }

    /**
      * Autor: Luis Xavier Roman Calix.
      * Descripcion: Inicializa un dialogo modal de bootstrap.
      * Parametros: idModal, id del dialog modal.
      * Implementacion: CyC.app.GetJsonbyAjax("controller/action", data, funtion);
      */
    GetJsonObject = function (action, data, funcionCallBack) {
        //alert(this.GetAppURLHost + action);
        try {
            $.ajax({
                url: action,
                type: "GET",
                data: data,
                contentType: "application/json; charset=utf-8",
                dataType: "JSON",
                success: function (response) {
                    funcionCallBack(response);
                },
                error: function (xhr, ajaxOptions, thrownError) {
                    alert(xhr.status);
                    alert(thrownError);
                    alert(ajaxOptions);
                }
            });
        } catch (e) {
            alert("ERROR: " + e.toString());
        }
    }

    /**
    * Autor: Luis Xavier Roman Calix.
    * Descripcion: Muestra una vista parcial (vp) en un contenedor.
    * Parametros: idModal:  action:Accion del controlador a llamar
                            idContent:id del contenedor donde se muestra la vp.
                            data: datos que se envian a la accion del controlador.
    */
    OpenPartialView = function (action,  data) {
        $.ajax({
            url:  action,
            type: "POST",
            async: false,
            data: data,
            success: function (result) {
                
            },
            error: function (xhr, ajaxOptions, thrownError) {
                alert(JSON.stringify("Ocurrio un error al procesar la peticion."));
            }
        });
    }

    /**
     * Autor: LXRC
     * Descrip: Metodo para regresar el URL del host
     */
    var GetAppURLHost = function ( numero )
    {
        url_site = document.location.href;
        url_pos = url_site.indexOf('//');
        url_limpia = url_site.substr(url_pos + 2);
        url_prot = url_site.substr(0, url_pos + 2);
        url_split = url_limpia.split('/');
        switch (numero) {
            case 1:
                url_base = url_prot + url_split[0] + '/' + url_split[1] + '/'
                break;
            case 2:

                break;
            default:
                url_base = url_prot + url_split[0] + '/' + url_split[1] + '/';
                break;
        }
        return url_base;
    }

    /**
     * Autor: LXRC
     * Descrip: Metodo para validar los campos de un formulario
     */
    var IsContentValid = function (idContenedor)
    {
        return $("#" + idContenedor).validationEngine("validate");
    }

    /**
     * Autor: LXRC
     * Descrip: Valida si la tecla presionada fue un enter
     */
    var IsKeyPressEnter = function (e)
    {
        var key = e.charCode || e.keyCode;
        return (key == 13) ? true : false;
    }

    var InitModal = function (idModal)
    {
        $("#" + idModal).modal("hide");
    }

    var ShowModal = function (idModal)
    {
        $("#" + idModal).modal("show");
    }

    return {
        Mostrar: Mostrar,
        IsContentValid: IsContentValid,
        IsKeyPressEnter: IsKeyPressEnter,
        OpenPartialView: OpenPartialView,
        CallJson: CallJson,
        GetJsonObject: GetJsonObject,
        GetAppURLHost: GetAppURLHost,
        InitModal: InitModal,
        ShowModal: ShowModal
    }
}(jQuery, window, document, navigator, undefined));

