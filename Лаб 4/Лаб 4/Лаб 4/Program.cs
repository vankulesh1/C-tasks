using System.Threading.Channels;

namespace Лаб_4
{
    internal class Program
    {
        
            static void Main(string[] args)
            {
            // Дано дійсне число R і масив розміру N. Знайти елемент масиву, який найближчий (найдальший) від даного числа. 

            int r = 0, n = 0, min = 1, max = 1, k, minI = -1, maxI = -1;
                Random random = new Random();
                int[] mas;
                string minIndexs = "Min indexs: ", maxIndexs = "Max indexs: ";


                Console.Write("Write number R=");
                r = Convert.ToInt32(Console.ReadLine());

                Console.Write("Write lenght massive ");
                n = Convert.ToInt32(Console.ReadLine());
                mas = new int[n];

                Console.WriteLine("Write elements massive");
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = random.Next(20);
                    Console.WriteLine("Element " + (i + 1) + "=" + mas[i]);

                }

                //min = Math.Abs(mas[0] - r);
                for (int i = 0; i < mas.Length; i++)
                {
                    k = Math.Abs(mas[i] - r);
                    if (k >= max)
                    {
                        max = k;
                        maxI = i;
                    }
                    if (k <= min && k > 0)
                    {
                        min = k;
                        minI = i;
                    }
                }
                for (int i = 0; i < mas.Length; i++)
                {
                    if (mas[i] == mas[maxI])
                    {
                        maxIndexs += (i + 1) + " ";
                    }
                    if (mas[i] == mas[minI])
                    {
                        minIndexs += (i + 1) + " ";
                    }
                }
                Console.WriteLine(minIndexs);
                Console.WriteLine(maxIndexs);

            }
        
    }
}