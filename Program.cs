using System;

namespace app_raphael
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            
            System.Console.WriteLine("Informe seu nome");
            person.Name = Convert.ToString(Console.ReadLine());

          while (person.Name != "Raphael"){
               System.Console.WriteLine("Nome Inválido. Informe outro");
               person.Name = Convert.ToString(Console.ReadLine());
           } 

            System.Console.WriteLine("Informe sua idade");
            person.Idade = Console.ReadLine();
        
            System.Console.WriteLine("Seu nome é:" + person.Name);
            System.Console.WriteLine("Sua idaide é:" + person.Idade);
        }
    }
}
