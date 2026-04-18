Movie API
En enkel REST API byggd med asp .net för att hantera filmer.

funktioner:
- Hämta alla filmer
- Hämta en film med id
- Skapa en film
- Uppdatera en film
- Ta bort en film

Tekniker
C# / .NET
Entity Framework Core
SQLite
Docker & Docker Compose

Köra Projektet (utan Docker)
dotnet run

öppna webbläsaren och navigera till http://localhost:5000/swagger

Köra Projektet (med Docker)
docker-compose up
öppna webbläsaren och navigera till http://localhost:8080/swagger

Stoppa Docker
docker-compose down

Struktur
- Controllers: API endpoints
- Models: Datamodeller
- Data: Databas kontext
- Migrations: Entity Framework migrationer

Om projektet
Detta projekt är avsett som en enkel demonstration av en REST API för att hantera filmer. Det kan utökas med fler funktioner som autentisering, mer avancerade sökfunktioner, eller integration med externa API:er för att hämta filmdata.

