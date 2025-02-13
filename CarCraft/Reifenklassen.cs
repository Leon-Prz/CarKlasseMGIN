using System;

namespace ReifenNamespace
{
    // Abstrakte Basisklasse für Reifen
    public abstract class AReifen
    {
        public int Aussendurchmesser { get; set; }

        public abstract void Rollen();
    }

    // Abstrakte Klasse für Luftreifen
    public abstract class ALuftreifen : AReifen
    {
        public int Druck { get; set; }
        public string Felge { get; set; }
        public int Innendurchmesser { get; set; }
        public bool ReifenIstSchlauchlos { get; set; }

        public virtual void LuftEinfuellen(int menge)
        {
            Druck += menge;
            Console.WriteLine($"Luft hinzugefügt. Aktueller Druck: {Druck}.");
        }
    }

    // Vollgummireifen (kein Luftdruck notwendig)
    public class Vollgummireifen : AReifen
    {
        public override void Rollen()
        {
            Console.WriteLine("Vollgummireifen rollen ohne Luftverlust.");
        }
    }

    // Eisenreifen (kein Luftdruck notwendig)
    public class Eisenreifen : AReifen
    {
        public override void Rollen()
        {
            Console.WriteLine("Eisenreifen rollen auf Stahlfelgen.");
        }
    }

    // Fahrradreifen
    public class Fahrradreifen : ALuftreifen
    {
        public override void Rollen()
        {
            Console.WriteLine("Fahrradreifen rollen leise und leicht.");
        }
    }

    // Autoreifen
    public class Autoreifen : ALuftreifen
    {
        public override void Rollen()
        {
            Console.WriteLine("Autoreifen rollen komfortabel auf Asphalt.");
        }
    }

    // LKW-Reifen
    public class LKWReifen : ALuftreifen
    {
        public override void Rollen()
        {
            Console.WriteLine("LKW-Reifen rollen stabil unter schwerer Last.");
        }
    }
}