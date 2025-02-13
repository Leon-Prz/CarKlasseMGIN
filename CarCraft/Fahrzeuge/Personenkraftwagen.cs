namespace AutoNamespace
{
    public class Personenkraftwagen : Kraftfahrzeug
    {
        public Personenkraftwagen() : base("Silber", 120, 4)
        {
            Console.WriteLine("Personenkraftwagen erstellt.");
        }

        public void Beschleunigen()
        {
            Console.WriteLine("Personenkraftwagen beschleunigt.");
        }
    }
}