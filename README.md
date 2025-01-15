# Task Tracker

Uma aplicação simples de rastreamento de tarefas via linha de comando, que permite aos usuários gerenciar suas tarefas de forma eficiente. 
A aplicação armazena as tarefas em um arquivo JSON e oferece suporte para várias ações, como adicionar, atualizar e excluir tarefas, além de acompanhar o status delas (a fazer, em progresso, concluído).

## Requisitos

A aplicação deve ser executada pela linha de comando, aceitar ações e entradas do usuário como argumentos e armazenar as tarefas em um arquivo JSON. O usuário deve ser capaz de realizar as seguintes ações:

- **Adicionar**: Adicionar novas tarefas à lista.
- **Atualizar**: Atualizar a descrição ou o status de uma tarefa existente.
- **Excluir**: Remover uma tarefa da lista.
- **Marcar como Em Progresso**: Alterar o status de uma tarefa para "em progresso".
- **Marcar como Concluída**: Alterar o status de uma tarefa para "concluída".
- **Listar todas as tarefas**: Exibir todas as tarefas.
- **Listar tarefas concluídas**: Exibir todas as tarefas marcadas como concluídas.
- **Listar tarefas não concluídas**: Exibir todas as tarefas que não foram concluídas.
- **Listar tarefas em progresso**: Exibir todas as tarefas que estão em andamento.

## Propriedades da Tarefa

Cada tarefa na aplicação terá as seguintes propriedades:

- **id**: Um identificador único para a tarefa.
- **descrição**: Uma breve descrição da tarefa.
- **status**: O status da tarefa. Pode ser um dos seguintes:
  - `todo`: Tarefa ainda não iniciada.
  - `in-progress`: Tarefa está em andamento.
  - `done`: Tarefa foi concluída.
- **createdAt**: A data e hora em que a tarefa foi criada.
- **updatedAt**: A data e hora em que a tarefa foi atualizada pela última vez.

Essas propriedades são armazenadas em um arquivo JSON, e o arquivo é atualizado sempre que uma nova tarefa é adicionada ou uma tarefa existente é modificada.

## Uso

Para interagir com o rastreador de tarefas, você pode executar a aplicação pela linha de comando e passar os argumentos necessários para cada ação.
