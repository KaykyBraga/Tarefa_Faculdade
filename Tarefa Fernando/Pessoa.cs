using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_Fernando
{
    internal class Pessoa
    {
        public string nome;        
        public int idade;

        public Pessoa(int idade,string nome)
        {
            this.idade = idade;
            this.nome = nome;
        }

        public void Apresentar()
        {
            Console.WriteLine($"\n\nOlá meu nome é {this.nome} e minha idade é {this.idade} anos.");
        }
    }
}
