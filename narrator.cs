using System;
namespace klasy.TrzyMałeŚwinki
{
    public class Narrator
    {
        public string imie;
        // czy umieścic treść - 
        // bez treści: nie pokazujemy metodzie, by zwracała jakąś treść
        //   narrator.Mówi("ds");
        // TERMINAL: Narrator mówi:
        // metoda potrzebuje określenia string, dane!
        public void Mówi(string treść)
        {
            Console.WriteLine(imie +" mówi: " + treść);
        }
        
    }
}