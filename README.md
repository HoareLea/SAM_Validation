# SAM_Validation

<a href="https://github.com/HoareLea/SAM_Validation"><img src="https://github.com/HoareLea/SAM/blob/master/Grasshopper/SAM.Core.Grasshopper/Resources/SAM_Small.png" align="left" hspace="10" vspace="6"></a>

**SAM_Validation** is a repository containing validation tests for various SAM toolkits. Welcome and let's make the opensource journey continue. :handshake:

# SAM_Validation

🧪 A modular validation suite for the Sustainable Analytical Model (SAM) platform developed by Hoare Lea.  
This repository compares outputs from SAM modules against trusted reference implementations such as PsychroLib and IAPWS-IF97 to ensure numerical correctness, thermodynamic validity, and regression stability.

---

## ✅ Purpose

This repository helps verify the physical and numerical accuracy of core SAM components, such as:

- `SAM_Mollier` (moist air / psychrometrics)
- `SAM_IAPWS` (pure water/steam thermodynamics)
- `SAM_SolarCalculator` (solar irradiance and weather input models)

---

## 📁 Structure

```

SAM_Validation/
├── SAM_Mollier/                   # Validation tests for SAM_Mollier
│   ├── Test/                      # Test files (e.g., HumidityRatioTests.cs, EnthalpyTests.cs)
│   └── validationfiles/           # Reference data (e.g., psychrolib_validation.csv)
├── SAM_IAPWS/                     # Validation tests for SAM_IAPWS
│   ├── Test/                      # Test files
│   └── validationfiles/           # Reference data
├── SAM_SolarCalculator/           # Validation tests for SAM_SolarCalculator
│   ├── Test/                      # Test files
│   └── validationfiles/           # Reference data
├── .github/
│   └── workflows/test.yml         # GitHub Actions for CI
└── README.md					   # Project overview and structure

```


- `SAM_Mollier/`: Validation tests for the SAM Mollier toolkit.
- `SAM_IAPWS/`: Validation tests for the SAM IAPWS toolkit.
- `SAM_SolarCalculator/`: Validation tests for the SAM Solar Calculator toolkit.
- `.github/workflows/`: Continuous Integration workflows.

Each toolkit directory contains:
- `tests/`: Unit and integration tests.
- `validation_data/`: Reference data used for validation.

---

## 📘 Getting Started

➡️ See [RunInstructions.md](./RunInstructions.md) for first-time setup and test execution.

## 🧪 Current Test Coverage

### ✅ `SAM_Mollier/HumidityRatioTests.cs`
Validates:
- `HumidityRatio.HumidityRatio(...)` against PsychroLib 2.5.0
- Tolerance: ±0.0005 kg/kg

More tests to come:
- Enthalpy
- Dew point
- Wet bulb

---

## 🔧 Run the Tests Locally

Ensure you have:
- [.NET SDK 7.0](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)
- References to `SAM_Mollier` and optionally `SAM_Psychrometrics`

```bash
dotnet test
```

---

## 📚 References

- 🔗 [PsychroLib 2.5.0](https://github.com/psychrometrics/psychrolib)
- 🔗 [IAPWS-IF97 Steam Tables](https://www.iapws.org/relguide/IF97-Rev.pdf)
- 🔗 [SAM_Mollier](https://github.com/HoareLea/SAM_Mollier)

---

## 🛠 Roadmap

- [x] Validate humidity ratio (RH-based)
- [ ] Validate enthalpy, dew point, wet bulb
- [ ] Add Region 1–5 tests for `SAM_IAPWS`
- [ ] Validate solar input with `SAM_SolarCalculator`
- [ ] Shared test utilities & loader helpers

---

## 👥 Maintainers

- **Michal Dengusiak** – Lead architect and domain expert

---

## Resources
* [Wiki](https://github.com/HoareLea/SAM_Validation/wiki)

## Installing

To install **SAM** from .exe just download and run [latest installer](https://github.com/HoareLea/SAM_Deploy/releases) otherwise rebuild using VS [SAM](https://github.com/HoareLea/SAM)

## Licence ##

SAM is free software licenced under GNU Lesser General Public Licence - [https://www.gnu.org/licenses/lgpl-3.0.html](https://www.gnu.org/licenses/lgpl-3.0.html)  
Each contributor holds copyright over their respective contributions.
The project versioning (Git) records all such contribution source information.
See [LICENSE](https://github.com/HoareLea/SAM_Template/blob/master/LICENSE) and [COPYRIGHT_HEADER](https://github.com/HoareLea/SAM/blob/master/COPYRIGHT_HEADER.txt).
