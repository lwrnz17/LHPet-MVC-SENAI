# LH-Pet — ASP.NET Core MVC

Atividade SENAI de Codificação Back-End. Projeto MVC sem banco de dados, com Models `Cliente` e `Fornecedor`, listas criadas no `HomeController` e exibidas no `Index.cshtml` disponibilizado no material da atividade.

## Executar

1. Instale o SDK do .NET 8 (ou superior compatível com o projeto).
2. Abra um terminal na pasta `LHPet` (onde está o arquivo `LHPet.csproj`).
3. Execute `dotnet restore` e `dotnet run`.
4. Abra o endereço `http://localhost:...` ou `https://localhost:...` mostrado no terminal.

A página usa Bootstrap via CDN, portanto o estilo depende de conexão à internet. Os dados são apenas exemplos em memória, não persistidos. O PDF do SENAI usa .NET 6; este projeto usa .NET 8 por ser uma versão mais recente, mantendo a mesma arquitetura e os mesmos requisitos.

## Enviar ao GitHub

Na pasta `LHPet`, execute:

```bash
git init
git add .
git commit -m "Atividade MVC LH-Pet"
git branch -M main
git remote add origin URL_DO_SEU_REPOSITORIO
git push -u origin main
```

Crie antes um repositório vazio no GitHub e substitua `URL_DO_SEU_REPOSITORIO` pela URL real. Envie o link desse repositório no AVA.
