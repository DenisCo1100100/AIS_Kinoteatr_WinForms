using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS_Kinoteatr
{

    class Identification
    {
        public string Login { get; set; }

        public Identification()
        {
            Login = "denis"; // тут вытащим из БД
        }
    }
}
