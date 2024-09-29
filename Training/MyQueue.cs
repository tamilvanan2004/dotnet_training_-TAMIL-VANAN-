using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    public class MyQueue
    {
        Queue<int> que;
        public MyQueue() 
        {
            Console.WriteLine($"-----------------------------QUEUE METHOD-----------------------");
            que = new Queue<int>();

        }

        public void enqueue(int num)
        {
            Console.WriteLine($"-----------------------------{num} ENQUEUED-----------------------");
            que.Enqueue(num);
            printNum();
        }
        public void dequeue()
        {
            que.Dequeue();
            Console.WriteLine($"-----------------------------NUMBER DEQUEUE-----------------------");
            printNum();
        }
        public void printNum()
        {
            foreach (var item in que)
            {
                Console.WriteLine(item);
                
            }
        }


    }
}
