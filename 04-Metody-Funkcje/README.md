# 04 - Metody i Funkcje

## 🎯 Cel Modułu
Pisanie modułowego kodu poprzez metody. Po tym module będziesz tworzyć czysty, reużywalny kod.

## 📚 Tematy

### 04.1 - Definiowanie Metod
- Składnia metody
- Typ zwracany
- Parametry
- Ciało metody
- **Umiejętność:** Tworzenie własnych funkcji

### 04.2 - Parametry i Zwracane Wartości
- Parametry wartościowe vs referencyjne
- `ref` i `out`
- `params` - zmienna liczba parametrów
- Domyślne wartości parametrów
- **Umiejętność:** Flexibilne przekazywanie danych

### 04.3 - Przeładowanie Metod
- Wiele wersji tej samej metody
- Różne sygnatury
- Zasady przeładowania
- **Umiejętność:** Polimorfizm na poziomie metod

### 04.4 - Hermetyzacja i Access Modifiers
- `public` - dostęp wszędzie
- `private` - dostęp wewnątrz klasy
- `protected` - dostęp w klasie i pochodnych
- `internal` - dostęp w assembly
- **Umiejętność:** Kontrola dostępu do kodu

### 04.5 - Typy Puste (Nullable)
- `null` - brak wartości
- `?` - typ nullable
- `??` - operator łączenia null
- `?.` - warunkowy dostęp
- **Umiejętność:** Bezpieczne operacje na danych

---

## 📁 Struktura Folderów

```
04-Metody-Funkcje/
├── 04.1-Definiowanie-Metod/
│   ├── Program.cs
│   ├── README.md
│   └── ZADANIA.md
├── 04.2-Parametry-Wartosci/
│   ├── Program.cs
│   ├── README.md
│   └── ZADANIA.md
├── 04.3-Przeladowanie-Metod/
│   ├── Program.cs
│   ├── README.md
│   └── ZADANIA.md
├── 04.4-Hermetyzacja/
│   ├── Program.cs
│   ├── README.md
│   └── ZADANIA.md
├── 04.5-Typy-Puste/
│   ├── Program.cs
│   ├── README.md
│   └── ZADANIA.md
└── README.md
```

---

## 🔍 Zasady DRY (Don't Repeat Yourself)

❌ ZŁE - Kod powtarzany:
```csharp
int wynik1 = a + b;
int wynik2 = c + d;
int wynik3 = e + f;
```

✅ DOBRE - Używamy metody:
```csharp
int Dodaj(int x, int y) => x + y;
int wynik1 = Dodaj(a, b);
int wynik2 = Dodaj(c, d);
int wynik3 = Dodaj(e, f);
```

---

## ✅ Checklist Nauki

- [ ] Potrafię deklarować metody
- [ ] Znam różnicę między parametrami wartościowymi a referencyjnymi
- [ ] Rozumiem `ref` i `out`
- [ ] Wiem co to przeładowanie metod
- [ ] Znam access modifiers
- [ ] Rozumiem nullable types

---

## 🎯 Cel Końcowy

Po tym module powinieneś:
✅ Pisać funkcje i metody  
✅ Przekazywać dane do metod  
✅ Zwracać wartości  
✅ Kontrolować dostęp do kodu  
✅ Bezpiecznie pracować z wartościami null  

**Następnie:** Przejdź do 05-Programowanie-Obiektowe/ 🚀

