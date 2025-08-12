# 📚 Blazor Mangás API

Uma API RESTful desenvolvida em ASP.NET Core (.NET 8) para cadastro, autenticação e gerenciamento de mangás. Ideal para integrar com um frontend Blazor ou qualquer aplicação moderna que consuma dados via HTTP.

---

## 🚀 Tecnologias Utilizadas

- ASP.NET Core 8 (API)
- Entity Framework Core
- Identity com autenticação JWT
- AutoMapper
- Swagger para documentação
- LINQ + extensões de paginação

---

## ⚙️ Funcionalidades

- 🔐 Cadastro e login de usuários com JWT
- 📄 Listagem de mangás com paginação
- 🔍 Busca por título ou categoria
- 🧩 Integração com banco via EF Core
- 📦 DTOs para transporte limpo de dados
- 🧠 Separação por camadas (Entities, Repositories, Controllers, DTOs)

---

## 🧪 Como rodar localmente

1. Certifique-se que o .NET 8 SDK está instalado:
```bash
dotnet --version
```

2. Clone o projeto:
```bash
git clone <url-do-repositorio>
cd BlazorMangasProjeto
```

3. Restaure as dependências:
```bash
dotnet restore
```

4. Execute a aplicação:
```bash
dotnet run
```

5. Acesse no navegador:
```
http://localhost:5094/swagger
```

---

## 🗂️ Estrutura do Projeto

```
📦 BlazorMangasProjeto
├── Controllers/
├── DTOs/
├── Entities/
├── Extensions/
├── Mappings/
├── Repositories/
├── Program.cs
├── appsettings.json
└── ApiMangas.csproj
```

---

## 📌 Endpoints Principais

| Método | Rota | Descrição |
|--------|------|-----------|
| `POST` | `/api/users/register` | Cadastro de novo usuário |
| `POST` | `/api/users/login` | Login com JWT |
| `GET`  | `/api/mangas` | Lista todos os mangás |
| `GET`  | `/api/mangas/paginacao` | Mangás paginados |
| `GET`  | `/api/mangas/search/{titulo}` | Buscar por título |
| `GET`  | `/api/mangas/get-mangas-by-category/{categoriaId}` | Buscar por categoria |

---# Projeto-Biblioteca-BlazorMangas
