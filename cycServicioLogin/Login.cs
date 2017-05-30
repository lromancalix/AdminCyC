using contratos = cycContratos;

namespace cycServicioLogin
{
    public class Login : contratos.interfaces.ILogin
    {
        public contratos.entidades.Usuario AutenticaUsuario(contratos.entidades.Login usuarioLogin)
        {
            contratos.entidades.Usuario usuarioAtenticado = new contratos.entidades.Usuario();
            usuarioLogin.IsLoginValid();

            usuarioAtenticado.isError = usuarioLogin.isError;
            usuarioAtenticado.descripcionRespuesta = usuarioLogin.descripcionRespuesta;

            if (!usuarioLogin.isError)
            {

            }
            
            return usuarioAtenticado;
        }
    }
}
