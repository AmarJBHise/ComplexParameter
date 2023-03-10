namespace ConsoleApp6
{
    internal class Program
    {
        static void Main()
        {
            

            PARAMETERex Parameaterobj = new PARAMETERex();
            Parameaterobj.Addittion(50, 5);

            PARAMETERex Parameaterobj1 = new PARAMETERex();
             

            int result=10;
            Parameaterobj1.Division(999, 9, ref result);
            Console.WriteLine($"Division of 999 & 9 is = {result}");


            /*int Result;
            Parameaterobj1.Multiplication(545, 689, out Result);
            Console.WriteLine($"Multiplication of 545 & 689 is = {Result}");*/

        }
    }
}