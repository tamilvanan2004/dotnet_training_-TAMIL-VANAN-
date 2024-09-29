using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    public class MyDict
    {
        private Dictionary<int, string> dict;
        public MyDict()
        {
            Console.WriteLine($"-----------------------------DICTIONARY METHOD-----------------------");
            dict = new Dictionary<int, string>();
        }

        public void addData(int key, string value) 
        {
            dict.Add(key, value);
        }
        public void removeData(int key)
        {
            dict.Remove(key);

        }
        public void printData()
        {
            foreach (var item in dict)
            {
                Console.WriteLine($"id : {item.Key} Name : {item.Value}");
            }
        }

    }

}
