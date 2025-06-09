# 🛠 How to Create `SAM_Validation.sln`

If the solution file was not included, no worries — you can create it yourself in a few quick steps using the .NET CLI.

---

## ✅ Step-by-Step: Create a New Solution and Add Test Project

> Run these in a terminal or command prompt inside your cloned `SAM_Validation/` folder.

### 1. Navigate to repo root
```bash
cd path/to/SAM_Validation
```

### 2. Create a new solution file
```bash
dotnet new sln -n SAM_Validation
```

This will create:
```text
SAM_Validation.sln
```

### 3. Identify your test project path
Ensure your test project exists at:
```
tests/SAM.Mollier.Tests/SAM.Mollier.Tests.csproj
```
If not, create it using:
```bash
dotnet new xunit -n SAM.Mollier.Tests -o tests/SAM.Mollier.Tests
```

### 4. Add the test project to the solution
```bash
dotnet sln add tests/SAM.Mollier.Tests/SAM.Mollier.Tests.csproj
```

### 5. Add `SAM_Mollier` as a project reference to the test project
(assuming it's cloned side-by-side)
```bash
dotnet add tests/SAM.Mollier.Tests/SAM.Mollier.Tests.csproj reference ../SAM_Mollier/SAM_Mollier.csproj
```

---

## ✅ Done!
You can now run:
```bash
dotnet test
```
And it will execute tests defined in `SAM.Mollier.Tests` using `SAM_Validation.sln`.

Let me know if you’d like a `.sln` auto-generated and zipped too.
