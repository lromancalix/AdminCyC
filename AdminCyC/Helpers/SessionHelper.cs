using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AdminCyC.Helpers
{
    public class SessionHelper
    {
        #region ExistUserSesion
        /// <summary>
        /// Valida si existe una sesión activa
        /// </summary>
        /// <returns></returns>
        public static bool ExistUserInSession()
        {
            return HttpContext.Current.User.Identity.IsAuthenticated;
        }
        #endregion

        #region DestroyUserSession
        /// <summary>
        /// Termina la sesión activa
        /// </summary>
        public static void DestroyUserSession()
        {
            FormsAuthentication.SignOut();
        }
        #endregion

        #region GetUser
        /// <summary>
        /// Regresa el id del usuario activo
        /// </summary>
        /// <returns></returns>
        public static int GetUser()
        {
            int userID = 0;

            if (HttpContext.Current.User != null && HttpContext.Current.User.Identity is FormsIdentity)
            {
                FormsAuthenticationTicket ticket = ((FormsIdentity)HttpContext.Current.User.Identity).Ticket;
                if (ticket != null)
                {
                    userID = Convert.ToInt32(ticket.UserData);
                }
            }

            return userID;
        }
        #endregion

        #region AddUserToSession
        /// <summary>
        /// Agrega el id del usuario encontrado a la sesión
        /// </summary>
        /// <param name="id"></param>
        public static void AddUserToSession(string id)
        {
            bool persitent = true;
            var cookie = FormsAuthentication.GetAuthCookie("usuario", persitent);

            cookie.Name = FormsAuthentication.FormsCookieName;
            cookie.Expires = DateTime.Now.AddMonths(3);

            var ticket = FormsAuthentication.Decrypt(cookie.Value);
            var newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, ticket.IssueDate, ticket.Expiration, ticket.IsPersistent, id);

            cookie.Value = FormsAuthentication.Encrypt(newTicket);
            HttpContext.Current.Response.Cookies.Add(cookie);
        } 
        #endregion
    }
}