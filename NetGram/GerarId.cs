using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetGram
{
    public class GerarId
    {
        public int id = 0;

        public int ID { get; private set; }

        public ID(int id)
        {
            ID = id;

        }
        public int CriaID()
        {
            return id++;
        }

    }
}
