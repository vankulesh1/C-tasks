namespace Лаб_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1

            float I;
            Console.WriteLine("Enter the value U: ");
            float U = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value R: ");
            float R = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value R: " + U);
            Console.WriteLine("Enter the value U: " + R);

            I = U / R;
            Console.WriteLine("Value I = " + I);

            
        }
    }
}