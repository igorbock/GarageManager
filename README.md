# GarageManager

Projeto que gerencia ordens de serviço para oficinas mecânicas.

## Estado atual (refatoração 2026)

O projeto foi unificado em um único aplicativo **Windows Forms** (.NET 10), eliminando a separação
antiga entre os projetos `GarageManager` (frontend), `Data` (acesso a dados) e `Dominio` (modelos).

### Estrutura

```
GarageManager/
├── Program.cs          # Ponto de entrada (cria o banco e abre a tela principal)
├── App.config          # Connection string do SQLite
├── Forms/              # Telas (code-behind + Designer)
│   ├── Home.cs         # Tela principal (abrir OS, consultas abertas/encerradas/histórico)
│   ├── OS_Info.cs      # Detalhes/edição da ordem de serviço
│   ├── PecasMaoObra.cs # Inclusão de peças e mão de obra
│   ├── Pagamento.cs    # Forma de pagamento
│   └── Dialogo.cs      # Confirmação de exclusão de itens
├── Models/             # Modelos e DTOs (POCOs sem dependência de ORM)
│   ├── OrdemServico.cs
│   ├── OrdemServicoDTO.cs
│   ├── Peca.cs
│   └── PecaDTO.cs
└── Data/               # Acesso a dados
    └── GarageDb.cs     # Conexão SQLite + criação automática do schema
```

### Tecnologias

- .NET 10 (Windows Forms)
- [Dapper](https://github.com/DapperLib/Dapper) com SQL puro chamado diretamente no code-behind das telas
- SQLite ([Microsoft.Data.Sqlite](https://learn.microsoft.com/pt-br/dotnet/standard/data/sqlite/))
  - O banco `garage.db` é criado automaticamente na primeira execução, ao lado do executável
  - Preparado para evoluir para SQLCipher (basta adicionar a chave de criptografia na connection string)

### Histórico

- **2020** - Projeto piloto em .NET Framework 4.7.2, Entity Framework 6 + PostgreSQL, com separação
  em 3 projetos (GarageManager, Data, Dominio).
- **2025** - Experiências de refatoração para .NET 8/Blazor e MAUI (branches separadas).
- **2026** - Unificação dos projetos em um único WinForms, migração para SQLite + Dapper com SQL puro.