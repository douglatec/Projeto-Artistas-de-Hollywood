using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ProjetoArtistasDeHollywood.Dominio
{
    class Participacao
    {
        public double desconto { get; set; }
        public Artista artista { get; set; }
       



        public Participacao(double desconto, Artista artista) 
        {
            this.desconto = desconto;
            this.artista = artista;           
            
        }



        public double custo()
        {          
           
           desconto = artista.cache - desconto;
            
            return desconto;
        }


        public override string ToString()
        {
            return desconto.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
