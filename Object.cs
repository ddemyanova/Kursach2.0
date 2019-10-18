using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodVision
{
    abstract class Object
    {
        private string Name;
        private Tuple<int, int> Size;
        public Object(Object Obj)
        {
            this.Name = Obj.Name;
            this.Size = Obj.Size;
        }
    }
}
