# 🐾 Sistema de Caixa — Pet Shop

Projeto desenvolvido em **C#** para praticar lógica de programação, estruturas de dados e organização de código através de uma simulação de caixa de Pet Shop.

## 🎯 Objetivo

Simular o processamento de atendimentos de um Pet Shop, considerando:

* Serviços disponíveis e seus valores
* Pacotes de serviços dos pets
* Consumo de pacote
* Descontos individuais
* Cobrança dos serviços
* Serviços inexistentes
* Relatório final dos atendimentos

## ⚙️ Funcionamento

Cada atendimento é informado no formato:

```text
Pet:Serviço
```

Exemplo:

```text
Thor:Banho
Mel:Banho + Tosa
Rex:Tosa Total
```

O sistema identifica o pet e o serviço e aplica as regras correspondentes.

### 📦 Pacotes

Os pacotes possuem uma quantidade de serviços disponíveis.

Neste projeto, o pacote cobre **somente o serviço de Banho**.

Quando o pet possui saldo no pacote:

```text
Thor → Banho → PACOTE CONSUMIDO → 2 serviços restantes
```

Quando o pacote chega a zero:

```text
Thor → atendimento realizado → Banho → 0 → PACOTE ESGOTADO
```

Serviços diferentes de Banho são cobrados normalmente.

### 💰 Descontos

Alguns pets possuem descontos individuais.

Exemplo:

```text
Mel → Banho + Tosa → R$ 76,00 → desconto → 5%
```

O desconto é aplicado somente quando o serviço é pago.

### ❌ Serviço inexistente

Caso o serviço não esteja cadastrado, o atendimento é recusado:

```text
kiara → serviço indisponível → unha
```

## 📊 Relatório

Ao final, o sistema gera um resumo contendo:

```text
Atendimentos Realizados
Atendimentos Recusados
Serviços pagos
Serviços consumidos do pacote
Valor recebido
```

## 🧠 Conceitos praticados

* `Dictionary<TKey, TValue>`
* Arrays
* Métodos
* Parâmetros
* `foreach`
* `if / else`
* `ContainsKey`
* `Split()`
* Manipulação de strings
* Cálculo de porcentagem
* Acumuladores
* Validação de dados
* Separação de responsabilidades
* Organização de regras de negócio

## 🏗️ Organização

O código foi dividido em métodos com responsabilidades diferentes:

```text
SistemaCaixa()
    ↓
Processa os atendimentos

Verificar_Pacote()
    ↓
Verifica e consome o pacote quando aplicável

Resumo()
    ↓
Exibe os resultados finais
```

Essa organização foi feita com o objetivo de evitar concentrar toda a lógica em uma única função.

## 📌 Status

**Finalizado ✅**

Projeto desenvolvido para praticar lógica de programação e organização de código em C#.

> Próximo objetivo de estudo: aprofundar os recursos da linguagem e avançar para POO.
