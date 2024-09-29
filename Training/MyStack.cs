using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    public class MyStack
    {
        private Stack<int> stk;
        public MyStack() 
        {
            stk = new Stack<int>();
            Console.WriteLine($"-----------------------------STACK METHOD-----------------------");
            stk.Push(1);
            stk.Push(2);
        }

        public void pushElement(int value) 
        {
            stk.Push(value);
        }
        public void popElement()
        {
            Console.WriteLine($"-----------------------------ELEMENT POPED-----------------------");

            stk.Pop();
            printNum();
        }
        public void printNum()
        {
            foreach (var item in stk)
            {
                Console.WriteLine(item);
                
            }
        }
        

    }
}
