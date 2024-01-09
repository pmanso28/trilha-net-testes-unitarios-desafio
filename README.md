# DIO - Trilha .NET - Testes Unitários com C#
www.dio.me

**Languages** <br>
- [Português](#português)  <br>
- [English](#english)

### Português

## Aviso
O projeto original (que recebeu o fork) estava em .NET 6.0 e no momento não sei atualizá-lo para 8.0, mas assim que aprender assim o farei.

## Desafio de projeto
Atividade de projeto de teste unitário feita como parte do Decola Tech Avanade 2024.

## Contexto
Você está trabalhando em um sistema, e seus gestores relataram que frequentemente há problemas no software: bugs, funcionalidades que estavam funcionando de repente não funcionam mais, problemas de validações, entre outros. Os clientes já começam a duvidar da qualidade do código.

Feito isso, você sugeriu a implementação de testes unitários: escrever testes cobrindo as partes mais críticas do sistema, com cenários positivos e negativos, a fim de ter uma rastreabilidade e controle do código, melhorando assim a qualidade desse sistema.

Os gestores aceitaram a sua ideia, e com isso, você precisa implementar testes unitários no sistema.

## Premissas
O sistema hoje possui dois projetos: um do tipo console, e um do tipo testes com **xUnit**. O projeto do tipo console possui duas classes em que são realizadas as lógicas principais: **ValidacoesLista** e **ValidacoesString**. Essas classes contém métodos em comum que são usados para realizar diversas validações em determinados cenários.

O projeto de testes possui as classes de teste **ValidacoesListaTests** e **ValidacoesStringTests**, assim como seus métodos para validar o projeto do tipo console, porém estão incompletos. 

O seu objetivo é implementar os métodos de testes contidos no projeto.

## Projeto Console, suas classes e métodos

Essas são as classes do projeto console, onde fica a principal lógica do sistema.

**Classe ValidaçõesLista**

Classe responsável por realizar diversas validações envolvendo listas.

| Classe          | Método                       | Objetivo                                                                                                                |
|---------------- |------------------------------|-------------------------------------------------------------------------------------------------------------------------|
| ValidacoesLista | RemoverNumerosNegativos      | Recebe uma lista de números inteiros e retorna uma nova lista, apenas com os números positivos                          |
| ValidacoesLista | ListaContemDeterminadoNumero | Recebe uma lista de números inteiros e verifica se um determinado número está presente dentro dessa lista               |
| ValidacoesLista | MultiplicarNumerosLista      | Recebe uma lista de números inteiros e retorna uma nova lista, com seus valores múltiplicados por um determinado número |
| ValidacoesLista | RetornarMaiorNumeroLista     | Recebe uma lista de números inteiros e retorna o maior número entre eles                                                |
| ValidacoesLista | RetornarMenorNumeroLista     | Recebe uma lista de números inteiros e retorna o menor número entre eles                                                |

**Classe ValidacoesString**

Classe responsável por realizar diversas validações envolvendo strings.

| Classe           | Método                       | Objetivo                                                                                                                
|------------------|------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------|
| ValidacoesString | RetornarQuantidadeCaracteres | Recebe um texto qualquer e retorna a quantidade de caracteres presentes no texto                                                                           |
| ValidacoesString | ContemCaractere              | Recebe um texto qualquer e um texto a ser procurado, retorna verdadeiro ou falso se um determinado trecho procurado está presente no texto                 |
| ValidacoesString | TextoTerminaCom              | Recebe um texto qualquer e um trecho a ser procurado, retorna verdadeiro ou falso se um determinado trecho procurado está presente no final do texto apenas |

## Projeto do tipo teste, suas classes e métodos

**Classe ValidacoesListaTests**

Classe responsável por realizar os testes da classe ValidacoesLista.

| Classe               | Método de teste                               | Resultado esperado do teste
|----------------------|-----------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------|
| ValidacoesListaTests | DeveRemoverNumerosNegativosDeUmaLista         | Ao passar uma lista com diversos números, incluindo positivos e negativos, deve ser retornado uma nova lista apenas com números positivos  |
| ValidacoesListaTests | DeveConterONumero9NaLista                     | Ao passar uma lista com diversos números, incluindo o número 9, deve retornar verdadeiro, pois encontrou o 9 na lista                      |
| ValidacoesListaTests | NaoDeveConterONumero10NaLista                 | Ao passar uma lista com diversos números, mas sem o número 10, deve retornar falso, pois não encontrou o 10 na lista                       |
| ValidacoesListaTests | DeveMultiplicarOsElementosDaListaPor2         | Ao passar uma lista de inteiros, deve retornar uma nova lista, com todos os elementos da lista multiplicados por 2                         |
| ValidacoesListaTests | DeveRetornar9ComoMaiorNumeroDaLista           | Ao passar uma lista de números inteiros, sendo o maior deles 9, deve retornar o 9 como maior elemento dentro dessa lista                   |
| ValidacoesListaTests | DeveRetornarOitoNegativoComoMenorNumeroDaList | Ao passar uma lista de números inteiros, sendo o menor deles -8, deve retornar o -8 como menor elemento dentro dessa lista                 |

**Classe ValidacoesStringTests**

Classe responsável por realizar os testes da classe ValidacoesString.

| Classe                | Método de teste                                  | Resultado esperado do teste
|---------------------- |--------------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| ValidacoesStringTests | DeveRetornar6QuantidadeCaracteresDaPalavraMatrix | Ao passar um texto escrito a palavra "Matrix", deve retornar o número 6, representando 6 caracteres presentes na palavra                                                                         |
| ValidacoesStringTests | DeveContemAPalavraQualquerNoTexto                | Ao passar um texto escrito "Esse é um texto qualquer" e procurar pela palavra "qualquer", deve retornar verdadeiro pois a palavra existe no texto                                                |
| ValidacoesStringTests | NaoDeveConterAPalavraTesteNoTexto                | Ao passar um texto escrito "Esse é um texto qualquer" e procurar pela palavra "teste", deve retornar falso pois a palavra não existe no texto                                                    |
| ValidacoesStringTests | TextoDeveTerminarComAPalavraProcurado            | Ao passar um texto escrito "Começo, meio e fim do texto procurado" e procurar pela palavra "procurado", deve retornar verdadeiro pois a palavra existe no texto e está inclusa no final do texto |

## Estrutura do projeto

O projeto está estruturado da seguinte maneira:

![Métodos Swagger](Imagens/projeto.png)


## Solução
Além de dois exemplos de testes, nenhum deles funcionou de imediato e teve que ser corrigido de uma forma ou de outra, utilizando os conceitos das aulas.

### English

## Notice
The original project (which received the fork) was in .NET 6.0 and at the moment I don't know how to update it to 8.0, but as soon as I learn so I will do so.

## Project challenge
This unit testing programming project was made as part of the Decola Tech Avanade 2024 course's set of projects.

## Context
You are working on a system, and your managers have reported that there are often problems with the software: bugs, features that were working suddenly no longer work, validation problems, among others. Customers already started to doubt the quality of the code.

With this, you suggested implementing unit tests: writing tests covering the most critical parts of the system, with positive and negative scenarios, in order to have traceability and control of the code, thus improving the quality of that system.

The managers accepted your idea, and with that, you need to implement unit tests in the system.

## Premises
The system today has two projects: um of the console type, and one of the testing type whith **xUnit**. the console type project has two classes in which the main logic is carried out: **ValidacoesLista** and **ValidacoesString**. These classes contain common methods that are used to perform various validations in certain scenarios.

The testing type project contains two testing classes, **ValidacoesListaTests** and **ValidacoesStringTests**, as well as their methods to validate the console type project, but they're incomplete. 

Your objective is to implement the testing methods contained in the project.

## Console Project, it's classes and methods

Those are the console project's classes, where the mais system logic is located.

**ValidaçõesLista Class**

Class responsible for performing various validations involving lists.


| Class           | Method                       | Objective                                                                                                               |
|---------------- |------------------------------|-------------------------------------------------------------------------------------------------------------------------|
| ValidacoesLista | RemoverNumerosNegativos      | Receives a list of integers and returns a new list, with only positive numbers                                          |
| ValidacoesLista | ListaContemDeterminadoNumero | Receives a list of integers and checks if a given number is present within that list                                    |
| ValidacoesLista | MultiplicarNumerosLista      | Receives a list of integers and returns a new list, with their values ​​multiplied by a given number                      |
| ValidacoesLista | RetornarMaiorNumeroLista     | Receives a list of integers and returns the highest number among them                                                   |
| ValidacoesLista | RetornarMenorNumeroLista     | Receives a list of integers and returns the smallest number among them                                                  |

**ValidacoesString Class**

Class responsible for performing various validations involving strings.

| Class            | Method                       | Objective                                                                                                                
|------------------|------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------|
| ValidacoesString | RetornarQuantidadeCaracteres | Receives a string and returns the number of characters present in the string                                                                               |
| ValidacoesString | ContemCaractere              | Receives a string and a text to be searched for, returns true or false if a particular searched part is present in the string                              |
| ValidacoesString | TextoTerminaCom              | Receives a string and a text to be searched for, returns true or false if a particular searched part is present at the end of the string                   |

## Testing Project, it's classes and methods

**ValidacoesListaTests Class**

Class responsible of performing the tests on the ValidacoesLista class.

| Class                | Testing Method                                | Expected test outcomes
|----------------------|-----------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------|
| ValidacoesListaTests | DeveRemoverNumerosNegativosDeUmaLista         | When passing a list with several numbers, including positive and negative, a new list with only positive numbers should be returned        |
| ValidacoesListaTests | DeveConterONumero9NaLista                     | When passing a list with several numbers, including the number 9, it should return true, as it found 9 in the list                         |
| ValidacoesListaTests | NaoDeveConterONumero10NaLista                 | When passing a list with several numbers, but without the number 10, it should return false, as it did not find 10 in the list             |
| ValidacoesListaTests | DeveMultiplicarOsElementosDaListaPor2         | When passing a list of integers, it should return a new list, with all elements in the list multiplied by 2                                |
| ValidacoesListaTests | DeveRetornar9ComoMaiorNumeroDaLista           | When passing a list of integers, the highest value of which is 9, 9 should be returned as the highest element within that list             |
| ValidacoesListaTests | DeveRetornarOitoNegativoComoMenorNumeroDaList | When passing a list of integers, the lowest value of which is -8, -8 should be returned as the lowest element within that list             |

**ValidacoesStringTests Class**

Class responsible of performing the tests on the ValidacoesString class.

| Class                 | Testing Method                                   | Expected test outcomes
|---------------------- |--------------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| ValidacoesStringTests | DeveRetornar6QuantidadeCaracteresDaPalavraMatrix | When passing a written text the word "Matrix", the number 6 should be returned, representing the 6 characters present in the word                                                                            |
| ValidacoesStringTests | DeveContemAPalavraQualquerNoTexto                | When passing a text written "Esse é um texto qualquer" and searching for the word "qualquer", it should return true because the word exists in the text                                                      |
| ValidacoesStringTests | NaoDeveConterAPalavraTesteNoTexto                | When passing a text written "Esse é um texto qualquer" and searching for the word "teste", it should return false as the word does not exist in the text                                                     |
| ValidacoesStringTests | TextoDeveTerminarComAPalavraProcurado            | When passing a text written "Começo, meio e fim do texto procurado" and searching for the word "procurado", it should return true because the word exists in the text and is included at the end of the text |

## Structure of the project

The project is structured as seen below:

![Métodos Swagger](Imagens/projeto.png)


## Solution
Apart from two example tests, none of them worked right away and had to be fixed in one way or another, using the concepts from the classes.
