# Wkład w Projektu - Contributing Guide

Dziękuję za zainteresowanie udziałem w tym projekcie! 🙏

## 📋 Jak Wnieść Wkład?

### Dla Studentów

1. **Fork Repozytorium** - Stwórz własną kopię
2. **Stwórz Branch** - `git checkout -b feature/twoja-funkcjonalność`
3. **Rób Zmiany** - Pracuj nad swoimi zadaniami
4. **Commituj** - `git commit -m "opis zmian"`
5. **Push** - `git push origin feature/twoja-funkcjonalność`
6. **Pull Request** - Poproś o przejrzenie zmian

### Dla Prowadzących

1. Dodaj nowe moduły/projekty
2. Zaktualizuj README
3. Prześlij Pull Request z opisem

---

## ✅ Standardy Kodu

### Nazewnictwo

- **Klasy**: PascalCase → `Calculator`, `Contact`
- **Metody**: PascalCase → `Add()`, `CalculateTotal()`
- **Zmienne**: camelCase → `firstName`, `totalAmount`
- **Stałe**: UPPER_CASE → `MAX_SIZE`, `API_KEY`

### Formatowanie

```csharp
// Używamy 4 spacje, nie taby
// Używamy curly braces w nowych liniach

public class MyClass
{
    public void MyMethod()
    {
        if (condition)
        {
            // Code here
        }
    }
}
```

### Komentarze

```csharp
// Zły komentarz
x = x + 1; // Zwiększ x

// Dobry komentarz
// Zwiększamy licznik, aby śledzić liczbę iteracji
counter++;
```

---

## 📝 Struktura Zadań

Każdy podmoduł powinien zawierać:

```
01.X-Temat/
├── Program.cs         (Kod źródłowy)
├── README.md          (Opis i tutorial)
└── ZADANIA.md         (Zadania dla studentów)
```

### README.md Szablon

```markdown
# 01.X - Temat

## 🎯 Cel
Krótki opis celu

## 📚 Koncepty
- Koncept 1
- Koncept 2

## 📝 Program
```csharp
// Kod tutaj
```

## 🚀 Jak Uruchomić?
...
```

---

## 🐛 Raportowanie Błędów

Jeśli znaleziesz błąd:

1. Sprawdź, czy błąd już istnieje w Issues
2. Stwórz nowy Issue z:
   - Opisem błędu
   - Krokami reprodukcji
   - Spodziewanym rezultatem
   - Aktualnym rezultatem

---

## ❓ Pytania?

- Otwórz Discussion
- Poproś o pomoc w Issues
- Skontaktuj się z prowadzącym

---

**Dziękujemy za Twój wkład!** ⭐

