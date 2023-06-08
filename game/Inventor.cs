using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    class Inventor
    {
        private string _name;
        private int _count;
        public int _id;

        static public int _iid = 1;

        public Inventor(string name, int count)
        {
            _name = name;
            _count = count;
            _id = _iid++;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Count
        {
            get => _count;
            set => _count = value;
        }
    }


}
