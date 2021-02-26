using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Karolina Czech Informatyka zaocznie semestr 2 nr albumu: 35518

namespace Kadra
{
    //abstrakcyjna klasa Pracownik
    abstract public class Pracownik
    {
        //pola klasy Pracownik z poziomem dostępu "protected" (klasy dziedziczące mają do nich dostęp)
        protected int id;
        protected string imie;
        protected string nazwisko;
        protected string stanowisko;
        protected double pensja;

        protected static int make_id = 0; //pole służące do automatycznego nadawania id kolejnym obiektom

        //gettery i settery umożliwiające dostęp do pol klasy Pracownik
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Imie
        {
            get{ return imie; }
            set { imie = value; }
        }
        public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }
        public string Stanowisko
        {
            get { return stanowisko; }
            set { stanowisko = value; }
        }
        public double Pensja
        {
            get { return pensja; }
            set { pensja = value; }
        }

        //metody, które będą nadpisywane w klasach dziedziczących po klasie Pracownik:
        
        //zawiera 5 parametrow, odpowiadających polom klasy Pracownik, ponieważ zwraca ona obiekt tej klasy, na ktory podmienimy obiekt(pracownika), ktory chcemy awansować
        abstract public Pracownik Awans(int id, string imie, string nazwisko, double pensja);
        //zawiera 1 parametr, odpowiadający polu "pensja"
        abstract public double Podwyzka(double pensja);
        
    }
    //klasa Kierownik dziedzicząca po klasie Pracownik
    class Kierownik : Pracownik 
    {
       //konstruktor z czterema parametrami (imie, nazwisko, stanowisko, pensja)
        public Kierownik(string im, string n, string s, double p )
        {
            id = make_id;
            imie = im;
            nazwisko = n;
            stanowisko = s;
            pensja = p;
            make_id++; //zwiększenie make_id o 1 (żeby przy kolejnym tworzeniu obiektu do pola id przypisało się inne, większe id)
        }
        //konstruktor z pięcioma parametrami (id, imie, nazwisko, stanowisko, pensja)
        public Kierownik(int i, string im, string n, string s, double p)
        {
            id = i; //umożliwia przypisanie innego id, niż to automatycznie tworzone za pomocą make_id
            imie = im;
            nazwisko = n;
            stanowisko = s;
            pensja = p;
            make_id++; //zwiększenie make_id o 1
        }
        
        override public Pracownik Awans(int id, string imie, string nazwisko, double pensja)
        {
           //metoda zwraca obiekt klasy Kierownik z polem "stanowisko" ustawionym na "dyrektor"
            return new Kierownik(id, imie, nazwisko, "dyrektor", pensja);
        }
        override public double Podwyzka(double pensja)
        {   
            //wyliczenie nowej pensji na podstawie tej aktualnej
            double nowaPensja = pensja + (0.1 * pensja);
            //metoda zwraca nową pensję zaookrągloną do dwoch miejsc po przecinku
            return Math.Round(nowaPensja, 2);
        }
    }
    //klasa Lider dziedzicząca po klasie Pracownik
    class Lider : Pracownik
    {
        //konstruktor z czterema parametrami (imie, nazwisko, stanowisko, pensja)
        public Lider(string im, string n, string s, double p)
        {
            id = make_id;
            imie = im;
            nazwisko = n;
            stanowisko = s;
            pensja = p;
            make_id++; //zwiększenie make_id o 1 (żeby przy kolejnym tworzeniu obiektu do pola id przypisało się inne, większe id)
        }
        //konstruktor z pięcioma parametrami (id, imie, nazwisko, stanowisko, pensja) 
        public Lider(int i, string im, string n, string s, double p)
        {
            id = i;
            imie = im;
            nazwisko = n;
            stanowisko = s;
            pensja = p;
            make_id++; //zwiększenie make_id o 1
        }
        override public Pracownik Awans(int id, string imie, string nazwisko, double pensja)
        {
            //metoda zwraca obiekt klasy Kierownik z polem "stanowisko" ustawionym na "kierownik"
            return new Kierownik(id, imie, nazwisko, "kierownik", pensja);
        }
        override public double Podwyzka(double pensja)
        {
           //wyliczenie nowej pensji na podstawie tej aktualnej
            double nowaPensja = pensja + (0.2 * pensja);
           //metoda zwraca nową pensję zaookrągloną do dwoch miejsc po przecinku
            return Math.Round(nowaPensja, 2);
        }
    }
    //klasa Pracownik_produkcji dziedzicząca po klasie Pracownik
    class Pracownik_produkcji : Pracownik
    {
        //konstruktor z czterema parametrami (imie, nazwisko, stanowisko, pensja)
        public Pracownik_produkcji(string im, string n, string s, double p)
        {
            id = make_id;
            imie = im;
            nazwisko = n;
            stanowisko = s;
            pensja = p;
            make_id++; //zwiększenie make_id o 1 (żeby przy kolejnym tworzeniu obiektu do pola id przypisało się inne, większe id)
        }
        override public Pracownik Awans(int id, string imie, string nazwisko, double pensja)
        {
            //metoda zwraca obiekt klasy Lider z polem "stanowisko" ustawionym na "lider"
            return new Lider(id, imie, nazwisko, "lider", pensja);
           
        }
        override public double Podwyzka(double pensja)
        {
           //wyliczenie nowej pensji na podstawie tej aktualnej
            double nowaPensja = pensja +  (0.1 * pensja);
           //metoda zwraca nową pensję zaookrągloną do dwoch miejsc po przecinku    
            return Math.Round(nowaPensja, 2);
        }
    }
}
