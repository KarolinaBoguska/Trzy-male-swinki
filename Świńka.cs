using System;
// w namespace bez ;
namespace klasy.TrzyMałeŚwinki
{
    public class Świńka // klasa l. poj 
    {
        public string numer;
        // void metoda która nic nie zwraca a wyświetla coś gdy w metodzie niemamy zawartego zadania typu return int
        public void Mówi(string tresc)  // czynność jednej
        {
            Console.WriteLine("Świnka " + numer + " mówi: " + tresc);
        }

    }

}