using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ProjetoArtistasDeHollywood.Dominio
{
    class Participacao
    {
        double desconto { get; set; }
        Artista artista { get; set; }



        public Participacao(double desconto) 
        {
            this.desconto = desconto;
            
        }



        /*public double custo() 
        {


            return;
        }*/


        public override string ToString()
        {
            return desconto.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
