using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjetoArtistasDeHollywood.Dominio;

namespace ProjetoArtistasDeHollywood
{
    class Program
    {
        public static List<Artista> listaDeArtista = new List<Artista>();
        public static List<Filme> ListaDeFilme = new List<Filme>();
        public static List<Participacao> listaDeParticipacoes = new List<Participacao>();



        static void Main(string[] args)
        {
            int opcao = 0;
          
            
            listaDeArtista.Add(new Artista(101, "Scarlett Johansson", 4000000.00));
            listaDeArtista.Add(new Artista(102, "Chris Evans", 2500000.00));
            listaDeArtista.Add(new Artista(103, "Robert Downey Jr.", 3000000.00));
            listaDeArtista.Add(new Artista(104, "Morgan Freeman", 4000000.00));
            //listaDeArtista.Sort();


            

            while (opcao != 5)
            {
                Console.Clear();
                Tela.mostrarMenu();

                try
                {
                    opcao = int.Parse(Console.ReadLine());
                }
                catch (Exception e) 
                {
                    Console.WriteLine("Erro inexperado: " + e.Message);
                    opcao = 0;
                }



                if (opcao == 1)
                {
                    Tela.mostrarListaDeArtista();                   

                }
                else if (opcao == 2)
                {
                    try
                    {
                        Tela.cadastrarArtista();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erro Inexperado: " + e.Message);
                    }
                }

                else if (opcao == 3)
                {
                    try
                    {
                        Tela.cadastroDeFilme();
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("Erro Inexperado: " + e.Message);
                    }
                }
                else if (opcao == 4)
                {
                    try
                    {
                        Tela.mostarParticipacoe();
                    }
                    catch (ModelException e)
                    {
                        Console.WriteLine("Erro de Negocio: " + e.Message);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erro Inexperado: " + e.Message);
                    }
                }
                else if (opcao == 5)
                {
                    Console.Write("Fim de Programa!");
                }
                else
                {
                    Console.WriteLine("Opção Invalida!");
                }

                Console.ReadLine();
                            


            }           

            
        }
    }
}
