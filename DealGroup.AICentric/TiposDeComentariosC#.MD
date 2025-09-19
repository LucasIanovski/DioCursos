# Tipos de Comentários em C#

Em C#, existem três tipos principais de comentários:

## 1. Comentário de Linha Única

Utiliza `//` para comentar uma linha. Tudo após `//` na mesma linha é ignorado pelo compilador.

```csharp
// Este é um comentário de linha única
Console.WriteLine("Olá, mundo!");
```

## 2. Comentário de Múltiplas Linhas

Utiliza `/*` para iniciar e `*/` para finalizar o comentário. Pode abranger várias linhas.

```csharp
/*
Este é um comentário
de múltiplas linhas.
*/
Console.WriteLine("Exemplo");
```

## 3. Comentário de Documentação

Utiliza `///` antes de métodos, classes ou propriedades. É usado para gerar documentação automática do código.

```csharp
/// <summary>
/// Este método exibe uma mensagem.
/// </summary>
public void ExibirMensagem()
{
    Console.WriteLine("Mensagem");
}
```

Esses comentários ajudam a documentar, explicar e organizar o código, facilitando a manutenção e compreensão.
