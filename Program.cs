using System;

namespace Exercícios_Estrutura_Condicional_03 {
    class Program {
        static void Main(string[] args) {
            double A, B;
            
        string[] vet = Console.ReadLine().Split(' '); 
        A = double.Parse(vet [0]);
        B = double.Parse(vet [1]);

        if (A % B == 0 || B % A == 0) {
                Console.WriteLine("São Multiplos");
        } else {
                Console.WriteLine("Não são Multiplos");
         }
            

        }
    }
}
