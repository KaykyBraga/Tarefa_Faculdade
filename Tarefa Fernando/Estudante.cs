using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_Fernando
{
    internal class Estudante : Pessoa
    {
        string ra;
        string curso;
        public Estudante(string nome, int idade, string ra, string curso) : base(idade, nome)
        {
            this.ra = ra;
            this.curso = curso;
        }

        public bool VerificarRa(string raParaVerificar)
        {
            if (this.ra == raParaVerificar)
            {
                Console.WriteLine($"\nConfirmado o RA {this.ra} pertence a {this.nome}.");
                return true;
            }
            else
            {
                Console.WriteLine($"\nAtenção o RA {raParaVerificar} não pertence a {this.nome}.");
                return false;
            }
        }

        public void MostarDadosDoEstudante()
        {
            Console.WriteLine($"\n\n-- Dados do aluno -- \n Nome: {this.nome}\n Idade: {this.idade}\n RA: {this.ra}\n Curso: {this.curso}");
        }
    }
}
