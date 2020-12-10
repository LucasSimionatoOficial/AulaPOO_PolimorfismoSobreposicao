using System;
using AulaPOO_PolimorfismoSobreposicao.classes;

namespace AulaPOO_PolimorfismoSobreposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            bool entradaCorreta = true;
            while(entradaCorreta){
                Console.WriteLine("Escolha seu personagem");
                Console.WriteLine("Digite 1 para MegaMan");
                Console.WriteLine("Digite 2 para Zero");
                switch (Console.ReadLine())
                {
                    case "1":
                        MegaMan megaman = new MegaMan();
                        Console.WriteLine("Selecione uma ação");
                        Console.WriteLine("Digite 1 para correr");
                        Console.WriteLine("Digite 2 para pular");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                Console.WriteLine(megaman.Correr());
                                break;
                            case "2":
                                Console.WriteLine(megaman.Pular());
                                break;
                            default:
                                Console.WriteLine("Fazendo seja la o que isso for");
                                break;
                        }
                        entradaCorreta = false;
                        break;
                    case "2":
                    Zero zero = new Zero();
                        Console.WriteLine("Selecione uma ação");
                        Console.WriteLine("Digite 1 para correr");
                        Console.WriteLine("Digite 2 para pular");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                Console.WriteLine(zero.Correr());
                                break;
                            case "2":
                                Console.WriteLine(zero.Pular());
                                break;
                            default:
                                Console.WriteLine("Fazendo seja la o que isso for");
                                break;
                        }
                        entradaCorreta = false;
                        break;
                    default:
                    Console.WriteLine("Valor inválido");
                        break;
                }
                
            }
        }
    }
}
