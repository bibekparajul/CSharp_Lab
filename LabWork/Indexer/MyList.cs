using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    internal class MyList
    {
        private int[] _arr;

        public MyList(int size)
        {
            _arr = new int[size];
        }
        public int this[int idx]
        {
            get
            {

                return _arr[idx];
            }
            set
            {
                _arr[idx] = value;
            }
        }
    }
}
