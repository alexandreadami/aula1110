using System;
using System.IO;

namespace aula1110
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("\nPERGUNTAS E RESPOSTAS\n");
            string[] perguntas = File.ReadAllLines(@"C:\Users\FIC\Documents\aula1110\perguntas.txt");
            string[] respostas = new string[perguntas.Length];
            string controle = "s";
            

            do {

            for(int i = 0; i<perguntas.Length; i++){
                Console.Write("Qual " + perguntas[i] + " ");
                respostas[i] = Console.ReadLine();
            }

            StreamWriter salvaRespostas = new StreamWriter("respostas.csv", true);

            for(int i = 0; i<perguntas.Length; i++){
                salvaRespostas.Write(respostas[i] + ";");
                
            }
            salvaRespostas.WriteLine("");
            salvaRespostas.Close();
            
            Console.WriteLine();
            Console.Write("Vai ler mais um? (s/n)");
            controle = Console.ReadLine();
            
            }while (controle == "s");
        }
    }
}
