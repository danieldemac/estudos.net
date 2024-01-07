using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplofundamentos.Models
{
    public class Pessoa
    {
        public Pessoa()
        {

        }
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        
        private string? _nome;
        private int _idade;
        private string _sobrenome;
        private string _nomecompleto;


        public string Nome 
        { 
           get => _nome.ToUpper();


           set
           {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
           }
        }

        public string Sobrenome 
        { 
            get => _sobrenome.ToUpper(); 
            set => _sobrenome = value;
        }

        public string NomeCompleto => $"{Nome} {Sobrenome}";

        public int Idade 
        { 
            get => _idade;
        
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Idade deve ser um valor positivo");
                }
                _idade = value;
            }
        
        }

         public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {NomeCompleto} e tenho {Idade} anos.");
        }
    }
}