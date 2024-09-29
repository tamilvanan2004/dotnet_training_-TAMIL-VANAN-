using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
   
  
    public class MyArrayList
    {

        private ArrayList al;
        public ArrayList newAl;
        public MyArrayList() 

        {
            Console.WriteLine($"-----------------------------ARRAY LIST METHOD-----------------------");
            al = new ArrayList();
            al.Add(1);
            al.Add(2);
            //printNum();

        }


        public void getNumToAdd(int num)
        {
            al.Add(num);

        }

        public void printNum()
        {
            foreach (var item in al)
            {
                Console.WriteLine(item);
                
            }
        }

        public void getListOfNum(int[] num)
        {
            al.AddRange(num);

        }
        
    }
}
