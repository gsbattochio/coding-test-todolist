# Desafio Dotkon - ToDo List

## Descrição

Desenvolva uma aplicação em que uma pessoa possa controlar suas tarefas diárias e ter controle do que já foi concluído e o que está em andamento. O usuário precisa ver um título, descrição e data para término, e também a possibilidade de criar novas tarefas. Além do próprio usuário, outras pessoas também podem adicionar tarefas para si mesmas, mas o usuário principal não verá as tarefas das outras pessoas.

## Sumário

1. [Requisitos de Negócio](#requisitos-de-negócio)
2. [Requisitos Técnicos](#requisitos-técnicos)
3. [Requisitos de Gestão do Software](#requisitos-de-gestão-do-software)
4. [Requisitos para Publicação e Hospedagem da Aplicação](#requisitos-para-publicação-e-hospedagem-da-aplicação)
5. [Objetivos](#objetivos)
6. [Entrega](#entrega)

## Requisitos de Negócio

Antes de começar a desenvolver, é importante saber gerenciar suas atividades como desenvolvedor ou gestor de projetos. Para isso, será necessário usar o GitHub.
Faça um fork deste repositório para executar o trabalho.

### Gestão de Usuários (Feature)
1. **Criação/Remoção de Usuários (US)**
2. **Listagem de Usuários (US)**
   - Não é necessário visualizar os dados de um usuário específico, apenas a listagem de todos.

### Gestão de Tarefas (Feature)
1. **Criação/Remoção de Tarefas (US)**
2. **Listagem e Visualização de Tarefas (US)**
   - Necessário separar a listagem e visualização.

Crie tasks necessárias para executar cada uma das 4 US.

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

## Requisitos de Gestão do Software

Usando GitHub, faça um Fork desse repositório e crie um projeto chamado "Gestão de Tarefas" e organize as Issues conforme descrito. Planeje suas atividades e use o Azure Boards para gerenciar seu backlog e sprints.

## Requisitos para Publicação e Hospedagem da Aplicação

- **CI/CD**: Utilize o Azure DevOps para configurar pipelines de CI (restore, build, testes e geração de artefato) e CD (publicação no app service do Azure).
- **Hospedagem**: Publique a aplicação no App Service do Azure. Crie um resource group e um Service Plan (pode ser do plano free). Configure as strings de conexão e chaves do JWT nas configurações do App Service.

### Extras

- Use Azure Key Vault para armazenar strings de conexão e chaves.
- Crie um serviço de autenticação separado e use mensageria (Azure Service Bus) para comunicação.
- Configure um cache para a aplicação (em memória ou usando Azure Cache).

## Objetivos

Este desafio testa suas habilidades para resolver desafios do dia a dia como desenvolvedor .NET pleno, abordando desde a gestão de tarefas até a publicação da aplicação na nuvem.

## Entrega

O projeto precisa ser entregue em até 5 dias após o recebimento deste documento. Adicione o e-mail do avaliador na sua organização no Azure DevOps e na sua subscription no Azure. Não será necessário enviar código ou link da aplicação, apenas o invite para acesso.

---

Para qualquer dúvida, não hesite em chamar!
