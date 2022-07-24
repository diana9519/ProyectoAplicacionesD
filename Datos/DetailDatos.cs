using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class DetailDatos
    {
        public static DetailEntidad Crear(DetailEntidad detail)
        {
            try
            {
                OFFICE_DETAIL newDetail = new OFFICE_DETAIL();
                newDetail.ID_DETAIL = 0;
                newDetail.DATE_DETAIL = DateTime.Parse(detail.DATE_DETAIL);
                newDetail.ID_USER_DETAIL = detail.ID_USER_DETAIL;
                newDetail.LOCATION_DETAIL = detail.LOCATION_DETAIL;


                using (var ctx = new ProyectoFinal())
                {
                    ctx.OFFICE_DETAIL.Add(newDetail);
                    ctx.SaveChanges();
                }
                detail.ID_DETAIL = newDetail.ID_DETAIL;
                return detail;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static DetailEntidad Editar(DetailEntidad detail)
        {
            try
            {
                OFFICE_DETAIL newDetail = new OFFICE_DETAIL();
                newDetail.ID_DETAIL = detail.ID_DETAIL;
                newDetail.DATE_DETAIL = DateTime.Parse(detail.DATE_DETAIL);
                newDetail.ID_USER_DETAIL = detail.ID_USER_DETAIL;
                newDetail.LOCATION_DETAIL = detail.LOCATION_DETAIL;

                using (var ctx = new ProyectoFinal())
                {
                    ctx.OFFICE_DETAIL.AddOrUpdate(newDetail);
                    ctx.SaveChanges();
                }
                return detail;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static List<DetailEntidad> Listar()
        {
            try
            {
                var lista = new List<DetailEntidad>();

                using (var ctx = new ProyectoFinal())
                {
                    var listaResultado = ctx.OFFICE_DETAIL.OrderByDescending(c => c.DATE_DETAIL).ToList();
                    foreach (var item in listaResultado)
                    {
                        var user = UserDatos.Buscar(item.ID_USER_DETAIL);
                        lista.Add(new DetailEntidad(
                            item.ID_DETAIL,
                            item.DATE_DETAIL.ToString("dd/MM/yyyy HH:mm:ss"),
                            item.ID_USER_DETAIL,
                            user.USER_USER,
                            user.ID_OFFICE_USER,
                            OfficeDatos.Buscar(user.ID_OFFICE_USER).NAME_OFFICE,
                            item.LOCATION_DETAIL)
                            );
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
                    var detailFound = ctx.OFFICE_DETAIL.FirstOrDefault(u => u.ID_DETAIL == id);
                    ctx.OFFICE_DETAIL.Remove(detailFound);
                    ctx.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static DetailEntidad Buscar(int id)
        {
            DetailEntidad detailFound = new DetailEntidad();
            try
            {
                using (var ctx = new ProyectoFinal())
                {
                    var detailBaseFound = ctx.OFFICE_DETAIL.FirstOrDefault(u => u.ID_DETAIL == id);
                    detailFound.ID_DETAIL = detailBaseFound.ID_DETAIL;
                    detailFound.DATE_DETAIL = detailBaseFound.DATE_DETAIL.ToString("dd/MM/yyyy HH:mm:ss");
                    detailFound.ID_USER_DETAIL = detailBaseFound.ID_USER_DETAIL;
                    detailFound.LOCATION_DETAIL = detailBaseFound.LOCATION_DETAIL;

                    var user = UserDatos.Buscar(detailBaseFound.ID_USER_DETAIL);

                    detailFound.USER_DETAIL = user.USER_USER;
                    detailFound.USER_SUCURSAL_DETAIL = OfficeDatos.Buscar(user.ID_OFFICE_USER).NAME_OFFICE;
                    detailFound.USER_SUCURSAL_ID_DETAIL = user.ID_OFFICE_USER;

                    return detailFound;
                }
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}
