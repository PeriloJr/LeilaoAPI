# 🎯 Sistema de Leilão - ASP.NET Core MVC

Este é um sistema de leilões desenvolvido em **ASP.NET Core MVC**, permitindo a gestão e participação em leilões de imóveis e veículos.

## 🛠 Tecnologias Utilizadas

- **C#** e **ASP.NET Core MVC**
- **Entity Framework Core**
- **SQL Server**
- **Bootstrap (para a interface gráfica)**

## 🔥 Principais Funcionalidades

### ✅ Gestão de Produtos Leiloados

- Cadastro, edição e remoção de **imóveis** e **veículos** disponíveis para leilão.
- Os produtos devem estar obrigatoriamente vinculados a um leilão.

### ✅ Gestão de Leilões

- Registro e consulta de leilões futuros, com data, local e detalhes da realização.
- Associação dos produtos (imóveis/veículos) ao leilão correspondente.

### ✅ Clientes e Instituições Financeiras

- Registro e gerenciamento de **clientes cadastrados**, que podem consultar leilões e dar lances.
- Cadastro das **instituições financeiras** responsáveis pela quitação dos lances vencedores.

### ✅ Sistema de Lances

- Clientes podem realizar lances, respeitando regras de incremento mínimo e valores arredondados.
- Histórico de lances exibido em ordem cronológica.

## 🚀 Como Executar o Projeto

1. Clone o repositório:

   ```bash
   git clone https://github.com/seu-usuario/seu-repositorio.git
   cd seu-repositorio
   ```

2. Configure a **string de conexão** no `appsettings.json`.
3. Execute as **migrações do banco de dados**:

   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

4. Execute a aplicação:

   ```bash
   dotnet run
   ```

5. Acesse `https://localhost:5001` para visualizar o sistema.

## 📌 Próximos Passos

- Implementar autenticação de usuários.
- Melhorar a interface gráfica com Bootstrap e JavaScript.
- Criar uma API para integração com frontend moderno (React ou Angular).
