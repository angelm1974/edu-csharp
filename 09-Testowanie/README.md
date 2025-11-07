# 09 - Testowanie

## 🎯 Cel Modułu
Nauka pisania testów jednostkowych i zapewniania jakości kodu. Po tym module będziesz tworzyć niezawodny kod.

## 📚 Tematy

### Unit Testing
- Czym jest test jednostkowy
- AAA pattern (Arrange, Act, Assert)
- Test frameworks: XUnit, NUnit, MSTest
- Assertions
- Test coverage
- **Umiejętność:** Testowanie kodu

### Mockowanie
- Mockowanie zależności
- Interfaces dla testów
- Dependency Injection
- **Umiejętność:** Testowanie w izolacji

### Testowanie Integracyjne
- Testy końca do końca (E2E)
- Testowanie z bazą danych
- **Umiejętność:** Weryfikacja całego systemu

---

## 📁 Struktura Folderów

```
09-Testowanie/
├── Podstawy-Unit-Testing/
│   ├── CalculatorTests.cs
│   ├── README.md
│   └── ZADANIA.md
├── Mockowanie-i-DI/
│   ├── ServiceTests.cs
│   ├── README.md
│   └── ZADANIA.md
├── Integracyjne/
│   ├── IntegrationTests.cs
│   ├── README.md
│   └── ZADANIA.md
└── README.md
```

---

## 🧪 Struktura Testu - AAA Pattern

```csharp
[Fact] // lub [Test] w NUnit
public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
{
    // Arrange - Przygotowanie
    var calculator = new Calculator();
    int a = 5;
    int b = 3;
    
    // Act - Działanie
    int result = calculator.Add(a, b);
    
    // Assert - Asercja
    Assert.Equal(8, result);
}
```

---

## ⚙️ Setup - Projekt Testowy

Aby uruchomić testy, potrzebujesz projektu testowego:

```bash
# Utwórz projekt testowy
dotnet new xunit -n MyProject.Tests

# Dodaj referencję do projektu do testowania
cd MyProject.Tests
dotnet add reference ../MyProject/MyProject.csproj

# Uruchom testy
dotnet test
```

---

## 📊 Test Coverage

```
┌─────────────────────────────┐
│ Kod źródłowy: 100 linii     │
│ Pokryte: 85 linii (85%)     │ ✅ Dobry coverage
└─────────────────────────────┘

Cel: min. 80% coverage
Ideał: 90%+
```

---

## 🎯 Przykład - Testowanie Kalkulatora

```csharp
public class CalculatorTests
{
    private Calculator _calculator;
    
    public CalculatorTests()
    {
        _calculator = new Calculator();
    }
    
    [Fact]
    public void Add_Returns_CorrectSum()
    {
        // Arrange
        int a = 2, b = 3;
        
        // Act
        int result = _calculator.Add(a, b);
        
        // Assert
        Assert.Equal(5, result);
    }
    
    [Fact]
    public void Divide_ByZero_ThrowsException()
    {
        // Arrange & Act & Assert
        Assert.Throws<DivideByZeroException>(
            () => _calculator.Divide(10, 0)
        );
    }
    
    [Theory]
    [InlineData(2, 3, 5)]
    [InlineData(0, 0, 0)]
    [InlineData(-1, 1, 0)]
    public void Add_WithVariousInputs_Works(int a, int b, int expected)
    {
        var result = _calculator.Add(a, b);
        Assert.Equal(expected, result);
    }
}
```

---

## 📋 Test Naming Convention

✅ Dobre nazwy:
- `Add_TwoNumbers_ReturnsSum`
- `Divide_ByZero_ThrowsException`
- `Login_WithInvalidPassword_ReturnsFalse`

❌ Złe nazwy:
- `Test1`
- `CalculatorTest`
- `DoTest`

---

## ✅ Checklist Nauki

- [ ] Rozumiem AAA pattern
- [ ] Potrafię pisać testy z XUnit/NUnit
- [ ] Znam asercje (Assert)
- [ ] Potrafię używać [Fact] i [Theory]
- [ ] Wiem co to mockowanie
- [ ] Mogę mierzyć code coverage
- [ ] Rozumiem testy integracyjne

---

## 🎯 Cel Końcowy

Po tym module powinieneś:
✅ Pisać unit testy  
✅ Stosować best practices testowania  
✅ Mierzyć pokrycie kodu  
✅ Mockować zależności  
✅ Budować niezawodny kod  

**Brawo! Ukończyłeś cały kurs C#!** 🎉

---

## 📚 Dodatkowe Zasoby

- [xUnit.net Documentation](https://xunit.net/)
- [NUnit Documentation](https://nunit.org/)
- [Microsoft - Unit Testing Best Practices](https://docs.microsoft.com/en-us/dotnet/core/testing/)

