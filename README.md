# Task Tracker

Uma aplica��o simples de rastreamento de tarefas via linha de comando, que permite aos usu�rios gerenciar suas tarefas de forma eficiente. 
A aplica��o armazena as tarefas em um arquivo JSON e oferece suporte para v�rias a��es, como adicionar, atualizar e excluir tarefas, al�m de acompanhar o status delas (a fazer, em progresso, conclu�do).

## Requisitos

A aplica��o deve ser executada pela linha de comando, aceitar a��es e entradas do usu�rio como argumentos e armazenar as tarefas em um arquivo JSON. O usu�rio deve ser capaz de realizar as seguintes a��es:

- **Adicionar**: Adicionar novas tarefas � lista.
- **Atualizar**: Atualizar a descri��o ou o status de uma tarefa existente.
- **Excluir**: Remover uma tarefa da lista.
- **Marcar como Em Progresso**: Alterar o status de uma tarefa para "em progresso".
- **Marcar como Conclu�da**: Alterar o status de uma tarefa para "conclu�da".
- **Listar todas as tarefas**: Exibir todas as tarefas.
- **Listar tarefas conclu�das**: Exibir todas as tarefas marcadas como conclu�das.
- **Listar tarefas n�o conclu�das**: Exibir todas as tarefas que n�o foram conclu�das.
- **Listar tarefas em progresso**: Exibir todas as tarefas que est�o em andamento.

## Propriedades da Tarefa

Cada tarefa na aplica��o ter� as seguintes propriedades:

- **id**: Um identificador �nico para a tarefa.
- **descri��o**: Uma breve descri��o da tarefa.
- **status**: O status da tarefa. Pode ser um dos seguintes:
  - `todo`: Tarefa ainda n�o iniciada.
  - `in-progress`: Tarefa est� em andamento.
  - `done`: Tarefa foi conclu�da.
- **createdAt**: A data e hora em que a tarefa foi criada.
- **updatedAt**: A data e hora em que a tarefa foi atualizada pela �ltima vez.

Essas propriedades s�o armazenadas em um arquivo JSON, e o arquivo � atualizado sempre que uma nova tarefa � adicionada ou uma tarefa existente � modificada.

## Uso

Para interagir com o rastreador de tarefas, voc� pode executar a aplica��o pela linha de comando e passar os argumentos necess�rios para cada a��o.
