using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOOex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Peso a;
            a = new Peso();

            Console.Write("peso: ");
            a.setpeso(double.Parse(Console.ReadLine()));
             
            Console.Write("altura: ");
            a.setaltura(double.Parse(Console.ReadLine()));

            a.calcular();
                 
           
        }
    }
}
