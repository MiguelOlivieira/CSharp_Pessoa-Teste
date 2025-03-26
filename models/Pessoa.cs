using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.models
{
    public class Pessoa
    {
        

        //campo _nome (campos não possuem set ou get)
        private string _nome;
        
        //campo _idade
        private int _idade;

        //Propriedade Nome e Idade
        public string Nome 
        {   
            get => _nome.ToUpper(); //body expression (por ser apenas uma linha de codigo)
            
            set
            {
                if (value == ""){ //Caso o valor setado seja vazio, vai retornar a mensagem baixo como erro
                    throw new ArgumentException("O nome do usuário não pode ser vazio");
                }

                _nome = value; //propriedade private recebe o valor de Nome 
            } 
         }

        //prop simples.
        public string Sobrenome { get; set; }

        //Propriedade de leitura (somente get)
         public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        public int Idade { 
            
            get => _idade; //Por ser um numero, não vou fazer nenhum tratamento especial no get
            
            set 
            {
                if(value < 0){
                    throw new ArgumentException("A idade não pode ser menor que 0");
                }

                _idade = value;  //propriedade private recebe o valor de idade 
            }          
        }
         public void Apresentar(){
        Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade} ");
    }                                          
    }

   
}