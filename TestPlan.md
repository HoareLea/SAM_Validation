# SAM_Validation: Test Planning

This document tracks planned and validated tests across SAM modules.

---

## ✅ Implemented Tests

| Module        | Test Name                  | Description                                       | Reference        |
|---------------|-----------------------------|---------------------------------------------------|------------------|
| SAM_Mollier   | `HumidityRatioTests.cs`     | Validates RH→x conversion                         | PsychroLib 2.5.0 |

---

## 🧪 Planned Tests

### SAM_Mollier

| Test Name                  | Description                                 | Status    |
|---------------------------|---------------------------------------------|-----------|
| `EnthalpyTests.cs`        | Validate `Enthalpy(t, x)`                   | ⏳ Planned |
| `DewPointTests.cs`        | Validate `DewPoint(t, rh)`                  | ⏳ Planned |
| `WetBulbTests.cs`         | Validate `WetBulb(t, rh, p)`                | ⏳ Planned |
| `PartialVapourPressure.cs`| Validate reverse from x → pW                | ⏳ Planned |

### SAM_IAPWS

| Test Name                  | Description                                 | Status    |
|---------------------------|---------------------------------------------|-----------|
| `Region1Tests.cs`         | h, s, v from T+p                            | ⏳ Planned |
| `Region4Tests.cs`         | Saturation curve: T ↔ p                     | ⏳ Planned |

---

## 📚 Validation Data Sources

- `psychrolib_validation.csv` — from PsychroLib 2.5.0 (x, h, RH)
- `iapws_reference.csv` — (planned)

---

## 🛠 How to Add a New Test

Follow these steps to add a new validation test to the `SAM_Validation` repository:

### ✅ 1. Add Reference Data

Place your CSV file in the appropriate toolkit's validation data folder:

```
SAM_Validation/
└── SAM_{Module}/
    └── validationfiles/
        └── your_dataset.csv
```

> Example:  
> `SAM_Mollier/validationfiles/psychrolib_validation.csv`

---

### ✅ 2. Add a Test Class

Create a new `.cs` test file under the corresponding toolkit's test directory:

```
SAM_Validation/
└── SAM_{Module}/
    └── Test/
        └── YourNewTest.cs
```

> Example:  
> `SAM_Mollier/Test/HumidityRatioTests.cs`

---

### ✅ 3. Implement the Test

In your new test class:
- Use `[Theory]` and `[MemberData(nameof(GetTestData))]` to supply test cases
- Read data from the CSV using `AppContext.BaseDirectory` to resolve file paths
- Use `Assert.True(...)` or `Assert.InRange(...)` to validate results
- (Optional) Include `Console.WriteLine(...)` for debugging individual test cases

---

### ✅ 4. Run and Verify

From the repo root:

```bash
dotnet test
```

You should see output confirming that your test was discovered and executed. If not, confirm the file is in the correct `SAM_{Module}/Test/` folder and properly decorated with `[Fact]` or `[Theory]`.

---

## ✅ CI

- Tests are automatically executed via GitHub Actions on push and PRs to `main`.
