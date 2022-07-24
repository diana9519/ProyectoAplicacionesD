using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entidades;
using Negocio;

using System.ServiceModel.Web;

namespace Servicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServices" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServices
    {


        /// <summary>
        /// servicios para usuarios
        /// </summary>
        [OperationContract]
        [WebInvoke(UriTemplate = "makeUser",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            Method = "POST")]
        UserEntidad CrearUserService(UserEntidad user);

        [OperationContract]
        [WebInvoke(UriTemplate = "editUser",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            Method = "POST")]
        UserEntidad EditarUserService(UserEntidad user);

        [OperationContract]
        [WebGet(UriTemplate = "users",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        List<UserEntidad> ListarUserService();

        [OperationContract]
        [WebGet(UriTemplate = "deleteUser?id={id}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        bool BorrarUserService(int id);

        [OperationContract]
        [WebGet(UriTemplate = "searchUser?id={id}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        UserEntidad BuscarUserService(int id);

        [OperationContract]
        [WebGet(UriTemplate = "checkUser?user={user}&pass={pass}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        UserEntidad VerificarUserService(string user, string pass);

        /// <summary>
        /// servicios para sucursal
        /// </summary>
        [OperationContract]
        [WebInvoke(UriTemplate = "makeOffice",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
           Method = "POST")]
        OfficeEntidad CrearOfficeService(OfficeEntidad office);

        [OperationContract]
        [WebInvoke(UriTemplate = "editOffice",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
           Method = "POST")]
        OfficeEntidad EditarOfficeService(OfficeEntidad office);


        [OperationContract]
        [WebGet(UriTemplate = "offices",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        List<OfficeEntidad> ListarOfficeService();

        [OperationContract]
        [WebGet(UriTemplate = "deleteOffice?id={id}",
          RequestFormat = WebMessageFormat.Json,
          ResponseFormat = WebMessageFormat.Json)]
        bool BorrarOfficeService(int id);

        [OperationContract]
        [WebGet(UriTemplate = "searchOffice?id={id}",
          RequestFormat = WebMessageFormat.Json,
          ResponseFormat = WebMessageFormat.Json)]
        OfficeEntidad BuscarOfficeService(int id);

        /// <summary>
        /// servicios para notificaciones
        /// </summary>
        [OperationContract]
        [WebInvoke(UriTemplate = "makeNotify",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
           Method = "POST")]
        DetailEntidad CrearDetailService(DetailEntidad detail);

        [OperationContract]
        [WebInvoke(UriTemplate = "editNotify",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
           Method = "POST")]
        DetailEntidad EditarDetailService(DetailEntidad detail);


        [OperationContract]
        [WebGet(UriTemplate = "notifications",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        List<DetailEntidad> ListarDetailService();

        [OperationContract]
        [WebGet(UriTemplate = "deleteNotify?id={id}",
          RequestFormat = WebMessageFormat.Json,
          ResponseFormat = WebMessageFormat.Json)]
        bool BorrarDetailService(int id);

        [OperationContract]
        [WebGet(UriTemplate = "searchNotify?id={id}",
          RequestFormat = WebMessageFormat.Json,
          ResponseFormat = WebMessageFormat.Json)]
        DetailEntidad BuscarDetailService(int id);
    }
}

