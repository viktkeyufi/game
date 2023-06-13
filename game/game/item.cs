using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    class item : ICloneable
    {
        public string name;
        public int Id;
        public bool stack;
        public int count;

        public item(string name, int Id, bool stack, int count=1)
        {
            this.name = name;
            this.Id = Id;
            this.stack = stack;
            this.count = count;
        }

        public object Clone()
        {
            return this;
        }
    }
}
