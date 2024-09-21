namespace DN_training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Tamil");
            list.Add("Vanan");
            list.Add("Hari");


            foreach (var item in list)
            {
                Console.WriteLine(item);

            }

            // List Concadination
            Console.WriteLine("-------------------------------------------- List Concadination -----------------------------------------------------");
            List<string> list1 = new List<string>();
            list1.Add("Tamil");
            list1.Add("Vanan");
            list1.Add("Hari");

            List <string> list2 = new List<string>();
            list2.Add("Varshan");
            list2.Add("Darshan");

            var conList = list1.Concat(list2);

            foreach (var item in conList)
            {
                Console.WriteLine(item);
                
            }

            // List Count

            Console.WriteLine("-------------------------------------------- List Count -----------------------------------------------------");

            foreach (var item in conList)
            {
                Console.WriteLine(item);

                
            }
            Console.WriteLine("The Count of the List is " + conList.Count());

            // List Contains
            Console.WriteLine("-------------------------------------------- List Contains -----------------------------------------------------");
            Console.WriteLine(conList.Contains("Tamil"));
            Console.WriteLine(conList.Contains("Tamil Vanan"));

            // List Append 
            Console.WriteLine("-------------------------------------------- List Append -----------------------------------------------------");
            var appendedList = conList.Append("Tamil Vanan").Append("Tamil Vanan");

            foreach (var item in appendedList)
            {
                Console.WriteLine(item);
            }

            // List Distinct

            Console.WriteLine("-------------------------------------------- List Distrinct -----------------------------------------------------");

            var distrinctList = appendedList.Distinct();

            foreach(var item in distrinctList)
            {
                Console.WriteLine(item);
            }


            // List First

            Console.WriteLine("-------------------------------------------- List First & Last -----------------------------------------------------");

            Console.WriteLine("The First Element of the List is "+ distrinctList.First());
            // Last
            Console.WriteLine("The Last Element of the List is " + distrinctList.Last());

            // Skip 

            Console.WriteLine("-------------------------------------------- List Skiping -----------------------------------------------------");

            Console.WriteLine("BEFORE SKIP");
            Console.WriteLine(" ");
            List <string> mainList =  distrinctList.ToList();
            foreach (var item in mainList)
            {
                Console.WriteLine(item);
                
            }
            Console.WriteLine(" ");
            Console.WriteLine("AFTER SKIP");
            Console.WriteLine(" ");
            var skipedList = mainList.Skip(2);
            foreach (var item in skipedList)
            {
                Console.WriteLine(item);
            }

            // Remove

            var removedList = mainList.Remove("Hari");
            foreach (var item in mainList)
            {
                Console.WriteLine(item);
                
            }





        }
    }
}
