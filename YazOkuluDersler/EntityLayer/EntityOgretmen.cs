using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    class EntityOgretmen
    {
        private string ogrtid;
        private string ogrtad;
        private int ogrtbrans;

        public string OGRTID { get => ogrtid; set => ogrtid = value; }
        public string OGRTAD { get => ogrtad; set => ogrtad = value; }
        public int OGRTBRANS { get => ogrtbrans; set => ogrtbrans = value; }
    }
}
