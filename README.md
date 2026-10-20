# 🚀 Task Manager API

REST API desenvolvida com **ASP.NET Core Web API e C#** para fornecer os serviços de backend da aplicação **Task Manager**.

A API disponibiliza operações para criação, consulta, atualização e exclusão de tarefas e é consumida pelo frontend desenvolvido com **Next.js, React e TypeScript**.

---

## 📌 Sobre o projeto

O **Task Manager** é um projeto Full Stack desenvolvido com o objetivo de aplicar conceitos de desenvolvimento web moderno, separação entre frontend e backend, integração via API REST e organização de código.

A solução está dividida em dois projetos:

### Backend

**Task Manager API**

Tecnologias principais:

- ASP.NET Core Web API
- C#
- Swagger / OpenAPI
- REST

### Frontend

**Task Manager Next.js**

Tecnologias principais:

- Next.js
- React
- TypeScript
- PrimeReact
- PrimeFlex
- Axios
- Chart.js

Frontend disponível em:

[task-manager-nextjs](https://github.com/leaodiego/task-manager-nextjs)

---

## 🏗️ Arquitetura

A aplicação utiliza uma arquitetura separando frontend e backend.

```text
┌──────────────────────────────┐
│      task-manager-nextjs     │
│                              │
│  Next.js + React             │
│  TypeScript + PrimeReact     │
└──────────────┬───────────────┘
               │
               │ HTTP / REST
               │
               ▼
┌──────────────────────────────┐
│       task-manager-api       │
│                              │
│  ASP.NET Core Web API        │
│  C#                          │
└──────────────────────────────┘
```

Durante o desenvolvimento local:

```text
Frontend
http://localhost:3000

        │
        ▼

API
http://localhost:5161
```

---

## ⚙️ Funcionalidades

A API disponibiliza operações CRUD para gerenciamento de tarefas:

- ✅ Listar tarefas
- ✅ Consultar tarefa por ID
- ✅ Criar tarefa
- ✅ Atualizar tarefa
- ✅ Excluir tarefa
- ✅ Documentação e testes dos endpoints através do Swagger

---

## 🔗 Endpoints

### Listar tarefas

```http
GET /api/Tarefas
```

Retorna a coleção de tarefas.

---

### Consultar tarefa por ID

```http
GET /api/Tarefas/{id}
```

Retorna uma tarefa específica utilizando o identificador informado.

---

### Criar tarefa

```http
POST /api/Tarefas
```

Cria uma nova tarefa.

---

### Atualizar tarefa

```http
PUT /api/Tarefas/{id}
```

Atualiza uma tarefa existente.

---

### Excluir tarefa

```http
DELETE /api/Tarefas/{id}
```

Remove uma tarefa utilizando seu identificador.

---

## 📚 Swagger

Durante o desenvolvimento, a API disponibiliza documentação interativa através do **Swagger UI**.

Com a aplicação executando localmente:

```text
http://localhost:5161/swagger
```

No Swagger é possível visualizar e testar os endpoints disponíveis na API.

---

## 🛠️ Tecnologias utilizadas

- **C#**
- **ASP.NET Core Web API**
- **Swagger / OpenAPI**
- **REST API**
- **Docker**

---

## 📁 Estrutura do projeto

```text
TaskManager.Api/
│
├── Controllers/
│   └── TarefasController.cs
│
├── Models/
│   └── Tarefa.cs
│
├── Properties/
│   └── launchSettings.json
│
├── .dockerignore
├── .gitignore
├── Dockerfile
├── Program.cs
├── TaskManager.Api.csproj
├── TaskManager.Api.http
├── appsettings.json
└── appsettings.Development.json
```

### Principais diretórios

**Controllers**

Responsável pelos endpoints HTTP disponibilizados pela API.

**Models**

Contém os modelos utilizados pela aplicação.

**Properties**

Contém configurações utilizadas durante a execução local do projeto.

---

## 🚀 Como executar o projeto

### Pré-requisitos

Para executar a API localmente é necessário possuir o **.NET SDK** compatível com o projeto.

Confira a instalação:

```bash
dotnet --version
```

---

### 1. Clone o repositório

```bash
git clone https://github.com/leaodiego/task-manager-api.git
```

### 2. Entre no diretório

```bash
cd task-manager-api
```

### 3. Restaure as dependências

```bash
dotnet restore
```

### 4. Compile o projeto

```bash
dotnet build
```

### 5. Execute a API

```bash
dotnet run
```

A configuração atual de desenvolvimento utiliza:

```text
http://localhost:5161
```

---

## 🔄 Integração com o frontend

O frontend utiliza a variável de ambiente:

```env
NEXT_PUBLIC_API_URL=http://localhost:5161
```

A aplicação Next.js utiliza esse endereço para realizar as requisições HTTP para a API.

No backend, o CORS está configurado para permitir requisições do ambiente local do frontend:

```text
http://localhost:3000
```

Isso permite a comunicação:

```text
Next.js
localhost:3000

     ↓ REST

ASP.NET Core API
localhost:5161
```

---

## 🌐 Repositórios

### Frontend

[task-manager-nextjs](https://github.com/leaodiego/task-manager-nextjs)

### Backend

[task-manager-api](https://github.com/leaodiego/task-manager-api)

---

## 🎯 Objetivos do projeto

Este projeto foi desenvolvido para praticar e demonstrar conhecimentos em:

- Desenvolvimento Full Stack
- Construção de APIs REST
- ASP.NET Core
- C#
- React e Next.js
- TypeScript
- Integração frontend/backend
- Requisições HTTP
- CRUD
- CORS
- Swagger / OpenAPI
- Git e GitHub
- Organização e separação de responsabilidades

---

## 👨‍💻 Autor

**Diego Viana Leão**

GitHub:

[github.com/leaodiego](https://github.com/leaodiego)

---

## 📄 Status

🚧 Projeto em evolução.

O backend está funcional e integrado ao frontend do Task Manager. Melhorias e novas funcionalidades poderão ser adicionadas conforme a evolução do projeto.
