using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma_impares {
    class Program {
        static void Main(string[] args) {

            int x, y, i, primeiro, ultimo, soma, troca;

            Console.WriteLine("Digite dois numeros:");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            
            soma = 0;

            if (x > y) {
                troca = x;
                x = y;
                y = troca;
            }

            primeiro = 0;
            ultimo = 0;

            ////if (x % 2 == 0) {
            //    primeiro = x + 1; 
            //}
            //else if (x % 2 != 0) {
            //    primeiro = x;
            //}
            //
            //if (y % 2 == 0) {
            //    ultimo = y - 1;
            //}
            //else if (y % 2 != 0) {
            //    ultimo = y;
            //}
            //
            //for (i = primeiro; i < ultimo; i = i + 2) {
            //    soma = soma + i;
            //}
            for (i = x + 1; i < y; i++) {
                if (i % 2 != 0) {
                    soma = soma + i;
                }
            }

            Console.WriteLine("SOMA DOS IMPARES = " + soma);
        }
    }
}
