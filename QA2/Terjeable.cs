using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA2
{
    class Terjeable : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            return new Terjator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
