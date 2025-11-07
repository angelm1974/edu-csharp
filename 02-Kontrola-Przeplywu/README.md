# 02 - Kontrola Przeplywu

## 🎯 Cel Modułu
Nauka podejmowania decyzji i powtarzania operacji. Po tym module będziesz tworzać programy, które podejmują decyzje na podstawie danych.

## 📚 Tematy

### 02.1 - Instrukcje Warunkowe
- Instrukcja `if`
- `else` i `else if`
- Operatory warunkowe: `? :`
- Instrukcja `switch`
- **Umiejętność:** Warunkowe wykonanie kodu

### 02.2 - Pętle
- Pętla `for` - pętle przebiegające
- Pętla `while` - pętle warunkowe
- Pętla `do-while` - pętle z gwarancją wykonania
- Pętla `foreach` - iteracja po kolekcjach
- **Umiejętność:** Powtarzanie kodu

### 02.3 - Instrukcje Skoku
- `break` - wyjście z pętli
- `continue` - przejście do następnej iteracji
- `return` - wyjście z metody
- `goto` (omawiane, ale nie polecane)
- **Umiejętność:** Kontrola przeplywu wykonania

---

## 📁 Struktura Folderów

```
02-Kontrola-Przeplywu/
├── 02.1-Instrukcje-Warunkowe/
│   ├── Program.cs
│   ├── README.md
│   └── ZADANIA.md
├── 02.2-Petle/
│   ├── Program.cs
│   ├── README.md
│   └── ZADANIA.md
├── 02.3-Instrukcje-Skoku/
│   ├── Program.cs
│   ├── README.md
│   └── ZADANIA.md
└── README.md
```

---

## 🔄 Przykład Przeplywu

```
START
  ↓
Czy liczba > 0?
  ├─ TAK → Wypisz "dodatnia" → KONIEC
  ├─ NIE → Czy liczba < 0?
  │         ├─ TAK → Wypisz "ujemna" → KONIEC
  │         └─ NIE → Wypisz "zero" → KONIEC
```

---

## ✅ Checklist Nauki

- [ ] Znam instrukcję `if-else`
- [ ] Znam instrukcję `switch`
- [ ] Potrafię używać pętli `for`
- [ ] Potrafię używać pętli `while`
- [ ] Potrafię używać pętli `foreach`
- [ ] Wiem kiedy używać `break` i `continue`

---

## 🎯 Cel Końcowy

Po tym module powinieneś:
✅ Podejmować decyzje w kodzie  
✅ Powtarzać kod używając pętli  
✅ Kontrolować przebieg programu  
✅ Pisać logikę warunkową  

**Następnie:** Przejdź do 03-Dane-Zlozene/ 🚀

