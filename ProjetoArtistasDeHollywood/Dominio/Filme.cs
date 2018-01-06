using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoArtistasDeHollywood.Dominio
{
    class Filme
    {
        public int codigo { get; set; }
        public string titulo { get; set; }
        public int ano { get; set; }


        public Filme(int codigo, string titulo, int ano) 
        {
            this.codigo = codigo;
            this.titulo = titulo;
            this.ano = ano;        
        }

       /* public double custoTotal() 
        {
        
        
        
        }*/


    }
}
