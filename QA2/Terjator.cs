using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA2
{
    class Terjator : IEnumerator<int>
    {

        public bool MoveNext()
        {
            Current *= 2;
            return true;
        }

        public void Reset()
        {
            Current = 1;
        }

        public int Current { get; private set; } = 1;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }
    }
}
