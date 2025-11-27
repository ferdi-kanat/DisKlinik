# DisKlinik - Dental Clinic Management System

## Architecture Overview

Windows Forms (.NET Framework 4.7.2) desktop app for dental clinic management. Uses **LocalDB SQL Server** with **3-layer architecture** and ADO.NET (no ORM).

**Key Layers:**
- **Presentation**: `MainMenu`, `PatientForm`, `AppointmentForm`, `TreatmentForm`, `PrescriptionForm`
- **Business Logic**: `Business/PatientManager` (validation), `Business/AppointmentManager`, etc.
- **Data Access**: `Repositories/` (SQL queries), `DataAccess` (SQL executor), `ConnectionString` (DB factory)
- **Utilities**: `NavigationHelper` (form navigation), `DataGridViewHelper` (grid operations)
- **UI Framework**: Guna.UI2.WinForms (2.0.4.7)
- **Database**: LocalDB at `C:\Users\ferdi\OneDrive\Documents\DentalDb.mdf`

## Critical Patterns

### 3-Layer Architecture (Forms → Business → Repository)
**Forms NEVER call Repository directly.** Use Manager classes for business logic:

```csharp
// ✅ CORRECT - Forms call Business layer
private readonly PatientManager _patientManager = new PatientManager();
_patientManager.SavePatient(name, phone, address, birthDate, gender, allergy);

// ✅ Business layer validates and calls Repository
public int SavePatient(...) {
    ValidatePatientData(...);  // Business logic
    return PatientRepository.Add(...);  // Data access
}

// ❌ WRONG - Forms calling Repository directly
PatientRepository.Add(name, phone, address, birthDate, gender, allergy);

// ❌ WRONG - Forms writing SQL
const string sql = "SELECT * FROM HastaTbl";
DataAccess.ExecuteQuery(sql);
```

**Repository Structure** (Data Access Layer only):
```csharp
// Repositories/{Entity}Repository.cs
public static class PatientRepository
{
    #region SQL Queries
    private const string SelectAll = "SELECT HId, PatientName... FROM HastaTbl";
    private const string InsertSql = "INSERT INTO HastaTbl...";
    #endregion

    #region Public Methods
    public static DataTable GetAll() { ... }
    public static DataTable Search(string searchText) { ... }
    public static int Add(params...) { ... }
    public static int Update(int id, params...) { ... }
    public static int Delete(int id) { ... }
    #endregion
}
```

### Standard Form Structure with Regions
Every form follows this pattern with Manager instance:

```csharp
public partial class PatientForm : Form
{
    #region Fields & Constants
    private int? _selectedPatientId;
    private readonly PatientManager _patientManager;
    #endregion

    #region Constructor
    public PatientForm() {
        InitializeComponent();
        _patientManager = new PatientManager();
    }
    #endregion

    #region Form Events
    private void Hasta_Load(object sender, EventArgs e) {
        LoadPatients();
        ClearInputFields();
    }
    #endregion

    #region CRUD Operations
    private void SaveButton_Click(object sender, EventArgs e) {
        try {
            _patientManager.SavePatient(name, phone, address, birthDate, gender, allergy);
            MessageBox.Show("Hasta başarıyla eklendi", "Başarılı", ...);
            LoadPatients();
            ClearInputFields();
        }
        catch (ArgumentException ex) {
            MessageBox.Show(ex.Message, "Doğrulama Hatası", ...);
        }
    }
    #endregion

    #region Grid Events
    private void PatientDataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
        if (e.RowIndex < 0) return;
        var row = PatientDataGridView.SelectedRows[0];
        PatientNameTextBox.Text = row.Cells[1].Value?.ToString() ?? "";  // Match SELECT column order
        _selectedPatientId = DataGridViewHelper.GetSelectedRecordId(gridView, "HId");
    }
    #endregion

    #region Helper Methods
    void LoadPatients() {
        PatientDataGridView.DataSource = PatientRepository.GetAll();  // Only in helper methods
    }
    #endregion

    #region Navigation Events
    private void BackLabel_Click(object sender, EventArgs e) {
        NavigationHelper.NavigateToMainMenu(this);
    }
    #endregion
}
```

**Critical Cell Index Rule**: `row.Cells[1]` must match the **2nd column** in Repository's SELECT statement (0-based indexing).

### Navigation Pattern (Centralized)
**ALL navigation must use NavigationHelper** - never create forms directly in form code:

```csharp
// ✅ CORRECT - Centralized navigation
NavigationHelper.NavigateToMainMenu(this);
NavigationHelper.NavigateToPatients(this);
NavigationHelper.NavigateToAppointments(this);
NavigationHelper.NavigateToTreatments(this);
NavigationHelper.NavigateToPrescriptions(this);
NavigationHelper.ExitApplication(); // Shows confirmation dialog

// ❌ WRONG - Manual form creation
new Anasayfa().Show();
this.Hide();
this.Close();
Application.Exit();
```

**NavigationHelper Features:**
- Generic `NavigateTo<TForm>(currentForm)` for any form
- Specific methods for each form
- Exit confirmation dialog
- Show/Hide pattern (not Close) to preserve form state

### Database Access Rules
**Always use Repository methods** with parameterized queries:

```csharp
// ✅ CORRECT - Repository handles SQL and parameters
PatientRepository.Add(name, phone, address, birthDate, gender, allergy);

// ❌ WRONG - Direct SQL in forms (security risk)
DataAccess.ExecuteNonQuery($"INSERT INTO HastaTbl (PatientName) VALUES ('{textBox.Text}')");
```

## Database Schema

**Tables** (Turkish names, English columns):
- **HastaTbl**: `HId`, `PatientName`, `Phone`, `Address`, `BirthDate`, `Gender`, `Allergy`
- **TedaviTbl**: `TId`, `TreatmentName`, `Cost`, `Description`
- **RandevuTbl**: `RId`, `PatientName`, `TreatmentName`, `AppointmentDate`, `AppointmentTime`
- **ReceteTbl**: `RecId`, `PatientName`, `TreatmentName`, `TreatmentCost`, `Medication`, `MedicationQuantity`

**Relationships:** Text-based matching (e.g., `PatientName=PatientName`), not foreign keys. `RandevuTbl` and `ReceteTbl` store patient/treatment names as text copied from `HastaTbl`/`TedaviTbl`.

## Naming Conventions

**Code (English):**
- Controls: `PatientNameTextBox`, `SaveButton`, `PatientDataGridView`
- Methods: `LoadPatients()`, `ClearInputFields()`, `ApplyPatientFilter()`
- Fields: `_selectedPatientId`, `_patientManager`
- Constants: `SelectAll`, `InsertSql`

**Database:** English column names (`PatientName`, `AppointmentDate`)

**UI Labels:** Turkish for end users ("Hasta Adı", "Randevu Tarihi")

## Common Workflows

### Build & Run
- **Visual Studio:** F5 or Ctrl+Shift+B
- **Command line:** `msbuild DisKlinik.sln /p:Configuration=Debug`
- **MSBuild path:** `C:\Program Files\Microsoft Visual Studio\2022\Professional\MSBuild\Current\Bin\MSBuild.exe`
- **Run:** `bin\Debug\DisKlinik.exe` (requires LocalDB)

### Adding a New Form
1. Create WinForms files: `{Name}Form.cs`, `{Name}Form.Designer.cs`, `{Name}Form.resx`
2. Add navigation method in `NavigationHelper.cs`: `NavigateTo{FormName}(Form currentForm)`
3. Create Manager class in `Business/{Name}Manager.cs` with validation methods
4. Create Repository in `Repositories/{Name}Repository.cs`
5. Implement standard form structure with regions and Manager instance (see pattern above)
6. Add Exit/Back button handlers using `NavigationHelper`
7. Add form to `DisKlinik.csproj` in `<Compile Include="..."/>`

### Adding a New Repository
1. Create `Repositories/{Entity}Repository.cs`
2. Add `#region SQL Queries` with private const strings
3. Add `#region Public Methods` with GetAll, Search, Add, Update, Delete
4. Use `DataAccess.ExecuteQuery()` for SELECT (returns DataSet)
5. Use `DataAccess.ExecuteNonQuery()` for INSERT/UPDATE/DELETE (returns affected rows)
6. Always use `DataGridViewHelper.CreateParameter()` for parameters
7. Add repository to `DisKlinik.csproj` in `<Compile Include="Repositories\..."/>`

### Adding a New Manager (Business Layer)
1. Create `Business/{Entity}Manager.cs`
2. Add `#region Validation Methods` with private validation logic
3. Add `#region CRUD Operations` with public methods that:
   - Call validation methods
   - Call Repository methods
   - Throw `ArgumentException` for validation errors
4. Forms catch `ArgumentException` and show validation messages
5. Add manager to `DisKlinik.csproj` in `<Compile Include="Business\..."/>`

### Modifying Database Queries
1. Find repository in `Repositories/{Entity}Repository.cs`
2. Update private const SQL strings
3. **If SELECT columns change, update cell indices** in form's `DataGridView_CellClick`
4. Test grid load, click, CRUD, and search operations

### Code Organization with Regions
All forms and repositories use `#region` for organization:
- **Forms**: Fields & Constants, Constructor, Form Events, CRUD Operations, Grid Events, Search & Filter, Helper Methods, Navigation Events
- **Repositories**: SQL Queries, Public Methods
- **Helpers**: Data Loading, Grid Selection, Parameter Creation, Command Execution, etc.

### Special Features
- **3-Layer Architecture**: Forms → Business → Repository separation enforced
- **Business Validation**: All validation logic in `Business/*Manager.cs` classes
- **ComboBox population**: Use `{Entity}Repository.Get{Entity}Names()` (see `PrescriptionForm.cs` → `LoadPatientComboBox()`)
- **Dependent dropdowns**: See `PrescriptionForm.cs` - `PatientComboBox_SelectionChangeCommitted` triggers `LoadTreatmentComboBox()` via `AppointmentRepository.GetTreatmentsByPatient()`
- **Auto-populate fields**: See `PrescriptionForm.cs` → `LoadTreatmentPrice()` - uses `TreatmentRepository.GetTreatmentCostByName()`
- **Print grid**: See `PrescriptionForm.cs` `PrintButton_Click` - captures grid as Bitmap to `PrintPreviewDialog`
- **Exit confirmation**: `NavigationHelper.ExitApplication()` shows Yes/No dialog

## Project Structure

```
DisKlinik/
├── Forms (Presentation Layer)
│   ├── MainMenu.cs         - Main menu
│   ├── PatientForm.cs      - Patients management
│   ├── AppointmentForm.cs  - Appointments management
│   ├── TreatmentForm.cs    - Treatments management
│   └── PrescriptionForm.cs - Prescriptions management
├── Business/ (Business Layer)
│   ├── PatientManager.cs
│   ├── TreatmentManager.cs
│   ├── AppointmentManager.cs
│   └── PrescriptionManager.cs
├── Repositories/ (Data Access Layer)
│   ├── PatientRepository.cs
│   ├── TreatmentRepository.cs
│   ├── AppointmentRepository.cs
│   └── PrescriptionRepository.cs
├── Core Infrastructure
│   ├── DataAccess.cs           - SQL executor (ExecuteQuery, ExecuteNonQuery)
│   ├── ConnectionString.cs     - DB connection factory
│   ├── DataGridViewHelper.cs   - Grid utilities & parameter creation
│   └── NavigationHelper.cs     - Centralized form navigation
└── Program.cs                  - Application entry point
```

## Clean Code Achievements

✅ **Separation of Concerns** - Forms, business logic, and repositories are separated
✅ **Single Responsibility** - Each class has one clear purpose
✅ **Repository Pattern** - SQL queries hidden from presentation layer
✅ **Business Logic Layer** - Validation centralized in Manager classes
✅ **DRY Principle** - Navigation logic centralized in NavigationHelper
✅ **Code Organization** - All files use regions for readability
✅ **Parameterized Queries** - Protection against SQL injection
✅ **Consistent Naming** - English code, Turkish UI labels

## Known Limitations & Technical Debt
- Hardcoded connection string in `ConnectionString.cs` (user-specific path)
- Text-based relationships instead of foreign keys (data integrity risk)
- Basic validation (phone length only, no email/format checks)
- No logging (errors shown in MessageBox only)
- No unit tests
- Static classes everywhere (no dependency injection)
- Form lifecycle uses Show/Hide instead of proper disposal

## When Making Changes

### Golden Rules
1. **NEVER write SQL in forms** - Use Repository methods
2. **NEVER call Repository from forms** - Use Manager classes
3. **NEVER create forms manually** - Use NavigationHelper
4. **ALWAYS use parameterized queries** - Via `DataGridViewHelper.CreateParameter()`
5. **ALWAYS organize code with regions** - Match existing pattern
6. **Match cell indices** to DataTable column order in `CellClick` handlers
7. **Test with LocalDB** - Connection string must be valid
8. **Use English** in code, **Turkish** in UI labels
9. **Validation in Manager** - Throw `ArgumentException` for business rule violations

### Before Committing
- [ ] All SQL queries are in Repository classes
- [ ] All validation is in Manager classes
- [ ] Forms only call Manager methods (never Repository directly)
- [ ] All navigation uses NavigationHelper
- [ ] All regions are properly organized
- [ ] No hardcoded strings (use const or repository)
- [ ] Cell indices match SELECT column order
- [ ] Build succeeds without warnings
- [ ] Manual testing completed for affected forms