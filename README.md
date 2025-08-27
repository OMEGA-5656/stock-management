# Stock Management System

A comprehensive stock management web application built with .NET 9 and MySQL, featuring a REST API and modern web interface.

## 🚀 Features

- **Full CRUD Operations**: Create, Read, Update, and Delete products
- **Search Functionality**: Search products by name, description, category, or SKU
- **Modern UI**: Responsive Bootstrap-based interface with Font Awesome icons
- **REST API**: Complete API with Swagger documentation
- **Database Integration**: MySQL database with Entity Framework Core
- **Real-time Stock Tracking**: Monitor product quantities with visual indicators

## 🏗️ Architecture

- **API Layer**: ASP.NET Core Web API (`StockManagementAPI`)
- **Web Interface**: ASP.NET Core MVC (`StockManagementWeb`)
- **Database**: MySQL with Entity Framework Core
- **Frontend**: Bootstrap 5 + Font Awesome icons

## 📋 Prerequisites

- .NET 9.0 SDK
- MySQL database (local or remote)
- Web browser

## 🛠️ Setup Instructions

### 1. Database Configuration

Update the connection string in `StockManagementAPI/appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=your_server;Port=3306;Database=your_database;User=your_user;Password=your_password;CharSet=utf8mb4;AllowPublicKeyRetrieval=true;SslMode=Preferred;"
  }
}
```

### 2. Running the Application

#### Start the API (Port 5099)
```bash
cd StockManagementAPI
dotnet run --urls "http://localhost:5099"
```

#### Start the Web Application (Port 5000)
```bash
cd StockManagementWeb
dotnet run --urls "http://localhost:5000"
```

### 3. Access the Application

- **Web Interface**: http://localhost:5000
- **API Documentation**: http://localhost:5099/swagger
- **API Endpoints**: http://localhost:5099/api/products

## 📚 API Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/api/products` | Get all products |
| GET | `/api/products/{id}` | Get product by ID |
| POST | `/api/products` | Create new product |
| PUT | `/api/products/{id}` | Update product |
| DELETE | `/api/products/{id}` | Delete product |
| GET | `/api/products/search?query={term}` | Search products |

## 🗄️ Database Schema

### Products Table
- `Id` (int, Primary Key, Auto Increment)
- `Name` (varchar(100), Required)
- `Description` (varchar(500), Optional)
- `Price` (decimal(18,2), Required)
- `Quantity` (int, Required)
- `Category` (varchar(50), Optional)
- `SKU` (varchar(50), Optional)
- `CreatedAt` (datetime)
- `UpdatedAt` (datetime)

## 🎨 Web Interface Features

- **Product List**: View all products in a responsive table
- **Search**: Real-time search across all product fields
- **Add Product**: Form to create new products
- **Edit Product**: Update existing product information
- **Delete Product**: Confirmation dialog for safe deletion
- **Stock Indicators**: Color-coded quantity badges (Green > 10, Yellow 1-10, Red 0)

## 🔧 Development

### Project Structure
```
stock-management/
├── StockManagementAPI/          # REST API
│   ├── Controllers/
│   ├── Data/
│   ├── Models/
│   └── Program.cs
├── StockManagementWeb/          # Web Interface
│   ├── Controllers/
│   ├── Models/
│   ├── Views/
│   └── Program.cs
└── README.md
```

### Adding New Features

1. **API Changes**: Modify controllers in `StockManagementAPI/Controllers/`
2. **Database Changes**: Update models in `StockManagementAPI/Models/` and run migrations
3. **UI Changes**: Update views in `StockManagementWeb/Views/`

## 🚨 Troubleshooting

### Common Issues

1. **Database Connection Error**
   - Verify connection string in `appsettings.json`
   - Ensure MySQL server is running
   - Check database credentials

2. **API Not Starting**
   - Ensure .NET 9.0 SDK is installed
   - Check for port conflicts
   - Verify all NuGet packages are restored

3. **Web App Not Connecting to API**
   - Ensure API is running on port 5099
   - Check CORS settings
   - Verify API endpoints are accessible

## 📝 License

This project is open source and available under the MIT License.

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch
3. Make your changes
4. Test thoroughly
5. Submit a pull request

---

**Happy Stock Managing! 📦**
