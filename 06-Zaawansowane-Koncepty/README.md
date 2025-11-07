# 06 - Zaawansowane Koncepty

## 🎯 Cel Modułu
Opanowanie nowoczesnych technik programowania w C#. Po tym module będziesz pisać profesjonalny kod.

## 📚 Tematy

### 06.1 - Przestrzenie Nazw (Namespaces)
- Organizacja kodu
- `using` directive
- Namespaces zagnieżdżone
- Unikanie konfliktów nazw
- **Umiejętność:** Logiczna organizacja projektów

### 06.2 - Dyrektywy Preprocesora
- `#if`, `#else`, `#endif`
- `#define`
- `#warning`, `#error`
- Kompilacja warunkowa
- **Umiejętność:** Warunkowa kompilacja kodu

### 06.3 - LINQ (Language Integrated Query)
- `from`, `select`, `where`
- `OrderBy`, `GroupBy`, `Join`
- Metody extension
- Query vs method syntax
- **Umiejętność:** Zaawansowane zapytania na danych

### 06.4 - Delegaty, Eventy, Lambda
- Delegaty - typy wskaźników na metody
- `event` keyword
- Wyrażenia lambda `=>`
- Anonymous methods
- **Umiejętność:** Programowanie zdarzeniowe

### 06.5 - Generyki
- Generyczne klasy `<T>`
- Generyczne metody
- Ograniczenia typu (constraints)
- Variance
- **Umiejętność:** Typ-bezpieczne, reużywalne komponenty

### 06.6 - Reflection
- `Type` class
- `MethodInfo`, `PropertyInfo`
- Dynamiczne tworzenie instancji
- Inspekcja metadanych
- **Umiejętność:** Runtime introspection

---

## 📁 Struktura Folderów

```
06-Zaawansowane-Koncepty/
├── 06.1-Przestrzenie-Nazw/
│   ├── Program.cs
│   ├── README.md
│   └── ZADANIA.md
├── 06.2-Dyrektywy-Preprocesora/
│   ├── Program.cs
│   ├── README.md
│   └── ZADANIA.md
├── 06.3-LINQ/
│   ├── Program.cs
│   ├── README.md
│   └── ZADANIA.md
├── 06.4-Delegaty-Eventy-Lambda/
│   ├── Program.cs
│   ├── README.md
│   └── ZADANIA.md
├── 06.5-Generyki/
│   ├── Program.cs
│   ├── README.md
│   └── ZADANIA.md
├── 06.6-Reflection/
│   ├── Program.cs
│   ├── README.md
│   └── ZADANIA.md
└── README.md
```

---

## 🔥 Porównanie: Lambda vs Anonymous vs Named Methods

```csharp
// Named method
int Add(int a, int b) => a + b;

// Anonymous method
Func<int, int, int> add2 = delegate(int a, int b) { return a + b; };

// Lambda expression
Func<int, int, int> add3 = (a, b) => a + b;
```

---

## 🎯 Przykład LINQ

```csharp
var liczby = new List<int> { 1, 2, 3, 4, 5 };

// Znajdź wszystkie liczby parzyste, pomnóż przez 2, posortuj malejąco
var wynik = liczby
    .Where(x => x % 2 == 0)
    .Select(x => x * 2)
    .OrderByDescending(x => x)
    .ToList();
// Rezultat: [8, 4]
```

---

## 🔍 Generyki - Przykład

```csharp
// Bez generyk - trudne w użyciu
public class Lista
{
    public object[] Items { get; set; }
}

// Z generik - type-safe
public class Lista<T>
{
    public T[] Items { get; set; }
}

// Użycie
var listy = new Lista<string>(); // Wyłącznie stringi!
```

---

## ✅ Checklist Nauki

- [ ] Znam namespaces i `using`
- [ ] Wiem co to dyrektywy preprocesora
- [ ] Potrafię używać LINQ
- [ ] Rozumiem lambdas
- [ ] Znam delegaty i eventy
- [ ] Wiem czym są generyki
- [ ] Miałem contact z Reflection

---

## 🎯 Cel Końcowy

Po tym module powinieneś:
✅ Pisać LINQ queries  
✅ Używać lambdas efektywnie  
✅ Pracować z delegatami i eventami  
✅ Tworzyć generyczne komponenty  
✅ Rozumieć zaawansowaną składnię C#  

**Następnie:** Przejdź do 07-Obsługa-Bledow-i-IO/ 🚀

