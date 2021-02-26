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
        //FUNKCJA SPRAWDZAJĄCA CZY WSZYSTKIE DANE ZOSTALY WPROWADZONE (przy dodawaniu pracownika buttonDodaj)
        private bool Dane()
        {
            //jeśli wszystkie pola są wypełnione funkcja zwraca true
            if (textBoxImie.Text != "" && textBoxNazwisko.Text != "" &&
                 textBoxPensja.Text != "" && comboBoxStanowisko.SelectedItem != null) return true;
            //jeśli conamniej jedno pole jest puste funkcja zwraca false
            else if (textBoxImie.Text == "" || textBoxNazwisko.Text == "" ||
               textBoxPensja.Text == "" || comboBoxStanowisko.SelectedItem == null) return false;
            else return false;
        }

        //FUNKCJA DODAJACA PRACOWNIKA
        private void Dodaj_Obiekt_Listy(Pracownik item) //obiekt klasy Pracownik jako parametr
        {
            DataGridViewRow row = new DataGridViewRow(); //utworzenie nowego wiersza DataGridView
            row.CreateCells(dataGridView1); //wyczysczenie istniejących komórek i ustawienie ich szablonu zgodnie z podanym szablonem DataGridView
            //wypełnianie kolejnych komorek DataGridView wartosciami pol obiektu klasy Pracownik:
            row.Cells[0].Value = item.Id;
            row.Cells[1].Value = item.Imie;
            row.Cells[2].Value = item.Nazwisko;
            row.Cells[3].Value = item.Stanowisko;
            row.Cells[4].Value = item.Pensja;
            dataGridView1.Rows.Add(row); //dodanie utworzonego wiersza do DataGridView
            //wyczyszczenie textboxow po dodaniu nowego obiektu:
            textBoxImie.Text = "";
            textBoxNazwisko.Text = "";
            textBoxPensja.Text = "";
            comboBoxStanowisko.SelectedItem = null;
        }

        //ODŚWIEŻANIE LISTY PRACOWNIKOW
        private void Odswiez()
        {
            dataGridView1.Rows.Clear(); //wyczyszczenie wierszy DataGridView
            //wypełnienie DataGridView kolejnymi obiektami z listy p:
            for (int i = 0; i < p.Count; i++)
            {
                Dodaj_Obiekt_Listy(p[i]);
            }
        }

        //FUNKCJA USUWAJACA PRACOWNIKA (wskazanie pracownika poprzez jego id)
        private void Usun_Wiersz(string id) //parametrem będzie id wpisane przez użytkownika do textboxa "id"
        {
            int ile = dataGridView1.Rows.Count; //zmienna przechowująca aktualną ilość wierszy DataGridView
            int indeks = 0; //zmienna do wyznaczania indeksu wybranego obiektu(pracownika) (id pracownika nie zawsze będzie odpowiadało jego indeksowi na liście p i w DataGridView!)
            try
            {
                //pętla przchodząca po wszystkich wierszach DataGridView, w celu znalezienia wskazanego przez użytkownika id
                for (int i = 0; i <= ile; i++)
                {
                    string id_w_tabeli = dataGridView1[0, i].Value.ToString(); //zmienna przechowująca wartość komorki "Id" z aktualnego wiersza DataGridView
                    
                   // jeśli id wpisane przez użytkownika będzie rowne id w DataGridView (czyli jeśli znaleziono wiersz(pracownika), ktorego użytkownik chce usunąć):
                    if (id == id_w_tabeli)
                    {
                        indeks += dataGridView1[0, i].RowIndex; //do zmiennej indeks dodajemy indeks wyznaczonego wiersza DataGridView
                        
                       //jeśli użytkownik potwierdzi, że chce usunąć danego pracownika (funkcja Czy_usunac() zwroci true):    
                        if (Czy_usunac(p[indeks]) == true)
                        {
                            dataGridView1.Rows.RemoveAt(indeks); //usunięcie wyznaczonego poprzez zmienną indeks wiersza DataGridView
                            p.RemoveAt(indeks); //usunięcie z listy p obiektu o wyznaczonym indeksie
                            textBoxID.Text = ""; //wyczyszcznie zawartości textboxa "id"
                            // Odswiez();
                            break; //przerwanie pętli
                        }
                        //jeśli funkcja Czy_usunac() zwroci wartość false:
                        else
                        {
                            textBoxID.Text = ""; //wyczyszczenie zawartości textboxa "id"
                            break; //przerwanie pętli
                        }
                    }
                }
            }
            catch (NullReferenceException e) //jeśli nastąpi proba odwołania się do obiektu o wartości null, czyli np. jeśli użytkownik wskaże indeks usuniętego już wcześniej obiektu:
            {
                textBoxID.Text = "nie ma takiego id"; //w textboxie "id" pojawi się informacja o braku wskazanego id
            }
        }

        //FUNKCJA DO POTWIERDZANIA USUNIĘCIA PRACOWNIKA, wykorzystywana w funkcji Usun_Wiersz(string id)
        private bool Czy_usunac(Pracownik item) //obiekt klasy Pracownik jako parametr
        {
            //treść wiadomości dla użytkownika (zawierająca imię, nazwisko oraz id pracownika, ktorego użytkownik chce usunąć):
            string messege = "Czy na pewno chcesz usunąć pracownika "
                             + item.Imie + " " + item.Nazwisko + " o id " + item.Id + "?";
            //opis wyskakującego okienka:
            string caption = "Usuwanie pracownika";
            //wyskakujące okienko zawieracjące wyżej zdefiniowane wiadomość i opis, użytkownik ma dwie opcje do kliknięcia: tak lub nie:
            var box = MessageBox.Show(messege, caption,
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
            if (box == DialogResult.No) return false; //jeśli użytkownik kliknie "no" funkcja zwraca false, w przeciwnym wypadku zwraca true
            else return true;
        }


        //ZMIENNE POTRZEBNE DO WYSZUKIWANIA FRAZY, przechowujące aktualne kryteria wyszukiwania
        private string _szukanaFraza = string.Empty; //zmienna przechowujaca aktualnie wyszukiwany tekst
        private int _szukanaKolumnaID = 0; //zmienna przechowująca aktualnie wybraną kolumnę do przeszukiwania
        private int _szukanyWierszID = 0; //zmienna przechowująca numer wiersza, od ktorego będzie się rozpoczynało wyszukiwanie
        
        //FUNKCJA DO WYSZUKIWANIA ELEMENTÓW W BAZIE
        private void Szukaj()
        {
            int IdKolumny = comboBoxKolumny.SelectedIndex; //id wybranej kolumny
            string wpisana_fraza = textBoxFraza.Text.ToUpper(); //wpisana przez użytkownika fraza
            bool znaleziono = false; //przechowuje informację, czy wyszukiwana fraza została znaleziona

            //pętla przechodząca po wierszach DataGridView
            for (int i = _szukanyWierszID; i < dataGridView1.Rows.Count; i++)
            {
                try
                {
                    string kolumna = dataGridView1.Rows[i].Cells[IdKolumny].Value.ToString().ToUpper(); //tekst znajdujący się w wybranej kolumnie
                    //jeśli tekst w wybranej kolumnie zawiera wyszukiwaną frazę:
                    if (kolumna.Contains(wpisana_fraza)) 
                    {
                        znaleziono = true; //szukana fraza została znaleziona
                        //aktualizacja numeru wiersza, od ktorego rozpocznie się następne wyszukiwanie:
                        //jeśli wiersz, w ktorym znalezniono wyszukiwaną frazę nie jest ostanim wierszem DataGridView:
                        if(i <= dataGridView1.Rows.Count - 1)
                         {
                             _szukanyWierszID = i + 1; //kolejne wyszukiwanie rozpocznie się od wiersza, ktory jest następny po wierszu, w ktorym daną frazę znaleziono
                         }
                         //jeśli wiersz, w ktorym znaleziono wyszukiwaną frazę jest ostatnim wierszem DataGridView:
                         else
                         {
                             _szukanyWierszID = 0; //kolejne wyszukiwanie rozpocznie się od pierwszego wiersza
                         }
                        dataGridView1.Rows[i].Selected = true; //zaznaczenie wiersza, w ktorym znalezniono frazę
                        dataGridView1.FirstDisplayedScrollingRowIndex = i; //ustawienie wiersza, w ktorym znaleziono frazę jako pierwszy wyświetlany w DataGridView
                        break; //przerwanie pętli
                    }
                }
                catch (NullReferenceException e) { textBoxFraza.Text = "nie znaleziono"; }
            }
            if (!znaleziono) //jeśli nie znaleziono wyszukiwanej frazy zostanie wyświetlona stosowna informacja:
            {
                MessageBox.Show("Nie znaleziono szukanej frazy");
                _szukanyWierszID = 0;
            }

        }

        //FUNKCJA DO AWANSOWANIA PRACOWNIKA
        private void Awansuj_Pracownika(string id) //parametrem będzie id wpisane przez użytkownika do textboxa "id"
        {
            int ile = dataGridView1.Rows.Count; //aktualna ilość wierszy DataGridView
            int indeks = 0; //zmienna do wyznaczania indeksu wybranego obiektu(pracownika) (id pracownika nie zawsze będzie odpowiadało jego indeksowi na liście p i w DataGridView!)
            try
            {
               //pętla przchodząca po wszystkich wierszach DataGridView, w celu znalezienia wskazanego przez użytkownika id
                for (int i = 0; i <= ile; i++)
                {
                    string id_w_tabeli = dataGridView1[0, i].Value.ToString(); //zmienna przechowująca wartość komorki "Id" z aktualnego wiersza DataGridView

                   // jeśli id wpisane przez użytkownika będzie rowne id w DataGridView (czyli jeśli znaleziono wiersz(pracownika), ktorego użytkownik chce usunąć):
                    if (id == id_w_tabeli)
                    {
                        indeks += dataGridView1[0, i].RowIndex; //do zmiennej indeks dodajemy indeks wyznaczonego wiersza DataGridView
                        //jeśli stanowisko wybranego pracownika nie jest rowne "dyrektor":
                        if (p[indeks].Stanowisko != "dyrektor")
                        {
                           //za pomocą metody Awans() następuje podmienienie pola stanowisko w wybranym obiekcie, przy jednoczesnym zachowaniu aktualnej wartości pozostałych pol:
                            p[indeks] = p[indeks].Awans(Convert.ToInt32(id), p[indeks].Imie, p[indeks].Nazwisko, p[indeks].Pensja);
                            MessageBox.Show("awansowano");
                            Odswiez();
                            break; //przerwanie pętli
                        }
                        //jeśli stanowisko wybranego pracownika to "dyrektor" wyświetli się jedynie poniższa informacja (ponieważ w programie nie ustanowiono stanowiska, na ktore możnaby awansować dyrektora):
                        else
                        {
                            MessageBox.Show("nie ma aktualnie wyższego stanowiska niż dyrektor");
                            break; //przerwanie pętli
                        }
                    }
                }
            }
            catch (NullReferenceException e) //jeśli nastąpi proba odwołania się do obiektu o wartości null, czyli np. jeśli użytkownik wskaże indeks usuniętego już wcześniej obiektu:
            {
                textBoxID.Text = "nie ma takiego id";
            }
        }

        //FUNKCJA DO DAWANIA PODWYŻKI
        private void Daj_Podwyzke(string id) //parametrem będzie id wpisane przez użytkownika do textboxa "id"
        {
            int ile = dataGridView1.Rows.Count; //aktualna ilość wierszy DataGridView
            int indeks = 0; //zmienna do wyznaczania indeksu wybranego obiektu(pracownika) (id pracownika nie zawsze będzie odpowiadało jego indeksowi na liście p i w DataGridView!)
            try
            {
               ////pętla przchodząca po wszystkich wierszach DataGridView, w celu znalezienia wskazanego przez użytkownika id
                for (int i = 0; i <= ile; i++)
                {
                    string id_w_tabeli = dataGridView1[0, i].Value.ToString(); // //zmienna przechowująca wartość komorki "Id" z aktualnego wiersza DataGridView
                   
                   // jeśli id wpisane przez użytkownika będzie rowne id w DataGridView (czyli jeśli znaleziono wiersz(pracownika), ktorego użytkownik chce usunąć):
                    if (id == id_w_tabeli)
                    {
                        indeks += dataGridView1[0, i].RowIndex; //do zmiennej indeks dodajemy indeks wyznaczonego wiersza DataGridView
                        //podmiana wartości pola pensja wybranego obiektu, na wartość wyliczoną za pomocą metody Podwyżka():
                        p[indeks].Pensja = p[indeks].Podwyzka(p[indeks].Pensja);
                        Odswiez(); 
                        break; //przerwanie pętli
                    }
                }
            }
            catch (NullReferenceException e) //jeśli nastąpi proba odwołania się do obiektu o wartości null, czyli np. jeśli użytkownik wskaże indeks usuniętego już wcześniej obiektu:
            {
               //w textboxie "id" zostanie wyświetlony następujący komunikat:
                textBoxID.Text = "nie ma takiego id";
            }
        }

    }
}
 