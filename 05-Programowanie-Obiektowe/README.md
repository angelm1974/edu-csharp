# 05 - Programowanie Obiektowe (OOP)

## 🎯 Cel Modułu
Projektowanie i tworzenie złożonych systemów poprzez obiekty. Po tym module będziesz architektem oprogramowania.

## 📚 Tematy

### 05.1 - Klasy i Obiekty
- Definiowanie klas
- Pola (fields) vs właściwości (properties)
- Tworzenie instancji
- `new` operator
- **Umiejętność:** Modelowanie rzeczywistości

### 05.2 - Konstruktory i Właściwości
- Konstruktor domyślny
- Konstruktor z parametrami
- Właściwości (properties) z getterami i setterami
- Auto-properties
- **Umiejętność:** Inicjalizacja obiektów

### 05.3 - Dziedziczenie
- Klasa bazowa (base)
- Klasa pochodna (derived)
- Constructor chaining
- `base` keyword
- Zasada "is-a"
- **Umiejętność:** Reużywanie kodu

### 05.4 - Polimorfizm
- Przesłanianie metod (`override`)
- `virtual` keyword
- `abstract` keyword
- Zasada Liskov Substitution Principle
- **Umiejętność:** Elastyczne projektowanie

### 05.5 - Klasy Abstrakcyjne
- Definiowanie klas abstrakcyjnych
- Metody abstrakcyjne
- Kiedy używać abstract
- **Umiejętność:** Definiowanie kontraktów

### 05.6 - Interfejsy
- Definiowanie interfejsów
- Implementacja interfejsów
- Wiele implementacji
- Interfejsy vs klasy abstrakcyjne
- **Umiejętność:** Umowa między klasami

---

## 📁 Struktura Folderów

```
05-Programowanie-Obiektowe/
├── 05.1-Klasy-Obiekty/
│   ├── Program.cs
│   ├── README.md
│   └── ZADANIA.md
├── 05.2-Konstruktory-Wlasciwosci/
│   ├── Program.cs
│   ├── README.md
│   └── ZADANIA.md
├── 05.3-Dziedziczenie/
│   ├── Program.cs
│   ├── README.md
│   └── ZADANIA.md
├── 05.4-Polimorfizm/
│   ├── Program.cs
│   ├── README.md
│   └── ZADANIA.md
├── 05.5-Klasy-Abstrakcyjne/
│   ├── Program.cs
│   ├── README.md
│   └── ZADANIA.md
├── 05.6-Interfejsy/
│   ├── Program.cs
│   ├── README.md
│   └── ZADANIA.md
└── README.md
```

---

## 🏗️ Cztery Filary OOP

| Filar | Opis | Przykład |
|-------|------|---------|
| **Enkapsulacja** | Ukrywanie wewnętrznych szczegółów | private pola, public properties |
| **Dziedziczenie** | Reużywanie kodu poprzez hierarchię | Zwierze → Pies, Kot |
| **Polimorfizm** | Wiele form tej samej metody | Zwierze.Głos() → Pies.Głos() vs Kot.Głos() |
| **Abstrakcja** | Ukrywanie złożoności | IAnimal interface |

---

## 📊 Hierarchia Klas - Przykład

```
┌─────────────────┐
│   Zwierze       │ (Klasa bazowa)
│ - Imię          │
│ + Głos()        │
│ + Jeść()        │
└────────┬────────┘
         │
    ┌────┴────┐
    │         │
┌───▼───┐  ┌──▼────┐
│  Pies │  │  Kot  │ (Klasy pochodne)
│-Rasa  │  │-Kolor │
│+Głos()│  │+Głos()│
└───────┘  └───────┘
```

---

## ✅ Checklist Nauki

- [ ] Potrafię definiować klasy
- [ ] Znam konstruktory i właściwości
- [ ] Rozumiem dziedziczenie
- [ ] Wiem co to polimorfizm
- [ ] Znam klasy abstrakcyjne
- [ ] Rozumiem interfejsy

---

## 🎯 Cel Końcowy

Po tym module powinieneś:
✅ Projektować architekturę aplikacji  
✅ Tworzyć hierarchie klas  
✅ Pisać czysty, obiektowy kod  
✅ Rozumieć SOLID principles  
✅ Tworzyć rozszerzalne systemy  

**Następnie:** Przejdź do 06-Zaawansowane-Koncepty/ 🚀

