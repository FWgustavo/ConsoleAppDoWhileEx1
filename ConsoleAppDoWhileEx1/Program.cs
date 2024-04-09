using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDoWhileEx1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valtotal = 0;
            string resp;
            do
            {
                Console.WriteLine("Qual a despesa: ");
                string desp = Console.ReadLine();
                Console.WriteLine("Qual o valor gasto na despesa? ");
                double val = double.Parse(Console.ReadLine());
                Console.ReadLine();
                valtotal += val;
                Console.WriteLine("Deseja adicionar mais uma despesa? S/N");
                resp = Console.ReadLine().ToUpper();
            } while (resp == "S");
            Console.WriteLine("O valor total da despesa foi de : " + valtotal.ToString("C"));
            Console.WriteLine("Quantas pessoas mora na casa: ");
            int pes = int.Parse(Console.ReadLine());

            double media = valtotal / pes;

            Console.WriteLine("O valor por morador é de: " + media.ToString("C"));
            Console.ReadKey ();
        }
    }
}
