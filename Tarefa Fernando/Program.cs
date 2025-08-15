
using Tarefa_Fernando;
using System;

string raKayky = "R194434";
string raInvalido = "R000000";

//Criando o objeto
Estudante aluno1 = new Estudante
    (
    nome: "Kayky braga da silva",
    idade: 19,
    ra: raKayky,
    curso: "Análise e Desenvolvimento de Sistemas"
    );

Console.WriteLine("\n\n-- Demonstração do Objeto 'Aluno1' --");

//Usando o metodo Apresentar que foi herdado da classe Pessoa
aluno1.Apresentar();

//Usado o metodo da propria classe estudante
aluno1.MostarDadosDoEstudante();

Console.WriteLine("\n\n-- Verificação de RA --");

// Usando o metodo principal que verifica o ra
// Teste 1 verificando com o seu ra correto
Console.WriteLine("\nTentativa 1 (RA correto):");

aluno1.VerificarRa(raKayky);

// Teste 2 verificando com um ra qualquer 
Console.WriteLine("\nTentativa 2 (RA incorreto):");

aluno1.VerificarRa(raInvalido);




string raLuan = "R00IE3";
//Criando o objeto
Estudante aluno2 = new Estudante
    (
    nome: "Luan Acuyo Braz",
    idade: 20,
    ra: raLuan,
    curso: "Análise e Desenvolvimento de Sistemas"
    );

Console.WriteLine("\n\n-- Demonstração do Objeto 'Aluno2' --");

//Usando o metodo Apresentar que foi herdado da classe Pessoa
aluno2.Apresentar();

//Usado o metodo da propria classe estudante
aluno2.MostarDadosDoEstudante();

Console.WriteLine("\n\n-- Verificação de RA --");

// Usando o metodo principal que verifica o ra
// Teste 1 verificando com o seu ra correto
Console.WriteLine("\nTentativa 1 (RA correto):");

aluno2.VerificarRa(raLuan);

// Teste 2 verificando com um ra qualquer 
Console.WriteLine("\nTentativa 2 (RA incorreto):");

aluno2.VerificarRa(raInvalido);




string raLeo = "G18AGI7";
//Criando o objeto
Estudante aluno3 = new Estudante
    (
    nome: "Leonardo da Silva Nunes",
    idade: 23,
    ra: raLeo,
    curso: "Análise e Desenvolvimento de Sistemas"
    );

Console.WriteLine("\n\n-- Demonstração do Objeto 'Aluno3' --");

//Usando o metodo Apresentar que foi herdado da classe Pessoa
aluno3.Apresentar();

//Usado o metodo da propria classe estudante
aluno3.MostarDadosDoEstudante();

Console.WriteLine("\n\n-- Verificação de RA --");

// Usando o metodo principal que verifica o ra
// Teste 1 verificando com o seu ra correto
Console.WriteLine("\nTentativa 1 (RA correto):");

aluno3.VerificarRa(raLeo);

// Teste 2 verificando com um ra qualquer 
Console.WriteLine("\nTentativa 2 (RA incorreto):");

aluno3.VerificarRa(raInvalido);



string raGabriel = "G799GI3";
//Criando o objeto
Estudante aluno4 = new Estudante
    (
    nome: "Gabriel Carriel Leite",
    idade: 27,
    ra: raGabriel,
    curso: "Análise e Desenvolvimento de Sistemas"
    );

Console.WriteLine("\n\n-- Demonstração do Objeto 'Aluno4' --");

//Usando o metodo Apresentar que foi herdado da classe Pessoa
aluno4.Apresentar();

//Usado o metodo da propria classe estudante
aluno4.MostarDadosDoEstudante();

Console.WriteLine("\n\n-- Verificação de RA --");

// Usando o metodo principal que verifica o ra
// Teste 1 verificando com o seu ra correto
Console.WriteLine("\nTentativa 1 (RA correto):");

aluno4.VerificarRa(raGabriel);

// Teste 2 verificando com um ra qualquer 
Console.WriteLine("\nTentativa 2 (RA incorreto):");

aluno4.VerificarRa(raInvalido);


string raBruno = "R197263";
//Criando o objeto
Estudante aluno5 = new Estudante
    (
    nome: "Bruno Minitti Tardelli",
    idade: 23,
    ra: raBruno,
    curso: "Análise e Desenvolvimento de Sistemas"
    );

Console.WriteLine("\n\n-- Demonstração do Objeto 'Aluno5' --");

//Usando o metodo Apresentar que foi herdado da classe Pessoa
aluno5.Apresentar();

//Usado o metodo da propria classe estudante
aluno5.MostarDadosDoEstudante();

Console.WriteLine("\n\n-- Verificação de RA --");

// Usando o metodo principal que verifica o ra
// Teste 1 verificando com o seu ra correto
Console.WriteLine("\nTentativa 1 (RA correto):");

aluno5.VerificarRa(raBruno);

// Teste 2 verificando com um ra qualquer 
Console.WriteLine("\nTentativa 2 (RA incorreto):");

aluno5.VerificarRa(raInvalido);