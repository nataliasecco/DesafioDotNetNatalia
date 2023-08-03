# Descrição do projeto

Este projeto é uma aplicação web que possibilita o upload de arquivos no formato CNAB, faz o parse e tratamento dos dados contidos nesses arquivos e os salva em um banco de dados.

# Funcionamento da aplicação

- A aplicação apresenta um menu dropdown no lado esquerdo da tela para navegar entre as views "home", "transactions" e "upload file".
- A rota principal "upload" permite ao usuário selecionar um arquivo CNAB para processamento e salvá-lo no banco de dados.
- A rota "transactions" exibe uma tabela dinâmica contendo todas as transações armazenadas no banco de dados, independentemente se foram cadastradas através do formulário ou do arquivo CNAB.
- Além dessas, há uma terceira rota chamada "home", que é usada apenas para apresentar informações sobre o autor do projeto.

# Tecnologias utilizadas no desenvolvimento do projeto

- Aplicação construída utilizando requisições HTTP para facilitar a comunicação.
- Ambiente de desenvolvimento: Microsoft Visual Studio 2022 IDE.
- Backend desenvolvido em ASP.NET Core (C#).
- Frontend desenvolvido usando HTML, CSS e JavaScript, com o framework CSS Bulma e o plugin DataTable do jQuery para estilização e apresentação dos dados.
- Biblioteca MongoDB.Driver para C# utilizada para conectar a aplicação a uma instância local do banco de dados MongoDB.
- Postman utilizado para testar a API.

# Requisitos para o funcionamento do projeto

- Instância local do MongoDB rodando para executar o projeto localmente.
Caso não tenha instalado, você pode acessar o link: (https://www.mongodb.com/try/download/community).
- (Opcional) Duas opções para se conectar a uma base de dados local usando o MongoDB: através do shell do MongoDB ou através do Compass, uma interface gráfica para o MongoDB. Links abaixo:
    Mongo Compass: (https://www.mongodb.com/pt-br/products/compass)
    Mongo Shell: (https://www.mongodb.com/try/download/community)
- É necessário ter o .NET e o SDK do .NET instalados, na versão 6.0 ou mais recente.

# Como iniciar a aplicação

- Faça o clone deste repositório para uma pasta local.
- Com o .NET instalado, abra o terminal do Windows ou Linux e navegue até a pasta onde o repositório foi clonado.
- Execute o comando "dotnet build" seguido por "dotnet run". O terminal imprimirá mensagens de execução conforme mostrado abaixo:

# Rota "Carregamento"

Nesta rota, o usuário pode fazer o upload de arquivos no formato CNAB para salvar suas transações no banco de dados.

# Rota "Transações"

Nesta rota, estão disponíveis as seguintes funcionalidades:

- **Botão de Detalhes**: Ao clicar neste botão, um modal é aberto exibindo todos os detalhes da transação realizada.

- **Botão Cadastrar Nova Transação**: Permite cadastrar uma nova transação individualmente, sem a necessidade de fazer o upload de um arquivo.

- **Funcionalidades de Filtro na Tabela**: A tabela de transações oferece recursos de filtragem, incluindo:
    - Ordenação Crescente e Decrescente: Permite ordenar as transações em ordem crescente ou decrescente.
    - Pesquisa: Permite filtrar as transações com base em informações como nome, valor, CPF, entre outros.
    - Paginação: A tabela é paginada, facilitando a navegação entre as transações.
    - Quantidade de Elementos por Página: O usuário pode definir a quantidade de elementos a serem exibidos por página.

# API's

A aplicação separa as API's de visualização das API's de tratamento de dados no lado do servidor, garantindo que as rotas sejam usadas apenas para renderização do frontend e delegando o tratamento dos dados às API's apropriadas.