using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    public class MyGenLis<T> 

    {
        private List<T> genList;
        public MyGenLis() 
        {
            genList = new List<T>();
            

        }
        public void addElement(T item)
        {
            genList.Add(item);
        }
        public void removeElement(T item)
        {
            genList.Remove(item);
        }
        public void printData()
        {
            foreach (T item in genList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
