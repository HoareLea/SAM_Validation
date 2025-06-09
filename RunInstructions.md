# 🧪 How to Run SAM_Validation Locally

These instructions walk you through your **first run** of the `SAM_Validation` tests.

---

## ✅ 1. Prerequisites

Make sure you have:

- [x] [.NET SDK 7.0+](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) installed
- [x] Cloned the following repositories locally:
  - `SAM_Validation`
  - `SAM_Mollier` (referenced in the test project)

---

## 📂 2. Folder Structure (Local)

Your folder should look like this:

```
Projects/
├── SAM_Validation/
│   ├── tests/
│   ├── reference/
│   └── SAM_Validation.sln
└── SAM_Mollier/
    └── SAM_Mollier.csproj
```

Ensure that `SAM_Validation` project **references** the local `SAM_Mollier.csproj` file:

> `dotnet add tests/SAM.Mollier.Tests.csproj reference ../SAM_Mollier/SAM_Mollier.csproj`

---

## ▶️ 3. Run Tests

From the root of the `SAM_Validation` repo:

```bash
cd SAM_Validation

dotnet test
```

You should see output like:

```text
Passed!  - Failed: 0, Passed: 1, Skipped: 0
```

If something fails, you'll get:
```text
Failed ValidateHumidityRatioAgainstReference [T=25, RH=60%]
Expected 0.0115, got 0.0111
```

---

## 💡 4. Run Specific Tests (Optional)

```bash
dotnet test --filter "FullyQualifiedName~HumidityRatioTests"
```

---

## 🧪 What’s Being Validated

You're running:
- `HumidityRatioTests.cs`
- Comparing output from `SAM_Mollier.HumidityRatio(...)`
- Against values from `reference/psychrolib_validation.csv`

---

## 🛠 Troubleshooting

| Issue | Fix |
|-------|-----|
| `The name 'HumidityRatio' does not exist...` | Check if `SAM_Mollier` is referenced properly |
| `FileNotFoundException` for CSV | Ensure `reference/psychrolib_validation.csv` is copied correctly |
| Inaccurate result | Check if `t`, `rh`, or `p` units are passed properly |

---

## ✅ You’re Ready

Once you're confident this works, we can proceed to:
- Add `EnthalpyTests.cs`
- Expand reference data
- Set up GitHub CI to auto-run this on PRs

Let me know when ready!
