using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    public class MyList
    {
        private List<int> list;
        public int num;

        public MyList(int num) {
            Console.WriteLine($"-----------------------------LIST METHOD-----------------------");
            list = new List<int>();
            list.Add(0);
            list.Add(1);
            printNum();
            
        }
        public void getElementToAdd(int num)
        {
            list.Add(num);
            Console.WriteLine($"-----------------------------RECENTLY ADDED ELEMENT is {num}-----------------------");
            printNum();
            
        }
        public void printNum()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);

            }
        }
        public void getNumtoDel(int num)
        {
            list.Remove(num);
            Console.WriteLine($"-----------------------------RECENTLY DELETED ELEMENT is {num}-----------------------");
            printNum();
        }
    }
}
