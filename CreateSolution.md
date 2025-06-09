# 🛠 How to Create `SAM_Validation.sln`

If the solution file was not included, no worries — you can create it yourself in a few quick steps using the .NET CLI.

---

## ✅ Step-by-Step: Create a New Solution and Add Test Project

> Run these in a terminal or PowerShell window inside your cloned `SAM_Validation/` folder.

---

### 1. Make sure you're in the correct directory
You should already be in:
```text
C:\Users\<your-username>\Documents\GitHub\SAM\SAM_Validation
```
✅ No need to use `cd path/to/...`. That was just a placeholder.

---

### 2. Create a new solution file
```powershell
dotnet new sln -n SAM_Validation
```
This will create:
```
SAM_Validation.sln
```

---

### 3. Create the test project (if not already created)
This step creates the **test project in the `SAM_Validation` repo**, not inside `SAM_Mollier`.

```powershell
dotnet new xunit -n SAM.Mollier.Tests -o tests/SAM.Mollier.Tests
```

---

### 4. Add the test project to the solution
```powershell
dotnet sln add tests/SAM.Mollier.Tests/SAM.Mollier.Tests.csproj
```

---

### 5. Reference `SAM_Mollier` engine project
Make sure the correct path points to:
```
C:\Users\<your-username>\Documents\GitHub\SAM\SAM_Mollier\SAM_Mollier\SAM.Core.Mollier\SAM.Core.Mollier.csproj
```
Then run:
```powershell
dotnet add tests/SAM.Mollier.Tests/SAM.Mollier.Tests.csproj reference ../SAM_Mollier/SAM_Mollier/SAM.Core.Mollier/SAM.Core.Mollier.csproj
```
✅ This ensures your test project has access to the real SAM_Mollier engine code.

---

### 6. Run your tests
```powershell
dotnet test
```
You should see:
```
Test summary: total: 1, failed: 0, succeeded: 1, skipped: 0
```

---

## ✅ Summary
You’ve created a `.sln`, wired up a dedicated test project, and validated it against `SAM_Mollier` logic — ready for future tests and GitHub CI integration.
