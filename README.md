# Simple CRUD
Web API desenvolvida com .NET 10 para demonstrar um CRUD simples de estudantes. O objetivo principal do projeto é aplicar conceitos de injeção de dependência, mapeamento de objetos com AutoMapper, persistência de dados com Entity Framework Core (SQL Server) e segregação de permissões de banco de dados via strings de conexão distintas.

## 🛠️ Tecnologias e Ferramentas
- ASP.NET Core Web API
- Entity Framework COre
- AutoMapper
- SQL Server

## 🏗️ Diferencial Técnico: Segregação de Connection Strings
Para aumentar a segurança em ambientes de produção, o projeto utiliza duas credenciais e strings de conexão distintas

- MigrationsConnection: Usada estritamente para a criação e atualização do esquema do banco de dados via CLI do EF Core.
- DefaultConnection: Usada pela aplicação em tempo de execução para garantir que a API não tenha privilégios para alterar a estrutura das tabelas (prevenção contra escalada de privilégios).

## 🛑 EndPoints
| Método | Endpoint | Descrição |
| ------ | -------- | --------- |
| GET    | /api/student | Retorna todos os estudantes cadastrados |
| GET    | /api/student/{id} | Retorna um estudante em específico |
| POST   | /api/student | Cria um novo estudante |
| PUT    | /api/student/{id} | Atualiza os dados de um estudante existente |
| DELETE | /api/student/{id} | Deleta um estudante do banco de dados |
