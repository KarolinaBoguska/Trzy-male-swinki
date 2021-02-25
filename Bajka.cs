using System;
//using klasa.TrzyMałeŚwinki; // chcesz korzystać z namespace
namespace klasy.TrzyMałeŚwinki  // deklarujesz namespace
{
    public class Bajka
    {
        // Stwórz obiekty świnek na podstawie klasy Świnki
        // Stwórz obiekt wilk na podstawie klasy Wilk
        public void Opowiedz()
        {
            Świńka świnka1 = new Świńka();
            świnka1.numer = "1";
            Świńka świnka2 = new Świńka();
            świnka2.numer = "2";
            Świńka świnka3 = new Świńka();
            świnka3.numer = "3";
            //string tresc = "sdd";
            //  Console.WriteLine("Świnka " + numer + " mówi: " + tresc);
            // Świnka 1 mówi: Jestem świnką 1sdd
            //świnka1.Mówi("Jestem świnką 1");
            // świnka2.Mówi("Jestem świnką 2");
            // świnka3.Mówi("Nie zdmuchuj!");

            Wilk wilk = new Wilk();
            wilk.imie = "Wilk";
            //string treść ="ułuu";
            // Console.WriteLine(imie + " odpowiada:" + treść);
            //Wilk odpowiada: A właśnie, że zdmuchnę
            // wilk.Mówi(" A właśnie, że zdmuchnę ");
            // //Console.WriteLine( imie + " dmucha: fiuuu!");
            // // Console.WriteLine( imie + " dmucha: fiuuu!");
            //wilk.WilkDmucha();

            Narrator narrator = new Narrator();
            narrator.imie = "Narrator";
            //Console.WriteLine(imie +" mówi: " + treść);
            // narrator.Mówi("ds");
            Console.WriteLine("------Trzy małe świnki------");

            narrator.Mówi("Dawno, dawno temu były sobie trzy świnki. Pewnego dnia zostawiły rodziców i wyruszyły w świat.");
            narrator.Mówi("Kiedy lato miało się ku końcowi, świnki zdały sobie sprawę że każdy zaczyna teraz myśleć o zbliżającej się zimie i wraca do zwykłych zajęć. Świnki uznały, że pora wreszcie pomyśleć o domu z prawdziwego zdarzenia.");
            świnka1.Mówi("Wybuduję sobie chatkę ze słomy, tak będzie najszybciej");
            narrator.Mówi("Twoja chatka będzie za słaba. Krytykowały jej pomysł pozostałe, ale ona nie chciała ich słuchać.");
            świnka2.Mówi(" Ja wybuduję swód omek z drewna");
            narrator.Mówi("Druga świnka, trochę mniej leniwa niż pierwsza wybrała się do lasu na poszukiwanie desek i patyków. Stuku – puku, stuku – puku, całe dwa dni zbijała je gwoździami.");
            świnka3.Mówi(" Nie podobają mi się wasze pomysły. Tak się domu nie buduje.");
            narrator.Mówi("Powiedziała"); // dodanie określenia numeru świnki?? narrator.świnka3.
            świnka3.Mówi("Trzeba mieć czas, cierpliwość i ciężko uczciwie pracować, żeby odm był na tyle solidny, żeby oparł się wichurom, nie przepuszczał deszczu i śniegu. A co najważniejsze – żeby chronił nas przed wilkami.");
            narrator.Mówi("Króregoś pięknego dnia do drzwi pierwszej chatki zapukał wilk");
            świnka1.Mówi("Odejdź wilku, nie wpusczę Cię do mojego domku");
            wilk.Mówi("Wychodź, albo zdmuchnę twój domek");
            świnka1.Mówi("Zostaw mnie w spokoju wilku!!");
            wilk.Mówi("Sama się o to prosisz!!");
            wilk.WilkDmucha();
            narrator.Mówi("I chatka została zdmuchnięta. Przestraszona Mała świnka zewrała się na równe nogi i pogiegła do chatki drugiej świnki");
            wilk.Mówi(" Wiem, że tam jesteście. Otwierajcie!!");
            świnka2.Mówi("Nie ma mowy!! Zostaw nas wiku!");
            wilk.Mówi("Jak się nadmę i jak dmuchnę To z twym domkiem będzie krucho!");
            narrator.Mówi("Wystraszone, zapłakane świnki mocno podpierały drzwi. Ale zły wilk zebrał wszystkie siły i dmuchnął! ");
            wilk.WilkDmucha();
            narrator.Mówi("Potężnie dmuchnął. Wtedy domek się rozpadł, jakby był z kart. A dwie świnki rzuciły się do ucieczki.");
narrator.Mówi("I chatka została zdmuchnięta. Przestraszona dwie świnki pogiegły do murowanej chatki trzeciej świnki");
wilk.Mówi("Wychodźie świnki, zdmuchnąłem wasze dwa poprzednie domki, ten też zdmuchnę!!");
wilk.WilkDmucha();
narrator.Mówi("Potem zaczął fukać i dmuchać. Dmuchał i fukał coraz mocniej. Ale choć się wytężał, nie mógł zdmuchnąć małego domku zbudowanego z cegieł. Wdrapał się więc na dach i wsadził głowę do komina.");
świnka1.Mówi("Mam pomysł. Pomóżcie ustawmy na palenisku kocioł z wodą.");
narrator.Mówi("Wielki zły wilk uciekł z powrotem przez komin, najszybciej jak tylko potrafił, gdyż w przeciwnym razie na pewno ugotował by się w kotle wrzącej wody.I tak wielki zły wilk, uciekł gdzie pieprz rośnie i trzy małe świnki mieszkały sobie szczęśliwie w niewielkim przytulnym domku z cegły.");
narrator.Mówi("----Koniec----");

















        }
    }
}