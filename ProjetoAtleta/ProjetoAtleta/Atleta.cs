using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtleta
{
    class Atleta
    {
        public String nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public double altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public double peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public double calcularIMC()
        {
            return peso / (altura * altura);
        }
    }
}
