using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV
{
    /// <summary>
    /// Curriculum_vitae, résumé
    /// </summary>
    class Curriculum_vitae
    {

        /// <summary>
        /// Podstawowe dane osobowe
        /// </summary>
        void Dane_osobowe()
        {
            string Imie = "Piotr";
            string Drugie_imie = "Robert";
            string Nazwisko = "Osłowski";
            string email = "piotr.oslowski@gmail.com";
            string adres = "08-112 Wiśniew, ul. Szkolna 11";
            string telefon = "+48 792 575 074";
        }

        /// <summary>
        /// Doświadczenie zawodowe
        /// </summary>
        /// <param name="lp"></param>
        void Doswiadczenie_zawodowe(int lp)
        {
            if (lp == 1)
            {
                string okres = "2007-";
                string nazwa = "Zawodowa Specjalistyczna Rodzina Zastępcza - Siedlce";
                string[] opis = new string[2];
                opis[1] = "Rodziną zawodową jestem od roku 2001. W doku 2007 Powiat Siedlecki podpisał z nami umowę na pełnienie funkcji Zawodowej Specjalistycznej Rodziny Zastępczej. Obiecnie pod naszą opieką jest trójka dzieci z orzeczoną niepełnosprawnością.";
            }
            if (lp == 2)
            {
                string okres = "1998-";
                string nazwa = "SEDKOMP Spółka Jawna Sawicki, Sikora - Siedlce";
                string stanowisko = "specjalista d/s systemów MSP";
                string[] opis = new string[3];
                opis[1] = "1998- Wdrożenia systemów kadrowo-płacowych CDN PIK w firmach i instytucjach: ZUS Szczecin, ZUS Olsztyn, ZUS Białystok, ZUS Siedlce, ZUS Jasło, ZUS Ostrołęka, ZUS Wałbrzych, ZUS Radzyń Podlaski, Baumann Mostostal, Zentis Polska, Telefony Podlaskie, Starostwo Powiatowe w Łukowie, WIWet Siedlce, ASAJ, ELMO, WSA (Wojewódzki Sąd Administracyjny w Warszawie) i wiele, wiele innych... ";
                opis[2] = "Czynny udział w pracach programistycznych (Delphi, C#) przy wdrożenieniu systemu Comarch CDN XL w hurtowni ASAJ (2005-2006) – największe wdrożenie firmy SEDKOMP.";
                opis[3] = "Prace programistyczne, dopisywanie funkcjonalności do istniejących programów (Comarch ERP XL), pisanie własnych autorskich rozwiązań.";
            }
            if (lp == 3)
            {
                string okres = "2002-2003";
                string nazwa = "Gimnazjum w Wiśniewie O/Śmiary";
                string stanowisko = "Nauczyciel informatyki";
            }
            if (lp == 4)
            {
                string okres = "2002-2003";
                string nazwa = "Szkoła Podstawowa w Śmiarach";
                string stanowisko = "Nauczyciel informatyki";
            }
            if (lp == 5)
            {
                string okres = "2013-";
                string nazwa = "Wielka Orkiestra Świątecznej Pomocy";
                string stanowisko = "Służba Informacyjna - Wolontariat Pokojowy Patrol – Przystanek Woodstock 2013-2015";
            }
            if (lp == 6)
            {
                string okres = "2015-";
                string nazwa = "Planszówki w Siedlcach";
                string stanowisko = "Organizator";
                string opis = "Cykliczny cykl spotkań mających jeden cel: granie w gry planszowe";
            }

        }

        /// <summary>
        /// Wykształcenie
        /// </summary>
        /// <param name="lp"></param>
        void Wyształcenie(int lp)
        {
            if (lp == 1)
            {
                string okres = "1999-2003";
                string nazwa = "Akademia Podlaska";
                string specjalność = "Nauczyciel informatyki";

            }
            if (lp == 2)
            {
                string okres = "1997-1998";
                string nazwa = "Politechnika Białostocka - Wydział Informatyki";
            }
            if (lp == 3)
            {
                string okres = "1992-1997";
                string nazwa = "Technikum Elektroniczne w Siedlcach";
                string specjalość = "Elektronika ogólna";
                string[] opis = new string[3];
                opis[1] = "Ukończyłem z najlepszą oceną z zawodu";
                opis[2] = "I miejsce w etapie okręgowym Olimpiady Wiedzy Technicznej";
            }
        }

        /// <summary>
        /// Inne kwalifikacje, kursy, szkolenia
        /// </summary>
        void Inne_kwalifikacje()
        {
            string[] kwalifikacja = new string[14];
            kwalifikacja[1] = "Znajomość języka angielskiego w stopniu podstawowym (czytanie)";
            kwalifikacja[2] = "Prawo jazdy kategorii AB";
            kwalifikacja[3] = "Znajomość systemów operacyjnych MS Windows";
            kwalifikacja[4] = "Dobra znajomość pakietów biurowych MS Office, Open Office";
            kwalifikacja[5] = "Znajomość języków programowania: Delphi, C++, Python, C#";
            kwalifikacja[6] = "Znajomość baz danych MSSQL, MySQL, SQLite";
            kwalifikacja[7] = "Dobra znajomość przepisów płacowo-kadrowych";
            kwalifikacja[8] = "Znajomość oprogramowania firmy Comarch CDN: Klasyka, Optima, XL";
            kwalifikacja[9] = "Znajomość oprogramowania ZUS Płatnik";
            kwalifikacja[10] = "Członek stowarzyszenia Mensa Polska";
            kwalifikacja[11] = "Służba Informacyjna - tzw. masówka";
            kwalifikacja[12] = "Znajomość oprogramowania firmy Soneta: Enova Płace i Kadry";
            kwalifikacja[13] = "Świadectwo klasy C operatora urządzeń radiowych w służbie radiokomunikacyjnej amatorskiej";


        }

        /// <summary>
        /// Zainteresowania, hobby
        /// </summary>
        void Zainteresowania()
        {
            string[] zainteresowanie = new string[5];
            zainteresowanie[1] = "Komputery, internet";
            zainteresowanie[2] = "Nowe technologie teleinformatyczne";
            zainteresowanie[3] = "Turystyka";
            zainteresowanie[4] = "Jazda na rowerze, motocyklu";
        }

        /// <summary>
        /// Klauzula
        /// </summary>
        void Klauzula()
        {
            string klauzula = "Wyrażam zgodę na przetwarzanie moich danych osobowych zawartych w mojej ofercie pracy dla potrzeb niezbędnych do realizacji procesu rekrutacji zgodnie z ustawą z dnia 29 sierpnia 1997 r. o ochronie danych osobowych (Dz. U. z 2002 r. Nr 101, poz. 926, ze zm.)";
        }



    }
}
