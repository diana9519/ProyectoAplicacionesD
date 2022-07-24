using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class UserNegocio
    {
        public static UserEntidad CrearUserNegocio(UserEntidad user)
        {
            return UserDatos.Crear(user);
        }
        public static UserEntidad EditarUserNegocio(UserEntidad user)
        {
            return UserDatos.Editar(user);
        }
        public static List<UserEntidad> ListarUserNegocio()
        {
            return UserDatos.Listar();
        }
        public static bool BorrarUserNegocio(int id)
        {
            return UserDatos.Borrar(id);
        }
        public static UserEntidad BuscarUserNegocio(int id)
        {
            return UserDatos.Buscar(id);
        }
        public static UserEntidad VerificarUserNegocio(string user, string pass)
        {
            return UserDatos.Verificar(user, pass);
        }
    }
}
