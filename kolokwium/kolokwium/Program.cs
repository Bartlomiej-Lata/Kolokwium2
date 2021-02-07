using System;

namespace kolokwium
{

    class Tekst
    {
        public string Tytul;
        public string Tresc;
        public int[] Wersja = new int[3];
        



    }




    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}






/*
    Stwórz 5 kolejek, które będą reprezentować kolejki do kas w sklepie.W jednym cyklu każda kasa obsługuje jednego klienta.
    W każdym cyklu do kolejek dołącza się losowo 0-5 klientów.Aby lepiej wykorzystać czas pracowników, następną
kasę otwiera się dopiero, gdy wszystkie poprzednie kasy mają co najmniej 5 osób w kolejce 
    (tj.jeśli klient miałby być szósty, idzie do następnej kasy). Przeprowadź 10 cykli.
    W każdym cyklu wypisz ile jest otwartych kas i jak długie są w nich kolejki.

Stwórz klasę Tekst.Powinna posiadać pola Tytul i Tresc a także 3-elem.tablicę typu int Wersja.
    Klasa powinna implementować interfejs ICloneable. Aplikacja powinna pozwalać tworzyć i zmieniać tekst ale zachowywać historię edycji.
    Po podaniu tytułu i treści, użytkownik podaje także wersję tekstu, np 1.0.5.
    Zapisz w dowolnej kolekcji wszystkie wersje tekstu przy pomocy klonowania.

Stwórz klasę Klient z polami Id i StanKonta. Stwórz klasę Bank, która będzie posiadać dowolną kolekcję typu Klient.
    Do Banku dodaj event Przelew i event handler tego samego typu. Event handler powinien szukać klienta o konkretnym ID i dodawać
 do jego Stanu konkretną kwotę. Jeśli nie ma takiego klienta, nic nie rób.
    Do klasy Bank dodaj również metodę WyslijPrzelew która przyjmie jako parametr id nadawcy, id odbiorcy i kwotę.
    Powinna obciążyć konto nadawcy (jeśli istnieje) i wysłać event Przelew
z odpowiednimi danymi. Stwórz dwa Banki, dodaj do nich co najmniej po jednym kliencie. 
    Połącz eventy z event handlerami na krzyż (bank A nasłuchuje na event banku B i na odwrót).
Wyślij przelewy z banku A do B i z B do A.   *\