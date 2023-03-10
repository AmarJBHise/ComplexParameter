using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class PARAMETERex
    {
        public int i { get; set; }
        public int j { get; set; }
       
        //simple  parameters 
        public void Addittion(int NUM1, int NUM2)
        {
            int result = NUM1 + NUM2;

  
            Console.WriteLine($"Addition of {NUM1} and {NUM2} is = {result}");

        }

        // Function Complex Parameters 
        

        public void Multiplication(int NUM1, int NUM2, out int Result)  
        {
           
        Result = NUM1 * NUM2;

            Console.WriteLine($"Multiplication Of {NUM1} and {NUM2} is = {Result}");

        }
        
        public void Division(int NUM1, int NUM2, ref int Result)   
        {
            Result =  NUM1 / NUM2;
            Console.WriteLine($" Division Of {NUM1} and {NUM2} is = {Result}");



        }
    }
}
