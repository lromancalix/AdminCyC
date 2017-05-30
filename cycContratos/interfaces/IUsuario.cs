using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dto = DtoCyC;
using bll = cycBLL;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace cycContratos
{
    [ServiceContract]
    public interface IUsuario
    {
        [OperationContract]
        List<dto.Usuario.dtoUsuario> getTodosLosUsuarios();

        [OperationContract]
        List<dto.Usuario.dtoUsuario> getUsuarioPorID(int id);

        [OperationContract]
        dto.dtoRespuesta setUsuario(dto.Usuario.dtoUsuario usuario);
    }
}
