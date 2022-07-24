using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class UserDatos
    {
        public static UserEntidad Crear(UserEntidad user)
        {
            try
            {
                USER_OFFICE newUser = new USER_OFFICE();
                newUser.ID_USER = 0;
                newUser.NAME_USER = user.NAME_USER;
                newUser.LAST_USER = user.LAST_USER;
                newUser.USER_USER = user.USER_USER;
                newUser.PASSWORD_USER = user.PASSWORD_USER;
                newUser.ID_OFFICE_USER = user.ID_OFFICE_USER;

                using (var ctx = new ProyectoFinal())
                {
                    ctx.USER_OFFICE.Add(newUser);
                    ctx.SaveChanges();
                }
                user.ID_USER = newUser.ID_USER;
                return user;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static UserEntidad Editar(UserEntidad user)
        {
            try
            {
                USER_OFFICE newUser = new USER_OFFICE();
                newUser.ID_USER = user.ID_USER;
                newUser.NAME_USER = user.NAME_USER;
                newUser.LAST_USER = user.LAST_USER;
                newUser.USER_USER = user.USER_USER;
                newUser.PASSWORD_USER = user.PASSWORD_USER;
                newUser.ID_OFFICE_USER = user.ID_OFFICE_USER;

                using (var ctx = new ProyectoFinal())
                {
                    ctx.USER_OFFICE.AddOrUpdate(newUser);
                    ctx.SaveChanges();
                }
                return user;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static List<UserEntidad> Listar()
        {

            try
            {
                var lista = new List<UserEntidad>();

                using (var ctx = new ProyectoFinal())
                {
                    var listaResultado = ctx.USER_OFFICE.ToList();
                    foreach (var item in listaResultado)
                    {
                        lista.Add(new UserEntidad(
                            item.ID_USER,
                            item.NAME_USER,
                            item.LAST_USER,
                            item.USER_USER,
                            item.PASSWORD_USER,
                            item.ID_OFFICE_USER,
                           OfficeDatos.Buscar(item.ID_OFFICE_USER).NAME_OFFICE));
                    }
                }
                return lista;

            }
            catch (Exception)
            {
                return null;
            }

        }
        public static bool Borrar(int id)
        {
            try
            {
                using (var ctx = new ProyectoFinal())
                {
                    var usuarioEliminar = ctx.USER_OFFICE.FirstOrDefault(u => u.ID_USER == id);
                    ctx.USER_OFFICE.Remove(usuarioEliminar);
                    ctx.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static UserEntidad Buscar(int id)
        {
            UserEntidad userFound = new UserEntidad();
            try
            {
                using (var ctx = new ProyectoFinal())
                {
                    var usuarioBaseFound = ctx.USER_OFFICE.FirstOrDefault(u => u.ID_USER == id);
                    userFound.ID_USER = usuarioBaseFound.ID_USER;
                    userFound.NAME_USER = usuarioBaseFound.NAME_USER;
                    userFound.LAST_USER = usuarioBaseFound.LAST_USER;
                    userFound.USER_USER = usuarioBaseFound.USER_USER;
                    userFound.PASSWORD_USER = usuarioBaseFound.PASSWORD_USER;
                    userFound.ID_OFFICE_USER = usuarioBaseFound.ID_OFFICE_USER;
                    userFound.OFFICE_USER = OfficeDatos.Buscar(usuarioBaseFound.ID_OFFICE_USER).NAME_OFFICE;
                    return userFound;
                }
            }
            catch (Exception)
            {
                return null;
            }

        }
        public static UserEntidad Verificar(string user, string pass)
        {
            try
            {
                UserEntidad userFound = new UserEntidad();

                using (var ctx = new ProyectoFinal())
                {
                    var userCheck = ctx.USER_OFFICE.FirstOrDefault(u => u.USER_USER == user && u.PASSWORD_USER == pass);
                    userFound.ID_USER = userCheck.ID_USER;
                    userFound.NAME_USER = userCheck.NAME_USER;
                    userFound.LAST_USER = userCheck.LAST_USER;
                    userFound.USER_USER = userCheck.USER_USER;
                    userFound.PASSWORD_USER = userCheck.PASSWORD_USER;
                    userFound.ID_OFFICE_USER = userCheck.ID_OFFICE_USER;
                    userFound.OFFICE_USER = OfficeDatos.Buscar(userCheck.ID_OFFICE_USER).NAME_OFFICE;

                    return userFound;
                }

            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
