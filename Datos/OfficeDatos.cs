using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class OfficeDatos
    {
        public static OfficeEntidad Crear(OfficeEntidad office)
        {
            try
            {
                OFFICE newOffice = new OFFICE();
                newOffice.ID_OFFICE = 0;
                newOffice.NAME_OFFICE = office.NAME_OFFICE;
                newOffice.DIR_OFFICE = office.DIR_OFFICE;
                newOffice.PHONE_OFFICE = office.PHONE_OFFICE;



                using (var ctx = new ProyectoFinal())
                {
                    ctx.OFFICE.Add(newOffice);
                    ctx.SaveChanges();
                }
                office.ID_OFFICE = newOffice.ID_OFFICE;
                return office;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static OfficeEntidad Editar(OfficeEntidad office)
        {
            try
            {
                OFFICE newOffice = new OFFICE();
                newOffice.ID_OFFICE = office.ID_OFFICE;
                newOffice.NAME_OFFICE = office.NAME_OFFICE;
                newOffice.DIR_OFFICE = office.DIR_OFFICE;
                newOffice.PHONE_OFFICE = office.PHONE_OFFICE;

                using (var ctx = new ProyectoFinal())
                {
                    ctx.OFFICE.AddOrUpdate(newOffice);
                    ctx.SaveChanges();
                }
                return office;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static List<OfficeEntidad> Listar()
        {
            try
            {
                var lista = new List<OfficeEntidad>();

                using (var ctx = new ProyectoFinal())
                {
                    var listaResultado = ctx.OFFICE.ToList();
                    foreach (var item in listaResultado)
                    {
                        lista.Add(new OfficeEntidad(item.ID_OFFICE, item.NAME_OFFICE, item.PHONE_OFFICE, item.DIR_OFFICE));
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
                    var officeFound = ctx.OFFICE.FirstOrDefault(u => u.ID_OFFICE == id);
                    ctx.OFFICE.Remove(officeFound);
                    ctx.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static OfficeEntidad Buscar(int id)
        {
            OfficeEntidad officeFound = new OfficeEntidad();
            try
            {
                using (var ctx = new ProyectoFinal())
                {
                    var officeBaseFound = ctx.OFFICE.FirstOrDefault(u => u.ID_OFFICE == id);
                    officeFound.ID_OFFICE = officeBaseFound.ID_OFFICE;
                    officeFound.NAME_OFFICE = officeBaseFound.NAME_OFFICE;
                    officeFound.DIR_OFFICE = officeBaseFound.DIR_OFFICE;
                    officeFound.PHONE_OFFICE = officeBaseFound.PHONE_OFFICE;

                    return officeFound;
                }
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}
