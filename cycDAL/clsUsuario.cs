using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dto = DtoCyC;
using modelo = cycMODEL;
namespace cycDAL
{
    public class clsUsuario
    {
        public static List<dto.Usuario.dtoUsuario> _TraerTodosLosUsuarios()
        {
            return _BuscarUsuario();
        }
        private static List<dto.Usuario.dtoUsuario> _BuscarUsuario(int? id = null)
        {
            List<dto.Usuario.dtoUsuario> listadoUsuarios = new List<dto.Usuario.dtoUsuario>();
         
            using (modelo.dbCyCEntities contexto = new modelo.dbCyCEntities())
            {
                foreach (var usuario in contexto.tblUsuario.ToList())
                {
                    listadoUsuarios.Add(new dto.Usuario.dtoUsuario
                    {
                        usuario = usuario.usuario,
                        apellidoMaterno = usuario.apellidoMaterno,
                        apellidoPaterno = usuario.apellidoPaterno,
                        idUsuario = usuario.idUsuario,
                        nombre = usuario.nombre
                    });
                }
            }

            return listadoUsuarios;
        }
    }
}
