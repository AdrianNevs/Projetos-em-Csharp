# 🐾 Desafio — Gerenciamento de Pacotes | C#

## 📌 Sobre o projeto

Este projeto é um exercício de lógica desenvolvido em **C#**, simulando o gerenciamento de pacotes de serviços de um Pet Shop.

O objetivo é praticar o uso de **Dictionary**, estruturas de repetição, condicionais, atualização de dados e criação de funções para processar atendimentos.

## 🎯 Objetivo

O sistema recebe uma lista de atendimentos e verifica, para cada pet, se existe um pacote com serviços disponíveis.

Quando um atendimento é realizado:

* 1 serviço é consumido do pacote;
* a quantidade restante é atualizada;
* o atendimento é contabilizado;
* quando o pacote chega a `0`, o sistema informa que ele foi esgotado.

Caso o pet não possua mais serviços disponíveis, o atendimento é recusado.

## 🧠 Lógica utilizada

O sistema trabalha principalmente com dois `Dictionary`:

```csharp
Dictionary<string, int> dicPacotes
```

Armazena o pet e a quantidade de serviços disponíveis.

Exemplo:

```text
Thor → 3
Mel → 1
Rex → 0
```

E:

```csharp
Dictionary<string, int> dicAtendimento
```

Registra quantos atendimentos foram realizados por cada pet.

## ⚙️ Funcionamento

Para cada atendimento, o sistema:

1. Identifica o pet.
2. Consulta a quantidade de serviços disponíveis.
3. Verifica se existe serviço disponível.
4. Consome um serviço.
5. Atualiza o `Dictionary`.
6. Registra o atendimento realizado.
7. Informa quando o pacote fica esgotado.
8. Recusa o atendimento caso não existam serviços disponíveis.

Ao final, o sistema apresenta um resumo contendo:

* Pet com maior consumo;
* quantidade de serviços consumidos;
* total de serviços realizados.

## 💻 Exemplo

Entrada:

```text
Thor
Rex
Thor
Mel
Thor
Bob
Rex
Luna
Mel
```

Saída esperada:

```text
Thor → atendimento realizado → 2 serviços restantes
Rex → atendimento recusado → pacote esgotado
Thor → atendimento realizado → 1 serviços restantes
Mel → atendimento realizado → 0 serviços restantes → PACOTE ESGOTADO
Thor → atendimento realizado → 0 serviços restantes → PACOTE ESGOTADO
Bob → atendimento realizado → 1 serviços restantes
Rex → atendimento recusado → pacote esgotado
Luna → atendimento realizado → 4 serviços restantes
Mel → atendimento recusado → pacote esgotado

==== RESUMO ====

Maior consumo: Thor → 3 serviços
TOTAL DE SERVIÇOS REALIZADOS = 6
```

## 📚 Conceitos praticados

* `Dictionary<TKey, TValue>`
* `ContainsKey()`
* Inserção e atualização de valores
* `for`
* `foreach`
* `if / else`
* Funções
* Parâmetros
* Contadores
* Acumuladores
* Controle de estado
* Processamento de dados
* Regras de negócio

## 🚀 Objetivo do exercício

Este projeto faz parte da prática de lógica de programação em C# e serve como preparação para projetos maiores, principalmente sistemas que trabalham com **cadastros, serviços, pacotes, atendimentos e regras de negócio**.

O próximo passo é aplicar esses conceitos em projetos mais completos utilizando **POO e classes**.
