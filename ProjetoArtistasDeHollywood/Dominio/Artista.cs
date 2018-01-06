using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ProjetoArtistasDeHollywood.Dominio
{
    class Artista
    {
          public int codigo { get; set; }
        public string nome { get; set; }
        public double cache{get; set;}


        public Artista(int codigo, string nome, double cache)
        {
        this.codigo=codigo;
        this.nome=nome;
        this.cache=cache;
        }



        public override string ToString()
        {
 	        return codigo
                   +", "
                   +nome
                   +", "
                   +"cachê: "
                   +cache.ToString("F2",CultureInfo.InvariantCulture);
        }

    }
}
