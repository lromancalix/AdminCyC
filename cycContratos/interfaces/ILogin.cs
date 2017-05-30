using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using contratos = cycContratos;

namespace cycContratos.interfaces
{
    [ServiceContract]
    public interface ILogin
    {
        contratos.entidades.Usuario AutenticaUsuario(contratos.entidades.Login usuario); 
    }
}
