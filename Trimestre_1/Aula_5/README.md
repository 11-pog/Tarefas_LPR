# Instruções

- No seu repositório público no GitHub
“Tarefas_LPR”, crie uma pasta chamada
“Aula5”. Dentro dessa pasta você deve
inserir os códigos dos exercícios a
seguir.
- São 5 exercícios. Resolva 2 em C# e 3
em C++, ou 3 em C# e 2 em C++ (você
pode escolher quais exercícios serão
resolvidos com cada linguagem).

## Exercício 1 - WHILE

Construa um algoritmo que calcule a
média aritmética de um conjunto de números
pares fornecidos pelo usuário. O usuário deve
fornecer primeiro a quantidade de números que
serão digitados, e em seguida, os números
considerados na média. O usuário pode digitar
números ímpares, que devem ser ignorados.
Por exemplo, no caso da tabela abaixo, o 5
informa que serão digitados 5 números (2 7 8 6
10), e para a média devem ser considerados
apenas os números pares (2, 8, 6 e 10)
ignorando o número 7 digitado.

![Exercicio 1](Exer1.png)

## Exercício 2 - DO WHILE

Construa um algoritmo de adivinhação
de números. Com as linhas abaixo, o algoritmo
gerará um número inteiro aleatório de 1 a 100:

    (C#)
    Random numAleatorio = new Random();
    int valorInteiro = numAleatorio.Next(1,100);

    (C++)
    random_device numAleatorio ;
    uniform_int_distribution<> distribuicao(1,100);
    int valorInteiro = distribuicao(numAleatorio);
    
O seu trabalho é elaborar um algoritmo em que o
usuário possa digitar números no console até
acertar o número inteiro aleatório valorInteiro, de 1 a
100. A cada chute, o programa deve responder com
“chutou alto”, “chutou baixo” ou “acertou”. Após
acertar, deve ser mostrado quantas tentativas foram
usadas para descobrir o número.

## Exercício 3 - FOR

Elabore um algoritmo que calcule a
soma de todos os números ímpares
múltiplos de 3 que se encontrem no
conjunto dos números de 50 a 500

![Exercicio 3](Exer3.png)

## Exercício 4 - ESCOLHA A MELHOR ESTRUTURA DE REPETIÇÃO

Solicite ao usuário para inserir
um número e calcule a soma dos dígitos do
quadrado desse número. Por exemplo, se o
número fornecido for 123, calcule 123² =
15129 e então a soma dos seus dígitos: 1 +
5 + 1 + 2 + 9 = 18.

![Exercicio 4](Exer4.png)

## Exercício 5 - ESCOLHA A MELHOR ESTRUTURA DE REPETIÇÃO

Crie um programa que simula
o treinamento de um Jedi. O usuário deve
inserir o número de horas de treinamento
por dia. O programa deve calcular o total
de horas de treinamento em uma semana,
desconsiderando sábados e domingos, e
informar quantos dias, semanas e meses
seriam necessários para alcançar o total de
1000 horas de treinamento. Considere 1
mês = 4,5 semanas.
