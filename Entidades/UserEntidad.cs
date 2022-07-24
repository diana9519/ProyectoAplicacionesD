using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class UserEntidad
    {
        public int ID_USER { get; set; }
        public string NAME_USER { get; set; }
        public string LAST_USER { get; set; }
        public string USER_USER { get; set; }
        public string PASSWORD_USER { get; set; }
        public int ID_OFFICE_USER { get; set; }
        public string OFFICE_USER { get; set; }
        public UserEntidad()
        {
        }
        public UserEntidad(int iD_USER, string nAME_USER, string lAST_USER, string uSER_USER, string pASSWORD_USER, int iD_OFFICE_USER, string oFFICE_USER)
        {
            ID_USER = iD_USER;
            NAME_USER = nAME_USER;
            LAST_USER = lAST_USER;
            USER_USER = uSER_USER;
            PASSWORD_USER = pASSWORD_USER;
            ID_OFFICE_USER = iD_OFFICE_USER;
            OFFICE_USER = oFFICE_USER;
        }
    }
}
