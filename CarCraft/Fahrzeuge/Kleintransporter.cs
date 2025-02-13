namespace AutoNamespace
{
    public class Kleintransporter : Kraftfahrzeug
    {
        public Kleintransporter() : base("Weiß", 150, 4)
        {
            Console.WriteLine("Kleintransporter erstellt.");
        }

        public void Entlade(int t)
        {
            Console.WriteLine($"Kleintransporter entladet {t} kg");
        }

        public void Belade(int o)
        {
            Console.WriteLine($"Kleintransporter beladet {o} kg");
        }
    }
}