
# Database Prerequisite

## Overview

This project uses Microsoft SQL Server LocalDB for the database. By default, it connects to a **custom LocalDB instance**:

```
(localdb)\SDV701ComputerApp
```

To ensure compatibility, **manually create this LocalDB instance** is necessary.

### 🛠 How to Create SDV701ComputerApp Instance

Open **Command Prompt** as Administrator and run the following commands:

```bash
sqllocaldb info
sqllocaldb create "SDV701ComputerApp"
sqllocaldb start "SDV701ComputerApp"
```

Once created, you can run the provided SQL script to initialize the database schema and data:

1. Open `SQL Server Management Studio (SSMS)`
2. Connect to:
   ```
   (localdb)\SDV701ComputerApp
   ```
3. Open and execute the SQL file:
   ```
   script.sql
   ```

This will create the database `ComputerStoreDB` along with the required tables and sample data.

---

## 🔗 Connection String

Make sure your `appsettings.json` contains the following connection string:

```json
"ConnectionStrings": {
  "Connection": "Server=(localdb)\\SDV701ComputerApp;Database=ComputerStoreDB;Trusted_Connection=True;"
}
```

---