using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class OfficeEntidad
    {
        public int ID_OFFICE { get; set; }
        public string NAME_OFFICE { get; set; }
        public string PHONE_OFFICE { get; set; }
        public string DIR_OFFICE { get; set; }

        public OfficeEntidad()
        {
        }

        public OfficeEntidad(int iD_OFFICE, string nAME_OFFICE, string pHONE_OFFICE, string dIR_OFFICE)
        {
            ID_OFFICE = iD_OFFICE;
            NAME_OFFICE = nAME_OFFICE;
            PHONE_OFFICE = pHONE_OFFICE;
            DIR_OFFICE = dIR_OFFICE;
        }
    }
}
