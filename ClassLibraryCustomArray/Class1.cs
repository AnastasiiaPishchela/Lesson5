using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCustomArray
{
    public class CustomaArray
    {
        int[] array;
        public int Lenght { get { return array.Length; } }
        public int start;
        public int end;

        public CustomaArray(int start, int end)
        {
            this.start = start;
            this.end = end;
            array = new int[end - start + 1];
        }
        public int this[int index]
        {
            get { return array[index - start]; }
            set { array[index - start] = value; }
        }
    }
}
