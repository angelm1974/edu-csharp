Opis kodu programu w C#

-------------------------------------------------
1. Struktura programu
-------------------------------------------------
internal class Program
{
    private static void Main(string[] args)
    {
        Int32 number1 = 5;
        Int32 number2 = 10;

        Console.WriteLine("Sumą 2 + 2 jest {2 + 2}");
        Console.WriteLine($"Sumą 2 + 2 jest {2 + 2}");
        Console.WriteLine($"Sumą {number1} + {number2} jest {number1 + number2}");

        number1 = Int32.Parse(args[0]);
        number2 = Int32.Parse(args[1]);

        Console.WriteLine($"Sumą {number1} + {number2} jest {number1 + number2}");
    }
}

-------------------------------------------------
2. Omówienie
-------------------------------------------------
- internal class Program
  Klasa Program to główny element programu. Słowo "internal" oznacza, że jest widoczna tylko w tym projekcie.

- private static void Main(string[] args)
  Jest to metoda startowa programu – kod zaczyna się wykonywać właśnie od niej.
  - private: dostępna tylko w tej klasie
  - static: nie wymaga tworzenia obiektu klasy
  - void: nie zwraca żadnej wartości
  - string[] args: tablica argumentów przekazywanych z wiersza poleceń

-------------------------------------------------
3. Co to jest args?
-------------------------------------------------
args to tablica typu string[], czyli lista tekstów wpisanych przez użytkownika przy uruchamianiu programu.
Na przykład:
    dotnet run 7 12
Wtedy:
    args[0] = "7"
    args[1] = "12"

-------------------------------------------------
4. Dlaczego indeksy zaczynają się od 0?
-------------------------------------------------
W większości języków programowania pierwszy element tablicy ma indeks 0.
Dzięki temu komputer łatwo oblicza położenie elementu w pamięci (adres_początkowy + indeks).

Przykład:
    args = ["7", "12"]
    args[0] → "7"
    args[1] → "12"

-------------------------------------------------
5. Zmienne
-------------------------------------------------
Int32 number1 = 5; – tworzy zmienną typu całkowitego i przypisuje jej wartość 5.
Int32 number2 = 10; – tworzy drugą zmienną o wartości 10.

-------------------------------------------------
6. Wyświetlanie danych
-------------------------------------------------
Console.WriteLine() – wypisuje tekst w konsoli.

Bez znaku $:
    Console.WriteLine("Sumą 2 + 2 jest {2 + 2}");
    → wynik: Sumą 2 + 2 jest {2 + 2}

Z użyciem $ (interpolacja):
    Console.WriteLine($"Sumą 2 + 2 jest {2 + 2}");
    → wynik: Sumą 2 + 2 jest 4

Interpolacja pozwala wstawiać wartości zmiennych:
    Console.WriteLine($"Sumą {number1} + {number2} jest {number1 + number2}");
    → wynik: Sumą 5 + 10 jest 15

-------------------------------------------------
7. Parsowanie argumentów
-------------------------------------------------
number1 = Int32.Parse(args[0]);
number2 = Int32.Parse(args[1]);

Funkcja Int32.Parse() zamienia tekst (np. "7") na liczbę całkowitą (7).

-------------------------------------------------
8. Wynik działania programu
-------------------------------------------------
Jeśli uruchomimy:
    dotnet run 8 14
to wynik będzie:
    Sumą 2 + 2 jest {2 + 2}
    Sumą 2 + 2 jest 4
    Sumą 5 + 10 jest 15
    Sumą 8 + 14 jest 22

-------------------------------------------------
9. Podsumowanie
-------------------------------------------------
| Linia                         | Co robi                                 |
|-------------------------------|------------------------------------------|
| Int32 number1 = 5;            | tworzy zmienną typu całkowitego          |
| Console.WriteLine()           | wypisuje tekst                          |
| args[0]                       | pierwszy argument z linii poleceń        |
| Int32.Parse()                 | zamienia tekst na liczbę                 |
| Main(string[] args)           | punkt startowy programu                 |

-------------------------------------------------

