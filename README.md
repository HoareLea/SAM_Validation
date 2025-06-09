# SAM_Template

<a href="https://github.com/HoareLea/SAM_Validation"><img src="https://github.com/HoareLea/SAM/blob/master/Grasshopper/SAM.Core.Grasshopper/Resources/SAM_Small.png" align="left" hspace="10" vspace="6"></a>

**SAM_Validation** is part of SAM Toolkit that is designed to validate SAM Toolkit. Welcome and let's make the opensource journey continue. :handshake:

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

SAM_Validation/
├── tests/
│ ├── Mollier/ # Validation for SAM_Mollier
│ ├── IAPWS/ # Placeholder for SAM_IAPWS tests
│ └── SolarCalculator/ # Placeholder for solar model tests
├── reference/
│ └── psychrolib_validation.csv # Golden reference dataset
├── .github/
│ └── workflows/test.yml # GitHub Actions for automated testing
├── README.md


## Resources
* [Wiki](https://github.com/HoareLea/SAM_Validation/wiki)

## Installing

To install **SAM** from .exe just download and run [latest installer](https://github.com/HoareLea/SAM_Deploy/releases) otherwise rebuild using VS [SAM](https://github.com/HoareLea/SAM)

## Licence ##

SAM is free software licenced under GNU Lesser General Public Licence - [https://www.gnu.org/licenses/lgpl-3.0.html](https://www.gnu.org/licenses/lgpl-3.0.html)  
Each contributor holds copyright over their respective contributions.
The project versioning (Git) records all such contribution source information.
See [LICENSE](https://github.com/HoareLea/SAM_Template/blob/master/LICENSE) and [COPYRIGHT_HEADER](https://github.com/HoareLea/SAM/blob/master/COPYRIGHT_HEADER.txt).
