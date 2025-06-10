# 🧪 How to Run SAM_Validation Locally

These instructions walk you through your **first run** of the `SAM_Validation` tests.

---

## ✅ 1. Prerequisites

Make sure you have:

- [x] [.NET SDK 7.0+](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) installed
- [x] Cloned the following repositories locally:
  - `SAM_Validation`
  - `SAM_Mollier` (referenced as external code)

---

## 📂 2. Folder Structure (Local)

Your folder should look like this:

```
Projects/
├── SAM_Validation/
│   ├── SAM_Mollier/
│   │   ├── Test/
│   │   │   └── HumidityRatioTests.cs
│   │   └── validationfiles/
│   │       └── psychrolib_validation.csv
│   └── SAM_Validation.sln
└── SAM_Mollier/
    └── SAM.Core.Mollier.csproj
```

Ensure that the test project in `SAM_Validation/SAM_Mollier/Test/` references the external `SAM_Mollier` engine:

```bash
# From the root of SAM_Validation
 dotnet add SAM_Mollier/Test/SAM.Mollier.Tests.csproj reference ../../SAM_Mollier/SAM_Mollier/SAM.Core.Mollier.csproj
```

---

## ▶️ 3. Run Tests

From the root of the `SAM_Validation` repo:

```bash
dotnet test
```

You should see output like:

```text
Passed!  - Failed: 0, Passed: 1, Skipped: 0
```

---

## 💡 4. Run Specific Tests (Optional)

```bash
dotnet test --filter "FullyQualifiedName~HumidityRatioTests"
```

---

## 🧪 What’s Being Validated

You're running tests like:
- `HumidityRatioTests.cs` or `EnthalpyTests.cs`
- Comparing output from `SAM_Mollier` logic
- Against values from `SAM_Mollier/validationfiles/psychrolib_validation.csv`

---

## 🛠 Troubleshooting

| Issue | Fix |
|-------|-----|
| `The name 'HumidityRatio' does not exist...` | Ensure the correct external project reference is set up |
| `FileNotFoundException` for CSV | Confirm the path to `validationfiles/*.csv` is resolved correctly |
| Inaccurate result | Check if `T`, `RH`, or `p` units are passed correctly |

---

## ✅ You’re Ready

Once you're confident this works, you can:
- Add more tests (e.g. `EnthalpyTests.cs`)
- Expand your validation dataset
- Integrate with GitHub CI for automated testing
