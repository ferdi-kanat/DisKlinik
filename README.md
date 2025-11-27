# 🦷 DisKlinik - Dental Clinic Management System

Modern dental clinic management system built with Windows Forms and LocalDB SQL Server. Features a clean 3-layer architecture for managing patients, appointments, treatments, and prescriptions.

![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.7.2-blue)
![License](https://img.shields.io/badge/license-MIT-green)
![Database](https://img.shields.io/badge/database-LocalDB-orange)

## 📋 Features

- **Patient Management** - Complete CRUD operations for patient records including demographics and allergy tracking
- **Appointment Scheduling** - Book and manage appointments with date/time slots
- **Treatment Tracking** - Maintain treatment catalog with costs and descriptions
- **Prescription Management** - Generate prescriptions with medication details and print functionality
- **Search & Filter** - Quick search across all data entities
- **Data Grid Views** - Interactive data tables with selection and edit capabilities

## 🏗️ Architecture

### 3-Layer Architecture
```
┌─────────────────┐
│ Presentation    │  Forms (WinForms UI)
├─────────────────┤
│ Business Logic  │  Managers (Validation)
├─────────────────┤
│ Data Access     │  Repositories (SQL)
└─────────────────┘
```

**Key Principles:**
- ✅ Forms **never** call Repositories directly
- ✅ All business logic in Manager classes
- ✅ All SQL queries in Repository classes
- ✅ Parameterized queries prevent SQL injection
- ✅ Centralized navigation via NavigationHelper

### Technology Stack

| Component | Technology |
|-----------|-----------|
| **Framework** | .NET Framework 4.7.2 |
| **UI Library** | Guna.UI2.WinForms 2.0.4.7 |
| **Database** | SQL Server LocalDB |
| **Data Access** | ADO.NET (SqlClient) |
| **Language** | C# |

## 🚀 Getting Started

### Prerequisites

- **Visual Studio 2012+** (2022 Professional recommended)
- **.NET Framework 4.7.2** Runtime
- **SQL Server LocalDB** (included with Visual Studio)

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/ferdi-kanat/disklinik.git
   cd disklinik
   ```

2. **Update database path**

   Edit `ConnectionString.cs` and update the MDF file path:
   ```csharp
   private const string ConnectionStringValue =
       @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\YOUR_PATH\DentalDb.mdf;...";
   ```

3. **Restore NuGet packages**
   ```bash
   nuget restore DisKlinik.sln
   ```

4. **Build solution**
   ```bash
   msbuild DisKlinik.sln /p:Configuration=Debug
   ```

   Or press **F5** in Visual Studio

5. **Run application**
   ```bash
   .\bin\Debug\DisKlinik.exe
   ```

## 📁 Project Structure

```
DisKlinik/
├── Forms/                      # Presentation Layer
│   ├── MainMenu.cs            # Application entry point
│   ├── PatientForm.cs         # Patient management
│   ├── AppointmentForm.cs     # Appointment scheduling
│   ├── TreatmentForm.cs       # Treatment catalog
│   └── PrescriptionForm.cs    # Prescription generation
│
├── Business/                   # Business Logic Layer
│   ├── PatientManager.cs      # Patient validation logic
│   ├── AppointmentManager.cs  # Appointment business rules
│   ├── TreatmentManager.cs    # Treatment validation
│   └── PrescriptionManager.cs # Prescription validation
│
├── Repositories/              # Data Access Layer
│   ├── PatientRepository.cs   # Patient CRUD operations
│   ├── AppointmentRepository.cs
│   ├── TreatmentRepository.cs
│   └── PrescriptionRepository.cs
│
├── Core/                      # Infrastructure
│   ├── DataAccess.cs         # SQL executor
│   ├── ConnectionString.cs   # Database factory
│   ├── DataGridViewHelper.cs # Grid utilities
│   └── NavigationHelper.cs   # Form navigation
│
└── Program.cs                # Application entry point
```

## 🗃️ Database Schema

### Tables

| Table | Description | Columns |
|-------|-------------|---------|
| **HastaTbl** | Patient records | HId, PatientName, Phone, Address, BirthDate, Gender, Allergy |
| **TedaviTbl** | Treatment catalog | TId, TreatmentName, Cost, Description |
| **RandevuTbl** | Appointments | RId, PatientName, TreatmentName, AppointmentDate, AppointmentTime |
| **ReceteTbl** | Prescriptions | RecId, PatientName, TreatmentName, TreatmentCost, Medication, MedicationQuantity |

**Note:** Relationships are text-based (e.g., PatientName matches), not foreign keys.

## 💻 Usage Examples

### Adding a Patient (Business Layer Pattern)

```csharp
// In PatientForm.cs
private readonly PatientManager _patientManager = new PatientManager();

private void SaveButton_Click(object sender, EventArgs e)
{
    try
    {
        _patientManager.SavePatient(
            PatientNameTextBox.Text,
            PhoneTextBox.Text,
            AddressTextBox.Text,
            BirthDatePicker.Value,
            GenderComboBox.Text,
            AllergyTextBox.Text
        );

        MessageBox.Show("Hasta başarıyla eklendi", "Başarılı",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        LoadPatients();
    }
    catch (ArgumentException ex)
    {
        MessageBox.Show(ex.Message, "Doğrulama Hatası",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}
```

### Creating a Repository Method

```csharp
// In PatientRepository.cs
public static class PatientRepository
{
    #region SQL Queries
    private const string SelectAll =
        "SELECT HId, PatientName, Phone, Address, BirthDate, Gender, Allergy FROM HastaTbl";
    #endregion

    #region Public Methods
    public static DataTable GetAll()
    {
        var dataSet = DataAccess.ExecuteQuery(SelectAll);
        return dataSet.Tables.Count > 0 ? dataSet.Tables[0] : new DataTable();
    }
    #endregion
}
```

### Navigation Pattern

```csharp
// ✅ CORRECT - Use NavigationHelper
NavigationHelper.NavigateToPatients(this);
NavigationHelper.NavigateToAppointments(this);
NavigationHelper.ExitApplication(); // Shows confirmation dialog

// ❌ WRONG - Don't create forms manually
new PatientForm().Show();
this.Hide();
```

## 🔧 Development Guidelines

### Golden Rules

1. **NEVER write SQL in forms** → Use Repository methods
2. **NEVER call Repository from forms** → Use Manager classes
3. **NEVER create forms manually** → Use NavigationHelper
4. **ALWAYS use parameterized queries** → Via `DataGridViewHelper.CreateParameter()`
5. **ALWAYS organize code with regions** → Match existing pattern

### Code Organization (Regions)

All forms follow this structure:
```csharp
#region Fields & Constants
#region Constructor
#region Form Events
#region CRUD Operations
#region Grid Events
#region Search & Filter
#region Helper Methods
#region Navigation Events
```

### Naming Conventions

| Type | Convention | Example |
|------|-----------|---------|
| **Controls** | PascalCase + Type | `PatientNameTextBox`, `SaveButton` |
| **Methods** | PascalCase | `LoadPatients()`, `ClearInputFields()` |
| **Fields** | _camelCase | `_selectedPatientId`, `_patientManager` |
| **Constants** | PascalCase | `SelectAll`, `InsertSql` |
| **UI Labels** | Turkish | "Hasta Adı", "Randevu Tarihi" |

## 🧪 Testing

Currently, testing is manual. To test after changes:

1. Build project without warnings
2. Run application
3. Test affected CRUD operations
4. Verify grid selection and data binding
5. Check navigation between forms

## 📝 Adding New Features

### Adding a New Form

1. Create WinForms files: `{Name}Form.cs`, `{Name}Form.Designer.cs`, `{Name}Form.resx`
2. Add navigation method in [`NavigationHelper.cs`](NavigationHelper.cs)
3. Create Manager in `Business/{Name}Manager.cs`
4. Create Repository in `Repositories/{Name}Repository.cs`
5. Update [`DisKlinik.csproj`](DisKlinik.csproj) with new files

### Adding a Repository Method

```csharp
public static DataTable Search(string searchText)
{
    string sql = "SELECT * FROM TableName WHERE Column LIKE @Search";
    var dataSet = DataAccess.ExecuteQuery(sql,
        new SqlParameter("@Search", "%" + searchText + "%"));
    return dataSet.Tables.Count > 0 ? dataSet.Tables[0] : new DataTable();
}
```

## 🐛 Known Limitations

- ⚠️ Hardcoded connection string (user-specific path)
- ⚠️ Text-based relationships instead of foreign keys
- ⚠️ Basic validation (phone length only)
- ⚠️ No logging infrastructure
- ⚠️ No unit tests
- ⚠️ Static classes (no dependency injection)

## 🤝 Contributing

1. Fork the repository
2. Create feature branch (`git checkout -b feature/AmazingFeature`)
3. Follow coding guidelines in [.github/copilot-instructions.md](.github/copilot-instructions.md)
4. Commit changes (`git commit -m 'Add AmazingFeature'`)
5. Push to branch (`git push origin feature/AmazingFeature`)
6. Open Pull Request

### Before Committing

- [ ] All SQL queries are in Repository classes
- [ ] All validation is in Manager classes
- [ ] Forms only call Manager methods
- [ ] All navigation uses NavigationHelper
- [ ] All regions are properly organized
- [ ] Build succeeds without warnings

## 📄 License

This project is licensed under the MIT License - see the LICENSE file for details.

## 👥 Authors

- **Ferdi Kanat** - *Initial work*

## 🙏 Acknowledgments

- [Guna.UI2.WinForms](https://gunaui.com/) - Modern UI components
- Microsoft LocalDB - Database engine
- Visual Studio - Development environment

## 📧 Contact

Project Link: [https://github.com/ferdi-kanat/disklinik](https://github.com/ferdi-kanat/disklinik)

---

**Built with ❤️ for dental clinics in Turkey**
