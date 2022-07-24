using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetailEntidad
    {
        public int ID_DETAIL { get; set; }
        public string DATE_DETAIL { get; set; }
        public int ID_USER_DETAIL { get; set; }
        public string USER_DETAIL { get; set; }
        public int USER_SUCURSAL_ID_DETAIL { get; set; }
        public string USER_SUCURSAL_DETAIL { get; set; }
        public string LOCATION_DETAIL { get; set; }

        public DetailEntidad()
        {
        }

        public DetailEntidad(int iD_DETAIL, string dATE_DETAIL, int iD_USER_DETAIL, string uSER_DETAIL, int uSER_SUCURSAL_ID_DETAIL, string uSER_SUCURSAL_DETAIL, string lOCATION_DETAIL)
        {
            ID_DETAIL = iD_DETAIL;
            DATE_DETAIL = dATE_DETAIL;
            ID_USER_DETAIL = iD_USER_DETAIL;
            USER_DETAIL = uSER_DETAIL;
            USER_SUCURSAL_ID_DETAIL = uSER_SUCURSAL_ID_DETAIL;
            USER_SUCURSAL_DETAIL = uSER_SUCURSAL_DETAIL;
            LOCATION_DETAIL = lOCATION_DETAIL;
        }
    }
}
