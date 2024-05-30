namespace LINQGroupBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


        }
        static void GroupByLINQ()
        {
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    GroupByLINQ();
                    break;

                case 2:
                    ifelse();
                    break;

                case 3:
                    ForLOOP();
                    break;

                default:
                    Console.WriteLine("vale valik");
                    break;
            }



            var result = PeopleList.peoples
                .GroupBy(x => x.Age);

            foreach (var age in result)
            {
                Console.WriteLine("Age group " + age.Key);

                foreach (var p in age)
                {
                    Console.WriteLine("People name: " + p.Name);
                }
            }
        }
        static void ToLookUpLINQ()
        {
            var result = PeopleList.peoples
                .ToLookup(x => x.Age);
            foreach (var age in result)
            {
                Console.WriteLine("Age group: " + age.Key);

                foreach (var p in age)
                {
                    Console.WriteLine("Person name " + p.Name);
                }
            }
        }
        static void ifelse()
        {
            try
            {
                string p = "yes"; string n = "no"; string pn = Console.ReadLine();
                if (pn == p)
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("else");
                }
                if (pn == n) { Console.WriteLine("no"); }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Midagi läks valesti");

            }



        }
        static void ForLOOP() 
        {
            int i, j, rows; 
            int t = 1;
            
            Console.WriteLine("Numbri püramiid"); Console.WriteLine("PRESS");
            
            rows = Convert.ToInt32(Console.ReadLine());
            
            for (j = 1; j <= rows; i++) 
            {
                for (j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for(j = 1; j <= 1 * i - 1; j++)
                {
                    Console.Write("{0} ", t++);
                }
                Console.Write("\n");

            }
                   
        
        
        
        
        
        
        
        
        
        
        }






    }
}