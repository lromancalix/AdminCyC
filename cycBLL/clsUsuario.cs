using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dto = DtoCyC;
using modelo = cycMODEL;
using cycDAL;
namespace cycBLL
{
   public class clsUsuario
    {
        #region Busqueda de usuarios

        #region Traer todos los usuarios activos, método público
        /// <summary>
        /// Regresa un listado de todos los usuarios activos
        /// </summary>
        /// <returns></returns>
        public static List<dto.Usuario.dtoUsuario> _TraerTodosLosUsuarios()
        {
            return _BuscarUsuario();
        }
        #endregion

        #region Traer usuario por ID, metodo publico
        /// <summary>
        /// Regresa un usuarios con estatus activo = true dependiendo el id de entrada
        /// </summary>
        /// <param name="id">id del usuario a buscar</param>
        /// <returns></returns>
        public static List<dto.Usuario.dtoUsuario> _TraerUsuarioPorID(int id)
        {
            return _BuscarUsuario(id);
        }
        #endregion

        #region Busca usuarios en la base de datos, metodo privado
        /// <summary>
        /// Regresa una lista de usuarios con 1 o más elementos
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private static List<dto.Usuario.dtoUsuario> _BuscarUsuario(int? id = null)
        {
            cycDAL.clsUsuario DALUsuario = new cycDAL.clsUsuario();
         
            List<dto.Usuario.dtoUsuario> listadoUsuarios = new List<dto.Usuario.dtoUsuario>();
            listadoUsuarios = cycDAL.clsUsuario._TraerTodosLosUsuarios();


            //using (modelo.dbCyCEntities contexto = new modelo.dbCyCEntities())
            //{
            //    foreach (var usuario in contexto.tblUsuario.ToList())
            //    {
            //        listadoUsuarios.Add(new dto.Usuario.dtoUsuario
            //        {
            //            usuario = usuario.usuario,
            //            apellidoMaterno = usuario.apellidoMaterno,
            //            apellidoPaterno = usuario.apellidoPaterno,
            //            idUsuario = usuario.idUsuario,
            //            nombre = usuario.nombre
            //        });
            //    }
            //}

            return listadoUsuarios;
        }
        #endregion 

        #endregion

        #region Guarda los datos de un usuario

        #region Recibe los datos de un usuario para actualizarlos o crear un nuevo usuario
        public dto.dtoRespuesta _GuardaUsuario(dto.Usuario.dtoUsuario usuario)
        {
            dto.dtoRespuesta respuesta = _CrearNuevoUsuario(usuario);

            return respuesta;
        }

        #endregion

        #region Crea un nuevo usuario
        /// <summary>
        /// Crea un nuevo usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        private static dto.dtoRespuesta _CrearNuevoUsuario(dto.Usuario.dtoUsuario usuario)
        {
            dto.dtoRespuesta respuesta = new dto.dtoRespuesta("", "", dto.TipoRespuesta.exito);

            return respuesta;
        }

        #endregion

        #region Actualiza los datos de un usuario existente
        /// <summary>
        /// Actualiza los datos de un usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        private static dto.dtoRespuesta _ActualizaUsuario(dto.Usuario.dtoUsuario usuario)
        {
            dto.dtoRespuesta respuesta = new dto.dtoRespuesta("", "", dto.TipoRespuesta.exito);

            return respuesta;
        }

        #endregion

        #endregion
    }
}
