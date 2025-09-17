# Estrutura de um Programa C#

## Arquivos de projeto

### 1. `.csproj` — Arquivo de Projeto C#

- **O que é:**  
  É um arquivo XML que descreve as configurações específicas do seu projeto C#. Ele define como seu projeto será compilado, quais dependências ele tem, versões, propriedades de build, referências a bibliotecas, entre outras informações técnicas.

- **Quando mexer:**  
  - Quando precisar adicionar, atualizar ou remover **pacotes NuGet** (bibliotecas externas).  
  - Para configurar **opções de compilação**, como definir o **framework alvo** (ex: .NET 8, .NET Core, .NET Framework).  
  - Para adicionar **arquivos ou recursos específicos** ao projeto que não estão sendo detectados automaticamente.  
  - Ajustar configurações de **debug** ou publicação.

- **Por que serve:**  
  Garante que o projeto seja construído da maneira correta, com todas as referências e configurações necessárias para rodar ou ser publicado.

---

### 2. `.sln` — Arquivo de Solução

- **O que é:**  
  Arquivo que agrupa um ou mais projetos (.csproj, por exemplo) em uma solução maior. Ele organiza vários projetos relacionados (como um backend, frontend, biblioteca compartilhada, etc) dentro de um único ambiente.

- **Quando mexer:**  
  - Geralmente, você não edita esse arquivo manualmente, pois o Visual Studio ou VS Code cuidam disso automaticamente.  
  - Se precisar adicionar, remover ou reorganizar projetos dentro da solução, isso pode ser feito via IDE e refletido no arquivo `.sln`.  
  - Quando estiver trabalhando com soluções grandes que possuem muitos projetos dependentes entre si.

- **Por que serve:**  
  Permite gerenciar facilmente projetos relacionados, facilitando o desenvolvimento em equipe, testes integrados e organização do código.

---

### 3. **Arquivos `.cs` — Código Fonte C#**

- **O que é:**  
  Arquivos que contêm o código-fonte em C#. Aqui é onde você escreve suas classes, métodos, lógica de negócio, interfaces e tudo que constitui seu programa.

- **Quando mexer:**  
  - Sempre que for implementar, corrigir ou modificar qualquer funcionalidade do seu programa.  
  - Criar novas classes, métodos, propriedades, ou estruturas de dados.  
  - Corrigir bugs ou melhorar o desempenho do código.

- **Por que serve:**  
  É o coração do seu programa, onde a lógica e funcionalidades realmente são implementadas.

---

### 4. **Outros arquivos importantes:**

- `.config` / `appsettings.json` — Arquivos de configuração onde você pode definir parâmetros que seu programa vai usar, como strings de conexão, URLs, chaves, etc. Você mexe aqui para ajustar comportamento sem alterar código.

- `.resx` — Arquivos de recursos para armazenar textos, imagens, e dados que podem ser usados para internacionalização (suporte a vários idiomas).

---

## Quando mexer em cada arquivo?

| Arquivo     | Quando mexer?                            | Propósito principal                      |
|-------------|-----------------------------------------|-----------------------------------------|
| `.csproj`   | Configurar projeto, dependências, build| Definir como o projeto é compilado      |
| `.sln`      | Organizar vários projetos juntos        | Gerenciar solução com múltiplos projetos|
| `.cs`       | Implementar/modificar código-fonte      | Escrever a lógica e funcionalidades     |
| `.config`   | Ajustar parâmetros de configuração      | Configurar comportamento sem recompilar |

---


**Negrito**, *Itálico*, ~~Riscado~~

[Link para o Google](https://google.com)
