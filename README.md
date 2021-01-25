# SpaUserControl
Hands ON do curso do Balta de Back Ends robustos no Youtube

## Aula 1
- Criação da solução em branco;
- Criação do projeto Domain e da pasta Models onde serão criadas as "entidades";
- Adição do Projeto ConsoleApp1 apenas para realizar algumas demontrações de conceitos e depois o projeto será deletado;
- Criação da Classe User;
- Proteção da classe User usando private nos "sets";
- Criação do método SetPassword;
- Criação do projeto Common;
- Criação da Pasta Validadtion;
- Criação da Classe AssertionConcern;
  - Nesse item foi necessário pegar o fonte no github do projeto disponibilizado pelo Balta e copiar os dados;
- Uso dos métodos da classe AssertionConcern para validar o password;
- Criação da classe PasswordAssertionConcern que tem um método para criptografar o password;
  - Nesse item foi necessário pegar o fonte no github do projeto disponibilizado pelo Balta e copiar os dados;
 - Criação da pasta Resources no projeto Common;
 - E adição de um resource para poder globalizar as mensagens exibidas ao usuário;
 - Criação dos métodos ResetPassword, changename e Validate;
 - Criação da Classe EmailAssertionConcern;
 - Criação de um novo resouce para as mensagems em pt-BR;
 - Adição de regions na classe User;
 - Uso do Guid para atribuição de ID no construtor da classe User;



## Aula 2

- Criação das pastas Contracts, "Contracts\Repositories" e da interface IUserRepository ;
- Criação do projeto SpaUserControl.Infraestructure;
- Instalação do EntityFramework no projeto SpaUserControl.Infraestructure via Package Manager Console;
- Criação da pasta Data e da classe AppDataContext (que herda de DBContext);
- Criação da classe UserMap para mapear o bd que será criado pelo Entity Framework;
- Criação da Pasta Repositories no projeto SpaUserControl.Infraestructure e da clase UserRepository;
- Implementação da classe UserRepository;
- Preparação do Console Application para testar o repositorio - Instalção do Entity e adição da connection string;
- Criação do BD usando o Migrations;
- Validação das implementações usando o ConsoleApp;



## Aula 3

- Explicação sobre injeção de dependencia;
- Alteração na UserRepository para exigir um contexto quando instanciarem a classe;
- Criação do projeto Startup e instalação do Unity nesse projeto.
- Criação da classe DependencyResolver;
- Implementação da classe e set das referencias para os projetos com dependencia (Infra e Domain);



## Aula 4

- Business;

- Criação da interface IUserService (SpaUserControl.Domain.Contracts.Services);

- Implementação da interface;

  - Nesse item foi necessário pegar o fonte no github do projeto disponibilizado pelo Balta e copiar os dados;

- Criação do projeto Business;

- Criação da classe UserService;

- Implementação da classe UserService;

  

