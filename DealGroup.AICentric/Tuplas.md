# 🚀 Introdução a Tuplas, Operador Ternário e Desconstrução em C#

## 1️⃣ Tuplas

- Tuplas são uma forma simples de **agrupar vários valores** em uma única variável, sem precisar criar uma classe.  
- Elas são úteis quando queremos retornar **vários valores de um método** sem criar objetos complexos.

### Exemplo:

```csharp
// Criando uma tupla com nome, idade e cidade
var pessoa = ("Lucas", 26, "São Paulo");

// Acessando os valores da tupla
Console.WriteLine($"Nome: {pessoa.Item1}");
Console.WriteLine($"Idade: {pessoa.Item2}");
Console.WriteLine($"Cidade: {pessoa.Item3}");

var pessoa2 = (Nome: "Maria", Idade: 25, Cidade: "Rio de Janeiro");

// Agora podemos acessar pelos nomes
Console.WriteLine($"Nome: {pessoa2.Nome}");
Console.WriteLine($"Idade: {pessoa2.Idade}");
Console.WriteLine($"Cidade: {pessoa2.Cidade}");

## 1️⃣ Tuplas
# 🚀 Tuplas, Operador Ternário e Desconstrução de Objetos em C#

Fala aí! 😎  
Nesse arquivo você vai aprender de forma **simples e prática** sobre **tuplas**, **operador ternário** e **desconstrução de objetos** no C#. Todos os exemplos são comentados pra facilitar o entendimento.

---

## 1️⃣ Tuplas

### O que é?

- Tupla é uma forma rápida de **guardar vários valores juntos** numa só variável, sem precisar criar uma classe.  
- Muito útil quando você quer **retornar vários valores de um método** sem complicação.

### Exemplo básico:

```csharp
// Criando uma tupla com nome, idade e cidade
var pessoa = ("Lucas", 26, "São Paulo");

// Acessando os valores da tupla
Console.WriteLine($"Nome: {pessoa.Item1}");
Console.WriteLine($"Idade: {pessoa.Item2}");
Console.WriteLine($"Cidade: {pessoa.Item3}");

## Tuplas nomeadas (mais legível)
var pessoa2 = (Nome: "Maria", Idade: 25, Cidade: "Rio de Janeiro");

// Acessando pelos nomes
Console.WriteLine($"Nome: {pessoa2.Nome}");
Console.WriteLine($"Idade: {pessoa2.Idade}");
Console.WriteLine($"Cidade: {pessoa2.Cidade}");

##2️⃣ Operador Ternário
O que é?

É um atalho para if/else quando a condição é simples.

Sintaxe:
condição ? valor_se_verdadeiro : valor_se_falso;
Exemplo:
int idade = 20;
string resultado = idade >= 18 ? "Maior de idade" : "Menor de idade";

Console.WriteLine(resultado); // Imprime "Maior de idade"
Ternário encadeado:
int nota = 85;
string conceito = nota >= 90 ? "A" :
                   nota >= 80 ? "B" :
                   nota >= 70 ? "C" : "D";

Console.WriteLine(conceito); // Imprime "B"
Serve pra condições rápidas, sem escrever várias linhas de if/else.

##3️⃣ Desconstrução de objetos
O que é?

Permite quebrar um objeto ou tupla em várias variáveis separadas.

Útil para extrair rapidamente valores sem precisar acessar cada propriedade manualmente.

Exemplo com tupla:
var pessoa = ("Lucas", 26, "São Paulo");

// Desconstruindo a tupla em variáveis separadas
(string nome, int idade, string cidade) = pessoa;

Console.WriteLine($"Nome: {nome}");
Console.WriteLine($"Idade: {idade}");
Console.WriteLine($"Cidade: {cidade}");

Exemplo com objeto customizado:
class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    // Método que permite desconstrução
    public void Deconstruct(out string nome, out int idade)
    {
        nome = Nome;
        idade = Idade;
    }
}

// Criando objeto
Pessoa p = new Pessoa { Nome = "Lucas", Idade = 26 };

// Desconstruindo o objeto
var (nomePessoa, idadePessoa) = p;

Console.WriteLine($"Nome: {nomePessoa}");
Console.WriteLine($"Idade: {idadePessoa}");
O método Deconstruct permite usar a sintaxe de tupla em objetos personalizados.

##4️⃣ Resumo rápido
| Conceito              | O que faz                                     | Exemplo rápido                  |
| --------------------- | --------------------------------------------- | ------------------------------- |
| **Tupla**             | Agrupa vários valores juntos                  | `(1, "Lucas")`                  |
| **Operador ternário** | Condição curta pra if/else                    | `idade>=18 ? "Maior" : "Menor"` |
| **Desconstrução**     | Quebra tupla ou objeto em variáveis separadas | `(var a, var b) = tupla`        |

##5️⃣ Dicas extras
Tuplas são ótimas pra retornar vários valores de funções sem criar classes.

Operador ternário é excelente pra decisões rápidas, mas evite linhas muito longas ou confusas.

Desconstrução deixa o código mais limpo, principalmente quando você só precisa de algumas propriedades do objeto.

Combinando os três, você consegue código mais enxuto e organizado.