namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Sprawdz czy liczba jest parzysta i nie parzysta");
                Console.WriteLine("2. Liczby parzyste");

                var input = Console.ReadLine();

                switch (int.Parse(input))
                {
                    case 1:
                        DisplayNumberIsEven();
                        break;
                    case 2:
                        DisplayEvenNumber();
                        break;

                    case 5:
                        {
                            Game();
                            break;
                        }
                    case 0: return;
                }
            }
        }

        static void Game()
        {
            var random = new Random();
            var number = random.Next(1, 101);//1-100

            int count = 0;
            int shoot;
            do
            {
                count++;
                Console.WriteLine("podaj liczbe");
                var input = Console.ReadLine();

                shoot = int.Parse(input);

                if (shoot == number)
                    break;

                if (shoot > number)
                    Console.WriteLine("Za duża");
                else
                    Console.WriteLine("Za mała");

            }
            while (shoot != number);

            Console.WriteLine($"Zgadłeś za {count}");
        }

        static void DisplayNumberIsEven()
        {
            Console.WriteLine("Podaj liczbę");

            var input = Console.ReadLine();


            Console.WriteLine("Liczba jest {0}", NumberIsEven(int.Parse(input)) ? "parzysta" : "nieparzysta");
        }

        static void DisplayEvenNumber()
        {
            Console.WriteLine("Podaj liczbę");

            var input = Console.ReadLine();

            for (var i = 0; i < int.Parse(input); i++)
            {
                if (NumberIsEven(i))
                    Console.WriteLine(i);
            }
        }

        static bool NumberIsEven(int number)
        => number % 2 == 0;

    }

}