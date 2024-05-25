# Desafio Dotkon - ToDo List

## Descrição

Desenvolva uma aplicação em que uma pessoa possa controlar suas tarefas diárias e ter controle do que já foi concluído e o que está em andamento. O usuário precisa ver um título, descrição e data para término, e também a possibilidade de criar novas tarefas. Além do próprio usuário, outras pessoas também podem adicionar tarefas para si mesmas, mas o usuário principal não verá as tarefas das outras pessoas.

## Sumário

1. [Requisitos de Negócio](#requisitos-de-negócio)
2. [Requisitos Técnicos](#requisitos-técnicos)
3. [Requisitos para o Trabalho](#requisitos-para-o-trabalho)
4. [Requisitos para Publicação da Aplicação](#opcional-requisitos-para-publicação-da-aplicação)
5. [Objetivos](#objetivos)


## Requisitos de Negócio
Antes de começar a desenvolver, é importante saber gerenciar suas atividades como desenvolvedor ou gestor de projetos. Para isso, será necessário usar o GitHub.
Faça um fork deste repositório para executar o trabalho.

### Gestão de Usuários
1. **Criação/Remoção de Usuários**
2. **Listagem de Usuários**
   - Não é necessário visualizar os dados de um usuário específico, apenas a listagem de todos.

### Gestão de Tarefas
1. **Criação/Remoção de Tarefas**
2. **Listagem e Visualização de Tarefas**
   - Necessário separar a listagem e visualização.

## Requisitos Técnicos
- **.NET**: Versão 6 ou 8.
- **Autenticação**: Realize autenticação na API, criando um controller de Auth para gerar um JWT.
- **Banco de Dados**: SQL Server ou MongoDB.
- **Validações**:
  - Nome: Letras apenas, máx. 50 caracteres.
  - Usuário: Alfanuméricos e ponto/underline, máx. 30 caracteres, deve iniciar com letra.
  - Título da tarefa: Máx. 50 caracteres.
  - Descrição da tarefa: Máx. 500 caracteres.
  - Datas: Cadastro e término da tarefa.
  - Usuário que adicionou a tarefa.

### Extras
- Crie testes de unidade.
- Use o pattern Command com a Lib MediatR.
- Criptografe senhas com SHA256.

## Requisitos para o trabalho
- Clique no botão "Use this template" no canto superior direito.
- Preencha as informações para criar um novo repositório baseado no template.
- No seu GitHub, acesse o novo repositório que você criou a partir do template.
- Tudo pronto. Inicie clonando o repositório.

## [Opcional] Requisitos para Publicação da Aplicação
- **CI/CD**: Configure os pipelines de CI (restore, build, testes e geração de artefato) e CD (publicação no app service do Azure).
- **Cloud**: Utilize preferencialmente Azure. Uma boa saída é utilizar a conta FREE pelo https://azure.com/free
- Usar Azure Key Vault para armazenar strings de conexão e chaves.
- Criar um serviço de autenticação separado e use mensageria (Azure Service Bus) para comunicação.
- Configurar um cache para a aplicação (em memória ou usando Azure Cache).

## Objetivos
Este desafio testa suas habilidades para resolver desafios do dia a dia como desenvolvedor .NET, abordando desde a gestão de tarefas até a publicação da aplicação na nuvem.
