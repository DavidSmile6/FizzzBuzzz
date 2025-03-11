namespace FizzzBuzzz
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Enter a number:");
                int number = Convert.ToInt32(Console.ReadLine());


                if (number % 5 == 0 && number % 3 == 0)
                {
                    Console.WriteLine("FIZZZ BUZZZ");
                }
                else if (number % 3 == 0)
                {
                    Console.WriteLine("Fizzz");
                }
                else if (number % 5 == 0)
                {
                    Console.WriteLine("Buzzz");
                }
                else
                {
                    Console.WriteLine("No Fizz or Buzz for this number.");
                }
            }
        }
    }
}
