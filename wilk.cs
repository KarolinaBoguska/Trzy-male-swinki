using System;

namespace klasy.TrzyMałeŚwinki
{

    public class Wilk
    {
        public string imie;
        /// spr - wartości wyświetlane w metodach innych klas mogą się powtarzać
        public void Mówi(string treść)
        {
            Console.WriteLine(imie + " odpowiada:" + treść);
        }

        public void WilkDmucha()
        {
            Console.WriteLine( imie + " dmucha: fiuuu!");
        }

    }
    // zrób metodę dmucha, która wypisze na ekranie "fiuuu!" 
    //" Wilk dmucha: fiuuu!"
}
