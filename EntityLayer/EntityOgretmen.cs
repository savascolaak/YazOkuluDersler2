using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    public class EntityOgretmen
    {
        private int ogrtid;
        private string ogrtad;
        private int ogrtBrans;

        public int Ogrtid { get => ogrtid; set => ogrtid = value; }
        public string Ogrtad { get => ogrtad; set => ogrtad = value; }
        public int OgrtBrans { get => ogrtBrans; set => ogrtBrans = value; }
    }
}
