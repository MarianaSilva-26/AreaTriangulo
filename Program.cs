using System;

namespace AreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double Base;
            double Altura;
            double Area;

            Console.WriteLine("digite o valor da base (cm):");
            Base = double.Parse(Console.ReadLine ());
            Console.ResetColor();

            Console.Write("Digite o Valor da Altura (cm): ");
            Altura = double.Parse(Console.ReadLine());
            Console.Write("\n");
            Console.ResetColor();

            Console.WriteLine($"A Área do Triangulo é: {Area = Base * Altura / 2} (cm²)");
            Console.ResetColor();    
               //---fim(digite)---//
            
               //---inicio(sair)---//
            Console.WriteLine("pressione Enter para sair!"); 
            Console.ReadKey();
            


        }
    }
}
