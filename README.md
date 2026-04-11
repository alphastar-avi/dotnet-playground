# API Rate Limiter (CLI)

A simple C# console application that simulates API rate limiting by allowing a fixed number of requests per route.

## Available Commands

- add     – Create a new API route and set its request limit
- request – Send a request to a route
- status  – View current usage of a route
- Reset - Reset the limit rate for a route
- help    – Display available commands
- clear   – Clear the console
- exit    – Exit the application

# Database Setup Instructions

## Prerequisites
- SQL Server LocalDB installed
- SQL Server Management Studio (SSMS)

## Setup Steps

### Option 1: Run Individual Scripts
1. Open SSMS
2. Connect to `(localdb)\MSSQLLocalDB`
3. Run scripts in order:
   - `001_CreateDatabase.sql`
   - `002_CreateRoutesTable.sql`
   - `003_CreateStoredProcedures.sql`

### Option 2: Run Master Script
1. Open SSMS
2. Connect to `(localdb)\MSSQLLocalDB`
3. Open `000_RunAll.sql`
4. Enable SQLCMD Mode: Query ? SQLCMD Mode
5. Execute

