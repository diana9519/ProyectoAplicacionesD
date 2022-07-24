using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class OfficeNegocio
    {
        public static OfficeEntidad CrearOfficeNegocio(OfficeEntidad office)
        {
            return OfficeDatos.Crear(office);
        }
        public static OfficeEntidad EditarOfficeNegocio(OfficeEntidad office)
        {
            return OfficeDatos.Editar(office);
        }
        public static List<OfficeEntidad> ListarOfficeNegocio()
        {
            return OfficeDatos.Listar();
        }
        public static bool BorrarOfficeNegocio(int id)
        {
            return OfficeDatos.Borrar(id);
        }
        public static OfficeEntidad BuscarOfficeNegocio(int id)
        {
            return OfficeDatos.Buscar(id);
        }

    }
}
