﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using dto = DtoCyC;
using bll = cycBLL;
using contratos = cycContratos;
using DtoCyC.Usuario;

namespace cycServicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "UsuarioService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione UsuarioService.svc o UsuarioService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class UsuarioService : contratos.IUsuario
    {
        public List<dtoUsuario> getTodosLosUsuarios()
        {
            return bll.clsUsuario._TraerTodosLosUsuarios();
        }

        public List<dtoUsuario> getUsuarioPorID(int id)
        {
            return bll.clsUsuario._TraerUsuarioPorID(id);
        }

        public dto.dtoRespuesta setUsuario(dtoUsuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
