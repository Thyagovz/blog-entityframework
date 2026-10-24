# Blog Entity Framework

Projeto pessoal de aprendizado focado na construção de um domínio de blog com
`.NET` e `Entity Framework Core`. A aplicação explora persistência em SQL
Server, mapeamento de entidades, relacionamentos, carregamento relacionado e
operações de atualização com change tracking.

O projeto está deliberadamente concentrado na camada de dados e em uma
execução via console. Ele serve como base técnica para evoluções futuras, como
uma API e uma interface frontend interativa.

## Visão geral

O domínio contempla usuários, categorias, posts, tags e funções. As entidades
possuem mapeamentos explícitos para o banco, incluindo chaves, tipos SQL,
limites de tamanho, campos obrigatórios, relacionamentos e chaves compostas
para entidades associativas.

O fluxo atual em `Program.cs` demonstra como:

- criar entidades relacionadas em memória;
- consultar posts com `Include` para autor e categoria;
- ordenar resultados por data de atualização;
- atualizar uma entidade relacionada;
- persistir alterações com `SaveChanges`.

## Stack tecnológica

| Tecnologia | Papel no projeto |
| --- | --- |
| **C#** | Linguagem principal para o domínio, contexto de dados e fluxo de execução. |
| **.NET 10** | Runtime e SDK da aplicação console, com nullable reference types e implicit usings habilitados. |
| **Entity Framework Core 10** | ORM responsável por materializar entidades, acompanhar alterações e traduzir consultas LINQ para SQL. |
| **EF Core SQL Server** | Provedor de persistência para conexão e operações compatíveis com Microsoft SQL Server. |
| **Microsoft.Extensions.Configuration.Json** | Leitura da connection string a partir do `appsettings.json`, mantendo a configuração fora do código de infraestrutura. |
| **System.Security.Cryptography.Pkcs** | Dependência disponível para cenários de criptografia e empacotamento criptográfico no processo de aprendizado. |
| **SQL Server** | Banco relacional usado pelo contexto `BlogDataContext`. O exemplo de conexão aponta para uma instância local em Docker ou ambiente equivalente. |

### Decisões técnicas

- **Mapeamento por Data Annotations:** as entidades declararam tabelas,
  chaves, colunas, tipos SQL, tamanhos e obrigatoriedade diretamente nos
  modelos para tornar o contrato com o banco explícito.
- **Relacionamentos tipados:** `Post` referencia `Category` e `User`;
  `PostTag` e `UserRole` representam associações com chaves compostas.
- **Carregamento relacionado explícito:** `Include` é usado nas consultas em
  que autor e categoria precisam ser materializados junto com o post.
- **Change tracking:** a atualização de autor demonstra o rastreamento padrão
  do EF Core antes da persistência.
- **Configuração externa:** a connection string é carregada em tempo de
  execução e validada antes da configuração do provedor SQL Server.

## Funcionalidades atuais

- Modelos de usuário, post, categoria, tag e função.
- Relacionamentos entre posts, autores e categorias.
- Entidades associativas para posts/tags e usuários/funções.
- Consultas LINQ com ordenação e carregamento relacionado.
- Persistência e atualização de dados via EF Core.
- Mapeamento de tipos e restrições do domínio para SQL Server.

## Experiência interativa e escopo

Esta versão ainda não contém uma camada frontend nem bibliotecas de
renderização no browser.

## Requisitos

- .NET SDK 10.0 ou compatível com o `TargetFramework` do projeto.
- SQL Server acessível pela aplicação.
- Uma base `Blog` criada na instância configurada.

## Instalação e execução

1. Configure a connection string `DefaultConnection` em
   `appsettings.json` ou em um arquivo local não versionado.
2. Restaure as dependências:

   ```bash
   dotnet restore
   ```

3. Compile o projeto:

   ```bash
   dotnet build
   ```

4. Execute a aplicação:

   ```bash
   dotnet run
   ```

O `BlogDataContext` falha explicitamente quando `DefaultConnection` não está
configurada, evitando iniciar a aplicação com uma conexão inválida.

## Nota sobre credenciais e aprendizado

No início do estudo, uma credencial de banco chegou a ficar exposta
intencionalmente como parte da experimentação local. Depois, a configuração
foi movida para `appsettings.json`, deixando o código de infraestrutura sem a
credencial embutida e permitindo alterar o ambiente sem recompilar.

Essa mudança foi feita com finalidade didática: demonstrar a separação entre
código e configuração, não estabelecer um padrão de segurança para produção.
O arquivo versionado deve conter apenas valores fictícios ou mascarados; em um
ambiente real, use variáveis de ambiente, User Secrets, um cofre de segredos ou
outro mecanismo de configuração segura. Senhas de usuários também devem ser
armazenadas somente como hashes fortes, com salt e política adequada de
gerenciamento de credenciais.

## Observações

Este é um projeto pessoal voltado ao aprendizado prático de persistência e
modelagem com Entity Framework Core.
