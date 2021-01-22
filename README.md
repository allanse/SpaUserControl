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