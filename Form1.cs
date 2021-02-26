using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Karolina Czech Informatyka zaocznie semestr 2 nr albumu: 35518

namespace Kadra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //LISTA ZAWIERACJA PRACOWNIKOW (są na niej zapisywane obiekty klasy Pracownik)
        List<Pracownik> p = new List<Pracownik>();

        //UMOZLIWIA WPISYWANIE WYŁĄCZNIE LICZB I PRZECINKA W POLE TEKSTOWE "PENSJA"
        private void textBoxPensja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == ',') base.OnKeyPress(e);
            else e.Handled = true;
        }

        //PRZYCISK DO DODAWANIA PRACOWNIKA
        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            //jeśli nie zostały wprowadzone wszystkie dane:
            if (Dane()==false) //zastosowanie funkcji Dane()
            {
                MessageBox.Show("Wprwadź wszystkie dane!", "brak danych",
                                 MessageBoxButtons.OK); //"wyskakujące" okienko z informacją
            }
            else //jeśli wprowadzono wszystkie dane nastąpi utworzenie nowego obiektu:
            {
                double pensja = Convert.ToDouble(textBoxPensja.Text); //konwersja podanej pensji na typ double
                string stanowisko = comboBoxStanowisko.SelectedItem.ToString(); //konwersja wybranego stanowiska na typ string
                //jeśli wybrane stanowisko to "kierownik":
                if (stanowisko == "kierownik")
                {
                    Kierownik k1 = new Kierownik
                    (textBoxImie.Text, textBoxNazwisko.Text, stanowisko, pensja); //utworzenie nowego obiektu klasy Kierownik
                    p.Add(k1); //dodanie tego obiektu do listy p
                    Dodaj_Obiekt_Listy(k1); //wyświetlenie nowego obiektu w DataGridView za pomocą funkcji Dodaj_Obiekt_Listy()
                }
                //jeśli wybrane stanowisko to "lider":
                else if (stanowisko == "lider")
                {
                    Lider l1 = new Lider
                    (textBoxImie.Text, textBoxNazwisko.Text, stanowisko, pensja); //utworzenie nowego obiektu klasy Lider
                    p.Add(l1); //dodanie tego obiektu do listy p
                    Dodaj_Obiekt_Listy(l1); //wyświetlenie nowego obiektu w DataGridView za pomocą funkcji Dodaj_Obiekt_Listy()
                }
                //jeśli wybrane stanowisko to "pracownik produkcji":
                else if (stanowisko == "pracownik produkcji")
                {
                    Pracownik_produkcji p1 = new Pracownik_produkcji
                    (textBoxImie.Text, textBoxNazwisko.Text, stanowisko, pensja); //utworzenie nowego obiektu klasy Pracownik_produkcji
                    p.Add(p1); //dodanie tego obiektu do listy p
                    Dodaj_Obiekt_Listy(p1); //wyświetlenie nowego obiektu w DataGridView za pomocą funkcji Dodaj_Obiekt_Listy()
                }
            }
        }

        //PRZYCISK DO USUWANIA PRACOWNIKA 
        private void buttonUsun_Click(object sender, EventArgs e)
        {
            Usun_Wiersz(textBoxID.Text.ToString()); //usunięcie obiektu za pomocą funkcji Usun_wiersz(), jako parametr podane jest id wpisane przez użytkownika do textboxa "id", przekonwertowane do typu string
        }

        //PRZYCISK OBSŁUGUJĄCY WYSZUKIWANIE PRACOWNIKA
        private void buttonSzukaj_Click(object sender, EventArgs e)
        {
            //jeśli wybrano kolumnę i wpisano frazę do wyszukania:
            if(comboBoxKolumny.SelectedIndex >= 0 && textBoxFraza.Text != string.Empty)
            {
                //jeśli kryteria wyszukiwanie zostały zmienione:
                if(textBoxFraza.Text != _szukanaFraza || comboBoxKolumny.SelectedIndex != _szukanaKolumnaID)
                {  
                    //aktualizacja zmiennych przechowujących kryteria wyszukiwania:
                    _szukanaFraza = textBoxFraza.Text;
                    _szukanyWierszID = 0;
                    _szukanaKolumnaID = comboBoxKolumny.SelectedIndex;
                }
                Szukaj(); //wywołanie funkcji Szukaj()
            }
            //jeśli nie wybrano kolumny i nie wpisano frazy do wyszukania:
            else 
            {
                MessageBox.Show("Proszę wprowadzić frazę oraz wybrać kolumnę"); //wyskakujące okienko z informacją
            }
        }

       
        //PRZYCISK OBSŁUGUJĄCY AWANS PRACOWNIKA
        private void buttonAwans_Click(object sender, EventArgs e)
        {
            Awansuj_Pracownika(textBoxID.Text.ToString()); //funkcja Awnasuj_Pracownika, jako parametr id, wpisane przez użytkownika do textboxa "id" i przekonwertowane na typ string
        }

       
        //PRZYCISK OBSŁUGUJĄCY DAWANIE PODWYŻKI
        private void buttonPodwyzka_Click(object sender, EventArgs e)
        {
            Daj_Podwyzke(textBoxID.Text.ToString()); //funkcja Awnasuj_Pracownika, jako parametr id wpisane przez użytkownika przekonwertowane na typ string
        }
    }
}
