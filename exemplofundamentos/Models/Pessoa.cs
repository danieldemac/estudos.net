using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplofundamentos.Models
{
    public class Pessoa
    {
        
        private string? _nome;
        private int _idade;


        public string Nome 
        { 
           get
           {

                return _nome.ToUpper();

           }

           set
           {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
           }
        }


        public int Idade 
        { 
            get
            {
                return _idade;
            }
        
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Idade deve ser maior que zero");
                }
                _idade = value;
            }
        
        }

        public Pessoa(string nome, int idade)
        {
            _nome = nome ?? throw new ArgumentNullException(nameof(nome), "O nome não pode ser nulo");
            Idade = idade;
        }
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}