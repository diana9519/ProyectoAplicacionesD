using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class DetailNegocio
    {
        public static DetailEntidad CrearDetailNegocio(DetailEntidad detail)
        {
            return DetailDatos.Crear(detail);
        }
        public static DetailEntidad EditarDetailNegocio(DetailEntidad detail)
        {
            return DetailDatos.Editar(detail);
        }
        public static List<DetailEntidad> ListarDetailNegocio()
        {
            return DetailDatos.Listar();
        }
        public static bool BorrarDetailNegocio(int id)
        {
            return DetailDatos.Borrar(id);
        }
        public static DetailEntidad BuscarDetailNegocio(int id)
        {
            return DetailDatos.Buscar(id);
        }
    }
}
