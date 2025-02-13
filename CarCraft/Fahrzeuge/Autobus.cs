namespace AutoNamespace
{
    public class Autobus : Kraftfahrzeug
    {
        public Autobus() : base("Gelb", 200, 6)
        {
            Console.WriteLine("Autobus erstellt.");
        }

        public void Öffne()
        {
            Console.WriteLine("Bustüren geöffnet.");
        }

        public void Schließe()
        {
            Console.WriteLine("Bustüren geschlossen.");
        }
    }
}