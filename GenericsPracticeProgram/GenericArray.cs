using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPracticeProgram
{
    public class GenericArray<T>
    {
        public T[] inputarray;
        public GenericArray(T[] inputArray)
        {
            this.inputarray = inputArray;
        }
        public void ToPrint()
        {
            foreach (var element in inputarray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("-------------------------");
        }
    }
}
