using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ProjetoArtistasDeHollywood.Dominio
{
    class Filme
    {
        public int codigo { get; set; }
        public string titulo { get; set; }
        public int ano { get; set; }
        public List<Participacao> participacao;



        public Filme(int codigo, string titulo, int ano) 
        {
            this.codigo = codigo;
            this.titulo = titulo;
            this.ano = ano; 
            participacao=new List<Participacao>();
        }

       
        public double custoTotal() 
        {
            double soma = 0.0;
            for (int i = 0; i < participacao.Count; i++) 
            {
                soma = soma + participacao[i].custo();
            
            }
                return soma;
        }




        public override string ToString()
        {
            string s ="Filme: " + codigo
                + ", "
                + "Titulo: " + titulo
                + ", "
                + "Ano :" + ano + "\n"
                + "Participações:\n";

                for(int i=0;i<participacao.Count;i++)
                {
                    s = s + participacao[i] + "\n";
                }
                s = s + "Custo total do filme:" + custoTotal().ToString("F2", CultureInfo.InvariantCulture);
                return s;               
        }
    }
}
