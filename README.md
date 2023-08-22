# EF Core JSON Column Issue

## Running the Code
_Note: Please ensure you have a MSSQL server available. I was using [MSSQL Express 2019 Docker](https://hub.docker.com/_/microsoft-mssql-server)_

1. Ensure you set your connection string to your db in `appsettings.json`.
2. Ensure you run `Update-Database` in the package manager console
3. When you are ready to insert the records, go to the URL `/index?generatePeople=true` to run the generation and insertion. You can then delete the rows manually and re-apply to test.
