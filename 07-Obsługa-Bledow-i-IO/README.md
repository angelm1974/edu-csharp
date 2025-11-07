# 07 - Obsługa Błędów i I/O

## 🎯 Cel Modułu
Tworzenie aplikacji produkcyjnych, które obsługują błędy i pracują z danymi na dysku. Po tym module będziesz tworzyć stabilne aplikacje.

## 📚 Tematy

### 07.1 - Obsługa Wyjątków
- Try-catch-finally
- Typy wyjątków
- `throw` - rzucanie wyjątków
- Custom exceptions
- `using` statement - zarządzanie zasobami
- **Umiejętność:** Bezpieczna obsługa błędów

### 07.2 - Wyrażenia Regularne
- Pattern matching
- `Regex` class
- `Match`, `Replace`, `Split`
- Znaki specjalne i kwantyfikatory
- **Umiejętność:** Zaawansowana analiza tekstu

### 07.3 - Odczyt i Zapis Plików
- `File` class
- `StreamReader`, `StreamWriter`
- `Path` utilities
- `Directory` operations
- **Umiejętność:** Praca z systemem plików

### 07.4 - Serializacja
- JSON (Newtonsoft.Json, System.Text.Json)
- XML
- Deserializacja
- Custom serialization
- **Umiejętność:** Wymiana danych

---

## 📁 Struktura Folderów

```
07-Obsługa-Bledow-i-IO/
├── 07.1-Obsługa-Wyjatkow/
│   ├── Program.cs
│   ├── README.md
│   └── ZADANIA.md
├── 07.2-Wyrażenia-Regularne/
│   ├── Program.cs
│   ├── README.md
│   └── ZADANIA.md
├── 07.3-Odczyt-Zapis-Plikow/
│   ├── Program.cs
│   ├── README.md
│   └── ZADANIA.md
├── 07.4-Serializacja/
│   ├── Program.cs
│   ├── README.md
│   └── ZADANIA.md
└── README.md
```

---

## ⚠️ Try-Catch-Finally Schemat

```csharp
try
{
    // Kod, który może rzucić wyjątek
    int wynik = int.Parse(wejscie);
}
catch (FormatException ex)
{
    // Obsługa konkretnego błędu
    Console.WriteLine("To nie jest liczba!");
}
catch (Exception ex)
{
    // Obsługa ogólnego błędu
    Console.WriteLine($"Błąd: {ex.Message}");
}
finally
{
    // Kod zawsze się wykonuje (czyszczenie)
    Console.WriteLine("Operacja zakończona.");
}
```

---

## 📝 Praca z Plikami - Przykład

```csharp
// Zapis do pliku
File.WriteAllText("dane.txt", "Cześć świecie!");

// Odczyt z pliku
string zawartość = File.ReadAllText("dane.txt");

// Linie po linii
string[] linie = File.ReadAllLines("dane.txt");
foreach (var linia in linie)
{
    Console.WriteLine(linia);
}

// Stream dla dużych plików
using (var reader = new StreamReader("duzy_plik.txt"))
{
    string linia;
    while ((linia = reader.ReadLine()) != null)
    {
        ProcessLine(linia);
    }
}
```

---

## 🔄 JSON Serializacja - Przykład

```csharp
using System.Text.Json;

class Osoba
{
    public string Imie { get; set; }
    public int Wiek { get; set; }
}

var osoba = new Osoba { Imie = "Jan", Wiek = 30 };

// Serializacja
string json = JsonSerializer.Serialize(osoba);
// {"Imie":"Jan","Wiek":30}

// Deserializacja
var przywrocona = JsonSerializer.Deserialize<Osoba>(json);
```

---

## 🔍 Regex - Przykłady

```csharp
// Email validation
string email = "user@example.com";
bool isValid = Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

// Zamiana
string tekst = "Słowa123 Liczby456";
string oczyszczony = Regex.Replace(tekst, @"\d", "X");
// Wynik: SlowXXX LiczbyXXX

// Podział
string csv = "Jan,Anna,Piotr";
string[] imiona = Regex.Split(csv, ",");
```

---

## ✅ Checklist Nauki

- [ ] Potrafię obsługiwać wyjątki
- [ ] Znam try-catch-finally
- [ ] Rozumiem wyrażenia regularne (regex)
- [ ] Potrafię czytać pliki
- [ ] Potrafię pisać do plików
- [ ] Wiem jak serializować do JSON
- [ ] Znam concept zasobów i `using`

---

## 🎯 Cel Końcowy

Po tym module powinieneś:
✅ Tworzyć odporne aplikacje  
✅ Obsługiwać błędy elegancko  
✅ Pracować z plikami  
✅ Parsować i walidować dane  
✅ Wymienić się danymi (JSON/XML)  

**Następnie:** Przejdź do 08-Aplikacje-Praktyczne/ 🚀

