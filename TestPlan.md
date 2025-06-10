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

1. Add your CSV test dataset to `validation_data/`
2. Create test class in `tests/{Module}/`
3. Use `[Theory][MemberData]` for parameterized tests
4. Set tolerance (e.g. ±0.0005 for x)
5. Validate with `dotnet test`

---

## ✅ CI

- Tests are automatically executed via GitHub Actions on push and PRs to `main`.
