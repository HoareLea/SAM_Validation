[![Build](https://github.com/SAM-BIM/SAM_Validation/actions/workflows/build.yml/badge.svg?branch=master)](https://github.com/SAM-BIM/SAM_Validation/actions/workflows/build.yml)
[![Installer (latest)](https://img.shields.io/github/v/release/SAM-BIM/SAM_Deploy?label=installer)](https://github.com/SAM-BIM/SAM_Deploy/releases/latest)

# SAM_Validation

<a href="https://github.com/SAM-BIM/SAM">
  <img src="https://github.com/SAM-BIM/SAM/blob/master/Grasshopper/SAM.Core.Grasshopper/Resources/SAM_Small.png"
       align="left" hspace="10" vspace="6">
</a>

**SAM_Validation** is part of the **SAM (Sustainable Analytical Model) Toolkit** —  
an open-source collection of tools designed to help engineers create, manage,
and process analytical building models for energy and environmental analysis.

This repository provides a **modular validation and regression test suite**
used to verify the numerical correctness, physical consistency, and long-term stability
of SAM core modules against trusted reference implementations.

---

## Purpose

The validation framework supports verification of SAM components such as:

- `SAM_Mollier` — moist air and psychrometric calculations
- `SAM_IAPWS` — pure water and steam thermodynamics
- `SAM_SolarCalculator` — solar and weather-related calculations

Reference libraries include **PsychroLib** and **IAPWS-IF97**.

---

## Repository structure

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
├── README.md                      # Project overview and structure
├── RunInstructions.md             # How to set up and run the tests
├── TestPlan.md                    # Summary of test coverage and status
├── CreateSolution.md              # How to create and configure the solution
```

Each module directory contains:
- `Test/`: Unit and integration tests.
- `validationfiles/`: Reference data used for validation.

---

## Getting Started

➡️ See [RunInstructions.md](./RunInstructions.md) — how to configure and execute tests
➡️ See [TestPlan.md](./TestPlan.md) — overview of test coverage and status
➡️ See [CreateSolution.md](./CreateSolution.md) — solution setup and project linking


## 🔧 Run the Tests Locally

Ensure you have:
- [.NET SDK 7.0](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)
- Referenced SAM modules under test

```bash
dotnet test
```

---

## 📚 References

- 🔗 [PsychroLib 2.5.0](https://github.com/psychrometrics/psychrolib)
- 🔗 [IAPWS-IF97 Steam Tables](https://www.iapws.org/relguide/IF97-Rev.pdf)
- 🔗 [SAM_Mollier](https://github.com/SAM_BIM/SAM_Mollier)

---

## Development notes

- Target framework: **.NET / C#**
- Coding style follows standard SAM-BIM conventions.
- New or modified `.cs` files must include the SPDX header from `COPYRIGHT_HEADER.txt`

## Licence

This repository is free software licensed under the  
**GNU Lesser General Public License v3.0 or later (LGPL-3.0-or-later)**.

Each contributor retains copyright to their respective contributions.  
The project history (Git) records authorship and provenance of all changes.

See:
- `LICENSE`
- `NOTICE`
- `COPYRIGHT_HEADER.txt`