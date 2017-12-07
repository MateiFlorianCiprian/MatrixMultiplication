using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs_4_CSharp_imultirea_2_matrici
{
    class Program
    {
        static void Main(string[] args)
        {
            //creare matrice B
            Console.Write("Enter n (numar de lini): ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter m (numar de coloane): ");
            int m = int.Parse(Console.ReadLine());
            int[,] a = new int[n, m];
            Random r = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    a[i, j] = r.Next(3);

            //crearea matrice B
            Console.Write("Enter p (numar de lini): ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Enter q (numar de coloane): ");
            int q = int.Parse(Console.ReadLine());
            int[,] b = new int[p, q];
            Random t = new Random();
            for (int i = 0; i < p; i++)
                for (int j = 0; j < q; j++)
                    b[i, j] = t.Next(3);
            int[,] c = new int[n, q];
            if (m == p)
            {
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < q; j++)
                    {
                        int k = 0;
                        //for (int k = 0; k < m; k++)
                        while (k < m)
                        {
                            c[i, j] += a[i, k] * b[k, j];
                            k++;
                        }
                    }
                //afisare matrice A
                Console.Write("The matrix A is:\n");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)

                    Console.Write(a[i, j] + " ");
                    Console.Write("\n");
                }
                Console.Write("\n");

                //afisare matrice B
                Console.Write("The matrix B is:\n");
                for (int i = 0; i < p; i++)
                {
                    for (int j = 0; j < q; j++)

                    Console.Write(b[i, j] + " ");
                    Console.Write("\n");
                }
                Console.Write("\n");

                //afisare matrice C
                Console.Write("The matrix C is:\n");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < q; j++)

                    Console.Write(c[i, j] + " ");
                    Console.Write("\n");
                }
            }
            else Console.WriteLine("The Add cannot be made!");     
            Console.ReadLine();


        }
        }
    }
