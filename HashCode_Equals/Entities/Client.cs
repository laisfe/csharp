using System;
using System.Collections.Generic;
using System.Text;

namespace HashCode_Equals.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is Client))
            {
                return false;
            }
            Client other = obj as Client;

            //o critério usado para definir se os objetos sao iguais ou não será o email
            return Email.Equals(other.Email);
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
