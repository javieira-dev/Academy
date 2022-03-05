using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioVetor
{
    class Hospedagem
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Hospedagem(string nome, string email)
        {
            Name = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Name  + ", " + Email;
        }
    }
}
