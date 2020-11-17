using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS_Kinoteatr
{
    class Registration : BaseConection
    {
        public Registration(string login, string password, string fullName, string position)
            : base(login, password, fullName, position) {}

        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
