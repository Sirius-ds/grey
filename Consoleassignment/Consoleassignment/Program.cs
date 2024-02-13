using System;


namespace quizAss
{
    class Person
    {
        public String Name { get; set; }
        public int Weight { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            int totalWeight = 0; 

            while (true)
            {
                Console.WriteLine("Enter your name/weight----but 1st yay or nay?");

                if (Console.ReadLine() == "nay")
                {
                    break;
                }
                Person person1 = new Person();
                Console.WriteLine("Enter Your Name= ");
                person1.Name = Console.ReadLine();
                Console.WriteLine("Enter your Weight");
                person1.Weight = int.Parse(Console.ReadLine());

                list.Add(person1);

                totalWeight += person1.Weight; // Update the total weight

            }

            Console.WriteLine("Total Weight: " + totalWeight); // Print total weight

            list.ForEach(x =>
            {
                Console.WriteLine(x.Name);
                Console.WriteLine(x.Weight);
                Console.WriteLine("----------------------");
            });
        }
    }
}