using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalutinisAtsiskaitymas
{
    class UName
    {
        static string Uname;
        public static string uname
        {
            get
            {
                return Uname;
            }
            set
            {
                Uname = value;
            }
        }

        static int UId;
        public static int uId
        {
            get
            {
                return UId;
            }
            set
            {
                UId = value;
            }
        }

        static string Pname;
        public static string pname
        {
            get
            {
                return Pname;
            }
            set
            {
                Pname = value;
            }
        }
    }
}
