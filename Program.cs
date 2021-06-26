using System;

namespace _3_Exercicio_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            double salariominimo;
            double salariobonus;

            Console.WriteLine("Qual é o seu salário?");
            salariominimo = double.Parse(Console.ReadLine());
            salariobonus = salariominimo * 1.3;


             if(salariominimo <= 500){ 
                  Console.WriteLine("Você receberá um bônus, e seu salário ficará: R$" + salariobonus);
             }
             else{ 
                 Console.WriteLine("Você não receberá o bônus, seu salario total é de: R$" + salariominimo);
             }
        }
    }
}
