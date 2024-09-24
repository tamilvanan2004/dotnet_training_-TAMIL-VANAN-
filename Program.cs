namespace Training
{
    internal class Program
    {
        static void Main(string[] args){
            // Stack
            Console.WriteLine("----------- STACK -------------------");

            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(3);
            stack.Push(2);
            stack.Push(0);
            stack.Pop();
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            // Queue
            Console.WriteLine("----------- QUEUE -------------------");

            Console.WriteLine(" ");
            Console.WriteLine("----------- ENQUEUE -------------------");
            var queue =new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------- DEQUEUE -------------------");
            queue.Dequeue();

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            


        }
    }
    
}