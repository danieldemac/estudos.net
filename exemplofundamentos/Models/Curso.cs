using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplofundamentos.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        //Adicionar Aluno
        {
            Alunos.Add(aluno);

        }

        public int ObterQuantidadeDeAlunosMatriculados()
        //Quantidade de Alunos
        {   
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        //Remover Aluno
        {
            return Alunos.Remove(aluno);
            

        }

        

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de Ingles: ");
            foreach (Pessoa aluno in Alunos)
            {
               Console.WriteLine(aluno.NomeCompleto+$": {aluno.Idade} anos."); 
            }
        }

    }










}