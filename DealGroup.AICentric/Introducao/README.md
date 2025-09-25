# Métodos

- **O que é:**  
  Um método é um bloco de código que contém uma série de instruções, que pode ser reapoveitado
  em vidersos lugares.

  Ordem de um digrama: NOME => ATRIBUTOS => MÉTODOS

- **Construtores**  
  Os construtores permitem que o programador definia valores 
  padrão, limite a instanciação e grave códigos flexíveis e fáceis de ler.
  Por conversão ele deve ficar logo abaixo da nossa classe, e sempre tera o mesmo nome da nossa classe, e não possui um tipo de retorno, mas pode receber parametros, que seriam o mesmo colocamos no program
  como por exemplo nome e sobrenome.

- **Exceção**  
  Os recursos de manipulação de exceção da linguagem C# ajudam você a lidar com quaisquer situações execepicionais ou inesperadas que ocorram quando um programa for executado.

- **FILAS**

# 🚀 Introdução a Filas em C# (Queue)

## 👉 O que é uma fila?

- Imagina a fila do banco, do mercado ou até a fila do lanche 🍔.  
- Quem chega primeiro é atendido primeiro.  
- Esse esquema se chama **FIFO** (First In, First Out = Primeiro que entra, primeiro que sai).  

No C#, a classe que representa **filas** é a `Queue<T>`.  
Ela fica no namespace `System.Collections.Generic`.

---

## ⚡ Criando uma fila

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Criando uma fila de strings (pessoas na fila)
        Queue<string> fila = new Queue<string>();

        // Adicionando pessoas na fila (Enqueue = enfileirar)
        fila.Enqueue("Lucas");
        fila.Enqueue("Ana");
        fila.Enqueue("Carlos");

        Console.WriteLine("Fila atual:");
        foreach (string pessoa in fila)
        {
            Console.WriteLine(pessoa);
        }
    }
}

## SAIDA NO CONSOLE
Fila atual:
Lucas
Ana
Carlos

## TIRANDO ELEMENTOS DA FILA
// Tirando a primeira pessoa da fila (Dequeue = desenfileirar)
string atendido = fila.Dequeue();
Console.WriteLine($"\nAtendido: {atendido}");

Console.WriteLine("Fila depois do atendimento:");
foreach (string pessoa in fila)
{
    Console.WriteLine(pessoa);
}

  ## SAIDA NO CONSOLE
  Atendido: Lucas
Fila depois do atendimento:
Ana
Carlos
