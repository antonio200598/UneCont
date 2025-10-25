# 🧾 UneCont API

O **UneCont** é um projeto desenvolvido em **C# / .NET**, cujo objetivo é realizar operações com Nota Fiscal(em formato XML).  
No momento existe dois endpoints para essa Api, no qual um é para inserção das informações da nota fiscal no banco de dados e outro é para checagem de notas fiscais já existentes no banco de dados.

---

## 🚀 Tecnologias Utilizadas

- **Linguagem:** C#
- **Framework:** .NET 6 / 7 (verifique a versão no .csproj)
- **Padrão de Projeto:** MVC / RESTful API
- **Banco de Dados:** SqlServer
- **ORM:** Entity Framework Core
- **Controle de versão:** Git + GitHub
- **Ferramentas para Teste:** Postman(pode ser usado o insomnia também)
---

## ⚙️ Configuração e Execução Local

### 🧩 Pré-requisitos

Antes de executar o projeto, você precisará ter instalado:

- [SDK .NET 6+](https://dotnet.microsoft.com/download)
- Banco de dados: Sql Server
- Editor recomendado: [Visual Studio 2022](https://visualstudio.microsoft.com/) ou [Visual Studio Code](https://code.visualstudio.com/)

### ▶️ Passos para execução

1. Clone este repositório:
   ```bash
   git clone https://github.com/antonio200598/UneCont.git
   cd UneCont/UneContAPI
2. Para Comunicação com o banco de dados crie uma banco com o nome UneCont ou edite na classe [Program.cs](/UneContAPI/Program.cs) para que use um existente no seu sql server.
3. Segue o link dos scripts das tabelas usadas: [Migrations](Migrations).
4. Após tudo configurado, rode a aplicação.

### Observações:

Urls para uso no postman:

Save-Notafiscal(Requisição tipo Post): https://localhost:7077/api/UneContApi/Save-NotaFiscal 

Get-NotaFiscal(Requisição tipo Get): https://localhost:7077/api/UneContApi/Get-NotaFiscal

Formatos dos documentos XMLs usados:

```xml

<NotaFiscal>
    <Numero>67890</Numero>
    <Prestador>
        <CNPJ>22345678000177</CNPJ>
    </Prestador>
    <Tomador>
        <CNPJ>88765432000166</CNPJ>
    </Tomador>
    <DataEmissao>2023-12-05</DataEmissao>
    <Servico>
        <Descricao>Serviços de manutenção de sistemas</Descricao>
        <Valor>2400.00</Valor>
    </Servico>
</NotaFiscal>
