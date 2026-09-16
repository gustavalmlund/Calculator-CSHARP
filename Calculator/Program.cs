using Lommeregner;

internal class Program
{
    private static void Main(string[] args)
    {
        do
        {
            Calculator calc = new Calculator();
            Console.WriteLine("Velkommen til lommeregner menuen!");
            Console.WriteLine("Vælg den metode du vil benytte ved at skrive tallet ude for det.");
            Console.WriteLine("1. Summen af 2 tal.");
            Console.WriteLine("2. Forskellen mellem 2 tal.");
            Console.WriteLine("3. Gange 2 tal sammen.");
            Console.WriteLine("4. Dividere 2 tal.");
            Console.Write("Dit valg: ");

            if (!int.TryParse(Console.ReadLine(), out int input) || input < 1 || input > 4)
            {
                Console.WriteLine("\nForkert input!");
                Console.Write("Tryk enter for at starte for fra");
                Console.ReadLine();
                Console.Clear();
                continue;
            }
             
            Console.Write("\nAngiv x: ");
            if (!int.TryParse(Console.ReadLine(), out int x))
            {
                Console.WriteLine("\nForkert input!");
                Console.Write("Tryk enter for at starte for fra");
                Console.ReadLine();
                Console.Clear();
                continue;
            }

            Console.Write("Angiv y: ");
            if (!int.TryParse(Console.ReadLine(), out int y))
            {
                Console.WriteLine("\nForkert input!");
                Console.Write("Tryk enter for at starte for fra");
                Console.ReadLine();
                Console.Clear();
                continue;
            }

            if (input == 4 && y == 0)
            {
                Console.WriteLine("\nMan kan ikke dividere med 0!");
                Console.Write("Tryk enter for at starte for fra");
                Console.ReadLine();
                Console.Clear();
                continue;
            }

            double resultat = 0;

            switch (input)
            {
                case 1:
                    resultat = calc.Sum(x, y);
                    break;
                case 2:
                    resultat = calc.Subtract(x, y);
                    break;
                case 3:
                    resultat = calc.Multiply(x, y);
                    break;
                case 4:
                    resultat = calc.Divide(x, y);
                    break;
            }

            Console.WriteLine($"Resultat: {resultat}\n");
            Console.Write("Tryk enter for at starte for fra");
            Console.ReadLine();
            Console.Clear();

        } while (true);
    }
}