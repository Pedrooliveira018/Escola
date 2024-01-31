using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menu = 0;

            while (menu != 3)
            {
                if (menu == 0)
                {
                    Console.WriteLine("1 - Adicionar aluno");
                    Console.WriteLine("2 - Lista de alunos"); ;
                    Console.WriteLine("3 - sair");
                }
                int.TryParse(Console.ReadLine(), out menu);


                if (menu == 1)
                {
                    string[] alunos = new string[2];
                    int[] idade = new int[2];
                    string[] sexo = new string[2]; 
                    
                    // Solicita o nome dos alunos
                    for (int index = 0; index < alunos.Length; index++)
                    {
                        Console.WriteLine("Qual nome do aluno?");
                        Console.ReadLine();

                        // Solicitar a idade

                        Console.WriteLine("Qual sua idade?");
                        Console.ReadLine();

                        // Solicitar o Sexo

                        Console.WriteLine("Qual o sexo do aluno(a) ?");
                        Console.ReadLine();    

                        Console.Clear();    
                    }
                    
                     if (menu == 2)
                     {

                     }

                    
                }

            }
          
            
        }
    }
}
