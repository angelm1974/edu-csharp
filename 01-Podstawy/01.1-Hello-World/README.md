# 01.1 - Hello World

## 🎯 Cel
Uruchomienie pierwszego programu C# i zrozumienie struktury programu.

## 📚 Koncepty
- Struktura programu C#
- Metoda Main()
- Console.WriteLine()
- Namespace

## 📝 Program

```csharp
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cześć świecie!");
        }
    }
}
```

## 📖 Wyjaśnienie

```
using System;               // Importujemy namespace System
                           // Zawiera Console i inne podstawowe klasy

namespace HelloWorld       // Organizujemy kod w przestrzeń nazw
{
    class Program          // Definiujemy klasę Program
    {
        static void Main() // Entry point - tu zaczyna się program
        {
            // Wypisujemy tekst na ekran
            Console.WriteLine("Cześć świecie!");
        }
    }
}
```

## 🚀 Jak Uruchomić?

```bash
# Przejdź do folderu projektu
cd 01-Podstawy/01.1-Hello-World

# Uruchom program
dotnet run
```

## 📤 Spodziewany Output

```
Cześć świecie!
```

## 💡 Ciekawostki

- `static void Main()` musi być w programie
- `void` oznacza, że metoda nic nie zwraca
- `Console.WriteLine()` dodaje nową linię po tekście
- `Console.Write()` nie dodaje nowej linii

## ✏️ Zadania

1. Zmień tekst na "Witaj C#!"
2. Dodaj więcej linii tekstu
3. Sprawdź różnicę między `WriteLine` a `Write`

---

[← Wróć do 01-Podstawy](../README.md)

