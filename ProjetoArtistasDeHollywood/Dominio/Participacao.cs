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
           
           double resulDesconto = artista.cache - desconto;

           return resulDesconto;
        }


        public override string ToString()
        {
            return string.Format("{0}, Cachê: {1}, Desconto: {2}, Custo: {3}", artista.nome,artista.cache, desconto.ToString("F2", CultureInfo.InvariantCulture),custo().ToString("F2",CultureInfo.InvariantCulture));  
                
        }
    }
}
