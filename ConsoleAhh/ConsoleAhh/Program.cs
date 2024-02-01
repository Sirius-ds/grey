using System;

namespace borgar
{

    public class Meth
    {

        public int plus(int n1, int n2)
        {
            return  n1 + n2;

        }
        public int negartiv(int n1, int n2)
        {
            return n1-n2;
        }
        public int multi(int n1, int n2)
        {
            return n1*n2;
        }
        public int divi(int n1, int n2)
        {
            return n1 / n2;

            /*public void plus(int n1, int n2)
            {
                Console.WriteLine("Addition = " +(n1+n2));

            }
            public void negartiv(int n1, int n2)
            {
                Console.WriteLine("Subtraction = " + (n1-n2));

            }
            public void multi(int n1, int n2)
            {
                Console.WriteLine("Multi = " +  (n1*n2));

            }
            public void divi(int n1, int n2)
            {
                Console.WriteLine("Divi = " + (n1/n2));
    */
        }
        /* public void Final {

         }*/

    }

    class Program
    {

        static void Main(string[] args)
        {

            Meth meth = new Meth();

            int n1, n2;

            /*  Console.WriteLine("enter #1: ");
              n1 = int.Parse(Console.ReadLine());
              Console.WriteLine("enter #2: ");
              n2 = int.Parse(Console.ReadLine());

             meth.plus(n1, n2);
             meth.negartiv(n1, n2);
              meth.multi(n1, n2);
              meth.divi(n1, n2);  */

            Console.WriteLine("enter #1: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter #2: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Total (Addition) : " + meth.plus(n1, n2));

            Console.WriteLine("enter #1: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter #2: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Total (Subtract) : " + meth.negartiv(n1, n2));

            Console.WriteLine("enter #1: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter #2: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Total (Multi) : " + meth.multi(n1, n2));

            Console.WriteLine("enter #1: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter #2: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Total (Division): " + meth.divi(n1,n2));

        }
    }
}
