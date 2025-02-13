using System;
using ReifenNamespace;

namespace AutoNamespace
{
    public class Kraftfahrzeug
    {
        public string Farbe { get; private set; }
        public int Leistung { get; private set; }
        public AReifen[] Reifen { get; private set; }

        public Kraftfahrzeug(string farbe, int leistung, int reifenAnzahl)
        {
            Farbe = farbe;
            Leistung = leistung;
            Reifen = new AReifen[reifenAnzahl];
        }

        public void SetReifen(AReifen[] reifen)
        {
            if (reifen.Length != Reifen.Length)
                throw new ArgumentException("Die Anzahl der Reifen passt nicht zu diesem Fahrzeug!");

            Reifen = reifen;
            Console.WriteLine($"{GetType().Name} mit {reifen.Length} Reifen ausgestattet.");
        }

        public void ZeigeReifenDetails()
        {
            for (int i = 0; i < Reifen.Length; i++)
            {
                Console.WriteLine($"Reifen {i + 1}: Außendurchmesser = {Reifen[i].Aussendurchmesser}");
                Reifen[i].Rollen();
            }
        }
    }
}