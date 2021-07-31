using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula01DotnetFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Walquria, digite primeira nota:");
            double nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Walquria, digite segunda nota:");
            double nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Walquiria, a soma das duas notas é: " + (nota1 + nota2));
            Console.WriteLine("Walquiria, a divisão da nota1 pela nota2  é: " + (nota1 / nota2));
            Console.WriteLine("Walquiria, a multiplicação da nota1 pela nota2  é: " + (nota1 * nota2));
            Console.ReadLine();
            //\n pula linha
        }
    }
}
