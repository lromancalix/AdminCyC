using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace cycContratos.entidades
{
    [DataContract]
    public class Login : Respuesta
    {
        #region Propiedades de la entidad Login
        [DataMember(IsRequired = true)]
        public string usuario { get; set; }
        [DataMember(IsRequired = true)]
        public string contrasena { get; set; } 
        #endregion

        #region Valida que los campos sean correctos
        /// <summary>
        /// Valida si la estructura de la entidad es correcta
        /// </summary>
        /// <returns></returns>
        public bool IsLoginValid()
        {
            bool valor = false;

            if (String.IsNullOrEmpty(this.contrasena))
            {
                this.isError = true;
                this.descripcionRespuesta = MensajeDeRespuesta[1];
            }
            else if (String.IsNullOrEmpty(this.usuario))
            {
                this.isError = true;
                this.descripcionRespuesta = MensajeDeRespuesta[2];
            }

            return valor;
        } 
        #endregion

        #region Diccionario de respuesta para la entidad login.
        /// <summary>
        /// Diccionario de respuesta
        /// </summary>
        public static readonly Dictionary<int, string> MensajeDeRespuesta = new Dictionary<int, string> {
            { 0 , "No se generó ningún error"  } ,
            { 1 , "EL usuario es requerido"    } ,
            { 2 , "La contraseña es requerida" }
        };
        #endregion

    }
}
