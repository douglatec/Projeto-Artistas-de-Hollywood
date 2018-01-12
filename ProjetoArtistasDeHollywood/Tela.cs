using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjetoArtistasDeHollywood.Dominio;
using System.Globalization;

namespace ProjetoArtistasDeHollywood
{
    class Tela
    {

        public static void mostrarMenu()
        {
            Console.WriteLine("MENU DO SISTEMA:");           
            Console.WriteLine("1 – Listar artistas");
            Console.WriteLine("2 – Cadastrar artista");
            Console.WriteLine("3 – Cadastrar filme");
            Console.WriteLine("4 – Mostrar dados de um filme");
            Console.WriteLine("5 – Sair");
            Console.WriteLine();
            Console.Write("Digite uma opção: ");            
        }



        public static void mostrarListaDeArtista()        
       {
           Console.WriteLine();
           Console.WriteLine("LISTAGEM DE ARTISTAS:");
        for (int i = 0; i < Program.listaDeArtista.Count;i++ )
                    {
                        Console.WriteLine(Program.listaDeArtista[i]);                        
                    }        
        }



        public static void cadastrarArtista()
    {
        Console.WriteLine();
        Console.WriteLine("Digite os dados do artista: ");
        Console.Write("Código:");
        int codigo=int.Parse(Console.ReadLine());
        Console.Write("Nome:");
        string nome = Console.ReadLine();
        Console.Write("Valor do cachê:");
        double cache = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        Artista x = new Artista(codigo,nome,cache);
        Program.listaDeArtista.Add(x);          
    }


        public static void cadastroDeFilme() 
        {
            Console.WriteLine();
            Console.WriteLine("Digite os dados do filme:");
            Console.Write("Código:");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Título:");
            string titulo = Console.ReadLine();
            Console.Write("Ano:");
            int ano = int.Parse(Console.ReadLine());
            Filme y = new Filme(codigo,titulo,ano);
            Program.ListaDeFilme.Add(y);

            Console.Write("Quantas participações tem o filme? ");
            int qteFilme = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qteFilme; i++) 
            {
                Console.WriteLine("Digite os dados da "+i+"ª participação:");
                Console.Write("Artista (código):");
                int codArtista = int.Parse(Console.ReadLine());
                int pos = Program.listaDeArtista.FindIndex(x => x.codigo == codArtista);
                if (pos == -1)
                {
                    //throw new ModelException("Codigo do produto não encontrado: " + codProduto);
                }
                Console.Write("Desconto:");
                double desconto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Participacao z = new Participacao(desconto,Program.listaDeArtista[pos]);
                y.participacao.Add(z);
            }   
        
        
        }



        public static void mostarParticipacoe() 
        {
            Console.Write("Digite o código do filme:");
            int codFilme = int.Parse(Console.ReadLine());
            int pos = Program.ListaDeFilme.FindIndex(x => x.codigo == codFilme);
            if (pos == -1) 
            {
                throw new ModelException("Codigo do filme não encontrado: " + codFilme);
            }
            Console.WriteLine(Program.ListaDeFilme[pos]);
            Console.WriteLine();      
        
        }
    }
}
