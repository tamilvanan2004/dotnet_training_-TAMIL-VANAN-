namespace Training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //ARRAY
            MyArray arr = new MyArray(1, 2, 3, 4, 5);

            //LIST
            MyList lis = new MyList(5);
            lis.getElementToAdd(5);
            lis.getElementToAdd(6);
            lis.getElementToAdd(7);

            lis.getNumtoDel(6);

            //ARRAY LIST
            MyArrayList al = new MyArrayList();
            al.getNumToAdd(3);
            al.getNumToAdd(4);
            al.getListOfNum([5, 6, 7]);
            al.printNum();

            MyStack stack = new MyStack();
            stack.pushElement(3);
            stack.pushElement(4);
            stack.pushElement(5);

            stack.printNum();
            stack.popElement();

            MyQueue queue = new MyQueue();
            queue.enqueue(1);
            queue.enqueue(10);
            queue.enqueue(20);
            queue.enqueue(30);
            queue.dequeue();

            MyDict dict = new MyDict();
            dict.addData(1, "Tamil");
            dict.addData(2, "Vanan");
            dict.addData(3, "Hari");
            dict.printData();

            MyGenLis<int> intgenlis = new MyGenLis<int>();
            intgenlis.addElement(1);
            intgenlis.addElement(2);
            intgenlis.addElement(3);
            intgenlis.addElement(4);
            intgenlis.addElement(5);
            intgenlis.addElement(6);
            intgenlis.printData();
            MyGenLis<string> strgenlis = new MyGenLis<string>();
            strgenlis.addElement("Tamil");
            strgenlis.addElement("Vanan");
            strgenlis.addElement("Hari");

            strgenlis.printData();
        }
    }
}
