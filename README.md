# StockMarketData

StockMarketData is a .NET application that utilizes the Financial Modeling Prep (FMP) API to fetch and store stock market data in an SQL Server database.

## Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
  - [Configuration](#configuration)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

## Overview

StockMarketData is crafted to aggregate and manage financial information from the Financial Modeling Prep API, ensuring precise and up-to-date financial data storage and analysis. It leverages the capabilities of .NET for powerful data processing and database interaction.

## Features

- Integration with Financial Modeling Prep API for stock data retrieval.
- Storage of financial data in an SQL Server database.
- Support for real-time updates and historical data retention.
- Robust .NET implementation for reliable performance.

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- Financial Modeling Prep API Key

### Installation

1. **Clone the repository:**

   ```bash
   git clone https://github.com/yourusername/StockMarketData.git
   cd StockMarketData
   ```

2. **Restore dependencies:**

    Execute the following command to restore all dependencies for the project:
    ```bash
    dotnet restore
    ```

3. **Build the project:**

    After restoring dependencies, build the project with:

    ```bash
    dotnet build
    ```

### Configuration

1. **App settings:**

    Update `appsettings.json` with your SQL Server connection string and API key:

    ```json
    {
        "ConnectionStrings": {
            "DefaultConnection": "Server=your_server_name;Database=your_database_name;User Id=your_user_id;Password=your_password;"
        },
        "FMP": {
            "ApiKey": "your_api_key_here"
        }
    }
    ```

2. **Database Migrations:**

    Use Entity Framework Core to apply migrations and set up your database schema:

    ```bash
    dotnet ef database update
    ```

    ## Usage

1. **Running the Application:**

    Start the application to fetch and store data by running:

    ```bash
    dotnet run
    ```

2. **Data Access:**

    Once data is stored, use your preferred SQL client tools to query and analyze the financial data.

## License

    This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.
    
## Key Points

- **Restore Dependencies**: Use the `dotnet restore` command to download and install all necessary dependencies according to the project's configuration.

- **Configuration Settings**: Ensure `appsettings.json` is correctly updated with your SQL Server connection string and Financial Modeling Prep API key. This ensures your application can connect to the necessary services.

- **Database Setup**: Apply database migrations using Entity Framework Core to initialize and update your database schema, aligning it with your data model.

- **Application Execution**: Run the application using `dotnet run` to begin fetching and storing financial data into your SQL Server database.

- **Data Access**: Utilize SQL client tools to access, query, and analyze the financial data stored within the database.

- **Contribution Process**: Contributions are welcome through the standard GitHub workflow—fork the repository, create a branch, commit changes, and open a pull request.

- **Licensing**: This project is available under the MIT License, offering flexibility for modification and distribution. See the [LICENSE](LICENSE) file for more details.