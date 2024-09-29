using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    public class MyArray
    {
        public int[] array;

        public MyArray(params int[] elements)
        {
            array = elements;
            Console.WriteLine("-----------------------ARRAY METHOD-----------------------");
            foreach (var item in array)
            {
                Console.WriteLine(item);
                
            }
        }
    }
}
