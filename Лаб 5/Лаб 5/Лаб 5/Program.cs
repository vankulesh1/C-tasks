namespace Лаб_5
{
    internal class Program
    {
            static void Main(string[] args)
            {
            // Дана квадратна матриця порядку M. Дзеркально відобразити її елементи відносно
            // 1) горизонтальної осі симетрії; 2) вертикальної осі симетрії; 3) головної діагоналі;
            // 4) побічної діагоналі  матриці. 


            Random random = new Random();
                int m;
                int[,] mas, masCopy;




                Console.Write("Write M=");
                m = Convert.ToInt32(Console.ReadLine());
                mas = new int[m, m];
                masCopy = new int[m, m];
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        mas[i, j] = random.Next(30);
                    }
                }
                BreedingMassive(mas, m);
                TransferMassive(masCopy, mas, m);




                Console.WriteLine("Horizontal");
                for (int i = 0; i < (m / 2); i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        SwapElementMassive(ref mas[i, j], ref mas[(m - 1 - i), j]);
                    }
                }
                BreedingMassive(mas, m);
                TransferMassive(mas, masCopy, m);




                Console.WriteLine("Vertical");
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < (m / 2); j++)
                    {
                        SwapElementMassive(ref mas[i, j], ref mas[i, (m - 1 - j)]);
                    }
                }
                BreedingMassive(mas, m);
                TransferMassive(mas, masCopy, m);




                Console.WriteLine("Main diagonal");
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (j > i)
                        {
                            SwapElementMassive(ref mas[i, j], ref mas[j, i]);
                        }
                    }
                }
                BreedingMassive(mas, m);
                TransferMassive(mas, masCopy, m);





                Console.WriteLine("Side diagonal");
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (i + j < m - 1)
                        {
                            SwapElementMassive(ref mas[i, j], ref mas[m - 1 - j, m - 1 - i]);
                        }
                    }
                }
                BreedingMassive(mas, m);
            }





         static void SwapElementMassive<T>(ref T a, ref T b)//функція зміни елементів
            {
                T c = a;
                a = b;
                b = c;
            }


         static void BreedingMassive(int[,] mas, int l)//функція виведення масиву
            {
                for (int i = 0; i < l; i++)
                {
                    for (int j = 0; j < l; j++)
                    {
                        if ((mas[i, j] / 10) < 1)
                        {
                            Console.Write(mas[i, j] + " ");
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write(mas[i, j] + " ");
                        }
                    }
                    Console.WriteLine();
                }
            }



        static void TransferMassive(int[,] mas1, int[,] mas2, int l)//функція запису з елементів з одного масиву в інший
        {
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    mas1[i, j] = mas2[i, j];
                }
            }
        }
    }
}