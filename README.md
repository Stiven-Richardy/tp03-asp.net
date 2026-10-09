# 📦 TP03 - Sistemas Web II: Sistema de Gerenciamento de Produtos

## 📖 Sobre o Projeto
Aplicação web corporativa desenvolvida sob o padrão arquitetural **ASP.NET Core MVC** (.NET 8) com persistência via **Entity Framework Core** e banco de dados **SQLite**. O sistema implementa o ciclo de vida operacional e gerencial de produtos (CRUD completo), provendo uma camada de controle desacoplada, validação de regras de domínio (*Model State* e *Data Annotations*), injeção de dependência e interface gráfica responsiva estruturada em Bootstrap 5.

## 🎯 Objetivos Atendidos
- Arquitetura limpa estruturada no padrão **MVC (Model-View-Controller)**.
- Mapeamento objeto-relacional (ORM) e abstração de dados via **Entity Framework Core**.
- Persistência desacoplada e portabilidade com **SQLite**.
- Injeção de dependência nativa do `DbContext` configurada no ciclo de inicialização (`Program.cs`).
- Roteamento convencional dinâmico apontando a rota raiz (`/`) diretamente para o catálogo de produtos.
- Validação estrita em duas camadas (Cliente e Servidor) com mensagens customizadas de erro.
- Design System moderno no padrão *Admin Dashboard* com navegação persistente via Sidebar azul corporativa (`#0A3D62`).

## 🛠️ Tecnologias e Ferramentas
- **Linguagem:** C# 12
- **Plataforma:** .NET 8.0 (LTS)
- **Framework Web:** ASP.NET Core MVC
- **ORM:** Entity Framework Core 8.0.26
- **Driver de Banco de Dados:** `Microsoft.EntityFrameworkCore.Sqlite`
- **Ferramentas de Migração:** `Microsoft.EntityFrameworkCore.Tools`
- **Interface Gráfica:** Razor Views (`.cshtml`), Bootstrap 5.3, Bootstrap Icons
- **Ambiente de Desenvolvimento:** Visual Studio 2022

## 🛣️ Estrutura de Rotas e Controladores

| Controlador | Ação | Método | Rota | Descrição |
|-------------|------|--------|------|-----------|
| `ProdutosController` | `Index` | `GET` | `/` ou `/Produtos` | Catálogo geral com listagem de produtos e indicadores de estoque |
| `ProdutosController` | `Details` | `GET` | `/Produtos/Details/{id}` | Ficha técnica detalhada com especificações do item |
| `ProdutosController` | `Create` | `GET/POST` | `/Produtos/Create` | Exibição e processamento de cadastro com validação de dados |
| `ProdutosController` | `Edit` | `GET/POST` | `/Produtos/Edit/{id}` | Carregamento e atualização concorrente do registro de produto |
| `ProdutosController` | `Delete` | `GET/POST` | `/Produtos/Delete/{id}` | Tela de confirmação e execução da remoção física no banco |
| `HomeController` | `Creditos` | `GET` | `/Home/Creditos` | Painel institucional da equipe de desenvolvimento |

## 📁 Estrutura do Projeto
```text
TP03/
│
├── Controllers/                  # Camada de Controle HTTP e orquestração do fluxo
│   ├── HomeController.cs         # Roteamento institucional e tela de equipe
│   └── ProdutosController.cs     # Operações de CRUD e regras de negócio de produtos
│
├── Data/                         # Camada de Acesso a Dados
│   └── AppDbContext.cs           # Contexto do Entity Framework Core
│
├── Migrations/                   # Histórico de versionamento e schema do banco
│
├── Models/                       # Domínio da Aplicação
│   └── Produto.cs                # Entidade Produto e Data Annotations de validação
│
├── Views/                        # Camada de Apresentação (Razor Engine)
│   ├── Home/
│   │   └── Creditos.cshtml       # Painel de desenvolvedores
│   ├── Produtos/
│   │   ├── Create.cshtml         # Formulário de cadastro com validações
│   │   ├── Delete.cshtml         # Confirmação segura de exclusão
│   │   ├── Details.cshtml        # Ficha técnica completa do item
│   │   ├── Edit.cshtml           # Formulário de edição
│   │   └── Index.cshtml          # Tabela de catálogo com badges dinâmicas
│   └── Shared/
│       ├── _Layout.cshtml        # Master Page corporativa com Sidebar ativa
│       ├── _ValidationScriptsPartial.cshtml
│       ├── _ViewImports.cshtml
│       └── _ViewStart.cshtml
│
├── wwwroot/                      # Recursos estáticos (Bootstrap, CSS, JS, libs)
├── appsettings.json              # Configurações de conexão e logging
├── Program.cs                    # Configuração de serviços, DI e pipeline HTTP
└── TP03.csproj                   # Configuração e dependências do projeto .NET
```

## 🚀 Como Executar o Projeto Localmente

### 1. Clonar o Repositório
```bash
git clone <url-do-repositorio>
```

### 2. Abertura no Visual Studio 2022
1. Abra o arquivo `TP03.sln` ou `TP03.csproj` no Visual Studio 2022.
2. Aguarde a restauração automática dos pacotes NuGet.

### 3. Banco de Dados (SQLite)
O banco de dados SQLite (`banco_tp03.db`) é autocontido. Caso deseje reconstruir o esquema do zero a partir das Migrations:
1. Abra o **Console do Gerenciador de Pacotes** (`Ferramentas > Gerenciador de Pacotes NuGet > Console do Gerenciador de Pacotes`).
2. Execute o comando:
```powershell
Update-Database
```

### 4. Execução
Pressione **`F5`** ou clique no botão de inicialização com HTTPS. O navegador abrirá imediatamente na rota principal `/`, apresentando o catálogo de produtos integrado.

## 👨‍💻 Equipe de Desenvolvimento
**Stiven Richardy Silva Rodrigues**  
*Líder Técnico & Engenharia de Software*  
*Estudante de Análise e Desenvolvimento de Sistemas | IFSP — Campus Cubatão*  
*Software Developer - Meta Globaltech*  
GitHub: [@Stiven-Richardy](https://github.com/Stiven-Richardy)

**Guilherme Mendes de Sousa**  
*Desenvolvimento Back-end & Colaboração*  
*Estudante de Análise e Desenvolvimento de Sistemas | IFSP — Campus Cubatão*  
GitHub: [@Guilh3rme-M3ndes](https://github.com/Guilh3rme-M3ndes)

## 📚 Referências
- Aulas teóricas e práticas 03, 04, 05 e 06 - Prof. Me. Wellington Tuler Moraes (Sistemas Web II - IFSP Cubatão).
- Documentação Oficial da Microsoft: ASP.NET Core MVC & Entity Framework Core.
