namespace AutoNamespace
{
    public class Lastkraftwagen : Kraftfahrzeug
    {
        public Lastkraftwagen() : base("Blau", 400, 6)
        {
            Console.WriteLine("Lastkraftwagen erstellt.");
        }

        public void KranBelade(int menge)
        {
            Console.WriteLine($"LKW mit Kran um {menge} kg beladen.");
        }

        public void KranEntlade(int menge)
        {
            Console.WriteLine($"LKW mit Kran um {menge} kg entladen.");
        }

        public void Entlade(int i)
        {
            Console.WriteLine($"LKW mit Kran entladet {i} kg.");
        }

        public void Belade(int a)
        {
            Console.WriteLine($"LKW mit Kran beladet {a} kg.");
        }
    }
}
