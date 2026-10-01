# 💳 Processador de Transações Bancárias — C#

Projeto desenvolvido em **C#** para praticar processamento de transações, validações, tratamento de exceções e manipulação de `Dictionary`.

O sistema recebe transações no formato:

```text
Nome:Operação:Valor
```

Exemplo:

```text
Adrian:PIX:500
Ana:DEBITO:150
Carlos:SAQUE:50
```

## 🎯 Objetivo

Praticar a construção de uma lógica de processamento que consiga:

* Interpretar diferentes transações;
* Validar contas existentes;
* Validar operações permitidas;
* Validar valores;
* Verificar saldo disponível;
* Tratar valores inválidos utilizando `try/catch`;
* Continuar processando as próximas transações mesmo quando uma falha acontece;
* Atualizar os saldos das contas;
* Contabilizar transações aprovadas e recusadas;
* Identificar o cliente com maior saldo ao final.

## ⚙️ Operações permitidas

O sistema aceita:

* `PIX`
* `DEBITO`
* `SAQUE`

Operações diferentes dessas são recusadas.

O sistema também aceita operações digitadas em diferentes combinações de maiúsculas e minúsculas, normalizando a entrada antes da validação.

Exemplo:

```text
Bruno:pix:400
```

é interpretado como:

```text
Bruno:PIX:400
```

## 🧠 Tratamento de erros

Valores que não podem ser convertidos para número são tratados com `try/catch`.

Exemplo:

```text
Carlos:PIX:abc
Ana:PIX:xyz
```

Essas transações são recusadas e o processamento continua normalmente.

Também são recusadas transações quando:

* A conta não existe;
* A operação não é permitida;
* O valor é menor ou igual a zero;
* O valor é maior que o saldo disponível.

## 📊 Relatório

Ao final do processamento, o sistema apresenta:

* Quantidade de transações aprovadas;
* Quantidade de transações recusadas;
* Cliente com maior saldo;
* Valor do maior saldo.

## 🛠️ Conceitos praticados

* `Dictionary<TKey, TValue>`
* Arrays
* `foreach`
* Métodos
* Parâmetros
* `if / else`
* Guard clauses / validações sequenciais
* `ContainsKey()`
* `Contains()`
* `Split()`
* `ToUpper()`
* `ToTitleCase()`
* `try / catch`
* `FormatException`
* `continue`
* Manipulação de strings
* Alteração de valores dentro de `Dictionary`
* Contadores
* Acumuladores
* Busca do maior valor sem LINQ

## 🚫 Restrições do Exercício do sistema. 

O projeto foi desenvolvido como prática de C# **sem POO e sem LINQ**, utilizando apenas os recursos estudados até o momento.

## 📈 Status

**Finalizado ✅**

Projeto desenvolvido como parte dos estudos de **C# antes de POO**, com foco em lógica de programação, tratamento de exceções e regras de negócio.
